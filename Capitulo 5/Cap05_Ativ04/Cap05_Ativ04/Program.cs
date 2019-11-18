using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ativ04
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, exp;

            Console.WriteLine("Entre com valor da base: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com valor do expoente: ");
            exp = double.Parse(Console.ReadLine());

            Potencia(b, exp);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
        public static void Potencia(double a, double x)
        {
            double r = 1;
            for (int i = 0; i < x; i++) 
            {
                r *= a;
            }
            Console.WriteLine("O valor da potência é: {0}", r);
        }
    }
}
