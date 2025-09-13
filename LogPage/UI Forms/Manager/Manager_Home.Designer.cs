namespace App
{
    partial class Manager_Home
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
            this.toppnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // toppnl
            // 
            this.toppnl.BackColor = System.Drawing.Color.White;
            this.toppnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppnl.Location = new System.Drawing.Point(0, 0);
            this.toppnl.Name = "toppnl";
            this.toppnl.Size = new System.Drawing.Size(861, 35);
            this.toppnl.TabIndex = 0;
            // 
            // Manager_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 482);
            this.Controls.Add(this.toppnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_Home";
            this.Text = "Manager Dash Board";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppnl;
    }
}