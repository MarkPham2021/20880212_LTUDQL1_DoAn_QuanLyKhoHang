Public Class Frm_KhoHang
    Dim isClosed As Boolean = True
    Dim dskhohang As DataTable = New DataTable
    Dim dsdonvi As DataTable = New DataTable
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu()
    Dim chisodong As Integer
    Dim dangnhapdulieu As Boolean
    Private Sub Frm_KhoHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoDieuKhien(True)
        TaiDuLieuDgvDsKhoHang()
        TaiDuLieuCmbThuocDonVi()
        dangnhapdulieu = False
    End Sub
    Private Sub Frm_KhoHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
        dskhohang.Reset()
        XoaDuLieu()
        TaiDuLieuDgvDsKhoHang()
        btn_capnhat.Visible = False
        dangnhapdulieu = True
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        MoDieuKhien(False)
        HienCUDBtn(False)
        btn_luu.Visible = False
        dangnhapdulieu = True
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim xacnhan As DialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa kho hàng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If xacnhan = DialogResult.Yes Then
            If CoTheXoaKhoHang(Integer.Parse(txb_ma.Text)) Then
                Dim khohang As DataRow
                Dim pkcolumns(1) As DataColumn
                pkcolumns(0) = dskhohang.Columns(0)
                dskhohang.PrimaryKey = pkcolumns
                Dim ma = Integer.Parse(txb_ma.Text)
                khohang = dskhohang.Rows.Find(ma)
                khohang.Item("kho_daxoa") = 1
                khohang.Item("kho_thoidiemcapnhat") = DateTime.Now
                Dim cautruyvan = "select kho_ma,kho_ten, kho_thuocmadonvi, kho_diachi,kho_congsuatkhoiluong, kho_congsuatthetich,
	                            kho_daxoa,kho_thoidiemcapnhat 
                          from KhoHang"

                xl_dulieu.GhiDuLieuTuDo(cautruyvan, dskhohang)
                TaiDuLieuDgvDsKhoHang()
                HienCUDBtn(True)
                MoDieuKhien(True)
            Else
                MessageBox.Show("Không thể xóa kho hàng này do đã phát sinh giao dịch nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        Dim khohang As DataRow = dskhohang.NewRow()
        khohang.Item("kho_ten") = txb_ten.Text
        khohang.Item("kho_thuocmadonvi") = cmb_thuocdonvi.SelectedValue
        khohang.Item("kho_diachi") = txb_diachi.Text
        khohang.Item("kho_congsuatkhoiluong") = Integer.Parse(txb_congsuatkhoiluong.Text)
        khohang.Item("kho_congsuatthetich") = Integer.Parse(txb_congsuatthetich.Text)
        khohang.Item("kho_daxoa") = 0
        khohang.Item("kho_thoidiemcapnhat") = DateTime.Now
        dskhohang.Rows.Add(khohang)
        Dim cautruyvan = "select kho_ma,kho_ten, kho_thuocmadonvi, kho_diachi,kho_congsuatkhoiluong, kho_congsuatthetich,
	                            kho_daxoa,kho_thoidiemcapnhat 
                          from KhoHang"

        xl_dulieu.GhiDuLieuTuDo(cautruyvan, dskhohang)
        TaiDuLieuDgvDsKhoHang()
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
    End Sub
    Private Sub btn_capnhat_Click(sender As Object, e As EventArgs) Handles btn_capnhat.Click
        Dim khohang As DataRow
        Dim pkcolumns(1) As DataColumn
        pkcolumns(0) = dskhohang.Columns(0)
        dskhohang.PrimaryKey = pkcolumns
        Dim ma = Integer.Parse(txb_ma.Text)
        khohang = dskhohang.Rows.Find(ma)
        khohang.Item("kho_ten") = txb_ten.Text
        khohang.Item("kho_thuocmadonvi") = cmb_thuocdonvi.SelectedValue
        khohang.Item("kho_diachi") = txb_diachi.Text
        khohang.Item("kho_congsuatkhoiluong") = Integer.Parse(txb_congsuatkhoiluong.Text)
        khohang.Item("kho_congsuatthetich") = Integer.Parse(txb_congsuatthetich.Text)
        khohang.Item("kho_thoidiemcapnhat") = DateTime.Now
        Dim cautruyvan = "select kho_ma,kho_ten, kho_thuocmadonvi, kho_diachi,kho_congsuatkhoiluong, kho_congsuatthetich,
	                            kho_daxoa,kho_thoidiemcapnhat 
                          from KhoHang"

        xl_dulieu.GhiDuLieuTuDo(cautruyvan, dskhohang)
        TaiDuLieuDgvDsKhoHang()
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
    End Sub
    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub
    Private Sub dgvDsKho_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsKho.CellClick
        Dim khohang = dgvDsKho.CurrentRow
        If Not khohang.IsNewRow Then
            txb_ma.Text = khohang.Cells(0).Value
            txb_ten.Text = khohang.Cells(1).Value
            cmb_thuocdonvi.Text = khohang.Cells("dv_ten").Value
            txb_diachi.Text = khohang.Cells("kho_diachi").Value
            txb_congsuatkhoiluong.Text = khohang.Cells(4).Value
            txb_congsuatthetich.Text = khohang.Cells(5).Value
            MoDieuKhien(True)
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
        End If
    End Sub
    Private Sub dgvDsKho_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsKho.CellContentClick
        Dim khohang = dgvDsKho.CurrentRow
        If Not khohang.IsNewRow Then
            txb_ma.Text = khohang.Cells(0).Value
            txb_ten.Text = khohang.Cells(1).Value
            cmb_thuocdonvi.Text = khohang.Cells("dv_ten").Value
            txb_diachi.Text = khohang.Cells("kho_diachi").Value
            txb_congsuatkhoiluong.Text = khohang.Cells(4).Value
            txb_congsuatthetich.Text = khohang.Cells(5).Value
            MoDieuKhien(True)
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
        End If
    End Sub
    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt As String = txb_noidungtim.Text.ToLower
            Dim dskq =
            From khohang In dskhohang
            Where khohang.Item(1).ToString.ToLower.Contains(ndt) Or khohang.Item(2).ToString.ToLower.Contains(ndt) Or khohang.Item(3).ToString.ToLower.Contains(ndt)
            Select khohang
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
            End If
            dgvDsKho.DataSource = dtdskq
        Else
            dgvDsKho.DataSource = dskhohang
        End If
        DinhdangDgvDsKhoHang()
    End Sub
    Function CoTheXoaKhoHang(ByVal makhohang As Integer) As Boolean
        Dim cautruyvanphieunhaphang As String = "Select pnh_makhohang from PhieuNhapHang where pnh_daxoa =0"
        Dim dsphieunhaphang As DataTable = xl_dulieu.DocDuLieu(cautruyvanphieunhaphang)
        Dim pnhs = dsphieunhaphang.Select($"pnh_makhohang = {makhohang}")
        Dim kq As Boolean = pnhs.Count <= 0
        Return kq
    End Function
    Sub MoDieuKhien(ByVal mo As Boolean)
        txb_ten.ReadOnly = mo
        txb_diachi.ReadOnly = mo
        txb_congsuatkhoiluong.ReadOnly = mo
        txb_congsuatthetich.ReadOnly = mo
        cmb_thuocdonvi.Enabled = Not mo
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
    Sub TaiDuLieuDgvDsKhoHang()
        Dim cautruyvan As String
        cautruyvan = "select kho_ma, kho_ten,dv_ten, kho_diachi,kho_congsuatkhoiluong, kho_congsuatthetich,
	                            kho_daxoa,kho_thoidiemcapnhat, kho_thuocmadonvi
                     from KhoHang join DonVi on kho_thuocmadonvi = dv_ma
                     where kho_daxoa=0"
        dskhohang = xl_dulieu.DocDuLieu(cautruyvan)
        dgvDsKho.DataSource = dskhohang
        If dgvDsKho.Columns.Count > 7 Then
            dgvDsKho.RowHeadersVisible = False
            dgvDsKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            dgvDsKho.Columns(0).HeaderText = "Mã kho hàng"
            dgvDsKho.Columns(0).AutoSizeMode = False
            dgvDsKho.Columns(0).Width = 70
            dgvDsKho.Columns(1).HeaderText = "Tên kho hàng"
            dgvDsKho.Columns(1).AutoSizeMode = False
            dgvDsKho.Columns(1).Width = 140
            dgvDsKho.Columns(2).HeaderText = "Thuộc Đơn vị"
            dgvDsKho.Columns(2).AutoSizeMode = False
            dgvDsKho.Columns(2).Width = 140
            dgvDsKho.Columns(3).HeaderText = "Địa chỉ"
            dgvDsKho.Columns(3).AutoSizeMode = False
            dgvDsKho.Columns(3).Width = 180
            dgvDsKho.Columns(4).HeaderText = "Công suất khối lượng"
            dgvDsKho.Columns(4).AutoSizeMode = False
            dgvDsKho.Columns(4).Width = 100
            dgvDsKho.Columns(5).HeaderText = "Công suất thể tích"
            dgvDsKho.Columns(5).AutoSizeMode = False
            dgvDsKho.Columns(5).Width = 100
            dgvDsKho.Columns(6).Visible = False
            dgvDsKho.Columns(7).Visible = False
            dgvDsKho.Columns(8).Visible = False
            'dgvDsKho.Columns(9).Visible = False
        End If
    End Sub
    Sub DinhdangDgvDsKhoHang()
        If dgvDsKho.Columns.Count > 5 Then
            dgvDsKho.RowHeadersVisible = False
            dgvDsKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            dgvDsKho.Columns(0).HeaderText = "Mã kho hàng"
            dgvDsKho.Columns(0).AutoSizeMode = False
            dgvDsKho.Columns(0).Width = 70
            dgvDsKho.Columns(1).HeaderText = "Tên kho hàng"
            dgvDsKho.Columns(1).AutoSizeMode = False
            dgvDsKho.Columns(1).Width = 140
            dgvDsKho.Columns(2).HeaderText = "Địa chỉ"
            dgvDsKho.Columns(2).AutoSizeMode = False
            dgvDsKho.Columns(2).Width = 335
            dgvDsKho.Columns(3).HeaderText = "Công suất khối lượng"
            dgvDsKho.Columns(3).AutoSizeMode = False
            dgvDsKho.Columns(3).Width = 100
            dgvDsKho.Columns(4).HeaderText = "Công suất thể tích"
            dgvDsKho.Columns(4).AutoSizeMode = False
            dgvDsKho.Columns(4).Width = 100

            dgvDsKho.Columns(5).Visible = False
            dgvDsKho.Columns(6).Visible = False
            dgvDsKho.Columns(7).Visible = False
        End If
    End Sub
    Sub TaiDuLieuCmbThuocDonVi()
        Dim cautruyvan As String
        cautruyvan = "select dv_ma, dv_ten from DonVi where dv_daxoa = 0"
        dsdonvi = xl_dulieu.DocDuLieu(cautruyvan)
        cmb_thuocdonvi.DataSource = dsdonvi
        cmb_thuocdonvi.DisplayMember = "dv_ten"
        cmb_thuocdonvi.ValueMember = "dv_ma"
    End Sub
    Sub XoaDuLieu()
        txb_ma.ResetText()
        txb_ten.ResetText()
        txb_diachi.ResetText()
        txb_congsuatkhoiluong.ResetText()
        txb_congsuatthetich.ResetText()
    End Sub
End Class