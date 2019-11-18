using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Ativ07
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
                Console.Write("Entre com valor A[{0}]: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int J = 0;
            for (I = 7; I >= 0; I--)
            {
                B[J] = A[I];
                J++;
                Console.WriteLine("Numeros invertidos [{0}], [{1}]", A[I], B[I]);
                
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
