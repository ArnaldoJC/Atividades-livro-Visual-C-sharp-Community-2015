using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ativ02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Entre com um número: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("A série de Fibonacci dos {0} primeiros números é: 1", n);
            Fibonacci(n);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");
            Console.ReadKey();
        }

        public static void Fibonacci(int x)
        {
            int t1 = 0, t2 = 1, aux;
            for (int cont = 0; cont < x; cont++)
            {
                aux = t1;
                t1 = t2;
                t2 = t1 + aux;
                Console.Write(", {0}", t2);
            }
        }
    }
}
