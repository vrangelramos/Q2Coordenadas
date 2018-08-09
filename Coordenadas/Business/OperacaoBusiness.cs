using Coordenadas.Model;
using System.Collections.Generic;

namespace Coordenadas.Business
{
    internal class OperacaoBusiness
    {
        internal Ponto AplicaVetor(Ponto p, Vetor v)
        {
            switch (v.Direcao)
            {
                case Model.Domain.enumTipoDirecao.N:
                    p.Y += v.Intensidade;
                    break;
                case Model.Domain.enumTipoDirecao.S:
                    p.Y -= v.Intensidade;
                    break;
                case Model.Domain.enumTipoDirecao.L:
                    p.X += v.Intensidade;
                    break;
                case Model.Domain.enumTipoDirecao.O:
                    p.X -= v.Intensidade;
                    break;
                default:
                    break;
            }

            return p;
        }

        internal Ponto AplicaVetores(Ponto p, List<Vetor> vetores)
        {
            foreach(var v in vetores)
            {
                p = AplicaVetor(p, v);
            }

            return p;
        }
    }
}
