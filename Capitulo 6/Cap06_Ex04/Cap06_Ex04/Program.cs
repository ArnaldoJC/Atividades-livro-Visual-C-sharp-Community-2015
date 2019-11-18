using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NOME = new string[5];
            int I, J;
            string X;

            //Entrada de dados

            for (I = 0; I <= 4; I++)
            {
                Console.Write("Entre o {0}° nome: ", I + 1);
                NOME[I] = Console.ReadLine();
            }

            // Processamento ordenado

            for (I = 0; I <= 3; I++)
                for (J = I + 1; J <= 4; J++)
                    if (NOME[I].CompareTo(NOME[J]) > 0) // "compareTo" compara dois strings
                    {
                        X = NOME[I];
                        NOME[I] = NOME[J];
                        NOME[J] = X;
                    }
            Console.WriteLine();

            // Apresentação dos arranjos

            Console.WriteLine("Lista de nomes ordenada");
            Console.WriteLine();

            for (I = 0; I <= 4; I++)
                Console.WriteLine(NOME[I]);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
