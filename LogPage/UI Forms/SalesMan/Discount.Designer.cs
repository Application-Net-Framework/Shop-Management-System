namespace App
{
    partial class Discount
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
            this.feedbackLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(120, 350);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(92, 29);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // feedbackLbl
            // 
            this.feedbackLbl.AutoSize = true;
            this.feedbackLbl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.feedbackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feedbackLbl.Location = new System.Drawing.Point(254, 9);
            this.feedbackLbl.Name = "feedbackLbl";
            this.feedbackLbl.Size = new System.Drawing.Size(219, 20);
            this.feedbackLbl.TabIndex = 18;
            this.feedbackLbl.Text = "Find Less Popular product";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 312);
            this.dataGridView1.TabIndex = 19;
            // 
            // listBtn
            // 
            this.listBtn.AutoSize = true;
            this.listBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBtn.ForeColor = System.Drawing.Color.Transparent;
            this.listBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listBtn.Location = new System.Drawing.Point(298, 350);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(92, 29);
            this.listBtn.TabIndex = 20;
            this.listBtn.Text = "Get List";
            this.listBtn.UseVisualStyleBackColor = false;
            // 
            // reportBtn
            // 
            this.reportBtn.AutoSize = true;
            this.reportBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.reportBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.Transparent;
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(460, 350);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(135, 29);
            this.reportBtn.TabIndex = 21;
            this.reportBtn.Text = "Send to Manager";
            this.reportBtn.UseVisualStyleBackColor = false;
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::App.Properties.Resources.flat_lay_transparent_leaves_lamina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.feedbackLbl);
            this.Controls.Add(this.backBtn);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(815, 489);
            this.Name = "Discount";
            this.Text = "Discount";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label feedbackLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button reportBtn;
    }
}