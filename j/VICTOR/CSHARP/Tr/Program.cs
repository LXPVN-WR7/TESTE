using System;

namespace Tr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            
            -------------------------------------------------
            | Seja bem vindo ao seitema de compras do SENAI |
            -------------------------------------------------

                       -----------       ------------
                  (1)  | Começar |  (2)  | Cancelar |
                       -----------       ------------

            "); 

            String resposta = Console.ReadLine();

            if(resposta == "1"){
                
                Console.WriteLine("Informe o seu nome:");
                String nome = Console.ReadLine();
                
                Console.WriteLine($"Ok {nome} vamos começar");

                String [] produtos = new String [];

                while(produtos )

            }
        }
    }
}
