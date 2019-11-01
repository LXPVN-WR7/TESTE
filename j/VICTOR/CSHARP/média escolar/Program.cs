using System;

namespace média_escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App Média escolar");

            Console.WriteLine("Informe o seu nome:");
            String nome = Console.ReadLine();

            Console.WriteLine("Informe a primeira nota:");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota:");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota:");
            float n3 = float.Parse(Console.ReadLine());

            float nf = (n1 + n2 + n3) /3;

            String resultado;

            if(nf >= 7) {
                resultado = "APROVADO!";
            }else{
                resultado = "REPROVADO!";
            }

            Console.WriteLine($"O aluno {nome} está {resultado} pela nota {nf}");

        }
    }
}
