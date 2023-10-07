Module Module1

    Sub Main()
        Dim age As Integer

        Console.Write("Enter Age:")
        age = Console.ReadLine()

        Console.WriteLine()

        Select Case age
            Case 1 To 6
                Console.WriteLine("Kid")
            Case 7 To 18
                Console.WriteLine("Teenage")
            Case 19 To 100
                Console.WriteLine("Adult")
        End Select
        Console.ReadKey()
    End Sub

End Module
