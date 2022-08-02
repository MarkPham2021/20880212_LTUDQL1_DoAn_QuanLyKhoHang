<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DangNhap
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txb_matkhau = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_dongy = New System.Windows.Forms.Button()
        Me.btn_huy = New System.Windows.Forms.Button()
        Me.txb_tendangnhap = New System.Windows.Forms.TextBox()
        Me.btn_dangky = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txb_matkhau)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_dongy)
        Me.Panel1.Controls.Add(Me.btn_huy)
        Me.Panel1.Controls.Add(Me.txb_tendangnhap)
        Me.Panel1.Controls.Add(Me.btn_dangky)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1482, 903)
        Me.Panel1.TabIndex = 1
        '
        'txb_matkhau
        '
        Me.txb_matkhau.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_matkhau.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_matkhau.Location = New System.Drawing.Point(474, 146)
        Me.txb_matkhau.Name = "txb_matkhau"
        Me.txb_matkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txb_matkhau.Size = New System.Drawing.Size(382, 31)
        Me.txb_matkhau.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(540, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đăng Nhập Hệ thống"
        '
        'btn_dongy
        '
        Me.btn_dongy.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dongy.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_dongy.Location = New System.Drawing.Point(463, 229)
        Me.btn_dongy.Name = "btn_dongy"
        Me.btn_dongy.Size = New System.Drawing.Size(186, 39)
        Me.btn_dongy.TabIndex = 3
        Me.btn_dongy.Text = "Đồng ý"
        Me.btn_dongy.UseVisualStyleBackColor = True
        '
        'btn_huy
        '
        Me.btn_huy.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_huy.ForeColor = System.Drawing.Color.Orange
        Me.btn_huy.Location = New System.Drawing.Point(655, 229)
        Me.btn_huy.Name = "btn_huy"
        Me.btn_huy.Size = New System.Drawing.Size(200, 39)
        Me.btn_huy.TabIndex = 4
        Me.btn_huy.Text = "Hủy"
        Me.btn_huy.UseVisualStyleBackColor = True
        '
        'txb_tendangnhap
        '
        Me.txb_tendangnhap.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tendangnhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_tendangnhap.Location = New System.Drawing.Point(473, 106)
        Me.txb_tendangnhap.Name = "txb_tendangnhap"
        Me.txb_tendangnhap.Size = New System.Drawing.Size(382, 31)
        Me.txb_tendangnhap.TabIndex = 1
        '
        'btn_dangky
        '
        Me.btn_dangky.Font = New System.Drawing.Font("Segoe UI Semibold", 13.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_dangky.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_dangky.Location = New System.Drawing.Point(463, 274)
        Me.btn_dangky.Name = "btn_dangky"
        Me.btn_dangky.Size = New System.Drawing.Size(392, 39)
        Me.btn_dangky.TabIndex = 5
        Me.btn_dangky.Text = "Chưa có tài khoản? => Đăng ký"
        Me.btn_dangky.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(334, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 25)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Tên đăng nhập:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(334, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Mật khẩu:"
        '
        'Frm_DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 903)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_DangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm_DangNhap"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txb_matkhau As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_dongy As Button
    Friend WithEvents btn_huy As Button
    Friend WithEvents txb_tendangnhap As TextBox
    Friend WithEvents btn_dangky As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
End Class
