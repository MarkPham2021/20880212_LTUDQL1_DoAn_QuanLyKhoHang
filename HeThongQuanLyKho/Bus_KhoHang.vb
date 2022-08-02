Public Class Bus_KhoHang
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu
    Public Function TinhCongSuatKhoiLuongDaSuDungTrongNgay(ByVal makhohang As Integer, ByVal ngaytinhtoan As String) As Integer
        Dim kq As Integer = 0
        Dim cautruyvanchitietnhaphang As String = String.Format("select pnh_makhohang, ctnh_mamathang, mh_ten,mh_khoiluong, Sum(ctnh_soluong) as Soluongnhap
                                        from CTNhapHang join PhieuNhapHang on ctnh_maphieunhaphang=pnh_ma
                                        join MatHang on ctnh_mamathang= mh_ma
                                        where pnh_makhohang = {0} and pnh_ngaynhaphang = '{1}' and ctnh_daxoa =0
                                        group by pnh_makhohang, ctnh_mamathang,mh_ten,mh_khoiluong",
                                        makhohang.ToString, ngaytinhtoan)
        Dim cautruyvanchitietxuathang As String = String.Format("select pxh_makhohang, ctxh_mamathang, mh_ten,mh_khoiluong, Sum(ctxh_soluong) as Soluongxuat
                                                    from CTXuatHang join PhieuXuatHang on ctxh_maphieuxuathang=pxh_ma
                                                    join MatHang on ctxh_mamathang= mh_ma
                                                    where pxh_makhohang = {0} and pxh_ngayxuathang = '{1}' and ctxh_daxoa = 0
                                                    group by pxh_makhohang, ctxh_mamathang,mh_ten,mh_khoiluong",
                                                    makhohang.ToString, ngaytinhtoan)
        Dim bangnhap = xl_dulieu.DocDuLieu(cautruyvanchitietnhaphang)
        Dim bangxuat = xl_dulieu.DocDuLieu(cautruyvanchitietxuathang)
        For Each ctn In bangnhap.Rows
            kq += ctn.item("Soluongnhap") * ctn.item("mh_khoiluong")
        Next
        For Each ctx In bangxuat.Rows
            kq -= ctx.item("Soluongxuat") * ctx.item("mh_khoiluong")
        Next
        Return kq
    End Function
    Public Function TinhCongSuatTheTichDaSuDungTrongNgay(ByVal makhohang As Integer, ByVal ngaytinhtoan As String) As Integer
        Dim kq As Integer = 0
        Dim cautruyvanchitietnhaphang As String = $"select pnh_makhohang, ctnh_mamathang, mh_ten,mh_thetich, Sum(ctnh_soluong) as Soluongnhap
                                        from CTNhapHang join PhieuNhapHang on ctnh_maphieunhaphang=pnh_ma
                                        join MatHang on ctnh_mamathang= mh_ma
                                        where pnh_makhohang = {makhohang.ToString} and pnh_ngaynhaphang = '{ngaytinhtoan}' and ctnh_daxoa =0
                                        group by pnh_makhohang, ctnh_mamathang,mh_ten,mh_thetich"
        Dim cautruyvanchitietxuathang As String = $"select pxh_makhohang, ctxh_mamathang, mh_ten,mh_thetich, Sum(ctxh_soluong) as Soluongxuat
                                                    from CTXuatHang join PhieuXuatHang on ctxh_maphieuxuathang=pxh_ma
                                                    join MatHang on ctxh_mamathang= mh_ma
                                                    where pxh_makhohang = {makhohang.ToString} and pxh_ngayxuathang = '{ngaytinhtoan}' and ctxh_daxoa = 0
                                                    group by pxh_makhohang, ctxh_mamathang,mh_ten,mh_thetich"
        Dim bangnhap = xl_dulieu.DocDuLieu(cautruyvanchitietnhaphang)
        Dim bangxuat = xl_dulieu.DocDuLieu(cautruyvanchitietxuathang)
        For Each ctn In bangnhap.Rows
            kq += ctn.item("Soluongnhap") * ctn.item("mh_thetich")
        Next
        For Each ctx In bangxuat.Rows
            kq -= ctx.item("Soluongxuat") * ctx.item("mh_thetich")
        Next
        Return kq
    End Function
    Public Function TinhCongSuatKhoiLuongDaSuDungDenDauNgay(ByVal makhohang As Integer, ByVal ngaytinhtoan As String) As Integer
        Dim kq As Integer = 0
        Dim cautruyvanchitietnhaphang As String = $"select pnh_makhohang, ctnh_mamathang, mh_ten,mh_khoiluong, Sum(ctnh_soluong) as Soluongnhap
                                        from CTNhapHang join PhieuNhapHang on ctnh_maphieunhaphang=pnh_ma
                                        join MatHang on ctnh_mamathang= mh_ma
                                        where pnh_makhohang = {makhohang.ToString} and pnh_ngaynhaphang < '{ngaytinhtoan}' and ctnh_daxoa =0
                                        group by pnh_makhohang, ctnh_mamathang,mh_ten,mh_khoiluong"
        Dim cautruyvanchitietxuathang As String = $"select pxh_makhohang, ctxh_mamathang, mh_ten,mh_khoiluong, Sum(ctxh_soluong) as Soluongxuat
                                                    from CTXuatHang join PhieuXuatHang on ctxh_maphieuxuathang=pxh_ma
                                                    join MatHang on ctxh_mamathang= mh_ma
                                                    where pxh_makhohang = {makhohang.ToString} and pxh_ngayxuathang < '{ngaytinhtoan}' and ctxh_daxoa = 0
                                                    group by pxh_makhohang, ctxh_mamathang,mh_ten,mh_khoiluong"
        Dim bangnhap = xl_dulieu.DocDuLieu(cautruyvanchitietnhaphang)
        Dim bangxuat = xl_dulieu.DocDuLieu(cautruyvanchitietxuathang)
        For Each ctn In bangnhap.Rows
            kq += ctn.item("Soluongnhap") * ctn.item("mh_khoiluong")
        Next
        For Each ctx In bangxuat.Rows
            kq -= ctx.item("Soluongxuat") * ctx.item("mh_khoiluong")
        Next
        Return kq
    End Function
    Public Function TinhCongSuatTheTichDaSuDungDenDauNgay(ByVal makhohang As Integer, ByVal ngaytinhtoan As String) As Integer
        Dim kq As Integer = 0
        Dim cautruyvanchitietnhaphang As String = $"select pnh_makhohang, ctnh_mamathang, mh_ten,mh_thetich, Sum(ctnh_soluong) as Soluongnhap
                                        from CTNhapHang join PhieuNhapHang on ctnh_maphieunhaphang=pnh_ma
                                        join MatHang on ctnh_mamathang= mh_ma
                                        where pnh_makhohang = {makhohang.ToString} and pnh_ngaynhaphang < '{ngaytinhtoan}' and ctnh_daxoa =0
                                        group by pnh_makhohang, ctnh_mamathang,mh_ten,mh_thetich"
        Dim cautruyvanchitietxuathang As String = $"select pxh_makhohang, ctxh_mamathang, mh_ten,mh_thetich, Sum(ctxh_soluong) as Soluongxuat
                                                    from CTXuatHang join PhieuXuatHang on ctxh_maphieuxuathang=pxh_ma
                                                    join MatHang on ctxh_mamathang= mh_ma
                                                    where pxh_makhohang = {makhohang.ToString} and pxh_ngayxuathang < '{ngaytinhtoan}' and ctxh_daxoa = 0
                                                    group by pxh_makhohang, ctxh_mamathang,mh_ten,mh_thetich"
        Dim bangnhap = xl_dulieu.DocDuLieu(cautruyvanchitietnhaphang)
        Dim bangxuat = xl_dulieu.DocDuLieu(cautruyvanchitietxuathang)
        For Each ctn In bangnhap.Rows
            kq += ctn.item("Soluongnhap") * ctn.item("mh_thetich")
        Next
        For Each ctx In bangxuat.Rows
            kq -= ctx.item("Soluongxuat") * ctx.item("mh_thetich")
        Next
        Return kq
    End Function
    Public Function TinhSoLuongTonKhocuaMatHangTrongHopDong(ByVal makhohang, ByVal mahopdong, ByVal mamathang) As Integer
        Dim kq As Integer = 0
        Dim cautruyvannhaphang As String = $"select isnull(sum(ctnh_soluong),0) as soluongnhap
	                                            from PhieuNhapHang join CTNhapHang on pnh_ma = ctnh_maphieunhaphang
	                                            where ctnh_daxoa=0 and ctnh_mamathang={mamathang} and pnh_makhohang={makhohang} and pnh_mahopdong={mahopdong}"
        Dim cautruyvanxuathang As String = $"select isnull(sum(ctxh_soluong),0) as soluongxuat
	                                            from PhieuXuatHang join CTXuatHang on pxh_ma = ctxh_maphieuxuathang
	                                            where ctxh_daxoa=0 and ctxh_mamathang={mamathang} and pxh_makhohang={makhohang} and pxh_mahopdong={mahopdong}"
        Dim bangnhaphang = xl_dulieu.DocDuLieu(cautruyvannhaphang)
        Dim bangxuathang = xl_dulieu.DocDuLieu(cautruyvanxuathang)
        kq = bangnhaphang.Rows(0).Item(0) - bangxuathang.Rows(0).Item(0)
        Return kq
    End Function
    Public Function TinhSoLuongNhapTheoNgaycuaMatHangTrongHopDong(ByVal mahopdong As Integer, ByVal mamathang As Integer, ByVal ngay As String) As Integer
        Dim kq As Integer = 0
        Dim cautruyvan As String = $"select isnull(sum(ctnh_soluong),0) as soluongnhap
                                    from PhieuNhapHang join CTNhapHang on pnh_ma = ctnh_maphieunhaphang
                                    where ctnh_daxoa =0 and ctnh_mamathang ={mamathang} and pnh_mahopdong = {mahopdong} and pnh_ngaynhaphang='{ngay}'"
        Dim dtnhaphang = xl_dulieu.DocDuLieu(cautruyvan)
        kq = dtnhaphang.Rows(0).Item(0)
        Return kq
    End Function
    Public Function TinhSoLuongXuatTheoNgaycuaMatHangTrongHopDong(ByVal mahopdong As Integer, ByVal mamathang As Integer, ByVal ngay As String) As Integer
        Dim kq As Integer = 0
        Dim cautruyvan As String = $"select isnull(sum(ctxh_soluong),0) as soluongxuat
                                    from PhieuXuatHang join CTXuatHang on pxh_ma = ctxh_maphieuxuathang
                                    where ctxh_daxoa =0 and ctxh_mamathang ={mamathang} and pxh_mahopdong = {mahopdong} and pxh_ngayxuathang='{ngay}'"
        Dim dtxuathang = xl_dulieu.DocDuLieu(cautruyvan)
        kq = dtxuathang.Rows(0).Item(0)
        Return kq
    End Function
    Public Function TinhSoLuongNhapTrongKhoangThoiGiancuaMatHangTrongHopDong(ByVal mahopdong As Integer, ByVal mamathang As Integer, ByVal tungay As String, ByVal denngay As String) As Integer
        Dim kq As Integer = 0
        Dim cautruyvan As String = $"select isnull(sum(ctnh_soluong),0) as soluongnhap
                                    from PhieuNhapHang join CTNhapHang on pnh_ma = ctnh_maphieunhaphang
                                    where ctnh_daxoa =0 and ctnh_mamathang ={mamathang} and pnh_mahopdong = {mahopdong} and pnh_ngaynhaphang between '{tungay}' and '{denngay}'"
        Dim dtnhaphang = xl_dulieu.DocDuLieu(cautruyvan)
        kq = dtnhaphang.Rows(0).Item(0)
        Return kq
    End Function
    Public Function TinhSoLuongXuatTrongKhoangThoiGiancuaMatHangTrongHopDong(ByVal mahopdong As Integer, ByVal mamathang As Integer, ByVal tungay As String, ByVal denngay As String) As Integer
        Dim kq As Integer = 0
        Dim cautruyvan As String = $"select isnull(sum(ctxh_soluong),0) as soluongxuat
                                    from PhieuXuatHang join CTXuatHang on pxh_ma = ctxh_maphieuxuathang
                                    where ctxh_daxoa =0 and ctxh_mamathang ={mamathang} and pxh_mahopdong = {mahopdong} and pxh_ngayxuathang between '{tungay}' and '{denngay}'"
        Dim dtxuathang = xl_dulieu.DocDuLieu(cautruyvan)
        kq = dtxuathang.Rows(0).Item(0)
        Return kq
    End Function
End Class
