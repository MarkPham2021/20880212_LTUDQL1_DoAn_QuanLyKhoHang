Public Class Frm_PhieuNhapHang_Action
    Public LoaiHanhDong As Integer
    Public MaPhieuNhapHang As Integer
    Dim isClosed As Boolean = True
    Dim DsPhieuNhapHang, DsCtNhapHang, DsKho, DsMatHang, DsHopDong As DataTable
    Dim MaCTNhapHangTam As Integer = 0
    Dim KhoiLuongChiemDung As Double = 0
    Dim TheTichChiemDung As Double = 0
    Dim KhoiLuongKhaDung As Double = 0
    Dim TheTichKhaDung As Double = 0
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu
    Dim madonvi = My.MyApplication.NguoiDung.Item("nd_madonvi")
    Private Sub Frm_PhieuNhapHang_Action_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuDgvDsHopDong()
        DinhdangdgvDSHopDong()
        TaiDuLieuDsPhieuNhapHang()
        TaiDuLieuDsCTNhapHang()
        TaiDuLieuCmbKhoHang()

        txb_mataikhoan.Text = My.MyApplication.NguoiDung.Item("nd_ma")
        txb_manhanvien.Text = My.MyApplication.NguoiDung.Item("nd_manhanvien")
        txb_tennhanvien.Text = My.MyApplication.NguoiDung.Item("nd_hoten")
        If LoaiHanhDong = 1 Then
            lbl_tieudeform.Text = "Tạo mới Phiếu Nhập hàng"
            btn_luu.Text = "Lưu Dữ liệu"
            btn_luu.BackColor = Color.DarkGreen
            btn_luu.ForeColor = Color.FloralWhite
            TaiCauTrucDsCTNhapHang()
            DinhdangdgvDsCTNhapHang()
        ElseIf LoaiHanhDong = 2 Then
            lbl_tieudeform.Text = "Thay đổi Nội dung Phiếu Nhập hàng"
            btn_luu.Text = "Lưu Dữ liệu"
            btn_luu.BackColor = Color.DarkBlue
            btn_luu.ForeColor = Color.FloralWhite
            LayThongTinPhieuNhapHang(MaPhieuNhapHang)
            TaiDuLieudgvDsMatHangTheoHopDong(Integer.Parse(txb_mahopdong.Text))
        ElseIf LoaiHanhDong = 3 Then
            lbl_tieudeform.Text = "Xóa Phiếu Nhập hàng"
            btn_luu.Text = "Xóa Phiếu Nhập hàng"
            btn_luu.BackColor = Color.Red
            btn_luu.ForeColor = Color.Yellow
            LayThongTinPhieuNhapHang(MaPhieuNhapHang)
            btn_themctnh.Visible = False
            btn_xoactnh.Visible = False
            dgvDsHopDong.Visible = False
            dgvDsMatHang.Visible = False
        End If
    End Sub
    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub
    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        'Tạo mới phiếu nhập hàng
        If LoaiHanhDong = 1 Then
            Dim pnh = DsPhieuNhapHang.NewRow
            Dim hople As Boolean
            hople = KhoiLuongKhaDung >= KhoiLuongChiemDung And TheTichKhaDung >= TheTichChiemDung
            If hople Then
                pnh.Item("pnh_mahopdong") = Integer.Parse(txb_mahopdong.Text)
                pnh.Item("pnh_ngaynhaphang") = dtp_ngaynhaphang.Value
                pnh.Item("pnh_makhohang") = Cmb_tenkhohang.SelectedValue
                pnh.Item("pnh_soluongmathang") = Integer.Parse(txb_tongsomathang.Text)
                pnh.Item("pnh_manguoidung") = Integer.Parse(txb_mataikhoan.Text)
                pnh.Item("pnh_daxoa") = 0
                pnh.Item("pnh_thoidiemcapnhat") = DateTime.Now
                DsPhieuNhapHang.Rows.Add(pnh)
                Dim cautruyvanghidulieuPhieuNhapHang As String = "select pnh_ma, pnh_mahopdong, pnh_makhohang,pnh_ngaynhaphang, pnh_soluongmathang,pnh_manguoidung,
                            pnh_daxoa, pnh_thoidiemcapnhat from PhieuNhapHang"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieuPhieuNhapHang, DsPhieuNhapHang)
                Dim cautruyvanghidulieutudoCTNhapHang = "select ctnh_ma, ctnh_maphieunhaphang, ctnh_mamathang,ctnh_soluong,
                                                            ctnh_daxoa, ctnh_thoidiemcapnhat 
                                                         from CTNhapHang"

                For Each ctnh As DataRow In DsCtNhapHang.Rows
                    If ctnh.Item("ctnh_maphieunhaphang") = -1 Then
                        ctnh.Item("ctnh_maphieunhaphang") = pnh.Item("pnh_ma")
                    End If
                Next
                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieutudoCTNhapHang, DsCtNhapHang)
                Me.Close()
            Else
                MessageBox.Show("Sức chứa còn lại của kho hàng không đủ tiếp nhận hàng hóa nhập kho của phiếu nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'Thay đổi nội dung phiếu nhập hàng
        ElseIf LoaiHanhDong = 2 Then

            Dim pnhs = DsPhieuNhapHang.Select("pnh_ma = " + MaPhieuNhapHang.ToString)
            Dim hople As Boolean
            hople = KhoiLuongKhaDung >= KhoiLuongChiemDung And TheTichKhaDung >= TheTichChiemDung
            If hople Then
                pnhs(0).Item("pnh_mahopdong") = Integer.Parse(txb_mahopdong.Text)
                pnhs(0).Item("pnh_ngaynhaphang") = dtp_ngaynhaphang.Value
                pnhs(0).Item("pnh_makhohang") = Cmb_tenkhohang.SelectedValue
                pnhs(0).Item("pnh_soluongmathang") = Integer.Parse(txb_tongsomathang.Text)
                pnhs(0).Item("pnh_manguoidung") = Integer.Parse(txb_mataikhoan.Text)
                pnhs(0).Item("pnh_thoidiemcapnhat") = DateTime.Now

                Dim cautruyvanghidulieuPhieuNhapHang As String = "select pnh_ma, pnh_mahopdong, pnh_makhohang,pnh_ngaynhaphang, pnh_soluongmathang,pnh_manguoidung,
                            pnh_daxoa, pnh_thoidiemcapnhat from PhieuNhapHang"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieuPhieuNhapHang, DsPhieuNhapHang)
                Dim cautruyvanghidulieutudoCTNhapHang = "select ctnh_ma, ctnh_maphieunhaphang, ctnh_mamathang,ctnh_soluong,
                                                            ctnh_daxoa, ctnh_thoidiemcapnhat 
                                                         from CTNhapHang"

                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieutudoCTNhapHang, DsCtNhapHang)
                Me.Close()
            Else
                MessageBox.Show("Sức chứa còn lại của kho hàng không đủ tiếp nhận hàng hóa nhập kho của phiếu nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'Xóa phiếu nhâp hàng
        ElseIf LoaiHanhDong = 3 Then
            Dim xacnhan As DialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu nhập hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If xacnhan = DialogResult.Yes Then
                Dim pnhs = DsPhieuNhapHang.Select("pnh_ma = " + MaPhieuNhapHang.ToString)
                pnhs(0).Item("pnh_daxoa") = 1
                pnhs(0).Item("pnh_thoidiemcapnhat") = DateTime.Now
                For Each ctnh As DataRow In DsCtNhapHang.Rows
                    If ctnh.Item("ctnh_maphieunhaphang") = MaPhieuNhapHang Then
                        ctnh.Item("ctnh_daxoa") = 1
                    End If
                Next
                Dim cautruyvanghidulieuPhieuNhapHang As String = "select pnh_ma, pnh_mahopdong, pnh_makhohang,pnh_ngaynhaphang, pnh_soluongmathang,pnh_manguoidung,
                            pnh_daxoa, pnh_thoidiemcapnhat from PhieuNhapHang"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieuPhieuNhapHang, DsPhieuNhapHang)
                Dim cautruyvanghidulieutudoCTNhapHang = "select ctnh_ma, ctnh_maphieunhaphang, ctnh_mamathang,ctnh_soluong,
                                                            ctnh_daxoa, ctnh_thoidiemcapnhat 
                                                         from CTNhapHang"

                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieutudoCTNhapHang, DsCtNhapHang)
                btn_themctnh.Visible = True
                btn_xoactnh.Visible = True
                dgvDsHopDong.Visible = True
                dgvDsMatHang.Visible = True
                Me.Close()
            Else
                btn_themctnh.Visible = True
                btn_xoactnh.Visible = True
                dgvDsHopDong.Visible = True
                dgvDsMatHang.Visible = True
                Me.Close()

            End If
        End If
    End Sub
    Private Sub txb_timhopdong_TextChanged(sender As Object, e As EventArgs) Handles txb_timhopdong.TextChanged
        If txb_timhopdong.Text.Trim <> "" Then
            Dim ndt = txb_timhopdong.Text.ToLower
            Dim dskq =
                From hd In DsHopDong
                Where hd.Item("hd_ma").ToString.Contains(ndt) Or hd.Item("hd_makhachhang").ToString.Contains(ndt) Or
                hd.Item("kh_ten").ToString.ToLower.Contains(ndt) Or hd.Item("kh_diachi").ToString.ToLower.Contains(ndt) Or
                hd.Item("kh_dienthoai").ToString.ToLower.Contains(ndt)
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
        Dim hopdongv = dgvDsHopDong.CurrentRow
        If Not hopdongv.IsNewRow Then
            txb_mahopdong.Text = hopdongv.Cells("hd_ma").Value
            txb_tenkhachhang.Text = hopdongv.Cells("kh_ten").Value
            txb_loaigtpl.Text = hopdongv.Cells("gt_ten").Value
            txb_gtplso.Text = hopdongv.Cells("kh_gtplso").Value
            txb_diachi.Text = hopdongv.Cells("kh_diachi").Value
            txb_dienthoai.Text = hopdongv.Cells("kh_dienthoai").Value
            txb_email.Text = hopdongv.Cells("kh_email").Value
            dtp_ngayhopdong.Value = hopdongv.Cells("hd_ngayhopdong").Value
            dtp_ngaybatdau.Value = hopdongv.Cells("hd_ngaybatdau").Value
            dtp_ngayhethan.Value = hopdongv.Cells("hd_ngayhethan").Value
            chb_cohieuluc.Checked = hopdongv.Cells("hd_cohieuluc").Value
            Dim mahopdong = hopdongv.Cells("hd_ma").Value
            TaiDuLieudgvDsMatHangTheoHopDong(mahopdong)
        End If
    End Sub
    Private Sub txb_timmathang_TextChanged(sender As Object, e As EventArgs) Handles txb_timmathang.TextChanged
        If txb_timmathang.Text.Trim <> "" Then
            Dim ndt = txb_timmathang.Text.ToLower
            Dim dskq =
            From mh In DsMatHang
            Where mh.Item(1).ToString.ToLower.Contains(ndt) Or mh.Item(2).ToString.ToLower.Contains(ndt)
            Select mh
            Dim dtdskq As DataTable = New DataTable
            If dskq.Count > 0 Then
                dtdskq = dskq.CopyToDataTable()
            End If
            dgvDsMatHang.DataSource = dtdskq
        Else
            dgvDsMatHang.DataSource = DsMatHang
        End If
        DinhdangdgvDsMatHang()
    End Sub

    Private Sub dgvDsMatHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDsMatHang.CellClick
        Dim mathangv = dgvDsMatHang.CurrentRow
        If mathangv.IsNewRow = False Then
            txb_mamathang.Text = mathangv.Cells("cthd_mamathang").Value
            txb_tenmathang.Text = mathangv.Cells("mh_ten").Value
            txb_tenloaihang.Text = mathangv.Cells("lh_ten").Value
            txb_khoiluong.Text = mathangv.Cells("mh_khoiluong").Value
            txb_thetich.Text = mathangv.Cells("mh_thetich").Value
        End If
    End Sub
    Private Sub Cmb_tenkhohang_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_tenkhohang.SelectionChangeCommitted
        Dim makhohang As Integer = Cmb_tenkhohang.SelectedItem("kho_ma")
        Dim ngay As String = Format(dtp_ngaynhaphang.Value, "yyyy-MM-dd")

        Dim bus_khohang As Bus_KhoHang = New Bus_KhoHang
        Dim khoiluongsudungtrongngay = bus_khohang.TinhCongSuatKhoiLuongDaSuDungTrongNgay(makhohang, ngay)
        Dim thetichsudungtrongngay = bus_khohang.TinhCongSuatTheTichDaSuDungTrongNgay(makhohang, ngay)
        Dim khohangs As DataRow() = DsKho.Select($"kho_ma = {makhohang}")
        KhoiLuongKhaDung = (khohangs(0).Item("kho_congsuatkhoiluong") - khohangs(0).Item("kho_khoiluongdasudung") - khoiluongsudungtrongngay)
        TheTichKhaDung = (khohangs(0).Item("kho_congsuatthetich") - khohangs(0).Item("kho_thetichdasudung") - thetichsudungtrongngay)
        txb_khoiluongkhadung.Text = FormatNumber(KhoiLuongKhaDung, 0, TriState.True, TriState.True, TriState.True)
        txb_thetichkhadung.Text = FormatNumber(TheTichKhaDung, 0, TriState.True, TriState.True, TriState.True)
        If KhoiLuongChiemDung > KhoiLuongKhaDung Then
            txb_tongkhoiluong.ForeColor = Color.Red
            txb_tongkhoiluong.BackColor = Color.LightYellow
        Else
            txb_tongkhoiluong.ForeColor = Color.DarkBlue
            txb_tongkhoiluong.BackColor = Color.WhiteSmoke
        End If
        If TheTichChiemDung > TheTichKhaDung Then
            txb_tongthetich.ForeColor = Color.Red
            txb_tongthetich.BackColor = Color.LightYellow
        Else
            txb_tongthetich.ForeColor = Color.DarkBlue
            txb_tongthetich.BackColor = Color.WhiteSmoke
        End If
    End Sub
    Private Sub btn_themcthd_Click(sender As Object, e As EventArgs) Handles btn_themctnh.Click
        KhoiLuongChiemDung = 0
        TheTichChiemDung = 0
        If txb_mamathang.Text.Trim <> "" And txb_soluong.Text.Trim <> "" Then
            MaCTNhapHangTam -= 1
            Dim ctnh As DataRow = DsCtNhapHang.NewRow
            ctnh.Item("ctnh_ma") = MaCTNhapHangTam
            ctnh.Item("ctnh_maphieunhaphang") = MaPhieuNhapHang
            ctnh.Item("ctnh_mamathang") = Integer.Parse(txb_mamathang.Text)
            ctnh.Item("mh_ten") = txb_tenmathang.Text
            ctnh.Item("ctnh_soluong") = Integer.Parse(txb_soluong.Text.Trim)
            ctnh.Item("mh_khoiluong") = Double.Parse(txb_khoiluong.Text.Trim)
            ctnh.Item("mh_thetich") = Double.Parse(txb_thetich.Text.Trim)
            ctnh.Item("ctnh_daxoa") = 0
            ctnh.Item("ctnh_thoidiemcapnhat") = DateTime.Now
            DsCtNhapHang.Rows.Add(ctnh)
            dgvDsCTNhapHang.DataSource = LayDsCTNhapHangTheoMaPNH(MaPhieuNhapHang)
            DinhdangdgvDsCTNhapHang()
            txb_tongsomathang.Text = dgvDsCTNhapHang.Rows.Count
            For i As Integer = 0 To dgvDsCTNhapHang.Rows.Count - 1
                KhoiLuongChiemDung += dgvDsCTNhapHang.Rows(i).Cells("khoiluongchiemdung").Value
                TheTichChiemDung += dgvDsCTNhapHang.Rows(i).Cells("thetichchiemdung").Value
            Next
            If KhoiLuongChiemDung > KhoiLuongKhaDung Then
                txb_tongkhoiluong.ForeColor = Color.Red
                txb_tongkhoiluong.BackColor = Color.LightYellow
            Else
                txb_tongkhoiluong.ForeColor = Color.DarkBlue
                txb_tongkhoiluong.BackColor = Color.WhiteSmoke
            End If
            If TheTichChiemDung > TheTichKhaDung Then
                txb_tongthetich.ForeColor = Color.Red
                txb_tongthetich.BackColor = Color.LightYellow
            Else
                txb_tongthetich.ForeColor = Color.DarkBlue
                txb_tongthetich.BackColor = Color.WhiteSmoke
            End If
            txb_tongkhoiluong.Text = Format(KhoiLuongChiemDung, "#,###.00")
            txb_tongthetich.Text = Format(TheTichChiemDung, "#,##0.00")
        End If
    End Sub
    Private Sub btn_xoacthd_Click(sender As Object, e As EventArgs) Handles btn_xoactnh.Click
        KhoiLuongChiemDung = 0
        TheTichChiemDung = 0
        Dim ctnhv = dgvDsCTNhapHang.CurrentRow
        If IsNothing(ctnhv) = False Then
            Dim ctnhs = DsCtNhapHang.Select("ctnh_ma = " + ctnhv.Cells("ctnh_ma").Value.ToString)
            If ctnhs(0).Item("ctnh_ma") < 0 Then
                DsCtNhapHang.Rows.Remove(ctnhs(0))
            Else
                ctnhs(0).Item("ctnh_daxoa") = 1
            End If
            If LayDsCTNhapHangTheoMaPNH(MaPhieuNhapHang).Rows.Count > 0 Then
                dgvDsCTNhapHang.DataSource = LayDsCTNhapHangTheoMaPNH(MaPhieuNhapHang)

            Else
                TaiCauTrucDsCTNhapHang()

            End If
            DinhdangdgvDsCTNhapHang()
            txb_tongsomathang.Text = dgvDsCTNhapHang.Rows.Count
            For i As Integer = 0 To dgvDsCTNhapHang.Rows.Count - 1
                KhoiLuongChiemDung += dgvDsCTNhapHang.Rows(i).Cells("khoiluongchiemdung").Value
                TheTichChiemDung += dgvDsCTNhapHang.Rows(i).Cells("thetichchiemdung").Value
            Next
            If KhoiLuongChiemDung > KhoiLuongKhaDung Then
                txb_tongkhoiluong.ForeColor = Color.Red
                txb_tongkhoiluong.BackColor = Color.LightYellow
            Else
                txb_tongkhoiluong.ForeColor = Color.DarkBlue
                txb_tongkhoiluong.BackColor = Color.WhiteSmoke
            End If
            If TheTichChiemDung > TheTichKhaDung Then
                txb_tongthetich.ForeColor = Color.Red
                txb_tongthetich.BackColor = Color.LightYellow
            Else
                txb_tongthetich.ForeColor = Color.DarkBlue
                txb_tongthetich.BackColor = Color.WhiteSmoke
            End If
            txb_tongkhoiluong.Text = Format(KhoiLuongChiemDung, "#,###.#0")
            txb_tongthetich.Text = Format(TheTichChiemDung, "#,##0.#0")
        End If
    End Sub
    Sub TaiDuLieuDsPhieuNhapHang()
        Dim cautruyvanphieunhaphang As String
        cautruyvanphieunhaphang = "select pnh_ma, pnh_mahopdong, pnh_makhohang, kho_ten,pnh_ngaynhaphang, pnh_soluongmathang,pnh_manguoidung,
                             hd_makhachhang, kh_ten, gt_ten, kh_gtplso,hd_ngayhopdong,hd_ngaybatdau,hd_ngayhethan,
                             kh_diachi, kh_dienthoai, kh_email, hd_cohieuluc, nd_hoten, nd_manhanvien,pnh_daxoa, pnh_thoidiemcapnhat
                            from HopDong join PhieuNhapHang on hd_ma = pnh_Mahopdong
                            join KhoHang on pnh_makhohang = kho_ma
                            join NguoiDung on pnh_manguoidung = nd_ma
                            join KhachHang on hd_makhachhang = kh_ma 
                            join LoaiGiayToPhapLy on gt_ma= kh_maloaigtpl 
                            where pnh_daxoa = 0"
        DsPhieuNhapHang = xl_dulieu.DocDuLieu(cautruyvanphieunhaphang)
    End Sub
    Sub LayThongTinPhieuNhapHang(ByVal maphieunhaphang)
        Dim pnhs = DsPhieuNhapHang.Select("pnh_ma = " + maphieunhaphang.ToString)
        If pnhs.Count > 0 Then
            txb_ma.Text = pnhs(0).Item("pnh_ma")
            txb_mahopdong.Text = pnhs(0).Item("pnh_mahopdong")
            txb_tenkhachhang.Text = pnhs(0).Item("kh_ten")
            txb_loaigtpl.Text = pnhs(0).Item("gt_ten")
            txb_gtplso.Text = pnhs(0).Item("kh_gtplso")
            txb_diachi.Text = pnhs(0).Item("kh_diachi")
            txb_dienthoai.Text = pnhs(0).Item("kh_dienthoai")
            txb_email.Text = pnhs(0).Item("kh_email")
            dtp_ngayhopdong.Value = pnhs(0).Item("hd_ngayhopdong")
            dtp_ngaybatdau.Value = pnhs(0).Item("hd_ngaybatdau")
            dtp_ngayhethan.Value = pnhs(0).Item("hd_ngayhethan")
            chb_cohieuluc.Checked = pnhs(0).Item("hd_cohieuluc")
            dtp_ngaynhaphang.Value = pnhs(0).Item("pnh_ngaynhaphang")
            Cmb_tenkhohang.Text = pnhs(0).Item("kho_ten")
            txb_mataikhoan.Text = My.MyApplication.NguoiDung.Item("nd_ma")
            txb_manhanvien.Text = My.MyApplication.NguoiDung.Item("nd_manhanvien")
            txb_tennhanvien.Text = My.MyApplication.NguoiDung.Item("nd_hoten")
            txb_tongsomathang.Text = pnhs(0).Item("pnh_soluongmathang")
            If LayDsCTNhapHangTheoMaPNH(maphieunhaphang).Rows.Count > 0 Then
                dgvDsCTNhapHang.DataSource = LayDsCTNhapHangTheoMaPNH(maphieunhaphang)
            Else
                TaiCauTrucDsCTNhapHang()
            End If
            DinhdangdgvDsCTNhapHang()
            KhoiLuongChiemDung = 0
            TheTichChiemDung = 0
            For i As Integer = 0 To dgvDsCTNhapHang.Rows.Count - 1
                KhoiLuongChiemDung += dgvDsCTNhapHang.Rows(i).Cells("khoiluongchiemdung").Value
                TheTichChiemDung += dgvDsCTNhapHang.Rows(i).Cells("thetichchiemdung").Value
            Next
            txb_tongkhoiluong.Text = Format(KhoiLuongChiemDung, "#,###.00")
            txb_tongthetich.Text = Format(TheTichChiemDung, "#,##0.00")
        End If
    End Sub
    Sub TaiDuLieuDsCTNhapHang()
        Dim cautruyvanctnh As String
        cautruyvanctnh = "select ctnh_ma, ctnh_maphieunhaphang, ctnh_mamathang,mh_ten, ctnh_soluong,
                            ctnh_daxoa,ctnh_thoidiemcapnhat, mh_khoiluong, mh_thetich
                            from CTNhapHang join MatHang on ctnh_mamathang = mh_ma
                            where ctnh_daxoa = 0"
        DsCtNhapHang = xl_dulieu.DocDuLieu(cautruyvanctnh)
    End Sub
    Sub TaiCauTrucDsCTNhapHang()
        Dim cautruyvancautrucCTNhapHang = "select ctnh_ma, ctnh_maphieunhaphang, ctnh_mamathang,mh_ten, ctnh_soluong,
                                                            ctnh_daxoa, ctnh_thoidiemcapnhat, mh_thetich, mh_khoiluong
                                                         from CTNhapHang join MatHang on ctnh_mamathang = mh_ma
                                                            where ctnh_daxoa=0"
        Dim cautrucDsCTNhapHang = xl_dulieu.DocCauTruc(cautruyvancautrucCTNhapHang)
        dgvDsCTNhapHang.DataSource = cautrucDsCTNhapHang
    End Sub
    Sub TaiDuLieuCmbKhoHang()
        TaiDuLieuKhoHang()
        Cmb_tenkhohang.DataSource = DsKho
        Cmb_tenkhohang.DisplayMember = "kho_ten"
        Cmb_tenkhohang.ValueMember = "kho_ma"
    End Sub
    Sub DinhdangdgvDsCTNhapHang()
        If dgvDsCTNhapHang.Columns.Count = 9 Then
            Dim stt As New DataGridViewTextBoxColumn
            Dim khoiluongchiemdung As New DataGridViewTextBoxColumn
            Dim thetichchiemdung As New DataGridViewTextBoxColumn

            dgvDsCTNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTNhapHang.RowHeadersVisible = False

            dgvDsCTNhapHang.Columns.Insert(0, stt)
            dgvDsCTNhapHang.Columns(0).Name = "stt"
            dgvDsCTNhapHang.Columns.Insert(6, khoiluongchiemdung)
            dgvDsCTNhapHang.Columns(6).Name = "khoiluongchiemdung"
            dgvDsCTNhapHang.Columns.Insert(7, thetichchiemdung)
            dgvDsCTNhapHang.Columns(7).Name = "thetichchiemdung"
            dgvDsCTNhapHang.Columns("stt").HeaderText = "STT"
            dgvDsCTNhapHang.Columns("stt").Width = 50
            dgvDsCTNhapHang.Columns("mh_ten").HeaderText = "Tên mặt hàng"
            dgvDsCTNhapHang.Columns("mh_ten").AutoSizeMode = False
            dgvDsCTNhapHang.Columns("mh_ten").Width = 160
            dgvDsCTNhapHang.Columns("ctnh_soluong").HeaderText = "Số lượng"
            dgvDsCTNhapHang.Columns("ctnh_soluong").AutoSizeMode = False
            dgvDsCTNhapHang.Columns("ctnh_soluong").Width = 70
            dgvDsCTNhapHang.Columns("khoiluongchiemdung").HeaderText = "Khối lượng chiếm dụng"
            dgvDsCTNhapHang.Columns("khoiluongchiemdung").AutoSizeMode = False
            dgvDsCTNhapHang.Columns("khoiluongchiemdung").Width = 80
            dgvDsCTNhapHang.Columns("thetichchiemdung").HeaderText = "Thể tích chiếm dụng"
            dgvDsCTNhapHang.Columns("thetichchiemdung").AutoSizeMode = False
            dgvDsCTNhapHang.Columns("thetichchiemdung").Width = 80
            dgvDsCTNhapHang.Columns("ctnh_ma").Visible = False
            dgvDsCTNhapHang.Columns("ctnh_maphieunhaphang").Visible = False
            dgvDsCTNhapHang.Columns("ctnh_mamathang").Visible = False
            dgvDsCTNhapHang.Columns("ctnh_daxoa").Visible = False
            dgvDsCTNhapHang.Columns("ctnh_thoidiemcapnhat").Visible = False
            dgvDsCTNhapHang.Columns("mh_khoiluong").Visible = False
            dgvDsCTNhapHang.Columns("mh_thetich").Visible = False

            For i As Integer = 0 To dgvDsCTNhapHang.Rows.Count - 1
                dgvDsCTNhapHang.Rows(i).Cells(0).Value = i + 1
                dgvDsCTNhapHang.Rows(i).Cells("khoiluongchiemdung").Value = dgvDsCTNhapHang.Rows(i).Cells("mh_khoiluong").Value * dgvDsCTNhapHang.Rows(i).Cells("ctnh_soluong").Value

                dgvDsCTNhapHang.Rows(i).Cells("thetichchiemdung").Value = dgvDsCTNhapHang.Rows(i).Cells("mh_thetich").Value * dgvDsCTNhapHang.Rows(i).Cells("ctnh_soluong").Value

            Next
        ElseIf dgvDsCTNhapHang.Columns.Count = 12 Then
            dgvDsCTNhapHang.Columns("stt").HeaderText = "STT"
            dgvDsCTNhapHang.Columns("stt").Width = 50
            dgvDsCTNhapHang.Columns("mh_ten").HeaderText = "Tên mặt hàng"
            dgvDsCTNhapHang.Columns("mh_ten").AutoSizeMode = False
            dgvDsCTNhapHang.Columns("mh_ten").Width = 160
            dgvDsCTNhapHang.Columns("ctnh_soluong").HeaderText = "Số lượng"
            dgvDsCTNhapHang.Columns("ctnh_soluong").AutoSizeMode = False
            dgvDsCTNhapHang.Columns("ctnh_soluong").Width = 70
            dgvDsCTNhapHang.Columns("khoiluongchiemdung").HeaderText = "Khối lượng chiếm dụng"
            dgvDsCTNhapHang.Columns("khoiluongchiemdung").AutoSizeMode = False
            dgvDsCTNhapHang.Columns("khoiluongchiemdung").Width = 80
            dgvDsCTNhapHang.Columns("thetichchiemdung").HeaderText = "Thể tích chiếm dụng"
            dgvDsCTNhapHang.Columns("thetichchiemdung").AutoSizeMode = False
            dgvDsCTNhapHang.Columns("thetichchiemdung").Width = 80
            dgvDsCTNhapHang.Columns("ctnh_ma").Visible = False
            dgvDsCTNhapHang.Columns("ctnh_maphieunhaphang").Visible = False
            dgvDsCTNhapHang.Columns("ctnh_mamathang").Visible = False
            dgvDsCTNhapHang.Columns("ctnh_daxoa").Visible = False
            dgvDsCTNhapHang.Columns("ctnh_thoidiemcapnhat").Visible = False
            dgvDsCTNhapHang.Columns("mh_khoiluong").Visible = False
            dgvDsCTNhapHang.Columns("mh_thetich").Visible = False
            For i As Integer = 0 To dgvDsCTNhapHang.Rows.Count - 1
                dgvDsCTNhapHang.Rows(i).Cells(0).Value = i + 1
                dgvDsCTNhapHang.Rows(i).Cells("khoiluongchiemdung").Value = dgvDsCTNhapHang.Rows(i).Cells("mh_khoiluong").Value * dgvDsCTNhapHang.Rows(i).Cells("ctnh_soluong").Value

                dgvDsCTNhapHang.Rows(i).Cells("thetichchiemdung").Value = dgvDsCTNhapHang.Rows(i).Cells("mh_thetich").Value * dgvDsCTNhapHang.Rows(i).Cells("ctnh_soluong").Value

            Next
        End If
    End Sub
    Sub TaiDuLieudgvDsMatHangTheoHopDong(ByVal mahopdong As Integer)
        Dim cautruyvanctmhhd As String
        cautruyvanctmhhd = $"select cthd_mamathang, mh_ten, mh_khoiluong, mh_thetich, lh_ten
                            from MatHang join CTHopDong on mh_ma = cthd_mamathang 
                            join LoaiHang on mh_maloaihang = lh_ma
                            where cthd_daxoa = 0 and cthd_mahopdong = {mahopdong.ToString}"
        DsMatHang = xl_dulieu.DocDuLieu(cautruyvanctmhhd)
        dgvDsMatHang.DataSource = DsMatHang

        dgvDsMatHang.RowHeadersVisible = False
        dgvDsMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDsMatHang.ReadOnly = True
        dgvDsMatHang.Columns("cthd_mamathang").Visible = False
        dgvDsMatHang.Columns("mh_khoiluong").HeaderText = "Khối lượng"
        dgvDsMatHang.Columns("mh_khoiluong").Width = 70
        dgvDsMatHang.Columns("mh_thetich").HeaderText = "Thể tích"
        dgvDsMatHang.Columns("mh_thetich").Width = 70
        dgvDsMatHang.Columns("mh_ten").HeaderText = "Tên mặt hàng"
        dgvDsMatHang.Columns("mh_ten").Width = 150
        dgvDsMatHang.Columns("lh_ten").HeaderText = "Loại hàng"
        dgvDsMatHang.Columns("lh_ten").Width = 150
    End Sub

    Private Sub Frm_PhieuNhapHang_Action_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosed = False Then
            Dim dialogResult As DialogResult
            dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình? Dữ liệu đang nhập chưa lưu trữ sẽ bị mất khi đóng màn hình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                e.Cancel = True
                isClosed = True
            Else
                btn_themctnh.Visible = True
                btn_xoactnh.Visible = True
                dgvDsHopDong.Visible = True
                dgvDsMatHang.Visible = True
            End If
        End If
    End Sub
    Sub DinhdangdgvDsMatHang()
        If dgvDsMatHang.Columns.Count > 4 Then
            dgvDsMatHang.RowHeadersVisible = False
            dgvDsMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsMatHang.ReadOnly = True
            dgvDsMatHang.Columns("cthd_mamathang").Visible = False
            dgvDsMatHang.Columns("mh_khoiluong").HeaderText = "Khối lượng"
            dgvDsMatHang.Columns("mh_khoiluong").Width = 70
            dgvDsMatHang.Columns("mh_thetich").HeaderText = "Thể tích"
            dgvDsMatHang.Columns("mh_thetich").Width = 70
            dgvDsMatHang.Columns("mh_ten").HeaderText = "Tên mặt hàng"
            dgvDsMatHang.Columns("mh_ten").Width = 170
            dgvDsMatHang.Columns("lh_ten").HeaderText = "Loại hàng"
            dgvDsMatHang.Columns("lh_ten").Width = 150
        End If
    End Sub



    Sub TaiDuLieuDgvDsHopDong()
        Dim cautruyvanhopdong As String
        cautruyvanhopdong = "select h.hd_ma, k.kh_ten, l.gt_ten, k.kh_gtplso,h.hd_ngayhopdong,h.hd_ngaybatdau,h.hd_ngayhethan,h.hd_soluongmathang,
                             k.kh_diachi, k.kh_dienthoai, k.kh_email, h.hd_cohieuluc, h.hd_daxoa, h.hd_thoidiemcapnhat, hd_makhachhang
                            from HopDong h join KhachHang k on h.hd_makhachhang = k.kh_ma join LoaiGiayToPhapLy l on l.gt_ma= k.kh_maloaigtpl
                            where h.hd_daxoa = 0 and h.hd_cohieuluc =1"
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
            dgvDsHopDong.Columns(12).Visible = False
            dgvDsHopDong.Columns(13).Visible = False
            dgvDsHopDong.Columns(14).Visible = False
        End If
    End Sub
    Sub TaiDuLieuKhoHang()
        Dim cautruyvankhohang As String = $"select kho_ma,kho_ten, kho_congsuatkhoiluong, kho_congsuatthetich,
                                            kho_khoiluongdasudung, kho_thetichdasudung from KhoHang Where kho_daxoa=0 and kho_thuocmadonvi = {madonvi}"
        DsKho = xl_dulieu.DocDuLieu(cautruyvankhohang)
    End Sub
    Protected Function LayDsCTNhapHangTheoMaPNH(ByVal maphieunhaphang As Integer) As DataTable
        Dim dtdskq As DataTable = New DataTable
        Dim dskq =
            From ctnh In DsCtNhapHang
            Where ctnh.Item("ctnh_maphieunhaphang") = maphieunhaphang And ctnh.Item("ctnh_daxoa") = 0
            Select ctnh
        If dskq.Count > 0 Then
            dtdskq = dskq.CopyToDataTable()
        End If
        Return dtdskq
    End Function
End Class