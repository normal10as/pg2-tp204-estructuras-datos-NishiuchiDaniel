Module Ej4_11
    Sub main()
        Dim valores As New Stack(Of Decimal)
        Dim ingreso As Decimal
        Dim suma As Decimal = 0

        Do
            Console.WriteLine("La suma es: " & suma)
            Console.Write("Ingrese un valor para sumar, 0 para eliminar un valor: ")
            ingreso = Console.ReadLine
            If ingreso = 0 And valores.Count <> 0 Then
                Console.WriteLine("Valor eliminado: " & valores.Peek)
                suma -= valores.Pop
            Else
                valores.Push(ingreso)
                suma += ingreso
            End If
        Loop Until suma = 0

    End Sub
End Module
