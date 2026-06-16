
using UniversitySystem.Enums;

namespace UniversitySystem.Models
{
    public class Users
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public UserRole Role{ get; set; }
        public string Password { get; set; }
    }
}
