using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] nomes = new string[10];
            int[] idade = new int[10];
            double[] peso = new double[10];
            float[] altura = new float[10];
            String[] sexo = new string[10];
            int i = 0;
            char reposta;

            Console.WriteLine(@"
                --------------------------------------------------
                | SEJA BEM VINDO AO SISTEMA DE CADASTRO DO SENAI |
                --------------------------------------------------

                (1) - Cadastrar aluno
                (2) - Total de homens 
                (3) - Total de mulheres
                (4) - Média de idade dos homens
                (5) - Média de idade das mulheres 
                (6) - Nome e IMC dos homens e das mulheres
                (7) - Sair
            ");

            Console.Write("Selecione uma opcão:");
            String resp = Console.ReadLine();


            switch (resp)
            {
                case "1":

                    do
                    {

                        Console.Write("Informe o seu nome: ");
                        nomes[i] = Console.ReadLine();

                        Console.Write("\nInforme sua idade: ");
                        idade[i] = int.Parse(Console.ReadLine());

                        Console.Write("\nInforme seu peso: ");
                        peso[i] = double.Parse(Console.ReadLine());

                        Console.Write("\nInforme sua altura: ");
                        altura[i] = float.Parse(Console.ReadLine());

                        Console.Write("\nInforme seu gênero: ");
                        sexo[i] = Console.ReadLine();

                        i++;

                        Console.Write("\nDeseja cadastrar mais um aluno ? (S/N)");
                        reposta = char.ToUpper(char.Parse(Console.ReadLine()));

                    } while (reposta == 'S');
                    break;
            }
        }
    }
}
