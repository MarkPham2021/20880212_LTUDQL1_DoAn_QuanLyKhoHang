Public Class Frm_LoaiHang
    Dim dsloaihang, dsmathang, dsthehiendgvdsmathang As DataTable
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu()
    Dim chisodong As Integer
    Dim dangnhapdulieu As Boolean
    Dim isClosed As Boolean = True
    Private Sub Frm_LoaiHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoDieuKhien(True)
        TaiDuLieuDgvDsLoaiHang()
        DinhdangDgvDsLoaiHang()
        TaiDuLieuDgvDsMatHang()
        DinhdangDgvDsMatHang()
        dgvDsMatHang.Visible = False
        lbl_nhandgvdsmathang.Visible = False
        dangnhapdulieu = False
    End Sub
    Private Sub Frm_LoaiHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosed = False Then
            Dim dialogResult As DialogResult
            If dangnhapdulieu Then
                dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình? Dữ liệu đang nhập chưa lưu trữ sẽ bị mất khi đóng màn hình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            Else
                dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            End If

            If dialogResult = DialogResult.No Then
                e.Cancel = True
                isClosed = True
            End If
        End If

    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        MoDieuKhien(False)
        HienCUDBtn(False)
        dsloaihang.Reset()
        TaiDuLieuDgvDsLoaiHang()
        DinhdangDgvDsLoaiHang()
        XoaDuLieu()

        btn_capnhat.Visible = False
        dangnhapdulieu = True
        dgvDsMatHang.Visible = False
        lbl_nhandgvdsmathang.Visible = False
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        MoDieuKhien(False)
        HienCUDBtn(False)
        btn_luu.Visible = False
        dangnhapdulieu = True
        dgvDsMatHang.Visible = False
        lbl_nhandgvdsmathang.Visible = False
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim loaihang As DataRow
        Dim pkcolumns(1) As DataColumn
        pkcolumns(0) = dsloaihang.Columns(0)
        dsloaihang.PrimaryKey = pkcolumns
        Dim ma = Integer.Parse(txb_ma.Text)
        If CoTheXoaLoaiHang(ma) Then
            loaihang = dsloaihang.Rows.Find(ma)
            loaihang.Item(3) = 1
            loaihang.Item(5) = DateTime.Now
            xl_dulieu.GhiDuLieu("LoaiHang", dsloaihang)
            TaiDuLieuDgvDsLoaiHang()
            HienCUDBtn(True)
            MoDieuKhien(True)
            dgvDsMatHang.Visible = False
            lbl_nhandgvdsmathang.Visible = False
        Else
            MessageBox.Show("Loại hàng đã chọn không thể xóa vì đã tồn tại mặt hàng trong danh mục loại hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        Dim loaihang As DataRow = dsloaihang.NewRow()
        loaihang.Item(1) = txb_ten.Text
        loaihang.Item(2) = txb_mota.Text
        loaihang.Item(3) = 0
        loaihang.Item(4) = DateTime.Now
        loaihang.Item(5) = DateTime.Now
        dsloaihang.Rows.Add(loaihang)
        xl_dulieu.GhiDuLieu("LoaiHang", dsloaihang)
        TaiDuLieuDgvDsLoaiHang()
        DinhdangDgvDsLoaiHang()
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
        dgvDsMatHang.Visible = False
        lbl_nhandgvdsmathang.Visible = False
    End Sub

    Private Sub btn_capnhat_Click(sender As Object, e As EventArgs) Handles btn_capnhat.Click
        Dim pkcolumns(1) As DataColumn
        pkcolumns(0) = dsloaihang.Columns(0)
        dsloaihang.PrimaryKey = pkcolumns
        Dim ma = Integer.Parse(txb_ma.Text)
        Dim loaihang = dsloaihang.Rows.Find(ma)
        loaihang.Item(1) = txb_ten.Text
        loaihang.Item(2) = txb_mota.Text
        loaihang.Item(5) = DateTime.Now
        xl_dulieu.GhiDuLieu("LoaiHang", dsloaihang)
        TaiDuLieuDgvDsLoaiHang()
        DinhdangDgvDsLoaiHang()
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
        dgvDsMatHang.Visible = False
        lbl_nhandgvdsmathang.Visible = False
    End Sub

    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub
    Private Sub dgvDsLoaiHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsLoaiHang.CellContentClick
        Dim loaihang = dgvDsLoaiHang.CurrentRow
        If Not loaihang.IsNewRow Then
            txb_ma.Text = loaihang.Cells(0).Value
            txb_ten.Text = loaihang.Cells(1).Value
            txb_mota.Text = loaihang.Cells(2).Value
            MoDieuKhien(True)
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
            Dim mlh As Integer = Integer.Parse(txb_ma.Text)
            Dim dskq =
            From mh In dsthehiendgvdsmathang
            Where mh.Item("mh_maloaihang") = (mlh)
            Select mh
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
                dgvDsMatHang.DataSource = dtdskq
                DinhdangDgvDsMatHang()
                dgvDsMatHang.Visible = True
                lbl_nhandgvdsmathang.Visible = True
            Else
                lbl_nhandgvdsmathang.Text = "Loại hàng này chưa có mặt hàng được khai báo."
                lbl_nhandgvdsmathang.Visible = True
            End If

        End If
    End Sub
    Private Sub dgvDsLoaiHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsLoaiHang.CellClick
        Dim loaihang = dgvDsLoaiHang.CurrentRow
        If Not loaihang.IsNewRow Then
            txb_ma.Text = loaihang.Cells(0).Value
            txb_ten.Text = loaihang.Cells(1).Value
            txb_mota.Text = loaihang.Cells(2).Value
            MoDieuKhien(True)
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
            Dim mlh As Integer = Integer.Parse(txb_ma.Text)
            Dim dskq =
            From mh In dsthehiendgvdsmathang
            Where mh.Item("mh_maloaihang") = (mlh)
            Select mh
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
                dgvDsMatHang.DataSource = dtdskq
                DinhdangDgvDsMatHang()
                dgvDsMatHang.Visible = True
                lbl_nhandgvdsmathang.Text = "Các mặt hàng của loại hàng:"
                lbl_nhandgvdsmathang.Visible = True
            Else
                lbl_nhandgvdsmathang.Text = "Loại hàng này chưa có mặt hàng được khai báo."
                lbl_nhandgvdsmathang.Visible = True
                dgvDsMatHang.Visible = False
            End If

        End If
    End Sub
    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt As String = txb_noidungtim.Text.ToLower
            Dim dskq =
            From loaihang In dsloaihang
            Where loaihang.Item(1).ToString.ToLower.Contains(ndt) Or loaihang.Item(2).ToString.ToLower.Contains(ndt)
            Select loaihang
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
            End If
            dgvDsLoaiHang.DataSource = dtdskq
        Else
            dgvDsLoaiHang.DataSource = dsloaihang
        End If
        DinhdangDgvDsLoaiHang()
        dgvDsMatHang.Visible = False
        lbl_nhandgvdsmathang.Visible = False
    End Sub
    Function CoTheXoaLoaiHang(ByVal ma As Integer) As Boolean
        Dim kq As Boolean
        Dim cautruyvantatcamathang = "Select * from MatHang"
        Dim dstatcamathang = xl_dulieu.DocDuLieu(cautruyvantatcamathang)
        Dim dskq =
            From mh In dstatcamathang
            Where mh.Item(2) = ma
            Select mh
        If dskq.Count > 0 Then
            kq = False
        Else
            kq = True
        End If
        Return kq
    End Function
    Sub MoDieuKhien(ByVal mo As Boolean)
        txb_ten.ReadOnly = mo
        txb_mota.ReadOnly = mo
        btn_luu.Visible = Not mo
        btn_capnhat.Visible = Not mo
        btn_sua.Enabled = Not mo
        btn_xoa.Enabled = Not mo
    End Sub
    Sub HienCUDBtn(ByVal tt As Boolean)
        btn_them.Visible = tt
        btn_sua.Visible = tt
        btn_xoa.Visible = tt
    End Sub
    Sub TaiDuLieuDgvDsLoaiHang()
        Dim cautruyvan As String
        cautruyvan = "select * from LoaiHang where lh_daxoa = 0"
        dsloaihang = xl_dulieu.DocDuLieu(cautruyvan)
        dgvDsLoaiHang.DataSource = dsloaihang
    End Sub
    Sub DinhdangDgvDsLoaiHang()
        If dgvDsLoaiHang.Columns.Count > 5 Then
            dgvDsLoaiHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsLoaiHang.RowHeadersVisible = False
            dgvDsLoaiHang.Columns(0).HeaderText = "Mã loại hàng"
            dgvDsLoaiHang.Columns(0).AutoSizeMode = False
            dgvDsLoaiHang.Columns(0).Width = 100
            dgvDsLoaiHang.Columns(1).HeaderText = "Tên loại hàng"
            dgvDsLoaiHang.Columns(1).AutoSizeMode = False
            dgvDsLoaiHang.Columns(1).Width = 200
            dgvDsLoaiHang.Columns(2).HeaderText = "Mô tả"
            dgvDsLoaiHang.Columns(2).AutoSizeMode = False
            dgvDsLoaiHang.Columns(2).Width = 400
            dgvDsLoaiHang.Columns(3).Visible = False
            dgvDsLoaiHang.Columns(4).Visible = False
            dgvDsLoaiHang.Columns(5).Visible = False
        End If

    End Sub

    Private Sub SplitContainer2_Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Sub TaiDuLieuDgvDsMatHang()
        Dim cautruyvanket As String
        cautruyvanket = "select m.mh_ma, m.mh_ten, l.lh_ten, m.mh_khoiluong, m.mh_thetich, m.mh_ghichu, m.mh_daxoa,m.mh_thoidiemcapnhat, m.mh_maloaihang from MatHang m left join LoaiHang l on m.mh_maloaihang = l.lh_ma where m.mh_daxoa =0"
        dsthehiendgvdsmathang = xl_dulieu.DocDuLieu(cautruyvanket)
        dgvDsMatHang.DataSource = dsthehiendgvdsmathang
    End Sub
    Sub DinhdangDgvDsMatHang()
        If dgvDsMatHang.Columns.Count = 9 Then
            dgvDsMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsMatHang.RowHeadersVisible = False
            dgvDsMatHang.Columns(0).HeaderText = "Mã mặt hàng"
            dgvDsMatHang.Columns(0).AutoSizeMode = False
            dgvDsMatHang.Columns(0).Width = 90
            dgvDsMatHang.Columns(1).HeaderText = "Tên mặt hàng"
            dgvDsMatHang.Columns(1).AutoSizeMode = False
            dgvDsMatHang.Columns(1).Width = 150
            dgvDsMatHang.Columns(2).HeaderText = "Thuộc loại hàng"
            dgvDsMatHang.Columns(2).AutoSizeMode = False
            dgvDsMatHang.Columns(2).Width = 150
            dgvDsMatHang.Columns(3).HeaderText = "Khối lượng"
            dgvDsMatHang.Columns(3).AutoSizeMode = False
            dgvDsMatHang.Columns(3).Width = 75
            dgvDsMatHang.Columns(4).HeaderText = "Thể tích"
            dgvDsMatHang.Columns(4).AutoSizeMode = False
            dgvDsMatHang.Columns(4).Width = 75
            dgvDsMatHang.Columns(5).HeaderText = "Ghi chú"
            dgvDsMatHang.Columns(5).AutoSizeMode = False
            dgvDsMatHang.Columns(5).Width = 250
            dgvDsMatHang.Columns(6).Visible = False
            dgvDsMatHang.Columns(7).Visible = False
            dgvDsMatHang.Columns(8).Visible = False

        End If
    End Sub
    Sub XoaDuLieu()
        txb_ma.ResetText()
        txb_ten.ResetText()
        txb_mota.ResetText()

    End Sub
End Class