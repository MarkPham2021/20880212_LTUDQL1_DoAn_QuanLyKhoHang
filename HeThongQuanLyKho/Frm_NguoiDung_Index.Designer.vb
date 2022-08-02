<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_NguoiDung_Index
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
        Me.dgwdsnguoidung = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txb_noidungtim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_dong = New System.Windows.Forms.Button()
        Me.lbl_ma = New System.Windows.Forms.Label()
        Me.btn_datlaimatkhau = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_khoa = New System.Windows.Forms.Button()
        Me.btn_kichhoat = New System.Windows.Forms.Button()
        Me.chb_daxoa = New System.Windows.Forms.CheckBox()
        Me.chb_dakichhoat = New System.Windows.Forms.CheckBox()
        Me.lbl_nd_tendangnhap = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_dienthoai = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_lnd_ten = New System.Windows.Forms.Label()
        Me.lbl_tendonvi = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_hoten = New System.Windows.Forms.Label()
        Me.lbl_manhanvien = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgwdsnguoidung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_dong)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_ma)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_datlaimatkhau)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_xoa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_khoa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_kichhoat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chb_daxoa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chb_dakichhoat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_nd_tendangnhap)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_email)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_dienthoai)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_lnd_ten)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_tendonvi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_hoten)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_manhanvien)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Size = New System.Drawing.Size(1482, 903)
        Me.SplitContainer1.SplitterDistance = 790
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgwdsnguoidung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 823)
        Me.Panel2.TabIndex = 2
        '
        'dgwdsnguoidung
        '
        Me.dgwdsnguoidung.AllowDrop = True
        Me.dgwdsnguoidung.AllowUserToAddRows = False
        Me.dgwdsnguoidung.AllowUserToDeleteRows = False
        Me.dgwdsnguoidung.AllowUserToOrderColumns = True
        Me.dgwdsnguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwdsnguoidung.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgwdsnguoidung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwdsnguoidung.Location = New System.Drawing.Point(0, 0)
        Me.dgwdsnguoidung.Name = "dgwdsnguoidung"
        Me.dgwdsnguoidung.RowHeadersWidth = 51
        Me.dgwdsnguoidung.RowTemplate.Height = 29
        Me.dgwdsnguoidung.Size = New System.Drawing.Size(790, 823)
        Me.dgwdsnguoidung.TabIndex = 0
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
        Me.Panel1.Size = New System.Drawing.Size(790, 80)
        Me.Panel1.TabIndex = 1
        '
        'txb_noidungtim
        '
        Me.txb_noidungtim.Cursor = System.Windows.Forms.Cursors.Default
        Me.txb_noidungtim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txb_noidungtim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_noidungtim.ForeColor = System.Drawing.Color.Blue
        Me.txb_noidungtim.Location = New System.Drawing.Point(0, 46)
        Me.txb_noidungtim.Name = "txb_noidungtim"
        Me.txb_noidungtim.Size = New System.Drawing.Size(790, 34)
        Me.txb_noidungtim.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quản lý Tài khoản Người dùng"
        '
        'btn_dong
        '
        Me.btn_dong.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dong.ForeColor = System.Drawing.Color.Orange
        Me.btn_dong.Location = New System.Drawing.Point(397, 396)
        Me.btn_dong.Name = "btn_dong"
        Me.btn_dong.Size = New System.Drawing.Size(198, 44)
        Me.btn_dong.TabIndex = 24
        Me.btn_dong.Text = "Đóng màn hình"
        Me.btn_dong.UseVisualStyleBackColor = True
        '
        'lbl_ma
        '
        Me.lbl_ma.AutoSize = True
        Me.lbl_ma.Location = New System.Drawing.Point(55, 467)
        Me.lbl_ma.Name = "lbl_ma"
        Me.lbl_ma.Size = New System.Drawing.Size(114, 20)
        Me.lbl_ma.TabIndex = 23
        Me.lbl_ma.Text = "nd_ma, invisible"
        Me.lbl_ma.Visible = False
        '
        'btn_datlaimatkhau
        '
        Me.btn_datlaimatkhau.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_datlaimatkhau.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_datlaimatkhau.Location = New System.Drawing.Point(42, 396)
        Me.btn_datlaimatkhau.Name = "btn_datlaimatkhau"
        Me.btn_datlaimatkhau.Size = New System.Drawing.Size(354, 44)
        Me.btn_datlaimatkhau.TabIndex = 22
        Me.btn_datlaimatkhau.Text = "Đặt lại mật khẩu"
        Me.btn_datlaimatkhau.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xoa.ForeColor = System.Drawing.Color.Red
        Me.btn_xoa.Location = New System.Drawing.Point(394, 346)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(198, 44)
        Me.btn_xoa.TabIndex = 21
        Me.btn_xoa.Text = "Xóa tài khoản"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_khoa
        '
        Me.btn_khoa.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_khoa.ForeColor = System.Drawing.Color.Orange
        Me.btn_khoa.Location = New System.Drawing.Point(198, 346)
        Me.btn_khoa.Name = "btn_khoa"
        Me.btn_khoa.Size = New System.Drawing.Size(198, 44)
        Me.btn_khoa.TabIndex = 20
        Me.btn_khoa.Text = "Khóa tài khoản"
        Me.btn_khoa.UseVisualStyleBackColor = True
        '
        'btn_kichhoat
        '
        Me.btn_kichhoat.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_kichhoat.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn_kichhoat.Location = New System.Drawing.Point(39, 346)
        Me.btn_kichhoat.Name = "btn_kichhoat"
        Me.btn_kichhoat.Size = New System.Drawing.Size(159, 44)
        Me.btn_kichhoat.TabIndex = 19
        Me.btn_kichhoat.Text = "Kích hoạt"
        Me.btn_kichhoat.UseVisualStyleBackColor = True
        '
        'chb_daxoa
        '
        Me.chb_daxoa.AutoSize = True
        Me.chb_daxoa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chb_daxoa.ForeColor = System.Drawing.Color.Blue
        Me.chb_daxoa.Location = New System.Drawing.Point(253, 291)
        Me.chb_daxoa.Name = "chb_daxoa"
        Me.chb_daxoa.Size = New System.Drawing.Size(94, 32)
        Me.chb_daxoa.TabIndex = 18
        Me.chb_daxoa.Text = "Đã xóa"
        Me.chb_daxoa.UseVisualStyleBackColor = True
        '
        'chb_dakichhoat
        '
        Me.chb_dakichhoat.AutoSize = True
        Me.chb_dakichhoat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chb_dakichhoat.ForeColor = System.Drawing.Color.Blue
        Me.chb_dakichhoat.Location = New System.Drawing.Point(55, 291)
        Me.chb_dakichhoat.Name = "chb_dakichhoat"
        Me.chb_dakichhoat.Size = New System.Drawing.Size(143, 32)
        Me.chb_dakichhoat.TabIndex = 17
        Me.chb_dakichhoat.Text = "Đã kích hoạt"
        Me.chb_dakichhoat.UseVisualStyleBackColor = True
        '
        'lbl_nd_tendangnhap
        '
        Me.lbl_nd_tendangnhap.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nd_tendangnhap.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_nd_tendangnhap.Location = New System.Drawing.Point(223, 239)
        Me.lbl_nd_tendangnhap.Name = "lbl_nd_tendangnhap"
        Me.lbl_nd_tendangnhap.Size = New System.Drawing.Size(189, 28)
        Me.lbl_nd_tendangnhap.TabIndex = 13
        Me.lbl_nd_tendangnhap.Text = "tên đăng nhập"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(42, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 28)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Tên đăng nhập:"
        '
        'lbl_email
        '
        Me.lbl_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_email.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_email.Location = New System.Drawing.Point(418, 147)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(258, 28)
        Me.lbl_email.TabIndex = 11
        Me.lbl_email.Text = "email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(353, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 28)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Email:"
        '
        'lbl_dienthoai
        '
        Me.lbl_dienthoai.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_dienthoai.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_dienthoai.Location = New System.Drawing.Point(165, 147)
        Me.lbl_dienthoai.Name = "lbl_dienthoai"
        Me.lbl_dienthoai.Size = New System.Drawing.Size(126, 28)
        Me.lbl_dienthoai.TabIndex = 9
        Me.lbl_dienthoai.Text = "điện thoại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(42, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Điện thoại:"
        '
        'lbl_lnd_ten
        '
        Me.lbl_lnd_ten.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_lnd_ten.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_lnd_ten.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_lnd_ten.Location = New System.Drawing.Point(198, 191)
        Me.lbl_lnd_ten.Name = "lbl_lnd_ten"
        Me.lbl_lnd_ten.Size = New System.Drawing.Size(448, 28)
        Me.lbl_lnd_ten.TabIndex = 7
        Me.lbl_lnd_ten.Text = "loại tài khoản"
        '
        'lbl_tendonvi
        '
        Me.lbl_tendonvi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_tendonvi.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_tendonvi.Location = New System.Drawing.Point(177, 108)
        Me.lbl_tendonvi.Name = "lbl_tendonvi"
        Me.lbl_tendonvi.Size = New System.Drawing.Size(469, 28)
        Me.lbl_tendonvi.TabIndex = 6
        Me.lbl_tendonvi.Text = "đơn vị"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(42, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Loại tài khoản:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(42, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 28)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Thuộc đơn vị:"
        '
        'lbl_hoten
        '
        Me.lbl_hoten.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_hoten.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_hoten.Location = New System.Drawing.Point(402, 63)
        Me.lbl_hoten.Name = "lbl_hoten"
        Me.lbl_hoten.Size = New System.Drawing.Size(244, 28)
        Me.lbl_hoten.TabIndex = 3
        Me.lbl_hoten.Text = " họ tên"
        '
        'lbl_manhanvien
        '
        Me.lbl_manhanvien.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_manhanvien.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_manhanvien.Location = New System.Drawing.Point(165, 63)
        Me.lbl_manhanvien.Name = "lbl_manhanvien"
        Me.lbl_manhanvien.Size = New System.Drawing.Size(126, 28)
        Me.lbl_manhanvien.TabIndex = 2
        Me.lbl_manhanvien.Text = " mã nhân sự"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(321, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Họ tên:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(42, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã nhân sự:"
        '
        'Frm_NguoiDung_Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 903)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_NguoiDung_Index"
        Me.Text = "Frm_NguoiDung_Index"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgwdsnguoidung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lbl_hoten As Label
    Friend WithEvents lbl_manhanvien As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgwdsnguoidung As DataGridView
    Friend WithEvents lbl_lnd_ten As Label
    Friend WithEvents lbl_tendonvi As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_dienthoai As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_nd_tendangnhap As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents chb_daxoa As CheckBox
    Friend WithEvents chb_dakichhoat As CheckBox
    Friend WithEvents btn_kichhoat As Button
    Friend WithEvents btn_khoa As Button
    Friend WithEvents btn_datlaimatkhau As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents lbl_ma As Label
    Friend WithEvents txb_noidungtim As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_dong As Button
    Friend WithEvents Panel2 As Panel
End Class
