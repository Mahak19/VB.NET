Imports System.Security.Cryptography

Module Module1

    Sub Main()
        Dim Ar() As Integer
        Dim Cr(10) As Integer
        Dim A(4) As Integer
        Ar = {210, 232, 253, 204, 25}
        Dim i As Object
        Console.WriteLine("Elements in array: ")

        For Each i In Ar
            Console.WriteLine(i)
        Next
        Console.WriteLine("Number of element in array: " & Ar.Length)
        Console.WriteLine("Dimensional of array is: " & Ar.Rank)
        Console.WriteLine("Lower Bound of array is: " & Ar.GetLowerBound(0))
        Console.WriteLine("Upper Bound of array is: " & Ar.GetUpperBound(0))
        Console.WriteLine("Value of index two is: " & Ar.GetValue(2))
        Console.WriteLine("Array index of 232 is: " & Array.IndexOf(Ar, 232))
        Console.WriteLine("Inserted Element: ")
        Ar.SetValue(88, 4)
        For Each i In Ar
            Console.WriteLine(i)
        Next
        Console.WriteLine("The reversed order of array: ")
        Ar.Reverse(Ar)
        For Each i In Ar
            Console.WriteLine(i)
        Next
        Console.WriteLine("Sorted Array: ")
        Ar.Sort(Ar)
        For Each i In Ar
            Console.WriteLine(i)
        Next
        Console.WriteLine("Index of 204 is: " & Array.IndexOf(Ar, 204))
        Array.Copy(Ar, Cr, 4)
        Console.WriteLine("Copy Array: ")
        Console.WriteLine("The value of index two is: " & Ar.GetValue(2))
        Console.WriteLine("Inserted Element: ")
        Ar.SetValue(88, 4)
        For Each i In Ar
            Console.WriteLine(i)
        Next
        Console.WriteLine("Reversed Order of Array: ")
        Ar.Reverse(Ar)
        For Each i In Ar
            Console.WriteLine(i)
        Next
        Console.WriteLine("Sorted Array: ")
        Ar.Sort(Ar)
        For Each i In Ar
            Console.WriteLine(i)
        Next
        Console.WriteLine("Index of 204 is: " & Array.IndexOf(Ar, 204))

        Array.Copy(Ar, Cr, 4)
        Console.WriteLine("Copy Array: ")
        For Each i In Cr
            Console.WriteLine(i)
        Next
        For i = 0 To 3
            Console.WriteLine(Cr(i))
        Next
        Ar.CopyTo(A, 0)
        Console.WriteLine("New Copy: ")
        For Each i In A
            Console.WriteLine(i)
        Next
        Console.ReadKey()

    End Sub

End Module
