Public Class Frm_MatHang
    Dim dsmathang, dsloaihang, dsthehiendgvdsmathang As DataTable
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu()
    Dim chisodong As Integer
    Dim dangnhapdulieu As Boolean
    Private Sub Frm_MatHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuDgvDsMatHang()
        DinhdangDgvDsMatHang()
        TaiDuLieuCmbLoaiHang()
        MoDieuKhien(True)
        dangnhapdulieu = False
    End Sub
    Private Sub Frm_MatHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialogResult As DialogResult
        If dangnhapdulieu Then
            dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình? Dữ liệu đang nhập chưa lưu trữ sẽ bị mất khi đóng màn hình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Else
            dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        End If

        If dialogResult = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        MoDieuKhien(False)
        HienCUDBtn(False)
        XoaDuLieu()
        btn_capnhat.Visible = False
        dangnhapdulieu = True
        dsmathang.Reset()
        TaiDuLieuDgvDsMatHang()
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        MoDieuKhien(False)
        HienCUDBtn(False)
        btn_luu.Visible = False
        dangnhapdulieu = True
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim pkcolumns(1) As DataColumn
        pkcolumns(0) = dsmathang.Columns(0)
        dsmathang.PrimaryKey = pkcolumns
        Dim ma = Integer.Parse(txb_ma.Text)
        If CoTheXoaMatHang(ma) Then
            Dim mathang = dsmathang.Rows.Find(ma)
            mathang.Item("mh_daxoa") = 1
            mathang.Item("mh_thoidiemcapnhat") = DateTime.Now
            xl_dulieu.GhiDuLieu("MatHang", dsmathang)
            TaiDuLieuDgvDsMatHang()
            DinhdangDgvDsMatHang()
        Else
            MessageBox.Show("Không thể xóa mặt hàng được chọn vì đã có hợp đồng sử dụng mặt hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        Dim mathang As DataRow = dsmathang.NewRow()
        mathang.Item("mh_ten") = txb_ten.Text
        mathang.Item("mh_maloaihang") = cmb_loaihang.SelectedValue
        mathang.Item("mh_khoiluong") = Double.Parse(txb_khoiluong.Text)
        mathang.Item("mh_thetich") = Double.Parse(txb_thetich.Text)
        mathang.Item("mh_ghichu") = txb_ghichu.Text
        mathang.Item("mh_daxoa") = 0
        mathang.Item("mh_thoidiemtao") = DateTime.Now
        mathang.Item("mh_thoidiemcapnhat") = DateTime.Now
        dsmathang.Rows.Add(mathang)
        xl_dulieu.GhiDuLieu("MatHang", dsmathang)
        TaiDuLieuDgvDsMatHang()
        DinhdangDgvDsMatHang()
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
    End Sub

    Private Sub btn_capnhat_Click(sender As Object, e As EventArgs) Handles btn_capnhat.Click
        Dim pkcolumns(1) As DataColumn
        pkcolumns(0) = dsmathang.Columns(0)
        dsmathang.PrimaryKey = pkcolumns
        Dim ma = Integer.Parse(txb_ma.Text)
        Dim mathang = dsmathang.Rows.Find(ma)
        mathang.Item("mh_ten") = txb_ten.Text
        mathang.Item("mh_maloaihang") = cmb_loaihang.SelectedValue
        mathang.Item("mh_khoiluong") = Double.Parse(txb_khoiluong.Text)
        mathang.Item("mh_thetich") = Double.Parse(txb_thetich.Text)
        mathang.Item("mh_ghichu") = txb_ghichu.Text
        mathang.Item("mh_thoidiemcapnhat") = DateTime.Now
        xl_dulieu.GhiDuLieu("MatHang", dsmathang)
        TaiDuLieuDgvDsMatHang()
        DinhdangDgvDsMatHang()
        HienCUDBtn(True)
        MoDieuKhien(True)
        dangnhapdulieu = False
    End Sub
    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        Me.Close()
    End Sub
    Sub MoDieuKhien(ByVal mo As Boolean)
        txb_ten.ReadOnly = mo
        cmb_loaihang.Enabled = Not mo
        txb_khoiluong.ReadOnly = mo
        txb_thetich.ReadOnly = mo
        txb_ghichu.ReadOnly = mo
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

    Private Sub dgvDsMatHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsMatHang.CellClick
        Dim mathang = dgvDsMatHang.CurrentRow
        If Not mathang.IsNewRow Then
            txb_ma.Text = mathang.Cells(0).Value
            txb_ten.Text = mathang.Cells(1).Value
            cmb_loaihang.SelectedValue = mathang.Cells("mh_maloaihang").Value
            txb_khoiluong.Text = mathang.Cells(3).Value
            txb_thetich.Text = mathang.Cells(4).Value
            txb_ghichu.Text = mathang.Cells(5).Value
            MoDieuKhien(True)
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
        End If
    End Sub

    Private Sub dgvDsMatHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsMatHang.CellContentClick
        Dim mathang = dgvDsMatHang.CurrentRow
        If Not mathang.IsNewRow Then
            txb_ma.Text = mathang.Cells(0).Value
            txb_ten.Text = mathang.Cells(1).Value
            cmb_loaihang.SelectedValue = mathang.Cells("mh_maloaihang").Value
            txb_khoiluong.Text = mathang.Cells(3).Value
            txb_thetich.Text = mathang.Cells(4).Value
            txb_ghichu.Text = mathang.Cells(5).Value
            MoDieuKhien(True)
            btn_sua.Enabled = True
            btn_xoa.Enabled = True
        End If
    End Sub

    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt = txb_noidungtim.Text.ToLower
            Dim dskq =
            From mh In dsthehiendgvdsmathang
            Where mh.Item(1).ToString.ToLower.Contains(ndt) Or mh.Item(2).ToString.ToLower.Contains(ndt)
            Select mh
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
            End If
            dgvDsMatHang.DataSource = dtdskq
        Else
            dgvDsMatHang.DataSource = dsthehiendgvdsmathang
        End If
        DinhdangDgvDsMatHang()
    End Sub

    Sub TaiDuLieuDgvDsMatHang()
        Dim cautruyvan, cautruyvanket As String
        cautruyvan = "select * from MatHang where mh_daxoa = 0"
        cautruyvanket = "select m.mh_ma, m.mh_ten, l.lh_ten, m.mh_khoiluong, m.mh_thetich, m.mh_ghichu,m.mh_daxoa,m.mh_thoidiemcapnhat, m.mh_maloaihang from MatHang m left join LoaiHang l on m.mh_maloaihang = l.lh_ma where m.mh_daxoa =0"
        dsmathang = xl_dulieu.DocDuLieu(cautruyvan)
        dsthehiendgvdsmathang = xl_dulieu.DocDuLieu(cautruyvanket)
        dgvDsMatHang.DataSource = dsthehiendgvdsmathang
    End Sub
    Sub DinhdangDgvDsMatHang()
        If dgvDsMatHang.Columns.Count > 8 Then
            dgvDsMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsMatHang.MultiSelect = False
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
    Sub TaiDuLieuCmbLoaiHang()
        Dim cautruyvan As String
        cautruyvan = "select * from LoaiHang where lh_daxoa = 0"
        dsloaihang = xl_dulieu.DocDuLieu(cautruyvan)
        cmb_loaihang.DataSource = dsloaihang
        cmb_loaihang.DisplayMember = dsloaihang.Columns(1).ColumnName
        cmb_loaihang.ValueMember = dsloaihang.Columns(0).ColumnName
    End Sub
    Function CoTheXoaMatHang(ByVal ma As Integer) As Boolean
        Dim kq As Boolean
        Dim cautruyvantatcacthd = "Select * from CTHopDong where cthd_daxoa =0"
        Dim dstatcacthd = xl_dulieu.DocDuLieu(cautruyvantatcacthd)
        Dim dskq =
            From cthd In dstatcacthd
            Where cthd.Item("cthd_mamathang") = ma
            Select cthd
        If dskq.Count > 0 Then
            kq = False
        Else
            kq = True
        End If
        Return kq
    End Function
    Sub XoaDuLieu()
        txb_ma.ResetText()
        txb_ten.ResetText()
        txb_khoiluong.ResetText()
        txb_thetich.ResetText()
        txb_ghichu.ResetText()
        txb_noidungtim.ResetText()
    End Sub
End Class