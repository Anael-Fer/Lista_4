using System;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            double soma, fatorial;

            soma = fatorial = 1;

            Console.WriteLine("Escreva um valor inteiro e positivo:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                fatorial *= i;
                soma += 1 * (1/fatorial);


                Console.WriteLine("O valor da soma é de: " + soma);
            }
            Console.ReadLine();
        }
    }
}
