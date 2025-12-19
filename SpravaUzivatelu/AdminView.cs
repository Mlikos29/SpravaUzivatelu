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
            dataGridView.Visible = false;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Font = new System.Drawing.Font("Consolas", 8);
            Error_Delete_Label.Text = "";
            Error_Create_Label.Text = "";

            // Show only for user creation
            Confirm_Password_Text.Visible = Create_User_Radio.Checked;
            label3.Visible = Create_User_Radio.Checked;
        }

        // Logs
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
                MessageBox.Show("Cant show logs: " + message);
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

        // Users
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
                MessageBox.Show("Cant show users");
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
                dataGridView.Columns["Timestamp"].HeaderText = "Timestamp";
            if (dataGridView.Columns.Contains("Username"))
                dataGridView.Columns["Username"].HeaderText = "Username";
            if (dataGridView.Columns.Contains("Action"))
                dataGridView.Columns["Action"].HeaderText = "Action";
            if (dataGridView.Columns.Contains("Details"))
                dataGridView.Columns["Details"].HeaderText = "Details";
        }

        private void SetUserColumnsHeaders()
        {
            if (dataGridView.Columns.Contains("Username"))
                dataGridView.Columns["Username"].HeaderText = "Username";
            if (dataGridView.Columns.Contains("Role"))
                dataGridView.Columns["Role"].HeaderText = "Role";
            if (dataGridView.Columns.Contains("CreatedAt"))
                dataGridView.Columns["CreatedAt"].HeaderText = "Added";
        }

        // Open User View Form
        private void User_View_Button_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new UserView());
        }

        // Show/Hide Confirm Password
        private void Create_User_Radio_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = Create_User_Radio.Checked;
            Confirm_Password_Text.Visible = Create_User_Radio.Checked;
        }

        private void Create_Admin_Radio_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            Confirm_Password_Text.Visible = false;
        }

        // Create User/Admin
        private void Create_Button_Click(object sender, EventArgs e)
        {
            string username = Username_Text.Text;
            string password = Password_Text.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(Password_Text.Text))
            {
                Error_Create_Label.Text = ("Not valid inputs");
                return;
            }

            if (Create_Admin_Radio.Checked)
            {
                var (success, message) = actionManager.CreateNewAdmin(Username_Text.Text, Password_Text.Text);
                MessageBox.Show(message);
            }
            else if (Create_User_Radio.Checked)
            {
                var (success, message) = actionManager.RegisterNewUser(Username_Text.Text, Password_Text.Text,Confirm_Password_Text.Text);
                MessageBox.Show(message);
            }
            else
            {
                Error_Create_Label.Text = ("Choosse admin or user");
            }

            // Clear
            Username_Text.Clear();
            Password_Text.Clear();
            Confirm_Password_Text.Clear();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Delete_Username_Text.Text))
            {
                Error_Delete_Label.Text = ("Invalid Username");
                return;
            }

            var (success, message) = actionManager.DeleteUser(Delete_Username_Text.Text);

            if (success)
            {
                MessageBox.Show($"User {Delete_Username_Text.Text} has been deleted.");
                Delete_Username_Text.Clear();

                // If currently viewing users refresh the list
                if (currentView == DataViewType.Users && dataGridView.Visible)
                {
                    var dt = actionManager.ViewAllUsers();
                    if (dt != null) dataGridView.DataSource = dt;
                }
            }
            else
            {
                Error_Delete_Label.Text =(message);
            }
        }
    }
}
