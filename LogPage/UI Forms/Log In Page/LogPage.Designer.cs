namespace App
{
    partial class LogPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogPage));
            this.logBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.fPassBtn = new System.Windows.Forms.Button();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBtn
            // 
            this.logBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.logBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.Color.White;
            this.logBtn.Location = new System.Drawing.Point(195, 258);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(104, 33);
            this.logBtn.TabIndex = 2;
            this.logBtn.Text = "LogIn";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.registerBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(140, 328);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(205, 34);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "New user? Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // fPassBtn
            // 
            this.fPassBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fPassBtn.BackColor = System.Drawing.Color.Azure;
            this.fPassBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPassBtn.Location = new System.Drawing.Point(282, 213);
            this.fPassBtn.Name = "fPassBtn";
            this.fPassBtn.Size = new System.Drawing.Size(163, 25);
            this.fPassBtn.TabIndex = 4;
            this.fPassBtn.Text = "Forget your Password?";
            this.fPassBtn.UseVisualStyleBackColor = false;
            this.fPassBtn.Click += new System.EventHandler(this.fPassBtn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTxt.Location = new System.Drawing.Point(140, 133);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(305, 20);
            this.emailTxt.TabIndex = 5;
            this.emailTxt.TextChanged += new System.EventHandler(this.uNameTxt_TextChanged);
            // 
            // passTxt
            // 
            this.passTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTxt.Location = new System.Drawing.Point(140, 187);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(305, 20);
            this.passTxt.TabIndex = 6;
            this.passTxt.TextChanged += new System.EventHandler(this.passTxt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.fPassBtn);
            this.panel1.Controls.Add(this.emailTxt);
            this.panel1.Controls.Add(this.logBtn);
            this.panel1.Controls.Add(this.passTxt);
            this.panel1.Location = new System.Drawing.Point(252, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 392);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Welcome To Ananda Bazar Grocery Shop!";
            // 
            // LogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "LogPage";
            this.Text = "LogPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button fPassBtn;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

