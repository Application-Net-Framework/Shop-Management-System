namespace App.UI_Forms.SalesMan
{
    partial class CustomerManagement
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
            this.sidePnl = new System.Windows.Forms.Panel();
            this.preOrderBtn = new System.Windows.Forms.Button();
            this.discountBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.pQueryBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.mobileLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.benifitBtn = new System.Windows.Forms.Button();
            this.statusTxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.sidePnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.Azure;
            this.sidePnl.Controls.Add(this.preOrderBtn);
            this.sidePnl.Controls.Add(this.discountBtn);
            this.sidePnl.Controls.Add(this.homeBtn);
            this.sidePnl.Controls.Add(this.pQueryBtn);
            this.sidePnl.Controls.Add(this.feedbackBtn);
            this.sidePnl.Controls.Add(this.logoutBtn);
            this.sidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePnl.Location = new System.Drawing.Point(0, 0);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.Size = new System.Drawing.Size(154, 561);
            this.sidePnl.TabIndex = 2;
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
            this.preOrderBtn.TabIndex = 21;
            this.preOrderBtn.Text = "Pre-Order";
            this.preOrderBtn.UseVisualStyleBackColor = false;
            this.preOrderBtn.Click += new System.EventHandler(this.preOrderBtn_Click);
            // 
            // discountBtn
            // 
            this.discountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.discountBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountBtn.ForeColor = System.Drawing.Color.Transparent;
            this.discountBtn.Image = global::App.Properties.Resources.discount;
            this.discountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discountBtn.Location = new System.Drawing.Point(12, 145);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(135, 37);
            this.discountBtn.TabIndex = 20;
            this.discountBtn.Text = "Discount";
            this.discountBtn.UseVisualStyleBackColor = false;
            this.discountBtn.Click += new System.EventHandler(this.discountBtn_Click);
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
            this.pQueryBtn.Location = new System.Drawing.Point(12, 102);
            this.pQueryBtn.Name = "pQueryBtn";
            this.pQueryBtn.Size = new System.Drawing.Size(135, 37);
            this.pQueryBtn.TabIndex = 11;
            this.pQueryBtn.Text = "PRODUCT";
            this.pQueryBtn.UseVisualStyleBackColor = false;
            this.pQueryBtn.Click += new System.EventHandler(this.pQueryBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.feedbackBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.feedbackBtn.Image = global::App.Properties.Resources.feedback;
            this.feedbackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedbackBtn.Location = new System.Drawing.Point(12, 59);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(135, 37);
            this.feedbackBtn.TabIndex = 10;
            this.feedbackBtn.Text = "FEEDBACK";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(153, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 53);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGE CUSTOMER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.emailTxt);
            this.panel2.Controls.Add(this.mobileTxt);
            this.panel2.Controls.Add(this.nameTxt);
            this.panel2.Controls.Add(this.emailLbl);
            this.panel2.Controls.Add(this.mobileLbl);
            this.panel2.Controls.Add(this.nameLbl);
            this.panel2.Location = new System.Drawing.Point(160, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 143);
            this.panel2.TabIndex = 14;
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.White;
            this.emailTxt.Location = new System.Drawing.Point(204, 95);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(218, 20);
            this.emailTxt.TabIndex = 5;
            // 
            // mobileTxt
            // 
            this.mobileTxt.BackColor = System.Drawing.Color.White;
            this.mobileTxt.Location = new System.Drawing.Point(204, 50);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(218, 20);
            this.mobileTxt.TabIndex = 4;
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.White;
            this.nameTxt.Location = new System.Drawing.Point(204, 11);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(218, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(15, 99);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(176, 16);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email Address(Optional)";
            // 
            // mobileLbl
            // 
            this.mobileLbl.AutoSize = true;
            this.mobileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLbl.Location = new System.Drawing.Point(15, 54);
            this.mobileLbl.Name = "mobileLbl";
            this.mobileLbl.Size = new System.Drawing.Size(112, 16);
            this.mobileLbl.TabIndex = 1;
            this.mobileLbl.Text = "Mobile Number";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(15, 11);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(77, 16);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Full Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.benifitBtn);
            this.panel3.Controls.Add(this.statusTxt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(160, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 151);
            this.panel3.TabIndex = 15;
            // 
            // benifitBtn
            // 
            this.benifitBtn.BackColor = System.Drawing.Color.White;
            this.benifitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benifitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.benifitBtn.Location = new System.Drawing.Point(18, 94);
            this.benifitBtn.Name = "benifitBtn";
            this.benifitBtn.Size = new System.Drawing.Size(204, 23);
            this.benifitBtn.TabIndex = 19;
            this.benifitBtn.Text = "View Memebrship Benifit";
            this.benifitBtn.UseVisualStyleBackColor = false;
            this.benifitBtn.Click += new System.EventHandler(this.benifitBtn_Click);
            // 
            // statusTxt
            // 
            this.statusTxt.BackColor = System.Drawing.Color.White;
            this.statusTxt.FormattingEnabled = true;
            this.statusTxt.Items.AddRange(new object[] {
            "Premimum",
            "Regular"});
            this.statusTxt.Location = new System.Drawing.Point(18, 31);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(186, 21);
            this.statusTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Membership status";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(380, 396);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(132, 23);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add Customer";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personal Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(639, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 151);
            this.dataGridView1.TabIndex = 17;
            // 
            // seeBtn
            // 
            this.seeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.seeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seeBtn.Location = new System.Drawing.Point(739, 396);
            this.seeBtn.Name = "seeBtn";
            this.seeBtn.Size = new System.Drawing.Size(132, 23);
            this.seeBtn.TabIndex = 18;
            this.seeBtn.Text = "View Members";
            this.seeBtn.UseVisualStyleBackColor = false;
            this.seeBtn.Click += new System.EventHandler(this.seeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Location = new System.Drawing.Point(307, 396);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(67, 23);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.seeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePnl);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.sidePnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel sidePnl;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button pQueryBtn;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label mobileLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.ComboBox statusTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button benifitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button seeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button discountBtn;
        private System.Windows.Forms.Button preOrderBtn;
    }
}