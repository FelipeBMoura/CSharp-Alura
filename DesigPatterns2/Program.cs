using DesigPatterns2;
using DesigPatterns2.Cap1;
using DesigPatterns2.Cap2;
using DesigPatterns2.Cap3;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato c = new Contrato(DateTime.Now, "victor", TipoContrato.Novo);
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);
        }
    }
}
