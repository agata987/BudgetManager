namespace BudzetManager
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.TabMain = new System.Windows.Forms.TabControl();
            this.tabPageMainPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonHelp_mainTab = new System.Windows.Forms.Button();
            this.label_actState_mainTab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_checkLimits = new System.Windows.Forms.Button();
            this.button_cat_limits_mainTab = new System.Windows.Forms.Button();
            this.labelUserName_mainTab = new System.Windows.Forms.Label();
            this.button_manage_reg_mainTab = new System.Windows.Forms.Button();
            this.buttonAdd_inc_out_mainTab = new System.Windows.Forms.Button();
            this.textBox_setBudget_mainTab = new System.Windows.Forms.TextBox();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.button_zestawieniaFinansowe = new System.Windows.Forms.Button();
            this.button_prognozaFinansowa = new System.Windows.Forms.Button();
            this.buttonRenew_history = new System.Windows.Forms.Button();
            this.buttonfiltr_history = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_year_history = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_month_history = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_category_history = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_income_history = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_user_history = new System.Windows.Forms.ComboBox();
            this.textBox_sum_history = new System.Windows.Forms.TextBox();
            this.dataGridView_history = new System.Windows.Forms.DataGridView();
            this.Rodzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kwota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uzytkownik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_login_konto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.button_logout_konto = new System.Windows.Forms.Button();
            this.textBox_login_konto = new System.Windows.Forms.TextBox();
            this.textBox_admin_konto = new System.Windows.Forms.TextBox();
            this.textBox_repeatPass_konto = new System.Windows.Forms.TextBox();
            this.label_repeatPass_konto = new System.Windows.Forms.Label();
            this.button_delete_acc_konto = new System.Windows.Forms.Button();
            this.button_changePass_konto = new System.Windows.Forms.Button();
            this.textBox_ChangePass_konto = new System.Windows.Forms.TextBox();
            this.label_changePass = new System.Windows.Forms.Label();
            this.label_newPass_konto = new System.Windows.Forms.Label();
            this.label_info_konto = new System.Windows.Forms.Label();
            this.button_manage_konto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabMain.SuspendLayout();
            this.tabPageMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).BeginInit();
            this.tabPageAccount.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabMain.Controls.Add(this.tabPageMainPage);
            this.TabMain.Controls.Add(this.tabPageHistory);
            this.TabMain.Controls.Add(this.tabPageAccount);
            this.TabMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TabMain.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabMain.Location = new System.Drawing.Point(-5, 2);
            this.TabMain.Multiline = true;
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(817, 528);
            this.TabMain.TabIndex = 0;
            // 
            // tabPageMainPage
            // 
            this.tabPageMainPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPageMainPage.BackgroundImage = global::BudzetManager.Properties.Resources.Best_Blur_Background_App_Compare_The_Top_6_Blur_Background_Apps;
            this.tabPageMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageMainPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageMainPage.Controls.Add(this.pictureBox2);
            this.tabPageMainPage.Controls.Add(this.buttonHelp_mainTab);
            this.tabPageMainPage.Controls.Add(this.label_actState_mainTab);
            this.tabPageMainPage.Controls.Add(this.panel1);
            this.tabPageMainPage.Controls.Add(this.textBox_setBudget_mainTab);
            this.tabPageMainPage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageMainPage.Location = new System.Drawing.Point(4, 29);
            this.tabPageMainPage.Name = "tabPageMainPage";
            this.tabPageMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainPage.Size = new System.Drawing.Size(809, 495);
            this.tabPageMainPage.TabIndex = 0;
            this.tabPageMainPage.Text = "STRONA GŁÓWNA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::BudzetManager.Properties.Resources.wallet;
            this.pictureBox2.Location = new System.Drawing.Point(487, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // buttonHelp_mainTab
            // 
            this.buttonHelp_mainTab.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp_mainTab.BackgroundImage = global::BudzetManager.Properties.Resources.thisGray;
            this.buttonHelp_mainTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHelp_mainTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp_mainTab.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp_mainTab.ForeColor = System.Drawing.Color.White;
            this.buttonHelp_mainTab.Location = new System.Drawing.Point(770, 460);
            this.buttonHelp_mainTab.Name = "buttonHelp_mainTab";
            this.buttonHelp_mainTab.Size = new System.Drawing.Size(31, 27);
            this.buttonHelp_mainTab.TabIndex = 14;
            this.buttonHelp_mainTab.Text = "?";
            this.buttonHelp_mainTab.UseVisualStyleBackColor = false;
            // 
            // label_actState_mainTab
            // 
            this.label_actState_mainTab.AutoSize = true;
            this.label_actState_mainTab.BackColor = System.Drawing.Color.Transparent;
            this.label_actState_mainTab.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_actState_mainTab.ForeColor = System.Drawing.Color.White;
            this.label_actState_mainTab.Location = new System.Drawing.Point(425, 150);
            this.label_actState_mainTab.Name = "label_actState_mainTab";
            this.label_actState_mainTab.Size = new System.Drawing.Size(233, 22);
            this.label_actState_mainTab.TabIndex = 3;
            this.label_actState_mainTab.Text = "AKTUALNY STAN BUDŻETU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_checkLimits);
            this.panel1.Controls.Add(this.button_cat_limits_mainTab);
            this.panel1.Controls.Add(this.labelUserName_mainTab);
            this.panel1.Controls.Add(this.button_manage_reg_mainTab);
            this.panel1.Controls.Add(this.buttonAdd_inc_out_mainTab);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 499);
            this.panel1.TabIndex = 15;
            // 
            // button_checkLimits
            // 
            this.button_checkLimits.BackColor = System.Drawing.Color.Transparent;
            this.button_checkLimits.BackgroundImage = global::BudzetManager.Properties.Resources.thisGray;
            this.button_checkLimits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_checkLimits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_checkLimits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_checkLimits.ForeColor = System.Drawing.Color.White;
            this.button_checkLimits.Location = new System.Drawing.Point(-1, 367);
            this.button_checkLimits.Name = "button_checkLimits";
            this.button_checkLimits.Size = new System.Drawing.Size(292, 27);
            this.button_checkLimits.TabIndex = 14;
            this.button_checkLimits.Text = "Sprawdź limity";
            this.button_checkLimits.UseVisualStyleBackColor = false;
            this.button_checkLimits.Click += new System.EventHandler(this.button_checkLimits_Click);
            // 
            // button_cat_limits_mainTab
            // 
            this.button_cat_limits_mainTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_cat_limits_mainTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cat_limits_mainTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cat_limits_mainTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cat_limits_mainTab.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cat_limits_mainTab.ForeColor = System.Drawing.Color.Black;
            this.button_cat_limits_mainTab.Location = new System.Drawing.Point(-1, 329);
            this.button_cat_limits_mainTab.Name = "button_cat_limits_mainTab";
            this.button_cat_limits_mainTab.Size = new System.Drawing.Size(292, 38);
            this.button_cat_limits_mainTab.TabIndex = 13;
            this.button_cat_limits_mainTab.Text = "KATEGORIE I LIMITY\r\n";
            this.button_cat_limits_mainTab.UseVisualStyleBackColor = false;
            this.button_cat_limits_mainTab.Click += new System.EventHandler(this.button_cat_limits_mainTab_Click);
            // 
            // labelUserName_mainTab
            // 
            this.labelUserName_mainTab.AutoSize = true;
            this.labelUserName_mainTab.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName_mainTab.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName_mainTab.ForeColor = System.Drawing.Color.White;
            this.labelUserName_mainTab.Location = new System.Drawing.Point(26, 94);
            this.labelUserName_mainTab.Name = "labelUserName_mainTab";
            this.labelUserName_mainTab.Size = new System.Drawing.Size(185, 26);
            this.labelUserName_mainTab.TabIndex = 2;
            this.labelUserName_mainTab.Text = "Witaj userName!";
            // 
            // button_manage_reg_mainTab
            // 
            this.button_manage_reg_mainTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_manage_reg_mainTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_manage_reg_mainTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_manage_reg_mainTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage_reg_mainTab.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manage_reg_mainTab.ForeColor = System.Drawing.Color.Black;
            this.button_manage_reg_mainTab.Location = new System.Drawing.Point(-1, 239);
            this.button_manage_reg_mainTab.Name = "button_manage_reg_mainTab";
            this.button_manage_reg_mainTab.Size = new System.Drawing.Size(292, 58);
            this.button_manage_reg_mainTab.TabIndex = 12;
            this.button_manage_reg_mainTab.Text = "ZARZĄDZAJ PRZYCHODAMI\r\nI OPŁATAMI REGULARNYMI";
            this.button_manage_reg_mainTab.UseVisualStyleBackColor = false;
            this.button_manage_reg_mainTab.Click += new System.EventHandler(this.button_manage_reg_mainTab_Click);
            // 
            // buttonAdd_inc_out_mainTab
            // 
            this.buttonAdd_inc_out_mainTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdd_inc_out_mainTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd_inc_out_mainTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd_inc_out_mainTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd_inc_out_mainTab.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd_inc_out_mainTab.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd_inc_out_mainTab.Location = new System.Drawing.Point(-1, 150);
            this.buttonAdd_inc_out_mainTab.Name = "buttonAdd_inc_out_mainTab";
            this.buttonAdd_inc_out_mainTab.Size = new System.Drawing.Size(292, 55);
            this.buttonAdd_inc_out_mainTab.TabIndex = 11;
            this.buttonAdd_inc_out_mainTab.Text = "DODAJ PRZYCHÓD LUB WYDATEK";
            this.buttonAdd_inc_out_mainTab.UseVisualStyleBackColor = false;
            this.buttonAdd_inc_out_mainTab.Click += new System.EventHandler(this.buttonAdd_inc_out_mainTab_Click);
            // 
            // textBox_setBudget_mainTab
            // 
            this.textBox_setBudget_mainTab.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox_setBudget_mainTab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_setBudget_mainTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_setBudget_mainTab.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_setBudget_mainTab.ForeColor = System.Drawing.Color.White;
            this.textBox_setBudget_mainTab.Location = new System.Drawing.Point(285, 185);
            this.textBox_setBudget_mainTab.Name = "textBox_setBudget_mainTab";
            this.textBox_setBudget_mainTab.ReadOnly = true;
            this.textBox_setBudget_mainTab.Size = new System.Drawing.Size(523, 26);
            this.textBox_setBudget_mainTab.TabIndex = 5;
            this.textBox_setBudget_mainTab.Text = "???";
            this.textBox_setBudget_mainTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPageHistory.BackgroundImage = global::BudzetManager.Properties.Resources.Best_Blur_Background_App_Compare_The_Top_6_Blur_Background_Apps;
            this.tabPageHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageHistory.Controls.Add(this.button_zestawieniaFinansowe);
            this.tabPageHistory.Controls.Add(this.button_prognozaFinansowa);
            this.tabPageHistory.Controls.Add(this.buttonRenew_history);
            this.tabPageHistory.Controls.Add(this.buttonfiltr_history);
            this.tabPageHistory.Controls.Add(this.label5);
            this.tabPageHistory.Controls.Add(this.textBox_year_history);
            this.tabPageHistory.Controls.Add(this.label4);
            this.tabPageHistory.Controls.Add(this.comboBox_month_history);
            this.tabPageHistory.Controls.Add(this.label3);
            this.tabPageHistory.Controls.Add(this.comboBox_category_history);
            this.tabPageHistory.Controls.Add(this.label1);
            this.tabPageHistory.Controls.Add(this.comboBox_income_history);
            this.tabPageHistory.Controls.Add(this.label8);
            this.tabPageHistory.Controls.Add(this.comboBox_user_history);
            this.tabPageHistory.Controls.Add(this.textBox_sum_history);
            this.tabPageHistory.Controls.Add(this.dataGridView_history);
            this.tabPageHistory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageHistory.Location = new System.Drawing.Point(4, 29);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(809, 495);
            this.tabPageHistory.TabIndex = 1;
            this.tabPageHistory.Text = "HISTORIA";
            // 
            // button_zestawieniaFinansowe
            // 
            this.button_zestawieniaFinansowe.BackColor = System.Drawing.Color.Transparent;
            this.button_zestawieniaFinansowe.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_zestawieniaFinansowe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_zestawieniaFinansowe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zestawieniaFinansowe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_zestawieniaFinansowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zestawieniaFinansowe.Location = new System.Drawing.Point(558, 415);
            this.button_zestawieniaFinansowe.Name = "button_zestawieniaFinansowe";
            this.button_zestawieniaFinansowe.Size = new System.Drawing.Size(122, 38);
            this.button_zestawieniaFinansowe.TabIndex = 54;
            this.button_zestawieniaFinansowe.Text = "ZESTAWIENIA FINANSOWE";
            this.button_zestawieniaFinansowe.UseVisualStyleBackColor = false;
            this.button_zestawieniaFinansowe.Click += new System.EventHandler(this.button_zestawieniaFinansowe_Click);
            // 
            // button_prognozaFinansowa
            // 
            this.button_prognozaFinansowa.BackColor = System.Drawing.Color.Transparent;
            this.button_prognozaFinansowa.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_prognozaFinansowa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_prognozaFinansowa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prognozaFinansowa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_prognozaFinansowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_prognozaFinansowa.Location = new System.Drawing.Point(558, 365);
            this.button_prognozaFinansowa.Name = "button_prognozaFinansowa";
            this.button_prognozaFinansowa.Size = new System.Drawing.Size(122, 38);
            this.button_prognozaFinansowa.TabIndex = 53;
            this.button_prognozaFinansowa.Text = "PROGNOZA FINANSOWA";
            this.button_prognozaFinansowa.UseVisualStyleBackColor = false;
            this.button_prognozaFinansowa.Click += new System.EventHandler(this.button_prognozaFinansowa_Click);
            // 
            // buttonRenew_history
            // 
            this.buttonRenew_history.BackColor = System.Drawing.Color.Transparent;
            this.buttonRenew_history.BackgroundImage = global::BudzetManager.Properties.Resources.reloadButton;
            this.buttonRenew_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRenew_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRenew_history.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRenew_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRenew_history.Location = new System.Drawing.Point(490, 413);
            this.buttonRenew_history.Name = "buttonRenew_history";
            this.buttonRenew_history.Size = new System.Drawing.Size(44, 40);
            this.buttonRenew_history.TabIndex = 52;
            this.buttonRenew_history.UseVisualStyleBackColor = false;
            this.buttonRenew_history.Click += new System.EventHandler(this.buttonRenew_history_Click);
            // 
            // buttonfiltr_history
            // 
            this.buttonfiltr_history.BackColor = System.Drawing.Color.Transparent;
            this.buttonfiltr_history.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.buttonfiltr_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonfiltr_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonfiltr_history.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonfiltr_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonfiltr_history.Location = new System.Drawing.Point(411, 415);
            this.buttonfiltr_history.Name = "buttonfiltr_history";
            this.buttonfiltr_history.Size = new System.Drawing.Size(73, 38);
            this.buttonfiltr_history.TabIndex = 51;
            this.buttonfiltr_history.Text = "FILTRUJ";
            this.buttonfiltr_history.UseVisualStyleBackColor = false;
            this.buttonfiltr_history.Click += new System.EventHandler(this.buttonfiltr_history_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(422, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "ROK";
            // 
            // textBox_year_history
            // 
            this.textBox_year_history.Location = new System.Drawing.Point(411, 373);
            this.textBox_year_history.Name = "textBox_year_history";
            this.textBox_year_history.Size = new System.Drawing.Size(123, 25);
            this.textBox_year_history.TabIndex = 49;
            this.textBox_year_history.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(275, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "MIESIĄC";
            // 
            // comboBox_month_history
            // 
            this.comboBox_month_history.DropDownHeight = 110;
            this.comboBox_month_history.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_month_history.FormattingEnabled = true;
            this.comboBox_month_history.IntegralHeight = false;
            this.comboBox_month_history.Location = new System.Drawing.Point(264, 373);
            this.comboBox_month_history.Name = "comboBox_month_history";
            this.comboBox_month_history.Size = new System.Drawing.Size(123, 25);
            this.comboBox_month_history.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(275, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "KATEGORIA";
            // 
            // comboBox_category_history
            // 
            this.comboBox_category_history.DropDownHeight = 110;
            this.comboBox_category_history.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category_history.FormattingEnabled = true;
            this.comboBox_category_history.IntegralHeight = false;
            this.comboBox_category_history.Location = new System.Drawing.Point(264, 428);
            this.comboBox_category_history.Name = "comboBox_category_history";
            this.comboBox_category_history.Size = new System.Drawing.Size(123, 25);
            this.comboBox_category_history.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "RODZAJ";
            // 
            // comboBox_income_history
            // 
            this.comboBox_income_history.DropDownHeight = 110;
            this.comboBox_income_history.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_income_history.FormattingEnabled = true;
            this.comboBox_income_history.IntegralHeight = false;
            this.comboBox_income_history.Location = new System.Drawing.Point(112, 428);
            this.comboBox_income_history.Name = "comboBox_income_history";
            this.comboBox_income_history.Size = new System.Drawing.Size(123, 25);
            this.comboBox_income_history.TabIndex = 41;
            this.comboBox_income_history.SelectedIndexChanged += new System.EventHandler(this.comboBox_income_history_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(127, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "UŻYTKOWNIK";
            // 
            // comboBox_user_history
            // 
            this.comboBox_user_history.DropDownHeight = 110;
            this.comboBox_user_history.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_user_history.FormattingEnabled = true;
            this.comboBox_user_history.IntegralHeight = false;
            this.comboBox_user_history.Location = new System.Drawing.Point(112, 373);
            this.comboBox_user_history.Name = "comboBox_user_history";
            this.comboBox_user_history.Size = new System.Drawing.Size(123, 25);
            this.comboBox_user_history.TabIndex = 39;
            // 
            // textBox_sum_history
            // 
            this.textBox_sum_history.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox_sum_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sum_history.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_sum_history.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sum_history.ForeColor = System.Drawing.Color.White;
            this.textBox_sum_history.Location = new System.Drawing.Point(122, 298);
            this.textBox_sum_history.Name = "textBox_sum_history";
            this.textBox_sum_history.ReadOnly = true;
            this.textBox_sum_history.Size = new System.Drawing.Size(548, 26);
            this.textBox_sum_history.TabIndex = 10;
            this.textBox_sum_history.Text = "Razem: ???";
            this.textBox_sum_history.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView_history
            // 
            this.dataGridView_history.AllowUserToAddRows = false;
            this.dataGridView_history.AllowUserToDeleteRows = false;
            this.dataGridView_history.AllowUserToOrderColumns = true;
            this.dataGridView_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_history.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rodzaj,
            this.Kwota,
            this.Data,
            this.Kategoria,
            this.Uzytkownik});
            this.dataGridView_history.Location = new System.Drawing.Point(122, 40);
            this.dataGridView_history.Name = "dataGridView_history";
            this.dataGridView_history.ReadOnly = true;
            this.dataGridView_history.Size = new System.Drawing.Size(548, 252);
            this.dataGridView_history.TabIndex = 0;
            this.dataGridView_history.SelectionChanged += new System.EventHandler(this.dataGridView_history_SelectionChanged);
            // 
            // Rodzaj
            // 
            this.Rodzaj.DataPropertyName = "Rodzaj";
            this.Rodzaj.HeaderText = "Rodzaj";
            this.Rodzaj.Name = "Rodzaj";
            this.Rodzaj.ReadOnly = true;
            // 
            // Kwota
            // 
            this.Kwota.DataPropertyName = "Kwota";
            this.Kwota.HeaderText = "Kwota [zł]";
            this.Kwota.Name = "Kwota";
            this.Kwota.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Kategoria
            // 
            this.Kategoria.DataPropertyName = "Kategoria";
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.ReadOnly = true;
            // 
            // Uzytkownik
            // 
            this.Uzytkownik.DataPropertyName = "Uzytkownik";
            this.Uzytkownik.HeaderText = "Użytkownik";
            this.Uzytkownik.Name = "Uzytkownik";
            this.Uzytkownik.ReadOnly = true;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPageAccount.BackgroundImage = global::BudzetManager.Properties.Resources.Best_Blur_Background_App_Compare_The_Top_6_Blur_Background_Apps;
            this.tabPageAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAccount.Controls.Add(this.panel3);
            this.tabPageAccount.Controls.Add(this.panel2);
            this.tabPageAccount.Controls.Add(this.textBox_repeatPass_konto);
            this.tabPageAccount.Controls.Add(this.label_repeatPass_konto);
            this.tabPageAccount.Controls.Add(this.button_delete_acc_konto);
            this.tabPageAccount.Controls.Add(this.button_changePass_konto);
            this.tabPageAccount.Controls.Add(this.textBox_ChangePass_konto);
            this.tabPageAccount.Controls.Add(this.label_changePass);
            this.tabPageAccount.Controls.Add(this.label_newPass_konto);
            this.tabPageAccount.Controls.Add(this.label_info_konto);
            this.tabPageAccount.Controls.Add(this.button_manage_konto);
            this.tabPageAccount.Controls.Add(this.pictureBox1);
            this.tabPageAccount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageAccount.Location = new System.Drawing.Point(4, 29);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(809, 495);
            this.tabPageAccount.TabIndex = 2;
            this.tabPageAccount.Text = "KONTO";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::BudzetManager.Properties.Resources.new_background_p;
            this.panel3.Controls.Add(this.label_login_konto);
            this.panel3.Location = new System.Drawing.Point(613, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 21);
            this.panel3.TabIndex = 29;
            // 
            // label_login_konto
            // 
            this.label_login_konto.AutoSize = true;
            this.label_login_konto.BackColor = System.Drawing.Color.Transparent;
            this.label_login_konto.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_konto.ForeColor = System.Drawing.Color.White;
            this.label_login_konto.Location = new System.Drawing.Point(71, 0);
            this.label_login_konto.Name = "label_login_konto";
            this.label_login_konto.Size = new System.Drawing.Size(53, 21);
            this.label_login_konto.TabIndex = 0;
            this.label_login_konto.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button_logout_konto);
            this.panel2.Controls.Add(this.textBox_login_konto);
            this.panel2.Controls.Add(this.textBox_admin_konto);
            this.panel2.Location = new System.Drawing.Point(613, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 499);
            this.panel2.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::BudzetManager.Properties.Resources.new_background_p;
            this.panel4.Controls.Add(this.labelAdmin);
            this.panel4.Location = new System.Drawing.Point(0, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 21);
            this.panel4.TabIndex = 30;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.White;
            this.labelAdmin.Location = new System.Drawing.Point(42, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(116, 21);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "Administrator";
            // 
            // button_logout_konto
            // 
            this.button_logout_konto.BackColor = System.Drawing.Color.Gold;
            this.button_logout_konto.BackgroundImage = global::BudzetManager.Properties.Resources.thisGray;
            this.button_logout_konto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_logout_konto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout_konto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_logout_konto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout_konto.ForeColor = System.Drawing.Color.White;
            this.button_logout_konto.Location = new System.Drawing.Point(34, 74);
            this.button_logout_konto.Name = "button_logout_konto";
            this.button_logout_konto.Size = new System.Drawing.Size(128, 41);
            this.button_logout_konto.TabIndex = 23;
            this.button_logout_konto.Text = "WYLOGUJ SIĘ";
            this.button_logout_konto.UseVisualStyleBackColor = false;
            this.button_logout_konto.Click += new System.EventHandler(this.button_logout_konto_Click);
            // 
            // textBox_login_konto
            // 
            this.textBox_login_konto.Enabled = false;
            this.textBox_login_konto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_login_konto.Location = new System.Drawing.Point(0, 197);
            this.textBox_login_konto.Name = "textBox_login_konto";
            this.textBox_login_konto.ReadOnly = true;
            this.textBox_login_konto.Size = new System.Drawing.Size(196, 22);
            this.textBox_login_konto.TabIndex = 2;
            this.textBox_login_konto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_admin_konto
            // 
            this.textBox_admin_konto.Enabled = false;
            this.textBox_admin_konto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_admin_konto.Location = new System.Drawing.Point(0, 287);
            this.textBox_admin_konto.Name = "textBox_admin_konto";
            this.textBox_admin_konto.ReadOnly = true;
            this.textBox_admin_konto.Size = new System.Drawing.Size(196, 22);
            this.textBox_admin_konto.TabIndex = 3;
            this.textBox_admin_konto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_repeatPass_konto
            // 
            this.textBox_repeatPass_konto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_repeatPass_konto.Location = new System.Drawing.Point(108, 280);
            this.textBox_repeatPass_konto.Name = "textBox_repeatPass_konto";
            this.textBox_repeatPass_konto.Size = new System.Drawing.Size(141, 22);
            this.textBox_repeatPass_konto.TabIndex = 25;
            this.textBox_repeatPass_konto.UseSystemPasswordChar = true;
            this.textBox_repeatPass_konto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_repeatPass_konto_PreviewKeyDown);
            // 
            // label_repeatPass_konto
            // 
            this.label_repeatPass_konto.AutoSize = true;
            this.label_repeatPass_konto.BackColor = System.Drawing.Color.Transparent;
            this.label_repeatPass_konto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_repeatPass_konto.ForeColor = System.Drawing.Color.White;
            this.label_repeatPass_konto.Location = new System.Drawing.Point(105, 251);
            this.label_repeatPass_konto.Name = "label_repeatPass_konto";
            this.label_repeatPass_konto.Size = new System.Drawing.Size(97, 16);
            this.label_repeatPass_konto.TabIndex = 24;
            this.label_repeatPass_konto.Text = "Powtórz hasło:";
            // 
            // button_delete_acc_konto
            // 
            this.button_delete_acc_konto.BackColor = System.Drawing.Color.Transparent;
            this.button_delete_acc_konto.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_delete_acc_konto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_delete_acc_konto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete_acc_konto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete_acc_konto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_acc_konto.Location = new System.Drawing.Point(338, 378);
            this.button_delete_acc_konto.Name = "button_delete_acc_konto";
            this.button_delete_acc_konto.Size = new System.Drawing.Size(141, 33);
            this.button_delete_acc_konto.TabIndex = 22;
            this.button_delete_acc_konto.Text = "USUŃ KONTO";
            this.button_delete_acc_konto.UseVisualStyleBackColor = false;
            this.button_delete_acc_konto.Click += new System.EventHandler(this.button_delete_acc_konto_Click);
            // 
            // button_changePass_konto
            // 
            this.button_changePass_konto.BackColor = System.Drawing.Color.Transparent;
            this.button_changePass_konto.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_changePass_konto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_changePass_konto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_changePass_konto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_changePass_konto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changePass_konto.Location = new System.Drawing.Point(108, 378);
            this.button_changePass_konto.Name = "button_changePass_konto";
            this.button_changePass_konto.Size = new System.Drawing.Size(141, 33);
            this.button_changePass_konto.TabIndex = 21;
            this.button_changePass_konto.Text = "POTWIERDŹ";
            this.button_changePass_konto.UseVisualStyleBackColor = false;
            this.button_changePass_konto.Click += new System.EventHandler(this.button_changePass_konto_Click);
            // 
            // textBox_ChangePass_konto
            // 
            this.textBox_ChangePass_konto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_ChangePass_konto.Location = new System.Drawing.Point(108, 208);
            this.textBox_ChangePass_konto.Name = "textBox_ChangePass_konto";
            this.textBox_ChangePass_konto.Size = new System.Drawing.Size(141, 22);
            this.textBox_ChangePass_konto.TabIndex = 20;
            this.textBox_ChangePass_konto.UseSystemPasswordChar = true;
            this.textBox_ChangePass_konto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_ChangePass_konto_PreviewKeyDown);
            // 
            // label_changePass
            // 
            this.label_changePass.AutoSize = true;
            this.label_changePass.BackColor = System.Drawing.Color.Transparent;
            this.label_changePass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_changePass.ForeColor = System.Drawing.Color.White;
            this.label_changePass.Location = new System.Drawing.Point(114, 125);
            this.label_changePass.Name = "label_changePass";
            this.label_changePass.Size = new System.Drawing.Size(126, 22);
            this.label_changePass.TabIndex = 19;
            this.label_changePass.Text = "ZMIEŃ HASŁO\r\n";
            // 
            // label_newPass_konto
            // 
            this.label_newPass_konto.AutoSize = true;
            this.label_newPass_konto.BackColor = System.Drawing.Color.Transparent;
            this.label_newPass_konto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_newPass_konto.ForeColor = System.Drawing.Color.White;
            this.label_newPass_konto.Location = new System.Drawing.Point(105, 178);
            this.label_newPass_konto.Name = "label_newPass_konto";
            this.label_newPass_konto.Size = new System.Drawing.Size(85, 16);
            this.label_newPass_konto.TabIndex = 16;
            this.label_newPass_konto.Text = "Nowe hasło:";
            // 
            // label_info_konto
            // 
            this.label_info_konto.AutoSize = true;
            this.label_info_konto.BackColor = System.Drawing.Color.Transparent;
            this.label_info_konto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_konto.Location = new System.Drawing.Point(339, 296);
            this.label_info_konto.Name = "label_info_konto";
            this.label_info_konto.Size = new System.Drawing.Size(144, 32);
            this.label_info_konto.TabIndex = 14;
            this.label_info_konto.Text = "* opcja dostępna tylko \r\n    dla administratora\r\n";
            // 
            // button_manage_konto
            // 
            this.button_manage_konto.BackColor = System.Drawing.Color.Transparent;
            this.button_manage_konto.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_manage_konto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_manage_konto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_manage_konto.Enabled = false;
            this.button_manage_konto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_manage_konto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manage_konto.Location = new System.Drawing.Point(338, 253);
            this.button_manage_konto.Name = "button_manage_konto";
            this.button_manage_konto.Size = new System.Drawing.Size(141, 40);
            this.button_manage_konto.TabIndex = 4;
            this.button_manage_konto.Text = "ZARZĄDZAJ UŻYTKOWNIKAMI\r\n\r\n\r\n";
            this.button_manage_konto.UseVisualStyleBackColor = false;
            this.button_manage_konto.Click += new System.EventHandler(this.button_manage_konto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BudzetManager.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(338, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 525);
            this.Controls.Add(this.TabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            this.TabMain.ResumeLayout(false);
            this.tabPageMainPage.ResumeLayout(false);
            this.tabPageMainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageHistory.ResumeLayout(false);
            this.tabPageHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).EndInit();
            this.tabPageAccount.ResumeLayout(false);
            this.tabPageAccount.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage tabPageMainPage;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.Button button_manage_konto;
        private System.Windows.Forms.TextBox textBox_admin_konto;
        private System.Windows.Forms.TextBox textBox_login_konto;
        private System.Windows.Forms.Label label_changePass;
        private System.Windows.Forms.Label label_newPass_konto;
        private System.Windows.Forms.Label label_info_konto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_logout_konto;
        private System.Windows.Forms.Button button_delete_acc_konto;
        private System.Windows.Forms.Button button_changePass_konto;
        private System.Windows.Forms.TextBox textBox_ChangePass_konto;
        private System.Windows.Forms.TextBox textBox_repeatPass_konto;
        private System.Windows.Forms.Label label_repeatPass_konto;
        private System.Windows.Forms.Label labelUserName_mainTab;
        private System.Windows.Forms.TextBox textBox_setBudget_mainTab;
        private System.Windows.Forms.Label label_actState_mainTab;
        private System.Windows.Forms.Button buttonHelp_mainTab;
        private System.Windows.Forms.Button button_cat_limits_mainTab;
        private System.Windows.Forms.Button button_manage_reg_mainTab;
        private System.Windows.Forms.Button buttonAdd_inc_out_mainTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_login_konto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button button_checkLimits;
        private System.Windows.Forms.DataGridView dataGridView_history;
        private System.Windows.Forms.TextBox textBox_sum_history;
        private System.Windows.Forms.ComboBox comboBox_user_history;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_month_history;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_category_history;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_income_history;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_year_history;
        private System.Windows.Forms.Button buttonfiltr_history;
        private System.Windows.Forms.Button buttonRenew_history;
        private System.Windows.Forms.Button button_zestawieniaFinansowe;
        private System.Windows.Forms.Button button_prognozaFinansowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kwota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uzytkownik;
    }
}