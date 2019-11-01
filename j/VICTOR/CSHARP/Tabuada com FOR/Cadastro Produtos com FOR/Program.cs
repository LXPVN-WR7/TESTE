using System;

namespace Cadastro_Produtos_com_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de produtos com FOR");

            String[] produtoNome = new string[3];
            double[] produtoPreco = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Informe o nome do {i + 1}° produto: ");
                produtoNome[i] = Console.ReadLine();

                Console.WriteLine($"Informe o preço do {i + 1}° produto: ");
                produtoPreco[i] = double.Parse(Console.ReadLine());
            }
            foreach (var produto in produtoNome)
            {
                Console.WriteLine($"Produto: {produto}");
            }

            foreach (var preco in produtoPreco)
            {
                Console.WriteLine($"Preço: {preco}");
            }
        }
    }
}
