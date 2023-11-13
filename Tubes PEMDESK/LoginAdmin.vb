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
End Class