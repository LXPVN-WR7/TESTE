using System;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            double vale = 4.30;

            Console.WriteLine("Informe a quantidade de passageiros:");
            int pass = int.Parse(Console.ReadLine());

            double lucro = pass * vale;

            Console.WriteLine($"Valor arrecadado: {lucro}");


        }
    }
}
