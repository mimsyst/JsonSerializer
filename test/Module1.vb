Module Module1

    <System.Runtime.Serialization.DataContractAttribute()> _
    Public Class testClass
        <System.Runtime.Serialization.DataMember()> _
        Public name As String
        <System.Runtime.Serialization.DataMember()> _
        Public gender As String
        <System.Runtime.Serialization.DataMember()> _
        Public age As Integer

    End Class

    Sub Main()
        Dim json As New JsonSerializer.Json
        Dim test As testClass
        Dim JsonStr As String = "{ ""name"":""apple"", ""gender"":""man"", ""age"":150}"

        test = json.JsonSerial(JsonStr, GetType(testClass))
        Debug.Print(String.Format("name={0}, gender={1}, age={2}", test.name, test.gender, test.age))
    End Sub
End Module
