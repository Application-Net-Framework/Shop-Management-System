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
            this.quantityLbl = new System.Windows.Forms.Label();
            this.codeLbl = new System.Windows.Forms.Label();
            this.addPnl = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cartPnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addPnl.SuspendLayout();
            this.cartPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // posLbl
            // 
            this.posLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.posLbl.AutoSize = true;
            this.posLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posLbl.Location = new System.Drawing.Point(306, 9);
            this.posLbl.Name = "posLbl";
            this.posLbl.Size = new System.Drawing.Size(174, 23);
            this.posLbl.TabIndex = 1;
            this.posLbl.Text = "Point Of Sale(POS)";
            // 
            // quantityLbl
            // 
            this.quantityLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(3, 43);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(202, 23);
            this.quantityLbl.TabIndex = 2;
            this.quantityLbl.Text = "Enter product quantity:";
            // 
            // codeLbl
            // 
            this.codeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeLbl.AutoSize = true;
            this.codeLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLbl.Location = new System.Drawing.Point(3, 20);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(174, 23);
            this.codeLbl.TabIndex = 3;
            this.codeLbl.Text = "Enter product code:";
            // 
            // addPnl
            // 
            this.addPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPnl.BackColor = System.Drawing.Color.SkyBlue;
            this.addPnl.Controls.Add(this.addBtn);
            this.addPnl.Controls.Add(this.textBox2);
            this.addPnl.Controls.Add(this.textBox1);
            this.addPnl.Controls.Add(this.quantityLbl);
            this.addPnl.Controls.Add(this.codeLbl);
            this.addPnl.Location = new System.Drawing.Point(12, 53);
            this.addPnl.Name = "addPnl";
            this.addPnl.Size = new System.Drawing.Size(344, 152);
            this.addPnl.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(199, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(199, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(94, 102);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(137, 33);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add to Cart";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // cartPnl
            // 
            this.cartPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cartPnl.BackColor = System.Drawing.Color.SkyBlue;
            this.cartPnl.Controls.Add(this.button1);
            this.cartPnl.Controls.Add(this.label1);
            this.cartPnl.Location = new System.Drawing.Point(362, 53);
            this.cartPnl.Name = "cartPnl";
            this.cartPnl.Size = new System.Drawing.Size(407, 395);
            this.cartPnl.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cart";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cartPnl);
            this.Controls.Add(this.addPnl);
            this.Controls.Add(this.posLbl);
            this.Name = "POS";
            this.Text = "POS";
            this.addPnl.ResumeLayout(false);
            this.addPnl.PerformLayout();
            this.cartPnl.ResumeLayout(false);
            this.cartPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label posLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.Panel addPnl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel cartPnl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}