Module Module1

    Sub Main()
        Dim ar() As Integer
        Dim s, i, k As Integer
        Console.Write("Enter size of array: ")
        s = Console.ReadLine()

        ReDim ar(5)
        For i = 0 To s
            Console.Write("Value of " & i & " index of array is ")
            ar(i) = Console.ReadLine()
            Console.WriteLine()
        Next
        Console.Write("Enter increasing size of array: ")
        k = Console.ReadLine()
        ReDim Preserve ar(k)
        s = s + 1
        Console.WriteLine()
        For i = s To k
            Console.Write("Value of " & i & " index of array is ")
            ar(i) = Console.ReadLine()
        Next
        Console.WriteLine()
        For i = 0 To k
            Console.WriteLine("Value of " & i & " index of array is " & ar(i))
        Next
        Console.ReadKey()

    End Sub

End Module
