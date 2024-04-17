using System;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double celsius, fahre, kelvin, graus;
            int opcao;

            do
            {

                Console.WriteLine("Selecione uma categoria desejada:");

                Console.WriteLine("Conversão de Celsius para Fahrenheit - (1)");
                Console.WriteLine("Conversão de Celsius para Kelvin - (2)");
                Console.WriteLine("Conversão de Fahrenheit para Celsius - (3)");
                Console.WriteLine("Conversão de Fahrenheit para Kelvin - (4)");
                Console.WriteLine("Conversão de Kelvin para Celsius - (5)");
                Console.WriteLine("Conversão de Kelvin para Fahrenheit - (6)");
                Console.WriteLine("Sair - (7)");

                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1)
                {
                    Console.WriteLine("Digite a temperatura em Celsius:");
                    celsius = double.Parse(Console.ReadLine());

                    fahre = (celsius * 9 / 5) + 32;

                    Console.WriteLine($"A temperatura em Celsius {celsius} é convertida para {fahre} graus Fahrenheit");
                }
                else if(opcao == 2)
                {
                    Console.WriteLine("Digite a temperatura em Celsius:");
                    celsius = double.Parse(Console.ReadLine());

                    kelvin = celsius + 273.15;

                    Console.WriteLine($"A temperatura em Celsius {celsius} é convertida para {kelvin} graus Kelvin");
                }
                else if(opcao == 3)
                {
                    Console.WriteLine("Digite a temperatura em Fahrenheit:");
                    fahre = double.Parse(Console.ReadLine());

                    celsius = (fahre - 32) * 5 / 9;

                    Console.WriteLine($"A temperatura em Fahrenheit {fahre} é convertida para {celsius} graus Celsius");
                }
                else if(opcao == 4)
                {
                    Console.WriteLine("Digite a temperatura em Fahrenheit:");
                    fahre = double.Parse(Console.ReadLine());

                    kelvin = (fahre - 32) * 5 / 9 + 273.15;

                    Console.WriteLine($"A temperatura em Fahrenheit {fahre} é convertida para {kelvin} graus Kelvin");
                }
                else if(opcao == 5)
                {
                    Console.WriteLine("Digite a temperatura em Kelvin:");
                    kelvin = double.Parse(Console.ReadLine());

                    celsius = kelvin - 273.15;

                    Console.WriteLine($"A temperatura em Kelvin {kelvin} é convertida para {celsius} graus Celsius");
                }
                else if(opcao == 6)
                {
                    Console.WriteLine("Digite a temperatura em Kelvin:");
                    kelvin = double.Parse(Console.ReadLine());

                    fahre = (kelvin - 273.15) * 9 / 5 + 32;


                    Console.WriteLine($"A temperatura em Kelvin {kelvin} é convertida para {fahre} graus Fahrenheit");
                }

            }
            while (opcao != 7);

            Console.ReadLine();
        }
    }
}
