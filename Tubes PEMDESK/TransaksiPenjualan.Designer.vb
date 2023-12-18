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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kasir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Invoice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer"
        '
        'tbNamaKasir
        '
        Me.tbNamaKasir.Location = New System.Drawing.Point(26, 90)
        Me.tbNamaKasir.Name = "tbNamaKasir"
        Me.tbNamaKasir.ReadOnly = True
        Me.tbNamaKasir.Size = New System.Drawing.Size(139, 20)
        Me.tbNamaKasir.TabIndex = 4
        '
        'tbInvoice
        '
        Me.tbInvoice.Location = New System.Drawing.Point(195, 90)
        Me.tbInvoice.Name = "tbInvoice"
        Me.tbInvoice.ReadOnly = True
        Me.tbInvoice.Size = New System.Drawing.Size(141, 20)
        Me.tbInvoice.TabIndex = 5
        '
        'tbDate
        '
        Me.tbDate.Location = New System.Drawing.Point(368, 91)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(128, 20)
        Me.tbDate.TabIndex = 6
        '
        'cbMember
        '
        Me.cbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMember.FormattingEnabled = True
        Me.cbMember.Items.AddRange(New Object() {"Member", "Non-Member"})
        Me.cbMember.Location = New System.Drawing.Point(521, 90)
        Me.cbMember.Name = "cbMember"
        Me.cbMember.Size = New System.Drawing.Size(121, 21)
        Me.cbMember.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Produk"
        '
        'cbProduk
        '
        Me.cbProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduk.FormattingEnabled = True
        Me.cbProduk.Location = New System.Drawing.Point(29, 160)
        Me.cbProduk.Name = "cbProduk"
        Me.cbProduk.Size = New System.Drawing.Size(121, 21)
        Me.cbProduk.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(249, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Transaksi Penjualan"
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(32, 216)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.ReadOnly = True
        Me.tbHarga.Size = New System.Drawing.Size(118, 20)
        Me.tbHarga.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Jumlah"
        '
        'tbJumlah
        '
        Me.tbJumlah.Location = New System.Drawing.Point(32, 271)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(118, 20)
        Me.tbJumlah.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Total"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(33, 340)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(118, 20)
        Me.tbTotal.TabIndex = 16
        '
        'btTambah
        '
        Me.btTambah.Location = New System.Drawing.Point(33, 378)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(118, 23)
        Me.btTambah.TabIndex = 17
        Me.btTambah.Text = "Tambahkan"
        Me.btTambah.UseVisualStyleBackColor = True
        '
        'dgvPenjualan
        '
        Me.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_invoice, Me.NamaBarang, Me.Harga, Me.Jumlah, Me.Total, Me.btRemove})
        Me.dgvPenjualan.Location = New System.Drawing.Point(175, 144)
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
        Me.Label10.Location = New System.Drawing.Point(192, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Subtotal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(192, 347)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Diskon"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(192, 382)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Grand Total"
        '
        'tbSubtotal
        '
        Me.tbSubtotal.Location = New System.Drawing.Point(290, 309)
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.ReadOnly = True
        Me.tbSubtotal.Size = New System.Drawing.Size(132, 20)
        Me.tbSubtotal.TabIndex = 22
        '
        'tbDiskon
        '
        Me.tbDiskon.Location = New System.Drawing.Point(290, 343)
        Me.tbDiskon.Name = "tbDiskon"
        Me.tbDiskon.Size = New System.Drawing.Size(132, 20)
        Me.tbDiskon.TabIndex = 23
        '
        'tbGrand
        '
        Me.tbGrand.Location = New System.Drawing.Point(290, 377)
        Me.tbGrand.Name = "tbGrand"
        Me.tbGrand.ReadOnly = True
        Me.tbGrand.Size = New System.Drawing.Size(132, 20)
        Me.tbGrand.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(428, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "%"
        '
        'btSelesai
        '
        Me.btSelesai.Location = New System.Drawing.Point(575, 363)
        Me.btSelesai.Name = "btSelesai"
        Me.btSelesai.Size = New System.Drawing.Size(113, 32)
        Me.btSelesai.TabIndex = 26
        Me.btSelesai.Text = "Buat Transaksi"
        Me.btSelesai.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Location = New System.Drawing.Point(486, 363)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(83, 32)
        Me.btBack.TabIndex = 27
        Me.btBack.Text = "Back"
        Me.btBack.UseVisualStyleBackColor = True
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
        Me.ClientSize = New System.Drawing.Size(734, 413)
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
        Me.Name = "TransaksiPenjualan"
        Me.Text = "TransaksiPenjualan"
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
