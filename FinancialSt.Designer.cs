namespace BudzetManager
{
    partial class FinancialSt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialSt));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DataUtworzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumaWydatkow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumaPrzychodow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miesiac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_title = new System.Windows.Forms.Label();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonfiltr = new System.Windows.Forms.Button();
            this.buttonRenew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataUtworzenia,
            this.SumaWydatkow,
            this.SumaPrzychodow,
            this.Miesiac,
            this.Rok});
            this.dataGridView.Location = new System.Drawing.Point(55, 76);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(457, 209);
            this.dataGridView.TabIndex = 0;
            // 
            // DataUtworzenia
            // 
            this.DataUtworzenia.DataPropertyName = "DataUtworzenia";
            this.DataUtworzenia.HeaderText = "Data utworzenia";
            this.DataUtworzenia.Name = "DataUtworzenia";
            this.DataUtworzenia.ReadOnly = true;
            // 
            // SumaWydatkow
            // 
            this.SumaWydatkow.DataPropertyName = "SumaWydatkow";
            this.SumaWydatkow.HeaderText = "Suma wydatków";
            this.SumaWydatkow.Name = "SumaWydatkow";
            this.SumaWydatkow.ReadOnly = true;
            // 
            // SumaPrzychodow
            // 
            this.SumaPrzychodow.DataPropertyName = "SumaPrzychodow";
            this.SumaPrzychodow.HeaderText = "Suma przychodów";
            this.SumaPrzychodow.Name = "SumaPrzychodow";
            this.SumaPrzychodow.ReadOnly = true;
            // 
            // Miesiac
            // 
            this.Miesiac.DataPropertyName = "Miesiac";
            this.Miesiac.HeaderText = "Miesiąc";
            this.Miesiac.Name = "Miesiac";
            this.Miesiac.ReadOnly = true;
            // 
            // Rok
            // 
            this.Rok.DataPropertyName = "Rok";
            this.Rok.HeaderText = "Rok";
            this.Rok.Name = "Rok";
            this.Rok.ReadOnly = true;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Black;
            this.label_title.Location = new System.Drawing.Point(149, 32);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(254, 23);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "ZESTAWIENIA FINANSOWE";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_month
            // 
            this.comboBox_month.DropDownHeight = 110;
            this.comboBox_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.IntegralHeight = false;
            this.comboBox_month.Location = new System.Drawing.Point(70, 322);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(119, 21);
            this.comboBox_month.TabIndex = 24;
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(70, 373);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(119, 20);
            this.textBox_year.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ROK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "MIESIĄC";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.Location = new System.Drawing.Point(242, 312);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(109, 38);
            this.button_add.TabIndex = 46;
            this.button_add.Text = "DODAJ";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(242, 355);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 38);
            this.buttonDelete.TabIndex = 45;
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
            this.buttonfiltr.Location = new System.Drawing.Point(379, 334);
            this.buttonfiltr.Name = "buttonfiltr";
            this.buttonfiltr.Size = new System.Drawing.Size(71, 40);
            this.buttonfiltr.TabIndex = 47;
            this.buttonfiltr.Text = "FILTRUJ";
            this.buttonfiltr.UseVisualStyleBackColor = false;
            this.buttonfiltr.Click += new System.EventHandler(this.buttonfiltr_Click);
            // 
            // buttonRenew
            // 
            this.buttonRenew.BackColor = System.Drawing.Color.Transparent;
            this.buttonRenew.BackgroundImage = global::BudzetManager.Properties.Resources.reloadButton;
            this.buttonRenew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRenew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRenew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRenew.Location = new System.Drawing.Point(456, 334);
            this.buttonRenew.Name = "buttonRenew";
            this.buttonRenew.Size = new System.Drawing.Size(44, 40);
            this.buttonRenew.TabIndex = 48;
            this.buttonRenew.UseVisualStyleBackColor = false;
            this.buttonRenew.Click += new System.EventHandler(this.buttonRenew_Click);
            // 
            // FinancialSt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BudzetManager.Properties.Resources.blue_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 424);
            this.Controls.Add(this.buttonfiltr);
            this.Controls.Add(this.buttonRenew);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FinancialSt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonfiltr;
        private System.Windows.Forms.Button buttonRenew;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataUtworzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumaWydatkow;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumaPrzychodow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miesiac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rok;
    }
}