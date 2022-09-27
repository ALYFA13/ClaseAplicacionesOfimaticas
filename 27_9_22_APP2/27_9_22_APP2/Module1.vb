Module Module1

    Sub Main()
        Dim precI, precF As Single
        Dim descuento As Byte 'porq no va a pasar del 100% el porcentaje
        Convert.ToSingle(descuento)

        Console.WriteLine("¿Precio inicial?")
        precI = Convert.ToSingle(Console.ReadLine())
        Console.WriteLine("¿Descuento?")
        descuento = Convert.ToByte(Console.ReadLine())

        precF = Convert.ToSingle(precI - (precI * descuento / 100))
        Console.WriteLine("Precio final: " & precF)


        Console.ReadLine()

    End Sub

End Module
