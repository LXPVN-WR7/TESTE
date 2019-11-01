using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"O triplo do seu número é {num * 3}");
        }
    }
}
