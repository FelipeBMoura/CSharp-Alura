using DesigPatterns2;
using DesigPatterns2.Cap1;
using DesigPatterns2.Cap2;
using DesigPatterns2.Cap3;
using DesigPatterns2.Cap4;
using DesigPatterns2.Cap5;
using DesigPatterns2.Cap6;
using DesigPatterns2.Cap7;
using DesigPatterns2.Cap8;
using DesigPatterns2.Cap9;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            String cpf = "1234";

            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            facade.CriaFatura(cliente, 5000);
            facade.GeraCobranca(tipo.Boleto, fatura);
        }
    }
}
