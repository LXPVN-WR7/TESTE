using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe o seu nome:");
            String nome = Console.ReadLine();

            Console.WriteLine("Informe o seu salário:");
            float sal = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor total de vendas efetuadas:");
            float vendas = float.Parse(Console.ReadLine());

            double comissao = (0.1 * vendas);

            Console.WriteLine($"Nome do vendedor: {nome}\nSalário: {sal}\nSalário reajustado: {sal + comissao}");        
        
        }
    }
}
