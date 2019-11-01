using System;

namespace Menu_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo ao menu de calculo!");
            
            Console.WriteLine("Informe o 1 valor:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2 valor:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|(1) - Soma de 2 números                  |");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|(2) - Subtração do primeiro pelo segundo |");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|(3) - Subtração do segundo pelo primeiro |");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|(4) - Multiplicação dos dois números     |");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|(5) - Divisão do primeiro pelo segundo   |");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|(6) - Divisão do segundo pelo primeiro   |");
            Console.WriteLine("|-----------------------------------------|");

            String resposta = Console.ReadLine();

            switch(resposta){
                
                case "1":
                double final = num1 + num2;
                Console.WriteLine($"A soma dos dois valores é {final}");
                break;

                case "2":
                double final2 = num1 - num2;
                Console.WriteLine($"A subtração do primeiro pelo segundo é {final2}");
                break;

                case "3":
                double final3 = num2 - num1;
                Console.WriteLine($"A subtração do segundo pelo primeiro é {final3}");
                break;

                case "4":
                double final4 = num1 * num2;
                Console.WriteLine($"A multiplicação dos dois valores é {final4}");
                break;

                case "5":
                double final5 = num1/num2;
                Console.WriteLine($"A divisão do primeiro pelo segundo é {final5}");
                break;

                case "6":
                double final6 = num2/num1;
                Console.WriteLine($"A divisão do segundo pelo primeiro é {final6}");
                break;

                default:
                Console.WriteLine("Valor invalido!\nTente novamente :)");
                break;
            }
        }
    }
}
