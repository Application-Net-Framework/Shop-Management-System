namespace LogPage
{
    partial class ChangePassConfirm
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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.rePassLbl = new System.Windows.Forms.Label();
            this.passBtn = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.Location = new System.Drawing.Point(315, 114);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(283, 20);
            this.textBox8.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.Location = new System.Drawing.Point(315, 88);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(283, 20);
            this.textBox7.TabIndex = 33;
            // 
            // rePassLbl
            // 
            this.rePassLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rePassLbl.AutoSize = true;
            this.rePassLbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePassLbl.Location = new System.Drawing.Point(176, 114);
            this.rePassLbl.Name = "rePassLbl";
            this.rePassLbl.Size = new System.Drawing.Size(116, 15);
            this.rePassLbl.TabIndex = 32;
            this.rePassLbl.Text = "Re-Typer Password:";
            // 
            // passBtn
            // 
            this.passBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passBtn.AutoSize = true;
            this.passBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBtn.Location = new System.Drawing.Point(175, 88);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(122, 15);
            this.passBtn.TabIndex = 31;
            this.passBtn.Text = "Enter New Password:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmBtn.Location = new System.Drawing.Point(337, 206);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(124, 23);
            this.confirmBtn.TabIndex = 30;
            this.confirmBtn.Text = "Confirm Password";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.Location = new System.Drawing.Point(474, 257);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(124, 23);
            this.backBtn.TabIndex = 35;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ChangePassConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.rePassLbl);
            this.Controls.Add(this.passBtn);
            this.Controls.Add(this.confirmBtn);
            this.Name = "ChangePassConfirm";
            this.Text = "ChangePassConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label rePassLbl;
        private System.Windows.Forms.Label passBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button backBtn;
    }
}