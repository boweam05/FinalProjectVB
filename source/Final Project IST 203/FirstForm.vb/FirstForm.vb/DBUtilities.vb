Imports System.Data.SQLite

Public Class DBUtilities
    'SQLite database properties 
    Private Shared connection As SQLiteConnection
    Private Shared command As SQLiteCommand
    Private Shared reader As SQLiteDataReader
    Private Shared adapter As SQLiteDataAdapter

    Private Const CONNECTION_STRING = "Data Source = Phones.db; Version=3"
    Private Shared SQL As String

    Public Shared Function GetPhonesTable() As DataTable
        Dim table As DataTable
        SQL = "SELECT CellPhones.Name, Make, Firmware FROM CellPhones"
        Try
            connection = New SQLiteConnection(CONNECTION_STRING)
            connection.Open()

            Dim dataSet As New DataSet
            adapter = New SQLiteDataAdapter(SQL, connection)
            adapter.Fill(dataSet)

            table = dataSet.Tables(0)
        Catch ex As Exception
            table = Nothing
        End Try
        Return table
    End Function

End Class
