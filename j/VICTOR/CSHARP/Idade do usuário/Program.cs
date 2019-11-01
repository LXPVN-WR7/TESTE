using System;

namespace Idade_do_usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade:");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias = idade * 365;
            int horas = idade * 8640;
            int minutos = idade * 518400;

            Console.WriteLine($"Meses: {meses} \nDias: {dias} \nHoras: {horas} \nMinutos: {minutos}");
        }
    }
}
