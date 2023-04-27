using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigPatterns2.Cap1
{
    internal class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connexao = new SqlConnection();
            connexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=banco";
            connexao.Open();

            return connexao;
        }
    }
}
