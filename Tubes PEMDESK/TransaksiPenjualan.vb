Imports MySql.Data.MySqlClient
Public Class TransaksiPenjualan
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim nama_item As String
    Dim harga_item As Integer
    Dim jumlah_item As Integer
    Dim total_item As Integer
    Dim subtotal As Integer = 0

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

    Private Sub TransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim currentDate As Date = DateTime.Now
            tbDate.Text = currentDate.ToString()
            koneksi()
            isi_combobox()
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
        dgvPenjualan.Rows.Add(nama_item, harga_item, jumlah_item, total_item)

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
        Dim grand As Double = subtotal - (subtotal * diskonPercent)
        tbGrand.Text = grand
    End Sub

End Class