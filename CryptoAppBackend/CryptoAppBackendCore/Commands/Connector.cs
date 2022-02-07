using CryptoAppBackend.Core.Interfaces.Connection;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace CryptoAppBackend.Core.Commands
{
    public class Connector : IConnectionDb
    {

        public bool IsDatabaseExist()
        {
            string query = "SELECT* FROM sys.databases WHERE name = 'mydb'";

            bool result;

            using (var connection = new SqlConnection(""))
            {
                connection.Open();

                result = connection.Query(query).Any();
            }

            return result;
        }
    }
}
