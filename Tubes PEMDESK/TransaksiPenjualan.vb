Imports MySql.Data.MySqlClient
Public Class TransaksiPenjualan

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Sub isi_combobox()
        da = New MySqlDataAdapter("select * from tbl_barang order by id_barang", conn)
        da.Fill(ds, "barang")
        cbProduk.Items.Clear()
        For i As Integer = 0 To ds.Tables("barang").Rows.Count - 1
            cbProduk.Items.Add(ds.Tables("barang").Rows(i).Item(1).ToString())
        Next
    End Sub

    Sub invoice()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT 
                                    CASE WHEN 
                                    MAX(CAST(SUBSTRING(no_invoice, 5, 3) AS UNSIGNED)) 
                                    IS NULL THEN
                                    1 ELSE MAX(CAST(SUBSTRING(no_invoice, 5, 3) AS UNSIGNED)) + 1
                                    END AS nomor
                                    FROM (
                                        SELECT
                                        MAX(CAST(SUBSTRING(no_invoice, 9, 2) AS UNSIGNED)) AS bln,
                                        MAX(CAST(SUBSTRING(no_invoice, 12, 4) AS UNSIGNED)) AS thn,
                                        no_invoice
                                        FROM tbl_transaksi
                                        GROUP BY no_invoice) a
                                        WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR (NOW());", conn)
        da.Fill(ds, "nomor")
        Dim nom As Integer
        nom = Integer.Parse(ds.Tables("nomor").Rows(0).Item(0))
        tbInvoice.Text = "INV/" & Format(nom, "0##") & "/" & Format(Now.Month, "0#") & "/" & Now.Year
    End Sub

    Private Sub TransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim currentDate As Date = DateTime.Now
            tbDate.Text = currentDate.ToString()
            tanggalTransaksi = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            koneksi()
            isi_combobox()
            invoice()
            tbNamaKasir.Text = user
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cbProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduk.SelectedIndexChanged
        nama_item = cbProduk.Text

        ds.Clear()
        da = New MySqlDataAdapter("SELECT harga FROM tbl_barang WHERE nama_barang='" & nama_item & "'", conn)
        da.Fill(ds, "harga")
        harga_item = Integer.Parse(ds.Tables("harga").Rows(0).Item(0))
        tbHarga.Text = harga_item
    End Sub

    Private Sub tbJumlah_TextChanged(sender As Object, e As EventArgs) Handles tbJumlah.TextChanged
        If tbJumlah.Text = "" Then
            ErrorProvider1.SetError(tbJumlah, "")
        Else
            ds.Clear()
            da = New MySqlDataAdapter("SELECT harga FROM tbl_barang WHERE nama_barang='" & nama_item & "'", conn)
            da.Fill(ds, "harga")
            jumlah_item = Integer.Parse(tbJumlah.Text)
            total_item = jumlah_item * harga_item
            tbTotal.Text = total_item
        End If
    End Sub

    Private Sub btTambah_Click(sender As Object, e As EventArgs) Handles btTambah.Click

        Try
            Dim existingRow As DataGridViewRow = Nothing

            For Each row As DataGridViewRow In dgvPenjualan.Rows
                If row.Cells("NamaBarang").Value IsNot Nothing AndAlso row.Cells("NamaBarang").Value.ToString() = nama_item Then
                    existingRow = row
                    Exit For
                End If
            Next

            ds.Clear()
            da = New MySqlDataAdapter("SELECT stock FROM tbl_barang WHERE nama_barang='" & nama_item & "'", conn)
            da.Fill(ds, "barang")
            Dim stock As Integer = Integer.Parse(ds.Tables("barang").Rows(0).Item("stock"))

            If stock > jumlah_item Or stock = jumlah_item Then
                stock -= jumlah_item

                If existingRow IsNot Nothing Then

                    Dim jumlah As Integer = Integer.Parse(existingRow.Cells("jumlah").Value) + Integer.Parse(tbJumlah.Text)
                    existingRow.Cells("jumlah").Value = jumlah

                    Dim harga As Integer = Integer.Parse(existingRow.Cells("harga").Value)
                    existingRow.Cells("subtotal").Value = jumlah * harga
                Else
                    ds.Clear()
                    da = New MySqlDataAdapter("select harga from tbl_barang where nama_barang='" & cbProduk.SelectedItem.ToString() & "'", conn)
                    da.Fill(ds, "harga")
                    Dim harga As Integer = Integer.Parse(ds.Tables("harga").Rows(0).Item(0))
                    Dim jumlah As Integer = Integer.Parse(tbJumlah.Text)
                    Dim subtotal As Integer = jumlah * harga
                    dgvPenjualan.Rows.Add(tbInvoice.Text, nama_item, harga_item, jumlah_item, total_item)
                End If

                subtotal = 0
                For Each row As DataGridViewRow In dgvPenjualan.Rows
                    If row.Cells("Total").Value IsNot Nothing Then
                        subtotal += row.Cells("Total").Value
                    End If
                Next

                tbSubtotal.Text = subtotal

                da = New MySqlDataAdapter("UPDATE tbl_barang SET stock='" & stock & "' WHERE nama_barang='" & nama_item & "'", conn)
                da.Fill(ds, "stock")

            Else
                MessageBox.Show("Stok habis/tidak cukup")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub tbDiskon_TextChanged(sender As Object, e As EventArgs) Handles tbDiskon.TextChanged
        If tbDiskon.Text = "" Then
            ErrorProvider1.SetError(tbDiskon, "")
        Else
            Dim diskon As Integer = CInt(tbDiskon.Text)
            Dim diskonPercent As Double = diskon / 100
            grand = 0
            grand = subtotal - (subtotal * diskonPercent)
            tbGrand.Text = grand
        End If
    End Sub

    Private Sub cbMember_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMember.SelectedIndexChanged
        If cbMember.SelectedIndex = 0 Then
            tbDiskon.Text = 5
            statusCust = cbMember.Text
        Else
            tbDiskon.Text = 0
            statusCust = cbMember.Text
        End If
    End Sub

    Private Sub btSelesai_Click(sender As Object, e As EventArgs) Handles btSelesai.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin memproses pesanan?",
                                                          "Konfirmasi Proses", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try

            If result = DialogResult.Yes Then
                noInvoice = tbInvoice.Text
                ds.Clear()
                da = New MySqlDataAdapter("insert into tbl_transaksi Values (?,?,?,?)", conn)
                da.SelectCommand.Parameters.AddWithValue("no_invoice", tbInvoice.Text)
                da.SelectCommand.Parameters.AddWithValue("total", grand)
                da.SelectCommand.Parameters.AddWithValue("tanggal_transaksi", tanggalTransaksi)
                da.SelectCommand.Parameters.AddWithValue("kode", kodekaryawan)
                da.Fill(ds, "transaksi")
                ds.Clear()

                For i As Integer = 0 To dgvPenjualan.Rows.Count - 1
                    Dim jumlah As Integer = dgvPenjualan.Rows(i).Cells("jumlah").Value
                    total_item = dgvPenjualan.Rows(i).Cells("Total").Value
                    nama_item = dgvPenjualan.Rows(i).Cells("namaBarang").Value
                    ds.Clear()
                    da = New MySqlDataAdapter("select id_barang from tbl_barang where nama_barang='" & nama_item & "'", conn)
                    da.Fill(ds, "barang")
                    If ds.Tables("barang").Rows.Count > 0 Then
                        id_item = ds.Tables("barang").Rows(0).Item(0)
                        If Not (Jumlah = 0 OrElse subtotal = 0) Then
                            ds.Clear()
                            da = New MySqlDataAdapter("insert into tbl_detailtrx (no_invoice, id_barang, jumlah, subtotal) values (?,?,?,?)", conn)
                            da.SelectCommand.Parameters.AddWithValue("no_invoice", noInvoice)
                            da.SelectCommand.Parameters.AddWithValue("id_barang", id_item)
                            da.SelectCommand.Parameters.AddWithValue("jumlah", Jumlah)
                            da.SelectCommand.Parameters.AddWithValue("subtotal", total_item)
                            da.Fill(ds, "detail")
                        End If
                    End If
                Next
                Me.Hide()

                Pembayaran.Show()
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Me.Hide()
        LoginKasir.Show()
    End Sub
End Class