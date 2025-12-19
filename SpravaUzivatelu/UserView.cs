using SpravaUzivatelu.Model;
using SpravaUzivatelu.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpravaUzivatelu
{
    
    public partial class UserView : Form
    {
        ActionManager actionmanager;
        
        public UserView()
        {
            InitializeComponent();
            Change_Password_Box.Visible = false;
            View_Profile_Box.Visible = false;
            actionmanager = ActionManager.Instance;
            ErrorMessage_Label.Text = "";
            User user = actionmanager.ViewMyProfile();
            To_Admin_Button.Visible = false;
            if (user.Role == "Admin")
                To_Admin_Button.Visible = true;
        }

        private void View_Profile_Button_Click(object sender, EventArgs e)
        {
            if (View_Profile_Box.Visible == false)
            {
                View_Profile_Box.Visible = true;
            }
            else if (View_Profile_Box.Visible == true)
            {
                View_Profile_Box.Visible = false;
            }
            
            User user = actionmanager.ViewMyProfile();
            if (user != null)
            {
                Username_Label.Text = ($"Username: {user.Username}");
                Role_Label.Text = ($"Role: {user.Role}");
            }
            else
            {
                Username_Label.ForeColor = Color.Red;
                Role_Label.ForeColor = Color.Red;
                Username_Label.Text = ("Username: Nenačteno");
                Role_Label.Text = ("Role: Nenačteno");
            }
        }

        private void Change_Password_Button_Click(object sender, EventArgs e)
        {
            if (Change_Password_Box.Visible == false)
            {
                Change_Password_Box.Visible = true;
            }
            else if (Change_Password_Box.Visible == true)
            {
                Change_Password_Box.Visible = false;
            }
        }

        private void Change_Password_Confirm_Click(object sender, EventArgs e)
        {
            (bool success, string ErrorMessage) = actionmanager.ChangeMyPassword(Old_Password_Text.Text, New_Password_Text.Text);
            if (!success)
            {
                ErrorMessage_Label.Text = ErrorMessage;
                return;
            }
            else
            {
                Change_Password_Box.Visible = false;
            }
        }

        private void To_Admin_Button_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(this, new AdminView());
        }
    }
}
