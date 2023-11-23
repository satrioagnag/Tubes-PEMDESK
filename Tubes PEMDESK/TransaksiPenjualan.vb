﻿Imports MySql.Data.MySqlClient
Public Class TransaksiPenjualan



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
        ds.Clear()
        da = New MySqlDataAdapter("SELECT harga FROM tbl_barang WHERE nama_barang='" & nama_item & "'", conn)
        da.Fill(ds, "harga")
        jumlah_item = Integer.Parse(tbJumlah.Text)
        total_item = jumlah_item * harga_item
        tbTotal.Text = total_item
    End Sub

    Private Sub btTambah_Click(sender As Object, e As EventArgs) Handles btTambah.Click
        dgvPenjualan.Rows.Add(tbInvoice.Text, nama_item, harga_item, jumlah_item, total_item)

        For Each row As DataGridViewRow In dgvPenjualan.Rows
            If row.Cells("Total").Value IsNot Nothing Then
                subtotal += row.Cells("Total").Value
            End If
        Next

        tbSubtotal.Text = subtotal
    End Sub

    Private Sub tbDiskon_TextChanged(sender As Object, e As EventArgs) Handles tbDiskon.TextChanged
        Dim diskon As Integer = CInt(tbDiskon.Text)
        Dim diskonPercent As Double = diskon / 100
        grand = 0
        grand = subtotal - (subtotal * diskonPercent)
        tbGrand.Text = grand
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
                                                          "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        noInvoice = tbInvoice.Text
        Try
            If result = DialogResult.Yes Then
                ds.Clear()
                da = New MySqlDataAdapter("insert into tbl_transaksi Values (?,?,?)", conn)
                da.SelectCommand.Parameters.AddWithValue("no_invoice", tbInvoice.Text)
                da.SelectCommand.Parameters.AddWithValue("total", total_item)
                da.SelectCommand.Parameters.AddWithValue("tanggal_transaksi", tanggalTransaksi)
                da.Fill(ds, "transaksi")
                ds.Clear()

            End If

            Me.Hide()
            Pembayaran.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class