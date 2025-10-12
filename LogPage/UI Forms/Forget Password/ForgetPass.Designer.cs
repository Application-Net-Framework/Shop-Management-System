namespace App

{
    partial class ForgetPass
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
            this.emailOrMobileLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dobLbl = new System.Windows.Forms.Label();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.dobTxt = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.checkPassTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.rePassLbl = new System.Windows.Forms.Label();
            this.passBtn = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailOrMobileLbl
            // 
            this.emailOrMobileLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailOrMobileLbl.AutoSize = true;
            this.emailOrMobileLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailOrMobileLbl.Location = new System.Drawing.Point(18, 72);
            this.emailOrMobileLbl.Name = "emailOrMobileLbl";
            this.emailOrMobileLbl.Size = new System.Drawing.Size(156, 15);
            this.emailOrMobileLbl.TabIndex = 0;
            this.emailOrMobileLbl.Text = "Enter your Mobile Number:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Recovey";
            // 
            // dobLbl
            // 
            this.dobLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobLbl.AutoSize = true;
            this.dobLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.Location = new System.Drawing.Point(18, 98);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(39, 15);
            this.dobLbl.TabIndex = 4;
            this.dobLbl.Text = "DOB:";
            // 
            // mobileTxt
            // 
            this.mobileTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobileTxt.Location = new System.Drawing.Point(227, 67);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(200, 20);
            this.mobileTxt.TabIndex = 6;
            // 
            // dobTxt
            // 
            this.dobTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobTxt.Location = new System.Drawing.Point(227, 93);
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.Size = new System.Drawing.Size(200, 20);
            this.dobTxt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(18, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkPassTxt
            // 
            this.checkPassTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkPassTxt.Location = new System.Drawing.Point(227, 145);
            this.checkPassTxt.Name = "checkPassTxt";
            this.checkPassTxt.Size = new System.Drawing.Size(200, 20);
            this.checkPassTxt.TabIndex = 41;
            // 
            // passTxt
            // 
            this.passTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTxt.Location = new System.Drawing.Point(227, 119);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(200, 20);
            this.passTxt.TabIndex = 40;
            // 
            // rePassLbl
            // 
            this.rePassLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rePassLbl.AutoSize = true;
            this.rePassLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePassLbl.Location = new System.Drawing.Point(18, 150);
            this.rePassLbl.Name = "rePassLbl";
            this.rePassLbl.Size = new System.Drawing.Size(116, 15);
            this.rePassLbl.TabIndex = 39;
            this.rePassLbl.Text = "Re-Typer Password:";
            // 
            // passBtn
            // 
            this.passBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passBtn.AutoSize = true;
            this.passBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBtn.Location = new System.Drawing.Point(18, 124);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(122, 15);
            this.passBtn.TabIndex = 38;
            this.passBtn.Text = "Enter New Password:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmBtn.Location = new System.Drawing.Point(209, 193);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(124, 23);
            this.confirmBtn.TabIndex = 37;
            this.confirmBtn.Text = "Confirm Password";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.emailOrMobileLbl);
            this.panel1.Controls.Add(this.checkPassTxt);
            this.panel1.Controls.Add(this.dobLbl);
            this.panel1.Controls.Add(this.passTxt);
            this.panel1.Controls.Add(this.mobileTxt);
            this.panel1.Controls.Add(this.rePassLbl);
            this.panel1.Controls.Add(this.dobTxt);
            this.panel1.Controls.Add(this.passBtn);
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Location = new System.Drawing.Point(246, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 234);
            this.panel1.TabIndex = 43;
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPass";
            this.Load += new System.EventHandler(this.ForgetPass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label emailOrMobileLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.DateTimePicker dobTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox checkPassTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label rePassLbl;
        private System.Windows.Forms.Label passBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Panel panel1;
    }
}