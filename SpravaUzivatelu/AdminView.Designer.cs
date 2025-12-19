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
            this.components = new System.ComponentModel.Container();
            this.LabelAdminView = new System.Windows.Forms.Label();
            this.ButtonShowUsers = new System.Windows.Forms.Button();
            this.User_View_Button = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Show_Logs_Button = new System.Windows.Forms.Button();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Create_User_Radio = new System.Windows.Forms.RadioButton();
            this.Create_Admin_Radio = new System.Windows.Forms.RadioButton();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Delete_Username_Text = new System.Windows.Forms.TextBox();
            this.Username_Text = new System.Windows.Forms.TextBox();
            this.Password_Text = new System.Windows.Forms.TextBox();
            this.Confirm_Password_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Error_Create_Label = new System.Windows.Forms.Label();
            this.Error_Delete_Label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.databaseManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseManagerBindingSource)).BeginInit();
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
            this.ButtonShowUsers.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonShowUsers.Location = new System.Drawing.Point(12, 91);
            this.ButtonShowUsers.Name = "ButtonShowUsers";
            this.ButtonShowUsers.Size = new System.Drawing.Size(136, 54);
            this.ButtonShowUsers.TabIndex = 1;
            this.ButtonShowUsers.Text = "Show Users";
            this.ButtonShowUsers.UseVisualStyleBackColor = true;
            this.ButtonShowUsers.Click += new System.EventHandler(this.ButtonShowUsers_Click);
            // 
            // User_View_Button
            // 
            this.User_View_Button.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.User_View_Button.Location = new System.Drawing.Point(713, 415);
            this.User_View_Button.Name = "User_View_Button";
            this.User_View_Button.Size = new System.Drawing.Size(75, 23);
            this.User_View_Button.TabIndex = 2;
            this.User_View_Button.Text = "User View";
            this.User_View_Button.UseVisualStyleBackColor = true;
            this.User_View_Button.Click += new System.EventHandler(this.User_View_Button_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 167);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(552, 271);
            this.dataGridView.TabIndex = 3;
            // 
            // Show_Logs_Button
            // 
            this.Show_Logs_Button.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Show_Logs_Button.Location = new System.Drawing.Point(154, 91);
            this.Show_Logs_Button.Name = "Show_Logs_Button";
            this.Show_Logs_Button.Size = new System.Drawing.Size(136, 54);
            this.Show_Logs_Button.TabIndex = 4;
            this.Show_Logs_Button.Text = "Show logs";
            this.Show_Logs_Button.UseVisualStyleBackColor = true;
            this.Show_Logs_Button.Click += new System.EventHandler(this.Show_Logs_Button_Click);
            // 
            // Create_Button
            // 
            this.Create_Button.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Create_Button.Location = new System.Drawing.Point(3, 179);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(80, 37);
            this.Create_Button.TabIndex = 5;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Create_User_Radio
            // 
            this.Create_User_Radio.AutoSize = true;
            this.Create_User_Radio.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Create_User_Radio.Location = new System.Drawing.Point(3, 3);
            this.Create_User_Radio.Name = "Create_User_Radio";
            this.Create_User_Radio.Size = new System.Drawing.Size(91, 17);
            this.Create_User_Radio.TabIndex = 6;
            this.Create_User_Radio.TabStop = true;
            this.Create_User_Radio.Text = "Create User";
            this.Create_User_Radio.UseVisualStyleBackColor = true;
            this.Create_User_Radio.CheckedChanged += new System.EventHandler(this.Create_User_Radio_CheckedChanged);
            // 
            // Create_Admin_Radio
            // 
            this.Create_Admin_Radio.AutoSize = true;
            this.Create_Admin_Radio.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Create_Admin_Radio.Location = new System.Drawing.Point(3, 26);
            this.Create_Admin_Radio.Name = "Create_Admin_Radio";
            this.Create_Admin_Radio.Size = new System.Drawing.Size(97, 17);
            this.Create_Admin_Radio.TabIndex = 7;
            this.Create_Admin_Radio.TabStop = true;
            this.Create_Admin_Radio.Text = "Create Admin";
            this.Create_Admin_Radio.UseVisualStyleBackColor = true;
            this.Create_Admin_Radio.CheckedChanged += new System.EventHandler(this.Create_Admin_Radio_CheckedChanged);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delete_Button.Location = new System.Drawing.Point(622, 363);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 8;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Delete_Username_Text
            // 
            this.Delete_Username_Text.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delete_Username_Text.Location = new System.Drawing.Point(622, 324);
            this.Delete_Username_Text.Name = "Delete_Username_Text";
            this.Delete_Username_Text.Size = new System.Drawing.Size(116, 20);
            this.Delete_Username_Text.TabIndex = 10;
            // 
            // Username_Text
            // 
            this.Username_Text.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Username_Text.Location = new System.Drawing.Point(3, 62);
            this.Username_Text.Name = "Username_Text";
            this.Username_Text.Size = new System.Drawing.Size(119, 20);
            this.Username_Text.TabIndex = 11;
            // 
            // Password_Text
            // 
            this.Password_Text.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password_Text.Location = new System.Drawing.Point(3, 101);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(119, 20);
            this.Password_Text.TabIndex = 12;
            // 
            // Confirm_Password_Text
            // 
            this.Confirm_Password_Text.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Confirm_Password_Text.Location = new System.Drawing.Point(3, 140);
            this.Confirm_Password_Text.Name = "Confirm_Password_Text";
            this.Confirm_Password_Text.Size = new System.Drawing.Size(119, 20);
            this.Confirm_Password_Text.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirm password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(619, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Username";
            // 
            // Error_Create_Label
            // 
            this.Error_Create_Label.AutoSize = true;
            this.Error_Create_Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Error_Create_Label.ForeColor = System.Drawing.Color.Red;
            this.Error_Create_Label.Location = new System.Drawing.Point(3, 163);
            this.Error_Create_Label.Name = "Error_Create_Label";
            this.Error_Create_Label.Size = new System.Drawing.Size(37, 13);
            this.Error_Create_Label.TabIndex = 18;
            this.Error_Create_Label.Text = "Error";
            // 
            // Error_Delete_Label
            // 
            this.Error_Delete_Label.AutoSize = true;
            this.Error_Delete_Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Error_Delete_Label.ForeColor = System.Drawing.Color.Red;
            this.Error_Delete_Label.Location = new System.Drawing.Point(622, 347);
            this.Error_Delete_Label.Name = "Error_Delete_Label";
            this.Error_Delete_Label.Size = new System.Drawing.Size(37, 13);
            this.Error_Delete_Label.TabIndex = 19;
            this.Error_Delete_Label.Text = "Error";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.Create_User_Radio);
            this.flowLayoutPanel1.Controls.Add(this.Create_Admin_Radio);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.Username_Text);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.Password_Text);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.Confirm_Password_Text);
            this.flowLayoutPanel1.Controls.Add(this.Error_Create_Label);
            this.flowLayoutPanel1.Controls.Add(this.Create_Button);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(622, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(141, 239);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // databaseManagerBindingSource
            // 
            this.databaseManagerBindingSource.DataSource = typeof(SpravaUzivatelu.DbContext.DatabaseManager);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Error_Delete_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Delete_Username_Text);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Show_Logs_Button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.User_View_Button);
            this.Controls.Add(this.ButtonShowUsers);
            this.Controls.Add(this.LabelAdminView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAdminView;
        private System.Windows.Forms.Button ButtonShowUsers;
        private System.Windows.Forms.Button User_View_Button;
        private System.Windows.Forms.BindingSource databaseManagerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Show_Logs_Button;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.RadioButton Create_User_Radio;
        private System.Windows.Forms.RadioButton Create_Admin_Radio;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox Delete_Username_Text;
        private System.Windows.Forms.TextBox Username_Text;
        private System.Windows.Forms.TextBox Password_Text;
        private System.Windows.Forms.TextBox Confirm_Password_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Error_Create_Label;
        private System.Windows.Forms.Label Error_Delete_Label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}