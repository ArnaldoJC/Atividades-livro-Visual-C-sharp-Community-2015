using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Acos(-1));
            Console.WriteLine(Math.Asin(-1));
            Console.WriteLine(Math.Atan(1));
            Console.WriteLine(Math.Sin(1));
            Console.WriteLine(Math.Tan(4));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9.0));
            Console.WriteLine(Math.Exp(1));
            Console.WriteLine(Math.Log(3));
            Console.WriteLine(Math.Abs(-9));
            Console.WriteLine(Math.Floor(2.03));
            Console.WriteLine(Math.Max(10, 3));
            Console.WriteLine(Math.Min(10, 3));
            Console.WriteLine(Math.Round(5.8));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
