Public Class Frm_PhieuTinhTien_Index
    Dim DsPhieuTinhTien As DataTable = New DataTable
    Dim DsCtTinhTien As DataTable = New DataTable
    Dim danhsachmathangtinhtien As List(Of Bus_TinhTien) = New List(Of Bus_TinhTien)
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu
    Dim isClosed As Boolean = True
    Private Sub Frm_PhieuTinhTien_Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TheHiendgvDsPhieuTinhTien()
        TaiDuLieuDsCTTinhTien()
    End Sub
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        TheHiendgvDsPhieuTinhTien()
        TaiDuLieuDsCTTinhTien()
    End Sub
    Private Sub btn_XemChiTiet_Click(sender As Object, e As EventArgs) Handles btn_XemChiTiet.Click
        If dgvDsCTTinhTien.Rows.Count > 0 Then
            danhsachmathangtinhtien.Clear()
            For i As Integer = 0 To dgvDsCTTinhTien.Rows.Count - 1
                Dim _cttt As Bus_TinhTien = New Bus_TinhTien
                _cttt.MaMatHang = dgvDsCTTinhTien.Rows(i).Cells("cttt_mamathang").Value
                _cttt.MH_Ten = dgvDsCTTinhTien.Rows(i).Cells("mh_ten").Value
                _cttt.MH_KhoiLuong = dgvDsCTTinhTien.Rows(i).Cells("mh_khoiluong").Value
                _cttt.MH_TheTich = dgvDsCTTinhTien.Rows(i).Cells("mh_thetich").Value
                _cttt.PTTT_Ma = dgvDsCTTinhTien.Rows(i).Cells("cttt_maphuongthuctinhtien").Value
                _cttt.PTTT_Ten = dgvDsCTTinhTien.Rows(i).Cells("pttt_ten").Value
                _cttt.DonGia = dgvDsCTTinhTien.Rows(i).Cells("cttt_dongia").Value
                _cttt.TonKhoBinhQuan = dgvDsCTTinhTien.Rows(i).Cells("cttt_soluongbinhquan").Value
                _cttt.ThanhTien = dgvDsCTTinhTien.Rows(i).Cells("cttt_thanhtien").Value
                danhsachmathangtinhtien.Add(_cttt)
            Next
            Dim mh As Frm_PhieuTinhTien_BangTinhChiTiet = New Frm_PhieuTinhTien_BangTinhChiTiet
            mh.danhsachmathangtinhtien.Clear()
            mh.danhsachmathangtinhtien = danhsachmathangtinhtien
            mh.MaHopDong = Integer.Parse(txb_mahopdong.Text)
            mh.MaPhieuTinhTien = Integer.Parse(txb_ma.Text)
            mh.TenKhachHang = txb_tenkhachhang.Text
            mh.TuNgay = DateValue(txb_tungay.Text)
            mh.DenNgay = DateValue(txb_denngay.Text)
            mh.TongThanhTien = txb_tongthanhtien.Text

            mh.WindowState = FormWindowState.Maximized
            mh.ShowDialog()
        Else
            MessageBox.Show("Vui lòng chọn phiếu tính tiền muốn xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        Dim mh As Frm_PhieuTinhTien_Action = New Frm_PhieuTinhTien_Action
        mh.LoaiHanhDong = 1
        mh.MaPhieuTinhTien = -1
        mh.WindowState = FormWindowState.Maximized
        mh.ShowDialog()
    End Sub
    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        If txb_ma.Text.Trim <> "" Then
            Dim mh As Frm_PhieuTinhTien_Action = New Frm_PhieuTinhTien_Action
            mh.LoaiHanhDong = 2
            mh.PhieuTinhTien = New Bus_PhieuTinhTien
            mh.PhieuTinhTien.Ma = Integer.Parse(txb_ma.Text)
            mh.PhieuTinhTien.MaHopDong = Integer.Parse(txb_mahopdong.Text)
            mh.PhieuTinhTien.KH_Ten = txb_tenkhachhang.Text
            mh.PhieuTinhTien.KH_LoaiGTPL = txb_loaigtpl.Text
            mh.PhieuTinhTien.KH_GTPLSo = txb_gtplso.Text
            mh.PhieuTinhTien.KH_DiaChi = txb_diachi.Text
            mh.PhieuTinhTien.KH_DienThoai = txb_dienthoai.Text
            mh.PhieuTinhTien.KH_Email = txb_email.Text
            mh.PhieuTinhTien.HD_NgayBatDau = txb_ngaybatdau.Text
            mh.PhieuTinhTien.HD_NgayHetHan = txb_ngayhethan.Text
            mh.PhieuTinhTien.PTT_NgayLap = txb_ngaylapphieu.Text
            mh.PhieuTinhTien.PTT_TuNgay = txb_tungay.Text
            mh.PhieuTinhTien.PTT_DenNgay = txb_denngay.Text
            mh.PhieuTinhTien.PTT_TongThanhTien = txb_tongthanhtien.Text
            mh.PhieuTinhTien.DsCTTinhTien = New List(Of Bus_TinhTien)
            If dgvDsCTTinhTien.Rows.Count > 0 Then
                danhsachmathangtinhtien.Clear()
                For i As Integer = 0 To dgvDsCTTinhTien.Rows.Count - 1
                    Dim _cttt As Bus_TinhTien = New Bus_TinhTien
                    _cttt.Ma = dgvDsCTTinhTien.Rows(i).Cells("cttt_ma").Value
                    _cttt.MaMatHang = dgvDsCTTinhTien.Rows(i).Cells("cttt_mamathang").Value
                    _cttt.MH_Ten = dgvDsCTTinhTien.Rows(i).Cells("mh_ten").Value
                    _cttt.MH_KhoiLuong = dgvDsCTTinhTien.Rows(i).Cells("mh_khoiluong").Value
                    _cttt.MH_TheTich = dgvDsCTTinhTien.Rows(i).Cells("mh_thetich").Value
                    _cttt.PTTT_Ma = dgvDsCTTinhTien.Rows(i).Cells("cttt_maphuongthuctinhtien").Value
                    _cttt.PTTT_Ten = dgvDsCTTinhTien.Rows(i).Cells("pttt_ten").Value
                    _cttt.DonGia = dgvDsCTTinhTien.Rows(i).Cells("cttt_dongia").Value
                    _cttt.TonKhoBinhQuan = dgvDsCTTinhTien.Rows(i).Cells("cttt_soluongbinhquan").Value
                    _cttt.ThanhTien = dgvDsCTTinhTien.Rows(i).Cells("cttt_thanhtien").Value
                    danhsachmathangtinhtien.Add(_cttt)
                Next
            End If
            mh.PhieuTinhTien.DsCTTinhTien = danhsachmathangtinhtien
            mh.WindowState = FormWindowState.Maximized
            mh.ShowDialog()
        Else
            MessageBox.Show("Vui lòng chọn Phiếu tính tiền muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        If txb_ma.Text.Trim <> "" Then
            Dim mh As Frm_PhieuTinhTien_Action = New Frm_PhieuTinhTien_Action
            mh.LoaiHanhDong = 3
            mh.PhieuTinhTien = New Bus_PhieuTinhTien
            mh.PhieuTinhTien.Ma = Integer.Parse(txb_ma.Text)
            mh.PhieuTinhTien.MaHopDong = Integer.Parse(txb_mahopdong.Text)
            mh.PhieuTinhTien.KH_Ten = txb_tenkhachhang.Text
            mh.PhieuTinhTien.KH_LoaiGTPL = txb_loaigtpl.Text
            mh.PhieuTinhTien.KH_GTPLSo = txb_gtplso.Text
            mh.PhieuTinhTien.KH_DiaChi = txb_diachi.Text
            mh.PhieuTinhTien.KH_DienThoai = txb_dienthoai.Text
            mh.PhieuTinhTien.KH_Email = txb_email.Text
            mh.PhieuTinhTien.HD_NgayBatDau = txb_ngaybatdau.Text
            mh.PhieuTinhTien.HD_NgayHetHan = txb_ngayhethan.Text
            mh.PhieuTinhTien.PTT_NgayLap = txb_ngaylapphieu.Text
            mh.PhieuTinhTien.PTT_TuNgay = txb_tungay.Text
            mh.PhieuTinhTien.PTT_DenNgay = txb_denngay.Text
            mh.PhieuTinhTien.PTT_TongThanhTien = txb_tongthanhtien.Text
            mh.PhieuTinhTien.DsCTTinhTien = New List(Of Bus_TinhTien)
            If dgvDsCTTinhTien.Rows.Count > 0 Then
                danhsachmathangtinhtien.Clear()
                For i As Integer = 0 To dgvDsCTTinhTien.Rows.Count - 1
                    Dim _cttt As Bus_TinhTien = New Bus_TinhTien
                    _cttt.Ma = dgvDsCTTinhTien.Rows(i).Cells("cttt_ma").Value
                    _cttt.MaMatHang = dgvDsCTTinhTien.Rows(i).Cells("cttt_mamathang").Value
                    _cttt.MH_Ten = dgvDsCTTinhTien.Rows(i).Cells("mh_ten").Value
                    _cttt.MH_KhoiLuong = dgvDsCTTinhTien.Rows(i).Cells("mh_khoiluong").Value
                    _cttt.MH_TheTich = dgvDsCTTinhTien.Rows(i).Cells("mh_thetich").Value
                    _cttt.PTTT_Ma = dgvDsCTTinhTien.Rows(i).Cells("cttt_maphuongthuctinhtien").Value
                    _cttt.PTTT_Ten = dgvDsCTTinhTien.Rows(i).Cells("pttt_ten").Value
                    _cttt.DonGia = dgvDsCTTinhTien.Rows(i).Cells("cttt_dongia").Value
                    _cttt.TonKhoBinhQuan = dgvDsCTTinhTien.Rows(i).Cells("cttt_soluongbinhquan").Value
                    _cttt.ThanhTien = dgvDsCTTinhTien.Rows(i).Cells("cttt_thanhtien").Value
                    danhsachmathangtinhtien.Add(_cttt)
                Next
            End If
            mh.PhieuTinhTien.DsCTTinhTien = danhsachmathangtinhtien
            mh.WindowState = FormWindowState.Maximized
            mh.ShowDialog()
        Else
            MessageBox.Show("Vui lòng chọn Phiếu tính tiền muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()

    End Sub


    Private Sub txb_noidungtim_TextChanged(sender As Object, e As EventArgs) Handles txb_noidungtim.TextChanged
        If txb_noidungtim.Text.Trim <> "" Then
            Dim ndt As String = txb_noidungtim.Text.ToLower
            Dim dskq =
                From ptt In DsPhieuTinhTien
                Where ptt.Item("kh_ten").ToString.ToLower.Contains(ndt) Or ptt.Item("kh_diachi").ToString.ToLower.Contains(ndt) Or
                    ptt.Item("kh_dienthoai").ToString.ToLower.Contains(ndt) Or ptt.Item("ptt_mahopdong").ToString = ndt Or ptt.Item("ptt_ma").ToString = ndt Or
                    ptt.Item("ptt_ngaylap").ToString.ToLower.Contains(ndt) Or ptt.Item("ptt_tongthanhtien").ToString.ToLower.Contains(ndt)
                Select ptt
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable
            End If
            dgvDsPhieuTinhTien.DataSource = dtdskq
        Else
            dgvDsPhieuTinhTien.DataSource = DsPhieuTinhTien
        End If
        DinhdangdgvDsPhieuTinhTien()

    End Sub
    Private Sub dgvDsPhieuTinhTien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsPhieuTinhTien.CellClick
        Dim dong = dgvDsPhieuTinhTien.CurrentRow
        If dong.IsNewRow = False Then
            Dim maphieutinhtien As Integer = dong.Cells("ptt_ma").Value
            TheHiendgvDsCtTinhTien(maphieutinhtien)
            txb_ma.Text = dong.Cells("ptt_ma").Value
            txb_mahopdong.Text = dong.Cells("ptt_mahopdong").Value
            txb_tenkhachhang.Text = dong.Cells("kh_ten").Value
            txb_loaigtpl.Text = dong.Cells("gt_ten").Value
            txb_gtplso.Text = dong.Cells("kh_gtplso").Value
            txb_diachi.Text = dong.Cells("kh_diachi").Value
            txb_dienthoai.Text = dong.Cells("kh_dienthoai").Value
            txb_email.Text = dong.Cells("kh_email").Value
            txb_ngaybatdau.Text = Format(dong.Cells("hd_ngaybatdau").Value, "dd/MM/yyyy")
            txb_ngayhethan.Text = Format(dong.Cells("hd_ngayhethan").Value, "dd/MM/yyyy")
            txb_ngaylapphieu.Text = Format(dong.Cells("ptt_ngaylap").Value, "dd/MM/yyyy")
            txb_tongthanhtien.Text = Format(dong.Cells("ptt_tongthanhtien").Value, "#,###.##")
            txb_tungay.Text = Format(dong.Cells("ptt_tungay").Value, "dd/MM/yyyy")
            txb_denngay.Text = Format(dong.Cells("ptt_denngay").Value, "dd/MM/yyyy")
            txb_mataikhoan.Text = dong.Cells("ptt_manguoidung").Value
            txb_manhanvien.Text = dong.Cells("nd_manhanvien").Value
            txb_tennhanvien.Text = dong.Cells("nd_hoten").Value
        End If
    End Sub
    Sub TaiDuLieuDsPhieuTinhTien()
        Dim cautruyvanphieutinhtien As String = "select ptt_ma, ptt_mahopdong,kh_ten, gt_ten,kh_gtplso, ptt_ngaylap, ptt_tungay, ptt_denngay,
                                                        ptt_tongthanhtien,kh_diachi, kh_dienthoai, kh_email, ptt_manguoidung, ptt_daxoa,  
                                                        ptt_thoidiemcapnhat,hd_ngaybatdau, hd_ngayhethan, nd_manhanvien, nd_hoten   
                                                 from HopDong join PhieuTinhTien on ptt_mahopdong = hd_ma join
                                                    KhachHang on kh_ma = hd_makhachhang join 
                                                    LoaiGiayToPhapLy on kh_maloaigtpl = gt_ma join NguoiDung on ptt_manguoidung = nd_ma
                                                    where ptt_daxoa = 0"
        DsPhieuTinhTien = XL_DuLieu.DocDuLieu(cautruyvanphieutinhtien)
    End Sub
    Sub TaiDuLieuDsCTTinhTien()
        Dim cautruyvancttinhtien As String = "select mh_ten, mh_khoiluong, mh_thetich,pttt_ten, cttt_dongia, cttt_soluongbinhquan,cttt_thanhtien, 
                                                cttt_daxoa, cttt_thoidiemcapnhat, cttt_ma, cttt_maphieutinhtien, cttt_mamathang,cttt_maphuongthuctinhtien
                                                from PhieuTinhTien right join CTTinhTien on cttt_maphieutinhtien = ptt_ma
                                                join PhuongThucTinhTien on cttt_maphuongthuctinhtien = pttt_ma
                                                join MatHang on cttt_mamathang = mh_ma where cttt_daxoa =0"
        DsCtTinhTien = xl_dulieu.DocDuLieu(cautruyvancttinhtien)
    End Sub
    Sub TheHiendgvDsPhieuTinhTien()
        TaiDuLieuDsPhieuTinhTien()
        dgvDsPhieuTinhTien.DataSource = DsPhieuTinhTien
        If dgvDsPhieuTinhTien.Columns.Count > 9 Then
            dgvDsPhieuTinhTien.RowHeadersVisible = False
            dgvDsPhieuTinhTien.ReadOnly = True
            dgvDsPhieuTinhTien.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            dgvDsPhieuTinhTien.Columns("ptt_ma").HeaderText = "Mã Phiếu"
            dgvDsPhieuTinhTien.Columns("ptt_ma").Width = 60
            dgvDsPhieuTinhTien.Columns("ptt_mahopdong").HeaderText = "Mã Hợp đồng"
            dgvDsPhieuTinhTien.Columns("ptt_mahopdong").Width = 60
            dgvDsPhieuTinhTien.Columns("ptt_ngaylap").HeaderText = "Ngày lập"
            dgvDsPhieuTinhTien.Columns("ptt_ngaylap").Width = 75
            dgvDsPhieuTinhTien.Columns("ptt_tungay").HeaderText = "Từ ngày"
            dgvDsPhieuTinhTien.Columns("ptt_tungay").Width = 75
            dgvDsPhieuTinhTien.Columns("ptt_denngay").HeaderText = "Đến ngày"
            dgvDsPhieuTinhTien.Columns("ptt_denngay").Width = 75
            dgvDsPhieuTinhTien.Columns("kh_ten").HeaderText = "Tên khách hàng"
            dgvDsPhieuTinhTien.Columns("kh_ten").Width = 220
            dgvDsPhieuTinhTien.Columns("gt_ten").HeaderText = "Loại GTPL"
            dgvDsPhieuTinhTien.Columns("gt_ten").Width = 75
            dgvDsPhieuTinhTien.Columns("kh_gtplso").HeaderText = "GTPL số"
            dgvDsPhieuTinhTien.Columns("kh_gtplso").Width = 90
            dgvDsPhieuTinhTien.Columns("ptt_tongthanhtien").HeaderText = "Tổng thành tiền"
            dgvDsPhieuTinhTien.Columns("ptt_tongthanhtien").Width = 95
            dgvDsPhieuTinhTien.Columns("kh_diachi").HeaderText = "Địa chỉ"
            dgvDsPhieuTinhTien.Columns("kh_diachi").Width = 150

            dgvDsPhieuTinhTien.Columns("ptt_daxoa").Visible = False
            dgvDsPhieuTinhTien.Columns("ptt_thoidiemcapnhat").Visible = False
            dgvDsPhieuTinhTien.Columns("ptt_manguoidung").Visible = False
            dgvDsPhieuTinhTien.Columns("kh_dienthoai").Visible = False
            dgvDsPhieuTinhTien.Columns("kh_email").Visible = False
            dgvDsPhieuTinhTien.Columns("hd_ngaybatdau").Visible = False
            dgvDsPhieuTinhTien.Columns("hd_ngayhethan").Visible = False
            dgvDsPhieuTinhTien.Columns("nd_hoten").Visible = False
            dgvDsPhieuTinhTien.Columns("nd_manhanvien").Visible = False
        End If
    End Sub
    Sub DinhdangdgvDsPhieuTinhTien()
        If dgvDsPhieuTinhTien.Columns.Count > 9 Then
            dgvDsPhieuTinhTien.RowHeadersVisible = False
            dgvDsPhieuTinhTien.ReadOnly = True
            dgvDsPhieuTinhTien.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            dgvDsPhieuTinhTien.Columns("ptt_ma").HeaderText = "Mã Phiếu"
            dgvDsPhieuTinhTien.Columns("ptt_ma").Width = 60
            dgvDsPhieuTinhTien.Columns("ptt_mahopdong").HeaderText = "Mã Hợp đồng"
            dgvDsPhieuTinhTien.Columns("ptt_mahopdong").Width = 60
            dgvDsPhieuTinhTien.Columns("ptt_ngaylap").HeaderText = "Ngày lập"
            dgvDsPhieuTinhTien.Columns("ptt_ngaylap").Width = 75
            dgvDsPhieuTinhTien.Columns("ptt_tungay").HeaderText = "Từ ngày"
            dgvDsPhieuTinhTien.Columns("ptt_tungay").Width = 75
            dgvDsPhieuTinhTien.Columns("ptt_denngay").HeaderText = "Đến ngày"
            dgvDsPhieuTinhTien.Columns("ptt_denngay").Width = 75
            dgvDsPhieuTinhTien.Columns("kh_ten").HeaderText = "Tên khách hàng"
            dgvDsPhieuTinhTien.Columns("kh_ten").Width = 220
            dgvDsPhieuTinhTien.Columns("gt_ten").HeaderText = "Loại GTPL"
            dgvDsPhieuTinhTien.Columns("gt_ten").Width = 75
            dgvDsPhieuTinhTien.Columns("kh_gtplso").HeaderText = "GTPL số"
            dgvDsPhieuTinhTien.Columns("kh_gtplso").Width = 90
            dgvDsPhieuTinhTien.Columns("ptt_tongthanhtien").HeaderText = "Tổng thành tiền"
            dgvDsPhieuTinhTien.Columns("ptt_tongthanhtien").Width = 95
            dgvDsPhieuTinhTien.Columns("kh_diachi").HeaderText = "Địa chỉ"
            dgvDsPhieuTinhTien.Columns("kh_diachi").Width = 150

            dgvDsPhieuTinhTien.Columns("ptt_daxoa").Visible = False
            dgvDsPhieuTinhTien.Columns("ptt_thoidiemcapnhat").Visible = False
            dgvDsPhieuTinhTien.Columns("ptt_manguoidung").Visible = False
            dgvDsPhieuTinhTien.Columns("kh_dienthoai").Visible = False
            dgvDsPhieuTinhTien.Columns("kh_email").Visible = False
            dgvDsPhieuTinhTien.Columns("hd_ngaybatdau").Visible = False
            dgvDsPhieuTinhTien.Columns("hd_ngayhethan").Visible = False
            dgvDsPhieuTinhTien.Columns("nd_hoten").Visible = False
            dgvDsPhieuTinhTien.Columns("nd_manhanvien").Visible = False
        End If
    End Sub
    Sub TheHiendgvDsCtTinhTien(ByVal maphieutinhtien As Integer)
        Dim dt_cttts As DataTable = New DataTable
        Dim cttts As DataRow() = DsCtTinhTien.Select($"cttt_maphieutinhtien = {maphieutinhtien} and cttt_daxoa = 0")
        If cttts.Count > 0 Then
            dt_cttts = cttts.CopyToDataTable()
        End If
        dgvDsCTTinhTien.DataSource = dt_cttts
        If dgvDsCTTinhTien.Columns.Count = 13 Then
            dgvDsCTTinhTien.RowHeadersVisible = False
            dgvDsCTTinhTien.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTTinhTien.ReadOnly = True
            Dim cot0 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot5 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot6 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            Dim cot7 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            dgvDsCTTinhTien.Columns.Insert(0, cot0)
            dgvDsCTTinhTien.Columns(0).Name = "stt"
            dgvDsCTTinhTien.Columns(0).HeaderText = "STT"
            dgvDsCTTinhTien.Columns(0).Width = 60
            dgvDsCTTinhTien.Columns("mh_ten").HeaderText = "Tên mặt hàng"
            dgvDsCTTinhTien.Columns("mh_ten").Width = 175
            dgvDsCTTinhTien.Columns("mh_khoiluong").HeaderText = "Khối lượng"
            dgvDsCTTinhTien.Columns("mh_khoiluong").Width = 65
            dgvDsCTTinhTien.Columns("mh_thetich").HeaderText = "Thể tích"
            dgvDsCTTinhTien.Columns("mh_thetich").Width = 65
            dgvDsCTTinhTien.Columns("pttt_ten").HeaderText = "Phương thức tính tiền"
            dgvDsCTTinhTien.Columns("pttt_ten").Width = 165
            dgvDsCTTinhTien.Columns.Insert(5, cot5)
            dgvDsCTTinhTien.Columns(5).Name = "cttt_dongiav"
            dgvDsCTTinhTien.Columns("cttt_dongiav").HeaderText = "Đơn giá"
            dgvDsCTTinhTien.Columns("cttt_dongiav").Width = 75
            dgvDsCTTinhTien.Columns.Insert(6, cot6)
            dgvDsCTTinhTien.Columns(6).Name = "cttt_soluongbinhquanv"
            dgvDsCTTinhTien.Columns("cttt_soluongbinhquanv").HeaderText = "Số lượng tồn kho bình quân"
            dgvDsCTTinhTien.Columns("cttt_soluongbinhquanv").Width = 85
            dgvDsCTTinhTien.Columns.Insert(7, cot7)
            dgvDsCTTinhTien.Columns(7).Name = "cttt_thanhtienv"
            dgvDsCTTinhTien.Columns("cttt_thanhtienv").HeaderText = "Thành tiền"
            dgvDsCTTinhTien.Columns("cttt_thanhtienv").Width = 85
            dgvDsCTTinhTien.Columns(8).Visible = False
            dgvDsCTTinhTien.Columns(9).Visible = False
            dgvDsCTTinhTien.Columns(10).Visible = False
            dgvDsCTTinhTien.Columns(11).Visible = False
            dgvDsCTTinhTien.Columns(12).Visible = False
            dgvDsCTTinhTien.Columns(13).Visible = False
            dgvDsCTTinhTien.Columns(14).Visible = False
            dgvDsCTTinhTien.Columns(15).Visible = False
            dgvDsCTTinhTien.Columns(16).Visible = False
            For i As Integer = 0 To dgvDsCTTinhTien.Rows.Count - 1
                dgvDsCTTinhTien.Rows(i).Cells(0).Value = i + 1
                dgvDsCTTinhTien.Rows(i).Cells("cttt_dongiav").Value = Format(dgvDsCTTinhTien.Rows(i).Cells("cttt_dongia").Value, "#,###.##")
                dgvDsCTTinhTien.Rows(i).Cells("cttt_soluongbinhquanv").Value = Format(dgvDsCTTinhTien.Rows(i).Cells("cttt_soluongbinhquan").Value, "#,###.##")
                dgvDsCTTinhTien.Rows(i).Cells("cttt_thanhtienv").Value = Format(dgvDsCTTinhTien.Rows(i).Cells("cttt_thanhtien").Value, "#,###.##")
            Next
        ElseIf dgvDsCTTinhTien.Columns.Count = 17 Then
            dgvDsCTTinhTien.RowHeadersVisible = False
            dgvDsCTTinhTien.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTTinhTien.ReadOnly = True
            dgvDsCTTinhTien.Columns(0).HeaderText = "STT"
            dgvDsCTTinhTien.Columns(0).Width = 60
            dgvDsCTTinhTien.Columns("mh_ten").HeaderText = "Tên mặt hàng"
            dgvDsCTTinhTien.Columns("mh_ten").Width = 175
            dgvDsCTTinhTien.Columns("mh_khoiluong").HeaderText = "Khối lượng"
            dgvDsCTTinhTien.Columns("mh_khoiluong").Width = 65
            dgvDsCTTinhTien.Columns("mh_thetich").HeaderText = "Thể tích"
            dgvDsCTTinhTien.Columns("mh_thetich").Width = 65
            dgvDsCTTinhTien.Columns("pttt_ten").HeaderText = "Phương thức tính tiền"
            dgvDsCTTinhTien.Columns("pttt_ten").Width = 165
            dgvDsCTTinhTien.Columns("cttt_dongiav").HeaderText = "Đơn giá"
            dgvDsCTTinhTien.Columns("cttt_dongiav").Width = 75
            dgvDsCTTinhTien.Columns("cttt_soluongbinhquanv").HeaderText = "Số lượng tồn kho bình quân"
            dgvDsCTTinhTien.Columns("cttt_soluongbinhquanv").Width = 85
            dgvDsCTTinhTien.Columns("cttt_thanhtienv").HeaderText = "Thành tiền"
            dgvDsCTTinhTien.Columns("cttt_thanhtienv").Width = 85
            dgvDsCTTinhTien.Columns(8).Visible = False
            dgvDsCTTinhTien.Columns(9).Visible = False
            dgvDsCTTinhTien.Columns(10).Visible = False
            dgvDsCTTinhTien.Columns(11).Visible = False
            dgvDsCTTinhTien.Columns(12).Visible = False
            dgvDsCTTinhTien.Columns(13).Visible = False
            dgvDsCTTinhTien.Columns(14).Visible = False
            dgvDsCTTinhTien.Columns(15).Visible = False
            dgvDsCTTinhTien.Columns(16).Visible = False
            For i As Integer = 0 To dgvDsCTTinhTien.Rows.Count - 1
                dgvDsCTTinhTien.Rows(i).Cells(0).Value = i + 1
                dgvDsCTTinhTien.Rows(i).Cells("cttt_dongiav").Value = Format(dgvDsCTTinhTien.Rows(i).Cells("cttt_dongia").Value, "#,###.##")
                dgvDsCTTinhTien.Rows(i).Cells("cttt_soluongbinhquanv").Value = Format(dgvDsCTTinhTien.Rows(i).Cells("cttt_soluongbinhquan").Value, "#,###.##")
                dgvDsCTTinhTien.Rows(i).Cells("cttt_thanhtienv").Value = Format(dgvDsCTTinhTien.Rows(i).Cells("cttt_thanhtien").Value, "#,###.##")
            Next
        End If
    End Sub


End Class