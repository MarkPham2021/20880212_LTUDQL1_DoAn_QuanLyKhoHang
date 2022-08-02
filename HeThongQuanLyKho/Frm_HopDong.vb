Public Class Frm_HopDong
    Dim isClosed = True
    Dim dshopdong, dskhachhang, dsmathang, dsphuongthuctinhtien, dscthopdong, dscthdcautruc As DataTable
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu()
    Dim dangnhapdulieu As Boolean
    Dim macthopdongtam = 0
    Private Sub Frm_HopDong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuDgvDsHopDong()
        DinhdangdgvDSHopDong()
        TaiDuLieuCTHopDong()
        TaiDuLieuDgvDsKhachHang()
        DinhdangdgvDSKhachHang()
        TaiDuLieuDgvDsMatHang()
        DinhdangDgvDsMatHang()
        TaiDuLieuCmbtenpttt()
        panel_timkhachhang.Visible = False
        DongDieuKhien(True)
        dangnhapdulieu = False
    End Sub

    Private Sub Frm_HopDong_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosed = False Then
            Dim dialogResult As DialogResult
            If dangnhapdulieu Then
                dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình? Dữ liệu đang nhập chưa lưu trữ sẽ bị mất khi đóng màn hình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            Else
                dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            End If

            If dialogResult = DialogResult.No Then
                isClosed = True
                btn_sua.Enabled = True
                btn_xoa.Enabled = True
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        panel_timkhachhang.Visible = True
        dangnhapdulieu = True
        XoaDuLieu()
        TaiCauTrucCTHopDong()
        DinhdangDgvDsCTHD()
        DongDieuKhien(False)
        btn_capnhat.Visible = False
        HienCUDBtn(False)
    End Sub
    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        Dim hopdong = dshopdong.NewRow
        Dim hople As Boolean
        hopdong.Item("hd_makhachhang") = txb_makhachhang.Text
        hopdong.Item("hd_ngayhopdong") = dtp_ngayhopdong.Value
        hopdong.Item("hd_ngaybatdau") = dtp_ngaybatdau.Value
        hopdong.Item("hd_ngayhethan") = dtp_ngayhethan.Value
        hopdong.Item("hd_cohieuluc") = True
        hopdong.Item("hd_daxoa") = False
        hopdong.Item("hd_thoidiemcapnhat") = DateTime.Now
        hople = (Integer.Parse(txb_tongsomathang.Text) = dgvDsCTHopDong.Rows.Count)
        If hople Then
            hopdong.Item("hd_soluongmathang") = Integer.Parse(txb_tongsomathang.Text)
            dshopdong.Rows.Add(hopdong)
            xl_dulieu.GhiDuLieuTuDo("select h.hd_ma,h.hd_ngayhopdong,h.hd_ngaybatdau,h.hd_ngayhethan,h.hd_soluongmathang,h.hd_cohieuluc, h.hd_daxoa, h.hd_thoidiemcapnhat, hd_makhachhang from HopDong h", dshopdong)

            Dim cautruyvanghidulieutudocthopdong = "select cthd_ma, cthd_mahopdong, cthd_mamathang,cthd_maphuongthuctinhtien, cthd_dongia, cthd_daxoa, cthd_thoidiemcapnhat from CTHopDong"
            For Each cthd As DataRow In dscthopdong.Rows
                If cthd.Item("cthd_mahopdong") = -1 Then
                    cthd.Item("cthd_mahopdong") = hopdong.Item("hd_ma")
                End If
            Next
            xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieutudocthopdong, dscthopdong)
            TaiDuLieuDgvDsHopDong()
            DinhdangdgvDSHopDong()
            DongDieuKhien(True)
            HienCUDBtn(True)
            dangnhapdulieu = False
        Else
            MessageBox.Show("Chưa lưu được dữ liệu vì thông tin chi tiết hợp đồng chưa khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        dangnhapdulieu = True
        DongDieuKhien(False)
        HienCUDBtn(False)
        btn_luu.Visible = False
    End Sub
    Private Sub btn_capnhat_Click(sender As Object, e As EventArgs) Handles btn_capnhat.Click
        Dim mahopdong = Integer.Parse(txb_ma.Text)
        Dim pkclms(1) As DataColumn
        pkclms(0) = dshopdong.Columns(0)
        dshopdong.PrimaryKey = pkclms
        Dim hopdong = dshopdong.Rows.Find(mahopdong)
        Dim hople As Boolean
        hopdong.Item("hd_makhachhang") = txb_makhachhang.Text
        hopdong.Item("hd_ngayhopdong") = dtp_ngayhopdong.Value
        hopdong.Item("hd_ngaybatdau") = dtp_ngaybatdau.Value
        hopdong.Item("hd_ngayhethan") = dtp_ngayhethan.Value
        hopdong.Item("hd_cohieuluc") = True
        hopdong.Item("hd_daxoa") = False
        hopdong.Item("hd_thoidiemcapnhat") = DateTime.Now
        hople = (Integer.Parse(txb_tongsomathang.Text) = dgvDsCTHopDong.Rows.Count)
        If hople Then
            hopdong.Item("hd_soluongmathang") = Integer.Parse(txb_tongsomathang.Text)
            xl_dulieu.GhiDuLieuTuDo("select h.hd_ma,h.hd_ngayhopdong,h.hd_ngaybatdau,h.hd_ngayhethan,h.hd_soluongmathang,h.hd_cohieuluc, h.hd_daxoa, h.hd_thoidiemcapnhat, hd_makhachhang from HopDong h", dshopdong)

            Dim cautruyvanghidulieutudocthopdong = "select cthd_ma, cthd_mahopdong, cthd_mamathang,cthd_maphuongthuctinhtien, cthd_dongia, cthd_daxoa, cthd_thoidiemcapnhat from CTHopDong"
            xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieutudocthopdong, dscthopdong)
            TaiDuLieuDgvDsHopDong()
            DinhdangdgvDSHopDong()
            HienCUDBtn(True)
            DongDieuKhien(True)
            dangnhapdulieu = False
        Else
            MessageBox.Show("Chưa lưu được dữ liệu vì thông tin chi tiết hợp đồng chưa khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click

        Dim xacnhan As DialogResult
        xacnhan = MessageBox.Show("Bạn chắc chắn muốn xóa hợp đồng được chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If xacnhan = DialogResult.Yes Then
            Dim mahopdong = Integer.Parse(txb_ma.Text)
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
            HienCUDBtn(True)
            DongDieuKhien(True)
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
        Dim hopdong = dgvDsHopDong.CurrentRow
        If Not hopdong.IsNewRow Then
            txb_ma.Text = hopdong.Cells("hd_ma").Value
            txb_makhachhang.Text = hopdong.Cells("hd_makhachhang").Value
            txb_tenkhachhang.Text = hopdong.Cells("kh_ten").Value
            txb_loaigtpl.Text = hopdong.Cells("gt_ten").Value
            txb_gtplso.Text = hopdong.Cells("kh_gtplso").Value
            txb_diachi.Text = hopdong.Cells("kh_diachi").Value
            txb_dienthoai.Text = hopdong.Cells("kh_dienthoai").Value
            txb_email.Text = hopdong.Cells("kh_email").Value
            dtp_ngayhopdong.Value = hopdong.Cells("hd_ngayhopdong").Value
            dtp_ngaybatdau.Value = hopdong.Cells("hd_ngaybatdau").Value
            dtp_ngayhethan.Value = hopdong.Cells("hd_ngayhethan").Value
            chb_cohieuluc.Checked = hopdong.Cells("hd_cohieuluc").Value
            txb_tongsomathang.Text = hopdong.Cells("hd_soluongmathang").Value
            Dim mahopdong = hopdong.Cells("hd_ma").Value
            Dim dtdscthd As DataTable = New DataTable
            dtdscthd = LayDsCTHDTheoMaHopDong(mahopdong)
            dgvDsCTHopDong.DataSource = dtdscthd
            DinhdangDgvDsCTHD()
            DongDieuKhien(True)
            HienCUDBtn(True)
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
        End If
    End Sub
    Private Sub dgvDsKhachHang_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsKhachHang.CellDoubleClick
        Dim khachhang = dgvDsKhachHang.CurrentRow
        If Not khachhang.IsNewRow Then
            txb_makhachhang.Text = khachhang.Cells(0).Value
            txb_tenkhachhang.Text = khachhang.Cells(1).Value
            txb_loaigtpl.Text = khachhang.Cells(2).Value
            txb_gtplso.Text = khachhang.Cells(3).Value
            txb_diachi.Text = khachhang.Cells(4).Value
            txb_dienthoai.Text = khachhang.Cells(5).Value
            txb_email.Text = khachhang.Cells(6).Value
            panel_timkhachhang.Visible = False
            GetNextControl(dtp_ngayhopdong, False)
        End If
    End Sub

    Private Sub txb_timmathang_TextChanged(sender As Object, e As EventArgs) Handles txb_timmathang.TextChanged
        If txb_timmathang.Text.Trim <> "" Then
            Dim ndt = txb_timmathang.Text.ToLower
            Dim dskq =
            From mh In dsmathang
            Where mh.Item(1).ToString.ToLower.Contains(ndt) Or mh.Item(2).ToString.ToLower.Contains(ndt)
            Select mh
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
            End If
            dgvDsMatHang.DataSource = dtdskq
        Else
            dgvDsMatHang.DataSource = dsmathang
        End If
        DinhdangDgvDsMatHang()
    End Sub

    Private Sub cmb_tenpttt_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_tenpttt.SelectedValueChanged

    End Sub

    Private Sub txb_tenkhachhang_DoubleClick(sender As Object, e As EventArgs) Handles txb_tenkhachhang.DoubleClick
        If dangnhapdulieu Then
            panel_timkhachhang.Visible = True
        End If

    End Sub
    Private Sub txb_tenkhachhang_MouseClick(sender As Object, e As EventArgs) Handles txb_tenkhachhang.MouseClick
        If dangnhapdulieu Then
            panel_timkhachhang.Visible = True
        End If

    End Sub
    Private Sub txb_timkhachhang_TextChanged(sender As Object, e As EventArgs) Handles txb_timkhachhang.TextChanged
        If txb_timkhachhang.Text.Trim <> "" Then
            Dim ndt As String = txb_timkhachhang.Text.ToLower
            Dim dskq =
            From khachhang In dskhachhang
            Where khachhang.Item(1).ToString.ToLower.Contains(ndt) Or khachhang.Item(3).ToString.ToLower.Contains(ndt) Or khachhang.Item(4).ToString.ToLower.Contains(ndt) Or khachhang.Item(5).ToString.ToLower.Contains(ndt) Or khachhang.Item(6).ToString.ToLower.Contains(ndt)
            Select khachhang
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
            End If
            dgvDsKhachHang.DataSource = dtdskq
        Else
            dgvDsKhachHang.DataSource = dskhachhang
        End If
        DinhdangdgvDSKhachHang()
    End Sub
    Private Sub dgvDsMatHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsMatHang.CellClick
        Dim mathang = dgvDsMatHang.CurrentRow
        If Not mathang.IsNewRow Then
            txb_mamathang.Text = mathang.Cells(0).Value
            txb_tenmathang.Text = mathang.Cells(1).Value
            txb_tenloaihang.Text = mathang.Cells(2).Value
            txb_khoiluong.Text = mathang.Cells(3).Value
            txb_thetich.Text = mathang.Cells(4).Value
        End If
    End Sub

    Private Sub dgvDsMatHang_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsMatHang.CellDoubleClick
        Dim mathang = dgvDsMatHang.CurrentRow
        If Not mathang.IsNewRow Then
            txb_mamathang.Text = mathang.Cells(0).Value
            txb_tenmathang.Text = mathang.Cells(1).Value
            txb_tenloaihang.Text = mathang.Cells(2).Value
            txb_khoiluong.Text = mathang.Cells(3).Value
            txb_thetich.Text = mathang.Cells(4).Value
        End If
    End Sub
    Private Sub btn_themcthd_Click(sender As Object, e As EventArgs) Handles btn_themcthd.Click

        If txb_mamathang.Text.Trim <> "" Then
            Dim mahopdong As Integer
            If (txb_ma.Text.Trim = "") Then
                mahopdong = -1
            Else
                mahopdong = Integer.Parse(txb_ma.Text)
            End If
            macthopdongtam -= 1
            Dim cthd = dscthopdong.NewRow
            cthd.Item("cthd_ma") = macthopdongtam
            cthd.Item("cthd_mahopdong") = mahopdong
            cthd.Item("cthd_mamathang") = Integer.Parse(txb_mamathang.Text)
            cthd.Item("cthd_maphuongthuctinhtien") = cmb_tenpttt.SelectedValue
            cthd.Item("cthd_dongia") = Integer.Parse(txb_dongia.Text)
            cthd.Item("cthd_daxoa") = False
            cthd.Item("cthd_thoidiemcapnhat") = DateTime.Now
            cthd.Item("mh_ten") = txb_tenmathang.Text
            cthd.Item("pttt_ten") = cmb_tenpttt.Text
            dscthopdong.Rows.Add(cthd)
            dgvDsCTHopDong.DataSource = LayDsCTHDTheoMaHopDong(mahopdong)
            DinhdangDgvDsCTHD()
        End If
        txb_tongsomathang.Text = dgvDsCTHopDong.Rows.Count
    End Sub
    Private Sub btn_xoacthd_Click(sender As Object, e As EventArgs) Handles btn_xoacthd.Click
        Dim mahopdong As Integer
        If (txb_ma.Text.Trim = "") Then
            mahopdong = -1
        Else
            mahopdong = Integer.Parse(txb_ma.Text)
        End If
        Dim cthdv = dgvDsCTHopDong.CurrentRow
        If Not IsNothing(cthdv) Then
            Dim pkclms(1) As DataColumn
            pkclms(0) = dscthopdong.Columns(0)
            dscthopdong.PrimaryKey = pkclms
            Dim cthd = dscthopdong.Rows.Find(cthdv.Cells("cthd_ma").Value)
            If cthdv.Cells("cthd_ma").Value < 1 Then
                dscthopdong.Rows.Remove(cthd)
            Else
                cthd.Item("cthd_daxoa") = 1
                cthd.Item("cthd_thoidiemcapnhat") = DateTime.Now

            End If
            Dim dt = LayDsCTHDTheoMaHopDong(mahopdong)
            If dt.Rows.Count > 0 Then
                dgvDsCTHopDong.DataSource = LayDsCTHDTheoMaHopDong(mahopdong)
            Else
                TaiCauTrucCTHopDong()
                DinhdangDgvDsCTHD()
            End If
            txb_tongsomathang.Text = dgvDsCTHopDong.Rows.Count
        End If
    End Sub
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
    Sub TaiDuLieuDgvDsKhachHang()
        Dim cautruyvankhachhang As String
        cautruyvankhachhang = "select k.kh_ma, k.kh_ten, l.gt_ten, k.kh_gtplso, k.kh_diachi, k.kh_dienthoai, k.kh_email, k.kh_maloaigtpl, k.kh_thoidiemcapnhat, k.kh_daxoa 
                                from KhachHang k join LoaiGiayToPhapLy l on l.gt_ma= k.kh_maloaigtpl where k.kh_daxoa = 0"
        dskhachhang = xl_dulieu.DocDuLieu(cautruyvankhachhang)
        dgvDsKhachHang.DataSource = dskhachhang
    End Sub


    Sub DinhdangdgvDSKhachHang()
        If dgvDsKhachHang.Columns.Count > 9 Then
            dgvDsKhachHang.RowHeadersVisible = False
            dgvDsKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            dgvDsKhachHang.Columns(0).HeaderText = "Mã khách hàng"
            dgvDsKhachHang.Columns(0).AutoSizeMode = False
            dgvDsKhachHang.Columns(0).Width = 70
            dgvDsKhachHang.Columns(1).HeaderText = "Tên khách hàng"
            dgvDsKhachHang.Columns(1).AutoSizeMode = False
            dgvDsKhachHang.Columns(1).Width = 185
            dgvDsKhachHang.Columns(2).HeaderText = "Loại GTPL"
            dgvDsKhachHang.Columns(2).AutoSizeMode = False
            dgvDsKhachHang.Columns(2).Width = 95
            dgvDsKhachHang.Columns(3).HeaderText = "GTPL số"
            dgvDsKhachHang.Columns(3).AutoSizeMode = False
            dgvDsKhachHang.Columns(3).Width = 105
            dgvDsKhachHang.Columns(4).HeaderText = "Địa chỉ"
            dgvDsKhachHang.Columns(4).AutoSizeMode = False
            dgvDsKhachHang.Columns(4).Width = 160
            dgvDsKhachHang.Columns(5).HeaderText = "Điện thoại"
            dgvDsKhachHang.Columns(5).AutoSizeMode = False
            dgvDsKhachHang.Columns(5).Width = 90
            dgvDsKhachHang.Columns(6).HeaderText = "Email"
            dgvDsKhachHang.Columns(6).AutoSizeMode = False
            dgvDsKhachHang.Columns(6).Width = 150
            dgvDsKhachHang.Columns(7).Visible = False
            dgvDsKhachHang.Columns(8).Visible = False
            dgvDsKhachHang.Columns(9).Visible = False
        End If
    End Sub

    Sub TaiDuLieuDgvDsMatHang()
        Dim cautruyvanmathang As String
        cautruyvanmathang = "select m.mh_ma, m.mh_ten, l.lh_ten, m.mh_khoiluong, m.mh_thetich, m.mh_maloaihang from MatHang m left join LoaiHang l on m.mh_maloaihang = l.lh_ma where m.mh_daxoa =0"
        dsmathang = xl_dulieu.DocDuLieu(cautruyvanmathang)
        dgvDsMatHang.DataSource = dsmathang
    End Sub
    Sub DinhdangDgvDsMatHang()
        If dgvDsMatHang.Columns.Count > 4 Then
            dgvDsMatHang.RowHeadersVisible = False
            dgvDsMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            dgvDsMatHang.Columns(1).HeaderText = "Tên mặt hàng"
            dgvDsMatHang.Columns(1).AutoSizeMode = False
            dgvDsMatHang.Columns(1).Width = 145
            dgvDsMatHang.Columns(2).HeaderText = "Thuộc loại hàng"
            dgvDsMatHang.Columns(2).AutoSizeMode = False
            dgvDsMatHang.Columns(2).Width = 145
            dgvDsMatHang.Columns(0).Visible = False
            dgvDsMatHang.Columns(3).Visible = False
            dgvDsMatHang.Columns(4).Visible = False
            dgvDsMatHang.Columns(5).Visible = False
        End If
    End Sub
    Sub TaiDuLieuCmbtenpttt()
        Dim cautruyvanpttt As String
        cautruyvanpttt = "select * from PhuongThucTinhTien where pttt_daxoa =0"
        dsphuongthuctinhtien = xl_dulieu.DocDuLieu(cautruyvanpttt)
        cmb_tenpttt.DataSource = dsphuongthuctinhtien
        cmb_tenpttt.DisplayMember = dsphuongthuctinhtien.Columns(1).ColumnName
        cmb_tenpttt.ValueMember = dsphuongthuctinhtien.Columns(0).ColumnName
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
    Sub XoaDuLieu()
        txb_ma.ResetText()
        txb_makhachhang.ResetText()
        txb_tenkhachhang.ResetText()
        txb_diachi.ResetText()
        txb_dienthoai.ResetText()
        txb_email.ResetText()
        txb_gtplso.ResetText()
        txb_mamathang.ResetText()
        txb_tenmathang.ResetText()
        txb_tenloaihang.ResetText()
        txb_thetich.ResetText()
        txb_khoiluong.ResetText()
        txb_dongia.ResetText()
    End Sub
    Sub DongDieuKhien(ByVal mo As Boolean)
        dtp_ngayhopdong.Enabled = Not mo
        dtp_ngaybatdau.Enabled = Not mo
        dtp_ngayhethan.Enabled = Not mo
        cmb_tenpttt.Enabled = Not mo
        txb_dongia.ReadOnly = mo
        dgvDsMatHang.Visible = Not mo
        lbl_nhandscthopdong.Visible = mo
        btn_luu.Visible = Not mo
        btn_capnhat.Visible = Not mo
        btn_themcthd.Visible = Not mo
        btn_xoacthd.Visible = Not mo
        btn_sua.Enabled = Not mo
        btn_xoa.Enabled = Not mo
    End Sub
    Sub HienCUDBtn(ByVal tt As Boolean)
        btn_them.Visible = tt
        btn_sua.Visible = tt
        btn_xoa.Visible = tt
    End Sub
End Class