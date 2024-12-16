Imports System

Module Program
    Sub Main(args As String())

        Dim data As String = "Tim,Sue,Bob,Jane"
        Dim firstNames As List(Of String) = data.Split(","c).ToList()

        For Each firstName As String In firstNames
            Console.WriteLine(firstName)
        Next

    End Sub
End Module
