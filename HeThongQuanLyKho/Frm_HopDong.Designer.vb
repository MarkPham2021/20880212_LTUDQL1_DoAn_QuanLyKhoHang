<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_HopDong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grb_tinhtranghieuluc = New System.Windows.Forms.GroupBox()
        Me.rdb_hethieuluc = New System.Windows.Forms.RadioButton()
        Me.rdb_conhieuluc = New System.Windows.Forms.RadioButton()
        Me.rdb_tatca = New System.Windows.Forms.RadioButton()
        Me.txb_noidungtim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.dgvDsHopDong = New System.Windows.Forms.DataGridView()
        Me.lbl_nhandscthopdong = New System.Windows.Forms.Label()
        Me.txb_mamathang = New System.Windows.Forms.TextBox()
        Me.txb_makhachhang = New System.Windows.Forms.TextBox()
        Me.panel_timkhachhang = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvDsKhachHang = New System.Windows.Forms.DataGridView()
        Me.txb_timkhachhang = New System.Windows.Forms.TextBox()
        Me.chb_cohieuluc = New System.Windows.Forms.CheckBox()
        Me.dtp_ngayhethan = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txb_loaigtpl = New System.Windows.Forms.TextBox()
        Me.txb_dienthoai = New System.Windows.Forms.TextBox()
        Me.txb_tongsomathang = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_xoacthd = New System.Windows.Forms.Button()
        Me.btn_themcthd = New System.Windows.Forms.Button()
        Me.txb_dongia = New HeThongQuanLyKho.IntTextBox()
        Me.cmb_tenpttt = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txb_thetich = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txb_tenloaihang = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txb_tenmathang = New System.Windows.Forms.TextBox()
        Me.dtp_ngaybatdau = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_ngayhopdong = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_dongia = New System.Windows.Forms.Label()
        Me.txb_timmathang = New System.Windows.Forms.TextBox()
        Me.lbl_nhannhapcthopdong = New System.Windows.Forms.Label()
        Me.dgvDsCTHopDong = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txb_gtplso = New System.Windows.Forms.TextBox()
        Me.txb_email = New System.Windows.Forms.TextBox()
        Me.txb_khoiluong = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_diachi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_capnhat = New System.Windows.Forms.Button()
        Me.btn_dong = New System.Windows.Forms.Button()
        Me.txb_tenkhachhang = New System.Windows.Forms.TextBox()
        Me.txb_ma = New System.Windows.Forms.TextBox()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDsMatHang = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grb_tinhtranghieuluc.SuspendLayout()
        CType(Me.dgvDsHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_timkhachhang.SuspendLayout()
        CType(Me.dgvDsKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDsCTHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDsMatHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvDsHopDong)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.SizeWE
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_nhandscthopdong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_mamathang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_makhachhang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.panel_timkhachhang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chb_cohieuluc)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtp_ngayhethan)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_loaigtpl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_dienthoai)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_tongsomathang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_xoacthd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_themcthd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_dongia)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmb_tenpttt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_thetich)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_tenloaihang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_tenmathang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtp_ngaybatdau)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtp_ngayhopdong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_dongia)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_timmathang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_nhannhapcthopdong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvDsCTHopDong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_gtplso)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_email)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_khoiluong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_diachi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_capnhat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_dong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_tenkhachhang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_ma)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_luu)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvDsMatHang)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SplitContainer1.Size = New System.Drawing.Size(1482, 903)
        Me.SplitContainer1.SplitterDistance = 556
        Me.SplitContainer1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grb_tinhtranghieuluc)
        Me.Panel1.Controls.Add(Me.txb_noidungtim)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_them)
        Me.Panel1.Controls.Add(Me.btn_sua)
        Me.Panel1.Controls.Add(Me.btn_xoa)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 170)
        Me.Panel1.TabIndex = 1
        '
        'grb_tinhtranghieuluc
        '
        Me.grb_tinhtranghieuluc.Controls.Add(Me.rdb_hethieuluc)
        Me.grb_tinhtranghieuluc.Controls.Add(Me.rdb_conhieuluc)
        Me.grb_tinhtranghieuluc.Controls.Add(Me.rdb_tatca)
        Me.grb_tinhtranghieuluc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grb_tinhtranghieuluc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grb_tinhtranghieuluc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grb_tinhtranghieuluc.Location = New System.Drawing.Point(337, 100)
        Me.grb_tinhtranghieuluc.Name = "grb_tinhtranghieuluc"
        Me.grb_tinhtranghieuluc.Size = New System.Drawing.Size(371, 76)
        Me.grb_tinhtranghieuluc.TabIndex = 0
        Me.grb_tinhtranghieuluc.TabStop = False
        Me.grb_tinhtranghieuluc.Text = "Tình trạng hiệu lực"
        '
        'rdb_hethieuluc
        '
        Me.rdb_hethieuluc.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.rdb_hethieuluc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdb_hethieuluc.Location = New System.Drawing.Point(231, 31)
        Me.rdb_hethieuluc.Name = "rdb_hethieuluc"
        Me.rdb_hethieuluc.Size = New System.Drawing.Size(127, 32)
        Me.rdb_hethieuluc.TabIndex = 2
        Me.rdb_hethieuluc.Text = "Hết hiệu lực"
        Me.rdb_hethieuluc.UseVisualStyleBackColor = True
        '
        'rdb_conhieuluc
        '
        Me.rdb_conhieuluc.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.rdb_conhieuluc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdb_conhieuluc.Location = New System.Drawing.Point(95, 31)
        Me.rdb_conhieuluc.Name = "rdb_conhieuluc"
        Me.rdb_conhieuluc.Size = New System.Drawing.Size(137, 32)
        Me.rdb_conhieuluc.TabIndex = 1
        Me.rdb_conhieuluc.Text = "Còn hiệu lực"
        Me.rdb_conhieuluc.UseVisualStyleBackColor = True
        '
        'rdb_tatca
        '
        Me.rdb_tatca.Checked = True
        Me.rdb_tatca.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.rdb_tatca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdb_tatca.Location = New System.Drawing.Point(9, 31)
        Me.rdb_tatca.Name = "rdb_tatca"
        Me.rdb_tatca.Size = New System.Drawing.Size(80, 32)
        Me.rdb_tatca.TabIndex = 0
        Me.rdb_tatca.TabStop = True
        Me.rdb_tatca.Text = "Tất cả"
        Me.rdb_tatca.UseVisualStyleBackColor = True
        '
        'txb_noidungtim
        '
        Me.txb_noidungtim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_noidungtim.ForeColor = System.Drawing.Color.Blue
        Me.txb_noidungtim.Location = New System.Drawing.Point(16, 133)
        Me.txb_noidungtim.Name = "txb_noidungtim"
        Me.txb_noidungtim.PlaceholderText = "Nhập thông tin để tìm hợp đồng..."
        Me.txb_noidungtim.Size = New System.Drawing.Size(315, 34)
        Me.txb_noidungtim.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(29, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 38)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Quản lý Hợp đồng"
        Me.Label1.UseWaitCursor = True
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_them.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_them.Location = New System.Drawing.Point(16, 50)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(157, 44)
        Me.btn_them.TabIndex = 2
        Me.btn_them.Text = "Thêm mới"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_sua.ForeColor = System.Drawing.Color.Orange
        Me.btn_sua.Location = New System.Drawing.Point(171, 50)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(138, 44)
        Me.btn_sua.TabIndex = 3
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xoa.ForeColor = System.Drawing.Color.Red
        Me.btn_xoa.Location = New System.Drawing.Point(306, 50)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(129, 44)
        Me.btn_xoa.TabIndex = 4
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'dgvDsHopDong
        '
        Me.dgvDsHopDong.AllowDrop = True
        Me.dgvDsHopDong.AllowUserToAddRows = False
        Me.dgvDsHopDong.AllowUserToDeleteRows = False
        Me.dgvDsHopDong.AllowUserToOrderColumns = True
        Me.dgvDsHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsHopDong.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDsHopDong.Location = New System.Drawing.Point(16, 182)
        Me.dgvDsHopDong.Name = "dgvDsHopDong"
        Me.dgvDsHopDong.RowHeadersWidth = 51
        Me.dgvDsHopDong.RowTemplate.Height = 29
        Me.dgvDsHopDong.Size = New System.Drawing.Size(729, 714)
        Me.dgvDsHopDong.TabIndex = 14
        '
        'lbl_nhandscthopdong
        '
        Me.lbl_nhandscthopdong.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_nhandscthopdong.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_nhandscthopdong.ForeColor = System.Drawing.Color.Blue
        Me.lbl_nhandscthopdong.Location = New System.Drawing.Point(246, 489)
        Me.lbl_nhandscthopdong.Name = "lbl_nhandscthopdong"
        Me.lbl_nhandscthopdong.Size = New System.Drawing.Size(551, 40)
        Me.lbl_nhandscthopdong.TabIndex = 58
        Me.lbl_nhandscthopdong.Text = "Danh sách các mặt hàng gởi kho:"
        '
        'txb_mamathang
        '
        Me.txb_mamathang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_mamathang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_mamathang.Location = New System.Drawing.Point(28, 748)
        Me.txb_mamathang.Name = "txb_mamathang"
        Me.txb_mamathang.ReadOnly = True
        Me.txb_mamathang.Size = New System.Drawing.Size(163, 34)
        Me.txb_mamathang.TabIndex = 57
        Me.txb_mamathang.Visible = False
        '
        'txb_makhachhang
        '
        Me.txb_makhachhang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_makhachhang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_makhachhang.Location = New System.Drawing.Point(28, 708)
        Me.txb_makhachhang.Name = "txb_makhachhang"
        Me.txb_makhachhang.ReadOnly = True
        Me.txb_makhachhang.Size = New System.Drawing.Size(163, 34)
        Me.txb_makhachhang.TabIndex = 56
        Me.txb_makhachhang.Visible = False
        '
        'panel_timkhachhang
        '
        Me.panel_timkhachhang.BackColor = System.Drawing.Color.Honeydew
        Me.panel_timkhachhang.Controls.Add(Me.Label11)
        Me.panel_timkhachhang.Controls.Add(Me.dgvDsKhachHang)
        Me.panel_timkhachhang.Controls.Add(Me.txb_timkhachhang)
        Me.panel_timkhachhang.Location = New System.Drawing.Point(3, -7)
        Me.panel_timkhachhang.Name = "panel_timkhachhang"
        Me.panel_timkhachhang.Size = New System.Drawing.Size(794, 490)
        Me.panel_timkhachhang.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(36, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(383, 40)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Double click vào dòng để chọn khách hàng."
        '
        'dgvDsKhachHang
        '
        Me.dgvDsKhachHang.AllowDrop = True
        Me.dgvDsKhachHang.AllowUserToAddRows = False
        Me.dgvDsKhachHang.AllowUserToDeleteRows = False
        Me.dgvDsKhachHang.AllowUserToOrderColumns = True
        Me.dgvDsKhachHang.BackgroundColor = System.Drawing.Color.White
        Me.dgvDsKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDsKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvDsKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsKhachHang.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDsKhachHang.GridColor = System.Drawing.Color.White
        Me.dgvDsKhachHang.Location = New System.Drawing.Point(12, 82)
        Me.dgvDsKhachHang.Name = "dgvDsKhachHang"
        Me.dgvDsKhachHang.RowHeadersWidth = 51
        Me.dgvDsKhachHang.RowTemplate.Height = 29
        Me.dgvDsKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDsKhachHang.Size = New System.Drawing.Size(767, 316)
        Me.dgvDsKhachHang.TabIndex = 32
        '
        'txb_timkhachhang
        '
        Me.txb_timkhachhang.BackColor = System.Drawing.Color.White
        Me.txb_timkhachhang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_timkhachhang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_timkhachhang.Location = New System.Drawing.Point(12, 36)
        Me.txb_timkhachhang.Name = "txb_timkhachhang"
        Me.txb_timkhachhang.PlaceholderText = "Nhập thông tin để tìm khách hàng ..."
        Me.txb_timkhachhang.Size = New System.Drawing.Size(767, 34)
        Me.txb_timkhachhang.TabIndex = 17
        '
        'chb_cohieuluc
        '
        Me.chb_cohieuluc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chb_cohieuluc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chb_cohieuluc.Location = New System.Drawing.Point(302, 173)
        Me.chb_cohieuluc.Name = "chb_cohieuluc"
        Me.chb_cohieuluc.Size = New System.Drawing.Size(146, 30)
        Me.chb_cohieuluc.TabIndex = 8
        Me.chb_cohieuluc.Text = "Có hiệu lực"
        Me.chb_cohieuluc.UseVisualStyleBackColor = True
        '
        'dtp_ngayhethan
        '
        Me.dtp_ngayhethan.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngayhethan.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngayhethan.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngayhethan.CustomFormat = "shortdate"
        Me.dtp_ngayhethan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ngayhethan.Location = New System.Drawing.Point(420, 138)
        Me.dtp_ngayhethan.Name = "dtp_ngayhethan"
        Me.dtp_ngayhethan.Size = New System.Drawing.Size(140, 27)
        Me.dtp_ngayhethan.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(302, 143)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 20)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Ngày hết hạn:"
        '
        'txb_loaigtpl
        '
        Me.txb_loaigtpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_loaigtpl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_loaigtpl.Location = New System.Drawing.Point(128, 36)
        Me.txb_loaigtpl.Name = "txb_loaigtpl"
        Me.txb_loaigtpl.ReadOnly = True
        Me.txb_loaigtpl.Size = New System.Drawing.Size(247, 27)
        Me.txb_loaigtpl.TabIndex = 6
        '
        'txb_dienthoai
        '
        Me.txb_dienthoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_dienthoai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_dienthoai.Location = New System.Drawing.Point(128, 105)
        Me.txb_dienthoai.Name = "txb_dienthoai"
        Me.txb_dienthoai.ReadOnly = True
        Me.txb_dienthoai.Size = New System.Drawing.Size(196, 27)
        Me.txb_dienthoai.TabIndex = 9
        '
        'txb_tongsomathang
        '
        Me.txb_tongsomathang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tongsomathang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_tongsomathang.Location = New System.Drawing.Point(634, 847)
        Me.txb_tongsomathang.Name = "txb_tongsomathang"
        Me.txb_tongsomathang.ReadOnly = True
        Me.txb_tongsomathang.Size = New System.Drawing.Size(163, 34)
        Me.txb_tongsomathang.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(276, 850)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(203, 28)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Tổng số mặt hàng:"
        '
        'btn_xoacthd
        '
        Me.btn_xoacthd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xoacthd.ForeColor = System.Drawing.Color.Red
        Me.btn_xoacthd.Location = New System.Drawing.Point(523, 489)
        Me.btn_xoacthd.Name = "btn_xoacthd"
        Me.btn_xoacthd.Size = New System.Drawing.Size(274, 40)
        Me.btn_xoacthd.TabIndex = 13
        Me.btn_xoacthd.Text = "(-) Xóa dòng được chọn"
        Me.btn_xoacthd.UseVisualStyleBackColor = True
        '
        'btn_themcthd
        '
        Me.btn_themcthd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_themcthd.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_themcthd.Location = New System.Drawing.Point(246, 489)
        Me.btn_themcthd.Name = "btn_themcthd"
        Me.btn_themcthd.Size = New System.Drawing.Size(271, 40)
        Me.btn_themcthd.TabIndex = 12
        Me.btn_themcthd.Text = "(+) Thêm mặt hàng"
        Me.btn_themcthd.UseVisualStyleBackColor = True
        '
        'txb_dongia
        '
        Me.txb_dongia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_dongia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_dongia.Location = New System.Drawing.Point(569, 422)
        Me.txb_dongia.Name = "txb_dongia"
        Me.txb_dongia.Size = New System.Drawing.Size(228, 27)
        Me.txb_dongia.TabIndex = 11
        Me.txb_dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_tenpttt
        '
        Me.cmb_tenpttt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmb_tenpttt.ForeColor = System.Drawing.Color.Blue
        Me.cmb_tenpttt.FormattingEnabled = True
        Me.cmb_tenpttt.Location = New System.Drawing.Point(569, 385)
        Me.cmb_tenpttt.Name = "cmb_tenpttt"
        Me.cmb_tenpttt.Size = New System.Drawing.Size(228, 28)
        Me.cmb_tenpttt.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(379, 353)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(124, 23)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Thể tích (dm3):"
        '
        'txb_thetich
        '
        Me.txb_thetich.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_thetich.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_thetich.Location = New System.Drawing.Point(523, 352)
        Me.txb_thetich.Name = "txb_thetich"
        Me.txb_thetich.ReadOnly = True
        Me.txb_thetich.Size = New System.Drawing.Size(274, 27)
        Me.txb_thetich.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(379, 319)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 23)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Khối lượng (Kg):"
        '
        'txb_tenloaihang
        '
        Me.txb_tenloaihang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tenloaihang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_tenloaihang.Location = New System.Drawing.Point(523, 282)
        Me.txb_tenloaihang.Name = "txb_tenloaihang"
        Me.txb_tenloaihang.ReadOnly = True
        Me.txb_tenloaihang.Size = New System.Drawing.Size(274, 27)
        Me.txb_tenloaihang.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(379, 283)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 23)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Thuộc loại hàng:"
        '
        'txb_tenmathang
        '
        Me.txb_tenmathang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tenmathang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_tenmathang.Location = New System.Drawing.Point(523, 248)
        Me.txb_tenmathang.Name = "txb_tenmathang"
        Me.txb_tenmathang.ReadOnly = True
        Me.txb_tenmathang.Size = New System.Drawing.Size(274, 27)
        Me.txb_tenmathang.TabIndex = 17
        '
        'dtp_ngaybatdau
        '
        Me.dtp_ngaybatdau.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngaybatdau.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngaybatdau.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngaybatdau.CustomFormat = "shortdate"
        Me.dtp_ngaybatdau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ngaybatdau.Location = New System.Drawing.Point(128, 138)
        Me.dtp_ngaybatdau.Name = "dtp_ngaybatdau"
        Me.dtp_ngaybatdau.Size = New System.Drawing.Size(140, 27)
        Me.dtp_ngaybatdau.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(15, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 20)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Ngày bắt đầu:"
        '
        'dtp_ngayhopdong
        '
        Me.dtp_ngayhopdong.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngayhopdong.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngayhopdong.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngayhopdong.CustomFormat = ""
        Me.dtp_ngayhopdong.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngayhopdong.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ngayhopdong.Location = New System.Drawing.Point(138, 172)
        Me.dtp_ngayhopdong.Name = "dtp_ngayhopdong"
        Me.dtp_ngayhopdong.Size = New System.Drawing.Size(140, 27)
        Me.dtp_ngayhopdong.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(15, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 20)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Ngày hợp đồng:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(379, 385)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 23)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Phương thức tính tiền:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(379, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 23)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Tên mặt hàng:"
        '
        'lbl_dongia
        '
        Me.lbl_dongia.AutoSize = True
        Me.lbl_dongia.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_dongia.ForeColor = System.Drawing.Color.Blue
        Me.lbl_dongia.Location = New System.Drawing.Point(379, 423)
        Me.lbl_dongia.Name = "lbl_dongia"
        Me.lbl_dongia.Size = New System.Drawing.Size(74, 23)
        Me.lbl_dongia.TabIndex = 33
        Me.lbl_dongia.Text = "Đơn giá:"
        '
        'txb_timmathang
        '
        Me.txb_timmathang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_timmathang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_timmathang.Location = New System.Drawing.Point(11, 248)
        Me.txb_timmathang.Name = "txb_timmathang"
        Me.txb_timmathang.PlaceholderText = "Nhập thông tin để tìm mặt hàng ..."
        Me.txb_timmathang.Size = New System.Drawing.Size(358, 27)
        Me.txb_timmathang.TabIndex = 9
        '
        'lbl_nhannhapcthopdong
        '
        Me.lbl_nhannhapcthopdong.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_nhannhapcthopdong.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nhannhapcthopdong.ForeColor = System.Drawing.Color.Blue
        Me.lbl_nhannhapcthopdong.Location = New System.Drawing.Point(14, 215)
        Me.lbl_nhannhapcthopdong.Name = "lbl_nhannhapcthopdong"
        Me.lbl_nhannhapcthopdong.Size = New System.Drawing.Size(364, 28)
        Me.lbl_nhannhapcthopdong.TabIndex = 28
        Me.lbl_nhannhapcthopdong.Text = "Nhập nội dung chi tiết hợp đồng:"
        '
        'dgvDsCTHopDong
        '
        Me.dgvDsCTHopDong.AllowDrop = True
        Me.dgvDsCTHopDong.AllowUserToAddRows = False
        Me.dgvDsCTHopDong.AllowUserToDeleteRows = False
        Me.dgvDsCTHopDong.AllowUserToOrderColumns = True
        Me.dgvDsCTHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsCTHopDong.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDsCTHopDong.Location = New System.Drawing.Point(246, 535)
        Me.dgvDsCTHopDong.Name = "dgvDsCTHopDong"
        Me.dgvDsCTHopDong.RowHeadersWidth = 51
        Me.dgvDsCTHopDong.RowTemplate.Height = 29
        Me.dgvDsCTHopDong.Size = New System.Drawing.Size(551, 306)
        Me.dgvDsCTHopDong.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(381, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 23)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Số:"
        '
        'txb_gtplso
        '
        Me.txb_gtplso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_gtplso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_gtplso.Location = New System.Drawing.Point(420, 36)
        Me.txb_gtplso.Name = "txb_gtplso"
        Me.txb_gtplso.ReadOnly = True
        Me.txb_gtplso.Size = New System.Drawing.Size(377, 27)
        Me.txb_gtplso.TabIndex = 7
        Me.txb_gtplso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txb_email
        '
        Me.txb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_email.Location = New System.Drawing.Point(420, 105)
        Me.txb_email.Name = "txb_email"
        Me.txb_email.ReadOnly = True
        Me.txb_email.Size = New System.Drawing.Size(377, 27)
        Me.txb_email.TabIndex = 10
        '
        'txb_khoiluong
        '
        Me.txb_khoiluong.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_khoiluong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_khoiluong.Location = New System.Drawing.Point(523, 318)
        Me.txb_khoiluong.Name = "txb_khoiluong"
        Me.txb_khoiluong.ReadOnly = True
        Me.txb_khoiluong.Size = New System.Drawing.Size(274, 27)
        Me.txb_khoiluong.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(358, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Email:"
        '
        'txb_diachi
        '
        Me.txb_diachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_diachi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_diachi.Location = New System.Drawing.Point(128, 70)
        Me.txb_diachi.Name = "txb_diachi"
        Me.txb_diachi.ReadOnly = True
        Me.txb_diachi.Size = New System.Drawing.Size(669, 27)
        Me.txb_diachi.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(15, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Địa chỉ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(15, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Loại GTPL:"
        '
        'btn_capnhat
        '
        Me.btn_capnhat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_capnhat.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_capnhat.Location = New System.Drawing.Point(15, 585)
        Me.btn_capnhat.Name = "btn_capnhat"
        Me.btn_capnhat.Size = New System.Drawing.Size(225, 40)
        Me.btn_capnhat.TabIndex = 15
        Me.btn_capnhat.Text = "==> Lưu dữ liệu"
        Me.btn_capnhat.UseVisualStyleBackColor = True
        '
        'btn_dong
        '
        Me.btn_dong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dong.ForeColor = System.Drawing.Color.Orange
        Me.btn_dong.Location = New System.Drawing.Point(15, 636)
        Me.btn_dong.Name = "btn_dong"
        Me.btn_dong.Size = New System.Drawing.Size(225, 40)
        Me.btn_dong.TabIndex = 16
        Me.btn_dong.Text = "Đóng màn hình"
        Me.btn_dong.UseVisualStyleBackColor = True
        '
        'txb_tenkhachhang
        '
        Me.txb_tenkhachhang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tenkhachhang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_tenkhachhang.Location = New System.Drawing.Point(420, 5)
        Me.txb_tenkhachhang.Name = "txb_tenkhachhang"
        Me.txb_tenkhachhang.ReadOnly = True
        Me.txb_tenkhachhang.Size = New System.Drawing.Size(377, 27)
        Me.txb_tenkhachhang.TabIndex = 5
        '
        'txb_ma
        '
        Me.txb_ma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ma.Location = New System.Drawing.Point(128, 3)
        Me.txb_ma.Name = "txb_ma"
        Me.txb_ma.ReadOnly = True
        Me.txb_ma.Size = New System.Drawing.Size(140, 27)
        Me.txb_ma.TabIndex = 4
        '
        'btn_luu
        '
        Me.btn_luu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_luu.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_luu.Location = New System.Drawing.Point(15, 535)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(225, 40)
        Me.btn_luu.TabIndex = 14
        Me.btn_luu.Text = "==> Lưu dữ liệu"
        Me.btn_luu.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(15, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Điện thoại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(284, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tên khách hàng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(11, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mã hợp đồng:"
        '
        'dgvDsMatHang
        '
        Me.dgvDsMatHang.AllowDrop = True
        Me.dgvDsMatHang.AllowUserToAddRows = False
        Me.dgvDsMatHang.AllowUserToDeleteRows = False
        Me.dgvDsMatHang.AllowUserToOrderColumns = True
        Me.dgvDsMatHang.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDsMatHang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDsMatHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvDsMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsMatHang.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDsMatHang.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDsMatHang.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvDsMatHang.Location = New System.Drawing.Point(14, 288)
        Me.dgvDsMatHang.Name = "dgvDsMatHang"
        Me.dgvDsMatHang.ReadOnly = True
        Me.dgvDsMatHang.RowHeadersWidth = 10
        Me.dgvDsMatHang.RowTemplate.Height = 29
        Me.dgvDsMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDsMatHang.Size = New System.Drawing.Size(359, 190)
        Me.dgvDsMatHang.TabIndex = 16
        '
        'Frm_HopDong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 903)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_HopDong"
        Me.Text = "Frm_HopDong"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grb_tinhtranghieuluc.ResumeLayout(False)
        CType(Me.dgvDsHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_timkhachhang.ResumeLayout(False)
        Me.panel_timkhachhang.PerformLayout()
        CType(Me.dgvDsKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDsCTHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDsMatHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txb_noidungtim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_them As Button
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents dgvDsHopDong As DataGridView
    Friend WithEvents lbl_nhannhapcthopdong As Label
    Friend WithEvents dgvDsCTHopDong As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txb_gtplso As TextBox
    Friend WithEvents txb_email As TextBox
    Friend WithEvents txb_khoiluong As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_diachi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_capnhat As Button
    Friend WithEvents btn_dong As Button
    Friend WithEvents txb_tenkhachhang As TextBox
    Friend WithEvents txb_ma As TextBox
    Friend WithEvents btn_luu As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDsMatHang As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_dongia As Label
    Friend WithEvents txb_timmathang As TextBox
    Friend WithEvents dtp_ngaybatdau As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents dtp_ngayhopdong As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_xoacthd As Button
    Friend WithEvents btn_themcthd As Button
    Friend WithEvents txb_dongia As HeThongQuanLyKho.IntTextBox
    Friend WithEvents cmb_tenpttt As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txb_thetich As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txb_tenloaihang As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txb_tenmathang As TextBox
    Friend WithEvents txb_tongsomathang As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txb_dienthoai As TextBox
    Friend WithEvents txb_loaigtpl As TextBox
    Friend WithEvents dtp_ngayhethan As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents chb_cohieuluc As CheckBox
    Friend WithEvents panel_timkhachhang As Panel
    Friend WithEvents dgvDsKhachHang As DataGridView
    Friend WithEvents txb_timkhachhang As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txb_makhachhang As TextBox
    Friend WithEvents txb_mamathang As TextBox
    Friend WithEvents grb_tinhtranghieuluc As GroupBox
    Friend WithEvents rdb_hethieuluc As RadioButton
    Friend WithEvents rdb_conhieuluc As RadioButton
    Friend WithEvents rdb_tatca As RadioButton
    Friend WithEvents lbl_nhandscthopdong As Label
End Class
