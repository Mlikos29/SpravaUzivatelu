namespace SpravaUzivatelu
{
    partial class AdminView
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
            this.LabelAdminView = new System.Windows.Forms.Label();
            this.ButtonShowUsers = new System.Windows.Forms.Button();
            this.User_View_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelAdminView
            // 
            this.LabelAdminView.AutoSize = true;
            this.LabelAdminView.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAdminView.Location = new System.Drawing.Point(331, 9);
            this.LabelAdminView.Name = "LabelAdminView";
            this.LabelAdminView.Size = new System.Drawing.Size(130, 24);
            this.LabelAdminView.TabIndex = 0;
            this.LabelAdminView.Text = "Admin View";
            // 
            // ButtonShowUsers
            // 
            this.ButtonShowUsers.Location = new System.Drawing.Point(83, 98);
            this.ButtonShowUsers.Name = "ButtonShowUsers";
            this.ButtonShowUsers.Size = new System.Drawing.Size(136, 54);
            this.ButtonShowUsers.TabIndex = 1;
            this.ButtonShowUsers.Text = "Show Users";
            this.ButtonShowUsers.UseVisualStyleBackColor = true;
            // 
            // User_View_Button
            // 
            this.User_View_Button.Location = new System.Drawing.Point(713, 415);
            this.User_View_Button.Name = "User_View_Button";
            this.User_View_Button.Size = new System.Drawing.Size(75, 23);
            this.User_View_Button.TabIndex = 2;
            this.User_View_Button.Text = "User View";
            this.User_View_Button.UseVisualStyleBackColor = true;
            this.User_View_Button.Click += new System.EventHandler(this.User_View_Button_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.User_View_Button);
            this.Controls.Add(this.ButtonShowUsers);
            this.Controls.Add(this.LabelAdminView);
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAdminView;
        private System.Windows.Forms.Button ButtonShowUsers;
        private System.Windows.Forms.Button User_View_Button;
    }
}