Module Ej4_7

    Sub main()


        Dim cantidadalumnos As Byte
        Dim cantidadnotas As Byte
        Dim mejoralumno As New ArrayList
        Dim bandera As Boolean = False
        Do
            Console.Write("Ingrese cantidad de alumnos (maximo 40): ")
            cantidadalumnos = Console.ReadLine()
            bandera = comprobarCantidad(cantidadalumnos, 40)
            If bandera = False Then
                Console.WriteLine("Cantidad Incorrecta")
            End If
        Loop Until bandera

        Do
            Console.Write("Ingrese cantidad de notas (maximo 4): ")
            cantidadnotas = Console.ReadLine()
            bandera = comprobarCantidad(cantidadnotas, 4)
            If bandera = False Then
                Console.WriteLine("Cantidad Incorrecta")
            End If
        Loop Until bandera

        Dim alumnos As New ArrayList
        Dim notas As New ArrayList
        Dim promedios As New arraylist

        For i = 0 To cantidadalumnos - 1
            comprobarNombre(alumnos)
            comprobarNota(notas, cantidadnotas)
        Next

        CalcularPromedios(notas, alumnos, cantidadalumnos, cantidadnotas, promedios)
        mejor(promedios, alumnos, cantidadalumnos, cantidadnotas, mejoralumno)

        Console.WriteLine("Los mejores alumnos son: ")
        For i = 0 To mejoralumno.Count - 1
            Console.WriteLine(mejoralumno(i) & " con el promedio: " & promedios(alumnos.IndexOf(mejoralumno(i))))
        Next
        Console.ReadKey()
    End Sub

    Private Function comprobarCantidad(ByVal val As Byte, ByVal maximo As Byte) As Boolean
        Dim x As Boolean = True
        If val > maximo Or val <= 0 Then
            x = False
            Return x
        End If
        Return x
    End Function

    Private Sub comprobarNota(ByRef notas As ArrayList, ByRef cantidadnotas As Byte)
        Dim carga(cantidadnotas - 1) As Single
        Dim i As Byte = 0
        Do
            Console.Write("Ingrese nota: ")
            carga(i) = Console.ReadLine()
            If carga(i) < 0 Or carga(i) > 10 Then
                Console.WriteLine("El rango de la nota es invalido")
            Else
                i += 1
            End If
        Loop Until i = cantidadnotas
        notas.Add(carga.Clone)
    End Sub

    Private Sub comprobarNombre(ByRef alumnos As ArrayList)
        Dim nombre As String
        Dim a As Boolean = True
        Do
            Console.Write("Ingrese nombre del alumno: ")
            nombre = Console.ReadLine()
            If nombre = "" Then
                Console.WriteLine("No se ingreso el nombre")
            ElseIf alumnos.Contains(nombre) Then
                Console.WriteLine("El nombre ingresado ya existe")
            Else
                alumnos.Add(nombre)
                a = False
            End If
        Loop While a
    End Sub

    Private Sub CalcularPromedios(ByVal notas As ArrayList, ByVal alumnos As ArrayList, ByVal cantidadalumnos As Byte, ByVal cantidadnotas As Byte, ByRef promedios As ArrayList)
        Dim valores(cantidadnotas - 1) As Single
        Dim suma As Single
        For i = 0 To cantidadalumnos - 1
            suma = 0
            valores = notas(i)
            Console.Write(alumnos(i))
            For j = 0 To cantidadnotas - 1
                suma += valores(j)
            Next
            promedios.Add(suma / cantidadnotas)
            Console.Write("   Promedio: " & promedios(i))
            Console.WriteLine(aprueba(promedios, i))
        Next
    End Sub
    Private Function aprueba(ByVal prom As ArrayList, ByRef i As Byte) As String
        If prom(i) >= 6 Then
            Return ("  Aprobo")
        Else
            Return ("  No aprobo")
        End If
    End Function
    Private Sub mejor(ByRef promedios As ArrayList, ByRef alumnos As ArrayList, ByRef cantidadalumnos As Byte, ByRef cantidadnotas As Byte, ByRef mejoralumno As ArrayList)
        Dim mayor As Double = 0
        For i = 0 To cantidadalumnos - 1
            If promedios(i) > mayor Then
                mejoralumno.Clear()
                mejoralumno.Add(alumnos.Item(i))
                mayor = promedios.Item(i)
            ElseIf promedios(i) = mayor Then
                mejoralumno.Add(alumnos.Item(i))
            End If
        Next
    End Sub
End Module
