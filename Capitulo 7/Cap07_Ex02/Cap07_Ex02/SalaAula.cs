using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap07_Ex02
{
    class SalaAula
    {
        public string SALA;
    }

    class CadAluno : SalaAula
    {
        public string NOME; // qualificador (public) define acesso total a todos os recursos (atributos e metodos). 
        public float N1, N2;
        private float MEDIA; // atributo (MEDIA) somente pode ser usado dentro da classe (CadAluno) pois nao possui visibilidade porque esta,
                             // encapisulado pelo qualificador (private).

        public float CalcMedia(float NT1, float NT2)
        {
            MEDIA = (NT1 + NT2) / 2;
            return MEDIA;
        }

        public static bool CondAluno(float ALUMEDIA, double CORMEDIA)
        {
            bool CONDALUNO = true;

            if (ALUMEDIA < CORMEDIA)
                CONDALUNO = false;
            return CONDALUNO;
        }
    }
}
