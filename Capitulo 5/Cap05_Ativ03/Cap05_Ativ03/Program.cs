using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ativ03
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor, taxa, tempo, prest;

            Console.Write("Entre com valor da prestação: ");
            valor = float.Parse(Console.ReadLine());
            Console.Write("Entre com valor da taxa: ");
            taxa = float.Parse(Console.ReadLine());
            Console.Write("Entre com valor dos dias de atraso: ");
            tempo = float.Parse(Console.ReadLine());

            prest = valor + (valor * (taxa / 100) * tempo);

            Console.WriteLine("O valor da prestação em atraso é: {0}", prest);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");
            Console.ReadKey();
        }
    }
}
