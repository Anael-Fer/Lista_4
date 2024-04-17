using System;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaMaiorTemp, diaMenorTemp;
            double temp, tempMax, tempMin;

            tempMax = double.MinValue;
            tempMin = double.MaxValue;

            diaMaiorTemp = diaMenorTemp = 0;

            for (int i = 1; i <= 31; i++)
            {

                Console.WriteLine("Escreva a temperatura média do dia de hoje:");
                temp = double.Parse(Console.ReadLine());

                if (temp > tempMax)
                {
                    tempMax = temp;
                    diaMaiorTemp = i;
                }

                if (temp < tempMin)
                {
                    tempMin = temp;
                    diaMenorTemp = i;
                }

                Console.WriteLine($"A maior temperatura registrada foi de {tempMax} no dia {diaMaiorTemp}");
                Console.WriteLine($"A menor temperatura registrada foi de {tempMin} no dia {diaMenorTemp}");

            }
            Console.ReadLine();


        }
    }
}
