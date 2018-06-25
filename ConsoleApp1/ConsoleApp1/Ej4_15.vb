Module Ej4_15
    Sub main()
        Dim clientes As New LinkedList(Of String)
        Dim prioridad As New Stack
        Dim opcion As Byte

        Do
            Console.WriteLine("-------------------------")
            If clientes.Count > 0 Then
                Console.WriteLine("Hay " & clientes.Count & " clientes en espera")
            Else
                Console.WriteLine("No hay clientes")
            End If
            Console.WriteLine("-------------------------")
            Console.WriteLine("1-Agregar un cliente")
            Console.WriteLine("2-Llamar un cliente")
            Console.WriteLine("0-Salir")
            opcion = Console.ReadLine
            Select Case opcion
                Case 1
                    agregar(clientes, prioridad)
                Case 2
                    If clientes.Count > 0 Then
                        llamar(clientes, prioridad)
                    Else
                        Console.WriteLine("No hay clientes!")
                    End If
                Case 0
                    Exit Do
                Case Else
                    Console.WriteLine("Opcion invalida")
            End Select
        Loop

    End Sub

    Private Sub agregar(ByRef clientes As LinkedList(Of String), ByRef prioridad As Stack)
        Dim opcion As Byte
        Dim nombre As String
        Console.Write("Ingrese nombre del cliente: ")
        nombre = Console.ReadLine
        Do
            Console.WriteLine("1-Con prioridad")
            Console.WriteLine("2-Sin prioridad")
            opcion = Console.ReadLine
            Select Case opcion
                Case 1
                    If prioridad.Count = 0 Then
                        clientes.AddFirst(nombre)
                        prioridad.Push(nombre)
                    Else
                        clientes.AddAfter(clientes.Find(prioridad.Peek()), nombre)
                        prioridad.Push(nombre)
                    End If
                    Exit Do

                Case 2
                    clientes.AddLast(nombre)
                    Exit Do
                Case Else
                    Console.WriteLine("Invalido")
            End Select
        Loop

    End Sub

    Private Sub llamar(ByRef clientes As LinkedList(Of String), ByRef prioridad As Stack)
        Dim nombre As String
        nombre = clientes(0)
        clientes.RemoveFirst()
        Console.WriteLine("-------------------------")
        Console.WriteLine("Proximo Cliente: " & nombre)
        If prioridad.Count > 0 Then
            If nombre = prioridad.Peek() Then
                prioridad.Clear()
            End If
        End If
    End Sub

End Module
