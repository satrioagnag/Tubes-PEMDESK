<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterBarang
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
        Me.tb_totalItem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudStock = New System.Windows.Forms.NumericUpDown()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.id_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btUbah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.rbBawahan = New System.Windows.Forms.RadioButton()
        Me.rbAtasan = New System.Windows.Forms.RadioButton()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RbAcc = New System.Windows.Forms.RadioButton()
        Me.btBack = New System.Windows.Forms.Button()
        Me.btBersihkan = New System.Windows.Forms.Button()
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(289, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Barang"
        '
        'tb_totalItem
        '
        Me.tb_totalItem.Location = New System.Drawing.Point(614, 420)
        Me.tb_totalItem.Name = "tb_totalItem"
        Me.tb_totalItem.Size = New System.Drawing.Size(100, 20)
        Me.tb_totalItem.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(535, 424)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Total Item"
        '
        'nudStock
        '
        Me.nudStock.Location = New System.Drawing.Point(461, 108)
        Me.nudStock.Name = "nudStock"
        Me.nudStock.Size = New System.Drawing.Size(71, 20)
        Me.nudStock.TabIndex = 27
        '
        'dgvBarang
        '
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barang, Me.nama_barang, Me.Harga, Me.Stock, Me.btUbah, Me.btHapus})
        Me.dgvBarang.Location = New System.Drawing.Point(16, 146)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.Size = New System.Drawing.Size(698, 250)
        Me.dgvBarang.TabIndex = 26
        '
        'id_barang
        '
        Me.id_barang.HeaderText = "ID Barang"
        Me.id_barang.Name = "id_barang"
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        '
        'btUbah
        '
        Me.btUbah.HeaderText = ""
        Me.btUbah.Name = "btUbah"
        Me.btUbah.Text = "UBAH"
        Me.btUbah.UseColumnTextForButtonValue = True
        '
        'btHapus
        '
        Me.btHapus.HeaderText = ""
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Text = "HAPUS"
        Me.btHapus.UseColumnTextForButtonValue = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(630, 107)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(538, 107)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'rbBawahan
        '
        Me.rbBawahan.AutoSize = True
        Me.rbBawahan.Location = New System.Drawing.Point(221, 94)
        Me.rbBawahan.Name = "rbBawahan"
        Me.rbBawahan.Size = New System.Drawing.Size(70, 17)
        Me.rbBawahan.TabIndex = 23
        Me.rbBawahan.TabStop = True
        Me.rbBawahan.Text = "Bawahan"
        Me.rbBawahan.UseVisualStyleBackColor = True
        '
        'rbAtasan
        '
        Me.rbAtasan.AutoSize = True
        Me.rbAtasan.Location = New System.Drawing.Point(128, 94)
        Me.rbAtasan.Name = "rbAtasan"
        Me.rbAtasan.Size = New System.Drawing.Size(58, 17)
        Me.rbAtasan.TabIndex = 22
        Me.rbAtasan.TabStop = True
        Me.rbAtasan.Text = "Atasan"
        Me.rbAtasan.UseVisualStyleBackColor = True
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(461, 56)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(152, 20)
        Me.tbHarga.TabIndex = 21
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(133, 56)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(229, 20)
        Me.tbNama.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(406, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Jenis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama Barang/Item"
        '
        'RbAcc
        '
        Me.RbAcc.AutoSize = True
        Me.RbAcc.Location = New System.Drawing.Point(128, 123)
        Me.RbAcc.Name = "RbAcc"
        Me.RbAcc.Size = New System.Drawing.Size(77, 17)
        Me.RbAcc.TabIndex = 30
        Me.RbAcc.TabStop = True
        Me.RbAcc.Text = "Accesories"
        Me.RbAcc.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Location = New System.Drawing.Point(16, 417)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(75, 23)
        Me.btBack.TabIndex = 31
        Me.btBack.Text = "Back"
        Me.btBack.UseVisualStyleBackColor = True
        '
        'btBersihkan
        '
        Me.btBersihkan.Location = New System.Drawing.Point(630, 53)
        Me.btBersihkan.Name = "btBersihkan"
        Me.btBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btBersihkan.TabIndex = 32
        Me.btBersihkan.Text = "Bersihkan"
        Me.btBersihkan.UseVisualStyleBackColor = True
        '
        'MasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(726, 460)
        Me.Controls.Add(Me.btBersihkan)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.RbAcc)
        Me.Controls.Add(Me.tb_totalItem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudStock)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.rbBawahan)
        Me.Controls.Add(Me.rbAtasan)
        Me.Controls.Add(Me.tbHarga)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MasterBarang"
        Me.Text = "MasterBarang"
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_totalItem As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nudStock As NumericUpDown
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents id_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents btUbah As DataGridViewButtonColumn
    Friend WithEvents btHapus As DataGridViewButtonColumn
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents rbBawahan As RadioButton
    Friend WithEvents rbAtasan As RadioButton
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RbAcc As RadioButton
    Friend WithEvents btBack As Button
    Friend WithEvents btBersihkan As Button
End Class
