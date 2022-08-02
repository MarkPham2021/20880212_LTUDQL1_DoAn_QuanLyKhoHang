Public Class Bus_TinhTien
    Public Ma As Integer
    Public MaHopDong As Integer
    Public MaMatHang As Integer
    Public MH_Ten As String
    Public MH_KhoiLuong As Double
    Public MH_TheTich As Double
    Public PTTT_Ma As Integer
    Public PTTT_Ten As String
    Public DonGia As Double
    Public TonKhoBinhQuan As Double
    Public SoNgay As Integer
    Public ThanhTien As Double
    Dim bus_khohang As Bus_KhoHang = New Bus_KhoHang
    Public Sub TinhTienMatHangChiTiet(ByVal tungay As Date, ByVal denngay As Date, ByVal TonKhoDauKy As Integer)

        Dim kq As Double = 0
        Dim tongsoluongtonkhocuoingay As Integer = 0
        SoNgay = DateAndTime.DateDiff(DateInterval.Day, tungay, denngay)
        Dim bangnhapxuatton As List(Of Bus_ThongKeNhapXuatTonMatHang) = New List(Of Bus_ThongKeNhapXuatTonMatHang)
        For dem As Integer = 0 To SoNgay
            Dim dong As Bus_ThongKeNhapXuatTonMatHang = New Bus_ThongKeNhapXuatTonMatHang
            dong.Ngay = DateAdd(DateInterval.Day, dem, tungay)
            Dim chuoingay As String = Format(dong.Ngay, "yyyy-MM-dd")
            If dem > 0 Then
                Dim dongtruoc = bangnhapxuatton(dem - 1)
                dong.TonKhoDauNgay = dongtruoc.TonKhoCuoiNgay
            Else
                dong.TonKhoDauNgay = TonKhoDauKy
            End If
            dong.SoLuongNhap = bus_khohang.TinhSoLuongNhapTheoNgaycuaMatHangTrongHopDong(MaHopDong, MaMatHang, chuoingay)
            dong.SoLuongXuat = bus_khohang.TinhSoLuongXuatTheoNgaycuaMatHangTrongHopDong(MaHopDong, MaMatHang, chuoingay)
            dong.TonKhoCuoiNgay = dong.TonKhoDauNgay + dong.SoLuongNhap - dong.SoLuongXuat
            tongsoluongtonkhocuoingay += dong.TonKhoCuoiNgay
            bangnhapxuatton.Add(dong)
        Next
        SoNgay = SoNgay + 1
        TonKhoBinhQuan = tongsoluongtonkhocuoingay / SoNgay
        If PTTT_Ma = 1 Then
            kq = TonKhoBinhQuan * MH_KhoiLuong * SoNgay * DonGia / 1000
        ElseIf PTTT_Ma = 2 Then
            kq = TonKhoBinhQuan * MH_TheTich * SoNgay * DonGia / 1000
        End If
        ThanhTien = kq
    End Sub
End Class
