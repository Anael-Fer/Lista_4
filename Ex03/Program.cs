using System;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double precokWh, quantkWh, total, mediaConsumo, maiorConsumo, menorConsumo;

            maiorConsumo = double.MinValue;
            menorConsumo = double.MaxValue;

            for (int i = 1; i <= 50; i++)
            {

                Console.WriteLine("Informe o preço do kWh:");
                precokWh = double.Parse(Console.ReadLine());


                Console.WriteLine("Informe a quantidade de kWh consumido por mês:");
                quantkWh = double.Parse(Console.ReadLine());

                total = precokWh * quantkWh;

                if(quantkWh > maiorConsumo)
                    maiorConsumo = quantkWh;

                if(quantkWh < menorConsumo)
                    menorConsumo = quantkWh;

                mediaConsumo = quantkWh / i;

                Console.WriteLine("O valor total a pagar é: " + total);
                Console.WriteLine("O maior consumo verificado é de: " + maiorConsumo);
                Console.WriteLine("O menor consumo verificado é de: " + menorConsumo);
                Console.WriteLine("A média entre os consumidores é de; " + mediaConsumo);

            }
            Console.ReadLine();

        }
    }
}
