using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ativ05
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.Write("Digite o tamanho do raio do recipiente em metros: ");
            raio = float.Parse(Console.ReadLine());
            Console.Write("Digite a altura do recipiente em metros: ");
            altura = float.Parse(Console.ReadLine());

            volume = 3.14159 * Math.Pow (raio, 2) * altura;

            Console.WriteLine();
            Console.WriteLine("O valor do volume do recipiente é: " + volume + " metros cubicos");
            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar");
            Console.ReadLine();
        }
    }
}
