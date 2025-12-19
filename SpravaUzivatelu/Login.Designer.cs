namespace SpravaUzivatelu
{
    partial class Login
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LabelConfirmPassword = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LabelErrorMessage = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LinkToRegistration = new System.Windows.Forms.LinkLabel();
            this.LoginContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginContainer
            // 
            this.LoginContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginContainer.Controls.Add(this.LoginLabel);
            this.LoginContainer.Controls.Add(this.LabelUsername);
            this.LoginContainer.Controls.Add(this.UsernameTextBox);
            this.LoginContainer.Controls.Add(this.LabelPassword);
            this.LoginContainer.Controls.Add(this.PasswordTextBox);
            this.LoginContainer.Controls.Add(this.LabelConfirmPassword);
            this.LoginContainer.Controls.Add(this.ConfirmPasswordTextBox);
            this.LoginContainer.Controls.Add(this.LabelErrorMessage);
            this.LoginContainer.Controls.Add(this.LoginButton);
            this.LoginContainer.Controls.Add(this.LinkToRegistration);
            this.LoginContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LoginContainer.Location = new System.Drawing.Point(12, 4);
            this.LoginContainer.Name = "LoginContainer";
            this.LoginContainer.Size = new System.Drawing.Size(233, 240);
            this.LoginContainer.TabIndex = 0;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(230, 22);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelUsername.Location = new System.Drawing.Point(3, 22);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(63, 14);
            this.LabelUsername.TabIndex = 7;
            this.LabelUsername.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsernameTextBox.Location = new System.Drawing.Point(3, 39);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(230, 25);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPassword.Location = new System.Drawing.Point(3, 67);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(63, 14);
            this.LabelPassword.TabIndex = 8;
            this.LabelPassword.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.Location = new System.Drawing.Point(3, 84);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(230, 25);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // LabelConfirmPassword
            // 
            this.LabelConfirmPassword.AutoSize = true;
            this.LabelConfirmPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelConfirmPassword.Location = new System.Drawing.Point(3, 112);
            this.LabelConfirmPassword.Name = "LabelConfirmPassword";
            this.LabelConfirmPassword.Size = new System.Drawing.Size(119, 14);
            this.LabelConfirmPassword.TabIndex = 9;
            this.LabelConfirmPassword.Text = "Confirm Password";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(3, 129);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(230, 25);
            this.ConfirmPasswordTextBox.TabIndex = 3;
            // 
            // LabelErrorMessage
            // 
            this.LabelErrorMessage.AutoSize = true;
            this.LabelErrorMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.LabelErrorMessage.Location = new System.Drawing.Point(3, 157);
            this.LabelErrorMessage.Name = "LabelErrorMessage";
            this.LabelErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.LabelErrorMessage.TabIndex = 6;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginButton.Location = new System.Drawing.Point(3, 173);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(230, 39);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LinkToRegistration
            // 
            this.LinkToRegistration.AutoSize = true;
            this.LinkToRegistration.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LinkToRegistration.Location = new System.Drawing.Point(3, 215);
            this.LinkToRegistration.Name = "LinkToRegistration";
            this.LinkToRegistration.Size = new System.Drawing.Size(0, 19);
            this.LinkToRegistration.TabIndex = 4;
            this.LinkToRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToRegistration_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 246);
            this.Controls.Add(this.LoginContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginContainer.ResumeLayout(false);
            this.LoginContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LoginContainer;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel LinkToRegistration;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label LabelErrorMessage;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelConfirmPassword;
    }
}

