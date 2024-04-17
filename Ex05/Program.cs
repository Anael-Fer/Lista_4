using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votos, cont1, cont2, cont3, branco, nulo;
            string maisVotado;
            char letra;

            cont1 = cont2 = cont3 = branco = nulo = 0;

            do
            {
                Console.WriteLine("Candidato 1 - (1)");
                Console.WriteLine("Candidato 2 - (2)");
                Console.WriteLine("Candidato 3 - (3)");
                Console.WriteLine("Voto em branco - (4)");
                Console.WriteLine("Voto nulo - invalido");

                Console.WriteLine("Digite o número do seu voto");
                votos = int.Parse(Console.ReadLine());

                if (votos == 1)
                    cont1++;
                else if(votos ==2)
                    cont2++;
                else if (votos == 3) 
                    cont3++;
                else if (votos == 4)
                    branco++;
                else
                    nulo++;

                if (cont1 >= cont2 && cont1 >= cont3)
                    maisVotado = "Candidato 1";
                else if (cont2 >= cont1 && cont2 >= cont3)
                    maisVotado = "Candidato 2";
                else
                    maisVotado = "Candidato 3";

                Console.Write("Deseja informar mais um voto ? [S/N] ");
                letra = char.Parse(Console.ReadLine());
            }

            while (letra != 'N');

            Console.WriteLine("Total de votos do candidato 1: " + cont1);
            Console.WriteLine("Total de votos do candidato 2: " + cont2);
            Console.WriteLine("Total de votos do candidato 3: " + cont3);
            Console.WriteLine("Candidato com mais votos: " + maisVotado);
            Console.WriteLine("Total de votos nulos: " + nulo);
            Console.WriteLine("Total de votos em branco: " + branco);

            Console.ReadLine();
        }
    }
}
