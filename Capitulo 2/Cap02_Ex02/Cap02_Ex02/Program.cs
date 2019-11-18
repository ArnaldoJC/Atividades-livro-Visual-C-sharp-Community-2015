using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;
            Console.Write("Entre o 1° valor: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Entre o 2° valor: ");
            B = int.Parse(Console.ReadLine());

            R = A + B;

            Console.WriteLine();
            Console.WriteLine("Resultado = " + R);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
