using Coordenadas.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas.Model
{
    public class Vetor
    {
        public enumTipoDirecao Direcao { get; set; }

        public int Intensidade { get; set; }

        public Vetor(enumTipoDirecao direcao, int intensidade)
        {
            Direcao = direcao;
            Intensidade = intensidade;
        }
    }
}
