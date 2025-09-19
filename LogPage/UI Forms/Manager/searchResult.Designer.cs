namespace App.UI_Forms.Manager
{
    partial class searchResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchResult));
            this.namelb = new System.Windows.Forms.Label();
            this.emaillb = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(80, 13);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(106, 17);
            this.namelb.TabIndex = 0;
            this.namelb.Text = "Complete Name";
            // 
            // emaillb
            // 
            this.emaillb.AutoSize = true;
            this.emaillb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillb.ForeColor = System.Drawing.Color.Gray;
            this.emaillb.Location = new System.Drawing.Point(81, 31);
            this.emaillb.Name = "emaillb";
            this.emaillb.Size = new System.Drawing.Size(36, 15);
            this.emaillb.TabIndex = 1;
            this.emaillb.Text = "Email";
            // 
            // picturebox
            // 
            this.picturebox.Image = ((System.Drawing.Image)(resources.GetObject("picturebox.Image")));
            this.picturebox.Location = new System.Drawing.Point(7, 8);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(50, 50);
            this.picturebox.TabIndex = 2;
            this.picturebox.TabStop = false;
            // 
            // searchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.emaillb);
            this.Controls.Add(this.namelb);
            this.Name = "searchResult";
            this.Size = new System.Drawing.Size(330, 70);
            this.Load += new System.EventHandler(this.searchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.Label emaillb;
        private System.Windows.Forms.PictureBox picturebox;
    }
}
