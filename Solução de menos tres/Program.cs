using System;
using System.Globalization;

namespace Primeiro{
    class Program{
        static void Main(String[] args){
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            //Variaveis
            int n1, n2, n3;

            //Digite os valores
            Console.Write("Digite o valores: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            //Descobrindo quem é o menor
            if (n1 < n2 && n1 < n3){
                Console.WriteLine("Menor = " + n1);
            } else if (n2 < n1 && n2 < n3){
                Console.WriteLine("Menor = " + n2);
            } else if (n3 < n1 && n3 < n2){
                Console.WriteLine("Menor = " + n3);
            }
        }
    }
}