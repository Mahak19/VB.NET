Module Module1

    Sub Main()
        Dim i, n As Byte

        Console.Write("Enter limit to print even number series: ")
        n = Console.ReadLine()
        Console.WriteLine()

        Console.WriteLine("Numbers are: ")

        i = 1
        Do While i <= n
            If i Mod 2 = 0 Then
                Console.WriteLine(i & " ")
            End If
            i = i + 1
        Loop
        Console.ReadKey()
    End Sub

End Module
