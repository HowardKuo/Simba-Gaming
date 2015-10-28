namespace _309_Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listGames = new System.Windows.Forms.ListBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnAdventure = new System.Windows.Forms.Button();
            this.btnFPS = new System.Windows.Forms.Button();
            this.btnRPG = new System.Windows.Forms.Button();
            this.btnOnline = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listGames
            // 
            this.listGames.BackColor = System.Drawing.Color.Black;
            this.listGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGames.ForeColor = System.Drawing.Color.White;
            this.listGames.FormattingEnabled = true;
            this.listGames.ItemHeight = 18;
            this.listGames.Location = new System.Drawing.Point(11, 83);
            this.listGames.Margin = new System.Windows.Forms.Padding(2);
            this.listGames.Name = "listGames";
            this.listGames.Size = new System.Drawing.Size(241, 202);
            this.listGames.TabIndex = 2;
            this.listGames.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listGames.DoubleClick += new System.EventHandler(this.DoubleClick);
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(11, 11);
            this.btnAction.Margin = new System.Windows.Forms.Padding(2);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(116, 34);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnAdventure
            // 
            this.btnAdventure.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdventure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdventure.Location = new System.Drawing.Point(136, 11);
            this.btnAdventure.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdventure.Name = "btnAdventure";
            this.btnAdventure.Size = new System.Drawing.Size(116, 34);
            this.btnAdventure.TabIndex = 4;
            this.btnAdventure.Text = "Adventure";
            this.btnAdventure.UseVisualStyleBackColor = false;
            this.btnAdventure.Click += new System.EventHandler(this.btnAdventure_Click);
            // 
            // btnFPS
            // 
            this.btnFPS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFPS.Location = new System.Drawing.Point(263, 11);
            this.btnFPS.Margin = new System.Windows.Forms.Padding(2);
            this.btnFPS.Name = "btnFPS";
            this.btnFPS.Size = new System.Drawing.Size(116, 34);
            this.btnFPS.TabIndex = 5;
            this.btnFPS.Text = "FPS";
            this.btnFPS.UseVisualStyleBackColor = false;
            this.btnFPS.Click += new System.EventHandler(this.btnFPS_Click);
            // 
            // btnRPG
            // 
            this.btnRPG.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRPG.Location = new System.Drawing.Point(389, 11);
            this.btnRPG.Margin = new System.Windows.Forms.Padding(2);
            this.btnRPG.Name = "btnRPG";
            this.btnRPG.Size = new System.Drawing.Size(116, 34);
            this.btnRPG.TabIndex = 6;
            this.btnRPG.Text = "RPG";
            this.btnRPG.UseVisualStyleBackColor = false;
            this.btnRPG.Click += new System.EventHandler(this.btnRPG_Click);
            // 
            // btnOnline
            // 
            this.btnOnline.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.Location = new System.Drawing.Point(517, 11);
            this.btnOnline.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(116, 34);
            this.btnOnline.TabIndex = 7;
            this.btnOnline.Text = "Online";
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 47);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            this.lblTitle.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(3, 63);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            this.lblDescription.Visible = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(5, 47);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 32);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Action";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(77, 316);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 25);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "$Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblTitle);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.lblDescription);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(263, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 384);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AllowDrop = true;
            this.btnAddToCart.Location = new System.Drawing.Point(146, 309);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(106, 39);
            this.btnAddToCart.TabIndex = 13;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeUser.Location = new System.Drawing.Point(661, 20);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(66, 16);
            this.lblWelcomeUser.TabIndex = 14;
            this.lblWelcomeUser.Text = "Welcome";
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.Color.Black;
            this.lstCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCart.ForeColor = System.Drawing.Color.White;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 18;
            this.lstCart.Location = new System.Drawing.Point(605, 86);
            this.lstCart.Margin = new System.Windows.Forms.Padding(2);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(230, 184);
            this.lstCart.TabIndex = 15;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            this.lstCart.DoubleClick += new System.EventHandler(this.Delete);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(673, 298);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 16;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(743, 295);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(92, 37);
            this.btnCheckOut.TabIndex = 19;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.BackColor = System.Drawing.Color.Transparent;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.White;
            this.lblCart.Location = new System.Drawing.Point(599, 50);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(59, 32);
            this.lblCart.TabIndex = 20;
            this.lblCart.Text = "Cart";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(11, 408);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 26);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 10);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.ForeColor = System.Drawing.Color.Silver;
            this.label21.Location = new System.Drawing.Point(8, 287);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(138, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Double-click to add to cart. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(602, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Double-click to remove from cart. ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(848, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lblWelcomeUser);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnOnline);
            this.Controls.Add(this.btnRPG);
            this.Controls.Add(this.btnFPS);
            this.Controls.Add(this.btnAdventure);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.listGames);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(642, 414);
            this.Name = "Main";
            this.Text = "Browse Games";
            this.Load += new System.EventHandler(this.Main_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listGames;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnAdventure;
        private System.Windows.Forms.Button btnFPS;
        private System.Windows.Forms.Button btnRPG;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
    }
}