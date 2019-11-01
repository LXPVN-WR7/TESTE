using System;

namespace Categoria_do_usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if(idade <= 7){ 
                Console.WriteLine("Categotia Infantil A");
            }else if( idade <= 10){
                Console.WriteLine("Categotia Infantil B");
            }else if(idade <= 13){
                Console.WriteLine("Categoria Juvenil A");
            }else if(idade <= 17){
                Console.WriteLine("Categoria Juvinil B");
            }else{
                Console.WriteLine("Categoria Maiores de 18 anos");
            }
        }
    }
}
