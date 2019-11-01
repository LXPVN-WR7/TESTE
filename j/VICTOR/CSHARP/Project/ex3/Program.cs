using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args){

            int maiores = 0;
            int menores = 0;

            Console.WriteLine("1 usuário informe sua idade:");
            int user1 = int.Parse(Console.ReadLine());

            if(user1 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine("2 usuário informe sua idade:");
            int user2 = int.Parse(Console.ReadLine());

            if(user2 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine("3 usuário informe sua idade:");
            int user3 = int.Parse(Console.ReadLine());
                
            if(user3 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine("4 usuário informe sua idade:");
            int user4 = int.Parse(Console.ReadLine());

            if(user4 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine("5 usuário informe sua idada:");
            int user5 = int.Parse(Console.ReadLine());

            if(user5 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine("6 usuário informe a sua idade:");
            int user6 = int.Parse(Console.ReadLine());

            if(user6 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine("7 usuário informe sua idade:");
            int user7 = int.Parse(Console.ReadLine());

            if(user7 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine("8 usuário informe sua idade");
            int user8 = int.Parse(Console.ReadLine());
            
            if(user8 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine("9 usuário informe sua idade:");
            int user9 = int.Parse(Console.ReadLine());
            
            if(user9 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine("10 usuário informe sua idade:");
            int user10 = int.Parse(Console.ReadLine());
        
            if(user10 >= 18){
                maiores += 1;
            }else{
                menores += 1;
            }

            Console.WriteLine($"Usuário mairores de idade: {maiores}\nUsuário menores de idade: {menores}");

        }
    }
}
