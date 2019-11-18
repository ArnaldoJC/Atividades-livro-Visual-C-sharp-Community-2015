using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Ativ02
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] A = new long[10];
            long[] B = new long[10];

            long CONT, I;

            for (I = 0; I < 10; I++)
            {
                Console.WriteLine("Entre com {0}° valor", I + 1);
                A[I] = long.Parse(Console.ReadLine());
            }

            for (I = 0; I < 10; I++)
            {
                long FAT = 1;
                for (CONT = A[I]; CONT >= 1; CONT--)
                    FAT *= CONT;
                B[I] = FAT;
            }

            for (I = 0; I < 10; I++)
            {
                Console.WriteLine("Fatorial de {0} é = [{1}]", A[I], B[I]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
