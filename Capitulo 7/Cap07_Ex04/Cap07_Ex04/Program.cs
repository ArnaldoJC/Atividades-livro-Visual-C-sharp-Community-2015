using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// exemplo polimorfismo universal de inclusão...

namespace Cap07_Ex04
{
    class ClassePai
    {
        // as classes (ClassePai) e (ClasseFilho) possuem método com mesmo nome mas resultam em ações diferentes.

        public virtual void Executa() // para que uma (classe-pai) assuma os recursos da (classe-filho) é necessário que o recurso a ser sobreposto esteja como (virtual).
        {
            Console.WriteLine("Ação na classe-pai");
        }
    }

    class ClasseFilho : ClassePai
    {
        // as classes (ClassePai) e (ClasseFilho) possuem método com mesmo nome mas resultam em ações diferentes.

        public override void Executa() // o método (override) da (classe-filho) faz sobreposição a um recurso do método do mesmo nome (Executa),
                                       // indicado como (virtual) da (classe-pai).
        {
            Console.WriteLine("Ação da classe-filho");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassePai PAI = new ClassePai();
            ClasseFilho FILHO = new ClasseFilho();

            PAI.Executa();
            FILHO.Executa();

            PAI = FILHO;
            PAI.Executa(); // o método (Executa()) da classe da classe-filho torna-se sobreposto ao método (Executa()) da classe-pai sendo que perde seu próprio acesso,
                           // ao seu próprio método. (Este efeito parece herança mas ocorre em sentido contrário).

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
