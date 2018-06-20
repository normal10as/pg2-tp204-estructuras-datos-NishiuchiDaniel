Module Ej4_5
    Sub main()
        Dim dominios As New Collection
        Dim seleccion As Char
        dominios.Add("Argentina", "ar")
        dominios.Add("Isla de la Ascencion", "ac")
        dominios.Add("Emiratos Arabes Unidos", "ab")
        dominios.Add("Albania", "al")
        dominios.Add("Afganistan", "af")
        dominios.Add("Australia", "au")
        dominios.Add("Austria", "at")
        dominios.Add("Brasil", "br")
        dominios.Add("Bolivia", "bo")

        Do
            Console.WriteLine("Hay " & dominios.Count & " dominios cargados.")
            Console.WriteLine("Seleccione operacion que desea realizar: " & vbLf & "1-Agregar un dominio" & vbLf & "2-Editar un dominio" & vbLf & "3-Eliminar un dominio" & vbLf & "4-Buscar un dominio")
            seleccion = Console.ReadLine()
            Select Case seleccion
                Case "1"
                    agregar(dominios)
                Case "2"
                    selecEdit(dominios)
                Case "3"
                    eliminar(dominios)
                Case "4"
                    buscar(dominios)
                Case Else
                    Console.WriteLine("Opcion invalida")
            End Select
            Console.WriteLine("-----------------------------------------")

        Loop Until asc(seleccion) = 0
    End Sub

    Private Sub agregar(ByRef dominios As Collection)
        Dim pais As String
        Dim dom As String
        Dim bandera As Boolean
        Do
            bandera = False
            Console.Write("Ingrese pais: ")
            pais = Console.ReadLine()
            For Each dominio In dominios
                If dominio = pais Then
                    Console.WriteLine("El pais ya se encuentra en la base de datos")
                    bandera = True
                    Exit For
                End If
            Next
        Loop While bandera
        Do
            Console.Write("Ingrese nombre de dominio: ")
            dom = Console.ReadLine()
            If dominios.Contains(dom) Then
                Console.WriteLine("El nombre de dominio ya existe")
            Else
                dominios.Add(pais, dom)
                Console.WriteLine("Agregado exitosamente")
                bandera = True
            End If
        Loop Until bandera
    End Sub

    Private Sub selecEdit(ByRef dominios As Collection)
        Dim seleccion As Byte
        Console.WriteLine("Seleccione que desea editar:")
        Console.WriteLine("1-Pais de un dominio")
        Console.WriteLine("2-Dominio de un pais")
        Console.WriteLine("0-Volver")
        seleccion = Console.ReadLine()
        Select Case seleccion
            Case 1
                editarPais(dominios)
            Case 2
                editarDominio(dominios)
            Case 0
            Case Else
                Console.WriteLine("Seleccion incorrecta")
        End Select
    End Sub

    Private Sub editarDominio(ByRef dominios As Collection)
        Dim pais As String
        Dim bandera As Boolean
        Dim dom As String
        Dim marcador As Byte = 0

        Console.Write("Ingrese pais del que desea editar el dominio: ")
        pais = Console.ReadLine()
        For i = 1 To dominios.Count
            If pais = dominios.Item(i) Then
                marcador = i
            End If
        Next
        If marcador <> 0 Then
            Do
                bandera = True
                Console.Write("Ingrese nombre de dominio: ")
                dom = Console.ReadLine()
                If dominios.Contains(dom) Then
                    Console.WriteLine("El nombre de dominio ya existe")
                    bandera = False
                End If
                If bandera = True Then
                    dominios.Remove(marcador)
                    dominios.Add(pais, dom)
                    Console.WriteLine("Edicion completada")
                End If
            Loop Until bandera
        Else
            Console.WriteLine("El pais no existe en la base de datos")
        End If

    End Sub

    Private Sub editarPais(ByRef dominios As Collection)
        Dim pais As String
        Dim dom As String
        Dim marcador As Byte = 0
        Dim bandera As Boolean
        Console.Write("Ingrese dominio al que quiere editar su pais: ")
        dom = Console.ReadLine()

        If dominios.Contains(dom) Then
            Console.WriteLine("Nombre del pais: " & dominios.Item(dom))
            Do
                bandera = True
                Console.Write("Ingrese nuevo nombre del pais: ")
                pais = Console.ReadLine()
                If pais <> dominios.Item(dom) Then
                    For i = 1 To dominios.Count
                        If pais = dominios.Item(i) Then
                            bandera = False
                            Exit For
                        End If
                    Next
                End If
                If bandera = True Then
                    dominios.Remove(dom)
                    dominios.Add(pais, dom)
                    Console.WriteLine("Edicion completada")
                Else
                    Console.WriteLine("El pais ya existe")
                End If
            Loop Until bandera
        Else
            Console.WriteLine("El dominio no existe en la base de datos")
        End If
    End Sub

    Private Sub eliminar(ByRef dominios As Collection)
        Dim dom As String
        Dim selec As Byte
        Console.Write("Ingrese dominio que desea eliminar: ")
        dom = Console.ReadLine()
        If dominios.Contains(dom) Then
            Console.WriteLine("Nombre del pais: " & dominios.Item(dom))
            Console.WriteLine("Nombre de dominio: " & dom)
            Console.WriteLine("Desea eliminar? 1-Si 2-No")
            selec = Console.ReadLine()
            Select Case selec
                Case 1
                    dominios.Remove(dom)
                    Console.WriteLine("Eliminado de la base de datos")
                Case 2
                Case Else
                    Console.WriteLine("Seleccion invalida")
            End Select
        End If
    End Sub

    Private Sub buscar(ByRef dominios As Collection)
        Dim ingreso As String
        Console.Write("Ingrese nombre de dominio: ")
        ingreso = Console.ReadLine()
        If dominios.Contains(ingreso) Then
            Console.WriteLine(dominios.Item(ingreso))
        Else
            Console.WriteLine("El dominio no existe en la base de datos")
        End If
    End Sub


End Module

