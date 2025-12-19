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
        private ActionManager actionManager;
        public Login()
        {
            InitializeComponent();

            LinkToRegistration.Text = "Register";
            ConfirmPasswordTextBox.Visible = false;
            LabelConfirmPassword.Visible = false;
            actionManager = new ActionManager();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Text == "Login")
            {
                RegistrationUser();
            }
            else if (LoginLabel.Text == "Register")
            {
                LoginUser();
            }
            else
            {
                LabelErrorMessage.Text = "Unknown action.";
            }
        }
        private void RegistrationUser()
        {
            (bool isOk, string Errormessage) = actionManager.RegisterNewUser(UsernameTextBox.Text, PasswordTextBox.Text, ConfirmPasswordTextBox.Text);
            if (!isOk)
            {
                LabelErrorMessage.Text = Errormessage;
                return;
            }
            LabelErrorMessage.Text = "";
            SwitchToLoginMode();
        }
        private void LoginUser()
        {
            bool isOk = UserManager.LoginUser(UsernameTextBox.Text, PasswordTextBox.Text);
            
            if (!isOk)
            {
                LabelErrorMessage.Text = UserManager.ErrorMessage;
                return;
            }

            LabelErrorMessage.Text = "";

            // otevřít formulář podle role
            if (ActionManager.Role == "Admin")
            {
                OpenForm(new AdminView());
            }
            else
            {
                OpenForm(new UserView());
            }
        }
        private void OpenForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close(); // hned co se novej otevře tak se starej zavře
            form.Show();
        }
        private void SwitchToLoginMode()
        {
            LinkToRegistration_LinkClicked(null, null);
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
