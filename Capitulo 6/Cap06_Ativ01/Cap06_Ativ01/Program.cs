using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Ativ01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[8];
            int[] B = new int[8];
            int I;

            for (I = 0; I < 8; I++)
            {
                Console.WriteLine("Entre com {0}° valor", I + 1);
                A[I]= int.Parse(Console.ReadLine());
            }

            for (I = 0; I < 8; I++)
            {
                B[I] = A[I] * 3;
                Console.WriteLine("o valor do número [{0}] * 3 = [{1}]", A[I], B[I]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
