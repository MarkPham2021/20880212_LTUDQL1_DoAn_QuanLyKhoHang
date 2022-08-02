Public Class Frm_MH_Chinh
    Dim isClosed As Boolean = False
    Dim kqdangnhap As DialogResult
    Private Sub Frm_MH_Chinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Enabled = False
        Dim mh = New Frm_DangNhap()
        kqdangnhap = mh.ShowDialog()
        If kqdangnhap = DialogResult.Cancel Then
            isClosed = True
            Me.Close()
        ElseIf kqdangnhap = DialogResult.Yes Then
            Me.Enabled = True
            HienThiMeNuChucnang()
            HienThiNguoiDung()
        End If
    End Sub
    Private Sub Frm_MH_Chinh_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosed = False Then
            Dim dialogResult As DialogResult
            dialogResult = MessageBox.Show("Bạn thực sự muốn thoát chương trình? Dữ liệu đang nhập chưa lưu trữ sẽ bị mất khi thoát khỏi chương trình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub QuảnLýTàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim mh As Frm_NguoiDung_Index = New Frm_NguoiDung_Index()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub

    Private Sub HệThốngKhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HệThốngKhoToolStripMenuItem.Click
        Dim mh As Frm_KhoHang = New Frm_KhoHang()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub

    Private Sub DanhMụcLoạiHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhMụcLoạiHàngToolStripMenuItem.Click
        Dim mh As Frm_LoaiHang = New Frm_LoaiHang()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub

    Private Sub DanhMụcHàngHóaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhMụcHàngHóaToolStripMenuItem.Click
        Dim mh As Frm_MatHang = New Frm_MatHang()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub
    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Enabled = False
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        Dim mh = New Frm_DangNhap()
        kqdangnhap = mh.ShowDialog()
        If kqdangnhap = DialogResult.Cancel Then
            isClosed = True
            Me.Close()
        ElseIf kqdangnhap = DialogResult.Yes Then
            Me.Enabled = True
            HienThiMeNuChucnang()
            HienThiNguoiDung()
        End If
    End Sub
    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        isClosed = False
        Me.Close()

    End Sub

    Private Sub QuảnLýKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim mh As Frm_KhachHang = New Frm_KhachHang()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub

    Private Sub QuảnLýHợpĐồngToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim mh As Frm_HopDong = New Frm_HopDong()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub

    Private Sub HợpĐồngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HợpĐồngToolStripMenuItem.Click
        Dim mh As Frm_HopDong_Index = New Frm_HopDong_Index()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub

    Private Sub KháchHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem1.Click
        Dim mh As Frm_KhachHang = New Frm_KhachHang()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub

    Private Sub NhậpHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậpHàngToolStripMenuItem.Click
        Dim mh As Frm_PhieuNhapHang_Index = New Frm_PhieuNhapHang_Index
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub
    Private Sub XuấtHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtHàngToolStripMenuItem.Click
        Dim mh As Frm_PhieuXuatHang_Index = New Frm_PhieuXuatHang_Index
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub
    Private Sub PhiếuTínhTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuTínhTiềnToolStripMenuItem.Click
        Dim mh As Frm_PhieuTinhTien_Index = New Frm_PhieuTinhTien_Index
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub
    Private Sub TinhtoanvaCapnhatDulieuDauNgayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TinhtoanvaCapnhatDulieuDauNgayToolStripMenuItem.Click
        Dim xl_dulieu As XL_DuLieu = New XL_DuLieu
        'Tính toán và cập nhật công suất đã sử dụng của các kho hàng

        Dim bus_khohang As Bus_KhoHang = New Bus_KhoHang
        Dim ngay As String = Format(Date.Now, "yyyy-MM-dd")
        Dim cautruyvankhohang As String = "Select * from KhoHang where kho_daxoa =0"
        Dim dskhohang As DataTable = xl_dulieu.DocDuLieu(cautruyvankhohang)
        For Each khohang As DataRow In dskhohang.Rows
            Dim congsuatkhoiluongdasudung As Double = bus_khohang.TinhCongSuatKhoiLuongDaSuDungDenDauNgay(khohang.Item("kho_ma"), ngay)
            Dim congsuatthetichdasudung As Double = bus_khohang.TinhCongSuatTheTichDaSuDungDenDauNgay(khohang.Item("kho_ma"), ngay)
            khohang.Item("kho_khoiluongdasudung") = congsuatkhoiluongdasudung
            khohang.Item("kho_thetichdasudung") = congsuatthetichdasudung
            khohang.Item("kho_thoidiemcapnhat") = DateTime.Now
        Next
        xl_dulieu.GhiDuLieu("KhoHang", dskhohang)

        'Tính toán và cập nhật tình trạng hiệu lực của các hợp đồng
        Dim cautruyvanhopdong As String = "Select * from HopDong where hd_daxoa =0"
        Dim dshopdong As DataTable = xl_dulieu.DocDuLieu(cautruyvanhopdong)
        For Each hopdong As DataRow In dshopdong.Rows
            Dim cohieuluc As Boolean = hopdong.Item("hd_ngayhethan") >= DateAndTime.Today And hopdong.Item("hd_ngaybatdau") <= DateAndTime.Today
            hopdong.Item("hd_cohieuluc") = cohieuluc
        Next
        xl_dulieu.GhiDuLieu("HopDong", dshopdong)

        MessageBox.Show($"Đã tính toán và cập nhật số liệu: {Chr(13)} Công suất sử dụng của các kho hàng và {Chr(13)} Tình trạng hiệu lực của các hợp đồng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub QuảnTrịTàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnTrịTàiKhoảnToolStripMenuItem.Click
        Dim mh As Frm_NguoiDung_Index = New Frm_NguoiDung_Index()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub

    Private Sub CậpNhậtThôngTinTàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtThôngTinTàiKhoảnToolStripMenuItem.Click
        Dim mh As Frm_NguoiDung_Action = New Frm_NguoiDung_Action
        mh.LoaiHanhDong = 2
        mh.Show(Me)
    End Sub

    Private Sub HợpĐồnggộpMànHìnhDànhChoMànHìnhCỡLớnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HợpĐồnggộpMànHìnhDànhChoMànHìnhCỡLớnToolStripMenuItem.Click
        Dim mh As Frm_HopDong = New Frm_HopDong()
        mh.MdiParent = Me
        mh.WindowState = FormWindowState.Maximized
        mh.Show()
    End Sub
    Sub HienThiMeNuChucnang()
        For Each menuitem As ToolStripMenuItem In MH_MainMenuStrip.Items
            For Each dropdownmenuitem As ToolStripMenuItem In menuitem.DropDownItems
                If dropdownmenuitem.Tag = 0 Then
                    Continue For
                End If
                Dim tagchucnang = dropdownmenuitem.Tag
                Dim dongchucnang = My.MyApplication.DSChucNangNguoiDung.Select("cn_tag = " + tagchucnang.ToString)
                If dongchucnang.Length > 0 Then
                    dropdownmenuitem.Enabled = True
                Else
                    dropdownmenuitem.Enabled = False
                End If
            Next
        Next
    End Sub
    Sub HienThiNguoiDung()
        Dim nguoidung = My.MyApplication.NguoiDung
        If Not IsNothing(nguoidung) Then
            Dim noidung = nguoidung.Item("nd_manhanvien").ToString + "_" + nguoidung.Item("nd_hoten")
            Dim tendonvi = nguoidung.Item("dv_ten")
            ToolStripStatusLabel_Loichao.Text = "Người dùng: "
            ToolStripStatusLabel_MaNhanVien_TenNhanVien.Text = noidung
            ToolStripStatusLabel_donvi.Text = "Đơn vị: "
            ToolStripStatusLabel_TenDonVi.Text = tendonvi
        End If

    End Sub

    Private Sub QuảnTrịLoạiNgườiDùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnTrịLoạiNgườiDùngToolStripMenuItem.Click
        Dim MH As New Frm_LoaiNguoiDung_Index
        MH.MdiParent = Me
        MH.WindowState = FormWindowState.Maximized
        MH.Show()

    End Sub

    Private Sub GiớiThiệuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GiớiThiệuToolStripMenuItem1.Click
        Dim MH As New GioiThieu
        MH.MdiParent = Me
        MH.WindowState = FormWindowState.Maximized
        MH.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        Dim MH As New Frm_HoaDon
        MH.MdiParent = Me
        MH.WindowState = FormWindowState.Maximized
        MH.Show()
    End Sub

    Private Sub PhiếuThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuThuToolStripMenuItem.Click
        Dim MH As New Frm_PhieuThu
        MH.MdiParent = Me
        MH.WindowState = FormWindowState.Maximized
        MH.Show()
    End Sub

    Private Sub ĐơnVịToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐơnVịToolStripMenuItem.Click
        Dim MH As New Frm_DonVi
        MH.MdiParent = Me
        MH.WindowState = FormWindowState.Maximized
        MH.Show()
    End Sub
End Class
