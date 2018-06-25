Module Ej4_12_2
    Sub main()
        Dim compradores As New Queue(Of String)
        Dim opcion As Byte

        Do
            If compradores.Count = 0 Then
                Console.WriteLine("Sin clientes")
            Else
                Console.WriteLine("Hay " & compradores.Count & " compradores en espera")
            End If
            Console.WriteLine("Que desea hacer?")
            Console.WriteLine("1-Agregar comprador a la cola")
            If compradores.Count Then
                Console.WriteLine("2-Llamar proximo cliente")
            End If
            Console.WriteLine("0-Salir")
            opcion = Console.ReadLine
            Select Case opcion
                Case 1
                    agregarComprador(compradores)
                Case 2
                    Console.WriteLine(llamarcomprador(compradores))
                Case 0
                    Exit Do
                Case Else
                    Console.WriteLine("Opcion invalida")
            End Select
        Loop
    End Sub

    Private Sub agregarComprador(ByRef compradores As Queue(Of String))
        Dim nombre As String

        Console.Write("Ingrese nombre del comprador: ")
        nombre = Console.ReadLine
        compradores.Enqueue(nombre)
    End Sub

    Private Function llamarcomprador(ByRef compradores As Queue(Of String))
        Return compradores.Dequeue
    End Function
End Module
