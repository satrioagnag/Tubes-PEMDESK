Imports MySql.Data.MySqlClient
Public Class FormReportBulanan


    Sub tampil_data()
        da = New MySqlDataAdapter("select * from tbl_transaksi;", conn)
        da.Fill(ds, "xxx")
    End Sub
    Private Sub bt_tampildata_Click(sender As Object, e As EventArgs) Handles bt_tampildata.Click
        ds.Clear()
        koneksi()
        Try
            Dim myrpt As New CrystalReport1
            tampil_data()
            myrpt.setdatasource(ds.Tables("xxx"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class