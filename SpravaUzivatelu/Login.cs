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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            LinkToRegistration.Text = "Register";
            ConfirmPasswordTextBox.Visible = false;
            LabelConfirmPassword.Visible = false;

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isOk;
            if(LoginLabel.Text == "Register")
            {
                isOk = UserManager.RegisterUser(UsernameTextBox.Text, PasswordTextBox.Text, ConfirmPasswordTextBox.Text);
               
                if (!isOk)
                {
                    LabelErrorMessage.Text = UserManager.ErrorMessage;
                }
                else
                {
                    LabelErrorMessage.Text = "";
                    LinkToRegistration_LinkClicked(null, null); //back to login
                }
            }
            else if(LoginLabel.Text == "Login")
            {
                isOk = UserManager.LoginUser(UsernameTextBox.Text, PasswordTextBox.Text);

                if (!isOk)
                {
                    LabelErrorMessage.Text = UserManager.ErrorMessage;
                }
                else
                {
                    LabelErrorMessage.Text = "";
                    if (UserManager.LoggedUser.Role == "Admin")
                    {
                        AdminView adminView = new AdminView();
                        adminView.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserView userView = new UserView();
                        userView.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                LabelErrorMessage.Text = "Unknown action.";
            }
        }

        //Zmeny Textu (Login / Register)
        private void LinkToRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LoginLabel.Text == "Login")
            {   
                LinkToRegistration.Text = "Login";
                LabelConfirmPassword.Visible = true;
                ConfirmPasswordTextBox.Visible = true;
                LoginLabel.Text = "Register";
                LoginButton.Text = "Register";
                this.Text = "Registration";
            }
            else
            {
                LinkToRegistration.Text = "Register";
                LabelConfirmPassword.Visible = false;
                ConfirmPasswordTextBox.Visible = false;
                LoginLabel.Text = "Login";
                LoginButton.Text = "Login";
                this.Text = "Login";
            }
        } 
    }
}
