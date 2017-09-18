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
        public double Preco { get; set; }

        public void Repor(int repor)
        {
            this.quatidade += repor;
        }

        public Produto(int id, string nome, int preco)
        {
            this.id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.quatidade = 0;
        }
    }


}
