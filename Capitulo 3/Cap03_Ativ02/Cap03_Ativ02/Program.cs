using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ativ02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equação de 2° grau");
            double a, b, c, delta, x1, x2;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            if (a != 0 && b != 0 && c != 0)
            {
                delta = ((Math.Pow(b, 2) - (4 * a * c)));
                Console.WriteLine("O valor de DELTA É: {0}", delta);

                if (delta == 0 )
                {
                    x1 = ((-b + Math.Pow(delta, (1.0/2.0)))/ (2 * a));
                    Console.WriteLine("O valor de x1 é: {0}", x1);
                }
                else if (delta < 0)
                {
                    Console.WriteLine("Não há solução para a equação");
                }
                else
                {
                    x1 = ((-b + Math.Pow(delta, (1.0 / 2.0))) / (2 * a));
                    Console.WriteLine("O valor de x1 é: {0}", x1);

                    x2 = ((-b - Math.Pow(delta, (1.0 / 2.0))) / (2 * a));
                    Console.WriteLine("O valor de x2 é: {0}", x2);
                }
            }
            else
                Console.WriteLine("Os números devem ser diferentes de (0)");

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar");
            Console.ReadLine();
        }
    }
}
