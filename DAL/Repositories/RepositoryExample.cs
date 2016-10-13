using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Interfaces;
using RepositoryPattern.Types;

namespace RepositoryPattern.Repositories
{
    public class UserRepository
    {
        IUser context;
        List<User> userList = new List<User>();

        public UserRepository(IUser context)
        {
            this.context = context;
        }

        public void add(int ID, string username, string password)
        {
            User user = new User(ID, username, password);
            userList.Add(user);
            context.create(user);
        }

        public void changePassword(User user, string password)
        {
            user.changePassword(password);
            context.update(user);
        }

        public void delete(User user)
        {
            userList.Remove(user);
            context.delete(user);
        }

        public List<User> getUsers()
        {
            return userList;
        }
    }
}
