using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    internal class ICMS : Imposto
    {
        public double calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
