using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            string TEXTO = "Computador";

            Console.WriteLine(TEXTO.Length);
            Console.WriteLine(TEXTO.ToLower());
            Console.WriteLine(TEXTO.ToUpper());
            Console.WriteLine(TEXTO.Substring(0, 3));
            Console.WriteLine(TEXTO.Substring(3, 4));
            Console.WriteLine(TEXTO.Substring(7, 3));

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
