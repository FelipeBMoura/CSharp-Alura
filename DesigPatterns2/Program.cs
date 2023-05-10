using DesigPatterns2;
using DesigPatterns2.Cap1;
using DesigPatterns2.Cap2;
using DesigPatterns2.Cap3;
using DesigPatterns2.Cap4;
using DesigPatterns2.Cap5;
using DesigPatterns2.Cap6;
using DesigPatterns2.Cap7;
using DesigPatterns2.Cap8;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.nome = "victor";
            cliente.Endereco = "Rua vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            XmlSerializer xmlSerializer = new XmlSerializer(cliente.GetType());
            StringWriter writer = new StringWriter();
            xmlSerializer.Serialize(writer, cliente);
            String xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);
        }
    }
}
