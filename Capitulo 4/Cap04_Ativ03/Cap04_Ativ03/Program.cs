using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ativ03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont;
            n = 0;
            for (cont = 1; cont < 200; cont++)
                if (cont % 4 == 0)
                {
                    n = n + cont;
                }
            Console.WriteLine("A soma dos números divisiveis por 4 até 199 é {0}", n);

            Console.WriteLine();
            Console.Write("Tecle alguma tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
