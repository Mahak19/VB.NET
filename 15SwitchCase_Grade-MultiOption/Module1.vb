Module Module1

    Sub Main()
        Dim grade As Integer
        Console.Write("Enter grade: ")
        grade = Console.ReadLine()

        Select Case grade
            Case 10, 9
                Console.WriteLine("Excellent")
            Case 8, 7
                Console.WriteLine("Very Good")
            Case 6, 5
                Console.WriteLine("Good")
            Case Else
                Console.WriteLine("Poor")
        End Select
        Console.ReadKey()
    End Sub

End Module
