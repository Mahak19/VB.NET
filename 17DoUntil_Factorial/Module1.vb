Module Module1

    Sub Main()
        Dim n, f, i As Integer
        f = 1
        Console.Write("Enter a number: ")
        n = Console.ReadLine()

        For i = 1 To n
            f = f * i
        Next
        Console.WriteLine("Factorial of " & n & " is " & f)
        Console.ReadKey()

    End Sub

End Module
