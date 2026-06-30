using System;
class Program{
    static void Main(){
        double salario;
        double prestacao;
        Console.WriteLine("Digite o valor do salário: ");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da prestação: ");
        prestacao = double.Parse(Console.ReadLine());

        if (prestacao > salario * 0.20) {Console.WriteLine("O empréstimo não pode ser concedido.");}
        else {Console.WriteLine("O empréstimo pode ser concedido.");}
            
    }
}
