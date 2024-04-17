using System;


namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, inss;
            char letras;


            do
            {
                Console.WriteLine("Informe seu salário:");
                salario = double.Parse(Console.ReadLine());

                if (salario <= 1412.00)
                {
                    inss = salario * 0.075;
                    inss = Math.Round(inss, 2);
                }
                else if (salario >= 1412.00 && salario <= 2666.68)
                {
                    inss = (2666.68 - 1412.00) * 0.075 + (salario - 1412.00) * 0.09;
                    inss = Math.Round(inss, 2);
                }
                else if (salario >= 2666.68 && salario <= 4000.03)
                {
                    inss = (2666.68 - 1412.00) * 0.075 + (4000.03 - 2666.68) * 0.09 + (salario - 2666.68) * 0.12;
                    inss = Math.Round(inss, 2);
                }
                else if (salario >= 4000.03 && salario <= 7786.02)
                {
                    inss = (2666.68 - 1412.00) * 0.075 + (4000.03 - 2666.68) * 0.09 + (7786.02 - 4000.04) * 0.12 + (salario - 4000.03) * 0.14;
                    inss = Math.Round(inss, 2);
                }
                else
                {
                    inss = (2666.68 - 1412.00) * 0.075 + (4000.03 - 2666.68) * 0.09 + (7786.02 - 4000.04) * 0.12 + (salario - 4000.03) * 0.14;
                    inss = Math.Round(inss, 2);
                }

                Console.Write("Deseja informar mais um voto ? [S/N] ");
                letras = char.Parse(Console.ReadLine());
            }
            while (letras != 'N');


            Console.WriteLine("Valor do seu desconto: " + inss);

            Console.ReadLine();

        }
    }
}
