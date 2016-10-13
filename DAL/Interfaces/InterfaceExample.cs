using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Types;

namespace RepositoryPattern.Interfaces
{
    public interface IUser
    {
        void create(User user);
        void update(User user);
        void delete(User user);
    }
}
