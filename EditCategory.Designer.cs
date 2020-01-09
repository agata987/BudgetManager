namespace BudzetManager
{
    partial class EditCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategory));
            this.label_category_name = new System.Windows.Forms.Label();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLimit = new System.Windows.Forms.TextBox();
            this.button_submit_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_category_name
            // 
            this.label_category_name.AutoSize = true;
            this.label_category_name.BackColor = System.Drawing.Color.Transparent;
            this.label_category_name.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_category_name.ForeColor = System.Drawing.Color.Black;
            this.label_category_name.Location = new System.Drawing.Point(27, 25);
            this.label_category_name.Name = "label_category_name";
            this.label_category_name.Size = new System.Drawing.Size(205, 38);
            this.label_category_name.TabIndex = 4;
            this.label_category_name.Text = "EDYTOWANIE KATEGORII \r\n<NAZWA>";
            this.label_category_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxOpis.Location = new System.Drawing.Point(67, 104);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(123, 75);
            this.richTextBoxOpis.TabIndex = 59;
            this.richTextBoxOpis.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "OPIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "LIMIT [zł]";
            // 
            // textBoxLimit
            // 
            this.textBoxLimit.Location = new System.Drawing.Point(67, 215);
            this.textBoxLimit.Name = "textBoxLimit";
            this.textBoxLimit.Size = new System.Drawing.Size(123, 20);
            this.textBoxLimit.TabIndex = 59;
            this.textBoxLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLimit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxLimit_PreviewKeyDown);
            // 
            // button_submit_confirm
            // 
            this.button_submit_confirm.BackColor = System.Drawing.Color.Transparent;
            this.button_submit_confirm.BackgroundImage = global::BudzetManager.Properties.Resources.this_button;
            this.button_submit_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_submit_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submit_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_submit_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_submit_confirm.Location = new System.Drawing.Point(67, 257);
            this.button_submit_confirm.Name = "button_submit_confirm";
            this.button_submit_confirm.Size = new System.Drawing.Size(123, 28);
            this.button_submit_confirm.TabIndex = 60;
            this.button_submit_confirm.Text = "POTWIERDŹ";
            this.button_submit_confirm.UseVisualStyleBackColor = false;
            this.button_submit_confirm.Click += new System.EventHandler(this.button_submit_confirm_Click);
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BudzetManager.Properties.Resources.blue_blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(260, 307);
            this.Controls.Add(this.button_submit_confirm);
            this.Controls.Add(this.textBoxLimit);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_category_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudzetManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_category_name;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLimit;
        private System.Windows.Forms.Button button_submit_confirm;
    }
}