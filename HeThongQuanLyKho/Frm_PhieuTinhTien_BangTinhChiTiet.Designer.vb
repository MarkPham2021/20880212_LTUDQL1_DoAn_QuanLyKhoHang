<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PhieuTinhTien_BangTinhChiTiet
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel_Thongtinphieutinhtien = New System.Windows.Forms.Panel()
        Me.btn_dong = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txb_tongthanhtien = New System.Windows.Forms.TextBox()
        Me.lbl_tieudeform = New System.Windows.Forms.Label()
        Me.txb_denngay = New System.Windows.Forms.TextBox()
        Me.txb_tenkhachhang = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txb_ma = New System.Windows.Forms.TextBox()
        Me.txb_tungay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txb_mahopdong = New System.Windows.Forms.TextBox()
        Me.Panel_dgvCTHopDong = New System.Windows.Forms.Panel()
        Me.dgvDsCTTinhTien = New System.Windows.Forms.DataGridView()
        Me.Panel_BangTinh = New System.Windows.Forms.Panel()
        Me.dgvBangTinhChiTiet = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel_Thongtinphieutinhtien.SuspendLayout()
        Me.Panel_dgvCTHopDong.SuspendLayout()
        CType(Me.dgvDsCTTinhTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_BangTinh.SuspendLayout()
        CType(Me.dgvBangTinhChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_BangTinh)
        Me.SplitContainer1.Size = New System.Drawing.Size(1482, 908)
        Me.SplitContainer1.SplitterDistance = 626
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel_Thongtinphieutinhtien)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel_dgvCTHopDong)
        Me.SplitContainer2.Size = New System.Drawing.Size(626, 908)
        Me.SplitContainer2.SplitterDistance = 293
        Me.SplitContainer2.TabIndex = 112
        '
        'Panel_Thongtinphieutinhtien
        '
        Me.Panel_Thongtinphieutinhtien.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel_Thongtinphieutinhtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.btn_dong)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.Label1)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.txb_tongthanhtien)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.lbl_tieudeform)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.txb_denngay)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.txb_tenkhachhang)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.Label18)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.txb_ma)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.txb_tungay)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.Label6)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.Label13)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.Label5)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.Label9)
        Me.Panel_Thongtinphieutinhtien.Controls.Add(Me.txb_mahopdong)
        Me.Panel_Thongtinphieutinhtien.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_Thongtinphieutinhtien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Thongtinphieutinhtien.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Thongtinphieutinhtien.Name = "Panel_Thongtinphieutinhtien"
        Me.Panel_Thongtinphieutinhtien.Size = New System.Drawing.Size(622, 289)
        Me.Panel_Thongtinphieutinhtien.TabIndex = 111
        '
        'btn_dong
        '
        Me.btn_dong.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_dong.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dong.ForeColor = System.Drawing.Color.Orange
        Me.btn_dong.Location = New System.Drawing.Point(153, 241)
        Me.btn_dong.Name = "btn_dong"
        Me.btn_dong.Size = New System.Drawing.Size(271, 38)
        Me.btn_dong.TabIndex = 112
        Me.btn_dong.Text = "Đóng màn hình"
        Me.btn_dong.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(25, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Tổng thành tiền:"
        '
        'txb_tongthanhtien
        '
        Me.txb_tongthanhtien.BackColor = System.Drawing.Color.White
        Me.txb_tongthanhtien.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tongthanhtien.ForeColor = System.Drawing.Color.DarkViolet
        Me.txb_tongthanhtien.Location = New System.Drawing.Point(173, 202)
        Me.txb_tongthanhtien.Name = "txb_tongthanhtien"
        Me.txb_tongthanhtien.ReadOnly = True
        Me.txb_tongthanhtien.Size = New System.Drawing.Size(439, 27)
        Me.txb_tongthanhtien.TabIndex = 110
        Me.txb_tongthanhtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_tieudeform
        '
        Me.lbl_tieudeform.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_tieudeform.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_tieudeform.ForeColor = System.Drawing.Color.Red
        Me.lbl_tieudeform.Location = New System.Drawing.Point(38, 9)
        Me.lbl_tieudeform.Name = "lbl_tieudeform"
        Me.lbl_tieudeform.Size = New System.Drawing.Size(552, 36)
        Me.lbl_tieudeform.TabIndex = 109
        Me.lbl_tieudeform.Text = "Phiếu Tính Tiền _ Bảng tính chi tiết"
        '
        'txb_denngay
        '
        Me.txb_denngay.BackColor = System.Drawing.Color.White
        Me.txb_denngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_denngay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_denngay.Location = New System.Drawing.Point(441, 164)
        Me.txb_denngay.Name = "txb_denngay"
        Me.txb_denngay.ReadOnly = True
        Me.txb_denngay.Size = New System.Drawing.Size(171, 27)
        Me.txb_denngay.TabIndex = 106
        Me.txb_denngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txb_tenkhachhang
        '
        Me.txb_tenkhachhang.BackColor = System.Drawing.Color.White
        Me.txb_tenkhachhang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tenkhachhang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_tenkhachhang.Location = New System.Drawing.Point(38, 131)
        Me.txb_tenkhachhang.Name = "txb_tenkhachhang"
        Me.txb_tenkhachhang.ReadOnly = True
        Me.txb_tenkhachhang.Size = New System.Drawing.Size(574, 27)
        Me.txb_tenkhachhang.TabIndex = 100
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(334, 164)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 25)
        Me.Label18.TabIndex = 108
        Me.Label18.Text = "đến ngày:"
        '
        'txb_ma
        '
        Me.txb_ma.BackColor = System.Drawing.Color.White
        Me.txb_ma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_ma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ma.Location = New System.Drawing.Point(120, 69)
        Me.txb_ma.Name = "txb_ma"
        Me.txb_ma.ReadOnly = True
        Me.txb_ma.Size = New System.Drawing.Size(166, 27)
        Me.txb_ma.TabIndex = 99
        Me.txb_ma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txb_tungay
        '
        Me.txb_tungay.BackColor = System.Drawing.Color.White
        Me.txb_tungay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_tungay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_tungay.Location = New System.Drawing.Point(120, 162)
        Me.txb_tungay.Name = "txb_tungay"
        Me.txb_tungay.ReadOnly = True
        Me.txb_tungay.Size = New System.Drawing.Size(166, 27)
        Me.txb_tungay.TabIndex = 105
        Me.txb_tungay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(25, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 25)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Tên khách hàng:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(25, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 25)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Từ ngày:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(25, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 25)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Mã phiếu:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(293, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 25)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Mã hợp đồng:"
        '
        'txb_mahopdong
        '
        Me.txb_mahopdong.BackColor = System.Drawing.Color.White
        Me.txb_mahopdong.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txb_mahopdong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_mahopdong.Location = New System.Drawing.Point(441, 69)
        Me.txb_mahopdong.Name = "txb_mahopdong"
        Me.txb_mahopdong.ReadOnly = True
        Me.txb_mahopdong.Size = New System.Drawing.Size(171, 27)
        Me.txb_mahopdong.TabIndex = 103
        Me.txb_mahopdong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel_dgvCTHopDong
        '
        Me.Panel_dgvCTHopDong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_dgvCTHopDong.Controls.Add(Me.dgvDsCTTinhTien)
        Me.Panel_dgvCTHopDong.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_dgvCTHopDong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_dgvCTHopDong.Location = New System.Drawing.Point(0, 0)
        Me.Panel_dgvCTHopDong.Name = "Panel_dgvCTHopDong"
        Me.Panel_dgvCTHopDong.Size = New System.Drawing.Size(622, 607)
        Me.Panel_dgvCTHopDong.TabIndex = 110
        '
        'dgvDsCTTinhTien
        '
        Me.dgvDsCTTinhTien.AllowUserToAddRows = False
        Me.dgvDsCTTinhTien.AllowUserToDeleteRows = False
        Me.dgvDsCTTinhTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDsCTTinhTien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDsCTTinhTien.Location = New System.Drawing.Point(0, 0)
        Me.dgvDsCTTinhTien.Name = "dgvDsCTTinhTien"
        Me.dgvDsCTTinhTien.ReadOnly = True
        Me.dgvDsCTTinhTien.RowHeadersWidth = 51
        Me.dgvDsCTTinhTien.RowTemplate.Height = 29
        Me.dgvDsCTTinhTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDsCTTinhTien.Size = New System.Drawing.Size(618, 603)
        Me.dgvDsCTTinhTien.TabIndex = 0
        '
        'Panel_BangTinh
        '
        Me.Panel_BangTinh.Controls.Add(Me.dgvBangTinhChiTiet)
        Me.Panel_BangTinh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_BangTinh.Location = New System.Drawing.Point(0, 0)
        Me.Panel_BangTinh.Name = "Panel_BangTinh"
        Me.Panel_BangTinh.Size = New System.Drawing.Size(852, 908)
        Me.Panel_BangTinh.TabIndex = 0
        '
        'dgvBangTinhChiTiet
        '
        Me.dgvBangTinhChiTiet.AllowDrop = True
        Me.dgvBangTinhChiTiet.AllowUserToAddRows = False
        Me.dgvBangTinhChiTiet.AllowUserToDeleteRows = False
        Me.dgvBangTinhChiTiet.AllowUserToOrderColumns = True
        Me.dgvBangTinhChiTiet.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvBangTinhChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBangTinhChiTiet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvBangTinhChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBangTinhChiTiet.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvBangTinhChiTiet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBangTinhChiTiet.GridColor = System.Drawing.Color.White
        Me.dgvBangTinhChiTiet.Location = New System.Drawing.Point(0, 0)
        Me.dgvBangTinhChiTiet.Name = "dgvBangTinhChiTiet"
        Me.dgvBangTinhChiTiet.RowHeadersWidth = 51
        Me.dgvBangTinhChiTiet.RowTemplate.Height = 29
        Me.dgvBangTinhChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBangTinhChiTiet.Size = New System.Drawing.Size(852, 908)
        Me.dgvBangTinhChiTiet.TabIndex = 1
        '
        'Frm_PhieuTinhTien_BangTinhChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 908)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_PhieuTinhTien_BangTinhChiTiet"
        Me.Text = "Frm_PhieuTinhTien_BangTinhChiTiet"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel_Thongtinphieutinhtien.ResumeLayout(False)
        Me.Panel_Thongtinphieutinhtien.PerformLayout()
        Me.Panel_dgvCTHopDong.ResumeLayout(False)
        CType(Me.dgvDsCTTinhTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_BangTinh.ResumeLayout(False)
        CType(Me.dgvBangTinhChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel_BangTinh As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txb_mahopdong As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txb_ma As TextBox
    Friend WithEvents txb_tenkhachhang As TextBox
    Friend WithEvents txb_denngay As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txb_tungay As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_tieudeform As Label
    Friend WithEvents dgvBangTinhChiTiet As DataGridView
    Friend WithEvents Panel_Thongtinphieutinhtien As Panel
    Friend WithEvents Panel_dgvCTHopDong As Panel
    Friend WithEvents dgvDsCTTinhTien As DataGridView
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents txb_tongthanhtien As TextBox
    Friend WithEvents btn_dong As Button
End Class
