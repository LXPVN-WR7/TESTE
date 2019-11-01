using System;

namespace Desafio__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            ----------------------------------------------------------
            | Olá seja Bem Vindo ao sitema de cadastramento do SENAI |
            ----------------------------------------------------------
            ");

            Console.WriteLine("Informe o seu nome:");
            String nome = Console.ReadLine();

            Console.WriteLine($"OK {nome} vamos comceçar!");

            String email;

            do{

            Console.WriteLine("Informe o seu E-mail de usuário do SENAI:");
            email = Console.ReadLine();

            }while(!(email.Contains("@") && email.Contains(".")));

        }
    }
}
