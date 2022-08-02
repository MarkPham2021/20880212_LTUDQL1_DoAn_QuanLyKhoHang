Public Class Frm_PhieuXuatHang_Action
    Public LoaiHanhDong As Integer
    Public MaPhieuXuatHang As Integer
    Dim isClosed As Boolean = True
    Dim DsPhieuXuatHang, DsCtXuatHang, DsKho, DsMatHang, DsHopDong As DataTable
    Dim MaCTXuatHangTam As Integer = 0
    Dim soluongtonkho, soluongxuat As Integer
    Dim xl_dulieu As XL_DuLieu = New XL_DuLieu
    Dim bus_khohang As Bus_KhoHang = New Bus_KhoHang
    Private Sub Frm_PhieuXuatHang_Action_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaiDuLieuDgvDsHopDong()
        DinhdangdgvDSHopDong()
        TaiDuLieuDsPhieuXuatHang()
        TaiDuLieuDsCTXuatHang()
        TaiDuLieuCmbKhoHang()

        txb_mataikhoan.Text = My.MyApplication.NguoiDung.Item("nd_ma")
        txb_manhanvien.Text = My.MyApplication.NguoiDung.Item("nd_manhanvien")
        txb_tennhanvien.Text = My.MyApplication.NguoiDung.Item("nd_hoten")
        If LoaiHanhDong = 1 Then
            lbl_tieudeform.Text = "Tạo mới Phiếu Xuất hàng"
            btn_luu.Text = "Lưu Dữ liệu"
            btn_luu.BackColor = Color.DarkGreen
            btn_luu.ForeColor = Color.FloralWhite
            TaiCauTrucDsCTXuatHang()
            DinhdangdgvDsCTXuatHang()
        ElseIf LoaiHanhDong = 2 Then
            lbl_tieudeform.Text = "Thay đổi Nội dung Phiếu Xuất hàng"
            btn_luu.Text = "Lưu Dữ liệu"
            btn_luu.BackColor = Color.DarkBlue
            btn_luu.ForeColor = Color.FloralWhite
            LayThongTinPhieuXuatHang(MaPhieuXuatHang)
            TaiDuLieudgvDsMatHangTheoHopDong(Integer.Parse(txb_mahopdong.Text))
        ElseIf LoaiHanhDong = 3 Then
            lbl_tieudeform.Text = "Xóa Phiếu Xuất hàng"
            btn_luu.Text = "Xóa Phiếu Xuất hàng"
            btn_luu.BackColor = Color.Red
            btn_luu.ForeColor = Color.Yellow
            LayThongTinPhieuXuatHang(MaPhieuXuatHang)
            btn_themctxh.Visible = False
            btn_xoactxh.Visible = False
            dgvDsHopDong.Visible = False
            dgvDsMatHang.Visible = False
        End If
    End Sub
    Private Sub btn_dong_Click(sender As Object, e As EventArgs) Handles btn_dong.Click
        isClosed = False
        Me.Close()
    End Sub
    Private Sub Frm_PhieuXuatHang_Action_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosed = False Then
            Dim dialogResult As DialogResult
            dialogResult = MessageBox.Show("Bạn thực sự muốn đóng màn hình? Dữ liệu đang nhập chưa lưu trữ sẽ bị mất khi đóng màn hình!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If dialogResult = DialogResult.No Then
                e.Cancel = True
                isClosed = True
            Else
                btn_themctxh.Visible = True
                btn_xoactxh.Visible = True
                dgvDsHopDong.Visible = True
                dgvDsMatHang.Visible = True
            End If
        End If
    End Sub
    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click

        If LoaiHanhDong = 1 Then
            Dim pxh = DsPhieuXuatHang.NewRow
            Dim hople As Boolean
            pxh.Item("pxh_mahopdong") = Integer.Parse(txb_mahopdong.Text)
            pxh.Item("pxh_ngayXuatHang") = dtp_ngayxuathang.Value
            pxh.Item("pxh_makhohang") = Cmb_tenkhohang.SelectedValue
            pxh.Item("pxh_manguoidung") = Integer.Parse(txb_mataikhoan.Text)
            pxh.Item("pxh_daxoa") = 0
            pxh.Item("pxh_thoidiemcapnhat") = DateTime.Now
            hople = (Integer.Parse(txb_tongsomathang.Text) = dgvDsCTXuatHang.Rows.Count)
            If hople Then
                pxh.Item("pxh_soluongmathang") = Integer.Parse(txb_tongsomathang.Text)
                DsPhieuXuatHang.Rows.Add(pxh)

                Dim cautruyvanghidulieuPhieuXuatHang As String = "select pxh_ma, pxh_mahopdong, pxh_makhohang,pxh_ngayXuatHang, pxh_soluongmathang,pxh_manguoidung,
                            pxh_daxoa, pxh_thoidiemcapnhat from PhieuXuatHang"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieuPhieuXuatHang, DsPhieuXuatHang)
                Dim cautruyvanghidulieutudoCTXuatHang = "select ctxh_ma, ctxh_maphieuXuatHang, ctxh_mamathang,ctxh_soluong,
                                                            ctxh_daxoa, ctxh_thoidiemcapnhat 
                                                         from CTXuatHang"

                For Each ctxh As DataRow In DsCtXuatHang.Rows
                    If ctxh.Item("ctxh_maphieuXuatHang") = -1 Then
                        ctxh.Item("ctxh_maphieuXuatHang") = pxh.Item("pxh_ma")
                    End If
                Next
                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieutudoCTXuatHang, DsCtXuatHang)
                Me.Close()
            Else
                MessageBox.Show("Chưa lưu được dữ liệu vì thông tin chi tiết xuất hàng chưa khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf LoaiHanhDong = 2 Then

            Dim pxhs = DsPhieuXuatHang.Select("pxh_ma = " + MaPhieuXuatHang.ToString)
            Dim hople As Boolean
            pxhs(0).Item("pxh_mahopdong") = Integer.Parse(txb_mahopdong.Text)
            pxhs(0).Item("pxh_ngayxuathang") = dtp_ngayxuathang.Value
            pxhs(0).Item("pxh_makhohang") = Cmb_tenkhohang.SelectedValue
            pxhs(0).Item("pxh_manguoidung") = Integer.Parse(txb_mataikhoan.Text)
            pxhs(0).Item("pxh_thoidiemcapnhat") = DateTime.Now
            hople = (Integer.Parse(txb_tongsomathang.Text) = dgvDsCTXuatHang.Rows.Count)
            If hople Then
                pxhs(0).Item("pxh_soluongmathang") = Integer.Parse(txb_tongsomathang.Text)
                Dim cautruyvanghidulieuPhieuXuatHang As String = "select pxh_ma, pxh_mahopdong, pxh_makhohang,pxh_ngayxuathang, pxh_soluongmathang,pxh_manguoidung,
                            pxh_daxoa, pxh_thoidiemcapnhat from PhieuXuatHang"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieuPhieuXuatHang, DsPhieuXuatHang)
                Dim cautruyvanghidulieutudoCTXuatHang = "select ctxh_ma, ctxh_maphieuxuathang, ctxh_mamathang,ctxh_soluong,
                                                            ctxh_daxoa, ctxh_thoidiemcapnhat 
                                                         from CTXuatHang"

                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieutudoCTXuatHang, DsCtXuatHang)
                Me.Close()
            Else
                MessageBox.Show("Chưa lưu được dữ liệu vì thông tin chi tiết xuất hàng chưa khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf LoaiHanhDong = 3 Then
            Dim xacnhan As DialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu xuất hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If xacnhan = DialogResult.Yes Then
                Dim pxhs = DsPhieuXuatHang.Select("pxh_ma = " + MaPhieuXuatHang.ToString)
                pxhs(0).Item("pxh_daxoa") = 1
                pxhs(0).Item("pxh_thoidiemcapnhat") = DateTime.Now
                For Each ctxh As DataRow In DsCtXuatHang.Rows
                    If ctxh.Item("ctxh_maphieuXuatHang") = MaPhieuXuatHang Then
                        ctxh.Item("ctxh_daxoa") = 1
                    End If
                Next
                Dim cautruyvanghidulieuPhieuXuatHang As String = "select pxh_ma, pxh_mahopdong, pxh_makhohang,pxh_ngayxuathang, pxh_soluongmathang,pxh_manguoidung,
                            pxh_daxoa, pxh_thoidiemcapnhat from PhieuXuatHang"
                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieuPhieuXuatHang, DsPhieuXuatHang)
                Dim cautruyvanghidulieutudoCTXuatHang = "select ctxh_ma, ctxh_maphieuxuathang, ctxh_mamathang,ctxh_soluong,
                                                            ctxh_daxoa, ctxh_thoidiemcapnhat 
                                                         from CTXuatHang"

                xl_dulieu.GhiDuLieuTuDo(cautruyvanghidulieutudoCTXuatHang, DsCtXuatHang)
                btn_themctxh.Visible = True
                btn_xoactxh.Visible = True
                dgvDsHopDong.Visible = True
                dgvDsMatHang.Visible = True
                Me.Close()
            Else
                btn_themctxh.Visible = True
                btn_xoactxh.Visible = True
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
            soluongtonkho = bus_khohang.TinhSoLuongTonKhocuaMatHangTrongHopDong(Cmb_tenkhohang.SelectedValue, Integer.Parse(txb_mahopdong.Text), mathangv.Cells("cthd_mamathang").Value)
            txb_soluonghangtonkhosanco.Text = Format(soluongtonkho, "#,###.##")

        End If
    End Sub
    Private Sub Cmb_tenkhohang_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_tenkhohang.SelectedValueChanged
        If txb_mahopdong.Text.Trim <> "" And txb_mamathang.Text.Trim <> "" Then
            soluongtonkho = bus_khohang.TinhSoLuongTonKhocuaMatHangTrongHopDong(Cmb_tenkhohang.SelectedValue, Integer.Parse(txb_mahopdong.Text), Integer.Parse(txb_mamathang.Text))
            txb_soluonghangtonkhosanco.Text = Format(soluongtonkho, "#,###.##")
            If txb_soluong.Text.Trim <> "" Then
                soluongxuat = Integer.Parse(txb_soluong.Text)
                If soluongtonkho > soluongxuat Then
                    txb_soluong.BackColor = Color.WhiteSmoke
                    txb_soluong.ForeColor = Color.DarkBlue
                ElseIf soluongtonkho = soluongxuat Then
                    txb_soluong.BackColor = Color.White
                    txb_soluong.ForeColor = Color.Yellow
                Else
                    txb_soluong.BackColor = Color.Yellow
                    txb_soluong.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub
    Private Sub btn_themctxh_Click(sender As Object, e As EventArgs) Handles btn_themctxh.Click
        If txb_mamathang.Text.Trim <> "" And txb_soluong.Text.Trim <> "" Then
            soluongxuat = Integer.Parse(txb_soluong.Text.Trim)
            If soluongtonkho >= soluongxuat Then
                MaCTXuatHangTam -= 1
                Dim ctxh As DataRow = DsCtXuatHang.NewRow
                ctxh.Item("ctxh_ma") = MaCTXuatHangTam
                ctxh.Item("ctxh_maphieuXuatHang") = MaPhieuXuatHang
                ctxh.Item("ctxh_mamathang") = Integer.Parse(txb_mamathang.Text)
                ctxh.Item("mh_ten") = txb_tenmathang.Text
                ctxh.Item("ctxh_soluong") = soluongxuat
                ctxh.Item("ctxh_daxoa") = 0
                ctxh.Item("ctxh_thoidiemcapnhat") = DateTime.Now
                DsCtXuatHang.Rows.Add(ctxh)
                dgvDsCTXuatHang.DataSource = LayDsCTXuatHangTheoMaPXH(MaPhieuXuatHang)
                DinhdangdgvDsCTXuatHang()
                txb_tongsomathang.Text = dgvDsCTXuatHang.Rows.Count
            Else
                MessageBox.Show("Số lượng hàng trong kho không đủ để xuất theo yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub btn_xoactxh_Click(sender As Object, e As EventArgs) Handles btn_xoactxh.Click
        Dim ctxhv = dgvDsCTXuatHang.CurrentRow
        If IsNothing(ctxhv) = False Then
            Dim ctxhs = DsCtXuatHang.Select("ctxh_ma = " + ctxhv.Cells("ctxh_ma").Value.ToString)
            If ctxhs(0).Item("ctxh_ma") < 0 Then
                DsCtXuatHang.Rows.Remove(ctxhs(0))
            Else
                ctxhs(0).Item("ctxh_daxoa") = 1
            End If
            If LayDsCTXuatHangTheoMaPXH(MaPhieuXuatHang).Rows.Count > 0 Then
                dgvDsCTXuatHang.DataSource = LayDsCTXuatHangTheoMaPXH(MaPhieuXuatHang)

            Else
                TaiCauTrucDsCTXuatHang()

            End If
            DinhdangdgvDsCTXuatHang()
            txb_tongsomathang.Text = dgvDsCTXuatHang.Rows.Count
        End If
    End Sub
    Sub TaiDuLieuDsPhieuXuatHang()
        Dim cautruyvanphieuXuatHang As String
        cautruyvanphieuXuatHang = "select pxh_ma, pxh_mahopdong, pxh_makhohang, kho_ten,pxh_ngayXuatHang, pxh_soluongmathang,pxh_manguoidung,
                             hd_makhachhang, kh_ten, gt_ten, kh_gtplso,hd_ngayhopdong,hd_ngaybatdau,hd_ngayhethan,
                             kh_diachi, kh_dienthoai, kh_email, hd_cohieuluc, nd_hoten, nd_manhanvien,pxh_daxoa, pxh_thoidiemcapnhat
                            from HopDong join PhieuXuatHang on hd_ma = pxh_Mahopdong
                            join KhoHang on pxh_makhohang = kho_ma
                            join NguoiDung on pxh_manguoidung = nd_ma
                            join KhachHang on hd_makhachhang = kh_ma 
                            join LoaiGiayToPhapLy on gt_ma= kh_maloaigtpl 
                            where pxh_daxoa = 0"
        DsPhieuXuatHang = xl_dulieu.DocDuLieu(cautruyvanphieuXuatHang)
    End Sub
    Sub LayThongTinPhieuXuatHang(ByVal maphieuxuathang)
        Dim pxhs = DsPhieuXuatHang.Select("pxh_ma = " + maphieuxuathang.ToString)
        If pxhs.Count > 0 Then
            txb_ma.Text = pxhs(0).Item("pxh_ma")
            txb_mahopdong.Text = pxhs(0).Item("pxh_mahopdong")
            txb_tenkhachhang.Text = pxhs(0).Item("kh_ten")
            txb_loaigtpl.Text = pxhs(0).Item("gt_ten")
            txb_gtplso.Text = pxhs(0).Item("kh_gtplso")
            txb_diachi.Text = pxhs(0).Item("kh_diachi")
            txb_dienthoai.Text = pxhs(0).Item("kh_dienthoai")
            txb_email.Text = pxhs(0).Item("kh_email")
            dtp_ngayhopdong.Value = pxhs(0).Item("hd_ngayhopdong")
            dtp_ngaybatdau.Value = pxhs(0).Item("hd_ngaybatdau")
            dtp_ngayhethan.Value = pxhs(0).Item("hd_ngayhethan")
            chb_cohieuluc.Checked = pxhs(0).Item("hd_cohieuluc")
            dtp_ngayxuathang.Value = pxhs(0).Item("pxh_ngayXuatHang")
            Cmb_tenkhohang.Text = pxhs(0).Item("kho_ten")
            txb_mataikhoan.Text = My.MyApplication.NguoiDung.Item("nd_ma")
            txb_manhanvien.Text = My.MyApplication.NguoiDung.Item("nd_manhanvien")
            txb_tennhanvien.Text = My.MyApplication.NguoiDung.Item("nd_hoten")
            txb_tongsomathang.Text = pxhs(0).Item("pxh_soluongmathang")
            If LayDsCTXuatHangTheoMaPXH(maphieuxuathang).Rows.Count > 0 Then
                dgvDsCTXuatHang.DataSource = LayDsCTXuatHangTheoMaPXH(maphieuxuathang)
            Else
                TaiCauTrucDsCTXuatHang()
            End If
            DinhdangdgvDsCTXuatHang()
        End If
    End Sub
    Sub TaiDuLieuCmbKhoHang()
        Dim madonvi = My.MyApplication.NguoiDung.Item("nd_madonvi")
        Dim cautruyvandskho = "Select kho_ma, kho_ten from KhoHang where kho_daxoa=0 and kho_thuocmadonvi = " + madonvi.ToString
        DsKho = xl_dulieu.DocDuLieu(cautruyvandskho)
        Cmb_tenkhohang.DataSource = DsKho
        Cmb_tenkhohang.DisplayMember = "kho_ten"
        Cmb_tenkhohang.ValueMember = "kho_ma"
    End Sub
    Sub TaiDuLieuDsCTXuatHang()
        Dim cautruyvanctxh As String
        cautruyvanctxh = "select ctxh_ma, ctxh_maphieuXuatHang, ctxh_mamathang,mh_ten, ctxh_soluong,
                            ctxh_daxoa,ctxh_thoidiemcapnhat
                            from CTXuatHang join MatHang on ctxh_mamathang = mh_ma
                            where ctxh_daxoa = 0"
        DsCtXuatHang = xl_dulieu.DocDuLieu(cautruyvanctxh)
    End Sub
    Sub TaiCauTrucDsCTXuatHang()
        Dim cautruyvancautrucCTXuatHang = "select ctxh_ma, ctxh_maphieuXuatHang, ctxh_mamathang,mh_ten, ctxh_soluong,
                                                            ctxh_daxoa, ctxh_thoidiemcapnhat
                                                         from CTXuatHang join MatHang on ctxh_mamathang = mh_ma
                                                            where ctxh_daxoa=0"
        Dim cautrucDsCTXuatHang = xl_dulieu.DocCauTruc(cautruyvancautrucCTXuatHang)
        dgvDsCTXuatHang.DataSource = cautrucDsCTXuatHang
    End Sub

    Sub DinhdangdgvDsCTXuatHang()
        If dgvDsCTXuatHang.Columns.Count = 7 Then
            Dim stt As New DataGridViewTextBoxColumn

            dgvDsCTXuatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDsCTXuatHang.RowHeadersVisible = False

            dgvDsCTXuatHang.Columns.Insert(0, stt)
            dgvDsCTXuatHang.Columns(0).Name = "stt"
            dgvDsCTXuatHang.Columns("stt").HeaderText = "STT"
            dgvDsCTXuatHang.Columns("stt").Width = 50
            dgvDsCTXuatHang.Columns("mh_ten").HeaderText = "Tên mặt hàng"
            dgvDsCTXuatHang.Columns("mh_ten").AutoSizeMode = False
            dgvDsCTXuatHang.Columns("mh_ten").Width = 160
            dgvDsCTXuatHang.Columns("ctxh_soluong").HeaderText = "Số lượng"
            dgvDsCTXuatHang.Columns("ctxh_soluong").AutoSizeMode = False
            dgvDsCTXuatHang.Columns("ctxh_soluong").Width = 70
            dgvDsCTXuatHang.Columns("ctxh_ma").Visible = False
            dgvDsCTXuatHang.Columns("ctxh_maphieuXuatHang").Visible = False
            dgvDsCTXuatHang.Columns("ctxh_mamathang").Visible = False
            dgvDsCTXuatHang.Columns("ctxh_daxoa").Visible = False
            dgvDsCTXuatHang.Columns("ctxh_thoidiemcapnhat").Visible = False
            For i As Integer = 0 To dgvDsCTXuatHang.Rows.Count - 1
                dgvDsCTXuatHang.Rows(i).Cells(0).Value = i + 1
            Next
        ElseIf dgvDsCTXuatHang.Columns.Count = 8 Then
            dgvDsCTXuatHang.Columns("stt").HeaderText = "STT"
            dgvDsCTXuatHang.Columns("stt").Width = 50
            dgvDsCTXuatHang.Columns("mh_ten").HeaderText = "Tên mặt hàng"
            dgvDsCTXuatHang.Columns("mh_ten").AutoSizeMode = False
            dgvDsCTXuatHang.Columns("mh_ten").Width = 160
            dgvDsCTXuatHang.Columns("ctxh_soluong").HeaderText = "Số lượng"
            dgvDsCTXuatHang.Columns("ctxh_soluong").AutoSizeMode = False
            dgvDsCTXuatHang.Columns("ctxh_soluong").Width = 70
            dgvDsCTXuatHang.Columns("ctxh_ma").Visible = False
            dgvDsCTXuatHang.Columns("ctxh_maphieuXuatHang").Visible = False
            dgvDsCTXuatHang.Columns("ctxh_mamathang").Visible = False
            dgvDsCTXuatHang.Columns("ctxh_daxoa").Visible = False
            dgvDsCTXuatHang.Columns("ctxh_thoidiemcapnhat").Visible = False
            For i As Integer = 0 To dgvDsCTXuatHang.Rows.Count - 1
                dgvDsCTXuatHang.Rows(i).Cells(0).Value = i + 1
            Next
        End If
    End Sub

    Private Sub txb_soluong_TextChanged(sender As Object, e As EventArgs) Handles txb_soluong.TextChanged
        If txb_soluong.Text.Trim <> "" Then
            soluongxuat = Integer.Parse(txb_soluong.Text)
            If soluongtonkho > soluongxuat Then
                txb_soluong.BackColor = Color.WhiteSmoke
                txb_soluong.ForeColor = Color.DarkBlue
            ElseIf soluongtonkho = soluongxuat Then
                txb_soluong.BackColor = Color.LightGreen
                txb_soluong.ForeColor = Color.Coral
            Else
                txb_soluong.BackColor = Color.Yellow
                txb_soluong.ForeColor = Color.Red
            End If
        End If
    End Sub
    Sub TaiDuLieudgvDsMatHangTheoHopDong(ByVal mahopdong As Integer)
        Dim cautruyvanctmhhd As String
        cautruyvanctmhhd = "select cthd_mamathang, mh_ten, mh_khoiluong, mh_thetich, lh_ten
                            from MatHang join CTHopDong on mh_ma = cthd_mamathang 
                            join LoaiHang on mh_maloaihang = lh_ma
                            where cthd_daxoa = 0 and cthd_mahopdong = " + mahopdong.ToString
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
    Protected Function LayDsCTXuatHangTheoMaPXH(ByVal maphieuxuathang As Integer) As DataTable
        Dim dtdskq As DataTable = New DataTable
        Dim dskq =
            From ctxh In DsCtXuatHang
            Where ctxh.Item("ctxh_maphieuxuathang") = maphieuxuathang And ctxh.Item("ctxh_daxoa") = 0
            Select ctxh
        If dskq.Count > 0 Then
            dtdskq = dskq.CopyToDataTable()
        End If
        Return dtdskq
    End Function
End Class