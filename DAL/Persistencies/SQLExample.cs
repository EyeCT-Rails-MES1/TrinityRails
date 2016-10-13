using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RepositoryPattern.Interfaces;
using RepositoryPattern.Types;

namespace RepositoryPattern.Persistencies
{
    public class UserSQLQuery : IUser
    {
        private DatabaseConnection databaseConnection;

        public UserSQLQuery()
        {
            databaseConnection = new DatabaseConnection();
        }        

        public void create(User user)
        {
            string query = @"INSERT INTO [UserTable] (Username, Password) VALUES ('" + user.username + @"', '" + user.password + @"');";
            databaseConnection.executeCommand(query);
        }

        public void delete(User user)
        {
            string query = @"DELETE FROM [UserTable] WHERE [UserID] = '" + user.ID + @"';";
            databaseConnection.executeCommand(query);
        }

        public void update(User user)
        {
            string query = @"UPDATE [UserTable] SET [password] = '" + user.password + @"' WHERE [UserID] = '" + user.ID + @"';";
            databaseConnection.executeCommand(query);
        }
    }
}
