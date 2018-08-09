using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas.Model
{
    public class Ponto
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Ponto(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
