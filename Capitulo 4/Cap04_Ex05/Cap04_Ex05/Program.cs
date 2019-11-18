using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programa exemplo para calculo de tabuada
 * de um valor numérico qualquer fornecido a 
 * partir do teclado para operação em modo console.
 */
 
/* Programa.............Tabuada
 * Autor(es)............Arnaldo Batista
 * Data.................11/04/2019
 * Versão...............2.0
 * Revisão..............Não.
 */

namespace Cap04_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, I, R;
            string RESP;

            RESP = "S";
            while (RESP.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA - TABUADA");
                Console.WriteLine();
                Console.Write("Informe um valor: ");
                N = int.Parse(Console.ReadLine());
                Console.ReadLine();

                for (I = 1; I <= 10; I++)
                {
                    //Calculo da tabuada propriamente dito
                    R = N * I;
                    //Apresentação da tabuada no formato: N X I = R
                    Console.WriteLine("{0,2} X {1,2} = {2,3}", N, I, R);
                }
                Console.WriteLine();
                Console.WriteLine("Deseja continuar?");
                Console.Write("[s] para sim ou [n] para não: ");
                RESP = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
