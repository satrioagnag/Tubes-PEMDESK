﻿Imports MySql.Data.MySqlClient
Public Class Home


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            koneksi()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Try
            ds.Clear()

            user = tbUsername.Text
            pass = tbPassword.Text
            da = New MySqlDataAdapter("select * from tbl_akun where username='" & user & "' AND pass='" & pass & "'", conn)
            da.Fill(ds, "akun")

            If ds.Tables("akun").Rows.Count > 0 Then
                da = New MySqlDataAdapter("select kode from tbl_akun where username='" & user & "'", conn)
                da.Fill(ds, "kode")
                kodekaryawan = ds.Tables("kode").Rows(0).Item(0)
                MessageBox.Show("Login Berhasil")
                clear(Me)
                da = New MySqlDataAdapter("select tier from tbl_akun where username='" & user & "'", conn)
                da.Fill(ds, "tier")
                Dim tier As String = ds.Tables(0).Rows(0)("tier").ToString()
                If tier = "ADMIN" Then
                    Me.Hide()
                    LoginAdmin.Show()
                ElseIf tier = "KASIR" Then
                    Me.Hide()
                    LoginKasir.Show()
                Else
                    Me.Hide()
                    LoginOwner.Show()
                End If

            Else
                MessageBox.Show("Login Gagal!")
                clear(Me)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        HomeSignup.Show()

    End Sub
End Class

