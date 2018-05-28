Module Ej4_1

    Sub Main()

        Dim arreglo(4) As Double
        Dim sumatoria As Double
        Dim media As Double

        For x = 0 To arreglo.Length - 1
            Console.Write("Ingrese valor " & x + 1 & " : ")
            arreglo(x) = Console.ReadLine()
            sumatoria += arreglo(x)
        Next

        media = sumatoria / arreglo.Length
        Console.WriteLine("La media de los elementos es: " & media)
        For x = 0 To arreglo.Length - 1
            Console.WriteLine("La desviacion del elemento " & x & " es: " & arreglo(x) - media)
        Next

        Console.ReadKey()
    End Sub

End Module
