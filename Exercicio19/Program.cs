using System;

class Exercicio_19
{
    static double PerguntaDouble(string texto)
    {
        Console.Write(texto);
        return double.Parse(Console.ReadLine());
    }
    static void Main()
    {
        double salario;
        double desconto;

        salario = PerguntaDouble("Insira o salário do funcionário: ");
        desconto = Math.Min(salario * 0.11, 334.29);

        Console.WriteLine($"O salário final do funcionário será de {salario - desconto}, tendo um desconto de {desconto}.");
    }
}