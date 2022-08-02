<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DonVi
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
        Me.dgvDsDonVi = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txb_noidungtim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_dong = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.txb_dienthoai = New System.Windows.Forms.TextBox()
        Me.txb_diachi = New System.Windows.Forms.TextBox()
        Me.lbl_nhandgvdsctquanly = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_ten = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.txb_ma = New System.Windows.Forms.TextBox()
        Me.dgvDsSubUnit = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDsDonVi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgvDsSubUnit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Size = New System.Drawing.Size(1482, 903)
        Me.SplitContainer1.SplitterDistance = 711
        Me.SplitContainer1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvDsDonVi)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 737)
        Me.Panel2.TabIndex = 2
        '
        'dgvDsDonVi
        '
        Me.dgvDsDonVi.AllowDrop = True
        Me.dgvDsDonVi.AllowUserToAddRows = False
        Me.dgvDsDonVi.AllowUserToDeleteRows = False
        Me.dgvDsDonVi.AllowUserToOrderColumns = True
        Me.dgvDsDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsDonVi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsDonVi.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsDonVi.Name = "dgvDsDonVi"
        Me.dgvDsDonVi.RowHeadersWidth = 51
        Me.dgvDsDonVi.RowTemplate.Height = 29
        Me.dgvDsDonVi.Size = New System.Drawing.Size(711, 737)
        Me.dgvDsDonVi.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.txb_noidungtim)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_them)
        Me.Panel1.Controls.Add(Me.btn_dong)
        Me.Panel1.Controls.Add(Me.btn_sua)
        Me.Panel1.Controls.Add(Me.btn_xoa)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 166)
        Me.Panel1.TabIndex = 1
        '
        'txb_noidungtim
        '
        Me.txb_noidungtim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txb_noidungtim.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_noidungtim.ForeColor = System.Drawing.Color.Blue
        Me.txb_noidungtim.Location = New System.Drawing.Point(0, 135)
        Me.txb_noidungtim.Name = "txb_noidungtim"
        Me.txb_noidungtim.PlaceholderText = "Nhập thông tin để tìm đơn vị..."
        Me.txb_noidungtim.Size = New System.Drawing.Size(711, 31)
        Me.txb_noidungtim.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(199, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 35)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Quản lý Đơn vị Cấp 1"
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_them.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_them.Location = New System.Drawing.Point(62, 52)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(180, 36)
        Me.btn_them.TabIndex = 6
        Me.btn_them.Text = "Thêm mới"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_dong
        '
        Me.btn_dong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dong.ForeColor = System.Drawing.Color.Orange
        Me.btn_dong.Location = New System.Drawing.Point(435, 92)
        Me.btn_dong.Name = "btn_dong"
        Me.btn_dong.Size = New System.Drawing.Size(180, 36)
        Me.btn_dong.TabIndex = 9
        Me.btn_dong.Text = "Đóng màn hình"
        Me.btn_dong.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_sua.ForeColor = System.Drawing.Color.Orange
        Me.btn_sua.Location = New System.Drawing.Point(249, 52)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(180, 36)
        Me.btn_sua.TabIndex = 7
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xoa.ForeColor = System.Drawing.Color.Red
        Me.btn_xoa.Location = New System.Drawing.Point(435, 52)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(180, 36)
        Me.btn_xoa.TabIndex = 8
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_dienthoai)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_diachi)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbl_nhandgvdsctquanly)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_ten)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_luu)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txb_ma)
        Me.SplitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvDsSubUnit)
        Me.SplitContainer2.Size = New System.Drawing.Size(767, 903)
        Me.SplitContainer2.SplitterDistance = 301
        Me.SplitContainer2.TabIndex = 26
        '
        'txb_dienthoai
        '
        Me.txb_dienthoai.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_dienthoai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_dienthoai.Location = New System.Drawing.Point(157, 122)
        Me.txb_dienthoai.Name = "txb_dienthoai"
        Me.txb_dienthoai.Size = New System.Drawing.Size(598, 31)
        Me.txb_dienthoai.TabIndex = 26
        '
        'txb_diachi
        '
        Me.txb_diachi.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_diachi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_diachi.Location = New System.Drawing.Point(157, 85)
        Me.txb_diachi.Name = "txb_diachi"
        Me.txb_diachi.Size = New System.Drawing.Size(598, 31)
        Me.txb_diachi.TabIndex = 26
        '
        'lbl_nhandgvdsctquanly
        '
        Me.lbl_nhandgvdsctquanly.AutoSize = True
        Me.lbl_nhandgvdsctquanly.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nhandgvdsctquanly.ForeColor = System.Drawing.Color.Blue
        Me.lbl_nhandgvdsctquanly.Location = New System.Drawing.Point(19, 270)
        Me.lbl_nhandgvdsctquanly.Name = "lbl_nhandgvdsctquanly"
        Me.lbl_nhandgvdsctquanly.Size = New System.Drawing.Size(348, 25)
        Me.lbl_nhandgvdsctquanly.TabIndex = 25
        Me.lbl_nhandgvdsctquanly.Text = "Các phòng/ban/chi nhánh/kho của Đơn vị:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Mã số:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tên Đơn vị:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(6, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Điện thoại:"
        '
        'txb_ten
        '
        Me.txb_ten.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ten.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ten.Location = New System.Drawing.Point(157, 48)
        Me.txb_ten.Name = "txb_ten"
        Me.txb_ten.Size = New System.Drawing.Size(598, 31)
        Me.txb_ten.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(6, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Địa chỉ:"
        '
        'btn_luu
        '
        Me.btn_luu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_luu.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_luu.Location = New System.Drawing.Point(157, 221)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(180, 36)
        Me.btn_luu.TabIndex = 10
        Me.btn_luu.Text = "=> Lưu dữ liệu"
        Me.btn_luu.UseVisualStyleBackColor = True
        '
        'txb_ma
        '
        Me.txb_ma.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ma.Location = New System.Drawing.Point(157, 7)
        Me.txb_ma.Name = "txb_ma"
        Me.txb_ma.ReadOnly = True
        Me.txb_ma.Size = New System.Drawing.Size(144, 31)
        Me.txb_ma.TabIndex = 23
        '
        'dgvDsSubUnit
        '
        Me.dgvDsSubUnit.AllowDrop = True
        Me.dgvDsSubUnit.AllowUserToAddRows = False
        Me.dgvDsSubUnit.AllowUserToDeleteRows = False
        Me.dgvDsSubUnit.AllowUserToOrderColumns = True
        Me.dgvDsSubUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsSubUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsSubUnit.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsSubUnit.Name = "dgvDsSubUnit"
        Me.dgvDsSubUnit.RowHeadersWidth = 51
        Me.dgvDsSubUnit.RowTemplate.Height = 29
        Me.dgvDsSubUnit.Size = New System.Drawing.Size(767, 598)
        Me.dgvDsSubUnit.TabIndex = 24
        '
        'Frm_DonVi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 903)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_DonVi"
        Me.Text = "Frm_DonVi"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvDsDonVi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgvDsSubUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvDsDonVi As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txb_noidungtim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_them As Button
    Friend WithEvents btn_dong As Button
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents txb_dienthoai As TextBox
    Friend WithEvents txb_diachi As TextBox
    Friend WithEvents lbl_nhandgvdsctquanly As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txb_ten As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_luu As Button
    Friend WithEvents txb_ma As TextBox
    Friend WithEvents dgvDsSubUnit As DataGridView
End Class
