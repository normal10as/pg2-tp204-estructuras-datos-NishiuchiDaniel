Module Ej4_2
    Sub main()
        Dim codigo = New Byte() {1, 2, 3, 4, 5}
        Dim nombre = New String() {"pepsi", "brahma", "coca", "lays", "sprite"}
        Dim preciounitario = New Decimal() {5, 20, 10, 15, 25}
        Dim cantidad As UInt32
        Dim codigoingresado As Byte
        Dim totalgeneral As Decimal
        Do
            Do
                Console.Write("Ingrese codigo entre 1 y 4 y cero para salir: ")
                codigoingresado = Console.ReadLine
                If codigoingresado < 0 Or codigoingresado > 4 Then
                    Console.WriteLine("El valor ingresado es incorrecto")
                End If
            Loop While codigoingresado > 4 And codigoingresado <= 0

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
        Console.ReadKey()
    End Sub
End Module