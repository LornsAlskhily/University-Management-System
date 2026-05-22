using System;
using UniversitySystem.Interfaces;
using UniversitySystem.Models;

namespace UniversitySystem.Services
{
    public class UserServices : IUserServices
    {

        IUserRepository _UserRepo;
        public UserServices(IUserRepository userRepository) { 
            _UserRepo = userRepository;
        }
        public Users Signin(string id, string password)
        {
            if (id == null || password == null) return null;
            Users user = _UserRepo.CheckPassword(id, password);
            return user;
        }
    }
}
