Imports MySql.Data.MySqlClient
Public Class LoginOwner

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Private Sub bt_reportJual_Click(sender As Object, e As EventArgs) Handles bt_reportJual.Click
        Me.Hide()
        FormReportBulanan.Show()
    End Sub

    Private Sub bt_logout_Click(sender As Object, e As EventArgs) Handles bt_logout.Click
        Me.Close()

        Home.Show()
    End Sub
End Class