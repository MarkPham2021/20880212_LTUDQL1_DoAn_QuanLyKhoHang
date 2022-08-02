Public Class Frm_PhieuTinhTien_BangTinhChiTiet
    Public MaHopDong As Integer = 1
    Public MaPhieuTinhTien As Integer
    Public TenKhachHang As String
    Public TuNgay As Date
    Public DenNgay As Date
    Public TongThanhTien As String
    Public danhsachmathangtinhtien As List(Of Bus_TinhTien) = New List(Of Bus_TinhTien)
    Dim HopDong As DataRow
    Dim DsHopDong As DataTable = New DataTable
    Dim DsCTHopDong As DataTable = New DataTable
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu
    Dim bus_khohang As Bus_KhoHang = New Bus_KhoHang
    Dim TongSoLuongTonKho As Integer
    Dim SoLuongTonKhhoBinhQuan As Double
    Dim SoNgay As Integer = 0
    Private Sub Frm_PhieuTinhTien_BangTinhChiTiet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuHopDong(MaHopDong)
        dgvDsCTTinhTien.Rows.Clear()
        txb_ma.Text = MaPhieuTinhTien
        txb_mahopdong.Text = MaHopDong
        txb_tenkhachhang.Text = TenKhachHang
        txb_tungay.Text = TuNgay
        txb_denngay.Text = DenNgay
        txb_tongthanhtien.Text = TongThanhTien
        dgvDsCTTinhTien.Rows.Clear()
        If danhsachmathangtinhtien.Count > 0 Then
            For Each cttt As Bus_TinhTien In danhsachmathangtinhtien
                ThemDongdgvDsCTTinhTien(cttt)
            Next
        End If
    End Sub
    Sub TaiDuLieuHopDong(ByVal mahopdong As Integer)
        Dim cautruyvan As String = $"select hd_ma, kh_ten, hd_ngaybatdau, hd_ngayhethan
                                    from HopDong
                                        join KhachHang on hd_makhachhang = kh_ma
                                    where hd_ma ={mahopdong}"
        DsHopDong = xl_dulieu.DocDuLieu(cautruyvan)
        HopDong = DsHopDong.Rows(0)
    End Sub
    Sub TinhTienChiTietMatHang(ByVal mamathang)
        dgvBangTinhChiTiet.Rows.Clear()
        dgvBangTinhChiTiet.Columns.Clear()
        Dim tonkhodauky As Integer = 0
        If TuNgay > HopDong.Item("hd_ngaybatdau") Then
            Dim chuoingaybatdauhd As String = Format(HopDong.Item("hd_ngaybatdau"), "yyyy-MM-dd")
            Dim chuoingaytruoc As String = Format(DateAdd(DateInterval.Day, -1, TuNgay), "yyyy-MM-dd")
            tonkhodauky = bus_khohang.TinhSoLuongNhapTrongKhoangThoiGiancuaMatHangTrongHopDong(MaHopDong, mamathang, chuoingaybatdauhd, chuoingaytruoc) -
                            bus_khohang.TinhSoLuongXuatTrongKhoangThoiGiancuaMatHangTrongHopDong(MaHopDong, mamathang, chuoingaybatdauhd, chuoingaytruoc)
        End If
        Dim tongsoluongtonkhocuoingay As Integer = 0
        Dim cl0 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Dim cl1 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Dim cl2 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Dim cl3 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        Dim cl4 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        dgvBangTinhChiTiet.Columns.AddRange({cl0, cl1, cl2, cl3, cl4})
        dgvBangTinhChiTiet.Columns(0).Name = "ngay"
        dgvBangTinhChiTiet.Columns(0).HeaderText = "Ngày"
        dgvBangTinhChiTiet.Columns(0).Width = 160
        dgvBangTinhChiTiet.Columns(1).Name = "tonkhodaungay"
        dgvBangTinhChiTiet.Columns(1).HeaderText = "Tồn kho đầu ngày"
        dgvBangTinhChiTiet.Columns(1).Width = 90
        dgvBangTinhChiTiet.Columns(2).Name = "soluongnhap"
        dgvBangTinhChiTiet.Columns(2).HeaderText = "Số lượng nhập"
        dgvBangTinhChiTiet.Columns(2).Width = 90
        dgvBangTinhChiTiet.Columns(3).Name = "soluongxuat"
        dgvBangTinhChiTiet.Columns(3).HeaderText = "Số lượng xuất"
        dgvBangTinhChiTiet.Columns(3).Width = 90
        dgvBangTinhChiTiet.Columns(4).Name = "tonkhocuoingay"
        dgvBangTinhChiTiet.Columns(4).HeaderText = "Tồn kho cuối ngày"
        dgvBangTinhChiTiet.Columns(4).Width = 90
        SoNgay = DateAndTime.DateDiff(DateInterval.Day, TuNgay, DenNgay)
        For dem As Integer = 0 To SoNgay
            dgvBangTinhChiTiet.Rows.Add(1)
            Dim dong As DataGridViewRow = dgvBangTinhChiTiet.Rows(dem)
            Dim ngay = DateAdd(DateInterval.Day, dem, TuNgay)
            Dim chuoingay As String = Format(ngay, "yyyy-MM-dd")
            dong.Cells("ngay").Value = ngay.ToShortDateString()
            If dem > 0 Then
                Dim dongtruoc = dgvBangTinhChiTiet.Rows(dem - 1)
                dong.Cells("tonkhodaungay").Value = dongtruoc.Cells("tonkhocuoingay").Value
            Else
                dong.Cells("tonkhodaungay").Value = tonkhodauky
            End If
            dong.Cells("soluongnhap").Value = bus_khohang.TinhSoLuongNhapTheoNgaycuaMatHangTrongHopDong(MaHopDong, mamathang, chuoingay)
            dong.Cells("soluongxuat").Value = bus_khohang.TinhSoLuongXuatTheoNgaycuaMatHangTrongHopDong(MaHopDong, mamathang, chuoingay)
            dong.Cells("tonkhocuoingay").Value = dong.Cells("tonkhodaungay").Value + dong.Cells("soluongnhap").Value - dong.Cells("soluongxuat").Value
            tongsoluongtonkhocuoingay += dong.Cells("tonkhocuoingay").Value

        Next
        SoNgay = SoNgay + 1
        TongSoLuongTonKho = tongsoluongtonkhocuoingay
        SoLuongTonKhhoBinhQuan = TongSoLuongTonKho / SoNgay
        dgvBangTinhChiTiet.Rows.Add()
        dgvBangTinhChiTiet.Rows(SoNgay).Cells(0).Value = "Tổng cộng"
        dgvBangTinhChiTiet.Rows(SoNgay).Cells("tonkhocuoingay").Value = Format(TongSoLuongTonKho, "#,###.##")
        dgvBangTinhChiTiet.Rows.Add(1)
        dgvBangTinhChiTiet.Rows(SoNgay + 1).Cells(0).Value = "Tổng số ngày"
        dgvBangTinhChiTiet.Rows(SoNgay + 1).Cells("tonkhocuoingay").Value = SoNgay
        dgvBangTinhChiTiet.Rows.Add(1)
        dgvBangTinhChiTiet.Rows(SoNgay + 2).Cells(0).Value = "Số lượng tồn kho bình quân"
        dgvBangTinhChiTiet.Rows(SoNgay + 2).Cells("tonkhocuoingay").Value = Format(SoLuongTonKhhoBinhQuan, "#,###.##")
    End Sub
    Private Sub dgvCTTinhTien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsCTTinhTien.CellClick
        dgvBangTinhChiTiet.Rows.Clear()
        Dim cttt = dgvDsCTTinhTien.CurrentRow
        If Not cttt.IsNewRow Then
            TinhTienChiTietMatHang(cttt.Cells("cttt_mamathang").Value)
        End If
    End Sub
    Sub ThemDongdgvDsCTTinhTien(ByVal cttinhtien As Bus_TinhTien)
        If dgvDsCTTinhTien.Columns.Count < 9 Then
            dgvDsCTTinhTien.RowHeadersVisible = False
            Dim cot0 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot1 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot2 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot3 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot4 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot5 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot6 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot7 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot8 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            dgvDsCTTinhTien.Columns.Insert(0, cot0)
            dgvDsCTTinhTien.Columns(0).Name = "stt"
            dgvDsCTTinhTien.Columns(0).HeaderText = "STT"
            dgvDsCTTinhTien.Columns(0).Width = 60

            dgvDsCTTinhTien.Columns.Insert(1, cot1)
            dgvDsCTTinhTien.Columns(1).Name = "MH_Ten"
            dgvDsCTTinhTien.Columns(1).HeaderText = "Tên mặt hàng"
            dgvDsCTTinhTien.Columns(1).Width = 180

            dgvDsCTTinhTien.Columns.Insert(2, cot2)
            dgvDsCTTinhTien.Columns(2).Name = "MH_KhoiLuong"
            dgvDsCTTinhTien.Columns(2).HeaderText = "Khối lượng"
            dgvDsCTTinhTien.Columns(2).Width = 70

            dgvDsCTTinhTien.Columns.Insert(3, cot3)
            dgvDsCTTinhTien.Columns(3).Name = "MH_TheTich"
            dgvDsCTTinhTien.Columns(3).HeaderText = "Thể tích"
            dgvDsCTTinhTien.Columns(3).Width = 70

            dgvDsCTTinhTien.Columns.Insert(4, cot4)
            dgvDsCTTinhTien.Columns(4).Name = "PTTT_Ten"
            dgvDsCTTinhTien.Columns(4).HeaderText = "Phương thức tính tiền"
            dgvDsCTTinhTien.Columns(4).Width = 170

            dgvDsCTTinhTien.Columns.Insert(5, cot5)
            dgvDsCTTinhTien.Columns(5).Name = "DonGia"
            dgvDsCTTinhTien.Columns(5).HeaderText = "Đơn giá"
            dgvDsCTTinhTien.Columns(5).Width = 70

            dgvDsCTTinhTien.Columns.Insert(6, cot6)
            dgvDsCTTinhTien.Columns(6).Name = "SoLuongTonKhoBinhQuan"
            dgvDsCTTinhTien.Columns(6).HeaderText = "Số lượng tồn kho bình quân"
            dgvDsCTTinhTien.Columns(6).Width = 90

            dgvDsCTTinhTien.Columns.Insert(7, cot7)
            dgvDsCTTinhTien.Columns(7).Name = "ThanhTien"
            dgvDsCTTinhTien.Columns(7).HeaderText = "Thành tiền"
            dgvDsCTTinhTien.Columns(7).Width = 120

            dgvDsCTTinhTien.Columns.Insert(8, cot8)
            dgvDsCTTinhTien.Columns(8).Name = "cttt_mamathang"
            dgvDsCTTinhTien.Columns("cttt_mamathang").Visible = False
        End If
        dgvDsCTTinhTien.Rows.Add()
        Dim chiso As Integer = dgvDsCTTinhTien.Rows.Count - 1
        dgvDsCTTinhTien.Rows(chiso).Cells("stt").Value = chiso + 1
        dgvDsCTTinhTien.Rows(chiso).Cells("MH_Ten").Value = cttinhtien.MH_Ten
        dgvDsCTTinhTien.Rows(chiso).Cells("MH_KhoiLuong").Value = cttinhtien.MH_KhoiLuong
        dgvDsCTTinhTien.Rows(chiso).Cells("MH_TheTich").Value = cttinhtien.MH_TheTich
        dgvDsCTTinhTien.Rows(chiso).Cells("PTTT_Ten").Value = cttinhtien.PTTT_Ten
        dgvDsCTTinhTien.Rows(chiso).Cells("DonGia").Value = Format(cttinhtien.DonGia, "#,###.##")
        dgvDsCTTinhTien.Rows(chiso).Cells("SoLuongTonKhoBinhQuan").Value = Format(cttinhtien.TonKhoBinhQuan, "#,###.##")
        dgvDsCTTinhTien.Rows(chiso).Cells("ThanhTien").Value = Format(cttinhtien.ThanhTien, "#,###.##")
        dgvDsCTTinhTien.Rows(chiso).Cells("cttt_mamathang").Value = cttinhtien.MaMatHang
    End Sub

    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        Me.Close()

    End Sub
End Class