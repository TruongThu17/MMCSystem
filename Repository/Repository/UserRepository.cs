using Data.Models;
using DataAccess;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        public User FindUserById(Guid userId)=> UserDAO.FindUserById(userId);

        public List<User> GetUsers() => UserDAO.GetUsers();

        public void UpdateUser(User c) => UserDAO.UpdateUser(c);
    }
}
