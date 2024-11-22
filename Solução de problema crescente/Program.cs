using System;

namespace Primeiro{
    class Program{
        static void Main(string[] args){
            //Variaveis
            int X, Y;

            //Digite o valor
            Console.Write("Digite o valor de X: ");
            X = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            Y = int.Parse(Console.ReadLine());

            //Descobrindo quem é o menor
            if (X > Y){
                Console.WriteLine("DECRESCENTE!");
            } else if (X < Y){
                Console.WriteLine("CRESCENTE!");
            }
        }
    }
}