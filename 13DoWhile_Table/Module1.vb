Module Module1

    Sub Main()
        Dim i, n As Byte
        Console.Write("Enter a number: ")
        n = Console.ReadLine()

        Console.WriteLine()
        Console.Write("Table of " & n & " is: ")
        Console.WriteLine()
        Console.WriteLine()


        i = 1
        Do While i <= 10
            Console.WriteLine(n & "x" & i & "=" & n * i)
            i = i + 1
        Loop
        Console.ReadKey()
    End Sub

End Module
