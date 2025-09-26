namespace App
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.empIdLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.perAddressLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dobDate = new System.Windows.Forms.DateTimePicker();
            this.mobileLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.genderLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.passBtn = new System.Windows.Forms.Label();
            this.rePassLbl = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.confirmPassTxt = new System.Windows.Forms.TextBox();
            this.educationLbl = new System.Windows.Forms.Label();
            this.educationCBox = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // empIdLbl
            // 
            this.empIdLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empIdLbl.AutoSize = true;
            this.empIdLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdLbl.Location = new System.Drawing.Point(44, 55);
            this.empIdLbl.Name = "empIdLbl";
            this.empIdLbl.Size = new System.Drawing.Size(82, 17);
            this.empIdLbl.TabIndex = 4;
            this.empIdLbl.Text = "Emplyee ID:";
            this.empIdLbl.Click += new System.EventHandler(this.empSerialLbl_Click);
            // 
            // idTxt
            // 
            this.idTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTxt.Location = new System.Drawing.Point(269, 52);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(283, 20);
            this.idTxt.TabIndex = 5;
            // 
            // perAddressLbl
            // 
            this.perAddressLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.perAddressLbl.AutoSize = true;
            this.perAddressLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.perAddressLbl.Location = new System.Drawing.Point(43, 278);
            this.perAddressLbl.Name = "perAddressLbl";
            this.perAddressLbl.Size = new System.Drawing.Size(67, 19);
            this.perAddressLbl.TabIndex = 7;
            this.perAddressLbl.Text = "Address:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(43, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Enter DOB:";
            // 
            // dobDate
            // 
            this.dobDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobDate.Location = new System.Drawing.Point(269, 179);
            this.dobDate.Name = "dobDate";
            this.dobDate.Size = new System.Drawing.Size(283, 20);
            this.dobDate.TabIndex = 14;
            // 
            // mobileLbl
            // 
            this.mobileLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobileLbl.AutoSize = true;
            this.mobileLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mobileLbl.Location = new System.Drawing.Point(43, 138);
            this.mobileLbl.Name = "mobileLbl";
            this.mobileLbl.Size = new System.Drawing.Size(120, 19);
            this.mobileLbl.TabIndex = 17;
            this.mobileLbl.Text = "Mobile Number:";
            // 
            // emailLbl
            // 
            this.emailLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.emailLbl.Location = new System.Drawing.Point(43, 94);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(53, 19);
            this.emailLbl.TabIndex = 18;
            this.emailLbl.Text = "E mail:";
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTxt.Location = new System.Drawing.Point(269, 93);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(283, 20);
            this.emailTxt.TabIndex = 19;
            // 
            // mobileTxt
            // 
            this.mobileTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobileTxt.Location = new System.Drawing.Point(269, 137);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(283, 20);
            this.mobileTxt.TabIndex = 20;
            // 
            // addressTxt
            // 
            this.addressTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTxt.Location = new System.Drawing.Point(269, 277);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(283, 20);
            this.addressTxt.TabIndex = 22;
            // 
            // genderLbl
            // 
            this.genderLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.genderLbl.Location = new System.Drawing.Point(43, 235);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(63, 19);
            this.genderLbl.TabIndex = 23;
            this.genderLbl.Text = "Gender:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.femaleRBtn);
            this.panel3.Controls.Add(this.maleRBtn);
            this.panel3.Location = new System.Drawing.Point(269, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 28);
            this.panel3.TabIndex = 17;
            // 
            // femaleRBtn
            // 
            this.femaleRBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleRBtn.AutoSize = true;
            this.femaleRBtn.Location = new System.Drawing.Point(142, 3);
            this.femaleRBtn.Name = "femaleRBtn";
            this.femaleRBtn.Size = new System.Drawing.Size(59, 17);
            this.femaleRBtn.TabIndex = 9;
            this.femaleRBtn.TabStop = true;
            this.femaleRBtn.Text = "Female";
            this.femaleRBtn.UseVisualStyleBackColor = true;
            // 
            // maleRBtn
            // 
            this.maleRBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleRBtn.AutoSize = true;
            this.maleRBtn.Location = new System.Drawing.Point(3, 3);
            this.maleRBtn.Name = "maleRBtn";
            this.maleRBtn.Size = new System.Drawing.Size(48, 17);
            this.maleRBtn.TabIndex = 8;
            this.maleRBtn.TabStop = true;
            this.maleRBtn.Text = "Male";
            this.maleRBtn.UseVisualStyleBackColor = true;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(256, 500);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(94, 29);
            this.confirmBtn.TabIndex = 25;
            this.confirmBtn.Text = "Confirm Registration";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // passBtn
            // 
            this.passBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passBtn.AutoSize = true;
            this.passBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.passBtn.Location = new System.Drawing.Point(43, 372);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(115, 19);
            this.passBtn.TabIndex = 26;
            this.passBtn.Text = "Enter Password:";
            // 
            // rePassLbl
            // 
            this.rePassLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rePassLbl.AutoSize = true;
            this.rePassLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rePassLbl.Location = new System.Drawing.Point(43, 416);
            this.rePassLbl.Name = "rePassLbl";
            this.rePassLbl.Size = new System.Drawing.Size(142, 19);
            this.rePassLbl.TabIndex = 27;
            this.rePassLbl.Text = "Re-Typer Password:";
            // 
            // passTxt
            // 
            this.passTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTxt.Location = new System.Drawing.Point(269, 371);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(283, 20);
            this.passTxt.TabIndex = 28;
            // 
            // confirmPassTxt
            // 
            this.confirmPassTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPassTxt.Location = new System.Drawing.Point(269, 415);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.Size = new System.Drawing.Size(283, 20);
            this.confirmPassTxt.TabIndex = 29;
            // 
            // educationLbl
            // 
            this.educationLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.educationLbl.AutoSize = true;
            this.educationLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.educationLbl.Location = new System.Drawing.Point(43, 327);
            this.educationLbl.Name = "educationLbl";
            this.educationLbl.Size = new System.Drawing.Size(209, 19);
            this.educationLbl.TabIndex = 32;
            this.educationLbl.Text = "Last Educational Qualification:";
            // 
            // educationCBox
            // 
            this.educationCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.educationCBox.FormattingEnabled = true;
            this.educationCBox.Items.AddRange(new object[] {
            "PhD",
            "Master\'s",
            "Bachelor\'s",
            "Diploma",
            "HSC/EQ",
            "SSC/EQ",
            "JSC/EQ",
            "PSC/EQ"});
            this.educationCBox.Location = new System.Drawing.Point(269, 327);
            this.educationCBox.Name = "educationCBox";
            this.educationCBox.Size = new System.Drawing.Size(283, 21);
            this.educationCBox.TabIndex = 33;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 526);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 34;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.educationCBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.educationLbl);
            this.panel4.Controls.Add(this.empIdLbl);
            this.panel4.Controls.Add(this.idTxt);
            this.panel4.Controls.Add(this.confirmPassTxt);
            this.panel4.Controls.Add(this.perAddressLbl);
            this.panel4.Controls.Add(this.passTxt);
            this.panel4.Controls.Add(this.rePassLbl);
            this.panel4.Controls.Add(this.passBtn);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.confirmBtn);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.genderLbl);
            this.panel4.Controls.Add(this.dobDate);
            this.panel4.Controls.Add(this.addressTxt);
            this.panel4.Controls.Add(this.mobileTxt);
            this.panel4.Controls.Add(this.mobileLbl);
            this.panel4.Controls.Add(this.emailTxt);
            this.panel4.Controls.Add(this.emailLbl);
            this.panel4.Location = new System.Drawing.Point(199, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(593, 545);
            this.panel4.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Registration";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.backBtn);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Registration";
            this.Text = "Register";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label empIdLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label perAddressLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dobDate;
        private System.Windows.Forms.Label mobileLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton femaleRBtn;
        private System.Windows.Forms.RadioButton maleRBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label passBtn;
        private System.Windows.Forms.Label rePassLbl;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox confirmPassTxt;
        private System.Windows.Forms.Label educationLbl;
        private System.Windows.Forms.ComboBox educationCBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}