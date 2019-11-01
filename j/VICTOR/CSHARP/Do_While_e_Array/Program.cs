using System;

namespace Do_While_e_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While com Array");

            String [] nomes = new String [3];

            int contador = 0;
            
            while(contador < 3){
                Console.WriteLine($"Digite o {contador+1}° nome:");
                nomes[contador] = Console.ReadLine();
                contador++;
            }           
            contador = 0;
            while(contador < 3){
                Console.WriteLine($"Nomes{contador+1}: {nomes[contador]}");
                contador++;
            }
        }
    }
}
