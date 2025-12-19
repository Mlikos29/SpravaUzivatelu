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
    public partial class Login : Form
    {
        private ActionManager actionManager;
        public Login()
        {
            InitializeComponent();

            LinkToRegistration.Text = "Register";
            ConfirmPasswordTextBox.Visible = false;
            LabelConfirmPassword.Visible = false;
            actionManager = ActionManager.Instance;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Text == "Login")
            {
                LoginUser();
            }
            else if (LoginLabel.Text == "Register")
            {
                RegistrationUser();
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
            (bool isOk, string ErrorMessage) = actionManager.LoginUser(UsernameTextBox.Text, PasswordTextBox.Text);

            if (!isOk)
            {
                LabelErrorMessage.Text = ErrorMessage;
                return;
            }

            LabelErrorMessage.Text = "";

            FormHelper.OpenForm(this, new UserView());
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
