using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Informe o seu salário:");
            float sal = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas efetuadas:");
            float vends = int.Parse(Console.ReadLine());

            float valf = (5 * vends) /100;
            valf = valf + sal;

            Console.WriteLine($"Você irá receber {valf}");
        }
    }
}
