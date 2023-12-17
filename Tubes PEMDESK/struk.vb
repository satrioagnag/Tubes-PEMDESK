Imports MySql.Data.MySqlClient
Public Class struk
    Sub tampil_data()
        Try
            da = New MySqlDataAdapter("SELECT
                                            t.no_invoice,
                                            b.nama_barang AS nama_barang,
                                            b.harga AS harga,
                                            dt.jumlah AS jumlah,
                                            dt.subtotal AS subtotal,
                                            t.total AS total,
                                            a.username AS username,
                                            p.jumlah_bayar AS jumlah_bayar,
                                            p.kembalian AS kembalian
                                       FROM
                                            tbl_transaksi t 
                                       JOIN 
                                            tbl_detailtrx dt ON t.no_invoice = dt.no_invoice
                                       LEFT JOIN
                                            tbl_barang b ON dt.id_barang = b.id_barang
                                       LEFT JOIN
                                            tbl_akun a ON t.kode = a.kode
                                        LEFT JOIN
                                            tbl_pembayaran p ON t.no_invoice = p.no_invoice
                                       WHERE 
                                            dt.no_invoice = @no_invoice", conn)
            da.SelectCommand.Parameters.AddWithValue("@no_invoice", noInvoice)
            da.Fill(ds, "struk")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub struk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ds.Clear()
        koneksi()
        Try
            Dim report As New strukCrystal

            tampil_data()
            report.SetDataSource(ds.Tables("struk"))

            For Each paramField As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition In report.ParameterFields
                paramField.CurrentValues.Clear()
                paramField.CurrentValues.AddValue(noInvoice)
                report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
            Next

            CrystalReportViewer2.ReportSource = report
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & ex.StackTrace, "Crystal Reports Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class