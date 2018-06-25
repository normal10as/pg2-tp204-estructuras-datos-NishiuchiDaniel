Module Ej4_14
    Sub main()
        Dim productos As New Dictionary(Of Integer, String)
        Dim precios As New Dictionary(Of Integer, Decimal)
        Dim opcion As Byte

        productos.Add(5, "Cerveza")
        productos.Add(7, "Gaseosa")
        productos.Add(10, "Agua")
        precios.Add(5, 28.5)
        precios.Add(7, 32.15)
        precios.Add(10, 100)
        Do

            Console.WriteLine("Clave" & vbTab & "Descripcion" & vbTab & "Precio")
            For Each producto In productos
                Console.WriteLine(producto.Key & vbTab & producto.Value & vbTab & vbTab & precios(producto.Key))
            Next
            Console.WriteLine("Elija una opcion")
            Console.WriteLine("1-Agregar un producto")
            Console.WriteLine("2-Editar un producto")
            Console.WriteLine("3-Borrar un producto")
            Console.WriteLine("0-Salir")
            opcion = Console.ReadLine
            Select Case opcion
                Case 1
                    agregar(productos, precios)
                Case 2
                    editar(productos, precios)
                Case 3
                    borrar(productos, precios)
                Case 0
                    Exit Do
                Case Else
                    Console.WriteLine("Opcion invalida")
            End Select
        Loop
    End Sub

    Private Sub agregar(ByRef productos As Dictionary(Of Integer, String), ByRef precios As Dictionary(Of Integer, Decimal))
        Dim claveProducto As Integer
        Dim descripcionProducto As String
        Dim precioProducto As Decimal

        Console.Write("Ingrese clave del producto: ")
        claveProducto = Console.ReadLine()
        If productos.ContainsKey(claveProducto) Then
            Console.WriteLine("La clave ya existe")
        Else
            Console.Write("Ingrese descripcion del producto: ")
            descripcionProducto = Console.ReadLine
            Console.Write("Ingrese precio del producto: ")
            precioProducto = Console.ReadLine
            productos.Add(claveProducto, descripcionProducto)
            precios.Add(claveProducto, precioProducto)
        End If
    End Sub

    Private Sub editar(ByRef productos As Dictionary(Of Integer, String), ByRef precios As Dictionary(Of Integer, Decimal))
        Dim claveProducto As Integer
        Dim descripcionProducto As String
        Dim precioProducto As Decimal

        Console.Write("Ingrese clave del producto: ")
        claveProducto = Console.ReadLine()
        If productos.ContainsKey(claveProducto) Then
            Console.Write("Ingrese descripcion del producto: ")
            descripcionProducto = Console.ReadLine
            Console.Write("Ingrese precio del producto: ")
            precioProducto = Console.ReadLine
            productos.Remove(claveProducto)
            productos.Add(claveProducto, descripcionProducto)
            precios.Remove(claveProducto)
            precios.Add(claveProducto, precioProducto)
        Else
            Console.WriteLine("La clave no existe")
        End If
    End Sub

    Private Sub borrar(ByRef productos As Dictionary(Of Integer, String), ByRef precios As Dictionary(Of Integer, Decimal))
        Dim claveProducto As Integer
        Console.Write("Ingrese clave del producto: ")
        claveProducto = Console.ReadLine()
        If productos.ContainsKey(claveProducto) Then
            productos.Remove(claveProducto)
            precios.Remove(claveProducto)
        Else
            Console.WriteLine("La clave no existe")
        End If
    End Sub
End Module
