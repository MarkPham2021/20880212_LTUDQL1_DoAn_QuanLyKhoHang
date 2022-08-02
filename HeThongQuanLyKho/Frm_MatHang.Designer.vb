<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_MatHang
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
        Me.dgvDsMatHang = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txb_noidungtim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txb_thetich = New HeThongQuanLyKho.NTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_khoiluong = New HeThongQuanLyKho.NTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_loaihang = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_capnhat = New System.Windows.Forms.Button()
        Me.btn_dong = New System.Windows.Forms.Button()
        Me.txb_ghichu = New System.Windows.Forms.TextBox()
        Me.txb_ten = New System.Windows.Forms.TextBox()
        Me.txb_ma = New System.Windows.Forms.TextBox()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDsMatHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.LightGray
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_thetich)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_khoiluong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmb_loaihang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_capnhat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_dong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_ghichu)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_ten)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_ma)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_luu)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_xoa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_sua)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_them)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Size = New System.Drawing.Size(1482, 903)
        Me.SplitContainer1.SplitterDistance = 765
        Me.SplitContainer1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvDsMatHang)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(765, 795)
        Me.Panel2.TabIndex = 14
        '
        'dgvDsMatHang
        '
        Me.dgvDsMatHang.AllowDrop = True
        Me.dgvDsMatHang.AllowUserToAddRows = False
        Me.dgvDsMatHang.AllowUserToDeleteRows = False
        Me.dgvDsMatHang.AllowUserToOrderColumns = True
        Me.dgvDsMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsMatHang.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDsMatHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsMatHang.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsMatHang.Name = "dgvDsMatHang"
        Me.dgvDsMatHang.RowHeadersWidth = 51
        Me.dgvDsMatHang.RowTemplate.Height = 29
        Me.dgvDsMatHang.Size = New System.Drawing.Size(765, 795)
        Me.dgvDsMatHang.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.txb_noidungtim)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 108)
        Me.Panel1.TabIndex = 1
        '
        'txb_noidungtim
        '
        Me.txb_noidungtim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txb_noidungtim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_noidungtim.ForeColor = System.Drawing.Color.Blue
        Me.txb_noidungtim.Location = New System.Drawing.Point(0, 74)
        Me.txb_noidungtim.Name = "txb_noidungtim"
        Me.txb_noidungtim.PlaceholderText = "Nhập thông tin để tìm mặt hàng..."
        Me.txb_noidungtim.Size = New System.Drawing.Size(765, 34)
        Me.txb_noidungtim.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(430, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 38)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Quản lý Mặt hàng"
        '
        'txb_thetich
        '
        Me.txb_thetich.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_thetich.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_thetich.Location = New System.Drawing.Point(492, 213)
        Me.txb_thetich.Name = "txb_thetich"
        Me.txb_thetich.Size = New System.Drawing.Size(193, 34)
        Me.txb_thetich.TabIndex = 5
        Me.txb_thetich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(342, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 28)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Thể tích (Dm3):"
        '
        'txb_khoiluong
        '
        Me.txb_khoiluong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_khoiluong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_khoiluong.Location = New System.Drawing.Point(172, 213)
        Me.txb_khoiluong.Name = "txb_khoiluong"
        Me.txb_khoiluong.Size = New System.Drawing.Size(162, 34)
        Me.txb_khoiluong.TabIndex = 4
        Me.txb_khoiluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(11, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 28)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Khối lượng (Kg):"
        '
        'cmb_loaihang
        '
        Me.cmb_loaihang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmb_loaihang.ForeColor = System.Drawing.Color.Blue
        Me.cmb_loaihang.FormattingEnabled = True
        Me.cmb_loaihang.Location = New System.Drawing.Point(172, 161)
        Me.cmb_loaihang.Name = "cmb_loaihang"
        Me.cmb_loaihang.Size = New System.Drawing.Size(513, 36)
        Me.cmb_loaihang.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(11, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 28)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Thuộc loại hàng:"
        '
        'btn_capnhat
        '
        Me.btn_capnhat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_capnhat.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_capnhat.Location = New System.Drawing.Point(244, 483)
        Me.btn_capnhat.Name = "btn_capnhat"
        Me.btn_capnhat.Size = New System.Drawing.Size(185, 44)
        Me.btn_capnhat.TabIndex = 11
        Me.btn_capnhat.Text = "==> Lưu dữ liệu"
        Me.btn_capnhat.UseVisualStyleBackColor = True
        '
        'btn_dong
        '
        Me.btn_dong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dong.ForeColor = System.Drawing.Color.Orange
        Me.btn_dong.Location = New System.Drawing.Point(432, 483)
        Me.btn_dong.Name = "btn_dong"
        Me.btn_dong.Size = New System.Drawing.Size(198, 44)
        Me.btn_dong.TabIndex = 12
        Me.btn_dong.Text = "Đóng màn hình"
        Me.btn_dong.UseVisualStyleBackColor = True
        '
        'txb_ghichu
        '
        Me.txb_ghichu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ghichu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ghichu.Location = New System.Drawing.Point(172, 266)
        Me.txb_ghichu.Multiline = True
        Me.txb_ghichu.Name = "txb_ghichu"
        Me.txb_ghichu.Size = New System.Drawing.Size(513, 135)
        Me.txb_ghichu.TabIndex = 6
        '
        'txb_ten
        '
        Me.txb_ten.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ten.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ten.Location = New System.Drawing.Point(172, 115)
        Me.txb_ten.Name = "txb_ten"
        Me.txb_ten.Size = New System.Drawing.Size(513, 34)
        Me.txb_ten.TabIndex = 2
        '
        'txb_ma
        '
        Me.txb_ma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ma.Location = New System.Drawing.Point(172, 68)
        Me.txb_ma.Name = "txb_ma"
        Me.txb_ma.ReadOnly = True
        Me.txb_ma.Size = New System.Drawing.Size(162, 34)
        Me.txb_ma.TabIndex = 23
        '
        'btn_luu
        '
        Me.btn_luu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_luu.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_luu.Location = New System.Drawing.Point(40, 483)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(204, 44)
        Me.btn_luu.TabIndex = 10
        Me.btn_luu.Text = "==> Lưu dữ liệu"
        Me.btn_luu.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xoa.ForeColor = System.Drawing.Color.Red
        Me.btn_xoa.Location = New System.Drawing.Point(432, 433)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(198, 44)
        Me.btn_xoa.TabIndex = 9
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_sua.ForeColor = System.Drawing.Color.Orange
        Me.btn_sua.Location = New System.Drawing.Point(244, 433)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(185, 44)
        Me.btn_sua.TabIndex = 8
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_them.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_them.Location = New System.Drawing.Point(37, 433)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(207, 44)
        Me.btn_them.TabIndex = 7
        Me.btn_them.Text = "Thêm mới"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(11, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 28)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Mô tả:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(11, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 28)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tên mặt hàng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(11, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 28)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mã số:"
        '
        'Frm_MatHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 903)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_MatHang"
        Me.Text = "Frm_MatHang"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvDsMatHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txb_noidungtim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDsMatHang As DataGridView
    Friend WithEvents btn_capnhat As Button
    Friend WithEvents btn_dong As Button
    Friend WithEvents txb_ghichu As TextBox
    Friend WithEvents txb_ten As TextBox
    Friend WithEvents txb_ma As TextBox
    Friend WithEvents btn_luu As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_them As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txb_thetich As NTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_khoiluong As NTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_loaihang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
End Class
