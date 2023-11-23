Imports MySql.Data.MySqlClient
Module Module1

    Public conn As New MySqlConnection
    Public da As New MySqlDataAdapter
    Public ds As New DataSet


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
End Module
