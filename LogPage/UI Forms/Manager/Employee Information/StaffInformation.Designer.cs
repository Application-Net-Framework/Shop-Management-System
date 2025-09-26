namespace App.UI_Forms.Manager
{
    partial class StaffInformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInformation));
            this.infolbl = new System.Windows.Forms.Label();
            this.txtpnl = new System.Windows.Forms.Panel();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchpnl = new System.Windows.Forms.Panel();
            this.sortpnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.searchcontainerpnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.informationContainerpnl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateinfo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateofbirthtxt = new System.Windows.Forms.DateTimePicker();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.hiredate = new System.Windows.Forms.DateTimePicker();
            this.txtusrname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtpnl.SuspendLayout();
            this.searchpnl.SuspendLayout();
            this.sortpnl.SuspendLayout();
            this.searchcontainerpnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.informationContainerpnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // infolbl
            // 
            this.infolbl.AutoSize = true;
            this.infolbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.infolbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolbl.ForeColor = System.Drawing.Color.White;
            this.infolbl.Location = new System.Drawing.Point(0, 7);
            this.infolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(219, 25);
            this.infolbl.TabIndex = 0;
            this.infolbl.Text = "Employee Informations";
            // 
            // txtpnl
            // 
            this.txtpnl.AutoSize = true;
            this.txtpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtpnl.Controls.Add(this.infolbl);
            this.txtpnl.Location = new System.Drawing.Point(0, 0);
            this.txtpnl.Margin = new System.Windows.Forms.Padding(4);
            this.txtpnl.Name = "txtpnl";
            this.txtpnl.Size = new System.Drawing.Size(1043, 49);
            this.txtpnl.TabIndex = 1;
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.White;
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(4, 11);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(439, 20);
            this.searchbox.TabIndex = 2;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // searchpnl
            // 
            this.searchpnl.AutoSize = true;
            this.searchpnl.BackColor = System.Drawing.Color.Gainsboro;
            this.searchpnl.Controls.Add(this.sortpnl);
            this.searchpnl.Controls.Add(this.searchcontainerpnl);
            this.searchpnl.Controls.Add(this.informationContainerpnl);
            this.searchpnl.Location = new System.Drawing.Point(0, 49);
            this.searchpnl.Margin = new System.Windows.Forms.Padding(4);
            this.searchpnl.Name = "searchpnl";
            this.searchpnl.Size = new System.Drawing.Size(1043, 628);
            this.searchpnl.TabIndex = 3;
            // 
            // sortpnl
            // 
            this.sortpnl.AutoSize = true;
            this.sortpnl.Controls.Add(this.label1);
            this.sortpnl.Controls.Add(this.comboBox1);
            this.sortpnl.Controls.Add(this.label2);
            this.sortpnl.Controls.Add(this.button1);
            this.sortpnl.Controls.Add(this.comboBox2);
            this.sortpnl.Location = new System.Drawing.Point(540, 5);
            this.sortpnl.Name = "sortpnl";
            this.sortpnl.Size = new System.Drawing.Size(457, 91);
            this.sortpnl.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Role :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 8);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assign :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(409, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(273, 7);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // searchcontainerpnl
            // 
            this.searchcontainerpnl.AutoSize = true;
            this.searchcontainerpnl.Controls.Add(this.panel1);
            this.searchcontainerpnl.Controls.Add(this.pictureBox1);
            this.searchcontainerpnl.Controls.Add(this.searchContainer);
            this.searchcontainerpnl.Location = new System.Drawing.Point(0, 0);
            this.searchcontainerpnl.Name = "searchcontainerpnl";
            this.searchcontainerpnl.Size = new System.Drawing.Size(519, 620);
            this.searchcontainerpnl.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 52);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchContainer
            // 
            this.searchContainer.BackColor = System.Drawing.Color.White;
            this.searchContainer.Location = new System.Drawing.Point(11, 63);
            this.searchContainer.Margin = new System.Windows.Forms.Padding(4);
            this.searchContainer.Name = "searchContainer";
            this.searchContainer.Size = new System.Drawing.Size(448, 65);
            this.searchContainer.TabIndex = 7;
            // 
            // informationContainerpnl
            // 
            this.informationContainerpnl.AutoSize = true;
            this.informationContainerpnl.Controls.Add(this.panel3);
            this.informationContainerpnl.Controls.Add(this.label11);
            this.informationContainerpnl.Controls.Add(this.textBox1);
            this.informationContainerpnl.Controls.Add(this.label3);
            this.informationContainerpnl.Controls.Add(this.dateofbirthtxt);
            this.informationContainerpnl.Controls.Add(this.txtuserid);
            this.informationContainerpnl.Controls.Add(this.hiredate);
            this.informationContainerpnl.Controls.Add(this.txtusrname);
            this.informationContainerpnl.Controls.Add(this.label10);
            this.informationContainerpnl.Controls.Add(this.label4);
            this.informationContainerpnl.Controls.Add(this.label9);
            this.informationContainerpnl.Controls.Add(this.txtgender);
            this.informationContainerpnl.Controls.Add(this.txtrole);
            this.informationContainerpnl.Controls.Add(this.label6);
            this.informationContainerpnl.Controls.Add(this.label7);
            this.informationContainerpnl.Controls.Add(this.txtphone);
            this.informationContainerpnl.Controls.Add(this.txtage);
            this.informationContainerpnl.Controls.Add(this.label5);
            this.informationContainerpnl.Controls.Add(this.label8);
            this.informationContainerpnl.Location = new System.Drawing.Point(539, 102);
            this.informationContainerpnl.Name = "informationContainerpnl";
            this.informationContainerpnl.Size = new System.Drawing.Size(458, 517);
            this.informationContainerpnl.TabIndex = 26;
            this.informationContainerpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.informationContainerpnl_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.updateinfo);
            this.panel3.Location = new System.Drawing.Point(159, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 56);
            this.panel3.TabIndex = 27;
            // 
            // updateinfo
            // 
            this.updateinfo.BackColor = System.Drawing.Color.Black;
            this.updateinfo.ForeColor = System.Drawing.Color.White;
            this.updateinfo.Image = ((System.Drawing.Image)(resources.GetObject("updateinfo.Image")));
            this.updateinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateinfo.Location = new System.Drawing.Point(3, 0);
            this.updateinfo.Name = "updateinfo";
            this.updateinfo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.updateinfo.Size = new System.Drawing.Size(204, 56);
            this.updateinfo.TabIndex = 28;
            this.updateinfo.Text = "Update";
            this.updateinfo.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Degree       :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "User ID       :";
            // 
            // dateofbirthtxt
            // 
            this.dateofbirthtxt.Location = new System.Drawing.Point(131, 205);
            this.dateofbirthtxt.Name = "dateofbirthtxt";
            this.dateofbirthtxt.Size = new System.Drawing.Size(242, 20);
            this.dateofbirthtxt.TabIndex = 25;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(130, 11);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(241, 20);
            this.txtuserid.TabIndex = 8;
            // 
            // hiredate
            // 
            this.hiredate.Location = new System.Drawing.Point(131, 351);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(242, 20);
            this.hiredate.TabIndex = 24;
            // 
            // txtusrname
            // 
            this.txtusrname.Location = new System.Drawing.Point(131, 57);
            this.txtusrname.Name = "txtusrname";
            this.txtusrname.Size = new System.Drawing.Size(241, 20);
            this.txtusrname.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Hire Date    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "User Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Role            :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(131, 106);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(241, 20);
            this.txtgender.TabIndex = 12;
            // 
            // txtrole
            // 
            this.txtrole.Location = new System.Drawing.Point(132, 300);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(241, 20);
            this.txtrole.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gender       :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Age             : ";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(132, 158);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(241, 20);
            this.txtphone.TabIndex = 14;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(132, 252);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(241, 20);
            this.txtage.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone No   :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "DOB           :";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // StaffInformation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1043, 677);
            this.Controls.Add(this.searchpnl);
            this.Controls.Add(this.txtpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffInformation";
            this.Text = "StaffInformation";
            this.Load += new System.EventHandler(this.StaffInformation_Load);
            this.txtpnl.ResumeLayout(false);
            this.txtpnl.PerformLayout();
            this.searchpnl.ResumeLayout(false);
            this.searchpnl.PerformLayout();
            this.sortpnl.ResumeLayout(false);
            this.sortpnl.PerformLayout();
            this.searchcontainerpnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.informationContainerpnl.ResumeLayout(false);
            this.informationContainerpnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Panel txtpnl;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Panel searchpnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel searchContainer;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusrname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.DateTimePicker hiredate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateofbirthtxt;
        private System.Windows.Forms.Panel informationContainerpnl;
        private System.Windows.Forms.Button updateinfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel sortpnl;
        private System.Windows.Forms.Panel searchcontainerpnl;
    }
}