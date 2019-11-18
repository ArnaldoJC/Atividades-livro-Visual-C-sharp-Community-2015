using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ativ05
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b = 0, c = 1, i;

            Console.WriteLine("Digite um número inteiro para obter a série de Fibonacci:");
            a = int.Parse(Console.ReadLine());

            Console.Write(" " + c);

            for (int cont = 0; cont < a; cont++)
            {
                i = b;
                b = c;
                c = b + i;
                Console.Write(", {0}", c);
            }
            Console.WriteLine();
            Console.Write("Tecle alguma tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
