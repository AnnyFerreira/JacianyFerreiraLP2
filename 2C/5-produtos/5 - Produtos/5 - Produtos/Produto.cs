using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Produtos
{
    class Produto
    {
        private int id;
        public int Id {
                get { return id;}
        }

        public string nome {get;set;}
        public double preco {get;set;}

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
        }
    }
}
