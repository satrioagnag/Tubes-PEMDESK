Imports MySql.Data.MySqlClient
Public Class Pembayaran
    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; password=" + "" + ";database=db_tubes")
    End Sub

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub
    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvPembelian.Rows.Add(nama_item, harga_item, jumlah_item, total_item)
        tbMember.Text = statusCust
        tbInvoice.Text = noInvoice
        tbGrand.Text = grand


    End Sub

    Private Sub tbBayar_TextChanged(sender As Object, e As EventArgs) Handles tbBayar.TextChanged
        Dim kembali As Double
        Dim bayar As Double
        bayar = tbBayar.Text

        If bayar > grand Then
            kembali = bayar - grand
            tbKembali.Text = kembali
        Else
            kembali = 0
            tbKembali.Text = kembali
        End If
    End Sub
End Class