Public Class Frm_DonVi
    Dim LoaiHanhDong As Integer
    Dim isClosed As Boolean = True
    Dim DsDonVi, DsSubUnit As DataTable
    Dim xl_dulieu = New XL_DuLieu

    Private Sub Frm_DonVi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDgvDsDonVi()
        DinhDangDgvDsDonVi()
        TaiDsSubUnit()
        TinhTrangNhapDuLieu(True)
    End Sub

    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        Me.Close()
        isClosed = False
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        LoaiHanhDong = 1
        XoaDuLieu()
        TinhTrangNhapDuLieu(False)
        dgvDsSubUnit.Visible = False

    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        LoaiHanhDong = 2
        TinhTrangNhapDuLieu(False)
        dgvDsSubUnit.Visible = False
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        TinhTrangNhapDuLieu(True)
        If txb_ma.Text.Trim <> "" Then
            Dim xacnhan As DialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa Đơn vị được chọn", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If xacnhan = DialogResult.Yes Then
                Dim cothexoa As Boolean = DsSubUnit.Select($"kho_thuocmadonvi = {txb_ma.Text}").Count = 0
                If cothexoa = True Then
                    Dim dv As DataRow = DsDonVi.Select($"dv_ma={txb_ma.Text}")(0)
                    dv("dv_daxoa") = 1
                    dv("dv_thoidiemcapnhat") = DateAndTime.Now
                    xl_dulieu.GhiDuLieu("DonVi", DsDonVi)
                    TaiDgvDsDonVi()
                    DinhDangDgvDsDonVi()
                Else
                    MessageBox.Show("Đơn vị này không thể xóa vì đã phát sinh các Chi nhánh con", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If LoaiHanhDong = 1 Then
            Dim hople As Boolean = txb_ten.Text <> "" And txb_diachi.Text <> "" And txb_dienthoai.Text <> ""
            If hople = True Then
                Dim dvm As DataRow = DsDonVi.NewRow
                dvm("dv_ten") = txb_ten.Text
                dvm("dv_diachi") = txb_diachi.Text
                dvm("dv_dienthoai") = txb_dienthoai.Text
                dvm("dv_daxoa") = 0
                dvm("dv_thoidiemtao") = DateAndTime.Now
                dvm("dv_thoidiemcapnhat") = DateAndTime.Now
                DsDonVi.Rows.Add(dvm)
                xl_dulieu.GhiDuLieu("DonVi", DsDonVi)
                TaiDgvDsDonVi()
                DinhDangDgvDsDonVi()

            End If
        ElseIf LoaiHanhDong = 2 Then
            Dim dv As DataRow = DsDonVi.Select($"dv_ma={txb_ma.Text}")(0)
            dv("dv_ten") = txb_ten.Text
            dv("dv_diachi") = txb_diachi.Text
            dv("dv_dienthoai") = txb_dienthoai.Text
            dv("dv_thoidiemcapnhat") = DateAndTime.Now
            xl_dulieu.GhiDuLieu("DonVi", DsDonVi)
            TaiDgvDsDonVi()
            DinhDangDgvDsDonVi()
        End If

    End Sub

    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt As String = txb_noidungtim.Text.ToLower
            Dim DsDonViV As DataView = DsDonVi.AsDataView
            DsDonViV.RowFilter = "dv_ten like '%" + ndt + "%'"
            dgvDsDonVi.DataSource = DsDonViV
            DinhDangDgvDsDonVi()
        End If

    End Sub

    Private Sub dgvDsDonVi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsDonVi.CellClick
        Dim dvv = dgvDsDonVi.CurrentRow
        If Not dvv.IsNewRow Then
            txb_ma.Text = dvv.Cells("dv_ma").Value
            txb_ten.Text = dvv.Cells("dv_ten").Value
            txb_diachi.Text = dvv.Cells("dv_diachi").Value
            txb_dienthoai.Text = dvv.Cells("dv_dienthoai").Value
            TaiDgvDsSubUnit(dvv.Cells("dv_ma").Value)
            dgvDsSubUnit.Visible = True
        End If

    End Sub
    Sub TaiDgvDsDonVi()
        Dim cautruyvan As String = "select * from DonVi"
        DsDonVi = xl_dulieu.DocDuLieu(cautruyvan)
        dgvDsDonVi.DataSource = DsDonVi

    End Sub
    Sub DinhDangDgvDsDonVi()
        If dgvDsDonVi.Columns.Count > 2 Then
            dgvDsDonVi.Columns("dv_ma").HeaderText = "Mã Đơn vị"
            dgvDsDonVi.Columns("dv_ten").HeaderText = "Tên Đơn vị"
            dgvDsDonVi.Columns("dv_diachi").HeaderText = "Địa chỉ"
            dgvDsDonVi.Columns("dv_dienthoai").HeaderText = "Điện thoại"
            dgvDsDonVi.Columns("dv_ma").Width = 50
            dgvDsDonVi.Columns("dv_ten").Width = 220
            dgvDsDonVi.Columns("dv_diachi").Width = 320
            dgvDsDonVi.Columns("dv_dienthoai").Width = 90
            dgvDsDonVi.Columns("dv_daxoa").Visible = False
            dgvDsDonVi.Columns("dv_thoidiemtao").Visible = False
            dgvDsDonVi.Columns("dv_thoidiemcapnhat").Visible = False
        End If
    End Sub
    Sub TaiDsSubUnit()
        Dim sql As String = "select kho_ma, kho_ten, kho_diachi, kho_thuocmadonvi from KhoHang where kho_daxoa=0"
        DsSubUnit = xl_dulieu.DocDuLieu(sql)
    End Sub
    Sub TaiDgvDsSubUnit(thuocdonvi As Integer)
        Dim dssubunitv As DataView
        dssubunitv = DsSubUnit.AsDataView
        dssubunitv.RowFilter = $"kho_thuocmadonvi ={thuocdonvi}"
        dgvDsSubUnit.DataSource = dssubunitv
        If dgvDsSubUnit.Columns.Count > 2 Then
            dgvDsSubUnit.Columns("kho_thuocmadonvi").Visible = False
            dgvDsSubUnit.Columns("kho_ma").HeaderText = "ID"
            dgvDsSubUnit.Columns("kho_ten").HeaderText = "Tên Đơn vị trực thuộc"
            dgvDsSubUnit.Columns("kho_diachi").HeaderText = "Địa chỉ"
            dgvDsSubUnit.Columns("kho_ma").Width = 60
            dgvDsSubUnit.Columns("kho_ten").Width = 250
            dgvDsSubUnit.Columns("kho_diachi").Width = 360
        End If
    End Sub
    Sub TinhTrangNhapDuLieu(ByVal khoa As Boolean)
        txb_ten.ReadOnly = khoa
        txb_diachi.ReadOnly = khoa
        txb_dienthoai.ReadOnly = khoa
        btn_luu.Visible = Not khoa
    End Sub
    Sub XoaDuLieu()
        txb_ma.ResetText()
        txb_ten.ResetText()
        txb_diachi.ResetText()
        txb_dienthoai.ResetText()
    End Sub
End Class