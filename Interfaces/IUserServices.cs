using System;
using UniversitySystem.Models;

namespace UniversitySystem.Interfaces
{
    public interface IUserServices
    {
        Users Signin(string id, string password);
    }
}
