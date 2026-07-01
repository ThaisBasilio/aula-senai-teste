using System;

class Program
{
    static double PerguntaDouble(string texto)
    {
        Console.Write(texto);
        return double.Parse(Console.ReadLine());
    }
    static int PerguntaInt(string texto)
    {
        Console.Write(texto);
        return int.Parse(Console.ReadLine());
    }
    static string PerguntaStr(string texto)
    {
        Console.Write(texto);
        return Parse(Console.ReadLine());
    }
    static void Main()
    {
        String funcionario;
        int horastrabalhadas;
        int dependentes;
        double salarioliquido;
        double salariobruto;

        funcionario = PerguntaStr("Insira o nome do funcionário: ");
        horastrabalhadas = PerguntaInt("Insira a quantidade de horas trabalhadas no mês do funcionário: ");
        dependentes = PerguntaInt("Insira a quantidade de dependentes do funcionário: ");

        salarioliquido = 15 * horastrabalhadas + dependentes * 50;
        salariobruto = salarioliquido * 0.92;

        Console.WriteLine($"Nome do funcionário: {funcionario}");
        Console.WriteLine($"Salário Bruto do funcionário: R${salariobruto}");
        Console.WriteLine($"Valor do desconto do salário: R${salarioliquido - salariobruto}");
        Console.WriteLine($"Salário Líquido do funcionário: R${salarioliquido}");
    }
}