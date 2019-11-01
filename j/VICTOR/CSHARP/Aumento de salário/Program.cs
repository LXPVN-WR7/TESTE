using System;

namespace Aumento_de_salário
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o seu nome:");
            String nome = Console.ReadLine();

            Console.WriteLine("Informe o seu salário:");
            float sal = float.Parse(Console.ReadLine());

            double aumento = sal * 0.3;

            double salario_final = sal + aumento;

            if(sal <= 990){
                Console.WriteLine($"{nome} seu aumento foi aprovado, seu salário foi reajustado para R$ {salario_final} reais");
            }else{
                Console.WriteLine($"{nome} seu aumento foi reprovado!");
            }
        }
    }
}