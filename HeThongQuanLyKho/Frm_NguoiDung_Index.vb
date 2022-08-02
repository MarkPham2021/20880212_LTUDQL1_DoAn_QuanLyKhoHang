Public Class Frm_NguoiDung_Index
    Dim dsnguoidung, dsnguoidung2 As DataTable
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu()
    Private Sub Frm_NguoiDung_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuDgvDsNguoiDung()
    End Sub
    Private Sub dgwdsnguoidung_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwdsnguoidung.CellClick
        Dim nguoidung = dgwdsnguoidung.CurrentRow
        If Not nguoidung.IsNewRow Then
            lbl_ma.Text = nguoidung.Cells(0).Value
            lbl_manhanvien.Text = nguoidung.Cells(2).Value
            lbl_hoten.Text = nguoidung.Cells(3).Value
            lbl_tendonvi.Text = nguoidung.Cells(5).Value
            lbl_dienthoai.Text = nguoidung.Cells(6).Value
            lbl_email.Text = nguoidung.Cells(7).Value
            lbl_lnd_ten.Text = nguoidung.Cells(4).Value
            lbl_nd_tendangnhap.Text = nguoidung.Cells(1).Value
            chb_dakichhoat.Checked = nguoidung.Cells(8).Value
            chb_daxoa.Checked = nguoidung.Cells(9).Value
        End If
    End Sub
    Private Sub dgwdsnguoidung_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwdsnguoidung.CellContentClick
        Dim nguoidung = dgwdsnguoidung.CurrentRow
        If Not nguoidung.IsNewRow Then
            lbl_ma.Text = nguoidung.Cells(0).Value
            lbl_manhanvien.Text = nguoidung.Cells(2).Value
            lbl_hoten.Text = nguoidung.Cells(3).Value
            lbl_tendonvi.Text = nguoidung.Cells(5).Value
            lbl_dienthoai.Text = nguoidung.Cells(6).Value
            lbl_email.Text = nguoidung.Cells(7).Value
            lbl_lnd_ten.Text = nguoidung.Cells(4).Value
            lbl_nd_tendangnhap.Text = nguoidung.Cells(1).Value
            chb_dakichhoat.Checked = nguoidung.Cells(8).Value
            chb_daxoa.Checked = nguoidung.Cells(9).Value
        End If

    End Sub
    Private Sub btn_khoa_Click(sender As Object, e As EventArgs) Handles btn_khoa.Click
        Dim pkcolumns(0) As DataColumn
        pkcolumns(0) = dsnguoidung2.Columns(0)
        dsnguoidung2.PrimaryKey = pkcolumns
        Dim ma As Integer
        Dim hople As Boolean = Integer.TryParse(lbl_ma.Text, ma)
        If hople Then
            Dim nguoidung = dsnguoidung2.Rows.Find(ma)
            nguoidung.Item("nd_dakichhoat") = 0
            nguoidung.Item("nd_thoidiemcapnhat") = DateAndTime.Now()
            xl_dulieu.GhiDuLieu("NguoiDung", dsnguoidung2)
            MessageBox.Show("Đã khóa tài khoản được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TaiDuLieuDgvDsNguoiDung()
        Else
            MessageBox.Show("Vui lòng chọn tài khoản muốn khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim pkcolumns(0) As DataColumn
        pkcolumns(0) = dsnguoidung2.Columns(0)
        dsnguoidung2.PrimaryKey = pkcolumns
        Dim ma As Integer
        Dim hople As Boolean = Integer.TryParse(lbl_ma.Text, ma)
        If hople Then
            Dim nguoidung = dsnguoidung2.Rows.Find(ma)
            nguoidung.Item("nd_daxoa") = 1
            nguoidung.Item("nd_thoidiemcapnhat") = DateAndTime.Now()
            xl_dulieu.GhiDuLieu("NguoiDung", dsnguoidung2)
            MessageBox.Show("Đã xóa tài khoản được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TaiDuLieuDgvDsNguoiDung()
        Else
            MessageBox.Show("Vui lòng chọn tài khoản muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_datlaimatkhau_Click(sender As Object, e As EventArgs) Handles btn_datlaimatkhau.Click
        Dim pkcolumns(0) As DataColumn
        pkcolumns(0) = dsnguoidung2.Columns(0)
        dsnguoidung2.PrimaryKey = pkcolumns
        Dim ma As Integer
        Dim hople As Boolean = Integer.TryParse(lbl_ma.Text, ma)
        If hople Then
            Dim nguoidung = dsnguoidung2.Rows.Find(ma)
            nguoidung.Item("nd_matkhau") = Util.MaHoa("123")
            nguoidung.Item("nd_thoidiemcapnhat") = DateAndTime.Now()
            xl_dulieu.GhiDuLieu("NguoiDung", dsnguoidung2)
            MessageBox.Show("Đã đặt lại mật khẩu mặc định cho tài khoản được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TaiDuLieuDgvDsNguoiDung()
        Else
            MessageBox.Show("Vui lòng chọn tài khoản muốn đặt lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        Me.Close()
    End Sub

    Private Sub btn_kichhoat_Click(sender As Object, e As EventArgs) Handles btn_kichhoat.Click
        Dim pkcolumns(0) As DataColumn
        pkcolumns(0) = dsnguoidung2.Columns(0)
        dsnguoidung2.PrimaryKey = pkcolumns
        Dim ma As Integer
        Dim hople As Boolean = Integer.TryParse(lbl_ma.Text, ma)
        If hople Then
            Dim nguoidung = dsnguoidung2.Rows.Find(ma)
            nguoidung.Item("nd_dakichhoat") = 1
            nguoidung.Item("nd_thoidiemcapnhat") = DateAndTime.Now()
            xl_dulieu.GhiDuLieu("NguoiDung", dsnguoidung2)
            MessageBox.Show("Đã kích hoạt tài khoản được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TaiDuLieuDgvDsNguoiDung()
        Else
            MessageBox.Show("Vui lòng chọn tài khoản muốn kích hoạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt As String = txb_noidungtim.Text.Trim.ToLower
            Dim dtdskq As DataTable = New DataTable
            Dim dskq =
                From nd In dsnguoidung
                Where nd.Item(1).ToString.ToLower.Contains(ndt) Or nd.Item(2).ToString.ToLower.Contains(ndt) Or nd.Item(3).ToString.ToLower.Contains(ndt) Or nd.Item(4).ToString.ToLower.Contains(ndt) Or nd.Item(5).ToString.ToLower.Contains(ndt) Or nd.Item(6).ToString.ToLower.Contains(ndt) Or nd.Item(7).ToString.ToLower.Contains(ndt)
                Select nd
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
            End If
            dgwdsnguoidung.DataSource = dtdskq
        Else
            dgwdsnguoidung.DataSource = dsnguoidung
        End If
        DinhdangDgvDsNguoiDung()
    End Sub

    Sub TaiDuLieuDgvDsNguoiDung()
        Dim cautruyvan, cautruyvan2 As String
        cautruyvan = "select n.nd_ma, n.nd_tendangnhap,n.nd_manhanvien, n.nd_hoten, l.lnd_ten, d.dv_ten, n.nd_dienthoai,n.nd_email, n.nd_dakichhoat, nd_daxoa,n.nd_matkhau from NguoiDung n left join LoaiNguoiDung l on l.lnd_ma= n.nd_maloainguoidung left join DonVi d on d.dv_ma=n.nd_madonvi where n.nd_daxoa=0"
        cautruyvan2 = "select * from NguoiDung where nd_daxoa = 0"
        dsnguoidung = xl_dulieu.DocDuLieu(cautruyvan)
        dsnguoidung2 = xl_dulieu.DocDuLieu(cautruyvan2)
        dgwdsnguoidung.DataSource = dsnguoidung
        If dgwdsnguoidung.Columns.Count > 10 Then
            dgwdsnguoidung.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgwdsnguoidung.RowHeadersVisible = False
            dgwdsnguoidung.MultiSelect = False
            dgwdsnguoidung.Columns(0).HeaderText = "Mã tài khoản"
            dgwdsnguoidung.Columns(0).AutoSizeMode = False
            dgwdsnguoidung.Columns(0).Width = 70
            dgwdsnguoidung.Columns(1).HeaderText = "Tên đăng nhập"
            dgwdsnguoidung.Columns(1).AutoSizeMode = False
            dgwdsnguoidung.Columns(1).Width = 80
            dgwdsnguoidung.Columns(2).HeaderText = "Mã nhân viên"
            dgwdsnguoidung.Columns(2).AutoSizeMode = False
            dgwdsnguoidung.Columns(2).Width = 50
            dgwdsnguoidung.Columns(3).HeaderText = "Họ tên"
            dgwdsnguoidung.Columns(3).AutoSizeMode = False
            dgwdsnguoidung.Columns(3).Width = 130
            dgwdsnguoidung.Columns(4).HeaderText = "Loại tài khoản"
            dgwdsnguoidung.Columns(4).AutoSizeMode = False
            dgwdsnguoidung.Columns(4).Width = 150
            dgwdsnguoidung.Columns(5).HeaderText = "Thuộc Đơn vị"
            dgwdsnguoidung.Columns(5).AutoSizeMode = False
            dgwdsnguoidung.Columns(5).Width = 160
            dgwdsnguoidung.Columns(6).HeaderText = "Điện thoại"
            dgwdsnguoidung.Columns(6).AutoSizeMode = False
            dgwdsnguoidung.Columns(6).Width = 80
            dgwdsnguoidung.Columns(7).HeaderText = "Email"
            dgwdsnguoidung.Columns(7).AutoSizeMode = False
            dgwdsnguoidung.Columns(7).Width = 140
            dgwdsnguoidung.Columns(8).HeaderText = "Đã kích hoạt"
            dgwdsnguoidung.Columns(8).AutoSizeMode = False
            dgwdsnguoidung.Columns(8).Width = 70
            dgwdsnguoidung.Columns(8).ReadOnly = True
            dgwdsnguoidung.Columns(9).HeaderText = "Đã xóa"
            dgwdsnguoidung.Columns(9).AutoSizeMode = False
            dgwdsnguoidung.Columns(9).Width = 50
            dgwdsnguoidung.Columns(9).ReadOnly = True
            dgwdsnguoidung.Columns(9).Visible = False
            dgwdsnguoidung.Columns(10).Visible = False
            chb_dakichhoat.Enabled = False
            chb_daxoa.Enabled = False
        End If
    End Sub
    Sub DinhdangDgvDsNguoiDung()
        If dgwdsnguoidung.Columns.Count > 10 Then
            dgwdsnguoidung.Columns(0).HeaderText = "Mã tài khoản"
            dgwdsnguoidung.Columns(0).AutoSizeMode = False
            dgwdsnguoidung.Columns(0).Width = 70
            dgwdsnguoidung.Columns(1).HeaderText = "Tên đăng nhập"
            dgwdsnguoidung.Columns(1).AutoSizeMode = False
            dgwdsnguoidung.Columns(1).Width = 80
            dgwdsnguoidung.Columns(2).HeaderText = "Mã nhân viên"
            dgwdsnguoidung.Columns(2).AutoSizeMode = False
            dgwdsnguoidung.Columns(2).Width = 50
            dgwdsnguoidung.Columns(3).HeaderText = "Họ tên"
            dgwdsnguoidung.Columns(3).AutoSizeMode = False
            dgwdsnguoidung.Columns(3).Width = 130
            dgwdsnguoidung.Columns(4).HeaderText = "Loại tài khoản"
            dgwdsnguoidung.Columns(4).AutoSizeMode = False
            dgwdsnguoidung.Columns(4).Width = 150
            dgwdsnguoidung.Columns(5).HeaderText = "Thuộc Đơn vị"
            dgwdsnguoidung.Columns(5).AutoSizeMode = False
            dgwdsnguoidung.Columns(5).Width = 160
            dgwdsnguoidung.Columns(6).HeaderText = "Điện thoại"
            dgwdsnguoidung.Columns(6).AutoSizeMode = False
            dgwdsnguoidung.Columns(6).Width = 80
            dgwdsnguoidung.Columns(7).HeaderText = "Email"
            dgwdsnguoidung.Columns(7).AutoSizeMode = False
            dgwdsnguoidung.Columns(7).Width = 140
            dgwdsnguoidung.Columns(8).HeaderText = "Đã kích hoạt"
            dgwdsnguoidung.Columns(8).AutoSizeMode = False
            dgwdsnguoidung.Columns(8).Width = 70
            dgwdsnguoidung.Columns(8).ReadOnly = True
            dgwdsnguoidung.Columns(9).HeaderText = "Đã xóa"
            dgwdsnguoidung.Columns(9).AutoSizeMode = False
            dgwdsnguoidung.Columns(9).Width = 50
            dgwdsnguoidung.Columns(9).ReadOnly = True
            dgwdsnguoidung.Columns(9).Visible = False
            dgwdsnguoidung.Columns(10).Visible = False
            chb_dakichhoat.Enabled = False
            chb_daxoa.Enabled = False
        End If
    End Sub
End Class