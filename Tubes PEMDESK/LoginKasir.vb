Imports MySql.Data.MySqlClient
Public Class LoginKasir
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet



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

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Me.Hide()
        TransaksiPenjualan.Show()
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        Me.Hide()
    End Sub

    Private Sub LoginKasir_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim currentDate As Date = DateTime.Now
        tbDate.Text = currentDate.ToString()
        lb_Nama.Text = user
    End Sub

    Private Sub bt_logout_Click(sender As Object, e As EventArgs) Handles bt_logout.Click
        Me.Close()
        Me.Hide()
        Home.Show()
    End Sub
End Class