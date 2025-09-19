namespace App.UI_Forms.Manager.Employee_Information
{
    partial class SearchResultControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultControl));
            this.usernamelb = new System.Windows.Forms.Label();
            this.phonelb = new System.Windows.Forms.Label();
            this.circlepicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circlepicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamelb
            // 
            this.usernamelb.AutoSize = true;
            this.usernamelb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelb.ForeColor = System.Drawing.Color.Black;
            this.usernamelb.Location = new System.Drawing.Point(127, 6);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(135, 23);
            this.usernamelb.TabIndex = 0;
            this.usernamelb.Text = "Complete Name";
            this.usernamelb.Click += new System.EventHandler(this.usernamelb_Click);
            // 
            // phonelb
            // 
            this.phonelb.AutoSize = true;
            this.phonelb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelb.ForeColor = System.Drawing.Color.Silver;
            this.phonelb.Location = new System.Drawing.Point(123, 31);
            this.phonelb.Name = "phonelb";
            this.phonelb.Size = new System.Drawing.Size(53, 20);
            this.phonelb.TabIndex = 1;
            this.phonelb.Text = "Phone";
            this.phonelb.Click += new System.EventHandler(this.phonelb_Click);
            // 
            // circlepicturebox
            // 
            this.circlepicturebox.Image = ((System.Drawing.Image)(resources.GetObject("circlepicturebox.Image")));
            this.circlepicturebox.Location = new System.Drawing.Point(31, 6);
            this.circlepicturebox.Margin = new System.Windows.Forms.Padding(4);
            this.circlepicturebox.Name = "circlepicturebox";
            this.circlepicturebox.Size = new System.Drawing.Size(50, 48);
            this.circlepicturebox.TabIndex = 5;
            this.circlepicturebox.TabStop = false;
            // 
            // SearchResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.circlepicturebox);
            this.Controls.Add(this.phonelb);
            this.Controls.Add(this.usernamelb);
            this.Name = "SearchResultControl";
            this.Size = new System.Drawing.Size(448, 62);
            this.Load += new System.EventHandler(this.SearchResultControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circlepicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelb;
        private System.Windows.Forms.Label phonelb;
        private System.Windows.Forms.PictureBox circlepicturebox;
    }
}
