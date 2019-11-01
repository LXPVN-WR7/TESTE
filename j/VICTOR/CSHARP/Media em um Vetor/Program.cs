using System;

namespace Media_em_um_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            -----------------------------------------------------
            | SEJA BEM VINDO AO SISTEMA DE NOTAS DO ALUNO SENAI |
            -----------------------------------------------------
            ");

            double[] notas1 = new double[5];
            double[] nota2 = new double[5];
            String[] alunos = new string[5];
            int contador = 0;
            double[] media = new double[5];
            double medsala = 0;
            double somaTotal = 0;

            do
            {
                Console.WriteLine($"Informe o nome do {contador + 1} aluno");
                alunos[contador] = Console.ReadLine();
                Console.WriteLine("Informe a preimeira nota do aluno:");
                notas1[contador] = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a segunda nota do aluno:");
                nota2[contador] = double.Parse(Console.ReadLine());
                media[contador] = (notas1[contador] + nota2[contador]) /2;
                contador++;
            } while (contador < 2);
            contador = 0;
            while (contador < 2)
            {
                somaTotal += media[contador];
                contador++;
            }
        
            medsala = somaTotal/2;
            Console.WriteLine($"Média da sala: {medsala}");

        }
    }
}
