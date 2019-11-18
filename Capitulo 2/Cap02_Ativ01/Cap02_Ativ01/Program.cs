using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ativ01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, soma, multiplicacao;

            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto número: ");
            n4 = int.Parse(Console.ReadLine());

            soma = ((n1 + n2) + (n1 + n3) + (n1 + n4)) + ((n2 + n3) + (n2 + n4)) + (n3 + n4);
            multiplicacao = ((n1 * n2) * (n1 * n3) * (n1 * n4)) * ((n2 * n3) * (n2 * n4)) * (n3 * n4);

            Console.WriteLine();
            Console.WriteLine("A soma dos valores na utilização da propriedade distributiva é: ");
            Console.WriteLine(soma);
            Console.WriteLine();
            Console.WriteLine("A multiplicação dos valores na utilização da propriedade distributiva é: ");
            Console.WriteLine(multiplicacao);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar");
            Console.ReadLine();
        }
    }
}
