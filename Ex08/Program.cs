using System;


namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int raiz, subtracao;
            double numero;

            raiz = 0;
            subtracao = 1;

            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            do
            {
                numero -= subtracao;
                subtracao += 2;
                raiz++;
            } while (numero > 0);

            if (numero < 0)
            {
                raiz--;
            }

            Console.WriteLine($"A raiz quadrada é aproximadamente: {raiz}");

            Console.ReadLine();
        }
    }
}
