using System;

class Exercicio_17
{
    static double PerguntaDouble(string texto)
    {
        Console.Write(texto);
        return double.Parse(Console.ReadLine());
    }
    static void Main()
    {
        double indice;

        indice = PerguntaDouble("Insira o índice de poluição: ");

        if (indice < 0.25) {
            Console.WriteLine("Índice aceitável.");
        } else if (indice < 0.4) {
            Console.WriteLine("Notifique o 1º grupo para suspender atividades.");
        } else if (indice < 0.5) {
            Console.WriteLine("Notifique o 1º e 2º grupos para suspenderem atividades.");
        } else {
            Console.WriteLine("Notifique todos os 3 grupos para paralisarem as atividades.");
        }
    }
}