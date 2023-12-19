Imports MySql.Data.MySqlClient

Public Class LoginAdmin
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

    Private Sub bt_logout_Click(sender As Object, e As EventArgs) Handles bt_logout.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub btn_barang_Click(sender As Object, e As EventArgs) Handles btn_barang.Click
        Me.Hide()
        MasterBarang.Show()
    End Sub

    Private Sub btn_riwayat_Click(sender As Object, e As EventArgs) Handles btn_riwayat.Click
        Me.Hide()
        PenjualanAdmin.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

End Class