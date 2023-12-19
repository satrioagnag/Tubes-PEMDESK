Imports MySql.Data.MySqlClient
Public Class MasterBarang

    Private Sub MasterBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        tampil_data()
        showitem()
    End Sub

    Sub showitem()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT COUNT(*) AS jumlah_barang FROM tbl_barang;", conn)
        da.Fill(ds, "count")
        tb_totalItem.Text = ds.Tables("count").Rows(0).Item(0)
    End Sub
    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            ElseIf TypeOf ctr Is RadioButton Then
                DirectCast(ctr, RadioButton).Checked = False
            ElseIf TypeOf ctr Is NumericUpDown Then
                DirectCast(ctr, NumericUpDown).Value = 0
            End If
        Next
    End Sub
    Sub tampil_data()
        Try
            ds.Clear()
            da = New MySqlDataAdapter("SELECT * FROM tbl_barang;", conn)
            da.Fill(ds, "barang")
            dgvBarang.Rows.Clear()

            For i As Integer = 0 To ds.Tables("barang").Rows.Count - 1
                dgvBarang.Rows.Add(ds.Tables("barang").Rows(i).Item(0).ToString,
                                    ds.Tables("barang").Rows(i).Item(1).ToString,
                                    ds.Tables("barang").Rows(i).Item(2).ToString,
                                    ds.Tables("barang").Rows(i).Item(3).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim id_barang As String = "0"
        If rbAtasan.Checked Then
            ds.Clear()
            da = New MySqlDataAdapter("SELECT CASE 
                                         WHEN MAX(CAST(SUBSTRING(id_barang, 2, 2) AS UNSIGNED)) IS NULL THEN 'A001'
                                         ELSE CONCAT('A', LPAD(MAX(CAST(SUBSTRING(id_barang, 2, 3) AS UNSIGNED)) + 1, 3, '0'))
                                       END AS nomor
                                       FROM tbl_barang
                                       WHERE id_barang LIKE 'A%';", conn)
            da.Fill(ds, "id")
            id_barang = ds.Tables("id").Rows(0).Item(0)
        ElseIf rbBawahan.Checked Then
            ds.Clear()
            da = New MySqlDataAdapter("SELECT CASE 
                                         WHEN MAX(CAST(SUBSTRING(id_barang, 2, 2) AS UNSIGNED)) IS NULL THEN 'B001'
                                         ELSE CONCAT('B', LPAD(MAX(CAST(SUBSTRING(id_barang, 2, 3) AS UNSIGNED)) + 1, 3, '0'))
                                       END AS nomor
                                       FROM tbl_barang
                                       WHERE id_barang LIKE 'B%';", conn)
            da.Fill(ds, "id")
            id_barang = ds.Tables("id").Rows(0).Item(0)
        ElseIf RbAcc.Checked Then
            ds.Clear()
            da = New MySqlDataAdapter("SELECT CASE 
                                         WHEN MAX(CAST(SUBSTRING(id_barang, 2, 2) AS UNSIGNED)) IS NULL THEN 'C001'
                                         ELSE CONCAT('C', LPAD(MAX(CAST(SUBSTRING(id_barang, 2, 3) AS UNSIGNED)) + 1, 3, '0'))
                                       END AS nomor
                                       FROM tbl_barang
                                       WHERE id_barang LIKE 'C%';", conn)
            da.Fill(ds, "id")
            id_barang = ds.Tables("id").Rows(0).Item(0)
        Else
            MessageBox.Show("Pilih jenis terlebih dahulu")
        End If

        ds.Clear()
        da = New MySqlDataAdapter("insert into tbl_barang values (?,?,?,?)", conn)
        da.SelectCommand.Parameters.AddWithValue("id_barang", id_barang)
        da.SelectCommand.Parameters.AddWithValue("nama_barang", tbNama.Text)
        da.SelectCommand.Parameters.AddWithValue("harga", tbHarga.Text)
        da.SelectCommand.Parameters.AddWithValue("stock", nudStock.Value)
        da.Fill(ds, "data_barang")
        ds.Clear()
        MessageBox.Show("Data berhasil disimpan")
        clear()
        tampil_data()
        showitem()

    End Sub
    Dim id As String
    Private Sub dgvBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellContentClick
        If e.ColumnIndex = dgvBarang.Columns("btHapus").Index AndAlso e.RowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus menu ini?",
                                                          "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim id_barang As String = dgvBarang.Rows(e.RowIndex).Cells("id_barang").Value
                dgvBarang.Rows.RemoveAt(e.RowIndex)
                da = New MySqlDataAdapter("DELETE from tbl_barang where id_barang = '" & id_barang & "'", conn)
                da.Fill(ds, "delete")
                tampil_data()
                showitem()
            End If
        End If

        If e.ColumnIndex = dgvBarang.Columns("btUbah").Index AndAlso e.RowIndex >= 0 Then
            id = dgvBarang.Rows(e.RowIndex).Cells("id_barang").Value.ToString()
            tbNama.Text = dgvBarang.Rows(e.RowIndex).Cells("nama_barang").Value.ToString()
            tbHarga.Text = dgvBarang.Rows(e.RowIndex).Cells("harga").Value
            nudStock.Value = Integer.Parse(dgvBarang.Rows(e.RowIndex).Cells("stock").Value)
            Dim id_barang As String = dgvBarang.Rows(e.RowIndex).Cells("id_barang").Value.ToString()
            If id_barang.StartsWith("A") Then
                rbAtasan.Checked = True
                rbBawahan.Checked = False
                RbAcc.Checked = False
            ElseIf id_barang.StartsWith("B") Then
                rbAtasan.Checked = False
                rbBawahan.Checked = True
                RbAcc.Checked = False
            Else
                rbAtasan.Checked = False
                rbBawahan.Checked = False
                RbAcc.Checked = True
            End If

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengupdate menu ini?",
                                                        "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ds.Clear()
            da = New MySqlDataAdapter("UPDATE tbl_barang SET nama_barang = @nama_barang, harga = @harga, stock = @stock where id_barang = '" & id & "'", conn)
            da.SelectCommand.Parameters.AddWithValue("nama_barang", tbNama.Text)
            da.SelectCommand.Parameters.AddWithValue("harga", tbHarga.Text)
            da.SelectCommand.Parameters.AddWithValue("stock", nudStock.Text)
            da.Fill(ds, "data_barang")
            ds.Clear()
            tampil_data()
            showitem()
        End If
    End Sub

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Me.Hide()
        LoginAdmin.Show()
        Me.Dispose()
    End Sub

    Private Sub btBersihkan_Click(sender As Object, e As EventArgs) Handles btBersihkan.Click
        clear()
    End Sub


End Class