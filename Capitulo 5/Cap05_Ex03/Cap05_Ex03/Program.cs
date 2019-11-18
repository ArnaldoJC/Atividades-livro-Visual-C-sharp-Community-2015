using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x;

            Console.Title = "Programa Fatorial";
            Console.Write("Entre um valor númerico: ");
            x = byte.Parse(Console.ReadLine());
            Console.WriteLine();

            Fatorial(x);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
        public static void Fatorial(byte n) //após a chamada de método Fatorial ele formaliza a recepção do valor da variavel x transferindo seu conteúdo para variavel n.
        {
            long FAT = 1;
            if (n == 0)
                FAT = 0;
            else
                for (int i = 1; i <= n; i++)
                    FAT += i;
            Console.WriteLine("Fatorial de {0} = {1}", n, FAT);
        }
    }
}
