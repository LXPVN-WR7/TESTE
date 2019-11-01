using System;

namespace Agência_de_Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            ----------------------------
            | Agência de Turismo SENAI |
            |      Seja Bem Vindo!     |
            ----------------------------
            ");

            String[] nome = new string[5];
            String[] origem = new string[5];
            String[] destino = new string[5];
            DateTime[] data = new DateTime[5];

            int opcao = 0; int contador = 0;

            do
            {

                Console.WriteLine(@"
                
            Selecione uma opção
            (1) - Cadastrar Passagem
            (2) - Listar Passagens
            (0) - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Vamos Cadastrar Agora");
                        String resposta = "";
                        do
                        {
                            if(contador <= 2){
                            Console.WriteLine("Digite o nome do passgeiro");
                            nome[contador] = Console.ReadLine();

                            Console.WriteLine("Informe a origem");
                            origem[contador] = Console.ReadLine();

                            Console.WriteLine("Informe o destino:");
                            destino[contador] = Console.ReadLine();

                            Console.WriteLine("Informe a Data do Vôo:");
                            data[contador] = DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Você deseja cadastrar mais um ? S/N");
                            resposta = Console.ReadLine();
                            contador++;
                            }else{
                                Console.WriteLine("Número de passagens Excedida");
                            }
                        }while (resposta == "S");
                    break;
                    case 2:
                        Console.WriteLine("Listando as passagens");
                        int contadorB = 0;
                        while(contadorB < 2)    
                        {
                            Console.WriteLine($"Passageiros nome: {nome[contadorB]}, orrigem: {origem[contadorB]}");
                            contadorB++;
                        }
                    break;

                    case 0:
                        Console.WriteLine("Obrigado  por usar nosso sistema");
                    break;

                    default:
                        Console.WriteLine("Opção invalida");
                    break;
                }
            } while (opcao != 0);
        }
    }
}
