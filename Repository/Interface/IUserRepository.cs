using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User FindUserById(Guid userId);
        void UpdateUser(User c);
    }
}
