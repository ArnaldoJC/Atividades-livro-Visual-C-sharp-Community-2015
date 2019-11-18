using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ativ04
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0, cont = 2;
            
            while(cont <= 5)
            {
                n = n + Math.Pow(cont, 2);
                cont++;
            }
            Console.WriteLine("A soma dos quadrados dos números de 2 até 5 é {0}", n);

            Console.WriteLine();
            Console.Write("Tecle alguma tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
