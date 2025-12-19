using SpravaUzivatelu.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace SpravaUzivatelu
{
    public partial class AdminView : Form
    {
        ActionManager actionManager = ActionManager.Instance;
        private enum DataViewType { None, Logs, Users } // Track current view
        private DataViewType currentView = DataViewType.None;

        public AdminView()
        {
            InitializeComponent();

            // DatagridView
            dataGridView.Visible = false;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Font = new System.Drawing.Font("Consolas", 8);

            // Errors
            Error_Delete_Label.Text = "";
            Error_Create_Label.Text = "";

            // User creation only
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
                MessageBox.Show(message);
                return;
            }

            if (dataObj is DataTable datatable)
            {
                dataGridView.DataSource = datatable;
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

            DataTable datatable = actionManager.ViewAllUsers();
            if (datatable == null)
            {
                MessageBox.Show("Cant show users");
                return;
            }

            dataGridView.DataSource = datatable;
            SetUserColumnsHeaders();
            dataGridView.Visible = true;
            currentView = DataViewType.Users;
        }

        // Setup DataGridView columns headers
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

        // Setup DataGridView columns headers
        private void SetUserColumnsHeaders()
        {
            if (dataGridView.Columns.Contains("Username"))
                dataGridView.Columns["Username"].HeaderText = "Username";
            if (dataGridView.Columns.Contains("Role"))
                dataGridView.Columns["Role"].HeaderText = "Role";
            if (dataGridView.Columns.Contains("CreatedAt"))
                dataGridView.Columns["CreatedAt"].HeaderText = "CreateAt";
        }

        // Open User View Form
        private void User_View_Button_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new UserView());
        }

        // Show/Hide Confirm Password (ActionManager go brrr, TODO: For Admin add confirm password)
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
            if (string.IsNullOrWhiteSpace(Username_Text.Text) || string.IsNullOrWhiteSpace(Password_Text.Text))
            {
                Error_Create_Label.Text = ("Invalid inputs");
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
                Error_Create_Label.Text = ("Something invalid");
            }

            // Clear
            Username_Text.Clear();
            Password_Text.Clear();
            Confirm_Password_Text.Clear();
        }

        // Delete anyone
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var (success, message) = actionManager.DeleteUser(Delete_Username_Text.Text);

            if (success)
            {
                MessageBox.Show($"User {Delete_Username_Text.Text} has been deleted.");
                Delete_Username_Text.Clear();

                // If currently viewing users refresh the list
                if (currentView == DataViewType.Users && dataGridView.Visible)
                {
                    DataTable datatable = actionManager.ViewAllUsers();
                    if (datatable != null) dataGridView.DataSource = datatable;
                }
            }
            else
            {
                Error_Delete_Label.Text =(message);
            }
        }
    }
}
