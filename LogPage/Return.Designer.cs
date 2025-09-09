namespace App
{
    partial class Return
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
            this.returnLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnLbl
            // 
            this.returnLbl.AutoSize = true;
            this.returnLbl.Location = new System.Drawing.Point(382, 219);
            this.returnLbl.Name = "returnLbl";
            this.returnLbl.Size = new System.Drawing.Size(99, 13);
            this.returnLbl.TabIndex = 1;
            this.returnLbl.Text = "Return or Exchangr";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnLbl);
            this.Name = "Return";
            this.Text = "Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label returnLbl;
    }
}