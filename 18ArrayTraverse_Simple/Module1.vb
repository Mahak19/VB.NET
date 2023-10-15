Module Module1

    Sub Main()
        Dim Arr(4) As Integer
        Dim i As Byte
        'Arr(0)=10
        'Arr(1)=20
        'Arr(2)=30
        'Arr(3)=40
        'Arr(4)=50
        For i = 0 To 4 Step 1
            Console.Write("Enter Values: ")
            Arr(i) = Console.ReadLine()
        Next
        For i = 0 To 4 Step 1
            Console.WriteLine("Values are: " & Arr(i))
        Next
        'Console.WriteLine(Arr(0))
        'Console.WriteLine(Arr(1))
        'Console.WriteLine(Arr(2))
        'Console.WriteLine(Arr(3))
        'Console.WriteLine(Arr(4))
        Console.ReadKey()
    End Sub

End Module
