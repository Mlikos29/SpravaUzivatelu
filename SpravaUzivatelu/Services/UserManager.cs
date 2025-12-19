using SpravaUzivatelu.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SpravaUzivatelu.DbContext;
using System.Threading;

namespace SpravaUzivatelu
{
    public class UserManager
    {
        private DatabaseManager _databaseManager;
        public UserManager()
        {
            _databaseManager = new DatabaseManager();
        }
        // Settings
        private int MIN_PASSWORD_LENGTH = 8;
        // Variables
        public User LoggedUser { get; private set; } = null;
        // Registrace
        public (bool success, string message) RegisterUser(string username, string password, string confirmPassword, bool isAdmin = false)
        {
            // Ověření zadaných údajů
            if (password != confirmPassword)
            {
                return (false, "Passwords do not match.");
            }

            if (ValidateUsername(username))
            {
                return (false, "Username is already used.");
            }

            (bool isPassValid, string errorMessage) = ValidatePassword(password);
            if (!isPassValid)
            {
                return (false, errorMessage);
            }

            // Vytvoření nového uživatele
            string hashedPassword = PasswordHasher.HashPassword(password);
            User newUser = new User(username, hashedPassword, isAdmin ? "Admin" : "User", DateTime.Now);

            //Uložení uživatele do databáze
            _databaseManager.AddUser(newUser);

            return (true, "Uživatel byl zaregistrován");
        }
        // Přihlášení
        public (bool success, string message) LoginUser(string username, string password)
        {
            // Získání uživatele z databáze
            List<User> usersFromDatabase = _databaseManager.GetAllUsers();
            if (!usersFromDatabase.Any(u => u.Username == username && PasswordHasher.VerifyPassword(password, u.PasswordHash)))
            {
                return (false, "Invalid username or password");
            }

            LoggedUser = usersFromDatabase.First(u => u.Username == username);
            return (true, "Uživatel byl přihlášen");
        }
        // Odhlášení
        public (bool, string) LogoutUser()
        {
            if (LoggedUser != null)
            {
                LoggedUser = null;
                return (true, "User was logged out");
            }
            else
            {
                return (false, "No user is currently logged in.");
            }
        }
        // Vracení uživatele
        private User GetUser()
        {
            return LoggedUser;
        }
        // Změna hesla uživatele
        public (bool success, string message) ChangePassword(string username, string oldPassword, string newPassword)
        {
            // Ověření nového hesla
            (bool isPassValid, string errorMessage) = ValidatePassword(newPassword);
            if (!isPassValid)
            {
                return (false, errorMessage);
            }
            string newPasswordHash = PasswordHasher.HashPassword(newPassword);
            // Změna hesla v databázy
            bool success = _databaseManager.UpdateUserPassword(username, newPasswordHash);
            if (!success)
            {
                return (false, "Password failed to update");
            }
            return (true, "Password was successfully updated");
        }
        // Vrácení všech uživatelů jako DataTable
        public DataTable GetAllUsersForAdmin()
        {
            return _databaseManager.GetAllUsersAsDataTable();
        }
        // Vytvoření nového admina
        public (bool success, string message) CreateNewAdmin(string username, string password)
        {
            (bool success, string errorMessage) = RegisterUser(username, password, password, true);
            if (!success)
            {
                return (false, errorMessage);
            }
            return (true, "Admin was successfully added");
        }
        // Smazání uživatele
        public (bool success, string message) DeleteUser(string username)
        {
            bool success = _databaseManager.DeleteUser(username);
            if (!success)
            {
                return (false, "Failed to delete user");
            }
            return (true, "User was successfully deleted");
        }
        // Validace uživatelského jména
        private bool ValidateUsername(string username)
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
        private (bool, string) ValidatePassword(string password)
        {
            if (password.Length < MIN_PASSWORD_LENGTH)
            {
                return (false, $"Password must be at least {MIN_PASSWORD_LENGTH} characters long.");
            }

            if (!password.Any(char.IsUpper))
            {
                return (false, "Password must contain at least one uppercase letter.");
            }

            if (!password.Any(char.IsLower))
            {
                return (false, "Password must contain at least one lowercase letter.");
            }

            if (!password.Any(char.IsDigit))
            {
                return (false, "Password must contain at least one digit.");
            }

            return (true, "Password is valid");
        }

        public (object, bool, string) GetLogs(bool asDataTable)
        {
            if (asDataTable)
            {
                var dt = _databaseManager.GetAllUsersAsDataTable();
                return (dt, true, "Logs was successfully read");
            }
            else
            {
                var list = _databaseManager.GetLogs();
                return (list, true, "Logs was successfully read");
            }
        }
    }
}