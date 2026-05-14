using System.Collections.Generic;
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
