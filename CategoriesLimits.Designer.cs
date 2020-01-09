namespace BudzetManager
{
    partial class CategoriesLimits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesLimits));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limit_miesieczny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rodzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_title = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nazwa = new System.Windows.Forms.TextBox();
            this.textBox_limit = new System.Windows.Forms.TextBox();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            this.comboBox_inOr_out = new System.Windows.Forms.ComboBox();
            this.comboBox_filtr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kategoria,
            this.Limit_miesieczny,
            this.Opis,
            this.Rodzaj});
            this.dataGridView1.Location = new System.Drawing.Point(20, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(508, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // Kategoria
            // 
            this.Kategoria.DataPropertyName = "Kategoria";
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.ReadOnly = true;
            // 
            // Limit_miesieczny
            // 
            this.Limit_miesieczny.DataPropertyName = "Limit miesięczny";
            this.Limit_miesieczny.HeaderText = "Limit misięczny [zł]";
            this.Limit_miesieczny.Name = "Limit_miesieczny";
            this.Limit_miesieczny.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Rodzaj
            // 
            this.Rodzaj.DataPropertyName = "Rodzaj";
            this.Rodzaj.HeaderText = "Rodzaj";
            this.Rodzaj.Name = "Rodzaj";
            this.Rodzaj.ReadOnly = true;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Black;
            this.label_title.Location = new System.Drawing.Point(179, 30);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(191, 23);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "KATEGORIE I LIMITY";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.Location = new System.Drawing.Point(56, 256);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(123, 35);
            this.button_add.TabIndex = 45;
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
            this.buttonDelete.Location = new System.Drawing.Point(366, 256);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(123, 35);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "USUŃ";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(213, 256);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(123, 35);
            this.buttonEdit.TabIndex = 47;
            this.buttonEdit.Text = "EDYTUJ";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "RODZAJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(242, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "NAZWA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(393, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "LIMIT [zł]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "OPIS";
            // 
            // textBox_nazwa
            // 
            this.textBox_nazwa.Location = new System.Drawing.Point(224, 336);
            this.textBox_nazwa.Name = "textBox_nazwa";
            this.textBox_nazwa.Size = new System.Drawing.Size(100, 20);
            this.textBox_nazwa.TabIndex = 53;
            this.textBox_nazwa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_limit
            // 
            this.textBox_limit.Location = new System.Drawing.Point(375, 336);
            this.textBox_limit.Name = "textBox_limit";
            this.textBox_limit.Size = new System.Drawing.Size(100, 20);
            this.textBox_limit.TabIndex = 54;
            this.textBox_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxOpis.Location = new System.Drawing.Point(56, 331);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(123, 75);
            this.richTextBoxOpis.TabIndex = 56;
            this.richTextBoxOpis.Text = "";
            // 
            // comboBox_inOr_out
            // 
            this.comboBox_inOr_out.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inOr_out.FormattingEnabled = true;
            this.comboBox_inOr_out.Location = new System.Drawing.Point(375, 386);
            this.comboBox_inOr_out.Name = "comboBox_inOr_out";
            this.comboBox_inOr_out.Size = new System.Drawing.Size(100, 21);
            this.comboBox_inOr_out.TabIndex = 57;
            // 
            // comboBox_filtr
            // 
            this.comboBox_filtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filtr.ForeColor = System.Drawing.Color.Black;
            this.comboBox_filtr.FormattingEnabled = true;
            this.comboBox_filtr.Location = new System.Drawing.Point(223, 386);
            this.comboBox_filtr.Name = "comboBox_filtr";
            this.comboBox_filtr.Size = new System.Drawing.Size(100, 21);
            this.comboBox_filtr.TabIndex = 59;
            this.comboBox_filtr.SelectedIndexChanged += new System.EventHandler(this.comboBox_filtr_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(247, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "filtruj";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoriesLimits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BudzetManager.Properties.Resources.blue_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 434);
            this.Controls.Add(this.comboBox_filtr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_inOr_out);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.textBox_limit);
            this.Controls.Add(this.textBox_nazwa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CategoriesLimits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nazwa;
        private System.Windows.Forms.TextBox textBox_limit;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
        private System.Windows.Forms.ComboBox comboBox_inOr_out;
        private System.Windows.Forms.ComboBox comboBox_filtr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limit_miesieczny;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodzaj;
    }
}