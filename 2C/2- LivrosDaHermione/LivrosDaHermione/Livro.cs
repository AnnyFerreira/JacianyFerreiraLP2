using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosDaHermione
{
    class Livro
    {
        public string titulo;
        public int qtdpaginas;
        public int DD; //dias até devolução

        double Tempo(int pph, int qtdpaginas)
        {
            return qtdpaginas / pph;
        }
    }
}
