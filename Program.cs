using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("leia dois valores");

            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            int x = 0;
            if (b > a) {
                x = a;
                a = b;
                b = x;
            }

            string saida = "nulo";
            if (a % b == 0) {
                saida = "Sao multilos";
            }
            else {
                saida = "Nao sao multiplos";
            }

            Console.WriteLine(saida);
        }
    }
}