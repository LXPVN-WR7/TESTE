using System;

namespace Rodizio_Veícular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao sistema de rodizio veicular!");

            Console.WriteLine("Informe o ultimo número de sua placa:");
            String placa = Console.ReadLine();

            int caracteres = placa.Length;

            int final = int.Parse(placa.Substring(caracteres - 1));

            Console.WriteLine($"Quantida de caracteres: {caracteres}");

            if(final == 0 || final == 1){
                Console.WriteLine("Segunda-feira");
            }else if(final == 2 || final == 3){
                Console.WriteLine("Terça-feira");
            }else if(final == 4 || final == 5){
                Console.WriteLine("Quarta-feira");
            }else if(final == 6 || final == 7){
                Console.WriteLine("Quinta-feira");
            }else{
                Console.WriteLine("Sexta-feira");
            }
        }
    }
}
