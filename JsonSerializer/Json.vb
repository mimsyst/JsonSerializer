Imports System.Runtime.Serialization.Json
Imports System.IO
Imports System.Text

Public Class Json
    Public Function JsonSerial(ByRef JsonStr As String, ByRef YourType As Type) As Object
        Dim Obj As Object = Nothing
        Try
            Dim ser As DataContractJsonSerializer
            ser = New DataContractJsonSerializer(YourType)
            Dim stream1 As New MemoryStream(Encoding.UTF8.GetBytes(JsonStr))
            Obj = ser.ReadObject(stream1)
        Catch ex As Exception
            Return Nothing
        End Try
        Return Obj
    End Function
End Class
