using System;

namespace Impar_ou_Par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            int num2 = int.Parse(Console.ReadLine());

            if((num1 % 2) == 0) {
                Console.WriteLine($"O valor {num1} é par!");
            }else{
                Console.WriteLine($"O valor {num1} é impar!");
            }

            if((num2 % 2) == 0) {
                Console.WriteLine($"O valor {num2} é par!");
            }else{
                Console.WriteLine($"O valor {num2} é impar!");
            }

            if(num1 > num2){
                Console.WriteLine($"O valor {num1} é maior que o valor {num2}!");
            }else{
                Console.WriteLine($"O valor {num2} é maior que o valor {num1}!");                                                                          
            }
        }
    }
}
