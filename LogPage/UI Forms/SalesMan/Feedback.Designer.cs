namespace App
{
    partial class Feedback
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
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.mobileLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pNameLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pIdLbl = new System.Windows.Forms.Label();
            this.feedbackLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(66, 324);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(92, 29);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.feedbackLbl);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.pIdLbl);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pNameLbl);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.mobileTxt);
            this.panel1.Controls.Add(this.mobileLbl);
            this.panel1.Location = new System.Drawing.Point(66, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 238);
            this.panel1.TabIndex = 14;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(311, 184);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(59, 27);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add Coustomer";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // mobileTxt
            // 
            this.mobileTxt.Location = new System.Drawing.Point(189, 55);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(182, 20);
            this.mobileTxt.TabIndex = 3;
            // 
            // mobileLbl
            // 
            this.mobileLbl.AutoSize = true;
            this.mobileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mobileLbl.Location = new System.Drawing.Point(29, 55);
            this.mobileLbl.Name = "mobileLbl";
            this.mobileLbl.Size = new System.Drawing.Size(66, 20);
            this.mobileLbl.TabIndex = 9;
            this.mobileLbl.Text = "Mobile:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(377, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(249, 103);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 13;
            // 
            // pNameLbl
            // 
            this.pNameLbl.AutoSize = true;
            this.pNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pNameLbl.Location = new System.Drawing.Point(29, 97);
            this.pNameLbl.Name = "pNameLbl";
            this.pNameLbl.Size = new System.Drawing.Size(154, 20);
            this.pNameLbl.TabIndex = 14;
            this.pNameLbl.Text = "PRODUCT NAME:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 15;
            // 
            // pIdLbl
            // 
            this.pIdLbl.AutoSize = true;
            this.pIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pIdLbl.Location = new System.Drawing.Point(29, 136);
            this.pIdLbl.Name = "pIdLbl";
            this.pIdLbl.Size = new System.Drawing.Size(123, 20);
            this.pIdLbl.TabIndex = 16;
            this.pIdLbl.Text = "PRODUCT ID:";
            // 
            // feedbackLbl
            // 
            this.feedbackLbl.AutoSize = true;
            this.feedbackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feedbackLbl.Location = new System.Drawing.Point(277, 9);
            this.feedbackLbl.Name = "feedbackLbl";
            this.feedbackLbl.Size = new System.Drawing.Size(104, 20);
            this.feedbackLbl.TabIndex = 17;
            this.feedbackLbl.Text = "FEEDBACK";
            this.feedbackLbl.Click += new System.EventHandler(this.feedbackLbl_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::App.Properties.Resources.flat_lay_transparent_leaves_lamina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBtn);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(815, 489);
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.Label mobileLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label pIdLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pNameLbl;
        private System.Windows.Forms.Label feedbackLbl;
    }
}