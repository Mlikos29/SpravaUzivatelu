using SpravaUzivatelu;
using SpravaUzivatelu.DbContext;
using SpravaUzivatelu.Model;
using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

public class ActionManager
{
    private static readonly Lazy<ActionManager> lazyInstance =
        new Lazy<ActionManager>(() => new ActionManager());
    public static ActionManager Instance => lazyInstance.Value;
    private readonly UserManager _userManager;
    private User currentUser;
    private ActionManager()
    {
        _userManager = UserManager.Instance;
        currentUser = null;
    }

    // Vlastnost pro získání aktuálního uživatele
    public User CurrentUser => currentUser;

    // AKCE PRO VŠECHNY UŽIVATELE
    // Změna vlastního hesla

    public (bool success, string message) ChangeMyPassword(string oldPassword, string newPassword)
    {
        if (currentUser == null)
            return (false, "Nejste přihlášen");

        return _userManager.ChangePassword(currentUser.Username, oldPassword, newPassword);
    }

    // Zobrazení vlastního profilu

    public User ViewMyProfile()
    {
        if (currentUser == null)
            return null;

        DatabaseManager.LogEvent(currentUser.Username, "ZOBRAZENÍ_PROFILU", "Uživatel zobrazil svůj profil");
        return currentUser;
    }

    // AKCE POUZE PRO ADMINA

    // Zobrazení všech uživatelů

    public DataTable ViewAllUsers()
    {
        if (currentUser?.Role != "Admin")
        {
            DatabaseManager.LogEvent(currentUser?.Username ?? "Unknown",
                "NEPOVOLENÝ_PŘÍSTUP", "Pokus o zobrazení všech uživatelů");
            return null;
        }

        DatabaseManager.LogEvent(currentUser.Username, "ZOBRAZENÍ_UŽIVATELŮ",
            "Admin zobrazil seznam všech uživatelů");

        try
        {
            return _userManager.GetAllUsersForAdmin();
        }
        catch (Exception)
        {
            return null;
        }
    }

    // Smazání uživatele

    public (bool success, string message) DeleteUser(string username)
    {
        if (currentUser?.Role != "Admin")
        {
            DatabaseManager.LogEvent(currentUser?.Username ?? "Unknown",
                "NEPOVOLENÝ_PŘÍSTUP", $"Pokus o smazání uživatele {username}");
            return (false, "Nemáte oprávnění k této akci");
        }

        return _userManager.DeleteUser(username);
    }

    // Zobrazení logů
    public (object, bool, string) ViewLogs(bool asDataTable)
    {
        if (currentUser?.Role != "Admin")
        {
            DatabaseManager.LogEvent(currentUser?.Username ?? "Unknown",
                "NEPOVOLENÝ_PŘÍSTUP", "Pokus o zobrazení logů");
            return (null, false, "Nepovolený přístup");
        }

        DatabaseManager.LogEvent(currentUser.Username, "ZOBRAZENÍ_LOGŮ",
            "Admin zobrazil logy");

        try
        {
            var dataobject = _userManager.GetLogs(asDataTable);
            return dataobject;
        }
        catch (Exception ex)
        {
            return (null, false, $"Chyba při načítání logů: {ex.Message}"); ;
        }
    }


    // Vytvoření nového admina (ručně)
    public (bool success, string message) CreateNewAdmin(string username, string password)
    {
        if (currentUser?.Role != "Admin")
        {
            DatabaseManager.LogEvent(currentUser?.Username ?? "Unknown",
                "NEPOVOLENÝ_PŘÍSTUP", "Pokus o vytvoření admina");
            return (false, "Nemáte oprávnění k této akci");
        }

        var (success, message) = _userManager.CreateNewAdmin(username, password);

        if (success)
        {
            DatabaseManager.LogEvent(currentUser.Username, "VYTVOŘENÍ_ADMINA",
                $"Vytvořen nový admin: {username}");
            return (true, $"Administrátor {username} byl vytvořen");
        }

        return (false, "Nepodařilo se vytvořit administrátora");
    }
    // Registrace nového uživatele
    public (bool success, string message) RegisterNewUser(string username, string password, string confirmPassword)
    {
        var (success, message) = _userManager.RegisterUser(username, password, confirmPassword);

        if (!success)
            return (false, message);

        DatabaseManager.LogEvent(
            "SYSTEM",
            "VYTVOŘENÍ_USERU",
            $"Vytvořen nový user: {username}"
        );

        return (true, $"Uživatel {username} byl vytvořen");
    }
    public (bool success, string message) LoginUser(string username, string password)
    {
        var (isOk, ErrorMessage) = _userManager.LoginUser(username, password);
        if (!isOk)
        {
            return (false, ErrorMessage);
        }
        currentUser = _userManager.GetLoggedUser();
        DatabaseManager.LogEvent(
            currentUser.Username,
            "PŘIHLÁŠENÍ",
            "Uživatel se úspěšně přihlásil"
        );
        return (true, "Uživatel byl přihlášen");
    }
}