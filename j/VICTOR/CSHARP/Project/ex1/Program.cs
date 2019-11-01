using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_inicial;

            double dollar = (0.25);

            Console.WriteLine("Informe o valor a ser convertido para Dollar:");
            valor_inicial = double.Parse(Console.ReadLine());

            double conversao = (valor_inicial * dollar);

            Console.WriteLine($"O valor convertido é {conversao}");     

        }
    }
}