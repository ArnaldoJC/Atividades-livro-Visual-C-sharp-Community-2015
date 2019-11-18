using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            int DIVIDENDO, DIVISOR, QUOCIENTE;

            Console.WriteLine("Entre o valor do dividendo...: ");
            DIVIDENDO = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do divisor.: ");
            DIVISOR = int.Parse(Console.ReadLine());

            try
            {
                QUOCIENTE = DIVIDENDO / DIVISOR;

                Console.WriteLine();
                Console.WriteLine("Resultado = {0}", QUOCIENTE);
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine();
                Console.WriteLine(dbze.Message);
            }
            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
