using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Infore o seu salário:");
            float sal = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor total das suas dívida:");
            float div = float.Parse(Console.ReadLine());

            float sobra = sal - div;

            Console.WriteLine($"Restante no final do mês: R$ {sobra} reais");

        }
    }
}
