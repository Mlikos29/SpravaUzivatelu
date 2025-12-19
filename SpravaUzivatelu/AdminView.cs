using SpravaUzivatelu.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace SpravaUzivatelu
{
    public partial class AdminView : Form
    {
        ActionManager actionManager = ActionManager.Instance;
        private enum DataViewType { None, Logs, Users }
        private DataViewType currentView = DataViewType.None;

        public AdminView()
        {
            InitializeComponent();

            // Datagrid na začátku skrytý
            dataGridView.Visible = false;

            dataGridView.AutoGenerateColumns = true;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Font = new System.Drawing.Font("Consolas", 8);

            // Na začátku potvrzení hesla viditelné jen pro usery
            Confirm_Password_Text.Visible = Create_User_Radio.Checked;
            label3.Visible = Create_User_Radio.Checked;
        }

        private void Show_Logs_Button_Click(object sender, EventArgs e)
        {
            if (currentView == DataViewType.Logs)
            {
                dataGridView.Visible = !dataGridView.Visible;
                if (!dataGridView.Visible) currentView = DataViewType.None;
                return;
            }

            var (dataObj, success, message) = actionManager.ViewLogs(true);

            if (!success || dataObj == null)
            {
                MessageBox.Show("Nepodařilo se načíst logy: " + message);
                return;
            }

            if (dataObj is DataTable dt)
            {
                dataGridView.DataSource = dt;
                SetLogColumnsHeaders();
                dataGridView.Visible = true;
                currentView = DataViewType.Logs;
            }
        }

        private void ButtonShowUsers_Click(object sender, EventArgs e)
        {
            if (currentView == DataViewType.Users)
            {
                dataGridView.Visible = !dataGridView.Visible;
                if (!dataGridView.Visible) currentView = DataViewType.None;
                return;
            }

            var dt = actionManager.ViewAllUsers();
            if (dt == null)
            {
                MessageBox.Show("Nepodařilo se načíst uživatele.");
                return;
            }

            dataGridView.DataSource = dt;
            SetUserColumnsHeaders();
            dataGridView.Visible = true;
            currentView = DataViewType.Users;
        }

        private void SetLogColumnsHeaders()
        {
            if (dataGridView.Columns.Contains("Id"))
                dataGridView.Columns["Id"].HeaderText = "Id";
            if (dataGridView.Columns.Contains("Timestamp"))
                dataGridView.Columns["Timestamp"].HeaderText = "Čas";
            if (dataGridView.Columns.Contains("Username"))
                dataGridView.Columns["Username"].HeaderText = "Uživatel";
            if (dataGridView.Columns.Contains("Action"))
                dataGridView.Columns["Action"].HeaderText = "Akce";
            if (dataGridView.Columns.Contains("Details"))
                dataGridView.Columns["Details"].HeaderText = "Detaily";
        }

        private void SetUserColumnsHeaders()
        {
            if (dataGridView.Columns.Contains("Username"))
                dataGridView.Columns["Username"].HeaderText = "Uživatel";
            if (dataGridView.Columns.Contains("Role"))
                dataGridView.Columns["Role"].HeaderText = "Role";
            if (dataGridView.Columns.Contains("CreatedAt"))
                dataGridView.Columns["CreatedAt"].HeaderText = "Vytvořen";
        }

        private void User_View_Button_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new UserView());
        }

        // --- Zobrazení / schování Confirm Password podle typu ---
        private void Create_User_Radio_CheckedChanged(object sender, EventArgs e)
        {
            Confirm_Password_Text.Visible = Create_User_Radio.Checked;
            label3.Visible = Create_User_Radio.Checked;
        }

        private void Create_Admin_Radio_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            Confirm_Password_Text.Visible = false;
        }

        // --- Vytvoření User / Admin ---
        private void Create_Button_Click(object sender, EventArgs e)
        {
            string username = Username_Text.Text.Trim();
            string password = Password_Text.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Zadejte uživatelské jméno a heslo.");
                return;
            }

            if (Create_Admin_Radio.Checked)
            {
                var (success, message) = actionManager.CreateNewAdmin(username, password);
                MessageBox.Show(message);
            }
            else if (Create_User_Radio.Checked)
            {
                string confirm = Confirm_Password_Text.Text;
                var (success, message) = actionManager.RegisterNewUser(username, password, confirm);
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Vyberte typ účtu: User nebo Admin.");
            }

            // Vyčistit políčka
            Username_Text.Clear();
            Password_Text.Clear();
            Confirm_Password_Text.Clear();
        }
    }
}
