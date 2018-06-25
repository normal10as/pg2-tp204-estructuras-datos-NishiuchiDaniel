Module Ej4_12
    Private nombres As New Stack(Of String)

    Sub main()
        Dim opcion As Byte
        Do
            Console.WriteLine("Seleccione una opcion")
            Console.WriteLine("1-Ingresar un nombre")
            Console.WriteLine("2-Extraer nombre")
            opcion = Console.ReadLine
            Select Case opcion
                Case 1
                    Console.Write("Ingrese el nombre: ")
                    nombres.Push(Console.ReadLine)
                Case 2
                    Console.WriteLine(nombres.Pop)
                    If nombres.Count = 0 Then
                        Exit Do
                    End If
            End Select

        Loop
        Console.WriteLine("Fin")
        Console.ReadKey()
    End Sub
End Module
