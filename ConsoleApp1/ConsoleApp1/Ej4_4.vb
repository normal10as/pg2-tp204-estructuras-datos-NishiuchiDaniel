Module Ej4_4
    Sub main()

        Dim dominios As New Collection
        Dim ingreso As String
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
            Console.Write("Ingrese nombre de dominio: ")
            ingreso = Console.ReadLine()
            If dominios.Contains(ingreso) Then
                Console.WriteLine(dominios.Item(ingreso))
            Else
                Console.WriteLine("El dominio no existe en la base de datos")
            End If


        Loop Until ingreso = ""

    End Sub
End Module
