using System;
class Program{

    static void Main(){
        double numero;
        Console.Write("Digite um número: ");
        numero = double.Parse(Console.ReadLine());

        if (numero > 20) { Console.WriteLine("Este número é maior que 20");}
        else if (numero == 20) { Console.WriteLine("Este número é igual a 20");}
        else { Console.WriteLine("Este número é menor que 20");}

    }

}