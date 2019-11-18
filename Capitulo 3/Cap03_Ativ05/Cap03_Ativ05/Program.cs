using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ativ05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resultado da diferença do valor maior pelo menor.........");
            int n1, n2, d;

            Console.Write("Digite a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                d = n1 - n2;
                Console.Write("A diferença é: {0}", d);
            }
            else
            {
                d = n2 - n1;
                Console.Write("A diferença é: {0}", d);
            }

            Console.WriteLine();
            Console.Write("Tecle alguma tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
