
Module Module1

    Sub Main()
        Dim Arr(2, 2) As Integer
        Dim i, j As Integer
        For i = 0 To 2
            For j = 0 To 2
                Console.Write("Enter Value: ")
                Arr(i, j) = Console.ReadLine()
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("Values are in Matrix form: ")
        For i = 0 To 2
            For j = 0 To 2
                Console.Write(Arr(i, j) & " ")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()

    End Sub

End Module
