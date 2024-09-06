Imports System.Console

Module Program
    Sub Main()
        Dim num, i As Integer
        Randomize()
        For i = 1 To 5
            num = (Rnd() * 5) + 5
            WriteLine(num)
        Next
        ReadKey()
    End Sub
End Module
