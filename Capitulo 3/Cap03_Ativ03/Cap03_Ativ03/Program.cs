using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ativ03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de 4 notas e a média.........");
            double n1, n2, n3, n4, md;

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a quarta nota: ");
            n4 = double.Parse(Console.ReadLine());

            md = (n1 + n2 + n3 + n4) / 4;
            
            if (md >= 5)
                Console.WriteLine("Aluno aprovado média é: {0}", md);
            else
                Console.WriteLine("Aluno reprovado média é: {0}", md);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");
            Console.ReadKey();
        }
    }
}
