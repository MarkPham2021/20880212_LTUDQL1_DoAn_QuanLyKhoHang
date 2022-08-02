Public Class Frm_LoaiNguoiDung_Action
    Public LoaiHanhDong As Integer
    Public LoaiNguoiDung As DataRow
    Public MaLoaiNguoiDung As Integer
    Dim DsLoaiNguoiDung, DsChucNang, DsCTPhanQuyen As DataTable
    Dim isClosed As Boolean = True
    Dim MaCTPhanQuyenTam As Integer = 0
    Dim xl_dulieu As New XL_DuLieu

    Private Sub Frm_LoaiNguoiDung_Action_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDgvDsChucNang()
        TaiDsCtPhanQuyen()

        If LoaiHanhDong = 1 Then
            lbl_tieudeform.Text = "Thêm mới Loại Người Dùng"
            MaLoaiNguoiDung = -1
            TaiCauTrucDgvDsCTPhanQuyen()
            btn_thuchien.BackColor = Color.White
            btn_thuchien.ForeColor = Color.DarkBlue
            TaiCauTrucDgvDsCTPhanQuyen()

        ElseIf LoaiHanhDong = 2 Then
            lbl_tieudeform.Text = "Thay đổi Thông tin Loại Người Dùng"
            txb_maloainguoidung.Text = LoaiNguoiDung("lnd_ma")
            MaLoaiNguoiDung = LoaiNguoiDung("lnd_ma")
            txb_tenloainguoidung.Text = LoaiNguoiDung("lnd_ten")
            txb_motaloainguoidung.Text = LoaiNguoiDung("lnd_mota")
            btn_thuchien.BackColor = Color.White
            btn_thuchien.ForeColor = Color.DarkBlue
            LayDSCTPhanQuyenCuaLoaiNguoiDung(MaLoaiNguoiDung)
        ElseIf LoaiHanhDong = 3 Then
            lbl_tieudeform.Text = "Xóa Loại Người Dùng"
            btn_thuchien.Text = "↓ Xóa"
            txb_maloainguoidung.Text = LoaiNguoiDung("lnd_ma")
            txb_tenloainguoidung.Text = LoaiNguoiDung("lnd_ten")
            txb_motaloainguoidung.Text = LoaiNguoiDung("lnd_mota")
            MaLoaiNguoiDung = LoaiNguoiDung("lnd_ma")
            dgvDsChucNang.Enabled = False
            txb_tenloainguoidung.ReadOnly = True
            txb_motaloainguoidung.ReadOnly = True
            btn_themchucnang.Enabled = False
            btn_xoachucnang.Enabled = False
            btn_thuchien.BackColor = Color.Red
            btn_thuchien.ForeColor = Color.Yellow
            LayDSCTPhanQuyenCuaLoaiNguoiDung(MaLoaiNguoiDung)
        End If
        DinhDangDgvDsCTPhanQuyen()
        DinhDangDgvDsChucNang()

    End Sub
    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub
    Private Sub btn_thuchien_Click(sender As Object, e As EventArgs) Handles btn_thuchien.Click
        If txb_tenloainguoidung.Text.Trim = "" Then
            MessageBox.Show("Vui lòng nhập tên loại người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dgvDsPhanQuyen.Rows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn chức năng được phân quyền cho loại người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cautruyvan As String
            cautruyvan = "select * from LoaiNguoiDung"
            DsLoaiNguoiDung = xl_dulieu.DocDuLieu(cautruyvan)
            If LoaiHanhDong = 1 Then
                Dim lndmoi As DataRow = DsLoaiNguoiDung.NewRow
                lndmoi("lnd_ten") = txb_tenloainguoidung.Text
                lndmoi("lnd_mota") = txb_motaloainguoidung.Text
                lndmoi("lnd_daxoa") = 0
                lndmoi("lnd_thoidiemtao") = DateAndTime.Now
                lndmoi("lnd_thoidiemcapnhat") = DateAndTime.Now
                DsLoaiNguoiDung.Rows.Add(lndmoi)
                xl_dulieu.GhiDuLieu("LoaiNguoiDung", DsLoaiNguoiDung)
                MaLoaiNguoiDung = lndmoi("lnd_ma")
                For Each ctpq As DataRow In DsCTPhanQuyen.Rows
                    If ctpq("pq_maloainguoidung") = -1 Then
                        ctpq("pq_maloainguoidung") = MaLoaiNguoiDung
                    End If
                Next
                xl_dulieu.GhiDuLieu("PhanQuyen", DsCTPhanQuyen)
                Me.Close()
            ElseIf LoaiHanhDong = 2 Then
                Dim lndsua As DataRow = DsLoaiNguoiDung.Select($"lnd_ma = {MaLoaiNguoiDung}")(0)
                lndsua("lnd_ten") = txb_tenloainguoidung.Text
                lndsua("lnd_mota") = txb_motaloainguoidung.Text
                lndsua("lnd_thoidiemcapnhat") = DateAndTime.Now
                xl_dulieu.GhiDuLieu("LoaiNguoiDung", DsLoaiNguoiDung)
                xl_dulieu.GhiDuLieu("PhanQuyen", DsCTPhanQuyen)
                Me.Close()
            ElseIf LoaiHanhDong = 3 Then
                Dim lndxoa As DataRow = DsLoaiNguoiDung.Select($"lnd_ma = {MaLoaiNguoiDung}")(0)

                lndxoa("lnd_daxoa") = 1
                lndxoa("lnd_thoidiemcapnhat") = DateAndTime.Now
                xl_dulieu.GhiDuLieu("LoaiNguoiDung", DsLoaiNguoiDung)
                For Each ctpq As DataRow In DsCTPhanQuyen.Rows
                    If ctpq("pq_maloainguoidung") = MaLoaiNguoiDung Then
                        ctpq("pq_daxoa") = 1
                    End If
                Next
                xl_dulieu.GhiDuLieu("PhanQuyen", DsCTPhanQuyen)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btn_themchucnang_Click(sender As Object, e As EventArgs) Handles btn_themchucnang.Click
        If txb_machucnang.Text.Trim <> "" Then
            MaCTPhanQuyenTam -= 1
            Dim ctpq As DataRow = DsCTPhanQuyen.NewRow
            ctpq.Item("pq_ma") = MaCTPhanQuyenTam
            ctpq.Item("pq_maloainguoidung") = MaLoaiNguoiDung
            ctpq.Item("pq_machucnang") = Integer.Parse(txb_machucnang.Text)
            ctpq.Item("cn_ten") = txb_tenchucnang.Text
            ctpq.Item("cn_tag") = txb_chucnangtagno.Text
            ctpq.Item("pq_daxoa") = 0
            DsCTPhanQuyen.Rows.Add(ctpq)
            LayDSCTPhanQuyenCuaLoaiNguoiDung(MaLoaiNguoiDung)
            DinhDangDgvDsCTPhanQuyen()
            txb_tongsochucnang.Text = dgvDsPhanQuyen.Rows.Count
        Else
            MessageBox.Show("Vui lòng chọn chức năng muốn phân quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_xoachucnang_Click(sender As Object, e As EventArgs) Handles btn_xoachucnang.Click
        If dgvDsPhanQuyen.SelectedRows.Count > 0 Then
            Dim ctpqv = dgvDsPhanQuyen.CurrentRow.DataBoundItem
            Dim ctpq = ctpqv.Row
            If ctpq("pq_ma") < 0 Then
                DsCTPhanQuyen.Rows.Remove(ctpq)
            Else
                ctpq("pq_daxoa") = 1
            End If
            LayDSCTPhanQuyenCuaLoaiNguoiDung(MaLoaiNguoiDung)
            DinhDangDgvDsCTPhanQuyen()
            txb_tongsochucnang.Text = dgvDsPhanQuyen.Rows.Count
        Else
            MessageBox.Show("Vui lòng chọn chức năng đã phân quyền muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txb_timchucnang_TextChanged(sender As Object, e As EventArgs) Handles txb_timchucnang.TextChanged
        If txb_timchucnang.Text.Trim <> "" Then
            Dim noidung As String = txb_timchucnang.Text.ToLower
            Dim dskq = From cn In DsChucNang
                       Where cn("cn_ten").ToString.ToLower().Contains(noidung)
                       Select cn
            Dim dtdskq As DataTable = New DataTable

            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
            End If
            dgvDsChucNang.DataSource = dtdskq
        Else
            dgvDsChucNang.DataSource = DsChucNang
        End If
        DinhDangDgvDsChucNang()

    End Sub
    Private Sub dgvDsChucNang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsChucNang.CellClick
        Dim cnv = dgvDsChucNang.CurrentRow
        If cnv.IsNewRow = False Then
            txb_machucnang.Text = cnv.Cells("cn_ma").Value
            txb_tenchucnang.Text = cnv.Cells("cn_ten").Value
            txb_chucnangtagno.Text = cnv.Cells("cn_tag").Value

        End If

    End Sub
    Sub TaiDgvDsChucNang()
        Dim cautruyvan = "select cn_ma, cn_ten,cn_tag from ChucNang"
        DsChucNang = xl_dulieu.DocDuLieu(cautruyvan)
        dgvDsChucNang.DataSource = DsChucNang
    End Sub
    Sub DinhDangDgvDsChucNang()
        If dgvDsChucNang.Columns.Count = 3 Then
            dgvDsChucNang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsChucNang.MultiSelect = False
            dgvDsChucNang.Columns("cn_ma").HeaderText = "Chức năng ID"
            dgvDsChucNang.Columns("cn_ma").Width = 60
            dgvDsChucNang.Columns("cn_ten").HeaderText = "Tên chức năng"
            dgvDsChucNang.Columns("cn_ten").Width = 220
            dgvDsChucNang.Columns("cn_tag").HeaderText = "Số Tag"
            dgvDsChucNang.Columns("cn_tag").Width = 60
        End If
    End Sub
    Sub TaiDsCtPhanQuyen()
        Dim cautruyvan As String = "select pq_ma, cn_ten,cn_tag, pq_machucnang, pq_maloainguoidung, pq_daxoa 
                                      from PhanQuyen join ChucNang on pq_machucnang = cn_ma
                                      where pq_daxoa =0"
        DsCTPhanQuyen = xl_dulieu.DocDuLieu(cautruyvan)
    End Sub
    Sub TaiCauTrucDgvDsCTPhanQuyen()
        Dim cautruyvan As String = "select pq_ma, cn_ten,cn_tag, pq_machucnang, pq_maloainguoidung, pq_daxoa 
                                      from PhanQuyen join ChucNang on pq_machucnang = cn_ma
                                      where pq_daxoa =0"
        Dim DsCTPhanQuyenCT = xl_dulieu.DocCauTruc(cautruyvan)
        dgvDsPhanQuyen.DataSource = DsCTPhanQuyenCT
    End Sub

    Sub LayDSCTPhanQuyenCuaLoaiNguoiDung(ByVal maloainguoidung As Integer)
        Dim dsctpqv As DataView = DsCTPhanQuyen.AsDataView
        dsctpqv.RowFilter() = $"pq_maloainguoidung = {maloainguoidung} and pq_daxoa =0"
        dgvDsPhanQuyen.DataSource = dsctpqv
    End Sub
    Sub DinhDangDgvDsCTPhanQuyen()
        If dgvDsPhanQuyen.Columns.Count = 6 Then
            Dim CotStt As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            dgvDsPhanQuyen.Columns.Insert(0, CotStt)
            dgvDsPhanQuyen.Columns(0).Name = "stt"
            dgvDsPhanQuyen.Columns("stt").HeaderText = "STT"
            dgvDsPhanQuyen.Columns("stt").Width = 55
            dgvDsPhanQuyen.Columns("cn_ten").HeaderText = "Tên chức năng"
            dgvDsPhanQuyen.Columns("cn_ten").Width = 355
            dgvDsPhanQuyen.Columns("cn_tag").HeaderText = "Số tag"
            dgvDsPhanQuyen.Columns("cn_tag").Width = 65
            dgvDsPhanQuyen.Columns("pq_ma").Visible = False
            dgvDsPhanQuyen.Columns("pq_machucnang").Visible = False
            dgvDsPhanQuyen.Columns("pq_maloainguoidung").Visible = False
            dgvDsPhanQuyen.Columns("pq_daxoa").Visible = False
            For i As Integer = 0 To dgvDsPhanQuyen.Rows.Count - 1
                dgvDsPhanQuyen.Rows(i).Cells("stt").Value = i + 1
            Next
            txb_tongsochucnang.Text = dgvDsPhanQuyen.Rows.Count
        ElseIf dgvDsPhanQuyen.Columns.Count = 7 Then
            dgvDsPhanQuyen.Columns(0).Name = "stt"
            dgvDsPhanQuyen.Columns("stt").HeaderText = "STT"
            dgvDsPhanQuyen.Columns("stt").Width = 55
            dgvDsPhanQuyen.Columns("cn_ten").HeaderText = "Tên chức năng"
            dgvDsPhanQuyen.Columns("cn_ten").Width = 355
            dgvDsPhanQuyen.Columns("cn_tag").HeaderText = "Số tag"
            dgvDsPhanQuyen.Columns("cn_tag").Width = 65
            dgvDsPhanQuyen.Columns("pq_ma").Visible = False
            dgvDsPhanQuyen.Columns("pq_machucnang").Visible = False
            dgvDsPhanQuyen.Columns("pq_maloainguoidung").Visible = False
            dgvDsPhanQuyen.Columns("pq_daxoa").Visible = False
            For i As Integer = 0 To dgvDsPhanQuyen.Rows.Count - 1
                dgvDsPhanQuyen.Rows(i).Cells("stt").Value = i + 1
            Next
            txb_tongsochucnang.Text = dgvDsPhanQuyen.Rows.Count
        End If
    End Sub
End Class