<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembayaran
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
        Me.tbInvoice = New System.Windows.Forms.TextBox()
        Me.tbMember = New System.Windows.Forms.TextBox()
        Me.dgvPembelian = New System.Windows.Forms.DataGridView()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbGrand = New System.Windows.Forms.TextBox()
        Me.cbMethod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbBayar = New System.Windows.Forms.TextBox()
        Me.tbKembali = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(194, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Invoice"
        '
        'tbInvoice
        '
        Me.tbInvoice.Location = New System.Drawing.Point(194, 71)
        Me.tbInvoice.Name = "tbInvoice"
        Me.tbInvoice.ReadOnly = True
        Me.tbInvoice.Size = New System.Drawing.Size(100, 20)
        Me.tbInvoice.TabIndex = 2
        '
        'tbMember
        '
        Me.tbMember.Location = New System.Drawing.Point(59, 71)
        Me.tbMember.Name = "tbMember"
        Me.tbMember.ReadOnly = True
        Me.tbMember.Size = New System.Drawing.Size(100, 20)
        Me.tbMember.TabIndex = 3
        '
        'dgvPembelian
        '
        Me.dgvPembelian.BackgroundColor = System.Drawing.Color.Pink
        Me.dgvPembelian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_barang, Me.harga, Me.Jumlah, Me.total})
        Me.dgvPembelian.GridColor = System.Drawing.Color.PaleVioletRed
        Me.dgvPembelian.Location = New System.Drawing.Point(59, 121)
        Me.dgvPembelian.Name = "dgvPembelian"
        Me.dgvPembelian.Size = New System.Drawing.Size(441, 218)
        Me.dgvPembelian.TabIndex = 4
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(320, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grand Total"
        '
        'tbGrand
        '
        Me.tbGrand.Location = New System.Drawing.Point(320, 71)
        Me.tbGrand.Name = "tbGrand"
        Me.tbGrand.Size = New System.Drawing.Size(100, 20)
        Me.tbGrand.TabIndex = 6
        '
        'cbMethod
        '
        Me.cbMethod.FormattingEnabled = True
        Me.cbMethod.Items.AddRange(New Object() {"Cash", "Card", "QRIS"})
        Me.cbMethod.Location = New System.Drawing.Point(544, 144)
        Me.cbMethod.Name = "cbMethod"
        Me.cbMethod.Size = New System.Drawing.Size(100, 21)
        Me.cbMethod.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(544, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pembayaran"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(544, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jumlah Bayar"
        '
        'tbBayar
        '
        Me.tbBayar.Location = New System.Drawing.Point(544, 214)
        Me.tbBayar.Name = "tbBayar"
        Me.tbBayar.Size = New System.Drawing.Size(100, 20)
        Me.tbBayar.TabIndex = 10
        '
        'tbKembali
        '
        Me.tbKembali.Location = New System.Drawing.Point(544, 283)
        Me.tbKembali.Name = "tbKembali"
        Me.tbKembali.ReadOnly = True
        Me.tbKembali.Size = New System.Drawing.Size(100, 20)
        Me.tbKembali.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(544, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Kembalian"
        '
        'btSimpan
        '
        Me.btSimpan.BackgroundImage = Global.Tubes_PEMDESK.My.Resources.Resources.hot_pink_gradient_7cbldqv6xt26lme0
        Me.btSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSimpan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSimpan.ForeColor = System.Drawing.Color.White
        Me.btSimpan.Location = New System.Drawing.Point(544, 321)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(100, 22)
        Me.btSimpan.TabIndex = 13
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Tubes_PEMDESK.My.Resources.Resources.download__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(726, 413)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbKembali)
        Me.Controls.Add(Me.tbBayar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbMethod)
        Me.Controls.Add(Me.tbGrand)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvPembelian)
        Me.Controls.Add(Me.tbMember)
        Me.Controls.Add(Me.tbInvoice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pembayaran"
        Me.Text = "Pembayaran"
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbInvoice As TextBox
    Friend WithEvents tbMember As TextBox
    Friend WithEvents dgvPembelian As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents tbGrand As TextBox
    Friend WithEvents cbMethod As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbBayar As TextBox
    Friend WithEvents tbKembali As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btSimpan As Button
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
