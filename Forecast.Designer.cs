namespace BudzetManager
{
    partial class Forecast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forecast));
            this.label_info = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_months = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_forecast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.Transparent;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(54, 238);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(398, 48);
            this.label_info.TabIndex = 15;
            this.label_info.Text = "* Prognozy finansowe pokazują ile pieniędzy zostanie w budżecie \r\npo wybranej lic" +
    "zbie miesięcy do przodu na podstawie \r\nwydatków z ostatnich 3 miesięcy. ";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Black;
            this.label_title.Location = new System.Drawing.Point(150, 47);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(220, 26);
            this.label_title.TabIndex = 21;
            this.label_title.Text = "Prognoza finansowa";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "ZA";
            // 
            // textBox_months
            // 
            this.textBox_months.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_months.Location = new System.Drawing.Point(105, 114);
            this.textBox_months.Name = "textBox_months";
            this.textBox_months.Size = new System.Drawing.Size(30, 29);
            this.textBox_months.TabIndex = 53;
            this.textBox_months.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_months.TextChanged += new System.EventHandler(this.textBox_months_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 26);
            this.label1.TabIndex = 54;
            this.label1.Text = "MIESIĘCY W BUDŻECIE BĘDZIE";
            // 
            // textBox_forecast
            // 
            this.textBox_forecast.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox_forecast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_forecast.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_forecast.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_forecast.ForeColor = System.Drawing.Color.White;
            this.textBox_forecast.Location = new System.Drawing.Point(-5, 160);
            this.textBox_forecast.Name = "textBox_forecast";
            this.textBox_forecast.ReadOnly = true;
            this.textBox_forecast.Size = new System.Drawing.Size(523, 26);
            this.textBox_forecast.TabIndex = 55;
            this.textBox_forecast.Text = "???";
            this.textBox_forecast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Forecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BudzetManager.Properties.Resources.blue_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 317);
            this.Controls.Add(this.textBox_forecast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_months);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Forecast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_months;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_forecast;
    }
}