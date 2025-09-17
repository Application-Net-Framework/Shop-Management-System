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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.staffinfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtpnl.SuspendLayout();
            this.searchpnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffinfo)).BeginInit();
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
            this.infolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(338, 40);
            this.infolbl.TabIndex = 0;
            this.infolbl.Text = "Employee Informations";
            // 
            // txtpnl
            // 
            this.txtpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtpnl.Controls.Add(this.infolbl);
            this.txtpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtpnl.Location = new System.Drawing.Point(0, 0);
            this.txtpnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpnl.Name = "txtpnl";
            this.txtpnl.Size = new System.Drawing.Size(1140, 52);
            this.txtpnl.TabIndex = 1;
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(100, 18);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(464, 26);
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
            this.searchpnl.Controls.Add(this.panel1);
            this.searchpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchpnl.Location = new System.Drawing.Point(0, 52);
            this.searchpnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchpnl.Name = "searchpnl";
            this.searchpnl.Size = new System.Drawing.Size(1140, 80);
            this.searchpnl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(1048, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(903, 20);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(822, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assign :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(602, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Role :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(669, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Controls.Add(this.searchlbl);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 65);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlbl.ForeColor = System.Drawing.Color.Black;
            this.searchlbl.Location = new System.Drawing.Point(10, 15);
            this.searchlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(97, 31);
            this.searchlbl.TabIndex = 5;
            this.searchlbl.Text = "Search :";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // staffinfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.staffinfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffinfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffinfo.Location = new System.Drawing.Point(0, 132);
            this.staffinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffinfo.Name = "staffinfo";
            this.staffinfo.RowHeadersWidth = 62;
            this.staffinfo.Size = new System.Drawing.Size(1140, 714);
            this.staffinfo.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 757);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 89);
            this.panel2.TabIndex = 5;
            // 
            // StaffInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1140, 846);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.staffinfo);
            this.Controls.Add(this.searchpnl);
            this.Controls.Add(this.txtpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaffInformation";
            this.Text = "StaffInformation";
            this.txtpnl.ResumeLayout(false);
            this.txtpnl.PerformLayout();
            this.searchpnl.ResumeLayout(false);
            this.searchpnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffinfo)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView staffinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}