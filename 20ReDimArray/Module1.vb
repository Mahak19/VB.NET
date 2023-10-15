Imports System.Runtime.InteropServices

Module Module1

    Sub Main()
        Dim arr() As Integer
        Dim s, i As Byte
        Console.Write("Enter the size of Array: ")
        s = Console.ReadLine()

        ReDim arr(3)
        For i = 0 To 2
            Console.Write("Value are: ")
            arr(i) = Console.ReadLine()
        Next
        Console.WriteLine()
        Console.WriteLine("Values are: ")
        For i = 0 To s
            Console.WriteLine(arr(i))
        Next
        Console.ReadKey()
        ReDim Preserve arr(5)
        For i = 0 To 5
            arr(3) = 40
            arr(4) = 50
            Console.WriteLine(arr(i))
        Next
        Console.WriteLine()
        Console.WriteLine("Values are: ")
        For i = 0 To s
            Console.WriteLine(arr(i))
        Next
        Console.ReadKey()

    End Sub

End Module
