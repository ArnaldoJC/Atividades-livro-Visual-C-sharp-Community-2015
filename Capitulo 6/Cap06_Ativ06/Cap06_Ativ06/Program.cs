using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06_Ativ06
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[10];
            double[] B = new double[10];

            int I;

            for (I = 0; I < 10; I++)
            {
                Console.Write("Entre com valor A[{0}]: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (I = 0; I < 10; I++)
            {
                B[I] = Math.Pow(A[I], 2);
                Console.WriteLine("O quadrado de {0} = {1}", A[I], B[I]);
            }
            
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
