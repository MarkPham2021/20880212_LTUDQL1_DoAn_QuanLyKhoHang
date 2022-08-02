Public Class Frm_LoaiNguoiDung_Index
    Dim isClosed = True
    Dim dsloainguoidung, dsphanquyen As DataTable
    Dim maloainguoidung As Integer
    Dim xl_dulieu = New XL_DuLieu
    Private Sub Frm_LoaiNguoiDung_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuDgvLoaiNguoiDung()
        DinhDangDgvDsLoaiNguoiDung()

    End Sub
    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim mh As Frm_LoaiNguoiDung_Action = New Frm_LoaiNguoiDung_Action
        mh.LoaiHanhDong = 1
        mh.WindowState = FormWindowState.Maximized
        mh.ShowDialog(Me)
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click

        If txb_ma.Text.Trim <> "" Then
            Dim lndv As DataRowView = dgvDsLoaiNguoiDung.CurrentRow.DataBoundItem
            Dim lnd = lndv.Row
            Dim mh As Frm_LoaiNguoiDung_Action = New Frm_LoaiNguoiDung_Action
            mh.LoaiHanhDong = 2
            mh.LoaiNguoiDung = lnd
            mh.WindowState = FormWindowState.Maximized
            mh.ShowDialog(Me)
        Else
            MessageBox.Show("Vui lòng chọn Loại người dùng muốn sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        If txb_ma.Text.Trim <> "" Then
            Dim lndv As DataRowView = dgvDsLoaiNguoiDung.CurrentRow.DataBoundItem
            Dim lnd = lndv.Row

            Dim mh As Frm_LoaiNguoiDung_Action = New Frm_LoaiNguoiDung_Action
            mh.LoaiHanhDong = 3
            mh.LoaiNguoiDung = lnd
            mh.WindowState = FormWindowState.Maximized
            mh.ShowDialog(Me)
        Else
            MessageBox.Show("Vui lòng chọn Loại người dùng muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        TaiDuLieuDgvLoaiNguoiDung()
        DinhDangDgvDsLoaiNguoiDung()
    End Sub

    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt As String = txb_noidungtim.Text.ToLower
            Dim so As Integer = -99
            Dim laso = Integer.TryParse(ndt, so)
            Dim dskq =
                From lnd In dsloainguoidung
                Where lnd.Item("lnd_ma") = so Or lnd("lnd_ten").ToString.ToLower.Contains(ndt)
                Select lnd
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable
            End If
            dgvDsLoaiNguoiDung.DataSource = dtdskq
        Else
            dgvDsLoaiNguoiDung.DataSource = dsloainguoidung
        End If
        DinhDangDgvDsLoaiNguoiDung()
    End Sub

    Private Sub dgvDsLoaiNguoiDung_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsLoaiNguoiDung.CellClick
        Dim lndv = dgvDsLoaiNguoiDung.CurrentRow
        If Not lndv.IsNewRow Then
            txb_ma.Text = lndv.Cells("lnd_ma").Value
            txb_lnd_ten.Text = lndv.Cells("lnd_ten").Value
            txb_lnd_mota.Text = lndv.Cells("lnd_mota").Value
            TaiDsPhanQuyen(Integer.Parse(txb_ma.Text))
            DinhDangDgvDsPhanQuyen()

        End If
    End Sub
    Sub TaiDuLieuDgvLoaiNguoiDung()
        Dim cautruyvan As String
        cautruyvan = "select lnd_ma, lnd_ten, Lnd_mota from LoaiNguoiDung
                        where lnd_daxoa = 0"
        dsloainguoidung = xl_dulieu.DocDuLieu(cautruyvan)
        dgvDsLoaiNguoiDung.DataSource = dsloainguoidung

    End Sub
    Sub DinhDangDgvDsLoaiNguoiDung()
        If dgvDsLoaiNguoiDung.Columns.Count = 3 Then

            dgvDsLoaiNguoiDung.Columns(0).HeaderText = "ID"
            dgvDsLoaiNguoiDung.Columns(0).Width = 50
            dgvDsLoaiNguoiDung.Columns(1).HeaderText = "Tên loại người dùng"
            dgvDsLoaiNguoiDung.Columns(1).Width = 240
            dgvDsLoaiNguoiDung.Columns(2).HeaderText = "Mô tả"
            dgvDsLoaiNguoiDung.Columns(2).Width = 630

        End If
    End Sub
    Sub TaiDsPhanQuyen(lnd_ma As Integer)
        Dim cautruyvan As String = $"select cn_ten, cn_tag, pq_machucnang
                                        from PhanQuyen join ChucNang on pq_machucnang = cn_ma
                                        where pq_maloainguoidung = {lnd_ma} and pq_daxoa=0"
        dsphanquyen = xl_dulieu.DocDuLieu(cautruyvan)
        dgvDsCTPhanQuyen.DataSource = dsphanquyen
    End Sub

    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        Me.Close()
        isClosed = False
    End Sub

    Sub DinhDangDgvDsPhanQuyen()
        If dgvDsCTPhanQuyen.Columns.Count = 3 Then
            Dim cotstt As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            dgvDsCTPhanQuyen.Columns.Insert(0, cotstt)
            dgvDsCTPhanQuyen.Columns(0).Name = "stt"
            dgvDsCTPhanQuyen.Columns("stt").HeaderText = "STT"
            dgvDsCTPhanQuyen.Columns("stt").Width = 50
            dgvDsCTPhanQuyen.Columns("cn_ten").HeaderText = "Tên Chức năng"
            dgvDsCTPhanQuyen.Columns("cn_ten").Width = 380
            dgvDsCTPhanQuyen.Columns("cn_tag").HeaderText = "Số Tag"
            dgvDsCTPhanQuyen.Columns("cn_tag").Width = 60
            dgvDsCTPhanQuyen.Columns("pq_machucnang").HeaderText = "ID"
            dgvDsCTPhanQuyen.Columns("pq_machucnang").Width = 50
            For i As Integer = 0 To dgvDsCTPhanQuyen.Rows.Count - 1
                dgvDsCTPhanQuyen.Rows(i).Cells("stt").Value = i + 1
            Next
        ElseIf dgvDsCTPhanQuyen.Columns.Count = 4 Then

            dgvDsCTPhanQuyen.Columns(0).Name = "stt"
            dgvDsCTPhanQuyen.Columns("stt").HeaderText = "STT"
            dgvDsCTPhanQuyen.Columns("stt").Width = 50
            dgvDsCTPhanQuyen.Columns("cn_ten").HeaderText = "Tên Chức năng"
            dgvDsCTPhanQuyen.Columns("cn_ten").Width = 380
            dgvDsCTPhanQuyen.Columns("cn_tag").HeaderText = "Số Tag"
            dgvDsCTPhanQuyen.Columns("cn_tag").Width = 60
            dgvDsCTPhanQuyen.Columns("pq_machucnang").HeaderText = "ID"
            dgvDsCTPhanQuyen.Columns("pq_machucnang").Width = 50
            For i As Integer = 0 To dgvDsCTPhanQuyen.Rows.Count - 1
                dgvDsCTPhanQuyen.Rows(i).Cells("stt").Value = i + 1
            Next
        End If
    End Sub
End Class