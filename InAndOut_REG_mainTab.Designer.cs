namespace BudzetManager
{
    partial class InAndOut_REG_mainTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InAndOut_REG_mainTab));
            this.label_title = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.comboBoxIn_or_out = new System.Windows.Forms.ComboBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.dateTimePickerFromWhen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToWhen = new System.Windows.Forms.DateTimePicker();
            this.textBoxHowOften = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonfiltr = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxIn_orOut_filtr = new System.Windows.Forms.ComboBox();
            this.comboBox_User_filtr = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_category_filtr = new System.Windows.Forms.ComboBox();
            this.checkBoxMonths = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRenew = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.Rodzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kwota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Od_kiedy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Do_kiedy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_ile_tygodni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_ile_miesiecy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uzytwkonik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Black;
            this.label_title.Location = new System.Drawing.Point(151, 30);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(386, 35);
            this.label_title.TabIndex = 20;
            this.label_title.Text = "Przychody i opłaty regularne";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rodzaj,
            this.Kwota,
            this.Od_kiedy,
            this.Do_kiedy,
            this.co_ile_tygodni,
            this.co_ile_miesiecy,
            this.Kategoria,
            this.Uzytwkonik});
            this.dataGridView.Location = new System.Drawing.Point(25, 85);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(638, 191);
            this.dataGridView.TabIndex = 21;
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownHeight = 110;
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.IntegralHeight = false;
            this.comboBox_category.Location = new System.Drawing.Point(353, 378);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(123, 21);
            this.comboBox_category.Sorted = true;
            this.comboBox_category.TabIndex = 22;
            // 
            // comboBoxIn_or_out
            // 
            this.comboBoxIn_or_out.DropDownHeight = 110;
            this.comboBoxIn_or_out.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIn_or_out.FormattingEnabled = true;
            this.comboBoxIn_or_out.IntegralHeight = false;
            this.comboBoxIn_or_out.Location = new System.Drawing.Point(34, 313);
            this.comboBoxIn_or_out.Name = "comboBoxIn_or_out";
            this.comboBoxIn_or_out.Size = new System.Drawing.Size(119, 21);
            this.comboBoxIn_or_out.Sorted = true;
            this.comboBoxIn_or_out.TabIndex = 23;
            this.comboBoxIn_or_out.SelectedIndexChanged += new System.EventHandler(this.comboBoxIn_or_out_SelectedIndexChanged);
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(34, 379);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(119, 20);
            this.textBoxMoney.TabIndex = 24;
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerFromWhen
            // 
            this.dateTimePickerFromWhen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromWhen.Location = new System.Drawing.Point(195, 313);
            this.dateTimePickerFromWhen.Name = "dateTimePickerFromWhen";
            this.dateTimePickerFromWhen.Size = new System.Drawing.Size(123, 20);
            this.dateTimePickerFromWhen.TabIndex = 25;
            // 
            // dateTimePickerToWhen
            // 
            this.dateTimePickerToWhen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToWhen.Location = new System.Drawing.Point(195, 379);
            this.dateTimePickerToWhen.Name = "dateTimePickerToWhen";
            this.dateTimePickerToWhen.Size = new System.Drawing.Size(123, 20);
            this.dateTimePickerToWhen.TabIndex = 26;
            // 
            // textBoxHowOften
            // 
            this.textBoxHowOften.Location = new System.Drawing.Point(353, 313);
            this.textBoxHowOften.Name = "textBoxHowOften";
            this.textBoxHowOften.Size = new System.Drawing.Size(123, 20);
            this.textBoxHowOften.TabIndex = 27;
            this.textBoxHowOften.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "RODZAJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(42, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "KWOTA [zł]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(362, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "KATEGORIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(337, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "CO ILE TYGODNI/ MIESIĘCY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(207, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "OD KIEDY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(207, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "DO KIEDY";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(513, 368);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 38);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "USUŃ";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonfiltr
            // 
            this.buttonfiltr.BackColor = System.Drawing.Color.Transparent;
            this.buttonfiltr.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.buttonfiltr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonfiltr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonfiltr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonfiltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonfiltr.Location = new System.Drawing.Point(515, 12);
            this.buttonfiltr.Name = "buttonfiltr";
            this.buttonfiltr.Size = new System.Drawing.Size(91, 40);
            this.buttonfiltr.TabIndex = 35;
            this.buttonfiltr.Text = "FILTRUJ";
            this.buttonfiltr.UseVisualStyleBackColor = false;
            this.buttonfiltr.Click += new System.EventHandler(this.buttonfiltr_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "RODZAJ";
            // 
            // comboBoxIn_orOut_filtr
            // 
            this.comboBoxIn_orOut_filtr.DropDownHeight = 110;
            this.comboBoxIn_orOut_filtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIn_orOut_filtr.FormattingEnabled = true;
            this.comboBoxIn_orOut_filtr.IntegralHeight = false;
            this.comboBoxIn_orOut_filtr.Location = new System.Drawing.Point(36, 31);
            this.comboBoxIn_orOut_filtr.Name = "comboBoxIn_orOut_filtr";
            this.comboBoxIn_orOut_filtr.Size = new System.Drawing.Size(119, 21);
            this.comboBoxIn_orOut_filtr.Sorted = true;
            this.comboBoxIn_orOut_filtr.TabIndex = 37;
            this.comboBoxIn_orOut_filtr.SelectedIndexChanged += new System.EventHandler(this.comboBoxIn_orOut_filtr_SelectedIndexChanged);
            // 
            // comboBox_User_filtr
            // 
            this.comboBox_User_filtr.DropDownHeight = 110;
            this.comboBox_User_filtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_User_filtr.FormattingEnabled = true;
            this.comboBox_User_filtr.IntegralHeight = false;
            this.comboBox_User_filtr.Location = new System.Drawing.Point(197, 31);
            this.comboBox_User_filtr.Name = "comboBox_User_filtr";
            this.comboBox_User_filtr.Size = new System.Drawing.Size(123, 21);
            this.comboBox_User_filtr.Sorted = true;
            this.comboBox_User_filtr.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(209, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "UŻYTKOWNIK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(364, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "KATEGORIA";
            // 
            // comboBox_category_filtr
            // 
            this.comboBox_category_filtr.DropDownHeight = 110;
            this.comboBox_category_filtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category_filtr.FormattingEnabled = true;
            this.comboBox_category_filtr.IntegralHeight = false;
            this.comboBox_category_filtr.Location = new System.Drawing.Point(355, 31);
            this.comboBox_category_filtr.Name = "comboBox_category_filtr";
            this.comboBox_category_filtr.Size = new System.Drawing.Size(123, 21);
            this.comboBox_category_filtr.Sorted = true;
            this.comboBox_category_filtr.TabIndex = 40;
            // 
            // checkBoxMonths
            // 
            this.checkBoxMonths.AutoSize = true;
            this.checkBoxMonths.Location = new System.Drawing.Point(354, 334);
            this.checkBoxMonths.Name = "checkBoxMonths";
            this.checkBoxMonths.Size = new System.Drawing.Size(67, 17);
            this.checkBoxMonths.TabIndex = 42;
            this.checkBoxMonths.Text = "miesiące";
            this.checkBoxMonths.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::BudzetManager.Properties.Resources.purple;
            this.panel1.Controls.Add(this.comboBoxIn_orOut_filtr);
            this.panel1.Controls.Add(this.buttonfiltr);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox_category_filtr);
            this.panel1.Controls.Add(this.comboBox_User_filtr);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonRenew);
            this.panel1.Location = new System.Drawing.Point(-2, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 94);
            this.panel1.TabIndex = 43;
            // 
            // buttonRenew
            // 
            this.buttonRenew.BackColor = System.Drawing.Color.Transparent;
            this.buttonRenew.BackgroundImage = global::BudzetManager.Properties.Resources.reloadButton;
            this.buttonRenew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRenew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRenew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRenew.Location = new System.Drawing.Point(612, 12);
            this.buttonRenew.Name = "buttonRenew";
            this.buttonRenew.Size = new System.Drawing.Size(44, 40);
            this.buttonRenew.TabIndex = 42;
            this.buttonRenew.UseVisualStyleBackColor = false;
            this.buttonRenew.Click += new System.EventHandler(this.buttonRenew_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.Location = new System.Drawing.Point(513, 306);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(141, 38);
            this.button_add.TabIndex = 44;
            this.button_add.Text = "DODAJ";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
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
            // Od_kiedy
            // 
            this.Od_kiedy.DataPropertyName = "Od kiedy";
            this.Od_kiedy.HeaderText = "Od kiedy";
            this.Od_kiedy.Name = "Od_kiedy";
            this.Od_kiedy.ReadOnly = true;
            // 
            // Do_kiedy
            // 
            this.Do_kiedy.DataPropertyName = "Do kiedy";
            this.Do_kiedy.HeaderText = "Do kiedy";
            this.Do_kiedy.Name = "Do_kiedy";
            this.Do_kiedy.ReadOnly = true;
            // 
            // co_ile_tygodni
            // 
            this.co_ile_tygodni.DataPropertyName = "Co ile tygodni";
            this.co_ile_tygodni.HeaderText = "Co ile tygodni";
            this.co_ile_tygodni.Name = "co_ile_tygodni";
            this.co_ile_tygodni.ReadOnly = true;
            // 
            // co_ile_miesiecy
            // 
            this.co_ile_miesiecy.DataPropertyName = "Co ile miesięcy";
            this.co_ile_miesiecy.HeaderText = "Co ile miesięcy";
            this.co_ile_miesiecy.Name = "co_ile_miesiecy";
            this.co_ile_miesiecy.ReadOnly = true;
            // 
            // Kategoria
            // 
            this.Kategoria.DataPropertyName = "Kategoria";
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.ReadOnly = true;
            // 
            // Uzytwkonik
            // 
            this.Uzytwkonik.DataPropertyName = "Użytkownik";
            this.Uzytwkonik.HeaderText = "Użytkownik";
            this.Uzytwkonik.Name = "Uzytwkonik";
            this.Uzytwkonik.ReadOnly = true;
            // 
            // InAndOut_REG_mainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BudzetManager.Properties.Resources.blue_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 499);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.checkBoxMonths);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHowOften);
            this.Controls.Add(this.dateTimePickerToWhen);
            this.Controls.Add(this.dateTimePickerFromWhen);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.comboBoxIn_or_out);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InAndOut_REG_mainTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ComboBox comboBoxIn_or_out;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromWhen;
        private System.Windows.Forms.DateTimePicker dateTimePickerToWhen;
        private System.Windows.Forms.TextBox textBoxHowOften;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonfiltr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxIn_orOut_filtr;
        private System.Windows.Forms.ComboBox comboBox_User_filtr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_category_filtr;
        private System.Windows.Forms.CheckBox checkBoxMonths;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button buttonRenew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kwota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Od_kiedy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Do_kiedy;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_ile_tygodni;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_ile_miesiecy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uzytwkonik;
    }
}