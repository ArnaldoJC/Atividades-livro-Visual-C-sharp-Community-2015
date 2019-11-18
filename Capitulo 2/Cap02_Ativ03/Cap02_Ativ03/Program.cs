using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ativ03
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius, fahrenheit;

            Console.Write("Digite a temperatura em graus Celsius: ");
            celsius = float.Parse(Console.ReadLine());

            fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine();
            Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit);
            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar");
            Console.ReadLine();
        }
    }
}
