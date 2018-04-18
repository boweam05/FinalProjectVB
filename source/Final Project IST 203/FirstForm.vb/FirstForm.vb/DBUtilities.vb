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

    Public Shared Function GetPhone(ByVal pName As Integer) As Phones
        Dim phone As Phones = Nothing
        SQL = "SELECT CellPhones.Name, Make, Firmware FROM CellPhones & WHERE CellPhones.Name = @Name"
        Try
            connection = New SQLiteConnection(CONNECTION_STRING)
            connection.Open()
            command = New SQLiteCommand(SQL, connection)
            command.Parameters.AddWithValue("@Name", pName)
            reader = command.ExecuteReader

            While (reader.Read())
                phone = New Phones
                phone.Name = reader.GetString(0)
                phone.Make = reader.GetString(1)
                phone.Firmware = reader.GetString(2)

            End While

        Catch ex As Exception
            phone = Nothing
        Finally
            connection.Close()

        End Try
        Return phone
    End Function

    Public Shared Function insert(ByVal pName As String, pMake As String, ByVal pFirmware As String) As Boolean
        Dim result As Boolean = False
        SQL = "INSERT INTO CellPhones(Name, Make, Firmware) VALUES(@Name, @Make, @Firmware)"
        Try
            connection = New SQLiteConnection(CONNECTION_STRING)
            connection.Open()

            command = New SQLiteCommand(SQL, connection)
            command.Parameters.AddWithValue("@Name", pName)
            command.Parameters.AddWithValue("@Make", pMake)
            command.Parameters.AddWithValue("@Firmware", pFirmware)

            If command.ExecuteNonQuery > 0 Then
                result = True
            End If
        Catch ex As Exception

        Finally
            connection.Close()
        End Try
        Return result
    End Function

    Public Shared Function Delete(ByVal pName As String) As Boolean
        Dim result As Boolean = False

        SQL = "DELETE FROM CellPhones WHERE Name = @Name"
        Try
            connection = New SQLiteConnection(CONNECTION_STRING)
            connection.Open()
            command = New SQLiteCommand(SQL, connection)
            command.Parameters.AddWithValue("@Name", pName)

            If command.ExecuteNonQuery > 0 Then
                result = True

            End If
        Catch ex As Exception
        Finally
            connection.Close()

        End Try
        Return result
    End Function

End Class
