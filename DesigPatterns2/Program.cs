using DesigPatterns2.Cap1;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();
            
            IDbCommand comando = connexao.CreateCommand();
            comando.CommandText = "select * from tabela";
        }
    }
}
