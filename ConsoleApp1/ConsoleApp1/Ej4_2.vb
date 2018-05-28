Module Ej4_2
    Sub main()
        Dim codigo = New Byte() {1, 2, 3, 4, 5}
        Dim nombre = New String() {"pepsi", "brahma", "coca", "lays", "sprite"}
        Dim preciounitario = New Decimal() {5, 20, 10, 15, 25}
        Dim cantidad As UInt32
        Dim codigoingresado As Byte
        Dim totalgeneral As Decimal
        Do
            codigoingresado = Comprobar()

            If codigoingresado <> 0 Then
                Console.WriteLine("Nombre de producto: " & nombre(codigoingresado - 1))
                Console.WriteLine("Precio unitario: " & preciounitario(codigoingresado - 1))
                Console.Write("Ingrese cantidad: ")
                cantidad = Console.ReadLine()
                Console.WriteLine("Total del producto " & nombre(codigoingresado - 1) & " es: " & preciounitario(codigoingresado - 1) * cantidad)
                totalgeneral += preciounitario(codigoingresado - 1) * cantidad
                Console.WriteLine("Total general: " & totalgeneral)
            End If
        Loop Until (codigoingresado = 0)


    End Sub

    Friend Function Comprobar() As Byte
        Dim a As Integer = -1
        While a < 0 Or a > 4
            Console.Write("Ingrese codigo entre 1 y 4 y cero para salir: ")
            a = Console.ReadLine()
            If a < 0 Or a > 4 Then
                Console.WriteLine("El valor ingresado es incorrecto")
            End If
        End While
        Return (a)
    End Function
End Module
