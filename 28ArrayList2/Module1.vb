Imports System.Security.Cryptography

Module Module1

    Sub Main()
        Dim a2 As ArrayList = New ArrayList(10)
        Dim s, r As Integer, i As Object

        Dim a3 As ArrayList = New ArrayList()

        a2.Add(5)
        a2.Add(6)
        a2.Add(7)
        a2.Add(8)
        a2.Add(9)
        a2.Add(10)

        'Console.Write("Enter number for Search: ")
        's = Console.ReadLine()

        'If a2.Contains(s) Then
        'Console.WriteLine("Data found")
        'Console.WriteLine("Index is:" & a2.IndexOf(s))
        'Else
        'Console.WriteLine("Data not found")


        'End If
        'Console.Write("Enter number to remove: ")
        'r = Console.ReadLine()

        'a2.Remove(r)

        'For Each i In a2
        'Console.WriteLine(i)
        'Next
        'Console.WriteLine()

        'Console.Write("Enter number to remove: ")
        'r = Console.ReadLine()

        'a2.RemoveAt(3)
        'For Each i In a2
        'Console.WriteLine(i)
        'Next
        'Console.WriteLine()

        'a2.RemoveRange(2, 3)
        'For Each i In a2
        'Console.WriteLine(i)
        'Next

        'Console.ReadKey()


        'a2.Reverse()
        For Each i In a2
            Console.WriteLine(i)
        Next
        Console.ReadKey()

        'Console.Write("Data count is " & a2.Count)
        'Console.Write("Capacity is " & a2.Capacity)

        'a2.TrimToSize()


        'Console.Write("Data count is " & a2.Count)
        'Console.Write("Capacity is " & a2.Capacity)


        a3 = a2.GetRange(2, 4)
        Console.WriteLine("Array range")
        For Each i In a3
            Console.WriteLine(i)
        Next
        Console.ReadKey()


    End Sub

End Module
