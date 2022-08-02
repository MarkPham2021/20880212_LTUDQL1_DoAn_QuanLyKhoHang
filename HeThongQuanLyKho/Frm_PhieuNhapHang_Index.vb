Public Class Frm_PhieuNhapHang_Index
    Dim isClosed = True
    Dim dsphieunhaphang, dsctnhaphang, dsmathang, dsctnhcautruc As DataTable
    Dim maphieunhaphang As Integer
    Dim xl_dulieu = New XL_DuLieu

    Private Sub Frm_PhieuNhapHang_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieudgvDsPhieuNhapHang()
        DinhdangdgvDsPhieuNhapHang()
        TaiDuLieuCTNhapHang()
        DinhdangDgvDsCTNhapHang()

    End Sub
    Private Sub Frm_PhieuNhapHang_Index_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isClosed Then
            Dim dialogResult As DialogResult
            dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                isClosed = True
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim mh As Frm_PhieuNhapHang_Action = New Frm_PhieuNhapHang_Action()
        mh.WindowState = FormWindowState.Maximized
        mh.LoaiHanhDong = 1
        mh.MaPhieuNhapHang = -1
        mh.ShowDialog()
    End Sub
    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        If txb_ma.Text.Trim <> "" Then
            Dim mh As Frm_PhieuNhapHang_Action = New Frm_PhieuNhapHang_Action()
            mh.WindowState = FormWindowState.Maximized
            mh.LoaiHanhDong = 2
            mh.MaPhieuNhapHang = Integer.Parse(txb_ma.Text.Trim)
            mh.ShowDialog()
        Else
            MessageBox.Show("Vui lòng chọn Phiếu nhập hàng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        If txb_ma.Text.Trim <> "" Then
            Dim mh As Frm_PhieuNhapHang_Action = New Frm_PhieuNhapHang_Action()
            mh.WindowState = FormWindowState.Maximized
            mh.LoaiHanhDong = 3
            mh.MaPhieuNhapHang = Integer.Parse(txb_ma.Text.Trim)
            mh.ShowDialog()
        Else
            MessageBox.Show("Vui lòng chọn Phiếu nhập hàng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        TaiDuLieudgvDsPhieuNhapHang()
        DinhdangdgvDsPhieuNhapHang()
        TaiDuLieuCTNhapHang()
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
                From pnh In dsphieunhaphang
                Where pnh.Item("pnh_ma") = so Or pnh.Item("pnh_mahopdong") = so Or pnh.Item("kh_ten").ToString.ToLower.Contains(ndt) Or
                    pnh.Item("pnh_ngaynhaphang").ToString.Contains(ndt)
                Select pnh
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable
            End If
            dgvDsPhieuNhapHang.DataSource = dtdskq
        Else
            dgvDsPhieuNhapHang.DataSource = dsphieunhaphang
        End If
        DinhdangdgvDsPhieuNhapHang()
    End Sub
    Sub TaiDuLieudgvDsPhieuNhapHang()
        Dim cautruyvanphieunhaphang As String
        cautruyvanphieunhaphang = "select pnh_ma, pnh_mahopdong, pnh_makhohang, kho_ten,pnh_ngaynhaphang, pnh_soluongmathang,pnh_manguoidung,
                             hd_makhachhang, kh_ten, gt_ten, kh_gtplso,hd_ngayhopdong,hd_ngaybatdau,hd_ngayhethan,
                             kh_diachi, kh_dienthoai, kh_email, hd_cohieuluc, nd_hoten, nd_manhanvien
                            from HopDong join PhieuNhapHang on hd_ma = pnh_Mahopdong
                            join KhoHang on pnh_makhohang = kho_ma
                            join NguoiDung on pnh_manguoidung = nd_ma
                            join KhachHang on hd_makhachhang = kh_ma 
                            join LoaiGiayToPhapLy on gt_ma= kh_maloaigtpl 
                            where pnh_daxoa = 0"
        dsphieunhaphang = xl_dulieu.DocDuLieu(cautruyvanphieunhaphang)
        dgvDsPhieuNhapHang.DataSource = dsphieunhaphang
    End Sub
    Sub DinhdangdgvDsPhieuNhapHang()
        If dgvDsPhieuNhapHang.Columns.Count > 9 Then
            dgvDsPhieuNhapHang.RowHeadersVisible = False
            dgvDsPhieuNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsPhieuNhapHang.ReadOnly = True

            dgvDsPhieuNhapHang.Columns(0).HeaderText = "Mã Phiếu Nhập hàng"
            dgvDsPhieuNhapHang.Columns(0).AutoSizeMode = False
            dgvDsPhieuNhapHang.Columns(0).Width = 60
            dgvDsPhieuNhapHang.Columns(1).HeaderText = "Mã Hợp đồng"
            dgvDsPhieuNhapHang.Columns(1).AutoSizeMode = False
            dgvDsPhieuNhapHang.Columns(1).Width = 60
            dgvDsPhieuNhapHang.Columns(3).HeaderText = "Kho nhập hàng"
            dgvDsPhieuNhapHang.Columns(3).AutoSizeMode = False
            dgvDsPhieuNhapHang.Columns(3).Width = 100
            dgvDsPhieuNhapHang.Columns(4).HeaderText = "Ngày nhập hàng"
            dgvDsPhieuNhapHang.Columns(4).AutoSizeMode = False
            dgvDsPhieuNhapHang.Columns(4).Width = 70
            dgvDsPhieuNhapHang.Columns(5).HeaderText = "Số mặt hàng"
            dgvDsPhieuNhapHang.Columns(5).AutoSizeMode = False
            dgvDsPhieuNhapHang.Columns(5).Width = 60
            dgvDsPhieuNhapHang.Columns(8).HeaderText = "Tên khách hàng"
            dgvDsPhieuNhapHang.Columns(8).AutoSizeMode = False
            dgvDsPhieuNhapHang.Columns(8).Width = 140
            dgvDsPhieuNhapHang.Columns(14).HeaderText = "Địa chỉ"
            dgvDsPhieuNhapHang.Columns(14).AutoSizeMode = False
            dgvDsPhieuNhapHang.Columns(14).Width = 150
            dgvDsPhieuNhapHang.Columns(15).HeaderText = "Điện thoại"
            dgvDsPhieuNhapHang.Columns(15).AutoSizeMode = False
            dgvDsPhieuNhapHang.Columns(15).Width = 80

            dgvDsPhieuNhapHang.Columns(2).Visible = False
            dgvDsPhieuNhapHang.Columns(6).Visible = False
            dgvDsPhieuNhapHang.Columns(7).Visible = False
            dgvDsPhieuNhapHang.Columns(9).Visible = False
            dgvDsPhieuNhapHang.Columns(10).Visible = False
            dgvDsPhieuNhapHang.Columns(11).Visible = False
            dgvDsPhieuNhapHang.Columns(12).Visible = False
            dgvDsPhieuNhapHang.Columns(13).Visible = False
            dgvDsPhieuNhapHang.Columns(16).Visible = False
            dgvDsPhieuNhapHang.Columns(17).Visible = False
            dgvDsPhieuNhapHang.Columns(18).Visible = False
            dgvDsPhieuNhapHang.Columns(19).Visible = False
        End If
    End Sub
    Sub TaiDuLieuCTNhapHang()
        Dim cautruyvanctnh As String
        cautruyvanctnh = "select ctnh_ma, ctnh_maphieunhaphang, ctnh_mamathang,mh_ten, ctnh_soluong
                            from CTNhapHang join MatHang on ctnh_mamathang = mh_ma
                            where ctnh_daxoa = 0"
        dsctnhaphang = xl_dulieu.DocDuLieu(cautruyvanctnh)
    End Sub

    Private Sub dgvDsPhieuNhapHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsPhieuNhapHang.CellClick
        Dim pnhv = dgvDsPhieuNhapHang.CurrentRow
        If Not pnhv.IsNewRow Then
            txb_ma.Text = pnhv.Cells("pnh_ma").Value
            txb_mahopdong.Text = pnhv.Cells("pnh_mahopdong").Value
            txb_tenkhachhang.Text = pnhv.Cells("kh_ten").Value
            txb_loaigtpl.Text = pnhv.Cells("gt_ten").Value
            txb_gtplso.Text = pnhv.Cells("kh_gtplso").Value
            txb_diachi.Text = pnhv.Cells("kh_diachi").Value
            txb_dienthoai.Text = pnhv.Cells("kh_dienthoai").Value
            txb_email.Text = pnhv.Cells("kh_email").Value
            dtp_ngayhopdong.Value = pnhv.Cells("hd_ngayhopdong").Value
            dtp_ngaybatdau.Value = pnhv.Cells("hd_ngaybatdau").Value
            dtp_ngayhethan.Value = pnhv.Cells("hd_ngayhethan").Value
            chb_cohieuluc.Checked = pnhv.Cells("hd_cohieuluc").Value
            txb_tongsomathang.Text = pnhv.Cells("pnh_soluongmathang").Value
            dtp_ngaynhaphang.Value = pnhv.Cells("pnh_ngaynhaphang").Value
            txb_tenkhohang.Text = pnhv.Cells("kho_ten").Value
            txb_mataikhoan.Text = pnhv.Cells("pnh_manguoidung").Value
            txb_manhanvien.Text = pnhv.Cells("nd_manhanvien").Value
            txb_tennhanvien.Text = pnhv.Cells("nd_hoten").Value
            Dim dtdsctpnh As DataTable = New DataTable
            dtdsctpnh = LayDsCTNHTheoMaPNH(pnhv.Cells("pnh_ma").Value)
            dgvDsCTNhapHang.DataSource = dtdsctpnh
            DinhdangDgvDsCTNhapHang()
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
        End If
    End Sub

    Sub TaiCauTrucCTNhapHang()
        Dim cautruyvanctnh As String
        cautruyvanctnh = "select ctnh_ma, ctnh_maphieunhaphang, ctnh_mamathang,mh_ten, ctnh_soluong
                            from CTNhapHang join MatHang on ctnh_mamathang = mh_ma
                            where ctnh_daxoa = 0"
        dsctnhcautruc = xl_dulieu.DocCauTruc(cautruyvanctnh)
        dgvDsCTNhapHang.DataSource = dsctnhcautruc
    End Sub
    Protected Function LayDsCTNHTheoMaPNH(ByVal mapnh As Integer) As DataTable
        Dim dtdskq As DataTable = New DataTable
        Dim dskq =
            From ctnh In dsctnhaphang
            Where ctnh.Item(1) = mapnh
            Select ctnh
        If dskq.Count > 0 Then
            dtdskq = dskq.CopyToDataTable()
        End If
        Return dtdskq
    End Function
    Sub DinhdangDgvDsCTNhapHang()
        If dgvDsCTNhapHang.Columns.Count = 5 Then
            Dim stt As New DataGridViewTextBoxColumn
            dgvDsCTNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTNhapHang.RowHeadersVisible = False
            dgvDsCTNhapHang.Columns.Insert(0, stt)
            dgvDsCTNhapHang.Columns(0).HeaderText = "STT"
            dgvDsCTNhapHang.Columns(0).Width = 50
            dgvDsCTNhapHang.Columns(4).HeaderText = "Tên mặt hàng"
            dgvDsCTNhapHang.Columns(4).AutoSizeMode = False
            dgvDsCTNhapHang.Columns(4).Width = 160
            dgvDsCTNhapHang.Columns(5).HeaderText = "Số lượng nhập"
            dgvDsCTNhapHang.Columns(5).AutoSizeMode = False
            dgvDsCTNhapHang.Columns(5).Width = 80
            dgvDsCTNhapHang.Columns(1).Visible = False
            dgvDsCTNhapHang.Columns(2).Visible = False
            dgvDsCTNhapHang.Columns(3).Visible = False
            For i As Integer = 0 To dgvDsCTNhapHang.Rows.Count - 1
                dgvDsCTNhapHang.Rows(i).Cells(0).Value = i + 1
            Next
        ElseIf dgvDsCTNhapHang.Columns.Count = 6 Then
            dgvDsCTNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTNhapHang.RowHeadersVisible = False
            dgvDsCTNhapHang.Columns(0).HeaderText = "STT"
            dgvDsCTNhapHang.Columns(0).Width = 50
            dgvDsCTNhapHang.Columns(4).HeaderText = "Tên mặt hàng"
            dgvDsCTNhapHang.Columns(4).AutoSizeMode = False
            dgvDsCTNhapHang.Columns(4).Width = 160
            dgvDsCTNhapHang.Columns(5).HeaderText = "Số lượng nhập"
            dgvDsCTNhapHang.Columns(5).AutoSizeMode = False
            dgvDsCTNhapHang.Columns(5).Width = 80
            dgvDsCTNhapHang.Columns(1).Visible = False
            dgvDsCTNhapHang.Columns(2).Visible = False
            dgvDsCTNhapHang.Columns(3).Visible = False
            For i As Integer = 0 To dgvDsCTNhapHang.Rows.Count - 1
                dgvDsCTNhapHang.Rows(i).Cells(0).Value = i + 1
            Next
        End If
    End Sub

End Class