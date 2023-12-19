<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginKasir
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_date = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.tbPenjualan = New System.Windows.Forms.TextBox()
        Me.tbDate = New System.Windows.Forms.TextBox()
        Me.dgvPenjualanToday = New System.Windows.Forms.DataGridView()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.bt_logout = New System.Windows.Forms.Button()
        Me.lb_Nama = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvPenjualanToday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 6
        '
        'lb_date
        '
        Me.lb_date.AutoSize = True
        Me.lb_date.BackColor = System.Drawing.Color.Transparent
        Me.lb_date.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_date.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lb_date.Location = New System.Drawing.Point(270, 42)
        Me.lb_date.Name = "lb_date"
        Me.lb_date.Size = New System.Drawing.Size(48, 23)
        Me.lb_date.TabIndex = 11
        Me.lb_date.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label3.Location = New System.Drawing.Point(270, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Customer "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label4.Location = New System.Drawing.Point(270, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Penjualan  Rp"
        '
        'tbCustomer
        '
        Me.tbCustomer.Location = New System.Drawing.Point(404, 81)
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.ReadOnly = True
        Me.tbCustomer.Size = New System.Drawing.Size(184, 20)
        Me.tbCustomer.TabIndex = 14
        '
        'tbPenjualan
        '
        Me.tbPenjualan.Location = New System.Drawing.Point(404, 119)
        Me.tbPenjualan.Name = "tbPenjualan"
        Me.tbPenjualan.ReadOnly = True
        Me.tbPenjualan.Size = New System.Drawing.Size(184, 20)
        Me.tbPenjualan.TabIndex = 15
        '
        'tbDate
        '
        Me.tbDate.Location = New System.Drawing.Point(404, 43)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.ReadOnly = True
        Me.tbDate.Size = New System.Drawing.Size(184, 20)
        Me.tbDate.TabIndex = 16
        '
        'dgvPenjualanToday
        '
        Me.dgvPenjualanToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenjualanToday.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaBarang, Me.Harga, Me.Jumlah, Me.Total})
        Me.dgvPenjualanToday.Location = New System.Drawing.Point(273, 172)
        Me.dgvPenjualanToday.Name = "dgvPenjualanToday"
        Me.dgvPenjualanToday.Size = New System.Drawing.Size(421, 150)
        Me.dgvPenjualanToday.TabIndex = 17
        '
        'NamaBarang
        '
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.Name = "NamaBarang"
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackColor = System.Drawing.Color.DeepPink
        Me.btnTransaksi.BackgroundImage = Global.Tubes_PEMDESK.My.Resources.Resources.hot_pink_gradient_7cbldqv6xt26lme0
        Me.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTransaksi.Location = New System.Drawing.Point(25, 249)
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(196, 31)
        Me.btnTransaksi.TabIndex = 7
        Me.btnTransaksi.Text = "Transaksi Penjualan"
        Me.btnTransaksi.UseVisualStyleBackColor = False
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.Red
        Me.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_logout.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bt_logout.Location = New System.Drawing.Point(25, 359)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(75, 23)
        Me.bt_logout.TabIndex = 10
        Me.bt_logout.Text = "Logout"
        Me.bt_logout.UseVisualStyleBackColor = False
        '
        'lb_Nama
        '
        Me.lb_Nama.AutoSize = True
        Me.lb_Nama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nama.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lb_Nama.Location = New System.Drawing.Point(89, 65)
        Me.lb_Nama.Name = "lb_Nama"
        Me.lb_Nama.Size = New System.Drawing.Size(68, 15)
        Me.lb_Nama.TabIndex = 10
        Me.lb_Nama.Text = "Nama Kasir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LavenderBlush
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lb_Nama)
        Me.Panel1.Controls.Add(Me.bt_logout)
        Me.Panel1.Controls.Add(Me.btnTransaksi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 413)
        Me.Panel1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label5.Location = New System.Drawing.Point(71, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 36)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "KASIR"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Tubes_PEMDESK.My.Resources.Resources.Desain_tanpa_judul__22_
        Me.PictureBox1.Location = New System.Drawing.Point(53, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Tubes_PEMDESK.My.Resources.Resources.vira_collection__900_x_500_piksel_
        Me.PictureBox2.Location = New System.Drawing.Point(269, 299)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(425, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = Global.Tubes_PEMDESK.My.Resources.Resources.vira_collection
        Me.PictureBox3.Location = New System.Drawing.Point(560, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(182, 166)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 59
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.UseWaitCursor = True
        '
        'LoginKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.BackgroundImage = Global.Tubes_PEMDESK.My.Resources.Resources.download__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(726, 413)
        Me.Controls.Add(Me.dgvPenjualanToday)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.tbPenjualan)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "LoginKasir"
        Me.Text = "LoginKasir"
        CType(Me.dgvPenjualanToday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_date As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCustomer As TextBox
    Friend WithEvents tbPenjualan As TextBox
    Friend WithEvents tbDate As TextBox
    Friend WithEvents dgvPenjualanToday As DataGridView
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents bt_logout As Button
    Friend WithEvents lb_Nama As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
