Imports System

Module Program
    Sub Main()
        Console.WriteLine("Zjisti v�sledek p�evr�cen� hodnoty n�sobku x a y.")
        Console.Write("Zadej prom�nnou X: ")
        Dim x = Console.ReadLine()
        Console.Write("Zadej prom�nnou Y: ")
        Dim y = Console.ReadLine()

        If x = 0 Or y = 0 Then
            Console.WriteLine("Hodnota X nebo Y je rovna nule. Po��tat nebudu, program by kleknul.")
        Else
            Dim vysledek = 1 / (x * y)
            Console.WriteLine("V�sledek �in�: " & vysledek)
        End If

        Main()

    End Sub
End Module
