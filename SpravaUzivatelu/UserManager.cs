using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpravaUzivatelu.Model;

namespace SpravaUzivatelu
{
    internal static class UserManager
    {
        // Settings
        private static int MIN_PASSWORD_LENGTH = 8;
        // Variables
        public static User LoggedUser { get; private set; } = null;
        public static string ErrorMessage { get; private set; } = string.Empty;
        // Registrace
        public static bool RegisterUser(string username, string password, string confirmPassword)
        {
            // Ověření zadaných údajů
            if (password != confirmPassword)
            {
                ErrorMessage = "Passwords do not match.";
                return false;
            }

            if (ValidateUsername(username))
            {
                ErrorMessage = "Username is allready used.";
                return false;
            }
            
            if (ValidatePassword(password))
            {
                return false;
            }

            // Vytvoření nového uživatele
            string hashedPassword = PasswordHasher.HashPassword(password);
            User newUser = new User(username, hashedPassword, "User", DateTime.Now);

            //TODO: Uložení uživatele do databáze

            return true;
        }
        // Přihlášení
        public static bool LoginUser(string username, string password)
        {
            //TODO: Získat uživatele z databáze
            List<User> usersFromDatabase = new List<User>();
            if (!usersFromDatabase.Any(u => u.Username == username && PasswordHasher.VerifyPassword(password, u.Password)))
            {
                ErrorMessage = "Invalid username or password.";
                return false;
            }

            LoggedUser = usersFromDatabase.First(u => u.Username == username);
            return true;
        }
        // Odhlášení
        public static bool LogoutUser()
        {
            if (LoggedUser != null)
            {
                LoggedUser = null;
                return true;
            }
            else
            {
                ErrorMessage = "No user is currently logged in.";
                return false;
            }
        }
        // Validace uživatelského jména
        private static bool ValidateUsername(string username)
        {
            //TODO: Získat uživatele z databáze
            List<User> users = new List<User>();
            if (users.Any(u => u.Username == username))
            {
                return false;
            }

            return true;
        }
        // Validace hesla
        private static bool ValidatePassword(string password)
        {
            if (password.Length < MIN_PASSWORD_LENGTH)
            {
                ErrorMessage = $"Password must be at least {MIN_PASSWORD_LENGTH} characters long.";
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                ErrorMessage = "Password must contain at least one uppercase letter.";
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                ErrorMessage = "Password must contain at least one lowercase letter.";
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                ErrorMessage = "Password must contain at least one digit.";
                return false;
            }

            return true;
        }
    }
}