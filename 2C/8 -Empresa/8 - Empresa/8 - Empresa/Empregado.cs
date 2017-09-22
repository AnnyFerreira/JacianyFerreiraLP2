using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Empresa
{
    class Empregado : Funcionário
    {
        public string Gerente { get; set; }
        public string Entrada { get; set; }
        public Gerente gente { get; set; }

            public Empregado(int reg, string data) : base(reg) // inicialização dos atributos da classe pai 
        {
                this.Entrada = data;
            }
    }
}
