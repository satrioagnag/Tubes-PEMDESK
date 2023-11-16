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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPembayaran = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lb_Nama = New System.Windows.Forms.Label()
        Me.lb_date = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.tbPenjualan = New System.Windows.Forms.TextBox()
        Me.tbDate = New System.Windows.Forms.TextBox()
        Me.dgvPenjualanToday = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPenjualanToday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(92, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "KASIR"
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackColor = System.Drawing.Color.DeepPink
        Me.btnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTransaksi.Location = New System.Drawing.Point(25, 108)
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(196, 31)
        Me.btnTransaksi.TabIndex = 7
        Me.btnTransaksi.Text = "Transaksi Penjualan"
        Me.btnTransaksi.UseVisualStyleBackColor = False
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
        'btnPembayaran
        '
        Me.btnPembayaran.BackColor = System.Drawing.Color.DeepPink
        Me.btnPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPembayaran.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPembayaran.Location = New System.Drawing.Point(25, 143)
        Me.btnPembayaran.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Size = New System.Drawing.Size(196, 31)
        Me.btnPembayaran.TabIndex = 5
        Me.btnPembayaran.Text = "Pembayaran"
        Me.btnPembayaran.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lb_Nama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnPembayaran)
        Me.Panel1.Controls.Add(Me.btnTransaksi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 413)
        Me.Panel1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepPink
        Me.Button1.Location = New System.Drawing.Point(25, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lb_Nama
        '
        Me.lb_Nama.AutoSize = True
        Me.lb_Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nama.Location = New System.Drawing.Point(87, 65)
        Me.lb_Nama.Name = "lb_Nama"
        Me.lb_Nama.Size = New System.Drawing.Size(72, 15)
        Me.lb_Nama.TabIndex = 10
        Me.lb_Nama.Text = "Nama Kasir"
        '
        'lb_date
        '
        Me.lb_date.AutoSize = True
        Me.lb_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lb_date.Location = New System.Drawing.Point(270, 42)
        Me.lb_date.Name = "lb_date"
        Me.lb_date.Size = New System.Drawing.Size(39, 18)
        Me.lb_date.TabIndex = 11
        Me.lb_date.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Customer "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(270, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Penjualan  Rp"
        '
        'tbCustomer
        '
        Me.tbCustomer.Location = New System.Drawing.Point(375, 80)
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.ReadOnly = True
        Me.tbCustomer.Size = New System.Drawing.Size(184, 20)
        Me.tbCustomer.TabIndex = 14
        '
        'tbPenjualan
        '
        Me.tbPenjualan.Location = New System.Drawing.Point(375, 118)
        Me.tbPenjualan.Name = "tbPenjualan"
        Me.tbPenjualan.ReadOnly = True
        Me.tbPenjualan.Size = New System.Drawing.Size(184, 20)
        Me.tbPenjualan.TabIndex = 15
        '
        'tbDate
        '
        Me.tbDate.Location = New System.Drawing.Point(375, 42)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.ReadOnly = True
        Me.tbDate.Size = New System.Drawing.Size(184, 20)
        Me.tbDate.TabIndex = 16
        '
        'dgvPenjualanToday
        '
        Me.dgvPenjualanToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenjualanToday.Location = New System.Drawing.Point(273, 165)
        Me.dgvPenjualanToday.Name = "dgvPenjualanToday"
        Me.dgvPenjualanToday.Size = New System.Drawing.Size(421, 150)
        Me.dgvPenjualanToday.TabIndex = 17
        '
        'LoginKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orchid
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
        Me.Name = "LoginKasir"
        Me.Text = "LoginKasir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPenjualanToday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lb_Nama As Label
    Friend WithEvents lb_date As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCustomer As TextBox
    Friend WithEvents tbPenjualan As TextBox
    Friend WithEvents tbDate As TextBox
    Friend WithEvents dgvPenjualanToday As DataGridView
End Class
