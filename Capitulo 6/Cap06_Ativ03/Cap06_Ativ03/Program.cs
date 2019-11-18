using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Ativ03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[9];
            int[] B = new int[9];
            int[] C = new int[9];

            int I;

            for (I = 0; I < 9; I++)
            {
                Console.Write("Entre com valor A[{0}]: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (I = 0; I < 9; I++)
            {
                Console.Write("Entre com valor B[{0}]: ", I + 1);
                B[I] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (I = 0; I < 9; I++)
            {
                C[I] = A[I] - B[I];
                Console.WriteLine("Resultado de A[{0}] - B[{1}] = {2}. ", A[I], B[I], C[I]);
            }

            Console.WriteLine();
            Console.WriteLine("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
