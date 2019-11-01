using System;

namespace Funções_e_Métodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(message());

            Console.WriteLine("Aprendendo Funções");

            Console.WriteLine("Informe o primeiro valor:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O rsultado da soma é {SomaDeDoisNumeros(num1, num2)}");
        } // Fim do main

            /// <summary>Efetua a soma de dois números</summary>
            /// <param name="a"> Primeiro valor inteiro</param>
            /// <param name="b"> Segundo valor inteiro</param>
            /// <return> Retorno a soma dos dois números</return> 

        public static int SomaDeDoisNumeros(int a, int b){

                int soma = a + b;

                return soma;

            }

            /// <summary>
            /// Retorna o texto de boas vindas
            /// </summary>
            
            

        public static string message(){
            
            return "Seja Bem Vindo ao SENAI";
        }
    }
}
