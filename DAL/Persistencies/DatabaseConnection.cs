using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RepositoryPattern.Persistencies
{
    public class DatabaseConnection
    {
        public string connectionString = @"Server = DESKTOP-NNKUBRF; Database = Tronics; User ID = sa; Password = 1234;";

        public void executeCommand(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    command.ExecuteReader();
                    Console.WriteLine("Execute reader executed");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
        }
    }
}
