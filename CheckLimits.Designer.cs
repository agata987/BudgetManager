namespace BudzetManager
{
    partial class BudzetManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudzetManager));
            this.label_title = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.checkBox_przekroczone_filtr = new System.Windows.Forms.CheckBox();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limit_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wydane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Przekroczone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Black;
            this.label_title.Location = new System.Drawing.Point(90, 36);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(310, 23);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "KATEGORIE WYDATKÓW I LIMITY";
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
            this.Nazwa,
            this.Limit_,
            this.Wydane,
            this.Przekroczone});
            this.dataGridView.Location = new System.Drawing.Point(12, 81);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(489, 231);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            // 
            // checkBox_przekroczone_filtr
            // 
            this.checkBox_przekroczone_filtr.AutoSize = true;
            this.checkBox_przekroczone_filtr.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.checkBox_przekroczone_filtr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox_przekroczone_filtr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_przekroczone_filtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_przekroczone_filtr.Location = new System.Drawing.Point(193, 336);
            this.checkBox_przekroczone_filtr.Name = "checkBox_przekroczone_filtr";
            this.checkBox_przekroczone_filtr.Size = new System.Drawing.Size(119, 22);
            this.checkBox_przekroczone_filtr.TabIndex = 4;
            this.checkBox_przekroczone_filtr.Text = "Przekroczone";
            this.checkBox_przekroczone_filtr.UseVisualStyleBackColor = true;
            this.checkBox_przekroczone_filtr.CheckedChanged += new System.EventHandler(this.checkBox_przekroczone_filtr_CheckedChanged);
            // 
            // Nazwa
            // 
            this.Nazwa.DataPropertyName = "Nazwa kategorii";
            this.Nazwa.HeaderText = "Nazwa kategorii";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // Limit_
            // 
            this.Limit_.DataPropertyName = "Limit";
            this.Limit_.HeaderText = "Limit [zł]";
            this.Limit_.Name = "Limit_";
            this.Limit_.ReadOnly = true;
            // 
            // Wydane
            // 
            this.Wydane.DataPropertyName = "Wydane pieniądze";
            this.Wydane.HeaderText = "Wydane pieniądze [zł]";
            this.Wydane.Name = "Wydane";
            this.Wydane.ReadOnly = true;
            // 
            // Przekroczone
            // 
            this.Przekroczone.DataPropertyName = "Limit przekroczony o...";
            this.Przekroczone.HeaderText = "Limit przekroczony o... [zł]";
            this.Przekroczone.Name = "Przekroczone";
            this.Przekroczone.ReadOnly = true;
            // 
            // BudzetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BudzetManager.Properties.Resources.blue_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 382);
            this.Controls.Add(this.checkBox_przekroczone_filtr);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BudzetManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox checkBox_przekroczone_filtr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limit_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wydane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przekroczone;
    }
}