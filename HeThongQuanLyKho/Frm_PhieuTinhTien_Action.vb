Public Class Frm_PhieuTinhTien_Action
    Public LoaiHanhDong As Integer
    Public PhieuTinhTien As Bus_PhieuTinhTien
    Public MaPhieuTinhTien As Integer
    Dim isClosed As Boolean = True
    Dim DsPhieuTinhTien, DsCtTinhTien, DsCTHD, DsHopDong As DataTable
    Dim MaCTTinhTienTam As Integer = 0
    Dim TongThanhTien As Double
    Dim danhsachmathangtinhtien As List(Of Bus_TinhTien) = New List(Of Bus_TinhTien) 'khi bấm chọn tính tiền các dòng lưu tạm vào danh sách này, khi nào chọn lưu mới đưa vào datatable
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu
    Dim bus_khohang As Bus_KhoHang = New Bus_KhoHang
    Private Sub Frm_PhieuTinhTien_Action_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuDgvDsHopDong()
        DinhdangdgvDSHopDong()
        TaiDuLieuDsPhieuTinhTien()
        TaiDuLieuDsCTTinhTien()

        If LoaiHanhDong = 1 Then
            lbl_tieudeform.Text = "Tạo mới Phiếu Tính tiền"
            btn_luu.Text = "Lưu Dữ liệu"
            btn_luu.BackColor = Color.DarkGreen
            btn_luu.ForeColor = Color.FloralWhite
            dgvDsHopDong.Enabled = True
            dtp_tungay.Enabled = True
            dtp_denngay.Enabled = True
            btn_tinhtien.Enabled = True
        ElseIf LoaiHanhDong = 2 Then
            lbl_tieudeform.Text = "Thay đổi Nội dung Phiếu Tính tiền"
            btn_luu.Text = "Lưu Dữ liệu"
            btn_luu.BackColor = Color.DarkBlue
            btn_luu.ForeColor = Color.FloralWhite
            txb_ma.Text = PhieuTinhTien.Ma
            txb_mahopdong.Text = PhieuTinhTien.MaHopDong
            txb_tenkhachhang.Text = PhieuTinhTien.KH_Ten
            txb_loaigtpl.Text = PhieuTinhTien.KH_LoaiGTPL
            txb_gtplso.Text = PhieuTinhTien.KH_GTPLSo
            txb_diachi.Text = PhieuTinhTien.KH_DiaChi
            txb_dienthoai.Text = PhieuTinhTien.KH_DienThoai
            txb_email.Text = PhieuTinhTien.KH_Email
            dtp_ngaybatdau.Value = PhieuTinhTien.HD_NgayBatDau
            dtp_ngayhethan.Value = PhieuTinhTien.HD_NgayHetHan
            txb_ngaylapphieu.Text = PhieuTinhTien.PTT_NgayLap
            txb_tungay.Text = PhieuTinhTien.PTT_TuNgay
            txb_denngay.Text = PhieuTinhTien.PTT_DenNgay
            txb_tongthanhtien.Text = PhieuTinhTien.PTT_TongThanhTien
            If PhieuTinhTien.DsCTTinhTien.Count > 0 Then
                For Each _cttt As Bus_TinhTien In PhieuTinhTien.DsCTTinhTien
                    ThemDongdgvDsCTTinhTien(_cttt)
                Next
            End If
            dgvDsHopDong.Enabled = True
            dtp_tungay.Enabled = True
            dtp_denngay.Enabled = True
            btn_tinhtien.Enabled = True
        ElseIf LoaiHanhDong = 3 Then
            lbl_tieudeform.Text = "Xóa Phiếu Tính tiền"
            btn_luu.Text = "Xóa Phiếu Tính tiền"
            btn_luu.BackColor = Color.Red
            btn_luu.ForeColor = Color.Yellow
            txb_ma.Text = PhieuTinhTien.Ma
            txb_mahopdong.Text = PhieuTinhTien.MaHopDong
            txb_tenkhachhang.Text = PhieuTinhTien.KH_Ten
            txb_loaigtpl.Text = PhieuTinhTien.KH_LoaiGTPL
            txb_gtplso.Text = PhieuTinhTien.KH_GTPLSo
            txb_diachi.Text = PhieuTinhTien.KH_DiaChi
            txb_dienthoai.Text = PhieuTinhTien.KH_DienThoai
            txb_email.Text = PhieuTinhTien.KH_Email
            dtp_ngaybatdau.Value = PhieuTinhTien.HD_NgayBatDau
            dtp_ngayhethan.Value = PhieuTinhTien.HD_NgayHetHan
            txb_ngaylapphieu.Text = PhieuTinhTien.PTT_NgayLap
            txb_tungay.Text = PhieuTinhTien.PTT_TuNgay
            txb_denngay.Text = PhieuTinhTien.PTT_DenNgay
            txb_tongthanhtien.Text = PhieuTinhTien.PTT_TongThanhTien
            If PhieuTinhTien.DsCTTinhTien.Count > 0 Then
                For Each _cttt As Bus_TinhTien In PhieuTinhTien.DsCTTinhTien
                    ThemDongdgvDsCTTinhTien(_cttt)
                Next
            End If
            dgvDsHopDong.Enabled = False
            dtp_tungay.Enabled = False
            dtp_denngay.Enabled = False
            btn_tinhtien.Enabled = False
        End If
    End Sub
    Private Sub btn_tinhtien_Click(sender As Object, e As EventArgs) Handles btn_tinhtien.Click
        dgvDsCTTinhTien.Rows.Clear()
        TongThanhTien = 0
        danhsachmathangtinhtien.Clear()

        If txb_mahopdong.Text.Trim <> "" Then
            Dim mahopdong As Integer = Integer.Parse(txb_mahopdong.Text)
            Dim ngaytruoc As Date
            Dim tonkhodauky As Integer = 0
            For Each dongv As DataGridViewRow In dgvDsCTHD.Rows
                Dim mamathang As Integer = dongv.Cells("cthd_mamathang").Value
                'Tinh soluongtonkhodaungay (hay soluongtonkho cuoi ngay truoc)
                If dtp_tungay.Value > dtp_ngaybatdau.Value Then
                    Dim chuoingaybatdauhopdong As String = Format(dtp_ngaybatdau.Value, "yyyy-MM-dd")
                    ngaytruoc = DateAndTime.DateAdd(DateInterval.Day, -1, dtp_tungay.Value)
                    Dim chuoingaytruoc As String = Format(ngaytruoc, "yyyy-MM-dd")
                    tonkhodauky = bus_khohang.TinhSoLuongNhapTrongKhoangThoiGiancuaMatHangTrongHopDong(mahopdong, mamathang, chuoingaybatdauhopdong, chuoingaytruoc) -
                        bus_khohang.TinhSoLuongXuatTrongKhoangThoiGiancuaMatHangTrongHopDong(mahopdong, mamathang, chuoingaybatdauhopdong, chuoingaytruoc)
                End If
                Dim cttinhtien As Bus_TinhTien = New Bus_TinhTien
                cttinhtien.MaHopDong = mahopdong
                cttinhtien.MaMatHang = mamathang
                cttinhtien.MH_Ten = dongv.Cells("mh_ten").Value
                cttinhtien.MH_KhoiLuong = dongv.Cells("mh_khoiluong").Value
                cttinhtien.MH_TheTich = dongv.Cells("mh_thetich").Value
                cttinhtien.PTTT_Ma = dongv.Cells("cthd_maphuongthuctinhtien").Value
                cttinhtien.PTTT_Ten = dongv.Cells("pttt_ten").Value
                cttinhtien.DonGia = dongv.Cells("cthd_dongia").Value
                cttinhtien.TinhTienMatHangChiTiet(dtp_tungay.Value, dtp_denngay.Value, tonkhodauky)
                danhsachmathangtinhtien.Add(cttinhtien)
                ThemDongdgvDsCTTinhTien(cttinhtien)
                TongThanhTien += cttinhtien.ThanhTien
            Next
            txb_tongthanhtien.Text = Format(TongThanhTien, "#,###.##")
            txb_tungay.Text = Format(dtp_tungay.Value, "dd/MM/yyyy")
            txb_denngay.Text = Format(dtp_denngay.Value, "dd/MM/yyyy")
            txb_ngaylapphieu.Text = Format(DateAndTime.Today, "dd/MM/yyyy")
        End If
    End Sub
    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If LoaiHanhDong = 1 Then
            If danhsachmathangtinhtien.Count > 0 Then
                Dim phieutinhtien As DataRow = DsPhieuTinhTien.NewRow
                phieutinhtien.Item("ptt_mahopdong") = Integer.Parse(txb_mahopdong.Text)
                phieutinhtien.Item("ptt_ngaylap") = DateValue(txb_ngaylapphieu.Text)
                phieutinhtien.Item("ptt_tungay") = DateValue(txb_tungay.Text)
                phieutinhtien.Item("ptt_denngay") = DateValue(txb_denngay.Text)
                phieutinhtien.Item("ptt_tongthanhtien") = Double.Parse(txb_tongthanhtien.Text)
                phieutinhtien.Item("ptt_manguoidung") = My.MyApplication.NguoiDung.Item("nd_ma")
                phieutinhtien.Item("ptt_daxoa") = 0
                phieutinhtien.Item("ptt_thoidiemcapnhat") = DateAndTime.Now
                DsPhieuTinhTien.Rows.Add(phieutinhtien)
                Dim cautruyvanluuphieutinhtien As String = "Select ptt_ma, ptt_mahopdong,ptt_ngaylap, ptt_tungay, ptt_denngay,
                                                            ptt_tongthanhtien, ptt_manguoidung, ptt_daxoa, ptt_thoidiemcapnhat   
                                                        From PhieuTinhTien"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanluuphieutinhtien, DsPhieuTinhTien)
                For Each mathangtinhtien As Bus_TinhTien In danhsachmathangtinhtien
                    Dim cttinhtien As DataRow = DsCtTinhTien.NewRow
                    cttinhtien.Item("cttt_maphieutinhtien") = phieutinhtien.Item("ptt_ma")
                    cttinhtien.Item("cttt_mamathang") = mathangtinhtien.MaMatHang
                    cttinhtien.Item("cttt_maphuongthuctinhtien") = mathangtinhtien.PTTT_Ma
                    cttinhtien.Item("cttt_dongia") = mathangtinhtien.DonGia
                    cttinhtien.Item("cttt_soluongbinhquan") = mathangtinhtien.TonKhoBinhQuan
                    cttinhtien.Item("cttt_thanhtien") = mathangtinhtien.ThanhTien
                    cttinhtien.Item("cttt_daxoa") = 0
                    cttinhtien.Item("cttt_thoidiemcapnhat") = DateTime.Now
                    DsCtTinhTien.Rows.Add(cttinhtien)
                Next
                Dim cautruyvanluucttinhtien As String = "select cttt_dongia, cttt_soluongbinhquan,cttt_thanhtien, 
                                                cttt_daxoa, cttt_thoidiemcapnhat, cttt_ma, cttt_maphieutinhtien, cttt_mamathang,cttt_maphuongthuctinhtien
                                                from CTTinhTien"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanluucttinhtien, DsCtTinhTien)
                Me.Close()
            Else
                MessageBox.Show("Vui lòng chọn hợp đồng cần tính tiền và  thực hiện tính tiền cho khoảng thời gian cần tính trước khi lưu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf LoaiHanhDong = 2 Then
            If danhsachmathangtinhtien.Count > 0 Then
                Dim phieutinhtien As DataRow = DsPhieuTinhTien.Select($"ptt_ma ={txb_ma.Text} ")(0)
                phieutinhtien.Item("ptt_mahopdong") = Integer.Parse(txb_mahopdong.Text)
                phieutinhtien.Item("ptt_ngaylap") = DateValue(txb_ngaylapphieu.Text)
                phieutinhtien.Item("ptt_tungay") = DateValue(txb_tungay.Text)
                phieutinhtien.Item("ptt_denngay") = DateValue(txb_denngay.Text)
                phieutinhtien.Item("ptt_tongthanhtien") = Double.Parse(txb_tongthanhtien.Text)
                phieutinhtien.Item("ptt_manguoidung") = My.MyApplication.NguoiDung.Item("nd_ma")
                phieutinhtien.Item("ptt_thoidiemcapnhat") = DateAndTime.Now

                Dim cautruyvanluuphieutinhtien As String = "Select ptt_ma, ptt_mahopdong,ptt_ngaylap, ptt_tungay, ptt_denngay,
                                                            ptt_tongthanhtien, ptt_manguoidung, ptt_daxoa, ptt_thoidiemcapnhat   
                                                        From PhieuTinhTien"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanluuphieutinhtien, DsPhieuTinhTien)
                For Each cttinhtien As DataRow In DsCtTinhTien.Rows
                    If cttinhtien("cttt_maphieutinhtien") = txb_ma.Text Then
                        cttinhtien.Item("cttt_daxoa") = 1
                        cttinhtien.Item("cttt_thoidiemcapnhat") = DateTime.Now
                    End If
                Next
                For Each mathangtinhtien As Bus_TinhTien In danhsachmathangtinhtien
                    Dim cttinhtien As DataRow = DsCtTinhTien.NewRow
                    cttinhtien.Item("cttt_maphieutinhtien") = phieutinhtien.Item("ptt_ma")
                    cttinhtien.Item("cttt_mamathang") = mathangtinhtien.MaMatHang
                    cttinhtien.Item("cttt_maphuongthuctinhtien") = mathangtinhtien.PTTT_Ma
                    cttinhtien.Item("cttt_dongia") = mathangtinhtien.DonGia
                    cttinhtien.Item("cttt_soluongbinhquan") = mathangtinhtien.TonKhoBinhQuan
                    cttinhtien.Item("cttt_thanhtien") = mathangtinhtien.ThanhTien
                    cttinhtien.Item("cttt_daxoa") = 0
                    cttinhtien.Item("cttt_thoidiemcapnhat") = DateTime.Now
                    DsCtTinhTien.Rows.Add(cttinhtien)
                Next
                Dim cautruyvanluucttinhtien As String = "select cttt_dongia, cttt_soluongbinhquan,cttt_thanhtien, 
                                                cttt_daxoa, cttt_thoidiemcapnhat, cttt_ma, cttt_maphieutinhtien, cttt_mamathang,cttt_maphuongthuctinhtien
                                                from CTTinhTien"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanluucttinhtien, DsCtTinhTien)
                Me.Close()
            Else
                MessageBox.Show("Vui lòng chọn hợp đồng cần tính tiền và  thực hiện tính tiền cho khoảng thời gian cần tính trước khi lưu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf LoaiHanhDong = 3 Then

            Dim phieutinhtien As DataRow = DsPhieuTinhTien.Select($"ptt_ma ={txb_ma.Text} ")(0)
            phieutinhtien.Item("ptt_daxoa") = 1
            phieutinhtien.Item("ptt_manguoidung") = My.MyApplication.NguoiDung.Item("nd_ma")
            phieutinhtien.Item("ptt_thoidiemcapnhat") = DateAndTime.Now

                Dim cautruyvanluuphieutinhtien As String = "Select ptt_ma, ptt_mahopdong,ptt_ngaylap, ptt_tungay, ptt_denngay,
                                                            ptt_tongthanhtien, ptt_manguoidung, ptt_daxoa, ptt_thoidiemcapnhat   
                                                        From PhieuTinhTien"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanluuphieutinhtien, DsPhieuTinhTien)
                For Each cttinhtien As DataRow In DsCtTinhTien.Rows
                    If cttinhtien("cttt_maphieutinhtien") = txb_ma.Text Then
                        cttinhtien.Item("cttt_daxoa") = 1
                        cttinhtien.Item("cttt_thoidiemcapnhat") = DateTime.Now
                    End If
                Next

            Dim cautruyvanluucttinhtien As String = "select cttt_dongia, cttt_soluongbinhquan,cttt_thanhtien, 
                                                cttt_daxoa, cttt_thoidiemcapnhat, cttt_ma, cttt_maphieutinhtien, cttt_mamathang,cttt_maphuongthuctinhtien
                                                from CTTinhTien"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanluucttinhtien, DsCtTinhTien)
            Me.Close()
        End If
    End Sub
    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub
    Private Sub txb_timhopdong_TextChanged(sender As Object, e As EventArgs) Handles txb_timhopdong.TextChanged
        If txb_timhopdong.Text.Trim <> "" Then
            Dim ndt = txb_timhopdong.Text.ToLower
            Dim dskq =
                From hd In DsHopDong
                Where hd.Item("hd_ma").ToString.Contains(ndt) Or hd.Item("kh_dienthoai").ToString.ToLower.Contains(ndt) Or
                hd.Item("kh_ten").ToString.ToLower.Contains(ndt) Or hd.Item("kh_diachi").ToString.ToLower.Contains(ndt)
                Select hd
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable
            End If
            dgvDsHopDong.DataSource = dtdskq
        Else
            dgvDsHopDong.DataSource = DsHopDong
        End If
        DinhdangdgvDSHopDong()
    End Sub
    Private Sub dgvDsHopDong_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsHopDong.CellClick
        Dim dong As DataGridViewRow = dgvDsHopDong.CurrentRow
        If Not dong.IsNewRow Then
            TaiDuLieudgvDsCTHD(dong.Cells("hd_ma").Value)
            DinhdangdgvDsCTHD()
            txb_mahopdong.Text = dong.Cells("hd_ma").Value
            txb_tenkhachhang.Text = dong.Cells("kh_ten").Value
            txb_loaigtpl.Text = dong.Cells("gt_ten").Value
            txb_gtplso.Text = dong.Cells("kh_gtplso").Value
            txb_diachi.Text = dong.Cells("kh_diachi").Value
            txb_dienthoai.Text = dong.Cells("kh_dienthoai").Value
            txb_email.Text = dong.Cells("kh_email").Value
            dtp_ngaybatdau.Value = dong.Cells("hd_ngaybatdau").Value
            dtp_ngayhethan.Value = dong.Cells("hd_ngayhethan").Value
        End If
    End Sub
    Private Sub btn_xemchitiet_Click(sender As Object, e As EventArgs) Handles btn_xemchitiet.Click
        If danhsachmathangtinhtien.Count > 0 Then
            Dim mh As Frm_PhieuTinhTien_BangTinhChiTiet = New Frm_PhieuTinhTien_BangTinhChiTiet
            mh.danhsachmathangtinhtien.Clear()
            mh.danhsachmathangtinhtien = danhsachmathangtinhtien
            mh.MaHopDong = Integer.Parse(txb_mahopdong.Text)
            'mh.MaPhieuTinhTien = Integer.Parse(txb_ma.Text)
            mh.TenKhachHang = txb_tenkhachhang.Text
            mh.TuNgay = DateValue(txb_tungay.Text)
            mh.DenNgay = DateValue(txb_denngay.Text)
            mh.TongThanhTien = txb_tongthanhtien.Text
            mh.WindowState = FormWindowState.Maximized
            mh.ShowDialog()
        Else
            MessageBox.Show("Vui lòng thực hiện tính tiền trước khi xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Sub TaiDuLieuDsPhieuTinhTien()
        Dim cautruyvanphieutinhtien As String = "select ptt_ma, ptt_mahopdong,ptt_ngaylap, ptt_tungay, ptt_denngay,
                                                        ptt_tongthanhtien, ptt_manguoidung, ptt_daxoa, ptt_thoidiemcapnhat,hd_ngaybatdau, 
                                                         hd_ngayhethan, kh_ten, kh_gtplso, kh_diachi, kh_dienthoai, kh_email, gt_ten  
                                                 from HopDong join PhieuTinhTien on ptt_mahopdong = hd_ma join
                                                    KhachHang on kh_ma = hd_makhachhang join 
                                                    LoaiGiayToPhapLy on kh_maloaigtpl = gt_ma
                                                    where ptt_daxoa = 0"
        DsPhieuTinhTien = xl_dulieu.DocDuLieu(cautruyvanphieutinhtien)
    End Sub
    Sub TaiDuLieuDsCTTinhTien()
        Dim cautruyvancttinhtien As String = "select mh_ten, mh_khoiluong, mh_thetich,pttt_ten, cttt_dongia, cttt_soluongbinhquan,cttt_thanhtien, 
                                                cttt_daxoa, cttt_thoidiemcapnhat, cttt_ma, cttt_maphieutinhtien, cttt_mamathang,cttt_maphuongthuctinhtien
                                                from PhieuTinhTien right join CTTinhTien on cttt_maphieutinhtien = ptt_ma
                                                join PhuongThucTinhTien on cttt_maphuongthuctinhtien = pttt_ma
                                                join MatHang on cttt_mamathang = mh_ma where cttt_daxoa =0"
        DsCtTinhTien = xl_dulieu.DocDuLieu(cautruyvancttinhtien)
    End Sub
    Sub TaiDuLieudgvDsCTHD(ByVal mahopdong As Integer)
        Dim cautruyvancthd As String
        cautruyvancthd = $"select cthd_mamathang, mh_ten, mh_khoiluong, mh_thetich, pttt_ten, cthd_dongia,cthd_maphuongthuctinhtien
                            from MatHang join CTHopDong on mh_ma = cthd_mamathang 
                            join PhuongThucTinhTien on cthd_maphuongthuctinhtien = pttt_ma
                            where cthd_daxoa = 0 and cthd_mahopdong = {mahopdong}"
        DsCTHD = xl_dulieu.DocDuLieu(cautruyvancthd)
        dgvDsCTHD.DataSource = DsCTHD
        dgvDsCTHD.RowHeadersVisible = False
        dgvDsCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDsCTHD.ReadOnly = True

        dgvDsCTHD.Columns("mh_khoiluong").HeaderText = "Khối lượng"
        dgvDsCTHD.Columns("mh_khoiluong").Width = 70
        dgvDsCTHD.Columns("mh_thetich").HeaderText = "Thể tích"
        dgvDsCTHD.Columns("mh_thetich").Width = 70
        dgvDsCTHD.Columns("mh_ten").HeaderText = "Tên mặt hàng"
        dgvDsCTHD.Columns("mh_ten").Width = 180
        dgvDsCTHD.Columns("pttt_ten").HeaderText = "Phương thức tính tiền"
        dgvDsCTHD.Columns("pttt_ten").Width = 180
        dgvDsCTHD.Columns("cthd_dongia").HeaderText = "Đơn giá"
        dgvDsCTHD.Columns("cthd_dongia").Width = 100
        dgvDsCTHD.Columns("cthd_mamathang").Visible = False
        dgvDsCTHD.Columns("cthd_maphuongthuctinhtien").Visible = False
    End Sub
    Sub DinhdangdgvDsCTHD()
        If dgvDsCTHD.Columns.Count > 4 Then
            dgvDsCTHD.RowHeadersVisible = False
            dgvDsCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTHD.ReadOnly = True
            dgvDsCTHD.Columns("cthd_mamathang").Visible = False
            dgvDsCTHD.Columns("mh_khoiluong").HeaderText = "Khối lượng"
            dgvDsCTHD.Columns("mh_khoiluong").Width = 70
            dgvDsCTHD.Columns("mh_thetich").HeaderText = "Thể tích"
            dgvDsCTHD.Columns("mh_thetich").Width = 70
            dgvDsCTHD.Columns("mh_ten").HeaderText = "Tên mặt hàng"
            dgvDsCTHD.Columns("mh_ten").Width = 180
            dgvDsCTHD.Columns("pttt_ten").HeaderText = "Phương thức tính tiền"
            dgvDsCTHD.Columns("pttt_ten").Width = 180
            dgvDsCTHD.Columns("cthd_dongia").HeaderText = "Đơn giá"
            dgvDsCTHD.Columns("cthd_dongia").Width = 90
        End If
    End Sub
    Sub TaiDuLieuDgvDsHopDong()
        Dim cautruyvanhopdong As String
        cautruyvanhopdong = "select h.hd_ma, k.kh_ten, l.gt_ten, k.kh_gtplso,h.hd_ngayhopdong,h.hd_ngaybatdau,h.hd_ngayhethan,h.hd_soluongmathang,
                             k.kh_diachi, k.kh_dienthoai, k.kh_email, h.hd_cohieuluc
                            from HopDong h join KhachHang k on h.hd_makhachhang = k.kh_ma join LoaiGiayToPhapLy l on l.gt_ma= k.kh_maloaigtpl where h.hd_daxoa = 0 and h.hd_cohieuluc=1"
        DsHopDong = xl_dulieu.DocDuLieu(cautruyvanhopdong)
        dgvDsHopDong.DataSource = DsHopDong
    End Sub
    Sub DinhdangdgvDSHopDong()
        If dgvDsHopDong.Columns.Count > 9 Then
            dgvDsHopDong.RowHeadersVisible = False
            dgvDsHopDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsHopDong.ReadOnly = True

            dgvDsHopDong.Columns(0).HeaderText = "Mã hợp đồng"
            dgvDsHopDong.Columns(0).AutoSizeMode = False
            dgvDsHopDong.Columns(0).Width = 60
            dgvDsHopDong.Columns(1).HeaderText = "Tên khách hàng"
            dgvDsHopDong.Columns(1).AutoSizeMode = False
            dgvDsHopDong.Columns(1).Width = 180
            dgvDsHopDong.Columns(2).HeaderText = "Loại GTPL"
            dgvDsHopDong.Columns(2).AutoSizeMode = False
            dgvDsHopDong.Columns(2).Width = 75
            dgvDsHopDong.Columns(3).HeaderText = "GTPL số"
            dgvDsHopDong.Columns(3).AutoSizeMode = False
            dgvDsHopDong.Columns(3).Width = 95
            dgvDsHopDong.Columns(4).HeaderText = "Ngày hợp đồng"
            dgvDsHopDong.Columns(4).AutoSizeMode = False
            dgvDsHopDong.Columns(4).Width = 80
            dgvDsHopDong.Columns(5).HeaderText = "Ngày bắt đầu"
            dgvDsHopDong.Columns(5).AutoSizeMode = False
            dgvDsHopDong.Columns(5).Width = 80
            dgvDsHopDong.Columns(6).HeaderText = "Ngày hết hạn"
            dgvDsHopDong.Columns(6).AutoSizeMode = False
            dgvDsHopDong.Columns(6).Width = 80
            dgvDsHopDong.Columns(7).HeaderText = "Số lượng mặt hàng"
            dgvDsHopDong.Columns(7).AutoSizeMode = False
            dgvDsHopDong.Columns(7).Width = 60
            dgvDsHopDong.Columns(8).HeaderText = "Địa chỉ"
            dgvDsHopDong.Columns(8).AutoSizeMode = False
            dgvDsHopDong.Columns(8).Width = 120
            dgvDsHopDong.Columns(9).HeaderText = "Điện thoại"
            dgvDsHopDong.Columns(9).AutoSizeMode = False
            dgvDsHopDong.Columns(9).Width = 90
            dgvDsHopDong.Columns(10).HeaderText = "Email"
            dgvDsHopDong.Columns(10).AutoSizeMode = False
            dgvDsHopDong.Columns(10).Width = 120
            dgvDsHopDong.Columns(11).Visible = False
        End If
    End Sub
    Sub ThemDongdgvDsCTTinhTien(ByVal cttinhtien As Bus_TinhTien)
        If dgvDsCTTinhTien.Columns.Count < 8 Then
            dgvDsCTTinhTien.RowHeadersVisible = False
            Dim cot0 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot1 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot2 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot3 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot4 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot5 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot6 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot7 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn

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
    End Sub
End Class