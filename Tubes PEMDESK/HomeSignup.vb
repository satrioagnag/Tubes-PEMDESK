Imports MySql.Data.MySqlClient
Public Class HomeSignup
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

    Private Sub btSignup_Click(sender As Object, e As EventArgs) Handles btSignup.Click
        koneksi()
        ds.Clear()
        da = New MySqlDataAdapter("select * from tbl_akun where username='" & tbUsername.Text & "'", conn)
        da.Fill(ds, "checkacc")
        If ds.Tables("checkacc").Rows.Count > 0 Then
            MessageBox.Show("Username telah dipakai")
        Else
            Dim id_user As String
            Dim kode As String
            If cbRole.SelectedItem = "OWNER" Then
                kode = "OWN"
            ElseIf cbRole.SelectedItem = "KASIR" Then
                kode = "KSR"
            Else
                kode = "ADM"
            End If

            ds.Clear()
            da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(kode, 4, 3) AS UNSIGNED)) IS NULL
                              THEN '" & kode & "001' ELSE CONCAT('" & kode & "',LPAD(MAX(CAST(SUBSTRING(kode, 4, 3) AS UNSIGNED)) + 1, 3, '0'))END AS NOMOR FROM tbl_akun WHERE
                              kode LIKE '" & kode & "%';", conn)

            da.Fill(ds, "xxx")
            id_user = ds.Tables("xxx").Rows(0).Item(0).ToString


            da = New MySqlDataAdapter("insert into tbl_akun values (?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("username", tbUsername.Text)
            da.SelectCommand.Parameters.AddWithValue("pass", tbPassword.Text)
            da.SelectCommand.Parameters.AddWithValue("tier", cbRole.Text)
            da.SelectCommand.Parameters.AddWithValue("kode", id_user)
            ds.Clear()
            da.Fill(ds, "newacc")
            MessageBox.Show("Akun berhasil terdaftar")
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Home.Show()

    End Sub
End Class