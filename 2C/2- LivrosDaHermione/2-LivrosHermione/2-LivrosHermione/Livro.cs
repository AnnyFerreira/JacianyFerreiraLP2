using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Livro
    {
        public string titulo;
        public double qtdpaginas,pph;
        public double DD; //dias até a devolução

        public double Tempo(double pph, double qtdpaginas)
        {
            double totalT = qtdpaginas / pph;
            return totalT;
        }
    }
}
