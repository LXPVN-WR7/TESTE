using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a cotação do Dollar:");
            float cotacao = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor a ser convertido para Dollar:");
            float valor = float.Parse(Console.ReadLine());

            float valf = cotacao * valor;

            Console.WriteLine($"O valor convertido é {valf}");

        }
    }
}
