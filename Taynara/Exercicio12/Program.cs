using System;

class Exercicio12
{
    static void Main()
    {
        
        int i=0;
        Console.WriteLine("Informe o número: ");
        i = int.Parse(Console.ReadLine());

        if (i % 2 == 0)
        {
            Console.WriteLine($"{i} é par: ");

        }
        else
        {
            Console.WriteLine($"{i} é impar: ");
            
        }
        
        }
}