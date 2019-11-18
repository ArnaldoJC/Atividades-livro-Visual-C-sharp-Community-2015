using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Ativ04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[8];
            int[] B = new int[8];
            int[] C = new int[16];

            int I, J;

            for (I = 0; I < 8; I++)
            {
                Console.Write("Entre com valor A[{0}]: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (J = 0; J < 8; J++)
            {
                Console.Write("Entre com valor B[{0}]: ", J + 1);
                B[J] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (I = 0; I < 8; I++)
            {
                C[I] = A[I];
                Console.Write("{0}, ", C[I]);
            }

            for (J = 0; J < 8; J++)
            {
                C[J] = B[J];
                Console.Write("{0}, ", C[J]);
            }


            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
