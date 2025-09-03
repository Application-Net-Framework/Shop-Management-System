namespace LogPage
{
    partial class POS
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
            this.posLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // posLbl
            // 
            this.posLbl.AutoSize = true;
            this.posLbl.Location = new System.Drawing.Point(382, 219);
            this.posLbl.Name = "posLbl";
            this.posLbl.Size = new System.Drawing.Size(29, 13);
            this.posLbl.TabIndex = 1;
            this.posLbl.Text = "POS";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.posLbl);
            this.Name = "POS";
            this.Text = "POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label posLbl;
    }
}