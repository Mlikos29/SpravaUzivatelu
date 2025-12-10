using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaUzivatelu.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } // bych to prejmenoval na PasswordHash
        public string Role { get; set; }
        public DateTime RegistrationDate { get; set; }
        public User(string username, string passwordHash, string role, DateTime registrationDate)
        {
            Username = username;
            PasswordHash = passwordHash;
            Role = role;
            RegistrationDate = registrationDate;
        }
    }
}
