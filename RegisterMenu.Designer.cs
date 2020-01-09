namespace BudzetManager
{
    partial class RegisterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterMenu));
            this.labelCreateNewBudget = new System.Windows.Forms.Label();
            this.buttoncCreateBudget = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label_repeatPassword = new System.Windows.Forms.Label();
            this.textBoxRepeatPassw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCreateNewBudget
            // 
            this.labelCreateNewBudget.AutoSize = true;
            this.labelCreateNewBudget.BackColor = System.Drawing.Color.Transparent;
            this.labelCreateNewBudget.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewBudget.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCreateNewBudget.Location = new System.Drawing.Point(79, 37);
            this.labelCreateNewBudget.Name = "labelCreateNewBudget";
            this.labelCreateNewBudget.Size = new System.Drawing.Size(363, 28);
            this.labelCreateNewBudget.TabIndex = 0;
            this.labelCreateNewBudget.Text = "Tworzenie nowego budżetu...";
            // 
            // buttoncCreateBudget
            // 
            this.buttoncCreateBudget.BackColor = System.Drawing.Color.Transparent;
            this.buttoncCreateBudget.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.buttoncCreateBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncCreateBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncCreateBudget.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncCreateBudget.Location = new System.Drawing.Point(211, 245);
            this.buttoncCreateBudget.Name = "buttoncCreateBudget";
            this.buttoncCreateBudget.Size = new System.Drawing.Size(141, 38);
            this.buttoncCreateBudget.TabIndex = 15;
            this.buttoncCreateBudget.Text = "ZAREJESTRUJ SIĘ";
            this.buttoncCreateBudget.UseVisualStyleBackColor = false;
            this.buttoncCreateBudget.Click += new System.EventHandler(this.buttoncCreateBudget_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_password.Location = new System.Drawing.Point(142, 156);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(54, 16);
            this.label_password.TabIndex = 14;
            this.label_password.Text = "HASŁO";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_login.Location = new System.Drawing.Point(146, 110);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(48, 16);
            this.label_login.TabIndex = 13;
            this.label_login.Text = "LOGIN";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(211, 149);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(141, 24);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxPassword_PreviewKeyDown);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(211, 103);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(141, 24);
            this.textBoxLogin.TabIndex = 11;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLogin.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxLogin_PreviewKeyDown);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.BackColor = System.Drawing.Color.Transparent;
            this.label_Info.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Info.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Info.Location = new System.Drawing.Point(170, 365);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(298, 57);
            this.label_Info.TabIndex = 16;
            this.label_Info.Text = "Uwaga: Tworząc nowy budżet \r\nstajesz się jego administratorem. \r\nNie można zmieni" +
    "ć administratora budżetu.";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturn.Location = new System.Drawing.Point(211, 289);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(141, 37);
            this.buttonReturn.TabIndex = 17;
            this.buttonReturn.Text = "POWRÓT DO MENU LOGOWANIA";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label_repeatPassword
            // 
            this.label_repeatPassword.AutoSize = true;
            this.label_repeatPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_repeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_repeatPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_repeatPassword.Location = new System.Drawing.Point(68, 199);
            this.label_repeatPassword.Name = "label_repeatPassword";
            this.label_repeatPassword.Size = new System.Drawing.Size(126, 16);
            this.label_repeatPassword.TabIndex = 19;
            this.label_repeatPassword.Text = "POWTÓRZ HASŁO";
            // 
            // textBoxRepeatPassw
            // 
            this.textBoxRepeatPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRepeatPassw.Location = new System.Drawing.Point(211, 191);
            this.textBoxRepeatPassw.Name = "textBoxRepeatPassw";
            this.textBoxRepeatPassw.Size = new System.Drawing.Size(141, 24);
            this.textBoxRepeatPassw.TabIndex = 20;
            this.textBoxRepeatPassw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRepeatPassw.UseSystemPasswordChar = true;
            this.textBoxRepeatPassw.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxRepeatPassw_PreviewKeyDown);
            // 
            // RegisterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BudzetManager.Properties.Resources.register_backgr;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.textBoxRepeatPassw);
            this.Controls.Add(this.label_repeatPassword);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.buttoncCreateBudget);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelCreateNewBudget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateNewBudget;
        private System.Windows.Forms.Button buttoncCreateBudget;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label_repeatPassword;
        private System.Windows.Forms.TextBox textBoxRepeatPassw;
    }
}