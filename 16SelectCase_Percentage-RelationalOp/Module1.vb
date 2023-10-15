Module Module1

    Sub Main()
        Dim percentage As Integer
        Console.Write("Enter ur percentage: ")
        percentage = Console.ReadLine()

        Select Case percentage
            Case Is >= 84
                Console.WriteLine("Grade A+")
            Case Is >= 76
                Console.WriteLine("Grade A")
            Case Is >= 60
                Console.WriteLine("Grade B")
            Case Is >= 54
                Console.WriteLine("Grade C")
            Case Is >= 36
                Console.WriteLine("Grade D")
            Case Else
                Console.WriteLine("Better Luck next time")
        End Select
        Console.ReadKey()
    End Sub

End Module
