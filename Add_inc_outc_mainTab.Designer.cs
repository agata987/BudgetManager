namespace BudzetManager
{
    partial class Add_inc_outc_mainTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_inc_outc_mainTab));
            this.label_title = new System.Windows.Forms.Label();
            this.label_kategoria = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.label_kwota = new System.Windows.Forms.Label();
            this.label_rodzaj = new System.Windows.Forms.Label();
            this.button_submit_add = new System.Windows.Forms.Button();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox_inOr_out = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Black;
            this.label_title.Location = new System.Drawing.Point(90, 53);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(235, 46);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "DODAWANIE\r\nPRZYCHODU/ WYDATKU";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_kategoria
            // 
            this.label_kategoria.AutoSize = true;
            this.label_kategoria.BackColor = System.Drawing.Color.Transparent;
            this.label_kategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_kategoria.ForeColor = System.Drawing.Color.White;
            this.label_kategoria.Location = new System.Drawing.Point(43, 178);
            this.label_kategoria.Name = "label_kategoria";
            this.label_kategoria.Size = new System.Drawing.Size(78, 13);
            this.label_kategoria.TabIndex = 14;
            this.label_kategoria.Text = "KATEGORIA";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.BackColor = System.Drawing.Color.Transparent;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_data.ForeColor = System.Drawing.Color.White;
            this.label_data.Location = new System.Drawing.Point(81, 221);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(40, 13);
            this.label_data.TabIndex = 15;
            this.label_data.Text = "DATA";
            // 
            // label_kwota
            // 
            this.label_kwota.AutoSize = true;
            this.label_kwota.BackColor = System.Drawing.Color.Transparent;
            this.label_kwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_kwota.ForeColor = System.Drawing.Color.White;
            this.label_kwota.Location = new System.Drawing.Point(41, 144);
            this.label_kwota.Name = "label_kwota";
            this.label_kwota.Size = new System.Drawing.Size(80, 13);
            this.label_kwota.TabIndex = 16;
            this.label_kwota.Text = "KWOTA [ZŁ]";
            // 
            // label_rodzaj
            // 
            this.label_rodzaj.AutoSize = true;
            this.label_rodzaj.BackColor = System.Drawing.Color.Transparent;
            this.label_rodzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rodzaj.ForeColor = System.Drawing.Color.White;
            this.label_rodzaj.Location = new System.Drawing.Point(65, 255);
            this.label_rodzaj.Name = "label_rodzaj";
            this.label_rodzaj.Size = new System.Drawing.Size(56, 13);
            this.label_rodzaj.TabIndex = 17;
            this.label_rodzaj.Text = "RODZAJ";
            // 
            // button_submit_add
            // 
            this.button_submit_add.BackColor = System.Drawing.Color.Transparent;
            this.button_submit_add.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_submit_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_submit_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submit_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_submit_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_submit_add.Location = new System.Drawing.Point(142, 302);
            this.button_submit_add.Name = "button_submit_add";
            this.button_submit_add.Size = new System.Drawing.Size(141, 38);
            this.button_submit_add.TabIndex = 18;
            this.button_submit_add.Text = "POTWIERDŹ";
            this.button_submit_add.UseVisualStyleBackColor = false;
            this.button_submit_add.Click += new System.EventHandler(this.button_submit_add_Click);
            // 
            // textBox_money
            // 
            this.textBox_money.Location = new System.Drawing.Point(142, 141);
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.Size = new System.Drawing.Size(200, 20);
            this.textBox_money.TabIndex = 19;
            this.textBox_money.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_money_PreviewKeyDown);
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownHeight = 110;
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.IntegralHeight = false;
            this.comboBox_category.Location = new System.Drawing.Point(142, 175);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(200, 21);
            this.comboBox_category.Sorted = true;
            this.comboBox_category.TabIndex = 20;
            this.comboBox_category.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.comboBox_category_PreviewKeyDown);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(142, 215);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 21;
            this.dateTimePicker.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dateTimePicker_PreviewKeyDown);
            // 
            // comboBox_inOr_out
            // 
            this.comboBox_inOr_out.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inOr_out.FormattingEnabled = true;
            this.comboBox_inOr_out.Location = new System.Drawing.Point(142, 252);
            this.comboBox_inOr_out.Name = "comboBox_inOr_out";
            this.comboBox_inOr_out.Size = new System.Drawing.Size(200, 21);
            this.comboBox_inOr_out.TabIndex = 22;
            this.comboBox_inOr_out.SelectedIndexChanged += new System.EventHandler(this.comboBox_inOr_out_SelectedIndexChanged);
            this.comboBox_inOr_out.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.comboBox_inOr_out_PreviewKeyDown);
            // 
            // Add_inc_outc_mainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BudzetManager.Properties.Resources.blue_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 381);
            this.Controls.Add(this.comboBox_inOr_out);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.textBox_money);
            this.Controls.Add(this.button_submit_add);
            this.Controls.Add(this.label_rodzaj);
            this.Controls.Add(this.label_kwota);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_kategoria);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_inc_outc_mainTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_kategoria;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_kwota;
        private System.Windows.Forms.Label label_rodzaj;
        private System.Windows.Forms.Button button_submit_add;
        private System.Windows.Forms.TextBox textBox_money;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBox_inOr_out;
    }
}