//using SpravaUzivatelu.Model;
//using SpravaUzivatelu;
//using System.Data;
//using System;

//public class ActionManager
//{
//    private User currentUser= null;

//    // AKCE PRO VŠECHNY UŽIVATELE
//    // Změna vlastního hesla

//    public (bool success, string message) ChangeMyPassword(string oldPassword, string newPassword)
//    {
//        if (currentUser == null)
//            return (false, "Nejste přihlášen");

//        return UserManager.ChangePassword(currentUser.Username, oldPassword, newPassword);
//    }

//    // Zobrazení vlastního profilu

//    public User ViewMyProfile()
//    {
//        if (currentUser == null)
//            return null;

//        DatabaseManager.LogEvent(currentUser.Username, "ZOBRAZENÍ_PROFILU", "Uživatel zobrazil svůj profil");
//        return currentUser;
//    }

//    // AKCE POUZE PRO ADMINA

//    // Zobrazení všech uživatelů

//    public DataTable ViewAllUsers()
//    {
//        if (currentUser?.Role != "Admin")
//        {
//            DatabaseManager.LogEvent(currentUser?.Username ?? "Unknown",
//                "NEPOVOLENÝ_PŘÍSTUP", "Pokus o zobrazení všech uživatelů");
//            return null;
//        }

//        DatabaseManager.LogEvent(currentUser.Username, "ZOBRAZENÍ_UŽIVATELŮ",
//            "Admin zobrazil seznam všech uživatelů");

//        try
//        {
//            return UserManager.GetAllUsersForAdmin();
//        }
//        catch (Exception)
//        {
//            return null;
//        }
//    }

//    // Smazání uživatele

//    public (bool success, string message) DeleteUser(string username)
//    {
//        if (currentUser?.Role != "Admin")
//        {
//            DatabaseManager.LogEvent(currentUser?.Username ?? "Unknown",
//                "NEPOVOLENÝ_PŘÍSTUP", $"Pokus o smazání uživatele {username}");
//            return (false, "Nemáte oprávnění k této akci");
//        }

//        return UserManager.DeleteUser(username);
//    }

//    // Zobrazení logů
//    public DataTable ViewLogs()
//    {
//        if (currentUser?.Role != "Admin")
//        {
//            DatabaseManager.LogEvent(currentUser?.Username ?? "Unknown",
//                "NEPOVOLENÝ_PŘÍSTUP", "Pokus o zobrazení logů");
//            return null;
//        }

//        DatabaseManager.LogEvent(currentUser.Username, "ZOBRAZENÍ_LOGŮ",
//            "Admin zobrazil logy");

//        try
//        {
//            return DatabaseManager.GetLogsAsDataTable();
//        }
//        catch (Exception)
//        {
//            return null;
//        }
//    }


//    // Vytvoření nového admina (ručně)
//    public (bool success, string message) CreateNewAdmin(string username, string password)
//    {
//        if (currentUser?.Role != "Admin")
//        {
//            DatabaseManager.LogEvent(currentUser?.Username ?? "Unknown",
//                "NEPOVOLENÝ_PŘÍSTUP", "Pokus o vytvoření admina");
//            return (false, "Nemáte oprávnění k této akci");
//        }

//        var result = UserManager.CreateAdmin(username, password);

//        if (result)
//        {
//            DatabaseManager.LogEvent(currentUser.Username, "VYTVOŘENÍ_ADMINA",
//                $"Vytvořen nový admin: {username}");
//            return (true, $"Administrátor {username} byl vytvořen");
//        }

//        return (false, "Nepodařilo se vytvořit administrátora");
//    }
//}