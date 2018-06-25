Module Ej4_8
    Sub main()

        Dim dominios As New Hashtable
        Dim ingreso As String
        dominios.Add("ar", "Argentina")
        dominios.Add("ac", "Isla de la Ascencion")
        dominios.Add("ab", "Emiratos Arabes Unidos")
        dominios.Add("al", "Albania")
        dominios.Add("af", "Afganistan")
        dominios.Add("au", "Australia")
        dominios.Add("at", "Austria")
        dominios.Add("br", "Brasil")
        dominios.Add("bo", "Bolivia")

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
