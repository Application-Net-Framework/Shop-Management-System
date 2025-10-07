namespace App.UI_Forms.Manager.User_Control_Form
{
    partial class searchProduct
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
            this.searchPnl = new System.Windows.Forms.Panel();
            this.productShowData = new System.Windows.Forms.DataGridView();
            this.stacklevelbtn2 = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.searchPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productShowData)).BeginInit();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPnl
            // 
            this.searchPnl.Controls.Add(this.deletebtn);
            this.searchPnl.Controls.Add(this.productShowData);
            this.searchPnl.Controls.Add(this.stacklevelbtn2);
            this.searchPnl.Controls.Add(this.panel18);
            this.searchPnl.Controls.Add(this.panel17);
            this.searchPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPnl.Location = new System.Drawing.Point(0, 0);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Size = new System.Drawing.Size(1000, 438);
            this.searchPnl.TabIndex = 86;
            // 
            // productShowData
            // 
            this.productShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productShowData.Location = new System.Drawing.Point(37, 56);
            this.productShowData.Name = "productShowData";
            this.productShowData.Size = new System.Drawing.Size(825, 267);
            this.productShowData.TabIndex = 85;
            // 
            // stacklevelbtn2
            // 
            this.stacklevelbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.stacklevelbtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stacklevelbtn2.ForeColor = System.Drawing.Color.White;
            this.stacklevelbtn2.Location = new System.Drawing.Point(37, 347);
            this.stacklevelbtn2.Name = "stacklevelbtn2";
            this.stacklevelbtn2.Size = new System.Drawing.Size(70, 38);
            this.stacklevelbtn2.TabIndex = 84;
            this.stacklevelbtn2.Text = "Back";
            this.stacklevelbtn2.UseVisualStyleBackColor = false;
            this.stacklevelbtn2.Click += new System.EventHandler(this.stacklevelbtn2_Click);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel18.Controls.Add(this.label8);
            this.panel18.Location = new System.Drawing.Point(220, 8);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(151, 29);
            this.panel18.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Search";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Controls.Add(this.productSearchBox);
            this.panel17.Location = new System.Drawing.Point(370, 8);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(328, 29);
            this.panel17.TabIndex = 81;
            // 
            // productSearchBox
            // 
            this.productSearchBox.BackColor = System.Drawing.Color.White;
            this.productSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productSearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchBox.Location = new System.Drawing.Point(4, 4);
            this.productSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(320, 20);
            this.productSearchBox.TabIndex = 2;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.IndianRed;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(113, 347);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(72, 38);
            this.deletebtn.TabIndex = 86;
            this.deletebtn.Text = "delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // searchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPnl);
            this.Name = "searchProduct";
            this.Size = new System.Drawing.Size(1000, 438);
            this.searchPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productShowData)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchPnl;
        private System.Windows.Forms.DataGridView productShowData;
        private System.Windows.Forms.Button stacklevelbtn2;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button deletebtn;
    }
}
