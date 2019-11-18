using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            float ht, vh, pd, sb, td, sl;

            Console.Write("Horas trabalhadas: ");
            ht = float.Parse(Console.ReadLine());
            Console.Write("Valor da hora: ");
            vh = float.Parse(Console.ReadLine());
            Console.Write("Valor do percentual de desconto: ");
            pd = float.Parse(Console.ReadLine());

            sb = ht * vh;
            td = (pd / 100) * sb;
            sl = sb - td;

            Console.WriteLine();
            Console.Write("Salario liquido: ");
            Console.WriteLine(sl.ToString("##,##0,00"));

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar");
            Console.ReadLine();
        }
    }
}
