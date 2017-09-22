using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Empresa
{
    class Gerente 
    {
        public string Setor { get; set; }
        public double Bonus { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }

            public Gerente(int reg, string setor int Registro, string Nome, double Salario, int CPF, string Email) 
                {
                    this.Setor = setor;
                }
    }
}
