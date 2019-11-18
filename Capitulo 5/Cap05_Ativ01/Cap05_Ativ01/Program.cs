using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ativ01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Entre com um valor: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Resultado(n);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }

        public static void Resultado(int x)
        {
            int SOMA = 0;
            for (int i = 0; i <= x; i++)
                SOMA += i;
            Console.WriteLine("A soma dos {0} primeiros números é: {1}", x, SOMA);

        }
    }
}
