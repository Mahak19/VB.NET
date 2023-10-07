Module Module1

    Sub Main()
        Dim s As String
        Dim r As Boolean

        s = "Hello"
        r = s Like "h??l?"
        Console.Write("The string start with s is " & r)
        Console.ReadKey()
    End Sub

End Module
