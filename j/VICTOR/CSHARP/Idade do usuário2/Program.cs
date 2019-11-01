using System;

namespace Idade_do_usuário2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe o seu ano de nascimento:");
            int nasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu ano atual:");
            int atual = int.Parse(Console.ReadLine());

            int idade = atual - nasc;

            Console.WriteLine($"Sua idade é {idade}");
            Console.WriteLine($"Semana de idade: {idade * 52}");
        }
    }
}
