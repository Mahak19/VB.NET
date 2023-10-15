Module Module1

    Sub Main()
        Dim ar As Integer() = {20, 22, 23, 24, 26}
        Dim i As Object
        Console.Write("Value of array: ")
        Console.WriteLine()
        For Each i In ar
            Console.WriteLine(i)
        Next
        Console.WriteLine()
        Console.WriteLine("Number of elements in array: " & ar.Length)

        Console.WriteLine()

        Console.ReadKey()
    End Sub

End Module
