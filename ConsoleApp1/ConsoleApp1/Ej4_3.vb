﻿Module Ej4_3

    Sub main()

        Dim cantidadalumnos As Byte
        Dim cantidadnotas As Byte
        Dim mejoralumno(1) As String
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

        Dim alumnos(cantidadalumnos - 1) As String
        Dim notas(cantidadalumnos - 1, cantidadnotas) As Single

        For i = 0 To cantidadalumnos - 1
            comprobarNombre("Ingrese nombre del alumno: ", i, alumnos)
            For j = 0 To cantidadnotas - 1
                comprobarNota("Ingrese nota: ", i, j, notas)
            Next
        Next
        promedio(notas, alumnos, cantidadalumnos, cantidadnotas)
        mejor(notas, alumnos, cantidadalumnos, cantidadnotas, mejoralumno)

        Console.WriteLine("Los mejores alumnos son: ")
        For Each i In mejoralumno
            Console.WriteLine(i)
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
    Private Sub comprobarNota(ByVal msj As String, ByVal i As Byte, ByVal j As Byte, ByRef notas(,) As Single)
        Do
            Console.Write(msj)
            notas(i, j) = Console.ReadLine()
            If notas(i, j) < 0 Or notas(i, j) > 10 Then
                Console.WriteLine("El rango de la nota es invalido")
            Else
                Exit Do
            End If
        Loop
    End Sub
    Private Sub comprobarNombre(ByVal msj As String, ByVal i As Byte, ByRef alumnos() As String)
        Dim valor As Boolean
        Do
            valor = False
            Console.Write(msj)
            alumnos(i) = Console.ReadLine()
            If alumnos(i) = "" Then
                Console.WriteLine("No se ingreso el nombre")
                valor = True
            Else
                For x = 0 To i - 1
                    If alumnos(i) = alumnos(x) Then
                        Console.WriteLine("El nombre ingresado ya existe")
                        valor = True
                    End If
                Next
            End If
        Loop While valor = True
    End Sub
    Private Sub promedio(ByVal notas(,) As Single, ByVal alumnos() As String, ByVal cantidadalumnos As Byte, ByVal cantidadnotas As Byte)
        Dim promedio As Double
        For i = 0 To cantidadalumnos - 1
            promedio = 0
            Console.Write(alumnos(i))
            For j = 0 To cantidadnotas - 1
                promedio += notas(i, j)
            Next
            promedio = promedio / cantidadnotas
            notas(i, cantidadnotas) = promedio
            Console.Write("   Promedio: " & promedio)
            Console.WriteLine(aprueba(promedio))
        Next
    End Sub
    Private Function aprueba(ByVal prom As Double) As String
        If prom >= 6 Then
            Return ("  Aprobo")
        Else
            Return ("  No aprobo")
        End If
    End Function
    Private Sub mejor(ByVal notas(,) As Single, ByVal alumnos() As String, ByVal cantidadalumnos As Byte, ByVal cantidadnotas As Byte, ByRef mejoralumno() As String)
        Dim mayor As Double = 0
        Dim contador As Byte = 1
        For i = 0 To cantidadalumnos - 1
            If notas(i, cantidadnotas) > mayor Then
                ReDim mejoralumno(1)
                mejoralumno(0) = alumnos(i)
                mayor = notas(i, cantidadnotas)
            ElseIf notas(i, cantidadnotas) = mayor Then
                ReDim Preserve mejoralumno(contador + 1)
                contador += 1
                mejoralumno(contador - 1) = alumnos(i)
            End If
        Next
    End Sub
End Module

