using System;

class Exercicio14
{
    static void Main()
    {
        double a=0, b=0, x=0, y=0, z=0;

        Console.WriteLine("O valor de a : ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("O valor de b : ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("O valor de x : ");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("O valor de y : ");
        y = double.Parse(Console.ReadLine());

        Console.WriteLine("O valor de z : ");
        z = double.Parse(Console.ReadLine());

        if (a >= 5 && a <= 7)
        {
            Console.WriteLine($"Então o público tem 5 a 7 anos ");
        }

        if (a >= 8 && a <= 10)
        {
            Console.WriteLine($"Então o público tem 11 a 13 ");
        }

        if (a >= 11 && a <= 13)
        {
            Console.WriteLine($"Então o públicp tem 14 a 17 anos ");
        }

        if (z >= 18)
        {
            Console.WriteLine($"Então o público tem 18 ou mais de idade ");

        }
  
  
    }

    
}