namespace SpravaUzivatelu
{
    partial class UserView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Change_Password_Button = new System.Windows.Forms.Button();
            this.View_Profile_Button = new System.Windows.Forms.Button();
            this.Change_Password_Box = new System.Windows.Forms.GroupBox();
            this.ErrorMessage_Label = new System.Windows.Forms.Label();
            this.Change_Password_Confirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.New_Password_Text = new System.Windows.Forms.TextBox();
            this.Old_Password_Text = new System.Windows.Forms.TextBox();
            this.View_Profile_Box = new System.Windows.Forms.GroupBox();
            this.Role_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.To_Admin_Button = new System.Windows.Forms.Button();
            this.Change_Password_Box.SuspendLayout();
            this.View_Profile_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ShotAnegrFy";
            // 
            // Change_Password_Button
            // 
            this.Change_Password_Button.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Change_Password_Button.Location = new System.Drawing.Point(12, 144);
            this.Change_Password_Button.Name = "Change_Password_Button";
            this.Change_Password_Button.Size = new System.Drawing.Size(136, 23);
            this.Change_Password_Button.TabIndex = 2;
            this.Change_Password_Button.Text = "Change password";
            this.Change_Password_Button.UseVisualStyleBackColor = true;
            this.Change_Password_Button.Click += new System.EventHandler(this.Change_Password_Button_Click);
            // 
            // View_Profile_Button
            // 
            this.View_Profile_Button.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.View_Profile_Button.Location = new System.Drawing.Point(12, 9);
            this.View_Profile_Button.Name = "View_Profile_Button";
            this.View_Profile_Button.Size = new System.Drawing.Size(75, 23);
            this.View_Profile_Button.TabIndex = 1;
            this.View_Profile_Button.Text = "View profile";
            this.View_Profile_Button.UseVisualStyleBackColor = true;
            this.View_Profile_Button.Click += new System.EventHandler(this.View_Profile_Button_Click);
            // 
            // Change_Password_Box
            // 
            this.Change_Password_Box.Controls.Add(this.ErrorMessage_Label);
            this.Change_Password_Box.Controls.Add(this.Change_Password_Confirm);
            this.Change_Password_Box.Controls.Add(this.label3);
            this.Change_Password_Box.Controls.Add(this.label2);
            this.Change_Password_Box.Controls.Add(this.New_Password_Text);
            this.Change_Password_Box.Controls.Add(this.Old_Password_Text);
            this.Change_Password_Box.Location = new System.Drawing.Point(12, 173);
            this.Change_Password_Box.Name = "Change_Password_Box";
            this.Change_Password_Box.Size = new System.Drawing.Size(156, 156);
            this.Change_Password_Box.TabIndex = 3;
            this.Change_Password_Box.TabStop = false;
            // 
            // ErrorMessage_Label
            // 
            this.ErrorMessage_Label.AutoSize = true;
            this.ErrorMessage_Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorMessage_Label.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage_Label.Location = new System.Drawing.Point(6, 103);
            this.ErrorMessage_Label.Name = "ErrorMessage_Label";
            this.ErrorMessage_Label.Size = new System.Drawing.Size(37, 13);
            this.ErrorMessage_Label.TabIndex = 5;
            this.ErrorMessage_Label.Text = "Error";
            // 
            // Change_Password_Confirm
            // 
            this.Change_Password_Confirm.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Change_Password_Confirm.Location = new System.Drawing.Point(37, 127);
            this.Change_Password_Confirm.Name = "Change_Password_Confirm";
            this.Change_Password_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Change_Password_Confirm.TabIndex = 4;
            this.Change_Password_Confirm.Text = "Confirm";
            this.Change_Password_Confirm.UseVisualStyleBackColor = true;
            this.Change_Password_Confirm.Click += new System.EventHandler(this.Change_Password_Confirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New password";
            // 
            // New_Password_Text
            // 
            this.New_Password_Text.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.New_Password_Text.Location = new System.Drawing.Point(6, 71);
            this.New_Password_Text.Name = "New_Password_Text";
            this.New_Password_Text.PasswordChar = '*';
            this.New_Password_Text.Size = new System.Drawing.Size(130, 20);
            this.New_Password_Text.TabIndex = 1;
            // 
            // Old_Password_Text
            // 
            this.Old_Password_Text.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Old_Password_Text.Location = new System.Drawing.Point(6, 32);
            this.Old_Password_Text.Name = "Old_Password_Text";
            this.Old_Password_Text.PasswordChar = '*';
            this.Old_Password_Text.Size = new System.Drawing.Size(130, 20);
            this.Old_Password_Text.TabIndex = 0;
            // 
            // View_Profile_Box
            // 
            this.View_Profile_Box.Controls.Add(this.Role_Label);
            this.View_Profile_Box.Controls.Add(this.Username_Label);
            this.View_Profile_Box.Location = new System.Drawing.Point(12, 41);
            this.View_Profile_Box.Name = "View_Profile_Box";
            this.View_Profile_Box.Size = new System.Drawing.Size(140, 91);
            this.View_Profile_Box.TabIndex = 4;
            this.View_Profile_Box.TabStop = false;
            // 
            // Role_Label
            // 
            this.Role_Label.AutoSize = true;
            this.Role_Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Role_Label.Location = new System.Drawing.Point(7, 54);
            this.Role_Label.Name = "Role_Label";
            this.Role_Label.Size = new System.Drawing.Size(31, 13);
            this.Role_Label.TabIndex = 1;
            this.Role_Label.Text = "Role";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Username_Label.Location = new System.Drawing.Point(7, 20);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(31, 13);
            this.Username_Label.TabIndex = 0;
            this.Username_Label.Text = "User";
            // 
            // To_Admin_Button
            // 
            this.To_Admin_Button.Location = new System.Drawing.Point(713, 415);
            this.To_Admin_Button.Name = "To_Admin_Button";
            this.To_Admin_Button.Size = new System.Drawing.Size(75, 23);
            this.To_Admin_Button.TabIndex = 5;
            this.To_Admin_Button.Text = "Admin View";
            this.To_Admin_Button.UseVisualStyleBackColor = true;
            this.To_Admin_Button.Click += new System.EventHandler(this.To_Admin_Button_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.To_Admin_Button);
            this.Controls.Add(this.View_Profile_Box);
            this.Controls.Add(this.Change_Password_Box);
            this.Controls.Add(this.View_Profile_Button);
            this.Controls.Add(this.Change_Password_Button);
            this.Controls.Add(this.label1);
            this.Name = "UserView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserView";
            this.Change_Password_Box.ResumeLayout(false);
            this.Change_Password_Box.PerformLayout();
            this.View_Profile_Box.ResumeLayout(false);
            this.View_Profile_Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Change_Password_Button;
        private System.Windows.Forms.Button View_Profile_Button;
        private System.Windows.Forms.GroupBox Change_Password_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox New_Password_Text;
        private System.Windows.Forms.TextBox Old_Password_Text;
        private System.Windows.Forms.Button Change_Password_Confirm;
        private System.Windows.Forms.Label ErrorMessage_Label;
        private System.Windows.Forms.GroupBox View_Profile_Box;
        private System.Windows.Forms.Label Role_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Button To_Admin_Button;
    }
}