using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ativ02
{
    class Program
    {
        static void Main(string[] args)
        {
            float tempo, velocidade, distancia, litros_usados;

            Console.Write("Digite o tempo gasto na viagem: ");
            tempo = float.Parse(Console.ReadLine());
            Console.Write("Digite a velocidade média: ");
            velocidade = float.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
            litros_usados = distancia / 12;

            Console.WriteLine();
            Console.WriteLine("A velocidade média é: " + velocidade);
            Console.WriteLine("O tempo gasto na viagem é: " + tempo);
            Console.WriteLine("A distância percorrida é: " + distancia); 
            Console.WriteLine("A quantidade de litros utilizado na viagem é: " + litros_usados);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar");
            Console.ReadLine();
        }
    }
}
