using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Empresa
{
    class Gerente : Funcionário
    {
        public string Setor { get; set; }
        public double Bonus { get; set; }

            public Gerente(int reg, string setor) : base(reg)
            {
                this.Setor = setor;
            }
    }
}
