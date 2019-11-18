using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do programa principal - 1");
            SubRotina();
            Console.WriteLine("Execução do programa principal - 2");

            Console.WriteLine();
            Console.WriteLine("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
        public static void SubRotina()
        {
            Console.WriteLine("Execução da sub-rotina");
        }
    }
}
