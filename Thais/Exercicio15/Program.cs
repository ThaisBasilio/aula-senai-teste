using System;
class Program{
    static void Main(){
        double salario;
        int codigo;
        double aumento;
        Console.Write("Digite o salário atual: ");
        salario = double.Parse(Console.ReadLine());
        Console.Write("Digite o código do cargo: ");
        codigo = int.Parse(Console.ReadLine());

        if (codigo == 101){aumento = salario * 0.10;}
        else if (codigo == 102){aumento = salario * 0.20;}
        else if (codigo == 103){aumento = salario * 0.30;}
        else {aumento = salario * 0.40;}

        double novosalario = salario + aumento;

        Console.WriteLine($"Salário antigo = {salario:F2}, o novo salário é = {novosalario:F2} e a diferença no salário foi = {aumento:F2}");

            
    }
}

