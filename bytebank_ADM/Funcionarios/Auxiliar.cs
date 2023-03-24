﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000) // base permite acessar parâmetros da superclasse
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }        

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
