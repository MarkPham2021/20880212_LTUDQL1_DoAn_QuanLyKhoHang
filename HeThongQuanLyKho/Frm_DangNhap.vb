Public Class Frm_DangNhap
    Dim dsnguoidung As DataTable = New DataTable
    Dim dsphanquyen As DataTable = New DataTable
    Dim dschucnangnguoidung As DataTable = New DataTable
    Dim nguoidung As DataRow
    Dim solandangnhap As Integer
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu
    Private Sub Frm_DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDsNguoiDung()
        TaiDsPhanQuyen()
        solandangnhap = 0
    End Sub
    Private Sub btn_dongy_Click(sender As Object, e As EventArgs) Handles btn_dongy.Click
        If txb_tendangnhap.Text <> "" Then
            Dim tendangnhap As String = txb_tendangnhap.Text
            Dim matkhau As String = Util.MaHoa(txb_matkhau.Text)
            If XacThucNguoiDung(tendangnhap, matkhau) Then
                Me.DialogResult = DialogResult.Yes
            Else
                solandangnhap += 1
                If solandangnhap < 3 Then
                    MessageBox.Show($"Tên đăng nhập và/hoặc mật khẩu chưa đúng, xin mời đăng nhập lại, số lần thử {solandangnhap}/3", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Me.DialogResult = DialogResult.Cancel
                End If
            End If
        Else
            MessageBox.Show("Xin mời nhập Tên đăng nhập và mật khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btn_huy_Click(sender As Object, e As EventArgs) Handles btn_huy.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Sub TaiDsNguoiDung()
        Dim cautruyvan As String = "select nd_ma, nd_tendangnhap, nd_matkhau, nd_maloainguoidung, nd_manhanvien, nd_hoten, nd_madonvi, dv_ten, lnd_ten, nd_dienthoai, nd_email
                                    from DonVi join  NguoiDung on dv_ma = nd_madonvi  
                                    join LoaiNguoiDung on lnd_ma = nd_maloainguoidung
                                    where nd_daxoa =0 and nd_dakichhoat =1"
        dsnguoidung = xl_dulieu.DocDuLieu(cautruyvan)
    End Sub
    Sub TaiDsPhanQuyen()
        Dim cautruyvandsphanquyen As String = "select pq_ma, pq_maloainguoidung, pq_machucnang, cn_tag from PhanQuyen join ChucNang on cn_ma = pq_machucnang where pq_daxoa =0"
        dsphanquyen = xl_dulieu.DocDuLieu(cautruyvandsphanquyen)
    End Sub
    Function XacThucNguoiDung(ByVal tendangnhap As String, ByVal matkhau As String) As Boolean
        Dim kq As Boolean
        Dim pkclms(1) As DataColumn
        pkclms(0) = dsnguoidung.Columns(1)
        dsnguoidung.PrimaryKey = pkclms
        Dim dskq = dsnguoidung.Rows.Find(tendangnhap)
        If IsNothing(dskq) Then
            kq = False
        Else
            If dskq.Item("nd_matkhau").ToString = matkhau Then
                My.MyApplication.NguoiDung = dskq
                My.MyApplication.DSChucNangNguoiDung = dsphanquyen.Select("pq_maloainguoidung = " + dskq.Item("nd_maloainguoidung").ToString).CopyToDataTable
                kq = True
            Else
                kq = False
            End If
        End If
        Return kq
    End Function

    Private Sub btn_dangky_Click(sender As Object, e As EventArgs) Handles btn_dangky.Click
        Dim mh As Frm_NguoiDung_Action = New Frm_NguoiDung_Action
        mh.LoaiHanhDong = 1
        mh.ShowDialog(Frm_MH_Chinh)
    End Sub
End Class