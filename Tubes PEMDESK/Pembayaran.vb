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
        'ambil dari database tbl_detailtrx, dengan comman select * from tbl_detailtrx where invoice = 
        ds.Clear()
        da = New MySqlDataAdapter("SELECT
                                        b.nama_barang AS nama_barang,
                                        dt.jumlah As jumlah,
                                        b.harga AS harga,
                                        dt.subtotal AS subtotal
                                    FROM
        tbl_transaksi t
                                    JOIN
        tbl_detailtrx dt ON t.no_invoice = dt.no_invoice
                                    JOIN
        tbl_barang b ON dt.id_barang = b.id_barang
                                    WHERE dt.no_invoice ='" & noInvoice & "'", conn)
        da.Fill(ds, "detail")
        dgvPembelian.Rows.Clear()
        For i As Integer = 0 To ds.Tables("detail").Rows.Count - 1
            dgvPembelian.Rows.Add(ds.Tables("detail").Rows(i).Item(0).ToString,
                                  ds.Tables("detail").Rows(i).Item(2).ToString,
                                  ds.Tables("detail").Rows(i).Item(1).ToString,
                                  ds.Tables("detail").Rows(i).Item(3).ToString)


        Next

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