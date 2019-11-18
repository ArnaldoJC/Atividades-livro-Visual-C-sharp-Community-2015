using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// exemplo polimorfismo universal paramétrico...

namespace Cap07_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> LISTA = new List<object>(); // a classe (List) usa a classe ((Object) classe genérica da linguagem C#) podendo operar com qualquer tipo de dado,
                                                     // desde que seja previamente avisado,
                                                     // para definir um objeto (LISTA) o qual é instanciado a partir da classe,(List<Object>) por meio da clausula (new). 
                                                     // O uso de parênteses após a classe (List<Object>) diz ao compilador, que é um arranjo do tipo dinâmico cujo número 
                                                     // de elementos a ser armazenado será controlado pelo programa.

            int T;
            string N;

            // Entrada dos nomes

            Console.WriteLine();
            Console.Write("Quantos nomes a entrar? ");
            T = int.Parse(Console.ReadLine());

            for (int I = 0; I < T; I++)
            {
                Console.Write("Entre com {0,3}º nome: ", I + 1);
                N = Console.ReadLine();
                LISTA.Add(N); // o método (Add) permite a entrada de dados na lista
            }

            // apresentação dos nomes

            Console.WriteLine();

            for (int I = 0; I < LISTA.Count; I++) // a propriedade Count captura o numero de elementos existentes na lista
            {
                N = LISTA[I].ToString();
                Console.WriteLine("{0,3}° nome = {1}", I + 1, N);
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
