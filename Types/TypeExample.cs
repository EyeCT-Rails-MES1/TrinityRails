using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Types
{
    public class User
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public User(int ID, string username, string password)
        {
            this.ID = ID;
            this.username = username;
            this.password = password;
        }

        public void changePassword(string password)
        {
            this.password = password;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
