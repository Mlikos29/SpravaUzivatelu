using System.Data.SQLite;
using System.Data;
using SpravaUzivatelu.Model;
using System.Collections.Generic;
using System;

public static class DatabaseManager
{
    private static readonly string ConnectionString = "Data Source=users.db;Version=3;";

    // Inicializuje databázi a vytvoří tabulky pokud neexistují

    public static void InitializeDatabase()
    {
        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Vytvoření tabulky Users
                string createUsersTable = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT UNIQUE NOT NULL,
                    PasswordHash TEXT NOT NULL,
                    Role TEXT NOT NULL CHECK(Role IN ('User', 'Admin')),
                    RegistrationDate TEXT NOT NULL
                )";

                // Vytvoření tabulky Logs (pro bonus)
                string createLogsTable = @"
                CREATE TABLE IF NOT EXISTS Logs (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Timestamp TEXT NOT NULL,
                    Username TEXT NOT NULL,
                    Action TEXT NOT NULL,
                    Details TEXT
                )";

                using (var command = new SQLiteCommand(createUsersTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createLogsTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Kontrola, zda existuje admin (může být vytvořen ručně)
                if (!UserExists("admin"))
                {
                    CreateDefaultAdmin();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Chyba při inicializaci databáze: {ex.Message}");
        }
    }

    // Vytvoří výchozího admina (pro testování)
    private static void CreateDefaultAdmin()
    {
        string adminHash = HashPassword("admin123");

        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();

            string sql = @"
            INSERT INTO Users (Username, PasswordHash, Role, RegistrationDate)
            VALUES ('admin', @passwordHash, 'Admin', @date)";

            using (var command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@passwordHash", adminHash);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                command.ExecuteNonQuery();
            }
        }
    }


    // Přidá nového uživatele do databáze

    public static bool AddUser(User user)
    {
        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"
                INSERT INTO Users (Username, PasswordHash, Role, RegistrationDate)
                VALUES (@username, @passwordHash, @role, @registrationDate)";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@passwordHash", user.PasswordHash);
                    command.Parameters.AddWithValue("@role", user.Role);
                    command.Parameters.AddWithValue("@registrationDate",
                        user.RegistrationDate.ToString("yyyy-MM-dd HH:mm:ss"));

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        catch (SQLiteException ex)
        {
            // Chyba UNIQUE constraint (username již existuje)
            if (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
                return false;

            throw new Exception($"Chyba při přidávání uživatele: {ex.Message}");
        }
    }


    // Najde uživatele podle uživatelského jména

    public static User GetUserByUsername(string username)
    {
        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"
                SELECT Id, Username, PasswordHash, Role, RegistrationDate
                FROM Users 
                WHERE Username = @username";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User(reader["Username"].ToString(),
                            reader["PasswordHash"].ToString(),
                            reader["Role"].ToString(),
                            DateTime.Parse(reader["RegistrationDate"].ToString()));
                            user.Id = Convert.ToInt32(reader["Id"]);
                            return user;
                           
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Chyba při hledání uživatele: {ex.Message}");
        }

        return null;
    }

    // Získá všechny uživatele z databáze
    public static DataTable GetAllUsersAsDataTable()
    {
        var dataTable = new DataTable();

        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT Id, Username, Role, RegistrationDate FROM Users ORDER BY Username";

                using (var adapter = new SQLiteDataAdapter(sql, connection))
                {
                    adapter.Fill(dataTable);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Chyba při načítání uživatelů: {ex.Message}");
        }

        return dataTable;
    }


    // Získá všechny uživatele jako seznam

    public static List<User> GetAllUsers()
    {
        var users = new List<User>();

        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT Id, Username, PasswordHash, Role, RegistrationDate FROM Users";

                using (var command = new SQLiteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User(reader["Username"].ToString(),
                         reader["PasswordHash"].ToString(),
                         reader["Role"].ToString(),
                         DateTime.Parse(reader["RegistrationDate"].ToString()));
                        user.Id = Convert.ToInt32(reader["Id"]);
                        users.Add(user);
                        
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Chyba při načítání uživatelů: {ex.Message}");
        }

        return users;
    }


   // Aktualizuje heslo uživatele

    public static bool UpdateUserPassword(string username, string newPasswordHash)
    {
        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"
                UPDATE Users 
                SET PasswordHash = @passwordHash
                WHERE Username = @username";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@passwordHash", newPasswordHash);
                    command.Parameters.AddWithValue("@username", username);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Chyba při aktualizaci hesla: {ex.Message}");
        }
    }

    //Smaže uživatele z databáze
    public static bool DeleteUser(string username)
    {
        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Users WHERE Username = @username";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Chyba při mazání uživatele: {ex.Message}");
        }
    }

    // Zkontroluje, zda uživatel s daným jménem existuje
    public static bool UserExists(string username)
    {
        return GetUserByUsername(username) != null;
    }

    // Zaloguje událost do databáze
    public static void LogEvent(string username, string action, string details = "")
    {
        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"
                INSERT INTO Logs (Timestamp, Username, Action, Details)
                VALUES (@timestamp, @username, @action, @details)";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@timestamp",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@action", action);
                    command.Parameters.AddWithValue("@details", details);

                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Chyba při logování: {ex.Message}");
        }
    }

    // Získá všechny logy z databáze jako DataTable (DataGridView)
    public static DataTable GetLogsAsDataTable()
    {
        var dataTable = new DataTable();

        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"
                SELECT Timestamp, Username, Action, Details
                FROM Logs 
                ORDER BY Timestamp DESC";

                using (var adapter = new SQLiteDataAdapter(sql, connection))
                {
                    adapter.Fill(dataTable);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Chyba při načítání logů: {ex.Message}");
        }

        return dataTable;
    }

    // Získá logy jako seznam
    public static List<LogEntry> GetLogs()
    {
        var logs = new List<LogEntry>();

        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"
                SELECT Id, Timestamp, Username, Action, Details
                FROM Logs 
                ORDER BY Timestamp DESC";

                using (var command = new SQLiteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        logs.Add(new LogEntry
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Timestamp = DateTime.Parse(reader["Timestamp"].ToString()),
                            Username = reader["Username"].ToString(),
                            Action = reader["Action"].ToString(),
                            Details = reader["Details"]?.ToString() ?? ""
                        });
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Chyba při načítání logů: {ex.Message}");
        }

        return logs;
    }

    // Hashování hesla pomocí SHA256 kdyby byla potřeba 
    private static string HashPassword(string password)
    {
        using (var sha256 = System.Security.Cryptography.SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}