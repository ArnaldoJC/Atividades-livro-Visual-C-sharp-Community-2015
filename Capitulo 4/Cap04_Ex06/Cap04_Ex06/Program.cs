using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            double V1 = 123.456;
            double V2 = 234.5;
            double V3 = 345.0;
            double V4 = 12345.67;
            double V5 = 1234.5;
            double V6 = 12345.6789;

            int V7 = 123;
            int V8 = 12;
            int V9 = 1;

            long X = 1234567890;
            long Y = 12345678901;

            //apresentação com duas casas decimais
            Console.WriteLine(string.Format("{0:0.00}", V1));
            Console.WriteLine(string.Format("{0:0.00}", V2));
            Console.WriteLine(string.Format("{0:0.00}", V3));

            //apresentação com separador de milhar
            Console.WriteLine(string.Format("{0:0,0.00}", V4));
            Console.WriteLine(string.Format("{0:0,0.00}", V5));
            Console.WriteLine(string.Format("{0:0,0.00}", V6));

            //apresentação com alinhamento a direita - valor real
            Console.WriteLine(string.Format("{0,15:0,0.00}", V4));
            Console.WriteLine(string.Format("{0,15:0,0.00}", V5));
            Console.WriteLine(string.Format("{0,15:0,0.00}", V2));

            //apresentação com zeros a direita
            Console.WriteLine(string.Format("{0:00000}", V7));
            Console.WriteLine(string.Format("{0:00000}", V8));
            Console.WriteLine(string.Format("{0:00000}", V9));

            //apresentação com alinhamento a direita - valor inteiro
            Console.WriteLine(string.Format("{0,5}", V7));
            Console.WriteLine(string.Format("{0,5}", V8));
            Console.WriteLine(string.Format("{0,5}", V9));

            //apresentação formatação customizada
            Console.WriteLine(string.Format("{0: (0xx##)####-####}", X));
            Console.WriteLine(string.Format(@"{0:###\.###\.###-##}", Y));

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
