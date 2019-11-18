using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ativ06
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.Write("Digite o primeiro valor: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = float.Parse(Console.ReadLine());

            c = b;
            b = a;
            a = c;

            Console.WriteLine();
            Console.WriteLine("O primeiro valor agora é: " + a);
            Console.WriteLine("O segundo valor agora é: " + b);
            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar");
            Console.ReadLine();
        }
    }
}
