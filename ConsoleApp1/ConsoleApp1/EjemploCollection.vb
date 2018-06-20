Module EjemploCollection
    'Sub main()
    '    Dim frutas As New Collection

    '    frutas.Add("Albahaca", "Ma")
    '    frutas.Add("Cebollita de verdeo", "CV")
    '    frutas.Add("Perejil", "PE")

    '    For Each fruta In frutas
    '        Console.WriteLine(fruta)
    '    Next

    '    Console.WriteLine(frutas.Item(1))
    '    Console.WriteLine(frutas.Item("cv"))
    '    frutas.Remove("PE")
    '    Console.WriteLine("Cantidad: " & frutas.Count)

    '    For Each fruta In frutas
    '        Console.WriteLine(fruta)
    '    Next
    '    Console.WriteLine("Cantidad: " & frutas.Count)

    '    frutas.Clear()
    '    Console.WriteLine("Cantidad: " & frutas.Count)

    'End Sub

    'Sub main()
    '    Dim frutas As Hashtable
    '    'instanciacion
    '    frutas = New Hashtable
    '    'agregamos los elementos
    '    frutas.Add("MZ", "Manzana")
    '    frutas.Add("PE", "Pera")
    '    frutas.Add("DU", "Durazno")
    '    'mostramos los elementos de la coleccion
    '    For Each fruta As DictionaryEntry In frutas
    '        Console.WriteLine(fruta.Key & " - " & fruta.Value)
    '    Next
    '    Console.WriteLine("cantidad de elementos: " & frutas.Count)
    '    Console.ReadKey()

    '    Console.Write("Ingrese clave: ")
    '    Dim clave As String
    '    clave = Console.ReadLine()
    '    If frutas.Contains(clave) Then
    '        Console.WriteLine("La clave existe " & frutas.Item(clave))
    '    Else
    '        Console.WriteLine("La clave no existe")
    '    End If
    '    Console.ReadKey()

    'End Sub

    'Sub main()
    '    Dim frutas As New Stack
    '    frutas.Push("Manzana")
    '    frutas.Push("Pera")
    '    Console.WriteLine(frutas.Pop)
    '    frutas.Push("sandia")
    '    frutas.Push("kiwi")
    '    'mostrar todos los elementos
    '    Console.WriteLine("solo se muestran")
    '    For Each fruta In frutas
    '        Console.WriteLine(fruta)
    '    Next
    '    Console.WriteLine("ahora se extraen")
    '    Console.WriteLine(frutas.Pop)
    '    Console.WriteLine(frutas.Pop)
    '    Console.WriteLine(frutas.Pop)
    '    Console.ReadKey()
    'End Sub

    'Sub main()
    '    Dim frutas As New Queue
    '    frutas.Enqueue("Manzana")
    '    frutas.Enqueue("Pera")
    '    Console.WriteLine(frutas.Dequeue)
    '    frutas.Enqueue("Sandia")
    '    frutas.Enqueue("kiwi")
    '    Console.WriteLine("---------------")
    '    'extrae si hay un elemento al menos
    '    Do While frutas.Count > 0
    '        Console.WriteLine(frutas.Dequeue)
    '    Loop
    '    Console.ReadKey()


    'End Sub

    'Collecciones genericas (list)
    'Sub main()
    '    'declaracion e instanciacion
    '    Dim frutas As List(Of String)
    '    frutas.Add("yaca")
    '    frutas.Add("Melon")
    '    frutas.Add("Sandia")
    '    For Each fruta In frutas
    '        Console.WriteLine(fruta)
    '    Next
    '    Console.WriteLine("indice 1: " & frutas.Item(1))
    '    frutas.Insert(1, "kiwi")
    '    'ordenar
    '    frutas.Sort()
    '    'invierte el orden actual
    '    frutas.Reverse()
    '    'elimino la posicion 3
    '    frutas.RemoveAt(3)
    '    Console.WriteLine("todos con un for")
    '    For x As Integer = 1 To frutas.Count - 1
    '        Console.WriteLine(frutas.Item(x))
    '    Next
    'End Sub

    'colecciones genericas (sortedList)
    'Sub main()
    '    Dim frutas As SortedList(Of String, String)
    '    'instanciacion
    '    frutas = New SortedList(Of String, String)
    '    'agregamos los elementos
    '    frutas.Add("MZ", "Manzana")
    '    frutas.Add("PE", "Pera")
    '    frutas.Add("DU", "Durazno")
    '    frutas.Add(10, "sandia")
    '    frutas.Add(45736, "palta")
    '    'mostramos los elementos de la coleccion
    '    For Each fruta As KeyValuePair(Of String, String) In frutas
    '        Console.WriteLine(fruta.Key & " - " & fruta.Value)
    '    Next
    '    Console.WriteLine("cantidad de elementos: " & frutas.Count)
    '    Console.ReadKey()

    '    'Console.Write("Ingrese clave: ")
    '    'Dim clave As String
    '    'clave = Console.ReadLine()
    '    'If frutas.Contains(clave) Then
    '    '    Console.WriteLine("La clave existe " & frutas.Item(clave))
    '    'Else
    '    '    Console.WriteLine("La clave no existe")
    '    'End If
    '    'Console.ReadKey()
    'End Sub

    'lista doble enlazada
    Sub main()
        Dim ciudades_ruta12 As New LinkedList(Of String)
        ciudades_ruta12.AddFirst("Posadas")
        ciudades_ruta12.AddLast("Iguazu")
        ciudades_ruta12.AddAfter(ciudades_ruta12.Find("Posadas"), "Candelaria")
        ciudades_ruta12.AddBefore(ciudades_ruta12.Find("Iguazu"), "Eldorado")

        For Each ciudad In ciudades_ruta12
            Console.WriteLine(ciudad)
        Next

    End Sub



End Module
