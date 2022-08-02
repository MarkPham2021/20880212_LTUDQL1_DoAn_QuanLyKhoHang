<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_HopDong_Index
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvDsHopDong = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.grb_tinhtranghieuluc = New System.Windows.Forms.GroupBox()
        Me.rdb_hethieuluc = New System.Windows.Forms.RadioButton()
        Me.rdb_conhieuluc = New System.Windows.Forms.RadioButton()
        Me.rdb_tatca = New System.Windows.Forms.RadioButton()
        Me.txb_noidungtim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_dong = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.txb_loaigtpl = New System.Windows.Forms.TextBox()
        Me.lbl_nhandscthopdong = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txb_makhachhang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chb_cohieuluc = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_ngayhethan = New System.Windows.Forms.DateTimePicker()
        Me.txb_ma = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txb_tenkhachhang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_dienthoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_ngaybatdau = New System.Windows.Forms.DateTimePicker()
        Me.txb_diachi = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_ngayhopdong = New System.Windows.Forms.DateTimePicker()
        Me.txb_email = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txb_gtplso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvDsCTHopDong = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txb_tongsomathang = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDsHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.grb_tinhtranghieuluc.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvDsCTHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.SizeWE
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SplitContainer1.Size = New System.Drawing.Size(1482, 903)
        Me.SplitContainer1.SplitterDistance = 729
        Me.SplitContainer1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.dgvDsHopDong)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(729, 733)
        Me.Panel2.TabIndex = 15
        '
        'dgvDsHopDong
        '
        Me.dgvDsHopDong.AllowDrop = True
        Me.dgvDsHopDong.AllowUserToAddRows = False
        Me.dgvDsHopDong.AllowUserToDeleteRows = False
        Me.dgvDsHopDong.AllowUserToOrderColumns = True
        Me.dgvDsHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsHopDong.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDsHopDong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsHopDong.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsHopDong.Name = "dgvDsHopDong"
        Me.dgvDsHopDong.ReadOnly = True
        Me.dgvDsHopDong.RowHeadersWidth = 51
        Me.dgvDsHopDong.RowTemplate.Height = 29
        Me.dgvDsHopDong.Size = New System.Drawing.Size(729, 733)
        Me.dgvDsHopDong.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btn_refresh)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_them)
        Me.Panel1.Controls.Add(Me.btn_sua)
        Me.Panel1.Controls.Add(Me.btn_xoa)
        Me.Panel1.Controls.Add(Me.btn_dong)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 170)
        Me.Panel1.TabIndex = 1
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.White
        Me.btn_refresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_refresh.ForeColor = System.Drawing.Color.Green
        Me.btn_refresh.Location = New System.Drawing.Point(541, 50)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(183, 38)
        Me.btn_refresh.TabIndex = 22
        Me.btn_refresh.Text = "Làm mới Dữ liệu"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.grb_tinhtranghieuluc)
        Me.Panel5.Controls.Add(Me.txb_noidungtim)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 98)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(729, 72)
        Me.Panel5.TabIndex = 21
        '
        'grb_tinhtranghieuluc
        '
        Me.grb_tinhtranghieuluc.Controls.Add(Me.rdb_hethieuluc)
        Me.grb_tinhtranghieuluc.Controls.Add(Me.rdb_conhieuluc)
        Me.grb_tinhtranghieuluc.Controls.Add(Me.rdb_tatca)
        Me.grb_tinhtranghieuluc.Dock = System.Windows.Forms.DockStyle.Right
        Me.grb_tinhtranghieuluc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grb_tinhtranghieuluc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grb_tinhtranghieuluc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grb_tinhtranghieuluc.Location = New System.Drawing.Point(368, 0)
        Me.grb_tinhtranghieuluc.Name = "grb_tinhtranghieuluc"
        Me.grb_tinhtranghieuluc.Size = New System.Drawing.Size(361, 72)
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
        Me.rdb_conhieuluc.Checked = True
        Me.rdb_conhieuluc.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.rdb_conhieuluc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdb_conhieuluc.Location = New System.Drawing.Point(95, 31)
        Me.rdb_conhieuluc.Name = "rdb_conhieuluc"
        Me.rdb_conhieuluc.Size = New System.Drawing.Size(137, 32)
        Me.rdb_conhieuluc.TabIndex = 1
        Me.rdb_conhieuluc.TabStop = True
        Me.rdb_conhieuluc.Text = "Còn hiệu lực"
        Me.rdb_conhieuluc.UseVisualStyleBackColor = True
        '
        'rdb_tatca
        '
        Me.rdb_tatca.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.rdb_tatca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdb_tatca.Location = New System.Drawing.Point(9, 31)
        Me.rdb_tatca.Name = "rdb_tatca"
        Me.rdb_tatca.Size = New System.Drawing.Size(80, 32)
        Me.rdb_tatca.TabIndex = 0
        Me.rdb_tatca.Text = "Tất cả"
        Me.rdb_tatca.UseVisualStyleBackColor = True
        '
        'txb_noidungtim
        '
        Me.txb_noidungtim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_noidungtim.ForeColor = System.Drawing.Color.Blue
        Me.txb_noidungtim.Location = New System.Drawing.Point(3, 28)
        Me.txb_noidungtim.Name = "txb_noidungtim"
        Me.txb_noidungtim.PlaceholderText = "Nhập thông tin để tìm hợp đồng..."
        Me.txb_noidungtim.Size = New System.Drawing.Size(359, 34)
        Me.txb_noidungtim.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(137, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 38)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Quản lý Hợp đồng"
        Me.Label1.UseWaitCursor = True
        '
        'btn_them
        '
        Me.btn_them.BackColor = System.Drawing.Color.White
        Me.btn_them.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_them.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_them.Location = New System.Drawing.Point(16, 50)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(135, 38)
        Me.btn_them.TabIndex = 2
        Me.btn_them.Text = "Thêm mới"
        Me.btn_them.UseVisualStyleBackColor = False
        '
        'btn_sua
        '
        Me.btn_sua.BackColor = System.Drawing.Color.White
        Me.btn_sua.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_sua.ForeColor = System.Drawing.Color.Indigo
        Me.btn_sua.Location = New System.Drawing.Point(151, 50)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(110, 38)
        Me.btn_sua.TabIndex = 3
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = False
        '
        'btn_xoa
        '
        Me.btn_xoa.BackColor = System.Drawing.Color.White
        Me.btn_xoa.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xoa.ForeColor = System.Drawing.Color.Red
        Me.btn_xoa.Location = New System.Drawing.Point(259, 50)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(107, 38)
        Me.btn_xoa.TabIndex = 4
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = False
        '
        'btn_dong
        '
        Me.btn_dong.BackColor = System.Drawing.Color.Snow
        Me.btn_dong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dong.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn_dong.Location = New System.Drawing.Point(363, 50)
        Me.btn_dong.Name = "btn_dong"
        Me.btn_dong.Size = New System.Drawing.Size(172, 38)
        Me.btn_dong.TabIndex = 16
        Me.btn_dong.Text = "Đóng màn hình"
        Me.btn_dong.UseVisualStyleBackColor = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_loaigtpl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbl_nhandscthopdong)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_makhachhang)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.chb_cohieuluc)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtp_ngayhethan)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_ma)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_tenkhachhang)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_dienthoai)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtp_ngaybatdau)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_diachi)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtp_ngayhopdong)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_email)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_gtplso)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label8)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(749, 903)
        Me.SplitContainer2.SplitterDistance = 294
        Me.SplitContainer2.TabIndex = 59
        '
        'txb_loaigtpl
        '
        Me.txb_loaigtpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_loaigtpl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_loaigtpl.Location = New System.Drawing.Point(151, 75)
        Me.txb_loaigtpl.Name = "txb_loaigtpl"
        Me.txb_loaigtpl.ReadOnly = True
        Me.txb_loaigtpl.Size = New System.Drawing.Size(217, 27)
        Me.txb_loaigtpl.TabIndex = 6
        '
        'lbl_nhandscthopdong
        '
        Me.lbl_nhandscthopdong.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_nhandscthopdong.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_nhandscthopdong.ForeColor = System.Drawing.Color.Blue
        Me.lbl_nhandscthopdong.Location = New System.Drawing.Point(11, 255)
        Me.lbl_nhandscthopdong.Name = "lbl_nhandscthopdong"
        Me.lbl_nhandscthopdong.Size = New System.Drawing.Size(329, 40)
        Me.lbl_nhandscthopdong.TabIndex = 58
        Me.lbl_nhandscthopdong.Text = "Danh sách các mặt hàng gởi kho:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(11, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mã hợp đồng:"
        '
        'txb_makhachhang
        '
        Me.txb_makhachhang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_makhachhang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_makhachhang.Location = New System.Drawing.Point(396, 255)
        Me.txb_makhachhang.Name = "txb_makhachhang"
        Me.txb_makhachhang.ReadOnly = True
        Me.txb_makhachhang.Size = New System.Drawing.Size(163, 34)
        Me.txb_makhachhang.TabIndex = 56
        Me.txb_makhachhang.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(11, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tên khách hàng:"
        '
        'chb_cohieuluc
        '
        Me.chb_cohieuluc.Enabled = False
        Me.chb_cohieuluc.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chb_cohieuluc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chb_cohieuluc.Location = New System.Drawing.Point(374, 210)
        Me.chb_cohieuluc.Name = "chb_cohieuluc"
        Me.chb_cohieuluc.Size = New System.Drawing.Size(157, 30)
        Me.chb_cohieuluc.TabIndex = 8
        Me.chb_cohieuluc.Text = "Có hiệu lực"
        Me.chb_cohieuluc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(11, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Điện thoại:"
        '
        'dtp_ngayhethan
        '
        Me.dtp_ngayhethan.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngayhethan.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngayhethan.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngayhethan.CustomFormat = "shortdate"
        Me.dtp_ngayhethan.Enabled = False
        Me.dtp_ngayhethan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ngayhethan.Location = New System.Drawing.Point(506, 176)
        Me.dtp_ngayhethan.Name = "dtp_ngayhethan"
        Me.dtp_ngayhethan.Size = New System.Drawing.Size(193, 27)
        Me.dtp_ngayhethan.TabIndex = 6
        '
        'txb_ma
        '
        Me.txb_ma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ma.Location = New System.Drawing.Point(151, 8)
        Me.txb_ma.Name = "txb_ma"
        Me.txb_ma.ReadOnly = True
        Me.txb_ma.Size = New System.Drawing.Size(217, 27)
        Me.txb_ma.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(371, 177)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 25)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Ngày hết hạn:"
        '
        'txb_tenkhachhang
        '
        Me.txb_tenkhachhang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tenkhachhang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_tenkhachhang.Location = New System.Drawing.Point(151, 39)
        Me.txb_tenkhachhang.Name = "txb_tenkhachhang"
        Me.txb_tenkhachhang.ReadOnly = True
        Me.txb_tenkhachhang.Size = New System.Drawing.Size(548, 27)
        Me.txb_tenkhachhang.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(11, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Loại GTPL:"
        '
        'txb_dienthoai
        '
        Me.txb_dienthoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_dienthoai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_dienthoai.Location = New System.Drawing.Point(151, 144)
        Me.txb_dienthoai.Name = "txb_dienthoai"
        Me.txb_dienthoai.ReadOnly = True
        Me.txb_dienthoai.Size = New System.Drawing.Size(201, 27)
        Me.txb_dienthoai.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(11, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Địa chỉ:"
        '
        'dtp_ngaybatdau
        '
        Me.dtp_ngaybatdau.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngaybatdau.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngaybatdau.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngaybatdau.CustomFormat = "shortdate"
        Me.dtp_ngaybatdau.Enabled = False
        Me.dtp_ngaybatdau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ngaybatdau.Location = New System.Drawing.Point(151, 176)
        Me.dtp_ngaybatdau.Name = "dtp_ngaybatdau"
        Me.dtp_ngaybatdau.Size = New System.Drawing.Size(201, 27)
        Me.dtp_ngaybatdau.TabIndex = 5
        '
        'txb_diachi
        '
        Me.txb_diachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_diachi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_diachi.Location = New System.Drawing.Point(151, 109)
        Me.txb_diachi.Name = "txb_diachi"
        Me.txb_diachi.ReadOnly = True
        Me.txb_diachi.Size = New System.Drawing.Size(548, 27)
        Me.txb_diachi.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(11, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 25)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Ngày bắt đầu:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(358, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Email:"
        '
        'dtp_ngayhopdong
        '
        Me.dtp_ngayhopdong.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngayhopdong.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngayhopdong.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp_ngayhopdong.CustomFormat = ""
        Me.dtp_ngayhopdong.Enabled = False
        Me.dtp_ngayhopdong.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_ngayhopdong.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ngayhopdong.Location = New System.Drawing.Point(151, 211)
        Me.dtp_ngayhopdong.Name = "dtp_ngayhopdong"
        Me.dtp_ngayhopdong.Size = New System.Drawing.Size(201, 27)
        Me.dtp_ngayhopdong.TabIndex = 7
        '
        'txb_email
        '
        Me.txb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_email.Location = New System.Drawing.Point(420, 144)
        Me.txb_email.Name = "txb_email"
        Me.txb_email.ReadOnly = True
        Me.txb_email.Size = New System.Drawing.Size(279, 27)
        Me.txb_email.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(11, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 25)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Ngày hợp đồng:"
        '
        'txb_gtplso
        '
        Me.txb_gtplso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_gtplso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_gtplso.Location = New System.Drawing.Point(420, 75)
        Me.txb_gtplso.Name = "txb_gtplso"
        Me.txb_gtplso.ReadOnly = True
        Me.txb_gtplso.Size = New System.Drawing.Size(279, 27)
        Me.txb_gtplso.TabIndex = 7
        Me.txb_gtplso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(374, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Số:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvDsCTHopDong)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(749, 569)
        Me.Panel4.TabIndex = 1
        '
        'dgvDsCTHopDong
        '
        Me.dgvDsCTHopDong.AllowDrop = True
        Me.dgvDsCTHopDong.AllowUserToAddRows = False
        Me.dgvDsCTHopDong.AllowUserToDeleteRows = False
        Me.dgvDsCTHopDong.AllowUserToOrderColumns = True
        Me.dgvDsCTHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsCTHopDong.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDsCTHopDong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsCTHopDong.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsCTHopDong.Name = "dgvDsCTHopDong"
        Me.dgvDsCTHopDong.ReadOnly = True
        Me.dgvDsCTHopDong.RowHeadersWidth = 51
        Me.dgvDsCTHopDong.RowTemplate.Height = 29
        Me.dgvDsCTHopDong.Size = New System.Drawing.Size(749, 569)
        Me.dgvDsCTHopDong.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txb_tongsomathang)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 569)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(749, 36)
        Me.Panel3.TabIndex = 0
        '
        'txb_tongsomathang
        '
        Me.txb_tongsomathang.Dock = System.Windows.Forms.DockStyle.Right
        Me.txb_tongsomathang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tongsomathang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_tongsomathang.Location = New System.Drawing.Point(586, 0)
        Me.txb_tongsomathang.Name = "txb_tongsomathang"
        Me.txb_tongsomathang.ReadOnly = True
        Me.txb_tongsomathang.Size = New System.Drawing.Size(163, 34)
        Me.txb_tongsomathang.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(221, 36)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Tổng số mặt hàng:"
        '
        'Frm_HopDong_Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 903)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_HopDong_Index"
        Me.Text = "Frm_HopDong_Index"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvDsHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.grb_tinhtranghieuluc.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvDsCTHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvDsHopDong As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grb_tinhtranghieuluc As GroupBox
    Friend WithEvents rdb_hethieuluc As RadioButton
    Friend WithEvents rdb_conhieuluc As RadioButton
    Friend WithEvents rdb_tatca As RadioButton
    Friend WithEvents txb_noidungtim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_them As Button
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents btn_dong As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents txb_loaigtpl As TextBox
    Friend WithEvents lbl_nhandscthopdong As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txb_makhachhang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chb_cohieuluc As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_ngayhethan As DateTimePicker
    Friend WithEvents txb_ma As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txb_tenkhachhang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txb_dienthoai As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_ngaybatdau As DateTimePicker
    Friend WithEvents txb_diachi As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_ngayhopdong As DateTimePicker
    Friend WithEvents txb_email As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txb_gtplso As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvDsCTHopDong As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txb_tongsomathang As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_refresh As Button
End Class
