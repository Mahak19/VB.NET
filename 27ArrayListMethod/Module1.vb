Module Module1

    Sub Main()
        Dim a1 As ArrayList = New ArrayList(10)
        Dim i As Object

        Console.WriteLine("Cpacity of array " & a1.Capacity)
        Console.WriteLine("Total no. of elements " & a1.Count)

        a1.Add(10)
        a1.Add(11)
        a1.Add(13)
        a1.Add(9)
        Console.WriteLine("")
        Console.WriteLine("Cpacity of array " & a1.Capacity)
        Console.WriteLine("Total no. of elements " & a1.Count)

        a1.Sort()
        For Each i In a1
            Console.WriteLine(i)
        Next
        Console.WriteLine("The index of 13 is " & a1.IndexOf(13))

        a1.Insert(3, 12)
        Console.WriteLine("Array after insertion: ")

        For Each i In a1
            Console.WriteLine(i)
        Next
        'a1.Clear()
        Console.WriteLine("Toat elements in array " & a1.Count)
        Console.WriteLine("Does 11 exists in array: " & a1.Contains(11))
        Console.ReadKey()
    End Sub

End Module
