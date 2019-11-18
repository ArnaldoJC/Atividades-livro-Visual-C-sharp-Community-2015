using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ativ04
{
    class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit, celsius;

            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            fahrenheit = float.Parse(Console.ReadLine());

            celsius = ((fahrenheit - 32) * 5) / 9;

            Console.WriteLine();
            Console.WriteLine("A temperatura em graus Celsius é: " + celsius);
            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar");
            Console.ReadLine();
        }
    }
}
