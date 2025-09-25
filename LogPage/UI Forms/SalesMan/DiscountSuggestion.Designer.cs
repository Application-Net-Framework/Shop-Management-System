namespace App.UI_Forms.SalesMan
{
    partial class DiscountSuggestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePnl = new System.Windows.Forms.Panel();
            this.preOrderBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.cManagementBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.pQueryBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.sidePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "DISCOUNT SUGGESTION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(152, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 53);
            this.panel1.TabIndex = 30;
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.Azure;
            this.sidePnl.Controls.Add(this.preOrderBtn);
            this.sidePnl.Controls.Add(this.feedbackBtn);
            this.sidePnl.Controls.Add(this.cManagementBtn);
            this.sidePnl.Controls.Add(this.homeBtn);
            this.sidePnl.Controls.Add(this.pQueryBtn);
            this.sidePnl.Controls.Add(this.logoutBtn);
            this.sidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePnl.Location = new System.Drawing.Point(0, 0);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.Size = new System.Drawing.Size(154, 561);
            this.sidePnl.TabIndex = 29;
            // 
            // preOrderBtn
            // 
            this.preOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.preOrderBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preOrderBtn.ForeColor = System.Drawing.Color.Transparent;
            this.preOrderBtn.Image = global::App.Properties.Resources.cart;
            this.preOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preOrderBtn.Location = new System.Drawing.Point(12, 188);
            this.preOrderBtn.Name = "preOrderBtn";
            this.preOrderBtn.Size = new System.Drawing.Size(135, 37);
            this.preOrderBtn.TabIndex = 31;
            this.preOrderBtn.Text = "Pre-Order";
            this.preOrderBtn.UseVisualStyleBackColor = false;
            this.preOrderBtn.Click += new System.EventHandler(this.preOrderBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.feedbackBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.feedbackBtn.Image = global::App.Properties.Resources.feedback;
            this.feedbackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedbackBtn.Location = new System.Drawing.Point(12, 145);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(135, 37);
            this.feedbackBtn.TabIndex = 31;
            this.feedbackBtn.Text = "FEEDBACK";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // cManagementBtn
            // 
            this.cManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cManagementBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cManagementBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cManagementBtn.Image = global::App.Properties.Resources.user1;
            this.cManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cManagementBtn.Location = new System.Drawing.Point(12, 102);
            this.cManagementBtn.Name = "cManagementBtn";
            this.cManagementBtn.Size = new System.Drawing.Size(135, 37);
            this.cManagementBtn.TabIndex = 12;
            this.cManagementBtn.Text = "CUSTOMER";
            this.cManagementBtn.UseVisualStyleBackColor = false;
            this.cManagementBtn.Click += new System.EventHandler(this.cManagementBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.homeBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.homeBtn.Image = global::App.Properties.Resources.home1;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(12, 16);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(135, 37);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // pQueryBtn
            // 
            this.pQueryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pQueryBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pQueryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.pQueryBtn.Image = global::App.Properties.Resources.product1;
            this.pQueryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pQueryBtn.Location = new System.Drawing.Point(12, 59);
            this.pQueryBtn.Name = "pQueryBtn";
            this.pQueryBtn.Size = new System.Drawing.Size(135, 37);
            this.pQueryBtn.TabIndex = 11;
            this.pQueryBtn.Text = "PRODUCT";
            this.pQueryBtn.UseVisualStyleBackColor = false;
            this.pQueryBtn.Click += new System.EventHandler(this.pQueryBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.logoutBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Image = global::App.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(12, 472);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(135, 37);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // DiscountSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePnl);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "DiscountSuggestion";
            this.Text = "DiscountSuggestion";
            this.Load += new System.EventHandler(this.DiscountSuggestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidePnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cManagementBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button pQueryBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePnl;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button preOrderBtn;
    }
}