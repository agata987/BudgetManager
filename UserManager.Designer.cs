namespace BudzetManager
{
    partial class UserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Uzytkownicy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxRepeatPassw = new System.Windows.Forms.TextBox();
            this.label_repeatPassword = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uzytkownicy});
            this.dataGridViewUsers.Location = new System.Drawing.Point(53, 63);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(188, 191);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // Uzytkownicy
            // 
            this.Uzytkownicy.DataPropertyName = "id_uzytkownika";
            this.Uzytkownicy.HeaderText = "     Użytkownicy";
            this.Uzytkownicy.Name = "Uzytkownicy";
            this.Uzytkownicy.ReadOnly = true;
            // 
            // textBoxRepeatPassw
            // 
            this.textBoxRepeatPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRepeatPassw.Location = new System.Drawing.Point(414, 230);
            this.textBoxRepeatPassw.Name = "textBoxRepeatPassw";
            this.textBoxRepeatPassw.Size = new System.Drawing.Size(141, 24);
            this.textBoxRepeatPassw.TabIndex = 27;
            this.textBoxRepeatPassw.UseSystemPasswordChar = true;
            this.textBoxRepeatPassw.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxRepeatPassw_PreviewKeyDown);
            // 
            // label_repeatPassword
            // 
            this.label_repeatPassword.AutoSize = true;
            this.label_repeatPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_repeatPassword.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_repeatPassword.ForeColor = System.Drawing.Color.White;
            this.label_repeatPassword.Location = new System.Drawing.Point(283, 236);
            this.label_repeatPassword.Name = "label_repeatPassword";
            this.label_repeatPassword.Size = new System.Drawing.Size(109, 16);
            this.label_repeatPassword.TabIndex = 26;
            this.label_repeatPassword.Text = "POWTÓRZ HASŁO";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(345, 194);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(47, 16);
            this.label_password.TabIndex = 25;
            this.label_password.Text = "HASŁO";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(348, 148);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(44, 16);
            this.label_login.TabIndex = 24;
            this.label_login.Text = "LOGIN";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(414, 188);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(141, 24);
            this.textBoxPassword.TabIndex = 23;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxPassword_PreviewKeyDown);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(414, 142);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(141, 24);
            this.textBoxLogin.TabIndex = 22;
            this.textBoxLogin.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxLogin_PreviewKeyDown);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteUser.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.buttonDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(73, 293);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(141, 38);
            this.buttonDeleteUser.TabIndex = 29;
            this.buttonDeleteUser.Text = "USUŃ UŻYTKOWNIKA";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddUser.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.buttonAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddUser.Location = new System.Drawing.Point(414, 293);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(141, 38);
            this.buttonAddUser.TabIndex = 30;
            this.buttonAddUser.Text = "DODAJ UŻYTKOWNIKA";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BudzetManager.Properties.Resources.logib_icn;
            this.pictureBox1.Location = new System.Drawing.Point(452, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BudzetManager.Properties.Resources.blue_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 381);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxRepeatPassw);
            this.Controls.Add(this.label_repeatPassword);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.dataGridViewUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxRepeatPassw;
        private System.Windows.Forms.Label label_repeatPassword;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uzytkownicy;
    }
}