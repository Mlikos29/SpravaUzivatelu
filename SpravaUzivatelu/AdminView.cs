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
        }

        private void Show_Logs_Button_Click(object sender, EventArgs e)
        {
            if (currentView == DataViewType.Logs)
            {
                // Toggle: pokud je aktuálně logy, schovej tabulku
                dataGridView.Visible = !dataGridView.Visible;
                if (!dataGridView.Visible) currentView = DataViewType.None;
                return;
            }

            // Přepnutí z users nebo None na logy
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
                // Toggle: pokud je aktuálně users, schovej tabulku
                dataGridView.Visible = !dataGridView.Visible;
                if (!dataGridView.Visible) currentView = DataViewType.None;
                return;
            }

            // Přepnutí z logů nebo None na users
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

        private void Create_User_Radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Create_Admin_Radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Create_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
