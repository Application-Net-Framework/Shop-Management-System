namespace App
{
    partial class Salesman_Home
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
            this.components = new System.ComponentModel.Container();
            this.sidePnl = new System.Windows.Forms.Panel();
            this.headerPnl = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.mainPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productBtn = new System.Windows.Forms.Button();
            this.discountBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.sidePnl.SuspendLayout();
            this.mainPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.DimGray;
            this.sidePnl.Controls.Add(this.productBtn);
            this.sidePnl.Controls.Add(this.discountBtn);
            this.sidePnl.Controls.Add(this.feedbackBtn);
            this.sidePnl.Controls.Add(this.customerBtn);
            this.sidePnl.Controls.Add(this.logoutBtn);
            this.sidePnl.Controls.Add(this.profilebtn);
            this.sidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePnl.Location = new System.Drawing.Point(0, 0);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.Size = new System.Drawing.Size(169, 450);
            this.sidePnl.TabIndex = 0;
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(169, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(630, 37);
            this.headerPnl.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainPnl
            // 
            this.mainPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPnl.BackgroundImage = global::App.Properties.Resources.delivery_concept_handsome_african_american_delivery_man_carrying_package_box_grocery_food_drink_from_store_isolated_grey_studio_background_copy_space;
            this.mainPnl.Controls.Add(this.label1);
            this.mainPnl.Location = new System.Drawing.Point(195, 43);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(592, 378);
            this.mainPnl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " Welcome to Ananda Bazar Grocery";
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.DimGray;
            this.productBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.Transparent;
            this.productBtn.Image = global::App.Properties.Resources.product;
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(16, 43);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(153, 37);
            this.productBtn.TabIndex = 13;
            this.productBtn.Text = "PRODUCT";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // discountBtn
            // 
            this.discountBtn.BackColor = System.Drawing.Color.DimGray;
            this.discountBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountBtn.ForeColor = System.Drawing.Color.Transparent;
            this.discountBtn.Image = global::App.Properties.Resources.discount1;
            this.discountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discountBtn.Location = new System.Drawing.Point(13, 208);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(153, 37);
            this.discountBtn.TabIndex = 12;
            this.discountBtn.Text = "DISCOUNT";
            this.discountBtn.UseVisualStyleBackColor = false;
            this.discountBtn.Click += new System.EventHandler(this.discountBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.DimGray;
            this.feedbackBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.feedbackBtn.Image = global::App.Properties.Resources.feedback;
            this.feedbackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedbackBtn.Location = new System.Drawing.Point(13, 152);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(153, 37);
            this.feedbackBtn.TabIndex = 11;
            this.feedbackBtn.Text = "FEEDBACK";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.AutoSize = true;
            this.customerBtn.BackColor = System.Drawing.Color.DimGray;
            this.customerBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.customerBtn.Image = global::App.Properties.Resources.user;
            this.customerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerBtn.Location = new System.Drawing.Point(12, 98);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(153, 37);
            this.customerBtn.TabIndex = 10;
            this.customerBtn.Text = "CUSTOMER";
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DimGray;
            this.logoutBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Image = global::App.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(13, 355);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(153, 37);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.BackColor = System.Drawing.Color.DimGray;
            this.profilebtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.ForeColor = System.Drawing.Color.Transparent;
            this.profilebtn.Image = global::App.Properties.Resources.user;
            this.profilebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profilebtn.Location = new System.Drawing.Point(13, 312);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(153, 37);
            this.profilebtn.TabIndex = 7;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = false;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::App.Properties.Resources.flat_lay_transparent_leaves_lamina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.headerPnl);
            this.Controls.Add(this.sidePnl);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(815, 489);
            this.Name = "Salesman";
            this.Text = "Salesman_Home";
            this.Load += new System.EventHandler(this.Cashier_Home_Load);
            this.sidePnl.ResumeLayout(false);
            this.sidePnl.PerformLayout();
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePnl;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button discountBtn;
        private System.Windows.Forms.Button productBtn;
    }
}