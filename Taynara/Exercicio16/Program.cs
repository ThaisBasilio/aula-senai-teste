using System;
using System.Diagnostics.CodeAnalysis;

class Exercicio16
{
    static void Main()
    {
        double sal=0;

        Console.WriteLine("Digite o saldo: ");
        sal = double.Parse(Console.ReadLine());

        if (sal <= 10000000)
        {
            Console.WriteLine($"Com o {sal} o cliente é denominado VIP ");
        }
        else if (sal >= 500000 && sal <= 10000000)
        {
            Console.WriteLine($"Com o {sal} o cliente é taxado como MIDDLE ");
        }
        else
        {
            Console.WriteLine($"Com o {sal} o vliente será taxado como USUAL ");
        }
    }
}


