using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05_Ex02
{
    class Program
    {
        public static float r, a, b;
        public static string MSG = "Tecle algo para continuar... ";

        static void Main(string[] args)
        {
            string OPCAO;
            OPCAO = "0";

            while (OPCAO != "5")
            {
                Console.Title = "Calculadora";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("--------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Fim do programa");
                Console.WriteLine();
                Console.WriteLine("Escolha uma opção: ");
                OPCAO = Console.ReadLine();

                if (OPCAO != "5")
                    switch (OPCAO)
                    {
                        case "1": RotSoma();    break;
                        case "2": RotSubtracao();    break;
                        case "3": RotMultiplicacao();    break;
                        case "4": RotDivisao();    break;
                        default:
                            Console.WriteLine("Opção invalida");
                            Console.Write(MSG);
                            Console.ReadKey();
                            break;
                    }
            }
        }
        private static void RotDivisao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Rotina de Divisão");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Entrada();
            if (b == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Erro.");
                Console.WriteLine();
                Console.WriteLine(MSG);
                Console.ReadKey();
            }
            else
            {
                r = Calculo(a, b, "/");
                Saida();
            }
            
        }
        private static void RotMultiplicacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Rotina de Multiplicação");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Entrada();
            r = Calculo(a, b, "*");
            Saida();
        }
        private static void RotSubtracao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rotina de Subtração");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Entrada();
            r = Calculo(a, b, "-");
            Saida();
        }
        private static void RotSoma()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Rotina de Soma");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Entrada();
            r = Calculo(a, b, "+");
            Saida();
        }
        public static float Calculo(float x, float y, string OPERADOR)
        {
            float z = 0;
            switch (OPERADOR)
            {
                case "+": z = x + y; break;
                case "-": z = x - y; break;
                case "*": z = x * y; break;
                case "/": z = x / y; break;
            }
            return z;
        }
        private static void Entrada()
        {
            Console.Write("Entre um valor para A: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Entre um valor para B: ");
            b = float.Parse(Console.ReadLine());
        }
        private static void Saida()
        {
            Console.WriteLine();
            Console.Write("O resultado entre A e B = {0:0.00}", r);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(MSG);
            Console.ReadKey();
        }
    }
}
