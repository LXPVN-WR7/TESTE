using System;

namespace Tabuada_com_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada com laço FOR");

            Console.WriteLine("Qual tabuada deseja saber:");
            float tabuada = float.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada}x{i} = {tabuada * i}");
            }

        }
    }
}
