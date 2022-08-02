Public Class Frm_KhachHang
    Dim dskhachhang, dsloaigtpl, dshopdong As DataTable
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu()
    Dim chisodong As Integer
    Dim dangnhapdulieu As Boolean
    Private Sub Frm_KhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuDgvDsKhachHang()
        DinhdangdgvDSKhachHang()
        TaiDuLieuCmbLoaiGTPL()
        TaiDuLieuDgvDsHopDong()
        DinhdangDgvDsHopDong()
        MoDieuKhien(True)
        dgvDsHopDong.Visible = False
        lbl_nhandgvdshopdong.Visible = False
        dangnhapdulieu = False
    End Sub

    Private Sub Frm_KhachHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialogResult As DialogResult
        If dangnhapdulieu Then
            dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình? Dữ liệu đang nhập chưa lưu trữ sẽ bị mất khi đóng màn hình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Else
            dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        End If

        If dialogResult = DialogResult.No Then
            e.Cancel = True
        End If
        MoDieuKhien(True)
        btn_sua.Enabled = True
        btn_xoa.Enabled = True
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        MoDieuKhien(False)
        HienCUDBtn(False)
        dskhachhang.Reset()
        TaiDuLieuDgvDsKhachHang()
        DinhdangdgvDSKhachHang()
        btn_capnhat.Visible = False
        dangnhapdulieu = True
        XoaDuLieu()
        dgvDsHopDong.Visible = False
        lbl_nhandgvdshopdong.Visible = False
    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        Dim khachhang As DataRow = dskhachhang.NewRow()
        khachhang.Item(1) = txb_ten.Text
        khachhang.Item(7) = cmb_loaigtpl.SelectedValue
        khachhang.Item(2) = cmb_loaigtpl.SelectedItem("gt_ten")
        khachhang.Item(3) = txb_gtplso.Text
        khachhang.Item(4) = txb_diachi.Text
        khachhang.Item(5) = txb_dienthoai.Text
        khachhang.Item(6) = txb_email.Text
        khachhang.Item(8) = DateTime.Now
        khachhang.Item(9) = 0
        dskhachhang.Rows.Add(khachhang)
        xl_dulieu.GhiDuLieuTuDo("select kh_ma, kh_ten, kh_maloaigtpl, kh_gtplso,kh_diachi, kh_dienthoai, kh_email, kh_thoidiemcapnhat, kh_daxoa from KhachHang", dskhachhang)
        TaiDuLieuDgvDsKhachHang()
        DinhdangdgvDSKhachHang()
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
        dgvDsHopDong.Visible = False
        lbl_nhandgvdshopdong.Visible = False
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        MoDieuKhien(False)
        HienCUDBtn(False)
        btn_luu.Visible = False
        dangnhapdulieu = True
        dgvDsHopDong.Visible = False
        lbl_nhandgvdshopdong.Visible = False
    End Sub

    Private Sub btn_capnhat_Click(sender As Object, e As EventArgs) Handles btn_capnhat.Click
        Dim pkcls(1) As DataColumn
        pkcls(0) = dskhachhang.Columns(0)
        dskhachhang.PrimaryKey = pkcls
        Dim khachhang As DataRow = dskhachhang.Rows.Find(Integer.Parse(txb_ma.Text))
        khachhang.Item(1) = txb_ten.Text
        khachhang.Item(7) = cmb_loaigtpl.SelectedValue
        khachhang.Item(2) = cmb_loaigtpl.SelectedItem("gt_ten")
        khachhang.Item(3) = txb_gtplso.Text
        khachhang.Item(4) = txb_diachi.Text
        khachhang.Item(5) = txb_dienthoai.Text
        khachhang.Item(6) = txb_email.Text
        khachhang.Item(8) = DateTime.Now
        xl_dulieu.GhiDuLieuTuDo("select kh_ma, kh_ten, kh_maloaigtpl, kh_gtplso,kh_diachi, kh_dienthoai, kh_email, kh_thoidiemcapnhat, kh_daxoa from KhachHang", dskhachhang)
        TaiDuLieuDgvDsKhachHang()
        DinhdangdgvDSKhachHang()
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
        dgvDsHopDong.Visible = False
        lbl_nhandgvdshopdong.Visible = False
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim pkcls(1) As DataColumn
        pkcls(0) = dskhachhang.Columns(0)
        dskhachhang.PrimaryKey = pkcls
        Dim khachhang As DataRow = dskhachhang.Rows.Find(Integer.Parse(txb_ma.Text))
        khachhang.Item(9) = 1
        xl_dulieu.GhiDuLieuTuDo("select kh_ma, kh_ten, kh_maloaigtpl, kh_gtplso,kh_diachi, kh_dienthoai, kh_email, kh_thoidiemcapnhat, kh_daxoa from KhachHang", dskhachhang)
        TaiDuLieuDgvDsKhachHang()
        DinhdangdgvDSKhachHang()
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
        dgvDsHopDong.Visible = False
        lbl_nhandgvdshopdong.Visible = False
    End Sub

    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        Me.Close()
    End Sub
    Private Sub dgvDsKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsKhachHang.CellClick
        Dim khachhang = dgvDsKhachHang.CurrentRow
        If Not khachhang.IsNewRow Then
            txb_ma.Text = khachhang.Cells(0).Value
            txb_ten.Text = khachhang.Cells(1).Value
            cmb_loaigtpl.Text = khachhang.Cells(2).Value
            txb_gtplso.Text = khachhang.Cells(3).Value
            txb_diachi.Text = khachhang.Cells(4).Value
            txb_dienthoai.Text = khachhang.Cells(5).Value
            txb_email.Text = khachhang.Cells(6).Value
            HienCUDBtn(True)
            MoDieuKhien(True)
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
            dangnhapdulieu = False
            dgvDsHopDong.Visible = True
            lbl_nhandgvdshopdong.Visible = True
            Dim dshd =
                From hd In dshopdong
                Where hd("hd_makhachhang") = khachhang.Cells(0).Value
                Select hd
            Dim dtdshd As DataTable = New DataTable
            If dshd.Count > 0 Then
                dtdshd = dshd.CopyToDataTable()
            End If
            dgvDsHopDong.DataSource = dtdshd
            DinhdangDgvDsHopDong()
        End If
        DinhdangDgvDsHopDong()

    End Sub
    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt As String = txb_noidungtim.Text.ToLower
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
        dgvDsHopDong.Visible = False
        lbl_nhandgvdshopdong.Visible = False
    End Sub
    Sub MoDieuKhien(ByVal mo As Boolean)
        txb_ten.ReadOnly = mo
        cmb_loaigtpl.Enabled = Not mo
        txb_gtplso.ReadOnly = mo
        txb_diachi.ReadOnly = mo
        txb_dienthoai.ReadOnly = mo
        txb_email.ReadOnly = mo
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
    Sub TaiDuLieuDgvDsKhachHang()
        Dim cautruyvankhachhang As String
        cautruyvankhachhang = "select k.kh_ma, k.kh_ten, l.gt_ten, k.kh_gtplso, k.kh_diachi, k.kh_dienthoai, k.kh_email, k.kh_maloaigtpl, k.kh_thoidiemcapnhat, k.kh_daxoa 
                                from KhachHang k join LoaiGiayToPhapLy l on l.gt_ma= k.kh_maloaigtpl where k.kh_daxoa = 0"
        dskhachhang = xl_dulieu.DocDuLieu(cautruyvankhachhang)
        dgvDsKhachHang.DataSource = dskhachhang
    End Sub
    Sub DinhdangdgvDSKhachHang()
        If dgvDsKhachHang.Columns.Count > 9 Then
            dgvDsKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsKhachHang.MultiSelect = False
            dgvDsKhachHang.RowHeadersVisible = False

            dgvDsKhachHang.Columns(0).HeaderText = "Mã khách hàng"
            dgvDsKhachHang.Columns(0).AutoSizeMode = False
            dgvDsKhachHang.Columns(0).Width = 70
            dgvDsKhachHang.Columns(1).HeaderText = "Tên khách hàng"
            dgvDsKhachHang.Columns(1).AutoSizeMode = False
            dgvDsKhachHang.Columns(1).Width = 170
            dgvDsKhachHang.Columns(2).HeaderText = "Loại GTPL"
            dgvDsKhachHang.Columns(2).AutoSizeMode = False
            dgvDsKhachHang.Columns(2).Width = 110
            dgvDsKhachHang.Columns(3).HeaderText = "GTPL số"
            dgvDsKhachHang.Columns(3).AutoSizeMode = False
            dgvDsKhachHang.Columns(3).Width = 90
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
    Sub TaiDuLieuDgvDsHopDong()
        Dim cautruyvanhopdong As String
        cautruyvanhopdong = "select hd_ma, hd_ngayhopdong,hd_soluongmathang,hd_ngaybatdau,hd_ngayhethan,hd_cohieuluc, hd_makhachhang                              
                            from HopDong where hd_daxoa = 0"
        dshopdong = xl_dulieu.DocDuLieu(cautruyvanhopdong)
        dgvDsHopDong.DataSource = dshopdong
    End Sub

    Private Sub txb_ma_TextChanged(sender As Object, e As EventArgs) Handles txb_ma.TextChanged

    End Sub

    Private Sub txb_ten_TextChanged(sender As Object, e As EventArgs) Handles txb_ten.TextChanged

    End Sub

    Private Sub txb_diachi_TextChanged(sender As Object, e As EventArgs) Handles txb_diachi.TextChanged

    End Sub

    Sub DinhdangDgvDsHopDong()
        If dgvDsHopDong.Columns.Count = 7 Then
            Dim stt As New DataGridViewTextBoxColumn
            dgvDsHopDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsHopDong.MultiSelect = False
            dgvDsHopDong.RowHeadersVisible = False

            dgvDsHopDong.Columns.Insert(0, stt)
            dgvDsHopDong.Columns(0).HeaderText = "STT"
            dgvDsHopDong.Columns(0).Width = 60
            dgvDsHopDong.Columns(1).HeaderText = "Mã hợp đồng"
            dgvDsHopDong.Columns(1).AutoSizeMode = False
            dgvDsHopDong.Columns(1).Width = 110
            dgvDsHopDong.Columns(2).HeaderText = "Ngày hợp đồng"
            dgvDsHopDong.Columns(2).AutoSizeMode = False
            dgvDsHopDong.Columns(2).Width = 90
            dgvDsHopDong.Columns(3).HeaderText = "Số lượng mặt hàng"
            dgvDsHopDong.Columns(3).AutoSizeMode = False
            dgvDsHopDong.Columns(3).Width = 80
            dgvDsHopDong.Columns(4).HeaderText = "Ngày bắt đầu"
            dgvDsHopDong.Columns(4).AutoSizeMode = False
            dgvDsHopDong.Columns(4).Width = 90
            dgvDsHopDong.Columns(5).HeaderText = "Ngày hết hạn"
            dgvDsHopDong.Columns(5).AutoSizeMode = False
            dgvDsHopDong.Columns(5).Width = 90
            dgvDsHopDong.Columns(6).HeaderText = "Có hiệu lực"
            dgvDsHopDong.Columns(6).AutoSizeMode = False
            dgvDsHopDong.Columns(6).Width = 80
            dgvDsHopDong.Columns(7).Visible = False
            For i As Integer = 0 To dgvDsHopDong.Rows.Count - 1
                dgvDsHopDong.Rows(i).Cells(0).Value = i + 1
            Next
        ElseIf dgvDsHopDong.Columns.Count = 8 Then
            dgvDsHopDong.Columns(0).HeaderText = "STT"
            dgvDsHopDong.Columns(0).Width = 60
            dgvDsHopDong.Columns(1).HeaderText = "Mã hợp đồng"
            dgvDsHopDong.Columns(1).AutoSizeMode = False
            dgvDsHopDong.Columns(1).Width = 110
            dgvDsHopDong.Columns(2).HeaderText = "Ngày hợp đồng"
            dgvDsHopDong.Columns(2).AutoSizeMode = False
            dgvDsHopDong.Columns(2).Width = 90
            dgvDsHopDong.Columns(3).HeaderText = "Số lượng mặt hàng"
            dgvDsHopDong.Columns(3).AutoSizeMode = False
            dgvDsHopDong.Columns(3).Width = 80
            dgvDsHopDong.Columns(4).HeaderText = "Ngày bắt đầu"
            dgvDsHopDong.Columns(4).AutoSizeMode = False
            dgvDsHopDong.Columns(4).Width = 90
            dgvDsHopDong.Columns(5).HeaderText = "Ngày hết hạn"
            dgvDsHopDong.Columns(5).AutoSizeMode = False
            dgvDsHopDong.Columns(5).Width = 90
            dgvDsHopDong.Columns(6).HeaderText = "Có hiệu lực"
            dgvDsHopDong.Columns(6).AutoSizeMode = False
            dgvDsHopDong.Columns(6).Width = 80
            dgvDsHopDong.Columns(7).Visible = False
            For i As Integer = 0 To dgvDsHopDong.Rows.Count - 1
                dgvDsHopDong.Rows(i).Cells(0).Value = i + 1
            Next
        End If
    End Sub
    Sub TaiDuLieuCmbLoaiGTPL()
        Dim cautruyvanloaigtpl As String
        cautruyvanloaigtpl = "select gt_ma, gt_ten from LoaiGiayToPhapLy where gt_daxoa=0"
        dsloaigtpl = xl_dulieu.DocDuLieu(cautruyvanloaigtpl)
        cmb_loaigtpl.DataSource = dsloaigtpl
        cmb_loaigtpl.DisplayMember = dsloaigtpl.Columns(1).ColumnName
        cmb_loaigtpl.ValueMember = dsloaigtpl.Columns(0).ColumnName
    End Sub
    Sub XoaDuLieu()
        txb_ma.ResetText()
        txb_ten.ResetText()
        txb_gtplso.ResetText()
        txb_diachi.ResetText()
        txb_dienthoai.ResetText()
        txb_email.ResetText()
    End Sub
End Class