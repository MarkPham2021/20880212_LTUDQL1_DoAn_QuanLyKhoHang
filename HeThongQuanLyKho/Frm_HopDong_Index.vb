Public Class Frm_HopDong_Index
    Dim isClosed As Boolean = True
    Dim dshopdong, dskhachhang, dsmathang, dsphuongthuctinhtien, dscthopdong, dscthdcautruc As DataTable
    Dim hopdongv As DataGridViewRow
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu()
    Private Sub Frm_HopDong_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuDgvDsHopDong()
        DinhdangdgvDSHopDong()
        TaiDuLieuCTHopDong()
    End Sub
    Private Sub Frm_HopDong_Index_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isClosed Then
            Dim dialogResult As DialogResult
            dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                isClosed = True
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        TaiDuLieuDgvDsHopDong()
        DinhdangdgvDSHopDong()
        TaiDuLieuCTHopDong()
    End Sub
    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim mh As Frm_HopDong_Action = New Frm_HopDong_Action()
        mh.WindowState = FormWindowState.Maximized
        mh.LoaiHanhDong = 1
        mh.HopDong = New DataGridViewRow
        mh.ShowDialog()
    End Sub
    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        If IsNothing(hopdongv) Then
            MessageBox.Show("Vui lòng chọn hợp đồng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim mh As Frm_HopDong_Action = New Frm_HopDong_Action()
            mh.WindowState = FormWindowState.Maximized
            mh.LoaiHanhDong = 2
            mh.HopDong = hopdongv
            mh.ShowDialog()
        End If

    End Sub
    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim xacnhan As DialogResult
        xacnhan = MessageBox.Show("Bạn chắc chắn muốn xóa hợp đồng được chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If xacnhan = DialogResult.Yes Then
            Dim mahopdong = Integer.Parse(txb_ma.Text)
            If CoTheXoaHopDong(mahopdong) Then
                Dim pkclms(1) As DataColumn
                pkclms(0) = dshopdong.Columns(0)
                dshopdong.PrimaryKey = pkclms
                Dim hopdong = dshopdong.Rows.Find(mahopdong)
                hopdong.Item("hd_daxoa") = 1
                hopdong.Item("hd_thoidiemcapnhat") = DateTime.Now
                xl_dulieu.GhiDuLieuTuDo("select h.hd_ma,h.hd_ngayhopdong,h.hd_ngaybatdau,h.hd_ngayhethan,h.hd_soluongmathang,h.hd_cohieuluc, h.hd_daxoa, h.hd_thoidiemcapnhat, hd_makhachhang from HopDong h", dshopdong)
                For Each cthd As DataRow In dscthopdong.Rows
                    If cthd.Item("cthd_mahopdong") = mahopdong Then
                        cthd.Item("cthd_daxoa") = 1
                        cthd.Item("cthd_thoidiemcapnhat") = DateTime.Now
                    End If
                Next
                Dim cautruyvanghidulieutudocthopdong = "select cthd_ma, cthd_mahopdong, cthd_mamathang,cthd_maphuongthuctinhtien, cthd_dongia, cthd_daxoa, cthd_thoidiemcapnhat from CTHopDong"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieutudocthopdong, dscthopdong)
                TaiDuLieuDgvDsHopDong()
                DinhdangdgvDSHopDong()
            Else
                MessageBox.Show("Không thể xóa hợp đồng này vì đã phát sinh giao dịch.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub
    Private Sub rdb_tatca_Click(sender As Object, e As EventArgs) Handles rdb_tatca.Click
        If rdb_tatca.Checked Then
            dgvDsHopDong.DataSource = dshopdong
            DinhdangdgvDSHopDong()
        End If
    End Sub

    Private Sub rdb_conhieuluc_Click(sender As Object, e As EventArgs) Handles rdb_conhieuluc.Click
        Dim tthl As Boolean
        If rdb_conhieuluc.Checked Then
            tthl = True
        End If

        Dim dskq =
                From hopdong In dshopdong
                Where hopdong.Item("hd_cohieuluc") = tthl
                Select hopdong
        Dim dtdskq As DataTable = New DataTable()
        If dskq.Count > 0 Then
            dtdskq = dskq.CopyToDataTable()
        End If
        dgvDsHopDong.DataSource = dtdskq

        DinhdangdgvDSHopDong()
    End Sub

    Private Sub rdb_hethieuluc_Click(sender As Object, e As EventArgs) Handles rdb_hethieuluc.Click
        Dim tthl As Boolean
        If rdb_hethieuluc.Checked Then
            tthl = False
        End If
        Dim dskq =
                From hopdong In dshopdong
                Where hopdong.Item("hd_cohieuluc") = tthl
                Select hopdong
        Dim dtdskq As DataTable = New DataTable()
        If dskq.Count > 0 Then
            dtdskq = dskq.CopyToDataTable()
        End If
        dgvDsHopDong.DataSource = dtdskq

        DinhdangdgvDSHopDong()
    End Sub
    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt = txb_noidungtim.Text.ToLower
            Dim dskq As EnumerableRowCollection(Of DataRow)
            If rdb_tatca.Checked Then
                dskq =
                From hopdong In dshopdong
                Where hopdong.Item(0).ToString Like ndt Or hopdong.Item(1).ToString.ToLower.Contains(ndt) Or hopdong.Item(3).ToString.ToLower.Contains(ndt) Or
                hopdong.Item(4).ToString.ToLower.Contains(ndt) Or hopdong.Item(5).ToString.ToLower.Contains(ndt) Or hopdong.Item(6).ToString.ToLower.Contains(ndt) Or
                hopdong.Item(8).ToString.ToLower.Contains(ndt) Or hopdong.Item(9).ToString.ToLower.Contains(ndt) Or hopdong.Item(10).ToString.ToLower.Contains(ndt) Or
                hopdong.Item(14).ToString.ToLower.Contains(ndt)
                Select hopdong
            ElseIf rdb_conhieuluc.Checked Then
                dskq =
                From hopdong In dshopdong
                Where hopdong.Item(0).ToString Like ndt Or hopdong.Item(1).ToString.ToLower.Contains(ndt) Or hopdong.Item(3).ToString.ToLower.Contains(ndt) Or
                hopdong.Item(4).ToString.ToLower.Contains(ndt) Or hopdong.Item(5).ToString.ToLower.Contains(ndt) Or hopdong.Item(6).ToString.ToLower.Contains(ndt) Or
                hopdong.Item(8).ToString.ToLower.Contains(ndt) Or hopdong.Item(9).ToString.ToLower.Contains(ndt) Or hopdong.Item(10).ToString.ToLower.Contains(ndt) Or
                hopdong.Item(14).ToString.ToLower.Contains(ndt) And hopdong.Item("hd_cohieuluc")
                Select hopdong
            Else
                dskq =
                From hopdong In dshopdong
                Where hopdong.Item(0).ToString Like ndt Or hopdong.Item(1).ToString.ToLower.Contains(ndt) Or hopdong.Item(3).ToString.ToLower.Contains(ndt) Or
                hopdong.Item(4).ToString.ToLower.Contains(ndt) Or hopdong.Item(5).ToString.ToLower.Contains(ndt) Or hopdong.Item(6).ToString.ToLower.Contains(ndt) Or
                hopdong.Item(8).ToString.ToLower.Contains(ndt) Or hopdong.Item(9).ToString.ToLower.Contains(ndt) Or hopdong.Item(10).ToString.ToLower.Contains(ndt) Or
                hopdong.Item(14).ToString.ToLower.Contains(ndt) And Not hopdong.Item("hd_cohieuluc")
                Select hopdong
            End If
            Dim dtdskq As DataTable = New DataTable()
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
            End If
            dgvDsHopDong.DataSource = dtdskq
        Else
            dgvDsHopDong.DataSource = dshopdong
        End If
        DinhdangdgvDSHopDong()
    End Sub
    Private Sub dgvDsHopDong_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsHopDong.CellClick
        hopdongv = dgvDsHopDong.CurrentRow
        If Not hopdongv.IsNewRow Then
            txb_ma.Text = hopdongv.Cells("hd_ma").Value
            txb_makhachhang.Text = hopdongv.Cells("hd_makhachhang").Value
            txb_tenkhachhang.Text = hopdongv.Cells("kh_ten").Value
            txb_loaigtpl.Text = hopdongv.Cells("gt_ten").Value
            txb_gtplso.Text = hopdongv.Cells("kh_gtplso").Value
            txb_diachi.Text = hopdongv.Cells("kh_diachi").Value
            txb_dienthoai.Text = hopdongv.Cells("kh_dienthoai").Value
            txb_email.Text = hopdongv.Cells("kh_email").Value
            dtp_ngayhopdong.Value = hopdongv.Cells("hd_ngayhopdong").Value
            dtp_ngaybatdau.Value = hopdongv.Cells("hd_ngaybatdau").Value
            dtp_ngayhethan.Value = hopdongv.Cells("hd_ngayhethan").Value
            chb_cohieuluc.Checked = hopdongv.Cells("hd_cohieuluc").Value
            txb_tongsomathang.Text = hopdongv.Cells("hd_soluongmathang").Value
            Dim mahopdong = hopdongv.Cells("hd_ma").Value
            Dim dtdscthd As DataTable = New DataTable
            dtdscthd = LayDsCTHDTheoMaHopDong(mahopdong)
            dgvDsCTHopDong.DataSource = dtdscthd
            DinhdangDgvDsCTHD()
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
        End If
    End Sub
    Function CoTheXoaHopDong(ByVal mahopdong As Integer) As Boolean
        Dim kq As Boolean = False
        Dim cautruyvanphieunhaphang As String = "select pnh_mahopdong from PhieuNhapHang where pnh_daxoa =0"
        Dim dsphieunhaphang As DataTable = xl_dulieu.DocDuLieu(cautruyvanphieunhaphang)
        Dim pnhs = dsphieunhaphang.Select($"pnh_mahopdong = {mahopdong}")
        kq = pnhs.Count <= 0
        Return kq
    End Function
    Sub TaiDuLieuDgvDsHopDong()
        Dim cautruyvanhopdong As String
        cautruyvanhopdong = "select h.hd_ma, k.kh_ten, l.gt_ten, k.kh_gtplso,h.hd_ngayhopdong,h.hd_ngaybatdau,h.hd_ngayhethan,h.hd_soluongmathang,
                             k.kh_diachi, k.kh_dienthoai, k.kh_email, h.hd_cohieuluc, h.hd_daxoa, h.hd_thoidiemcapnhat, hd_makhachhang
                            from HopDong h join KhachHang k on h.hd_makhachhang = k.kh_ma join LoaiGiayToPhapLy l on l.gt_ma= k.kh_maloaigtpl where h.hd_daxoa = 0"
        dshopdong = xl_dulieu.DocDuLieu(cautruyvanhopdong)
        dgvDsHopDong.DataSource = dshopdong
    End Sub
    Sub DinhdangdgvDSHopDong()
        If dgvDsHopDong.Columns.Count > 9 Then
            dgvDsHopDong.RowHeadersVisible = False
            dgvDsHopDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsHopDong.ReadOnly = True

            dgvDsHopDong.Columns(0).HeaderText = "Mã hợp đồng"
            dgvDsHopDong.Columns(0).AutoSizeMode = False
            dgvDsHopDong.Columns(0).Width = 60
            dgvDsHopDong.Columns(1).HeaderText = "Tên khách hàng"
            dgvDsHopDong.Columns(1).AutoSizeMode = False
            dgvDsHopDong.Columns(1).Width = 180
            dgvDsHopDong.Columns(2).HeaderText = "Loại GTPL"
            dgvDsHopDong.Columns(2).AutoSizeMode = False
            dgvDsHopDong.Columns(2).Width = 75
            dgvDsHopDong.Columns(3).HeaderText = "GTPL số"
            dgvDsHopDong.Columns(3).AutoSizeMode = False
            dgvDsHopDong.Columns(3).Width = 95
            dgvDsHopDong.Columns(4).HeaderText = "Ngày hợp đồng"
            dgvDsHopDong.Columns(4).AutoSizeMode = False
            dgvDsHopDong.Columns(4).Width = 80
            dgvDsHopDong.Columns(5).HeaderText = "Ngày bắt đầu"
            dgvDsHopDong.Columns(5).AutoSizeMode = False
            dgvDsHopDong.Columns(5).Width = 80
            dgvDsHopDong.Columns(6).HeaderText = "Ngày hết hạn"
            dgvDsHopDong.Columns(6).AutoSizeMode = False
            dgvDsHopDong.Columns(6).Width = 80
            dgvDsHopDong.Columns(7).HeaderText = "Số lượng mặt hàng"
            dgvDsHopDong.Columns(7).AutoSizeMode = False
            dgvDsHopDong.Columns(7).Width = 60
            dgvDsHopDong.Columns(8).HeaderText = "Địa chỉ"
            dgvDsHopDong.Columns(8).AutoSizeMode = False
            dgvDsHopDong.Columns(8).Width = 120
            dgvDsHopDong.Columns(9).HeaderText = "Điện thoại"
            dgvDsHopDong.Columns(9).AutoSizeMode = False
            dgvDsHopDong.Columns(9).Width = 90
            dgvDsHopDong.Columns(10).HeaderText = "Email"
            dgvDsHopDong.Columns(10).AutoSizeMode = False
            dgvDsHopDong.Columns(10).Width = 120
            dgvDsHopDong.Columns(11).Visible = False
            dgvDsHopDong.Columns(12).Visible = False
            dgvDsHopDong.Columns(13).Visible = False
            dgvDsHopDong.Columns(14).Visible = False
        End If
    End Sub
    Sub TaiDuLieuCTHopDong()
        Dim cautruyvancthd As String
        cautruyvancthd = "select cthd_ma, cthd_mahopdong, cthd_mamathang,mh_ten, cthd_maphuongthuctinhtien, pttt_ten, cthd_dongia, cthd_daxoa, cthd_thoidiemcapnhat
                            from CTHopDong join HopDong on cthd_mahopdong = hd_ma 
                            join PhuongThucTinhTien on cthd_maphuongthuctinhtien = pttt_ma
                            join MatHang on cthd_mamathang = mh_ma where cthd_daxoa = 0"
        dscthopdong = xl_dulieu.DocDuLieu(cautruyvancthd)
    End Sub
    Sub TaiCauTrucCTHopDong()
        Dim cautruyvancthd As String
        cautruyvancthd = "select cthd_ma, cthd_mahopdong, cthd_mamathang,mh_ten, cthd_maphuongthuctinhtien, pttt_ten, cthd_dongia, cthd_daxoa, cthd_thoidiemcapnhat
                            from CTHopDong join HopDong on cthd_mahopdong = hd_ma 
                            join PhuongThucTinhTien on cthd_maphuongthuctinhtien = pttt_ma
                            join MatHang on cthd_mamathang = mh_ma where cthd_daxoa = 0"
        dscthdcautruc = xl_dulieu.DocCauTruc(cautruyvancthd)
        dgvDsCTHopDong.DataSource = dscthdcautruc
    End Sub
    Protected Function LayDsCTHDTheoMaHopDong(ByVal mahopdong As Integer) As DataTable
        Dim dtdskq As DataTable = New DataTable
        Dim dskq =
            From cthd In dscthopdong
            Where cthd.Item(1) = mahopdong And cthd.Item(7) = 0
            Select cthd
        If dskq.Count > 0 Then
            dtdskq = dskq.CopyToDataTable()
        End If
        Return dtdskq
    End Function
    Sub DinhdangDgvDsCTHD()
        If dgvDsCTHopDong.Columns.Count = 9 Then
            Dim stt As New DataGridViewTextBoxColumn
            dgvDsCTHopDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTHopDong.RowHeadersVisible = False
            dgvDsCTHopDong.Columns.Insert(0, stt)
            dgvDsCTHopDong.Columns(0).HeaderText = "STT"
            dgvDsCTHopDong.Columns(0).Width = 50
            dgvDsCTHopDong.Columns(4).HeaderText = "Tên mặt hàng"
            dgvDsCTHopDong.Columns(4).AutoSizeMode = False
            dgvDsCTHopDong.Columns(4).Width = 160
            dgvDsCTHopDong.Columns(6).HeaderText = "Phương thức tính tiền"
            dgvDsCTHopDong.Columns(6).AutoSizeMode = False
            dgvDsCTHopDong.Columns(6).Width = 180
            dgvDsCTHopDong.Columns(7).HeaderText = "Đơn giá"
            dgvDsCTHopDong.Columns(7).AutoSizeMode = False
            dgvDsCTHopDong.Columns(7).Width = 80
            dgvDsCTHopDong.Columns(1).Visible = False
            dgvDsCTHopDong.Columns(2).Visible = False
            dgvDsCTHopDong.Columns(3).Visible = False
            dgvDsCTHopDong.Columns(5).Visible = False
            dgvDsCTHopDong.Columns(8).Visible = False
            dgvDsCTHopDong.Columns(9).Visible = False
            For i As Integer = 0 To dgvDsCTHopDong.Rows.Count - 1
                dgvDsCTHopDong.Rows(i).Cells(0).Value = i + 1
            Next
        ElseIf dgvDsCTHopDong.Columns.Count = 10 Then
            dgvDsCTHopDong.Columns(0).HeaderText = "STT"
            dgvDsCTHopDong.Columns(0).Width = 50
            dgvDsCTHopDong.Columns(4).HeaderText = "Tên mặt hàng"
            dgvDsCTHopDong.Columns(4).AutoSizeMode = False
            dgvDsCTHopDong.Columns(4).Width = 160
            dgvDsCTHopDong.Columns(6).HeaderText = "Phương thức tính tiền"
            dgvDsCTHopDong.Columns(6).AutoSizeMode = False
            dgvDsCTHopDong.Columns(6).Width = 180
            dgvDsCTHopDong.Columns(7).HeaderText = "Đơn giá"
            dgvDsCTHopDong.Columns(7).AutoSizeMode = False
            dgvDsCTHopDong.Columns(7).Width = 80
            dgvDsCTHopDong.Columns(1).Visible = False
            dgvDsCTHopDong.Columns(2).Visible = False
            dgvDsCTHopDong.Columns(3).Visible = False
            dgvDsCTHopDong.Columns(5).Visible = False
            dgvDsCTHopDong.Columns(8).Visible = False
            dgvDsCTHopDong.Columns(9).Visible = False
            For i As Integer = 0 To dgvDsCTHopDong.Rows.Count - 1
                dgvDsCTHopDong.Rows(i).Cells(0).Value = i + 1
            Next
        End If
    End Sub
End Class