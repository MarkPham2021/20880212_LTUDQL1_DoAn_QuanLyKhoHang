<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_LoaiNguoiDung_Index
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
        Me.dgvDsLoaiNguoiDung = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txb_noidungtim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_dong = New System.Windows.Forms.Button()
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang = New System.Windows.Forms.SplitContainer()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txb_ma = New System.Windows.Forms.TextBox()
        Me.txb_lnd_ten = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txb_lnd_mota = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvDsCTPhanQuyen = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDsLoaiNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.SuspendLayout()
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel2.SuspendLayout()
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvDsCTPhanQuyen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SplitContainer1.Size = New System.Drawing.Size(1482, 903)
        Me.SplitContainer1.SplitterDistance = 729
        Me.SplitContainer1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.dgvDsLoaiNguoiDung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(729, 733)
        Me.Panel2.TabIndex = 15
        '
        'dgvDsLoaiNguoiDung
        '
        Me.dgvDsLoaiNguoiDung.AllowDrop = True
        Me.dgvDsLoaiNguoiDung.AllowUserToAddRows = False
        Me.dgvDsLoaiNguoiDung.AllowUserToDeleteRows = False
        Me.dgvDsLoaiNguoiDung.AllowUserToOrderColumns = True
        Me.dgvDsLoaiNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsLoaiNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsLoaiNguoiDung.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsLoaiNguoiDung.Name = "dgvDsLoaiNguoiDung"
        Me.dgvDsLoaiNguoiDung.ReadOnly = True
        Me.dgvDsLoaiNguoiDung.RowHeadersWidth = 51
        Me.dgvDsLoaiNguoiDung.RowTemplate.Height = 29
        Me.dgvDsLoaiNguoiDung.Size = New System.Drawing.Size(729, 733)
        Me.dgvDsLoaiNguoiDung.TabIndex = 14
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
        Me.btn_refresh.Location = New System.Drawing.Point(363, 50)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(183, 38)
        Me.btn_refresh.TabIndex = 22
        Me.btn_refresh.Text = "Làm mới Dữ liệu"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txb_noidungtim)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 98)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(729, 72)
        Me.Panel5.TabIndex = 21
        '
        'txb_noidungtim
        '
        Me.txb_noidungtim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txb_noidungtim.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txb_noidungtim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txb_noidungtim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_noidungtim.ForeColor = System.Drawing.Color.Blue
        Me.txb_noidungtim.Location = New System.Drawing.Point(0, 38)
        Me.txb_noidungtim.Name = "txb_noidungtim"
        Me.txb_noidungtim.PlaceholderText = "Nhập thông tin để tìm loại người dùng..."
        Me.txb_noidungtim.Size = New System.Drawing.Size(729, 34)
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
        Me.Label1.Text = "Quản lý Loại Người Dùng"
        '
        'btn_them
        '
        Me.btn_them.BackColor = System.Drawing.Color.White
        Me.btn_them.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_them.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_them.Location = New System.Drawing.Point(10, 50)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(135, 38)
        Me.btn_them.TabIndex = 2
        Me.btn_them.Text = "Thêm mới"
        Me.btn_them.UseVisualStyleBackColor = False
        '
        'btn_sua
        '
        Me.btn_sua.BackColor = System.Drawing.Color.White
        Me.btn_sua.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_sua.ForeColor = System.Drawing.Color.Indigo
        Me.btn_sua.Location = New System.Drawing.Point(146, 50)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(105, 38)
        Me.btn_sua.TabIndex = 3
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = False
        '
        'btn_xoa
        '
        Me.btn_xoa.BackColor = System.Drawing.Color.White
        Me.btn_xoa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xoa.ForeColor = System.Drawing.Color.Red
        Me.btn_xoa.Location = New System.Drawing.Point(252, 50)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(105, 38)
        Me.btn_xoa.TabIndex = 4
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = False
        '
        'btn_dong
        '
        Me.btn_dong.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_dong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dong.ForeColor = System.Drawing.Color.Coral
        Me.btn_dong.Location = New System.Drawing.Point(552, 50)
        Me.btn_dong.Name = "btn_dong"
        Me.btn_dong.Size = New System.Drawing.Size(172, 38)
        Me.btn_dong.TabIndex = 16
        Me.btn_dong.Text = "Đóng màn hình"
        Me.btn_dong.UseVisualStyleBackColor = False
        '
        'SplitContainer_Xuly_LoaiNguoiDung_DsChucNang
        '
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Name = "SplitContainer_Xuly_LoaiNguoiDung_DsChucNang"
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1
        '
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.Controls.Add(Me.txb_ma)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.Controls.Add(Me.txb_lnd_ten)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.Controls.Add(Me.txb_lnd_mota)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        '
        'SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel2
        '
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Size = New System.Drawing.Size(749, 903)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.SplitterDistance = 264
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(11, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(482, 32)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Danh sách chức năng được sử dụng:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(11, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(329, 32)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Thông tin Loại Người dùng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mã loại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(11, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tên loại:"
        '
        'txb_ma
        '
        Me.txb_ma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ma.Location = New System.Drawing.Point(151, 44)
        Me.txb_ma.Name = "txb_ma"
        Me.txb_ma.ReadOnly = True
        Me.txb_ma.Size = New System.Drawing.Size(184, 27)
        Me.txb_ma.TabIndex = 4
        '
        'txb_lnd_ten
        '
        Me.txb_lnd_ten.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_lnd_ten.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_lnd_ten.Location = New System.Drawing.Point(151, 75)
        Me.txb_lnd_ten.Name = "txb_lnd_ten"
        Me.txb_lnd_ten.ReadOnly = True
        Me.txb_lnd_ten.Size = New System.Drawing.Size(548, 27)
        Me.txb_lnd_ten.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(11, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Mô tả:"
        '
        'txb_lnd_mota
        '
        Me.txb_lnd_mota.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_lnd_mota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_lnd_mota.Location = New System.Drawing.Point(151, 112)
        Me.txb_lnd_mota.Multiline = True
        Me.txb_lnd_mota.Name = "txb_lnd_mota"
        Me.txb_lnd_mota.ReadOnly = True
        Me.txb_lnd_mota.Size = New System.Drawing.Size(548, 87)
        Me.txb_lnd_mota.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvDsCTPhanQuyen)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(749, 635)
        Me.Panel4.TabIndex = 1
        '
        'dgvDsCTPhanQuyen
        '
        Me.dgvDsCTPhanQuyen.AllowDrop = True
        Me.dgvDsCTPhanQuyen.AllowUserToAddRows = False
        Me.dgvDsCTPhanQuyen.AllowUserToDeleteRows = False
        Me.dgvDsCTPhanQuyen.AllowUserToOrderColumns = True
        Me.dgvDsCTPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsCTPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsCTPhanQuyen.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsCTPhanQuyen.Name = "dgvDsCTPhanQuyen"
        Me.dgvDsCTPhanQuyen.ReadOnly = True
        Me.dgvDsCTPhanQuyen.RowHeadersWidth = 51
        Me.dgvDsCTPhanQuyen.RowTemplate.Height = 29
        Me.dgvDsCTPhanQuyen.Size = New System.Drawing.Size(749, 635)
        Me.dgvDsCTPhanQuyen.TabIndex = 27
        '
        'Frm_LoaiNguoiDung_Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 903)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_LoaiNguoiDung_Index"
        Me.Text = "Frm_LoaiNguoiDung_Index"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvDsLoaiNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.ResumeLayout(False)
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel1.PerformLayout()
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Xuly_LoaiNguoiDung_DsChucNang.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvDsCTPhanQuyen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvDsLoaiNguoiDung As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txb_noidungtim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_them As Button
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents btn_dong As Button
    Friend WithEvents SplitContainer_Xuly_LoaiNguoiDung_DsChucNang As SplitContainer
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_ma As TextBox
    Friend WithEvents txb_lnd_ten As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txb_lnd_mota As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvDsCTPhanQuyen As DataGridView
End Class
