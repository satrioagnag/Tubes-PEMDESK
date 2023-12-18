Imports MySql.Data.MySqlClient
Public Class ReportStock
    Sub tampil_data()
        da = New MySqlDataAdapter("select id_barang,nama_barang,stock FROM tbl_barang", conn)
        da.Fill(ds, "stockRep")
    End Sub

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Me.Hide()
        LoginOwner.Show()
    End Sub

    Private Sub ReportStock_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ds.Clear()
        koneksi()
        Try
            Dim report As New ReportStockCR
            tampil_data()
            report.SetDataSource(ds.Tables("stockRep"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = report
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class