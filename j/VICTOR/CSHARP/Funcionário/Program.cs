using System;

namespace Funcionário
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o seu nome:");
            String nome = Console.ReadLine();

            Console.WriteLine($"Informe o seu salário {nome}:");
            double sal = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|    CÓDIGO    |    CARGO    |     PERCENTUAL    |");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|      (1)     | Escrituário |        50%        |");
            Console.WriteLine("|      (2)     | Secretário  |        35%        |");
            Console.WriteLine("|      (3)     | Caixa       |        20%        |");
            Console.WriteLine("|      (4)     | Gerente     |        10%        |");
            Console.WriteLine("|      (5)     | Diretor     |  Não tem aumento  |");
            Console.WriteLine("--------------------------------------------------");

        
            String resposta = Console.ReadLine();

            switch(resposta){
                case "1":
                double reajuste = 0.5 * sal; 
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"|Nome do funcionários: {nome}                    |");
                Console.WriteLine($"|Salário do funcionário: R$ {sal} reais           |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|    CÓDIGO    |    CARGO    |     PERCENTUAL    |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|      (1)     | Escrituário |        50%        |");
                Console.WriteLine("--------------------------------------------------");
                sal += reajuste;
                Console.WriteLine($"|Salario reajustado: {sal}                        |");
                Console.WriteLine("--------------------------------------------------");
                break;

                case "2":
                double reajuste2 = 3.5 * sal; 
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"|Nome do funcionários: {nome}                    |");
                Console.WriteLine($"|Salário do funcionário: R$ {sal} reais           |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|    CÓDIGO    |    CARGO    |     PERCENTUAL    |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|      (2)     | Secretário  |        35%        |");
                Console.WriteLine("--------------------------------------------------");
                sal += reajuste2;
                Console.WriteLine($"|Salario reajustado: {sal}                        |");
                Console.WriteLine("--------------------------------------------------");
                break;
            
                case "3":
                double reajuste3 = 0.2 * sal; 
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"|Nome do funcionários: {nome}                    |");
                Console.WriteLine($"|Salário do funcionário: R$ {sal} reais           |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|    CÓDIGO    |    CARGO    |     PERCENTUAL    |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|      (3)     |    Caixa    |        20%        |");
                Console.WriteLine("--------------------------------------------------");
                sal += reajuste3;
                Console.WriteLine($"|Salario reajustado: {sal}                        |");
                Console.WriteLine("--------------------------------------------------");
                break;

                case "4":
                double reajuste4 = 0.1 * sal; 
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"|Nome do funcionários: {nome}                    |");
                Console.WriteLine($"|Salário do funcionário: R$ {sal} reais           |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|    CÓDIGO    |    CARGO    |     PERCENTUAL    |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|      (4)     |   Gerente   |        10%        |");
                Console.WriteLine("--------------------------------------------------");
                sal += reajuste4;
                Console.WriteLine($"|Salario reajustado: {sal}                        |");
                Console.WriteLine("--------------------------------------------------");
                break;

                case "5":
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"|Nome do funcionários: {nome}                    |");
                Console.WriteLine($"|Salário do funcionário: R$ {sal} reais           |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|    CÓDIGO    |    CARGO    |     PERCENTUAL    |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|      (5)     |   Diretor   |  Não tem aumento  |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"|Salario não possui reajuste!                    |");
                Console.WriteLine("--------------------------------------------------");
                break;
            }
        }
    }
}