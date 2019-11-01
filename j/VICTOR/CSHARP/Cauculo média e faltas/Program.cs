using System;

namespace Cauculo_média_e_faltas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App Cálculo de Médias e Faltas");
            Console.WriteLine("Bem vindo a Escola SENAI de Informática");

            Console.WriteLine("Informe o nome do aluno:");
            String nome = Console.ReadLine();

            Console.WriteLine("Informe a primeria nota do aluno:");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno:");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota do aluno:");
            int nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de faltas:");
            int faltas = int.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) /3;

            if(media >= 7 && faltas <= 25){
                Console.WriteLine($"Parabéns {nome} vocÊ foi aprovado!");
            }else if(media >= 5 && faltas <= 25){
                Console.WriteLine($"Parabéns {nome} você foi aprovado com DP!");
            }else{
                Console.WriteLine($"Parabéns {nome} você foi reprovado!");
            }
            
            Console.WriteLine($"Nota: {media}\nFaltas: {faltas}");
        
        }   
    }
}