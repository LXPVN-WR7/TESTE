using System;

namespace Calculo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;

            Console.WriteLine("Informe a primeira nota:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota:");
            n3 = int.Parse(Console.ReadLine());

            // Outra maneira de converter o resultado para Float
            // float media = (float)(n1 + n2 + n3) / 3;

            float soma = (n1 + n2 + n3);
            float media = soma / 3;

            if(media < 7){
                Console.WriteLine("ALUNO APROVADO!");
            }else{
                Console.WriteLine("ALUNO REPROVADO!");  
            }
        }
    }
}