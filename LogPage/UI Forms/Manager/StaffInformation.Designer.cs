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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchlbl = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.searchContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.txtpnl.SuspendLayout();
            this.searchpnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infolbl
            // 
            this.infolbl.AutoSize = true;
            this.infolbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.infolbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.infolbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolbl.ForeColor = System.Drawing.Color.White;
            this.infolbl.Location = new System.Drawing.Point(0, 0);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(219, 25);
            this.infolbl.TabIndex = 0;
            this.infolbl.Text = "Employee Informations";
            // 
            // txtpnl
            // 
            this.txtpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtpnl.Controls.Add(this.infolbl);
            this.txtpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtpnl.Location = new System.Drawing.Point(0, 0);
            this.txtpnl.Name = "txtpnl";
            this.txtpnl.Size = new System.Drawing.Size(782, 34);
            this.txtpnl.TabIndex = 1;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(3, 12);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(330, 20);
            this.searchbox.TabIndex = 2;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // searchpnl
            // 
            this.searchpnl.Controls.Add(this.button1);
            this.searchpnl.Controls.Add(this.comboBox2);
            this.searchpnl.Controls.Add(this.label2);
            this.searchpnl.Controls.Add(this.label1);
            this.searchpnl.Controls.Add(this.comboBox1);
            this.searchpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchpnl.Location = new System.Drawing.Point(0, 34);
            this.searchpnl.Name = "searchpnl";
            this.searchpnl.Size = new System.Drawing.Size(782, 59);
            this.searchpnl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(699, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(602, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(548, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assign :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(410, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Role :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Location = new System.Drawing.Point(90, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 42);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlbl.ForeColor = System.Drawing.Color.Black;
            this.searchlbl.Location = new System.Drawing.Point(579, 192);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(63, 20);
            this.searchlbl.TabIndex = 5;
            this.searchlbl.Text = "Search :";
            this.searchlbl.Click += new System.EventHandler(this.searchlbl_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // searchContainer
            // 
            this.searchContainer.Location = new System.Drawing.Point(90, 249);
            this.searchContainer.Name = "searchContainer";
            this.searchContainer.Size = new System.Drawing.Size(330, 70);
            this.searchContainer.TabIndex = 7;
            // 
            // StaffInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 550);
            this.Controls.Add(this.searchContainer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchpnl);
            this.Controls.Add(this.txtpnl);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "StaffInformation";
            this.Text = "StaffInformation";
            this.txtpnl.ResumeLayout(false);
            this.txtpnl.PerformLayout();
            this.searchpnl.ResumeLayout(false);
            this.searchpnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label searchlbl;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel searchContainer;
    }
}