<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterKaryawan
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
        Me.dgvKaryawan = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbKode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btUbah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(234, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Master Karyawan"
        '
        'dgvKaryawan
        '
        Me.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.username, Me.role, Me.btUbah, Me.btHapus})
        Me.dgvKaryawan.Location = New System.Drawing.Point(38, 155)
        Me.dgvKaryawan.Name = "dgvKaryawan"
        Me.dgvKaryawan.Size = New System.Drawing.Size(544, 150)
        Me.dgvKaryawan.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(156, 86)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(100, 20)
        Me.tbNama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kode Karyawan"
        '
        'tbKode
        '
        Me.tbKode.Location = New System.Drawing.Point(156, 128)
        Me.tbKode.Name = "tbKode"
        Me.tbKode.ReadOnly = True
        Me.tbKode.Size = New System.Drawing.Size(100, 20)
        Me.tbKode.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Role"
        '
        'cbRole
        '
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Items.AddRange(New Object() {"ADMIN", "KASIR", "OWNER"})
        Me.cbRole.Location = New System.Drawing.Point(331, 86)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(121, 21)
        Me.cbRole.TabIndex = 8
        '
        'btUpdate
        '
        Me.btUpdate.Location = New System.Drawing.Point(484, 118)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btUpdate.TabIndex = 10
        Me.btUpdate.Text = "Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(484, 84)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(75, 23)
        Me.btClear.TabIndex = 11
        Me.btClear.Text = "Bersihkan"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Location = New System.Drawing.Point(38, 334)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(75, 23)
        Me.btBack.TabIndex = 12
        Me.btBack.Text = "Back"
        Me.btBack.UseVisualStyleBackColor = True
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode Karyawan"
        Me.Kode.Name = "Kode"
        '
        'username
        '
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        '
        'role
        '
        Me.role.HeaderText = "Role"
        Me.role.Name = "role"
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
        'MasterKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(628, 408)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.cbRole)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbKode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvKaryawan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MasterKaryawan"
        Me.Text = "MasterKaryawan"
        CType(Me.dgvKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvKaryawan As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbKode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents btUpdate As Button
    Friend WithEvents btClear As Button
    Friend WithEvents btBack As Button
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents role As DataGridViewTextBoxColumn
    Friend WithEvents btUbah As DataGridViewButtonColumn
    Friend WithEvents btHapus As DataGridViewButtonColumn
End Class
