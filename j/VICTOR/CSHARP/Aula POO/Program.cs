using System;
using Aula_POO.Models;

namespace Aula_POO
{
    class Programx
    {
        static void Main(string[] args)
        {
            // Declarando objeto
            AlunoModel aluno1 = new AlunoModel(); // Instanciando aluno 
        
            // Limpa a tela
            Console.Clear();
        
            // Lendo o nome
            System.Console.WriteLine("Insira o nome do aluno:");
            aluno1.Nome = Console.ReadLine();

            // Lendo nome do curso 
            System.Console.WriteLine("Insira o curso:");
            aluno1.Curso = Console.ReadLine();

            // Lendo RG
            System.Console.WriteLine("Insira o RG:");
            aluno1.Rg = int.Parse(Console.ReadLine());

            // Lendo idade
            System.Console.WriteLine("Insira a idade:");
            aluno1.idade = int.Parse(Console.ReadLine());

            // Exibindo as informações
            System.Console.WriteLine($@"
            Nome: {aluno1.Nome}
            Curso: {aluno1.Curso}
            RG: {aluno1.Rg}
            Idade: {aluno1.idade}   
            ");

        }
    }
}
