Imports MySql.Data.MySqlClient
Module Module1

    Public conn As New MySqlConnection
    Public da As New MySqlDataAdapter
    Public ds As New DataSet

    Public kodekaryawan As String
    Public user As String
    Public pass As String


    Public nama_item As String
    Public harga_item As Integer
    Public jumlah_item As Integer
    Public total_item As Integer
    Public subtotal As Integer
    Public tanggalTransaksi As String
    Public statusCust As String
    Public noInvoice As String
    Public grand As Double
    Public id_item As String

    Public method As String
    Public jumlah_bayar As Integer
    Public kembalian As Integer

    Public Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; password=" + "" + ";database=db_tubes")
    End Sub
    Public Sub clear(form As Form)
        For Each ctr In form.Controls
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


End Module
