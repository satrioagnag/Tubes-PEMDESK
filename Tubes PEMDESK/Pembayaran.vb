Imports MySql.Data.MySqlClient
Public Class Pembayaran

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

    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Try
            method = cbMethod.SelectedItem
            jumlah_bayar = tbBayar.Text
            kembalian = tbKembali.Text
            ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_pembayaran (no_invoice, method_bayar, jumlah_bayar, kembalian) values (?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("no_invoice", noInvoice)
            da.SelectCommand.Parameters.AddWithValue("method_bayar", method)
            da.SelectCommand.Parameters.AddWithValue("jumlah_bayar", jumlah_bayar)
            da.SelectCommand.Parameters.AddWithValue("kembalian", kembalian)
            da.Fill(ds, "bayar")

            Me.Hide()
            LoginKasir.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class