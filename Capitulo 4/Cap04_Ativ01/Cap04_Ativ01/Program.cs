using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ativ01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont;
            n = 0;
            for(cont = 1; cont <= 20; cont++)
                if (cont % 2 == 1)
                {
                    n = n + cont;
                }
            Console.WriteLine("A soma dos números impares é {0}", n);

            Console.WriteLine();
            Console.Write("Tecle alguma tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
