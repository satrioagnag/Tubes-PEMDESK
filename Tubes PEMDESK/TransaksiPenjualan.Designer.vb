<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiPenjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransaksiPenjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNamaKasir = New System.Windows.Forms.TextBox()
        Me.tbInvoice = New System.Windows.Forms.TextBox()
        Me.tbDate = New System.Windows.Forms.TextBox()
        Me.cbMember = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbProduk = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbJumlah = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.dgvPenjualan = New System.Windows.Forms.DataGridView()
        Me.no_invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btRemove = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbSubtotal = New System.Windows.Forms.TextBox()
        Me.tbDiskon = New System.Windows.Forms.TextBox()
        Me.tbGrand = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btSelesai = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kasir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(200, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Invoice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(373, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(526, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer"
        '
        'tbNamaKasir
        '
        Me.tbNamaKasir.Location = New System.Drawing.Point(31, 119)
        Me.tbNamaKasir.Name = "tbNamaKasir"
        Me.tbNamaKasir.ReadOnly = True
        Me.tbNamaKasir.Size = New System.Drawing.Size(139, 20)
        Me.tbNamaKasir.TabIndex = 4
        '
        'tbInvoice
        '
        Me.tbInvoice.Location = New System.Drawing.Point(200, 119)
        Me.tbInvoice.Name = "tbInvoice"
        Me.tbInvoice.ReadOnly = True
        Me.tbInvoice.Size = New System.Drawing.Size(141, 20)
        Me.tbInvoice.TabIndex = 5
        '
        'tbDate
        '
        Me.tbDate.Location = New System.Drawing.Point(373, 120)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(128, 20)
        Me.tbDate.TabIndex = 6
        '
        'cbMember
        '
        Me.cbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMember.FormattingEnabled = True
        Me.cbMember.Items.AddRange(New Object() {"Member", "Non-Member"})
        Me.cbMember.Location = New System.Drawing.Point(526, 119)
        Me.cbMember.Name = "cbMember"
        Me.cbMember.Size = New System.Drawing.Size(121, 21)
        Me.cbMember.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(34, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Produk"
        '
        'cbProduk
        '
        Me.cbProduk.BackColor = System.Drawing.Color.Pink
        Me.cbProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduk.FormattingEnabled = True
        Me.cbProduk.Location = New System.Drawing.Point(34, 189)
        Me.cbProduk.Name = "cbProduk"
        Me.cbProduk.Size = New System.Drawing.Size(121, 21)
        Me.cbProduk.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(34, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(246, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 30)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Transaksi Penjualan"
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(37, 245)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.ReadOnly = True
        Me.tbHarga.Size = New System.Drawing.Size(118, 20)
        Me.tbHarga.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(35, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Jumlah"
        '
        'tbJumlah
        '
        Me.tbJumlah.Location = New System.Drawing.Point(37, 300)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(118, 20)
        Me.tbJumlah.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(35, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Total"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(38, 369)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(118, 20)
        Me.tbTotal.TabIndex = 16
        '
        'btTambah
        '
        Me.btTambah.BackgroundImage = CType(resources.GetObject("btTambah.BackgroundImage"), System.Drawing.Image)
        Me.btTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btTambah.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTambah.ForeColor = System.Drawing.Color.White
        Me.btTambah.Location = New System.Drawing.Point(38, 407)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(118, 23)
        Me.btTambah.TabIndex = 17
        Me.btTambah.Text = "Tambahkan"
        Me.btTambah.UseVisualStyleBackColor = True
        '
        'dgvPenjualan
        '
        Me.dgvPenjualan.BackgroundColor = System.Drawing.Color.Pink
        Me.dgvPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_invoice, Me.NamaBarang, Me.Harga, Me.Jumlah, Me.Total, Me.btRemove})
        Me.dgvPenjualan.GridColor = System.Drawing.Color.PaleVioletRed
        Me.dgvPenjualan.Location = New System.Drawing.Point(180, 173)
        Me.dgvPenjualan.Name = "dgvPenjualan"
        Me.dgvPenjualan.Size = New System.Drawing.Size(513, 150)
        Me.dgvPenjualan.TabIndex = 18
        '
        'no_invoice
        '
        Me.no_invoice.HeaderText = "No Invoice"
        Me.no_invoice.Name = "no_invoice"
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
        'btRemove
        '
        Me.btRemove.HeaderText = ""
        Me.btRemove.Name = "btRemove"
        Me.btRemove.Text = "Remove"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(197, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Subtotal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(197, 376)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Diskon"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(197, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Grand Total"
        '
        'tbSubtotal
        '
        Me.tbSubtotal.Location = New System.Drawing.Point(295, 338)
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.ReadOnly = True
        Me.tbSubtotal.Size = New System.Drawing.Size(132, 20)
        Me.tbSubtotal.TabIndex = 22
        '
        'tbDiskon
        '
        Me.tbDiskon.Location = New System.Drawing.Point(295, 372)
        Me.tbDiskon.Name = "tbDiskon"
        Me.tbDiskon.Size = New System.Drawing.Size(132, 20)
        Me.tbDiskon.TabIndex = 23
        '
        'tbGrand
        '
        Me.tbGrand.Location = New System.Drawing.Point(295, 406)
        Me.tbGrand.Name = "tbGrand"
        Me.tbGrand.ReadOnly = True
        Me.tbGrand.Size = New System.Drawing.Size(132, 20)
        Me.tbGrand.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(433, 376)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 15)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "%"
        '
        'btSelesai
        '
        Me.btSelesai.BackgroundImage = CType(resources.GetObject("btSelesai.BackgroundImage"), System.Drawing.Image)
        Me.btSelesai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSelesai.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSelesai.ForeColor = System.Drawing.Color.White
        Me.btSelesai.Location = New System.Drawing.Point(580, 392)
        Me.btSelesai.Name = "btSelesai"
        Me.btSelesai.Size = New System.Drawing.Size(113, 32)
        Me.btSelesai.TabIndex = 26
        Me.btSelesai.Text = "Buat Transaksi"
        Me.btSelesai.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.BackColor = System.Drawing.Color.Red
        Me.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btBack.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBack.ForeColor = System.Drawing.Color.White
        Me.btBack.Location = New System.Drawing.Point(491, 392)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(83, 32)
        Me.btBack.TabIndex = 27
        Me.btBack.Text = "Back"
        Me.btBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Tubes_PEMDESK.My.Resources.Resources.vira_collection__900_x_500_piksel_
        Me.PictureBox2.Location = New System.Drawing.Point(162, -38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(425, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Tubes_PEMDESK.My.Resources.Resources.download__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 472)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.btSelesai)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbGrand)
        Me.Controls.Add(Me.tbDiskon)
        Me.Controls.Add(Me.tbSubtotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvPenjualan)
        Me.Controls.Add(Me.btTambah)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbJumlah)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbHarga)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbProduk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbMember)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.tbInvoice)
        Me.Controls.Add(Me.tbNamaKasir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "TransaksiPenjualan"
        Me.Text = "TransaksiPenjualan"
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNamaKasir As TextBox
    Friend WithEvents tbInvoice As TextBox
    Friend WithEvents tbDate As TextBox
    Friend WithEvents cbMember As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbProduk As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbJumlah As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents btTambah As Button
    Friend WithEvents dgvPenjualan As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbSubtotal As TextBox
    Friend WithEvents tbDiskon As TextBox
    Friend WithEvents tbGrand As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btSelesai As Button
    Friend WithEvents no_invoice As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents btRemove As DataGridViewButtonColumn
    Friend WithEvents btBack As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
