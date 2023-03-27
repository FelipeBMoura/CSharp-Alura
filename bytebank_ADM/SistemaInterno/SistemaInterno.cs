using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string Senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(Senha);
            if(usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
