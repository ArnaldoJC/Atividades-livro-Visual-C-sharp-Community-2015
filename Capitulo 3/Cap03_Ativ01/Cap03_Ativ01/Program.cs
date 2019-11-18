using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ativ01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Digite o primeiro número: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            c = double.Parse(Console.ReadLine());

            if (a < b && b < c && a < c)
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", a, b, c);
            else if (a < b && c < b && a < c)
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", a, c, b);
            else if (b < a && c < a && b < c)
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", b, c, a);
            else if (b < a && a < c && b < c)
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", b, a, c);
            else if (c < a && c < b && a < b)
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", c, a, b);
            else if (c < b && c < a && b < a)
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", c, b, a);
            else if (a == b && a < c)
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", a, b, c);
            else if (a == c && a < b)
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", a, c, b);
            else
                Console.WriteLine("Ordem crescente: {0}, {1}, {2}", c, b, a);


            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar");
            Console.ReadLine();
        }
    }
}
