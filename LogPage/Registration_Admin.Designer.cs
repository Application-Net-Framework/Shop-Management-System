namespace App
{
    partial class Registration_Admin
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
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lalFName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMStatus = new System.Windows.Forms.Label();
            this.lblQuali = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEPass = new System.Windows.Forms.Label();
            this.lblRPass = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtMStatus = new System.Windows.Forms.TextBox();
            this.txtQuali = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEPass = new System.Windows.Forms.TextBox();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(676, 198);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(178, 48);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(262, 123);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(373, 26);
            this.txtPNumber.TabIndex = 9;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(262, 76);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(373, 26);
            this.txtFName.TabIndex = 8;
            this.txtFName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 7;
            // 
            // lalFName
            // 
            this.lalFName.AutoSize = true;
            this.lalFName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalFName.Location = new System.Drawing.Point(99, 74);
            this.lalFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalFName.Name = "lalFName";
            this.lalFName.Size = new System.Drawing.Size(107, 27);
            this.lalFName.TabIndex = 6;
            this.lalFName.Text = "FullName:";
            this.lalFName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 12;
            // 
            // lblPNumber
            // 
            this.lblPNumber.AutoSize = true;
            this.lblPNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNumber.Location = new System.Drawing.Point(99, 119);
            this.lblPNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPNumber.Name = "lblPNumber";
            this.lblPNumber.Size = new System.Drawing.Size(156, 27);
            this.lblPNumber.TabIndex = 13;
            this.lblPNumber.Text = "PhoneNumber:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(99, 252);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(87, 27);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(99, 209);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(138, 27);
            this.lblBirthDate.TabIndex = 15;
            this.lblBirthDate.Text = "Date of Birth:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(99, 165);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 27);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 27);
            this.label8.TabIndex = 17;
            // 
            // lblMStatus
            // 
            this.lblMStatus.AutoSize = true;
            this.lblMStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMStatus.Location = new System.Drawing.Point(99, 291);
            this.lblMStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMStatus.Name = "lblMStatus";
            this.lblMStatus.Size = new System.Drawing.Size(148, 27);
            this.lblMStatus.TabIndex = 18;
            this.lblMStatus.Text = "Marital Status:";
            // 
            // lblQuali
            // 
            this.lblQuali.AutoSize = true;
            this.lblQuali.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuali.Location = new System.Drawing.Point(99, 336);
            this.lblQuali.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuali.Name = "lblQuali";
            this.lblQuali.Size = new System.Drawing.Size(136, 27);
            this.lblQuali.TabIndex = 19;
            this.lblQuali.Text = "Qualification:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(99, 380);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(94, 27);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Address:";
            // 
            // lblEPass
            // 
            this.lblEPass.AutoSize = true;
            this.lblEPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEPass.Location = new System.Drawing.Point(99, 420);
            this.lblEPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEPass.Name = "lblEPass";
            this.lblEPass.Size = new System.Drawing.Size(163, 27);
            this.lblEPass.TabIndex = 21;
            this.lblEPass.Text = "Enter Password:";
            // 
            // lblRPass
            // 
            this.lblRPass.AutoSize = true;
            this.lblRPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPass.Location = new System.Drawing.Point(99, 460);
            this.lblRPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRPass.Name = "lblRPass";
            this.lblRPass.Size = new System.Drawing.Size(193, 27);
            this.lblRPass.TabIndex = 22;
            this.lblRPass.Text = "Re-Type Password:";
            this.lblRPass.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(262, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(373, 26);
            this.txtEmail.TabIndex = 23;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(262, 209);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(373, 26);
            this.txtBirthDate.TabIndex = 24;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(262, 252);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(373, 26);
            this.txtGender.TabIndex = 25;
            // 
            // txtMStatus
            // 
            this.txtMStatus.Location = new System.Drawing.Point(262, 291);
            this.txtMStatus.Name = "txtMStatus";
            this.txtMStatus.Size = new System.Drawing.Size(373, 26);
            this.txtMStatus.TabIndex = 26;
            // 
            // txtQuali
            // 
            this.txtQuali.Location = new System.Drawing.Point(262, 336);
            this.txtQuali.Name = "txtQuali";
            this.txtQuali.Size = new System.Drawing.Size(373, 26);
            this.txtQuali.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(262, 380);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(373, 26);
            this.txtAddress.TabIndex = 28;
            // 
            // txtEPass
            // 
            this.txtEPass.Location = new System.Drawing.Point(262, 422);
            this.txtEPass.Name = "txtEPass";
            this.txtEPass.Size = new System.Drawing.Size(373, 26);
            this.txtEPass.TabIndex = 29;
            // 
            // txtRPass
            // 
            this.txtRPass.Location = new System.Drawing.Point(299, 462);
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.Size = new System.Drawing.Size(373, 26);
            this.txtRPass.TabIndex = 30;
            // 
            // Registration_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 564);
            this.Controls.Add(this.txtRPass);
            this.Controls.Add(this.txtEPass);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtQuali);
            this.Controls.Add(this.txtMStatus);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRPass);
            this.Controls.Add(this.lblEPass);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblQuali);
            this.Controls.Add(this.lblMStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPNumber);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lalFName);
            this.Name = "Registration_Admin";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lalFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPNumber;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMStatus;
        private System.Windows.Forms.Label lblQuali;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEPass;
        private System.Windows.Forms.Label lblRPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtMStatus;
        private System.Windows.Forms.TextBox txtQuali;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEPass;
        private System.Windows.Forms.TextBox txtRPass;
    }
}