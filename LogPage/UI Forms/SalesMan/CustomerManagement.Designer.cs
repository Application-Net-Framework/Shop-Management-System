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
            this.homeBtn = new System.Windows.Forms.Button();
            this.pQueryBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.benifitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.statusTxt = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.mobileLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seeBtn = new System.Windows.Forms.Button();
            this.sidePnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.Azure;
            this.sidePnl.Controls.Add(this.preOrderBtn);
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
            this.preOrderBtn.Location = new System.Drawing.Point(12, 145);
            this.preOrderBtn.Name = "preOrderBtn";
            this.preOrderBtn.Size = new System.Drawing.Size(135, 37);
            this.preOrderBtn.TabIndex = 21;
            this.preOrderBtn.Text = "Pre-Order";
            this.preOrderBtn.UseVisualStyleBackColor = false;
            this.preOrderBtn.Click += new System.EventHandler(this.preOrderBtn_Click);
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
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.idTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.benifitBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.emailTxt);
            this.panel2.Controls.Add(this.statusTxt);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.mobileTxt);
            this.panel2.Controls.Add(this.nameTxt);
            this.panel2.Controls.Add(this.emailLbl);
            this.panel2.Controls.Add(this.mobileLbl);
            this.panel2.Controls.Add(this.nameLbl);
            this.panel2.Location = new System.Drawing.Point(210, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 256);
            this.panel2.TabIndex = 14;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBtn.Location = new System.Drawing.Point(324, 204);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(118, 23);
            this.updateBtn.TabIndex = 21;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // idTxt
            // 
            this.idTxt.BackColor = System.Drawing.Color.White;
            this.idTxt.Location = new System.Drawing.Point(540, 11);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(134, 20);
            this.idTxt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CustomerID";
            // 
            // benifitBtn
            // 
            this.benifitBtn.BackColor = System.Drawing.Color.White;
            this.benifitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benifitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.benifitBtn.Location = new System.Drawing.Point(18, 165);
            this.benifitBtn.Name = "benifitBtn";
            this.benifitBtn.Size = new System.Drawing.Size(204, 23);
            this.benifitBtn.TabIndex = 19;
            this.benifitBtn.Text = "View Memebrship Benifit";
            this.benifitBtn.UseVisualStyleBackColor = false;
            this.benifitBtn.Click += new System.EventHandler(this.benifitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Location = new System.Drawing.Point(85, 204);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(67, 23);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.White;
            this.emailTxt.Location = new System.Drawing.Point(204, 95);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(218, 20);
            this.emailTxt.TabIndex = 5;
            // 
            // statusTxt
            // 
            this.statusTxt.BackColor = System.Drawing.Color.White;
            this.statusTxt.FormattingEnabled = true;
            this.statusTxt.Items.AddRange(new object[] {
            "Premimum",
            "Regular"});
            this.statusTxt.Location = new System.Drawing.Point(204, 129);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(218, 21);
            this.statusTxt.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(176, 204);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(118, 23);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add Customer";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Membership status";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personal Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(538, 151);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // seeBtn
            // 
            this.seeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.seeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seeBtn.Location = new System.Drawing.Point(479, 495);
            this.seeBtn.Name = "seeBtn";
            this.seeBtn.Size = new System.Drawing.Size(132, 23);
            this.seeBtn.TabIndex = 18;
            this.seeBtn.Text = "View Members";
            this.seeBtn.UseVisualStyleBackColor = false;
            this.seeBtn.Click += new System.EventHandler(this.seeBtn_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.seeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePnl);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.sidePnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label mobileLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.ComboBox statusTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button benifitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button seeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button preOrderBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
    }
}