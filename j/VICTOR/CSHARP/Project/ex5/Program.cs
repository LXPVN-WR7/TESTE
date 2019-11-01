using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {    
            String[] nomes = new String[6];     

            Console.WriteLine("Informe o número de alunos a ser cadastrados:");
            int i = int.Parse(Console.ReadLine());
            
            for(int x = i; x > 0; x--) {

            Console.WriteLine("Informe o nome do funcionário:");    
            nomes[x] = Console.ReadLine();

            }

            for(int x = i; x > 0; x--){
                Console.WriteLine(nomes[x]);
            }
        }
    }
}
