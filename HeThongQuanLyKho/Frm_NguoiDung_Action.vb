Public Class Frm_NguoiDung_Action
    Public LoaiHanhDong As Integer  '1: Đăng ký tài khoản, 2: Thay đổi thông tin tài khoản
    Dim isClosed As Boolean = True
    Dim dsnguoidung, dsdonvi, dsloainguoidung As DataTable
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu
    Private Sub Frm_NguoiDung_DangKy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuNguoiDung()
        TaiDuLieuCmbDonVi()
        TaiDuLieuCmbLoaiNguoiDung()
        If LoaiHanhDong = 1 Then
            lbl_tieudeform.Text = "Đăng ký Tài Khoản"
        ElseIf LoaiHanhDong = 2 Then
            lbl_tieudeform.Text = "Thay đổi Thông tin Tài Khoản"
            Dim nguoidung = My.MyApplication.NguoiDung
            txb_ma.Text = nguoidung.Item("nd_ma")
            txb_manhanvien.Text = nguoidung.Item("nd_manhanvien")
            txb_tendangnhap.Text = nguoidung.Item("nd_tendangnhap")
            txb_tendangnhap.ReadOnly = True
            txb_tennhanvien.Text = nguoidung.Item("nd_hoten")
            txb_dienthoai.Text = nguoidung.Item("nd_dienthoai")
            txb_email.Text = nguoidung.Item("nd_email")
            cmb_thuocdonvi.Text = nguoidung.Item("dv_ten")
            cmb_loainguoidung.Text = nguoidung.Item("lnd_ten")
        End If
    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        Dim hople As Boolean = True
        Dim chuoibaoloi As String = ""
        Dim canpheduyet As Boolean = False
        If LoaiHanhDong = 1 Then
            Dim nguoidung As DataRow = dsnguoidung.NewRow

            Dim ndtrung1 = From nd In dsnguoidung
                           Where nd.Item("nd_tendangnhap") = txb_tendangnhap.Text
                           Select nd
            If ndtrung1.Count > 0 Then
                hople = False
                chuoibaoloi += " tên đăng nhập vừa nhập đã tồn tại " & Chr(13)
            Else
                nguoidung.Item("nd_tendangnhap") = txb_tendangnhap.Text
            End If

            If txb_matkhau.Text <> txb_matkhaucheck.Text Or txb_matkhau.Text.Trim = "" Then
                hople = False
                chuoibaoloi += " mật khẩu không hợp lệ " & Chr(13)
            Else
                nguoidung.Item("nd_matkhau") = Util.MaHoa(txb_matkhau.Text)
            End If

            Dim ndtrung2 = dsnguoidung.Select("nd_manhanvien = " + txb_manhanvien.Text)
            If ndtrung2.Length > 0 Then
                hople = False
                chuoibaoloi += " mã nhân viên vừa nhập đã tồn tại"
            Else
                nguoidung.Item("nd_manhanvien") = txb_manhanvien.Text
            End If
            nguoidung.Item("nd_hoten") = txb_tennhanvien.Text
            nguoidung.Item("nd_dienthoai") = txb_dienthoai.Text
            nguoidung.Item("nd_email") = txb_email.Text
            nguoidung.Item("nd_madonvi") = cmb_thuocdonvi.SelectedValue
            nguoidung.Item("nd_maloainguoidung") = cmb_loainguoidung.SelectedValue
            nguoidung.Item("nd_dakichhoat") = 0
            nguoidung.Item("nd_daxoa") = 0
            nguoidung.Item("nd_thoidiemtao") = DateTime.Now
            nguoidung.Item("nd_thoidiemcapnhat") = DateTime.Now
            If hople Then
                dsnguoidung.Rows.Add(nguoidung)
                xl_dulieu.GhiDuLieu("NguoiDung", dsnguoidung)
                Me.Close()
            Else
                MessageBox.Show(chuoibaoloi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf LoaiHanhDong = 2 Then
            Dim pkclms(1) As DataColumn
            pkclms(0) = dsnguoidung.Columns(0)
            dsnguoidung.PrimaryKey = pkclms
            Dim nguoidung = dsnguoidung.Rows.Find(Integer.Parse(txb_ma.Text))
            If nguoidung.Item("nd_tendangnhap") <> txb_tendangnhap.Text Then
                Dim ndtrung = dsnguoidung.Select("nd_tendangnhap = " + txb_tendangnhap.Text)
                If ndtrung.Length > 0 Then
                    hople = False
                    chuoibaoloi += "Tên đăng nhập vừa nhập đã tồn tại " & Chr(13)
                Else
                    nguoidung.Item("nd_tendangnhap") = txb_tendangnhap.Text
                End If
            End If
            If txb_matkhau.Text <> txb_matkhaucheck.Text Then
                hople = False
                chuoibaoloi += "Mật khẩu chưa khớp với xác nhận mật khẩu" & Chr(13)
            ElseIf txb_matkhau.Text.Trim <> "" Then
                nguoidung.Item("nd_matkhau") = Util.MaHoa(txb_matkhau.Text)
            End If
            If nguoidung.Item("nd_manhanvien") <> txb_manhanvien.Text Then
                Dim ndtrung = dsnguoidung.Select("nd_manhanvien = " + txb_manhanvien.Text)
                If ndtrung.Length > 0 Then
                    hople = False
                    chuoibaoloi += "Mã nhân viên vừa nhập đã tồn tại "
                Else
                    nguoidung.Item("nd_manhanvien") = txb_manhanvien.Text
                End If
            End If

            nguoidung.Item("nd_hoten") = txb_tennhanvien.Text
            nguoidung.Item("nd_dienthoai") = txb_dienthoai.Text
            nguoidung.Item("nd_email") = txb_email.Text
            If nguoidung.Item("nd_madonvi") <> cmb_thuocdonvi.SelectedValue Or nguoidung.Item("nd_maloainguoidung") <> cmb_loainguoidung.SelectedValue Then
                canpheduyet = True
            End If
            nguoidung.Item("nd_madonvi") = cmb_thuocdonvi.SelectedValue
            nguoidung.Item("nd_maloainguoidung") = cmb_loainguoidung.SelectedValue
            nguoidung.Item("nd_thoidiemcapnhat") = DateTime.Now
            If canpheduyet Then
                nguoidung.Item("nd_dakichhoat") = 0
            End If
            If hople Then
                xl_dulieu.GhiDuLieu("NguoiDung", dsnguoidung)
                Me.Close()
            Else
                MessageBox.Show(chuoibaoloi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub

    Private Sub Frm_NguoiDung_Action_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosed = False Then
            Dim dialogResult As DialogResult
            dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình? Dữ liệu chưa lưu trữ sẽ bị mất khi đóng màn hình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                isClosed = True
                e.Cancel = True
            End If
        End If
    End Sub
    Sub TaiDuLieuCmbDonVi()
        Dim cautruyvandonvi As String = "select dv_ma, dv_ten from DonVi where dv_daxoa =0"
        dsdonvi = xl_dulieu.DocDuLieu(cautruyvandonvi)
        cmb_thuocdonvi.DataSource = dsdonvi
        cmb_thuocdonvi.DisplayMember = "dv_ten"
        cmb_thuocdonvi.ValueMember = "dv_ma"
    End Sub
    Sub TaiDuLieuCmbLoaiNguoiDung()
        Dim cautruyvanloainguoidung As String = "select lnd_ma, lnd_ten from LoaiNguoiDung where lnd_daxoa =0"
        dsloainguoidung = xl_dulieu.DocDuLieu(cautruyvanloainguoidung)
        cmb_loainguoidung.DataSource = dsloainguoidung
        cmb_loainguoidung.DisplayMember = "lnd_ten"
        cmb_loainguoidung.ValueMember = "lnd_ma"
    End Sub
    Sub TaiDuLieuNguoiDung()
        Dim cautruyvan As String = "select * from NguoiDung where nd_daxoa =0"
        dsnguoidung = xl_dulieu.DocDuLieu(cautruyvan)
    End Sub
End Class