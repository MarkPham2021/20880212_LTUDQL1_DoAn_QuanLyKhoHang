<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_KhachHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvDsKhachHang = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txb_noidungtim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_dong = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.cmb_loaigtpl = New System.Windows.Forms.ComboBox()
        Me.lbl_nhandgvdshopdong = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.txb_gtplso = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_capnhat = New System.Windows.Forms.Button()
        Me.txb_email = New System.Windows.Forms.TextBox()
        Me.txb_ma = New System.Windows.Forms.TextBox()
        Me.txb_dienthoai = New System.Windows.Forms.TextBox()
        Me.txb_ten = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_diachi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvDsHopDong = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDsKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgvDsHopDong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1482, 903)
        Me.SplitContainer1.SplitterDistance = 737
        Me.SplitContainer1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvDsKhachHang)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(737, 731)
        Me.Panel2.TabIndex = 15
        '
        'dgvDsKhachHang
        '
        Me.dgvDsKhachHang.AllowDrop = True
        Me.dgvDsKhachHang.AllowUserToAddRows = False
        Me.dgvDsKhachHang.AllowUserToDeleteRows = False
        Me.dgvDsKhachHang.AllowUserToOrderColumns = True
        Me.dgvDsKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsKhachHang.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDsKhachHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsKhachHang.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsKhachHang.Name = "dgvDsKhachHang"
        Me.dgvDsKhachHang.RowHeadersWidth = 51
        Me.dgvDsKhachHang.RowTemplate.Height = 29
        Me.dgvDsKhachHang.Size = New System.Drawing.Size(737, 731)
        Me.dgvDsKhachHang.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.txb_noidungtim)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_sua)
        Me.Panel1.Controls.Add(Me.btn_them)
        Me.Panel1.Controls.Add(Me.btn_xoa)
        Me.Panel1.Controls.Add(Me.btn_dong)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 172)
        Me.Panel1.TabIndex = 1
        '
        'txb_noidungtim
        '
        Me.txb_noidungtim.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txb_noidungtim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txb_noidungtim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_noidungtim.ForeColor = System.Drawing.Color.Blue
        Me.txb_noidungtim.Location = New System.Drawing.Point(0, 138)
        Me.txb_noidungtim.Name = "txb_noidungtim"
        Me.txb_noidungtim.Size = New System.Drawing.Size(737, 34)
        Me.txb_noidungtim.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(245, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 38)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Quản lý Khách hàng"
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_sua.ForeColor = System.Drawing.Color.Orange
        Me.btn_sua.Location = New System.Drawing.Point(205, 53)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(181, 38)
        Me.btn_sua.TabIndex = 9
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_them.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_them.Location = New System.Drawing.Point(25, 53)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(181, 38)
        Me.btn_them.TabIndex = 8
        Me.btn_them.Text = "Thêm mới"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xoa.ForeColor = System.Drawing.Color.Red
        Me.btn_xoa.Location = New System.Drawing.Point(384, 53)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(181, 38)
        Me.btn_xoa.TabIndex = 10
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_dong
        '
        Me.btn_dong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dong.ForeColor = System.Drawing.Color.Orange
        Me.btn_dong.Location = New System.Drawing.Point(385, 91)
        Me.btn_dong.Name = "btn_dong"
        Me.btn_dong.Size = New System.Drawing.Size(181, 38)
        Me.btn_dong.TabIndex = 13
        Me.btn_dong.Text = "Đóng màn hình"
        Me.btn_dong.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmb_loaigtpl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbl_nhandgvdshopdong)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_luu)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_gtplso)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_capnhat)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_email)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_ma)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_dienthoai)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_ten)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_diachi)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvDsHopDong)
        Me.SplitContainer2.Size = New System.Drawing.Size(741, 903)
        Me.SplitContainer2.SplitterDistance = 285
        Me.SplitContainer2.TabIndex = 29
        '
        'cmb_loaigtpl
        '
        Me.cmb_loaigtpl.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmb_loaigtpl.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmb_loaigtpl.ForeColor = System.Drawing.Color.Blue
        Me.cmb_loaigtpl.FormattingEnabled = True
        Me.cmb_loaigtpl.Location = New System.Drawing.Point(141, 91)
        Me.cmb_loaigtpl.Name = "cmb_loaigtpl"
        Me.cmb_loaigtpl.Size = New System.Drawing.Size(232, 33)
        Me.cmb_loaigtpl.TabIndex = 2
        '
        'lbl_nhandgvdshopdong
        '
        Me.lbl_nhandgvdshopdong.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nhandgvdshopdong.ForeColor = System.Drawing.Color.Blue
        Me.lbl_nhandgvdshopdong.Location = New System.Drawing.Point(9, 257)
        Me.lbl_nhandgvdshopdong.Name = "lbl_nhandgvdshopdong"
        Me.lbl_nhandgvdshopdong.Size = New System.Drawing.Size(445, 28)
        Me.lbl_nhandgvdshopdong.TabIndex = 28
        Me.lbl_nhandgvdshopdong.Text = "Danh sách hợp đồng đang thực hiện:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mã số:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(379, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Số:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tên khách hàng:"
        '
        'btn_luu
        '
        Me.btn_luu.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_luu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_luu.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_luu.Location = New System.Drawing.Point(167, 216)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(181, 38)
        Me.btn_luu.TabIndex = 11
        Me.btn_luu.Text = "=> Lưu dữ liệu"
        Me.btn_luu.UseVisualStyleBackColor = True
        '
        'txb_gtplso
        '
        Me.txb_gtplso.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_gtplso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_gtplso.Location = New System.Drawing.Point(415, 91)
        Me.txb_gtplso.Name = "txb_gtplso"
        Me.txb_gtplso.Size = New System.Drawing.Size(313, 31)
        Me.txb_gtplso.TabIndex = 3
        Me.txb_gtplso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(6, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Điện thoại:"
        '
        'btn_capnhat
        '
        Me.btn_capnhat.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_capnhat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_capnhat.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_capnhat.Location = New System.Drawing.Point(407, 216)
        Me.btn_capnhat.Name = "btn_capnhat"
        Me.btn_capnhat.Size = New System.Drawing.Size(181, 38)
        Me.btn_capnhat.TabIndex = 12
        Me.btn_capnhat.Text = "=> Lưu dữ liệu"
        Me.btn_capnhat.UseVisualStyleBackColor = True
        '
        'txb_email
        '
        Me.txb_email.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_email.Location = New System.Drawing.Point(407, 176)
        Me.txb_email.Name = "txb_email"
        Me.txb_email.Size = New System.Drawing.Size(321, 31)
        Me.txb_email.TabIndex = 6
        '
        'txb_ma
        '
        Me.txb_ma.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ma.Location = New System.Drawing.Point(141, 12)
        Me.txb_ma.Name = "txb_ma"
        Me.txb_ma.ReadOnly = True
        Me.txb_ma.Size = New System.Drawing.Size(232, 31)
        Me.txb_ma.TabIndex = 23
        '
        'txb_dienthoai
        '
        Me.txb_dienthoai.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_dienthoai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_dienthoai.Location = New System.Drawing.Point(141, 176)
        Me.txb_dienthoai.Name = "txb_dienthoai"
        Me.txb_dienthoai.Size = New System.Drawing.Size(207, 31)
        Me.txb_dienthoai.TabIndex = 5
        '
        'txb_ten
        '
        Me.txb_ten.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ten.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ten.Location = New System.Drawing.Point(141, 51)
        Me.txb_ten.Name = "txb_ten"
        Me.txb_ten.Size = New System.Drawing.Size(587, 31)
        Me.txb_ten.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(352, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(6, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Loại GTPL:"
        '
        'txb_diachi
        '
        Me.txb_diachi.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_diachi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_diachi.Location = New System.Drawing.Point(141, 134)
        Me.txb_diachi.Name = "txb_diachi"
        Me.txb_diachi.Size = New System.Drawing.Size(587, 31)
        Me.txb_diachi.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(9, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Địa chỉ:"
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
        Me.dgvDsHopDong.RowHeadersWidth = 51
        Me.dgvDsHopDong.RowTemplate.Height = 29
        Me.dgvDsHopDong.Size = New System.Drawing.Size(741, 614)
        Me.dgvDsHopDong.TabIndex = 27
        '
        'Frm_KhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 903)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_KhachHang"
        Me.Text = "Frm_KhachHang"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvDsKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgvDsHopDong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txb_noidungtim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDsKhachHang As DataGridView
    Friend WithEvents txb_dienthoai As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_diachi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_loaigtpl As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_capnhat As Button
    Friend WithEvents btn_dong As Button
    Friend WithEvents txb_ten As TextBox
    Friend WithEvents txb_ma As TextBox
    Friend WithEvents btn_luu As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_them As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txb_gtplso As TextBox
    Friend WithEvents txb_email As TextBox
    Friend WithEvents lbl_nhandgvdshopdong As Label
    Friend WithEvents dgvDsHopDong As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer2 As SplitContainer
End Class
