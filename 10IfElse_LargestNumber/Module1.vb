
Module Module1

    Sub Main()
        Dim a, b, c As Integer

        'a=100
        'b=200
        'c=150

        Console.Write("Enter value of A: ")
        a = Console.ReadLine()

        Console.Write("Enter value of B: ")
        b = Console.ReadLine()

        Console.Write("Enter value of C: ")
        c = Console.ReadLine()

        If a > b Then
            If a > c Then
                Console.WriteLine("A is larger")
            Else
                Console.WriteLine("C is larger")
            End If
        Else
            If b > c Then
                Console.WriteLine("B is larger")
            Else
                Console.WriteLine("C is larger")
            End If
        End If
        Console.ReadKey()
    End Sub

End Module
