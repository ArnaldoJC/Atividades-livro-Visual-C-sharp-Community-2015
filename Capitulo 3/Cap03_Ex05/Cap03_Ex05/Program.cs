using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME1, NOME2, SEXO1, SEXO2;

            Console.Write("Entre o 1º nome ...........: ");
            NOME1 = Console.ReadLine();
            Console.Write("Entre com o sexo do 1° nome: ");
            SEXO1 = Console.ReadLine();

            Console.Write("Entre o 2º nome ...........: ");
            NOME2 = Console.ReadLine();
            Console.Write("Entre com o sexo do 2° nome: ");
            SEXO2 = Console.ReadLine();

            Console.WriteLine();
            if (SEXO1 == "m" ^ SEXO2 == "m")
                Console.WriteLine(NOME1 + " dança com " + NOME2);
            else
                Console.WriteLine(NOME1 + " não dança com " + NOME2);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
