﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Empresa
{
    class Tercerizado : Funcionário
    {
         public string EmpresaMatriz { get; set; }

            public Tercerizado(int reg, string data, string empresa) 
            {
                this.EmpresaMatriz = empresa;
            }
    }
}