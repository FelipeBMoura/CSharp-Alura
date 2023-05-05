using DesigPatterns2;
using DesigPatterns2.Cap1;
using DesigPatterns2.Cap2;
using DesigPatterns2.Cap3;
using DesigPatterns2.Cap4;
using DesigPatterns2.Cap5;
using DesigPatterns2.Cap6;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemAdministrativa("victor");
            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();
        }
    }
}
