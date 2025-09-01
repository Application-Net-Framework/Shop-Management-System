namespace LogPage
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
            this.uNameBtn = new System.Windows.Forms.Button();
            this.passBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.fPassBtn = new System.Windows.Forms.Button();
            this.uNameTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomeTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uNameBtn
            // 
            this.uNameBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uNameBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameBtn.Location = new System.Drawing.Point(13, 78);
            this.uNameBtn.Name = "uNameBtn";
            this.uNameBtn.Size = new System.Drawing.Size(178, 32);
            this.uNameBtn.TabIndex = 0;
            this.uNameBtn.Text = "Enter Username";
            this.uNameBtn.UseVisualStyleBackColor = true;
            this.uNameBtn.Click += new System.EventHandler(this.uNameBtn_Click);
            // 
            // passBtn
            // 
            this.passBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBtn.Location = new System.Drawing.Point(13, 134);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(178, 29);
            this.passBtn.TabIndex = 1;
            this.passBtn.Text = "Enter Password";
            this.passBtn.UseVisualStyleBackColor = true;
            this.passBtn.Click += new System.EventHandler(this.passBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.Location = new System.Drawing.Point(342, 205);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(104, 33);
            this.logBtn.TabIndex = 2;
            this.logBtn.Text = "LogIn";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(197, 262);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(205, 34);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "New user? Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // fPassBtn
            // 
            this.fPassBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fPassBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPassBtn.Location = new System.Drawing.Point(209, 311);
            this.fPassBtn.Name = "fPassBtn";
            this.fPassBtn.Size = new System.Drawing.Size(172, 28);
            this.fPassBtn.TabIndex = 4;
            this.fPassBtn.Text = "Forget your Password?";
            this.fPassBtn.UseVisualStyleBackColor = true;
            this.fPassBtn.Click += new System.EventHandler(this.fPassBtn_Click);
            // 
            // uNameTxt
            // 
            this.uNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uNameTxt.Location = new System.Drawing.Point(197, 86);
            this.uNameTxt.Name = "uNameTxt";
            this.uNameTxt.Size = new System.Drawing.Size(305, 20);
            this.uNameTxt.TabIndex = 5;
            this.uNameTxt.TextChanged += new System.EventHandler(this.uNameTxt_TextChanged);
            // 
            // passTxt
            // 
            this.passTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTxt.Location = new System.Drawing.Point(197, 140);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(305, 20);
            this.passTxt.TabIndex = 6;
            this.passTxt.TextChanged += new System.EventHandler(this.passTxt_TextChanged);
            // 
            // messageTxt
            // 
            this.messageTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messageTxt.Location = new System.Drawing.Point(293, 183);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(10, 20);
            this.messageTxt.TabIndex = 7;
            this.messageTxt.TextChanged += new System.EventHandler(this.messageTxt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.welcomeTxt);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.uNameBtn);
            this.panel1.Controls.Add(this.fPassBtn);
            this.panel1.Controls.Add(this.passBtn);
            this.panel1.Controls.Add(this.messageTxt);
            this.panel1.Controls.Add(this.uNameTxt);
            this.panel1.Controls.Add(this.logBtn);
            this.panel1.Controls.Add(this.passTxt);
            this.panel1.Location = new System.Drawing.Point(225, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 392);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // welcomeTxt
            // 
            this.welcomeTxt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTxt.Location = new System.Drawing.Point(143, 16);
            this.welcomeTxt.Name = "welcomeTxt";
            this.welcomeTxt.Size = new System.Drawing.Size(303, 32);
            this.welcomeTxt.TabIndex = 8;
            this.welcomeTxt.Text = "Welcome To Deshi Grocery Shop!";
            this.welcomeTxt.TextChanged += new System.EventHandler(this.welcomeTxt_TextChanged);
            // 
            // LogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 638);
            this.Controls.Add(this.panel1);
            this.Name = "LogPage";
            this.Text = "LogPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uNameBtn;
        private System.Windows.Forms.Button passBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button fPassBtn;
        private System.Windows.Forms.TextBox uNameTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox welcomeTxt;
    }
}

