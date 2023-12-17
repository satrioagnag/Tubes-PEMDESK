Imports MySql.Data.MySqlClient
Public Class MasterKaryawan
    Private Sub MasterKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        tampil_data()
    End Sub

    Sub tampil_data()
        Try
            ds.Clear()
            da = New MySqlDataAdapter("SELECT kode,username,tier FROM tbl_akun;", conn)
            da.Fill(ds, "karyawan")
            dgvKaryawan.Rows.Clear()

            For i As Integer = 0 To ds.Tables("karyawan").Rows.Count - 1
                dgvKaryawan.Rows.Add(ds.Tables("karyawan").Rows(i).Item(0).ToString,
                                    ds.Tables("karyawan").Rows(i).Item(1).ToString,
                                    ds.Tables("karyawan").Rows(i).Item(2).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        clear(Me)
    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengupdate karyawan ini?",
                                                        "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ds.Clear()
            da = New MySqlDataAdapter("UPDATE tbl_akun SET username = @username, tier = @tier where kode = '" & tbKode.Text & "'", conn)
            da.SelectCommand.Parameters.AddWithValue("username", tbNama.Text)
            da.SelectCommand.Parameters.AddWithValue("tier", cbRole.SelectedItem)
            da.Fill(ds, "data_karyawan")
            ds.Clear()
            tampil_data()
            clear(Me)
        End If
    End Sub
    Dim kode_ As String
    Private Sub dgvKaryawan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKaryawan.CellContentClick
        If e.ColumnIndex = dgvKaryawan.Columns("btHapus").Index AndAlso e.RowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data karyawan ini?",
                                                          "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim kode_kar As String = dgvKaryawan.Rows(e.RowIndex).Cells("Kode").Value
                dgvKaryawan.Rows.RemoveAt(e.RowIndex)
                da = New MySqlDataAdapter("DELETE from tbl_akun where kode = '" & kode_kar & "'", conn)
                da.Fill(ds, "delete")
                tampil_data()
            End If
        End If

        If e.ColumnIndex = dgvKaryawan.Columns("btUbah").Index AndAlso e.RowIndex >= 0 Then
            tbKode.Text = dgvKaryawan.Rows(e.RowIndex).Cells("Kode").Value.ToString()
            tbNama.Text = dgvKaryawan.Rows(e.RowIndex).Cells("username").Value.ToString()
            cbRole.SelectedItem = dgvKaryawan.Rows(e.RowIndex).Cells("Role").Value
            Dim kode_kar As String = dgvKaryawan.Rows(e.RowIndex).Cells("Kode").Value.ToString()
            If kode_kar.StartsWith("A") Then
                cbRole.SelectedIndex = 0
            ElseIf kode_kar.StartsWith("K") Then
                cbRole.SelectedIndex = 1
            Else
                cbRole.SelectedIndex = 2
            End If
        End If
    End Sub

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Me.Hide()
        LoginOwner.Show()
        Me.Dispose()
    End Sub
End Class