using DesigPatterns2.Cap3;
using DesigPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigPatterns2.Cap9
{
    class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClieneDAO().BuscaPorCpf(cfp);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }

        public Cobranca GeraCobranca(TipoContrato tipo, Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(tipo, fatura);
            cobranca.Emite();
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }

    }
}
