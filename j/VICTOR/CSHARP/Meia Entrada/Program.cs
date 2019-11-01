using System;

namespace Meia_Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App de validação de meia entrada\nSeja Bem Vindo!");

            Console.WriteLine("Informe seu nome:");
            String nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if(idade < 18 || idade > 59){
                Console.WriteLine($"Parabéns {nome} você tem direito a meia entrada!");
            }else{
                Console.WriteLine("Você não tem direito da meia entrada!");
            }
        }
    }
}
