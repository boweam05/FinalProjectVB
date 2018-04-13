Public Class Phones

    Public Property Name As String
    Public Property Make As String
    Public Property Firmware As String

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim result As Boolean = False

        If TypeOf obj Is Phones Then
            Dim cast As Phones = CType(obj, Phones)
            If Name = cast.Name Then
                result = True
            End If
        End If
        Return result
    End Function


End Class
