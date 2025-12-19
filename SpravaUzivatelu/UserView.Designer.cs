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
            this.Old_Password_Text = new System.Windows.Forms.TextBox();
            this.New_Password_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Change_Password_Confirm = new System.Windows.Forms.Button();
            this.Change_Password_Box.SuspendLayout();
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
            this.Change_Password_Button.Location = new System.Drawing.Point(573, 12);
            this.Change_Password_Button.Name = "Change_Password_Button";
            this.Change_Password_Button.Size = new System.Drawing.Size(103, 23);
            this.Change_Password_Button.TabIndex = 1;
            this.Change_Password_Button.Text = "Change password";
            this.Change_Password_Button.UseVisualStyleBackColor = true;
            this.Change_Password_Button.Click += new System.EventHandler(this.Change_Password_Button_Click);
            // 
            // View_Profile_Button
            // 
            this.View_Profile_Button.Location = new System.Drawing.Point(713, 12);
            this.View_Profile_Button.Name = "View_Profile_Button";
            this.View_Profile_Button.Size = new System.Drawing.Size(75, 23);
            this.View_Profile_Button.TabIndex = 2;
            this.View_Profile_Button.Text = "View profile";
            this.View_Profile_Button.UseVisualStyleBackColor = true;
            this.View_Profile_Button.Click += new System.EventHandler(this.View_Profile_Button_Click);
            // 
            // Change_Password_Box
            // 
            this.Change_Password_Box.Controls.Add(this.Change_Password_Confirm);
            this.Change_Password_Box.Controls.Add(this.label3);
            this.Change_Password_Box.Controls.Add(this.label2);
            this.Change_Password_Box.Controls.Add(this.New_Password_Text);
            this.Change_Password_Box.Controls.Add(this.Old_Password_Text);
            this.Change_Password_Box.Location = new System.Drawing.Point(520, 41);
            this.Change_Password_Box.Name = "Change_Password_Box";
            this.Change_Password_Box.Size = new System.Drawing.Size(156, 130);
            this.Change_Password_Box.TabIndex = 3;
            this.Change_Password_Box.TabStop = false;
            // 
            // Old_Password_Text
            // 
            this.Old_Password_Text.Location = new System.Drawing.Point(6, 32);
            this.Old_Password_Text.Name = "Old_Password_Text";
            this.Old_Password_Text.Size = new System.Drawing.Size(130, 20);
            this.Old_Password_Text.TabIndex = 0;
            // 
            // New_Password_Text
            // 
            this.New_Password_Text.Location = new System.Drawing.Point(6, 71);
            this.New_Password_Text.Name = "New_Password_Text";
            this.New_Password_Text.Size = new System.Drawing.Size(130, 20);
            this.New_Password_Text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Old password";
            // 
            // Change_Password_Confirm
            // 
            this.Change_Password_Confirm.Location = new System.Drawing.Point(33, 97);
            this.Change_Password_Confirm.Name = "Change_Password_Confirm";
            this.Change_Password_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Change_Password_Confirm.TabIndex = 4;
            this.Change_Password_Confirm.Text = "Change";
            this.Change_Password_Confirm.UseVisualStyleBackColor = true;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Change_Password_Box);
            this.Controls.Add(this.View_Profile_Button);
            this.Controls.Add(this.Change_Password_Button);
            this.Controls.Add(this.label1);
            this.Name = "UserView";
            this.Text = "UserView";
            this.Change_Password_Box.ResumeLayout(false);
            this.Change_Password_Box.PerformLayout();
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
    }
}