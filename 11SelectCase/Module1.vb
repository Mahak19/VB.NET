Module Module1

    Sub Main()
        Dim a, b, c As Double

        Console.Write("Enter Value of A: ")
        a = Console.ReadLine()
        Console.Write("Enter Value of B: ")
        b = Console.ReadLine()

        Dim op As String
        Console.Write("Enter Operator: ")
        op = Console.ReadLine()
        Select Case op
            Case "+"
                c = a + b
                Console.WriteLine("Addition is:" & c)
            Case "-"
                c = a - b
                Console.WriteLine("Subtraction is:" & c)
            Case "*"
                c = a + b
                Console.WriteLine("Multiplication is:" & c)
            Case "/"
                c = a Mod b
                Console.WriteLine("Division is:" & c)
            Case Else
                Console.WriteLine("Wrong")
        End Select
        Console.ReadKey()
    End Sub

End Module
