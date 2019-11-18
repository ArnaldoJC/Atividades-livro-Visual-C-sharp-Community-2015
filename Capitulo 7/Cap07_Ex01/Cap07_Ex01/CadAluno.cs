using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap07_Ex01
{  
    class SalaAula // classe-pai. 
    {
        public string SALA, TURMA; // propriedade SALA.
    }

    class CadAluno : SalaAula // classe (CadAluno) conjunto de propriedades e também de métodos a serem definidos (instanciados) a um objeto.
                              // para especificar a herança usa-se o simbolo (:). 
                              // (CadAluno) passa a ser a classe-filha que herdara todas as propriedades e métodos da classe pai como se a propriedade (SALA) fosse da,
                              // própria classe (CadAluno).
    {
        public string NOME;
        public float[] NOTA = new float[4];

        public float CalcMedia() // função que é um método da classe CadAluno que retorna o valor media das notas. 
        {
            byte I;
            float SOMA, MEDIA;
            SOMA = 0;

            for (I = 0; I <= 3; I++)
                SOMA = SOMA + NOTA[I];
            MEDIA = SOMA / 4;
            return MEDIA;
        }
    }
}
