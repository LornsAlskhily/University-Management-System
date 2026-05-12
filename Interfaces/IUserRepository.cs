using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Models;

namespace UniversitySystem.Interfaces
{
    public interface IUserRepository
    {
         bool AddUser(Users user);
        List<Users> GetAllUsers();
        Users GetUserById(string id);
        bool CheckPassword(string id, string password);
    }
}
