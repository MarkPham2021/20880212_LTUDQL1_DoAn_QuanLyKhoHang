<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_KhoHang
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txb_noidungtim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDsKho = New System.Windows.Forms.DataGridView()
        Me.cmb_thuocdonvi = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_capnhat = New System.Windows.Forms.Button()
        Me.btn_dong = New System.Windows.Forms.Button()
        Me.txb_congsuatthetich = New HeThongQuanLyKho.IntTextBox()
        Me.txb_congsuatkhoiluong = New HeThongQuanLyKho.IntTextBox()
        Me.txb_diachi = New System.Windows.Forms.TextBox()
        Me.txb_ten = New System.Windows.Forms.TextBox()
        Me.txb_ma = New System.Windows.Forms.TextBox()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDsKho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmb_thuocdonvi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_capnhat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_dong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_congsuatthetich)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_congsuatkhoiluong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_diachi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_ten)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txb_ma)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_luu)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_xoa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_sua)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_them)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Size = New System.Drawing.Size(1432, 888)
        Me.SplitContainer1.SplitterDistance = 706
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.txb_noidungtim)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 72)
        Me.Panel1.TabIndex = 1
        '
        'txb_noidungtim
        '
        Me.txb_noidungtim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txb_noidungtim.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_noidungtim.ForeColor = System.Drawing.Color.Blue
        Me.txb_noidungtim.Location = New System.Drawing.Point(0, 41)
        Me.txb_noidungtim.Name = "txb_noidungtim"
        Me.txb_noidungtim.PlaceholderText = "Nhập thông tin để tìm kho hàng ..."
        Me.txb_noidungtim.Size = New System.Drawing.Size(706, 31)
        Me.txb_noidungtim.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(387, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 36)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Quản lý Hệ thống Kho hàng"
        '
        'dgvDsKho
        '
        Me.dgvDsKho.AllowDrop = True
        Me.dgvDsKho.AllowUserToAddRows = False
        Me.dgvDsKho.AllowUserToDeleteRows = False
        Me.dgvDsKho.AllowUserToOrderColumns = True
        Me.dgvDsKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsKho.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDsKho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsKho.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsKho.Name = "dgvDsKho"
        Me.dgvDsKho.RowHeadersWidth = 51
        Me.dgvDsKho.RowTemplate.Height = 29
        Me.dgvDsKho.Size = New System.Drawing.Size(706, 816)
        Me.dgvDsKho.TabIndex = 0
        '
        'cmb_thuocdonvi
        '
        Me.cmb_thuocdonvi.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmb_thuocdonvi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmb_thuocdonvi.FormattingEnabled = True
        Me.cmb_thuocdonvi.Location = New System.Drawing.Point(139, 57)
        Me.cmb_thuocdonvi.Name = "cmb_thuocdonvi"
        Me.cmb_thuocdonvi.Size = New System.Drawing.Size(558, 33)
        Me.cmb_thuocdonvi.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Thuộc Đơn vị:"
        '
        'btn_capnhat
        '
        Me.btn_capnhat.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_capnhat.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_capnhat.Location = New System.Drawing.Point(205, 285)
        Me.btn_capnhat.Name = "btn_capnhat"
        Me.btn_capnhat.Size = New System.Drawing.Size(186, 39)
        Me.btn_capnhat.TabIndex = 6
        Me.btn_capnhat.Text = "=> Lưu"
        Me.btn_capnhat.UseVisualStyleBackColor = True
        '
        'btn_dong
        '
        Me.btn_dong.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dong.ForeColor = System.Drawing.Color.Orange
        Me.btn_dong.Location = New System.Drawing.Point(397, 285)
        Me.btn_dong.Name = "btn_dong"
        Me.btn_dong.Size = New System.Drawing.Size(200, 39)
        Me.btn_dong.TabIndex = 7
        Me.btn_dong.Text = "Đóng màn hình"
        Me.btn_dong.UseVisualStyleBackColor = True
        '
        'txb_congsuatthetich
        '
        Me.txb_congsuatthetich.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_congsuatthetich.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_congsuatthetich.Location = New System.Drawing.Point(315, 191)
        Me.txb_congsuatthetich.Name = "txb_congsuatthetich"
        Me.txb_congsuatthetich.Size = New System.Drawing.Size(382, 31)
        Me.txb_congsuatthetich.TabIndex = 12
        Me.txb_congsuatthetich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txb_congsuatkhoiluong
        '
        Me.txb_congsuatkhoiluong.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_congsuatkhoiluong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_congsuatkhoiluong.Location = New System.Drawing.Point(315, 143)
        Me.txb_congsuatkhoiluong.Name = "txb_congsuatkhoiluong"
        Me.txb_congsuatkhoiluong.Size = New System.Drawing.Size(382, 31)
        Me.txb_congsuatkhoiluong.TabIndex = 11
        Me.txb_congsuatkhoiluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txb_diachi
        '
        Me.txb_diachi.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_diachi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_diachi.Location = New System.Drawing.Point(139, 100)
        Me.txb_diachi.Name = "txb_diachi"
        Me.txb_diachi.Size = New System.Drawing.Size(558, 31)
        Me.txb_diachi.TabIndex = 10
        '
        'txb_ten
        '
        Me.txb_ten.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ten.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ten.Location = New System.Drawing.Point(363, 16)
        Me.txb_ten.Name = "txb_ten"
        Me.txb_ten.Size = New System.Drawing.Size(334, 31)
        Me.txb_ten.TabIndex = 8
        '
        'txb_ma
        '
        Me.txb_ma.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ma.Location = New System.Drawing.Point(139, 16)
        Me.txb_ma.Name = "txb_ma"
        Me.txb_ma.ReadOnly = True
        Me.txb_ma.Size = New System.Drawing.Size(144, 31)
        Me.txb_ma.TabIndex = 23
        '
        'btn_luu
        '
        Me.btn_luu.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_luu.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_luu.Location = New System.Drawing.Point(15, 285)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(186, 39)
        Me.btn_luu.TabIndex = 5
        Me.btn_luu.Text = "=> Lưu"
        Me.btn_luu.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xoa.ForeColor = System.Drawing.Color.Red
        Me.btn_xoa.Location = New System.Drawing.Point(395, 240)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(202, 39)
        Me.btn_xoa.TabIndex = 4
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_sua.ForeColor = System.Drawing.Color.Orange
        Me.btn_sua.Location = New System.Drawing.Point(205, 240)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(186, 39)
        Me.btn_sua.TabIndex = 3
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_them.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_them.Location = New System.Drawing.Point(15, 240)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(186, 39)
        Me.btn_them.TabIndex = 2
        Me.btn_them.Text = "Thêm mới"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(12, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Công suất thể tích (Dm3):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(12, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Công suất khối lượng (Kg):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(12, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Địa chỉ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(288, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tên kho:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Mã số:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.dgvDsKho)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 816)
        Me.Panel2.TabIndex = 2
        '
        'Frm_KhoHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1432, 888)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_KhoHang"
        Me.Text = "Frm_KhoHang"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDsKho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txb_noidungtim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDsKho As DataGridView
    Friend WithEvents txb_congsuatthetich As IntTextBox
    Friend WithEvents txb_congsuatkhoiluong As IntTextBox
    Friend WithEvents txb_diachi As TextBox
    Friend WithEvents txb_ten As TextBox
    Friend WithEvents txb_ma As TextBox
    Friend WithEvents btn_luu As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_them As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_dong As Button
    Friend WithEvents btn_capnhat As Button
    Friend WithEvents cmb_thuocdonvi As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
End Class
