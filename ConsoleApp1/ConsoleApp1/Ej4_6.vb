Module Ej4_6

    Sub main()
        Dim empleados As New Collection
        Dim empleadosclave As New ArrayList
        Dim ProduccionSemanal As New ArrayList
        Dim dia As Byte
        Dim clave As String
        empleados.Add("Pedro Alejandro", "pa")
        empleados.Add("Maria Fernanda", "mf")
        empleados.Add("Rodrigo Alberto", "ra")
        empleados.Add("Andrea Soledad", "as")


        Dim carga(empleados.Count - 1) As Integer

        For i As Byte = 0 To carga.Length - 1
            carga(i) = 0
        Next
        For i As Byte = 0 To 6
            ProduccionSemanal.Add(carga)
        Next
        For i As Byte = 0 To empleados.Count - 1
            empleadosclave.Add(empleados.Item(i + 1))
        Next

        Do
            Do
                Console.Write("Ingrese clave de empleado (0 para salir): ")
                clave = Console.ReadLine
                If empleados.Contains(clave) Or clave = "0" Then
                    Exit Do
                Else
                    Console.WriteLine("La clave no existe")
                End If
            Loop
            If clave = "0" Then
                Exit Do
            End If
            clave = empleadosclave.IndexOf(empleados.Item(clave))
            dia = 0
            Console.WriteLine("Ingrese dia de la semana para cargar la produccion (0 para salir): ")
            Console.WriteLine("1-Lunes 2-Martes 3-Miercoles 4-Jueves 5-Viernes 6-Sabado 7-Domingo")
            dia = Console.ReadLine()
            Select Case dia
                Case 1 To 7
                    carga = ProduccionSemanal(dia - 1)
                    Console.Write("Ingrese produccion para el empleado " & empleados.Item(clave + 1) & ": ")
                    carga(clave) += Console.ReadLine()
                    ProduccionSemanal.Item(dia - 1) = carga.Clone
                    carga(clave) = 0
                Case 0
                Case Else
                    Console.WriteLine("Seleccion Invalida")
            End Select

            totales(empleados, ProduccionSemanal)

        Loop Until dia = 0

    End Sub

    Private Sub totales(ByVal empleados As Collection, ByVal produccion As ArrayList)
        Dim prod As Array

        Console.WriteLine("Totales" & vbTab & vbTab & "Lun" & vbTab & "Mar" & vbTab & "Mier" & vbTab & "Juev" & vbTab & "Vier" & vbTab & "Sab" & vbTab & "Dom")
        For i As Byte = 1 To empleados.Count
            Console.Write(empleados.Item(i) & vbTab)
            For j As Byte = 0 To produccion.Count - 1
                prod = produccion(j)
                Console.Write(prod(i - 1) & vbTab)
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("------------------------------------------------------------------")
    End Sub

End Module
