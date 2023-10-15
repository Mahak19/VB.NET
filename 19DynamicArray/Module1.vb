
Module Module1

    Sub Main()
        Dim D() As Integer
        Dim s, i As Byte
        Console.Write("Enter the size of Array: ")
        s = Console.ReadLine()
        ReDim D(s)
        For i = 0 To s
            Console.Write("Enter values:")
            D(i) = Console.ReadLine()
        Next
        Console.WriteLine()
        Console.WriteLine("Values are: ")
        For i = 0 To s
            Console.WriteLine(D(i))
        Next
        Console.ReadKey()
    End Sub

End Module
