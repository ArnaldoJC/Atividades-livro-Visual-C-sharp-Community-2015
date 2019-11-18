using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// exemplo polimorfismo ad hoc de sobrecarga...

namespace Cap07_Ex05
{
    public class CalcArea
    {
        public /* static */ long Area(int x) // para casos em que os métodos serão sobrepostos via (polimorfismo ad hoc de sobrecarga) os métodos não podem ser estáticos.
        {
            long AREA = x * x;
            return AREA;
        }

        public /* static */ double Area(float R, float H) // para casos em que os métodos serão sobrepostos via (polimorfismo ad hoc de sobrecarga) os métodos não podem ser estáticos.
        {
            double AREA = R * R * 3.14159 * H;
            return AREA;
        }

        public /* static */ int Area(int X, int Y, int Z) // para casos em que os métodos serão sobrepostos via (polimorfismo ad hoc de sobrecarga) os métodos não podem ser estáticos.
        {
            int AREA = X * Y * Z;
            return AREA;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalcArea A = new CalcArea();

            Console.WriteLine();
            Console.WriteLine("Calculo de Areas");
            Console.WriteLine();
            Console.WriteLine("Quadrado..: " + A.Area(5)); // no momento da chamada do método a decisão depende do número de parâmetros em uso.
            Console.WriteLine("Cubo......: " + A.Area(5, 6, 7));
            Console.WriteLine("Cilindro..: " + A.Area(7, 3));
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
