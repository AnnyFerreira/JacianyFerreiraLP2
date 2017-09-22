using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Empresa
{
    class Empregado 
    {
        public string Gerente { get; set; }
        public string Entrada { get; set; }
        public Gerente gerente { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }

            public Empregado(int reg, string data, int Registro, string Nome, double Salario, int CPF, string Email) 
                {
                    this.Entrada = data;
                }
    }
}
