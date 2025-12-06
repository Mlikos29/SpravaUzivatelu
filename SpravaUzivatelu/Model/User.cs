using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaUzivatelu.Model
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime RegistrationDate { get; set; }
        public User(string username, string password, string role, DateTime registrationDate)
        {
            Username = username;
            Password = password;
            Role = role;
            RegistrationDate = registrationDate;
        }
    }
}
