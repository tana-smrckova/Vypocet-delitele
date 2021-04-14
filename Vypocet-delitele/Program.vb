Imports System

Module Program
    Sub Main()
        Console.WriteLine("Zjisti výsledek pøevrácené hodnoty násobku x a y.")
        Console.Write("Zadej promìnnou X: ")
        Dim x = Console.ReadLine()
        Console.Write("Zadej promìnnou Y: ")
        Dim y = Console.ReadLine()

        If x = 0 Or y = 0 Then
            Console.WriteLine("Hodnota X nebo Y je rovna nule. Poèítat nebudu, program by kleknul.")
        Else
            Dim vysledek = 1 / (x * y)
            Console.WriteLine("Výsledek èiní: " & vysledek)
        End If

        Main()

    End Sub
End Module
