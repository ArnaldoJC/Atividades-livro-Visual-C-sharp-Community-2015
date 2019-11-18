using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x;
            long r;

            Console.Title = "Programa Fatorial";
            Console.Write("Entre um valor númerico: ");
            x = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            r = Fatorial(x); //valor da variavel FAT retorna diretamente no método Fatorial(x) e é atribuido ao conteúdo da variavel r.

            Console.WriteLine("Fatorial de {0} = {1}", x, r);
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
        public static long Fatorial(byte n)
        {
            long FAT = 1;
            if (n == 0)
                FAT = 0;
            else
                for (int i = 1; i <= n; i++)
                    FAT += i;
            return FAT; //retorna ao metodo Main() o valor existente na variavel fat.
        }
    }
}
