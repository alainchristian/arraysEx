Imports System
Module Program
    Sub Main(args As String())
        Dim Arr1() As Integer = {2, 5, 5, 8}
        Dim Arr2 As Integer() = {2, 5, 5}
        Dim Arr3 As Integer() = {2, 5, 5}
        Dim Arr4(6) As Integer
        For i = 0 To Arr4.Length - 1
            Console.Write("Enter element {0}: ", i + 1)
            Arr4(i) = Console.ReadLine()

        Next
        Console.WriteLine("Displaying elements")
        For i = 0 To Arr4.Length - 1
            'Console.WriteLine("Element {0} is {1}", i + 1, Arr4(i))
            Console.WriteLine("Element " & i + 1 & " is " & Arr4(i))
        Next
    End Sub
End Module
