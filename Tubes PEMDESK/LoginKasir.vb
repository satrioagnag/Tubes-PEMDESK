Imports MySql.Data.MySqlClient
Public Class LoginKasir

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Sub Customer()
        ds.Clear()
        da = New MySqlDataAdapter("select count(*) from tbl_transaksi where date(tanggal_transaksi) = curdate()", conn)
        da.Fill(ds, "transaction_count")
        If ds.Tables("transaction_count").Rows.Count > 0 Then
            ' Access the count value from the first row and first column
            ' Dim transactionCount As Integer = Convert.ToInt32(ds.Tables("transaction_count").Rows(0))
            tbCustomer.Text = ds.Tables("transaction_count").Rows(0).Item(0) & " Customer"
        End If
    End Sub

    Sub Penjualan()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT IFNULL(SUM(total), 0) FROM tbl_transaksi WHERE DATE(tanggal_transaksi) = CURDATE()", conn)
        da.Fill(ds, "penjualan")
        If ds.Tables("penjualan").Rows.Count > 0  Then
            tbPenjualan.Text = ds.Tables("penjualan").Rows(0).Item(0)
        Else
            tbPenjualan.Text = ""
        End If
    End Sub

    Sub tampil_data()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT
    b.nama_barang AS nama_barang,
    dt.jumlah AS jumlah,
    b.harga AS harga,
    dt.subtotal AS subtotal
FROM
    tbl_transaksi t
JOIN
    tbl_detailtrx dt ON t.no_invoice = dt.no_invoice
JOIN
    tbl_barang b ON dt.id_barang = b.id_barang
WHERE
    DATE(t.tanggal_transaksi) = CURDATE();", conn)
        da.Fill(ds, "today")
        dgvPenjualanToday.Rows.Clear()
        For i As Integer = 0 To ds.Tables("today").Rows.Count - 1
            dgvPenjualanToday.Rows.Add(ds.Tables("today").Rows(i).Item(0).ToString,
                                  ds.Tables("today").Rows(i).Item(2).ToString,
                                  ds.Tables("today").Rows(i).Item(1).ToString,
                                  ds.Tables("today").Rows(i).Item(3).ToString)
        Next

    End Sub
    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Me.Hide()
        TransaksiPenjualan.Show()
        Me.Dispose()
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub

    Private Sub LoginKasir_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim currentDate As Date = DateTime.Now
        tbDate.Text = currentDate.ToString()
        lb_Nama.Text = user
        Customer()
        Penjualan()
        tampil_data()
    End Sub

    Private Sub bt_logout_Click(sender As Object, e As EventArgs) Handles bt_logout.Click
        Me.Close()
        Me.Hide()
        Home.Show()
    End Sub
End Class