using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Empresa
{
    class Funcionário
    {
         public int Registro { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }

        public Funcionário(int reg)
        {
            Registro = reg; 
        }
    }
}
