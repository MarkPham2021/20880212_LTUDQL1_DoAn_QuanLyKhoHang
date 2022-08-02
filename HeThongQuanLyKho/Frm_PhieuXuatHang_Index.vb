Public Class Frm_PhieuXuatHang_Index
    Dim isClosed = True
    Dim dsphieuxuathang, dsctxuathang, dsmathang, dsctxhcautruc As DataTable
    Dim maphieuxuathang As Integer
    Dim xl_dulieu = New XL_DuLieu
    Private Sub Frm_PhieuXuatHang_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieudgvDsPhieuXuatHang()
        DinhdangdgvDsPhieuXuatHang()
        TaiDuLieuCTXuatHang()
        DinhdangDgvDsCTXuatHang()
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim mh As Frm_PhieuXuatHang_Action = New Frm_PhieuXuatHang_Action()
        mh.WindowState = FormWindowState.Maximized
        mh.LoaiHanhDong = 1
        mh.MaPhieuXuatHang = -1
        mh.ShowDialog()
    End Sub
    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        If txb_ma.Text.Trim <> "" Then
            Dim mh As Frm_PhieuXuatHang_Action = New Frm_PhieuXuatHang_Action()
            mh.WindowState = FormWindowState.Maximized
            mh.LoaiHanhDong = 2
            mh.MaPhieuXuatHang = Integer.Parse(txb_ma.Text.Trim)
            mh.ShowDialog()
        Else
            MessageBox.Show("Vui lòng chọn Phiếu xuất hàng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        If txb_ma.Text.Trim <> "" Then
            Dim mh As Frm_PhieuXuatHang_Action = New Frm_PhieuXuatHang_Action()
            mh.WindowState = FormWindowState.Maximized
            mh.LoaiHanhDong = 3
            mh.MaPhieuXuatHang = Integer.Parse(txb_ma.Text.Trim)
            mh.ShowDialog()
        Else
            MessageBox.Show("Vui lòng chọn Phiếu xuất hàng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        TaiDuLieudgvDsPhieuXuatHang()
        DinhdangdgvDsPhieuXuatHang()
        TaiDuLieuCTXuatHang()
    End Sub

    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub
    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt As String = txb_noidungtim.Text.ToLower
            Dim so As Integer = -99
            Dim laso = Integer.TryParse(ndt, so)
            Dim dskq =
                From pxh In dsphieuxuathang
                Where pxh.Item("pxh_ma") = so Or pxh.Item("pxh_mahopdong") = so Or pxh.Item("kh_ten").ToString.ToLower.Contains(ndt) Or
                    pxh.Item("pxh_ngayxuathang").ToString.Contains(ndt)
                Select pxh
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable
            End If
            dgvDsPhieuXuatHang.DataSource = dtdskq
        Else
            dgvDsPhieuXuatHang.DataSource = dsphieuxuathang
        End If
        DinhdangdgvDsPhieuXuatHang()
    End Sub
    Sub TaiDuLieudgvDsPhieuXuatHang()
        Dim cautruyvanphieuxuathang As String
        cautruyvanphieuxuathang = "select pxh_ma, pxh_mahopdong, pxh_makhohang, kho_ten,pxh_ngayxuathang, pxh_soluongmathang,pxh_manguoidung,
                             hd_makhachhang, kh_ten, gt_ten, kh_gtplso,hd_ngayhopdong,hd_ngaybatdau,hd_ngayhethan,
                             kh_diachi, kh_dienthoai, kh_email, hd_cohieuluc, nd_hoten, nd_manhanvien
                            from HopDong join PhieuXuatHang on hd_ma = pxh_mahopdong
                            join KhoHang on pxh_makhohang = kho_ma
                            join NguoiDung on pxh_manguoidung = nd_ma
                            join KhachHang on hd_makhachhang = kh_ma 
                            join LoaiGiayToPhapLy on gt_ma= kh_maloaigtpl 
                            where pxh_daxoa = 0"
        dsphieuxuathang = xl_dulieu.DocDuLieu(cautruyvanphieuxuathang)
        dgvDsPhieuXuatHang.DataSource = dsphieuxuathang
    End Sub
    Sub DinhdangdgvDsPhieuXuatHang()
        If dgvDsPhieuXuatHang.Columns.Count > 9 Then
            dgvDsPhieuXuatHang.RowHeadersVisible = False
            dgvDsPhieuXuatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsPhieuXuatHang.ReadOnly = True

            dgvDsPhieuXuatHang.Columns(0).HeaderText = "Mã Phiếu Nhập hàng"
            dgvDsPhieuXuatHang.Columns(0).AutoSizeMode = False
            dgvDsPhieuXuatHang.Columns(0).Width = 60
            dgvDsPhieuXuatHang.Columns(1).HeaderText = "Mã Hợp đồng"
            dgvDsPhieuXuatHang.Columns(1).AutoSizeMode = False
            dgvDsPhieuXuatHang.Columns(1).Width = 60
            dgvDsPhieuXuatHang.Columns(3).HeaderText = "Kho nhập hàng"
            dgvDsPhieuXuatHang.Columns(3).AutoSizeMode = False
            dgvDsPhieuXuatHang.Columns(3).Width = 100
            dgvDsPhieuXuatHang.Columns(4).HeaderText = "Ngày nhập hàng"
            dgvDsPhieuXuatHang.Columns(4).AutoSizeMode = False
            dgvDsPhieuXuatHang.Columns(4).Width = 70
            dgvDsPhieuXuatHang.Columns(5).HeaderText = "Số mặt hàng"
            dgvDsPhieuXuatHang.Columns(5).AutoSizeMode = False
            dgvDsPhieuXuatHang.Columns(5).Width = 60
            dgvDsPhieuXuatHang.Columns(8).HeaderText = "Tên khách hàng"
            dgvDsPhieuXuatHang.Columns(8).AutoSizeMode = False
            dgvDsPhieuXuatHang.Columns(8).Width = 140
            dgvDsPhieuXuatHang.Columns(14).HeaderText = "Địa chỉ"
            dgvDsPhieuXuatHang.Columns(14).AutoSizeMode = False
            dgvDsPhieuXuatHang.Columns(14).Width = 150
            dgvDsPhieuXuatHang.Columns(15).HeaderText = "Điện thoại"
            dgvDsPhieuXuatHang.Columns(15).AutoSizeMode = False
            dgvDsPhieuXuatHang.Columns(15).Width = 80

            dgvDsPhieuXuatHang.Columns(2).Visible = False
            dgvDsPhieuXuatHang.Columns(6).Visible = False
            dgvDsPhieuXuatHang.Columns(7).Visible = False
            dgvDsPhieuXuatHang.Columns(9).Visible = False
            dgvDsPhieuXuatHang.Columns(10).Visible = False
            dgvDsPhieuXuatHang.Columns(11).Visible = False
            dgvDsPhieuXuatHang.Columns(12).Visible = False
            dgvDsPhieuXuatHang.Columns(13).Visible = False
            dgvDsPhieuXuatHang.Columns(16).Visible = False
            dgvDsPhieuXuatHang.Columns(17).Visible = False
            dgvDsPhieuXuatHang.Columns(18).Visible = False
            dgvDsPhieuXuatHang.Columns(19).Visible = False
        End If
    End Sub
    Sub TaiDuLieuCTXuatHang()
        Dim cautruyvanctxh As String
        cautruyvanctxh = "select ctxh_ma, ctxh_maphieuxuathang, ctxh_mamathang,mh_ten, ctxh_soluong
                            from CTXuatHang join MatHang on ctxh_mamathang = mh_ma
                            where ctxh_daxoa = 0"
        dsctxuathang = xl_dulieu.DocDuLieu(cautruyvanctxh)
    End Sub

    Private Sub dgvDsPhieuXuatHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsPhieuXuatHang.CellClick
        Dim pxhv = dgvDsPhieuXuatHang.CurrentRow
        If Not pxhv.IsNewRow Then
            txb_ma.Text = pxhv.Cells("pxh_ma").Value
            txb_mahopdong.Text = pxhv.Cells("pxh_mahopdong").Value
            txb_tenkhachhang.Text = pxhv.Cells("kh_ten").Value
            txb_loaigtpl.Text = pxhv.Cells("gt_ten").Value
            txb_gtplso.Text = pxhv.Cells("kh_gtplso").Value
            txb_diachi.Text = pxhv.Cells("kh_diachi").Value
            txb_dienthoai.Text = pxhv.Cells("kh_dienthoai").Value
            txb_email.Text = pxhv.Cells("kh_email").Value
            dtp_ngayhopdong.Value = pxhv.Cells("hd_ngayhopdong").Value
            dtp_ngaybatdau.Value = pxhv.Cells("hd_ngaybatdau").Value
            dtp_ngayhethan.Value = pxhv.Cells("hd_ngayhethan").Value
            chb_cohieuluc.Checked = pxhv.Cells("hd_cohieuluc").Value
            txb_tongsomathang.Text = pxhv.Cells("pxh_soluongmathang").Value
            dtp_ngayxuathang.Value = pxhv.Cells("pxh_ngayxuathang").Value
            txb_tenkhohang.Text = pxhv.Cells("kho_ten").Value
            txb_mataikhoan.Text = pxhv.Cells("pxh_manguoidung").Value
            txb_manhanvien.Text = pxhv.Cells("nd_manhanvien").Value
            txb_tennhanvien.Text = pxhv.Cells("nd_hoten").Value
            Dim dtdsctpxh As DataTable = New DataTable
            dtdsctpxh = LayDsCTXHTheoMaPXH(pxhv.Cells("pxh_ma").Value)
            dgvDsCTXuatHang.DataSource = dtdsctpxh
            DinhdangDgvDsCTXuatHang()
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
        End If
    End Sub
    Sub TaiCauTrucCTXuatHang()
        Dim cautruyvanctxh As String
        cautruyvanctxh = "select ctxh_ma, ctxh_maphieuxuathang, ctxh_mamathang,mh_ten, ctxh_soluong
                            from CTXuatHang join MatHang on ctxh_mamathang = mh_ma
                            where ctxh_daxoa = 0"
        dsctxhcautruc = xl_dulieu.DocCauTruc(cautruyvanctxh)
        dgvDsCTXuatHang.DataSource = dsctxhcautruc
    End Sub
    Protected Function LayDsCTXHTheoMaPXH(ByVal mapxh As Integer) As DataTable
        Dim dtdskq As DataTable = New DataTable
        Dim dskq =
            From ctxh In dsctxuathang
            Where ctxh.Item(1) = mapxh
            Select ctxh
        If dskq.Count > 0 Then
            dtdskq = dskq.CopyToDataTable()
        End If
        Return dtdskq
    End Function
    Sub DinhdangDgvDsCTXuatHang()
        If dgvDsCTXuatHang.Columns.Count = 5 Then
            Dim stt As New DataGridViewTextBoxColumn
            dgvDsCTXuatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTXuatHang.RowHeadersVisible = False
            dgvDsCTXuatHang.Columns.Insert(0, stt)
            dgvDsCTXuatHang.Columns(0).HeaderText = "STT"
            dgvDsCTXuatHang.Columns(0).Width = 50
            dgvDsCTXuatHang.Columns(4).HeaderText = "Tên mặt hàng"
            dgvDsCTXuatHang.Columns(4).AutoSizeMode = False
            dgvDsCTXuatHang.Columns(4).Width = 160
            dgvDsCTXuatHang.Columns(5).HeaderText = "Số lượng nhập"
            dgvDsCTXuatHang.Columns(5).AutoSizeMode = False
            dgvDsCTXuatHang.Columns(5).Width = 80
            dgvDsCTXuatHang.Columns(1).Visible = False
            dgvDsCTXuatHang.Columns(2).Visible = False
            dgvDsCTXuatHang.Columns(3).Visible = False
            For i As Integer = 0 To dgvDsCTXuatHang.Rows.Count - 1
                dgvDsCTXuatHang.Rows(i).Cells(0).Value = i + 1
            Next
        ElseIf dgvDsCTXuatHang.Columns.Count = 6 Then
            dgvDsCTXuatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTXuatHang.RowHeadersVisible = False
            dgvDsCTXuatHang.Columns(0).HeaderText = "STT"
            dgvDsCTXuatHang.Columns(0).Width = 50
            dgvDsCTXuatHang.Columns(4).HeaderText = "Tên mặt hàng"
            dgvDsCTXuatHang.Columns(4).AutoSizeMode = False
            dgvDsCTXuatHang.Columns(4).Width = 160
            dgvDsCTXuatHang.Columns(5).HeaderText = "Số lượng nhập"
            dgvDsCTXuatHang.Columns(5).AutoSizeMode = False
            dgvDsCTXuatHang.Columns(5).Width = 80
            dgvDsCTXuatHang.Columns(1).Visible = False
            dgvDsCTXuatHang.Columns(2).Visible = False
            dgvDsCTXuatHang.Columns(3).Visible = False
            For i As Integer = 0 To dgvDsCTXuatHang.Rows.Count - 1
                dgvDsCTXuatHang.Rows(i).Cells(0).Value = i + 1
            Next
        End If
    End Sub

End Class