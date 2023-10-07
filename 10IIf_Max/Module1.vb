Module Module1

    Sub Main()
        Dim a, b, max As Integer
        Console.Write("Enter Value of A: ")
        a = Console.ReadLine()

        Console.Write("Enter Value of B:")
        b = Console.ReadLine

        max = IIf(a > b, a, b)
        Console.WriteLine("Maximum Number is: " & max)
        Console.ReadKey()
    End Sub

End Module
