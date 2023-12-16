<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAdmin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_barang = New System.Windows.Forms.Button()
        Me.btn_riwayat = New System.Windows.Forms.Button()
        Me.bt_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(236, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ADMIN"
        '
        'btn_barang
        '
        Me.btn_barang.BackColor = System.Drawing.Color.DeepPink
        Me.btn_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_barang.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_barang.Location = New System.Drawing.Point(168, 185)
        Me.btn_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_barang.Name = "btn_barang"
        Me.btn_barang.Size = New System.Drawing.Size(196, 36)
        Me.btn_barang.TabIndex = 8
        Me.btn_barang.Text = "Stok Barang"
        Me.btn_barang.UseVisualStyleBackColor = False
        '
        'btn_riwayat
        '
        Me.btn_riwayat.BackColor = System.Drawing.Color.DeepPink
        Me.btn_riwayat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_riwayat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_riwayat.Location = New System.Drawing.Point(168, 127)
        Me.btn_riwayat.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_riwayat.Name = "btn_riwayat"
        Me.btn_riwayat.Size = New System.Drawing.Size(196, 36)
        Me.btn_riwayat.TabIndex = 7
        Me.btn_riwayat.Text = "Riwayat Penjualan"
        Me.btn_riwayat.UseVisualStyleBackColor = False
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.Red
        Me.bt_logout.Location = New System.Drawing.Point(12, 257)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(75, 23)
        Me.bt_logout.TabIndex = 10
        Me.bt_logout.Text = "Logout"
        Me.bt_logout.UseVisualStyleBackColor = False
        '
        'LoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.bt_logout)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_barang)
        Me.Controls.Add(Me.btn_riwayat)
        Me.Name = "LoginAdmin"
        Me.Text = "LoginAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btn_barang As Button
    Friend WithEvents btn_riwayat As Button
    Friend WithEvents bt_logout As Button
End Class
