namespace App

{
    partial class Login_Admin
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
            this.lbluName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtuName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbluName
            // 
            this.lbluName.AutoSize = true;
            this.lbluName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluName.Location = new System.Drawing.Point(111, 166);
            this.lbluName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluName.Name = "lbluName";
            this.lbluName.Size = new System.Drawing.Size(117, 27);
            this.lbluName.TabIndex = 0;
            this.lbluName.Text = "UserName:";
            this.lbluName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(111, 220);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(108, 27);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // txtuName
            // 
            this.txtuName.Location = new System.Drawing.Point(248, 159);
            this.txtuName.Name = "txtuName";
            this.txtuName.Size = new System.Drawing.Size(373, 39);
            this.txtuName.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(248, 213);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(373, 39);
            this.txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(327, 291);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 48);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegis
            // 
            this.btnRegis.Location = new System.Drawing.Point(308, 356);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(178, 48);
            this.btnRegis.TabIndex = 5;
            this.btnRegis.Text = "Registration";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 564);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtuName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lbluName);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login_Admin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtuName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegis;
    }
}