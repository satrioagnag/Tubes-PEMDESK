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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterBarang))
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(311, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Barang"
        '
        'tb_totalItem
        '
        Me.tb_totalItem.Location = New System.Drawing.Point(626, 444)
        Me.tb_totalItem.Name = "tb_totalItem"
        Me.tb_totalItem.Size = New System.Drawing.Size(100, 20)
        Me.tb_totalItem.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(547, 448)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Total Item"
        '
        'nudStock
        '
        Me.nudStock.Location = New System.Drawing.Point(473, 135)
        Me.nudStock.Name = "nudStock"
        Me.nudStock.Size = New System.Drawing.Size(71, 20)
        Me.nudStock.TabIndex = 27
        '
        'dgvBarang
        '
        Me.dgvBarang.BackgroundColor = System.Drawing.Color.Pink
        Me.dgvBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barang, Me.nama_barang, Me.Harga, Me.Stock, Me.btUbah, Me.btHapus})
        Me.dgvBarang.GridColor = System.Drawing.Color.PaleVioletRed
        Me.dgvBarang.Location = New System.Drawing.Point(28, 173)
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
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(642, 134)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImage = CType(resources.GetObject("btnSimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(550, 134)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'rbBawahan
        '
        Me.rbBawahan.AutoSize = True
        Me.rbBawahan.BackColor = System.Drawing.Color.Transparent
        Me.rbBawahan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBawahan.ForeColor = System.Drawing.Color.White
        Me.rbBawahan.Location = New System.Drawing.Point(233, 121)
        Me.rbBawahan.Name = "rbBawahan"
        Me.rbBawahan.Size = New System.Drawing.Size(74, 19)
        Me.rbBawahan.TabIndex = 23
        Me.rbBawahan.TabStop = True
        Me.rbBawahan.Text = "Bawahan"
        Me.rbBawahan.UseVisualStyleBackColor = False
        '
        'rbAtasan
        '
        Me.rbAtasan.AutoSize = True
        Me.rbAtasan.BackColor = System.Drawing.Color.Transparent
        Me.rbAtasan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAtasan.ForeColor = System.Drawing.Color.White
        Me.rbAtasan.Location = New System.Drawing.Point(140, 121)
        Me.rbAtasan.Name = "rbAtasan"
        Me.rbAtasan.Size = New System.Drawing.Size(62, 19)
        Me.rbAtasan.TabIndex = 22
        Me.rbAtasan.TabStop = True
        Me.rbAtasan.Text = "Atasan"
        Me.rbAtasan.UseVisualStyleBackColor = False
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(473, 83)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(152, 20)
        Me.tbHarga.TabIndex = 21
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(145, 83)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(229, 20)
        Me.tbNama.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(418, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(418, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Jenis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama Barang/Item"
        '
        'RbAcc
        '
        Me.RbAcc.AutoSize = True
        Me.RbAcc.BackColor = System.Drawing.Color.Transparent
        Me.RbAcc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAcc.ForeColor = System.Drawing.Color.White
        Me.RbAcc.Location = New System.Drawing.Point(140, 150)
        Me.RbAcc.Name = "RbAcc"
        Me.RbAcc.Size = New System.Drawing.Size(82, 19)
        Me.RbAcc.TabIndex = 30
        Me.RbAcc.TabStop = True
        Me.RbAcc.Text = "Accesories"
        Me.RbAcc.UseVisualStyleBackColor = False
        '
        'btBack
        '
        Me.btBack.BackColor = System.Drawing.Color.Red
        Me.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btBack.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBack.ForeColor = System.Drawing.Color.White
        Me.btBack.Location = New System.Drawing.Point(28, 441)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(75, 23)
        Me.btBack.TabIndex = 31
        Me.btBack.Text = "Back"
        Me.btBack.UseVisualStyleBackColor = False
        '
        'btBersihkan
        '
        Me.btBersihkan.BackgroundImage = CType(resources.GetObject("btBersihkan.BackgroundImage"), System.Drawing.Image)
        Me.btBersihkan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btBersihkan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBersihkan.ForeColor = System.Drawing.Color.White
        Me.btBersihkan.Location = New System.Drawing.Point(642, 80)
        Me.btBersihkan.Name = "btBersihkan"
        Me.btBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btBersihkan.TabIndex = 32
        Me.btBersihkan.Text = "Bersihkan"
        Me.btBersihkan.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Tubes_PEMDESK.My.Resources.Resources.vira_collection__900_x_500_piksel_
        Me.PictureBox2.Location = New System.Drawing.Point(184, -45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(425, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'MasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.BackgroundImage = Global.Tubes_PEMDESK.My.Resources.Resources.download__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(759, 491)
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
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "MasterBarang"
        Me.Text = "MasterBarang"
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox2 As PictureBox
End Class
