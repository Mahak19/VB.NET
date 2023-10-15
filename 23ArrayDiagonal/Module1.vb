Module Module1

    Sub Main()
        Dim arr(2, 2) As Integer
        Dim i, j As Byte
        For i = 0 To 2
            For j = 0 To 2
                Console.Write("Enter Value: ")
                arr(i, j) = Console.ReadLine()
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("Values are in diagonal form: ")
        For i = 0 To 2
            For j = 0 To 2
                If (i = j) Then
                    Console.Write(arr(i, j))
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
