Module Module1

    Sub Main()

        'calculamos la hipotenusa en triángulo rectángulo
        Dim lado1, lado2, h As Double

        Console.WriteLine("¿Lado 1?")
        lado1 = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("¿Lado 2?")
        lado2 = Convert.ToDouble(Console.ReadLine())

        h = (lado1 * lado1 + lado2 * lado2) ^ (1 / 2)
        'el simbolo "^", se puede sustituir por "Math.Pow(lado1,2)" (primero ponemos el nº y luego a cuanto lo elevamos)
        'y la raiz por "Math.Sqrt()"

        'Debemos redondear a las centésimas, usaremos "Math.Round(h,2)"
        Console.WriteLine("Hipotenusa = " & Math.Round(h, 2)) 'no se guarda la aproximación para más tarde
        Console.WriteLine("Hipotenusa = " & h) 'aquí lo vemos
        h = Math.Round(h, 2) 'se guarda la aproximación para más tarde
        Console.WriteLine("Hipotenusa = " & h) 'aquí lo vemos


        Console.ReadLine()

    End Sub

End Module
