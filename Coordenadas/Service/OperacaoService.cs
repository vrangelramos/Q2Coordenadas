using Coordenadas.Business;
using Coordenadas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas.Service
{
    public class OperacaoService
    {
        private static readonly OperacaoBusiness business = new OperacaoBusiness();

        public Ponto AplicarCoordenadas(Ponto p, List<Vetor> vetores)
        {
            return business.AplicaVetores(p, vetores);
        }
    }
}
