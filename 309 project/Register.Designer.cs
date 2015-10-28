namespace _309_Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.lblStarUsername = new System.Windows.Forms.Label();
            this.lblStarPassword = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblStarLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStarFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 155);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 27);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 121);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(138, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(31, 124);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 92);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(138, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(29, 94);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Location = new System.Drawing.Point(120, 225);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(90, 27);
            this.btnBackToLogin.TabIndex = 5;
            this.btnBackToLogin.Text = "Close";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // lblStarUsername
            // 
            this.lblStarUsername.AutoSize = true;
            this.lblStarUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblStarUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarUsername.ForeColor = System.Drawing.Color.Red;
            this.lblStarUsername.Location = new System.Drawing.Point(18, 92);
            this.lblStarUsername.Name = "lblStarUsername";
            this.lblStarUsername.Size = new System.Drawing.Size(15, 20);
            this.lblStarUsername.TabIndex = 11;
            this.lblStarUsername.Text = "*";
            this.lblStarUsername.Visible = false;
            // 
            // lblStarPassword
            // 
            this.lblStarPassword.AutoSize = true;
            this.lblStarPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblStarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarPassword.ForeColor = System.Drawing.Color.Red;
            this.lblStarPassword.Location = new System.Drawing.Point(20, 119);
            this.lblStarPassword.Name = "lblStarPassword";
            this.lblStarPassword.Size = new System.Drawing.Size(15, 20);
            this.lblStarPassword.TabIndex = 12;
            this.lblStarPassword.Text = "*";
            this.lblStarPassword.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(72, 192);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(75, 13);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // lblStarLastName
            // 
            this.lblStarLastName.AutoSize = true;
            this.lblStarLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblStarLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarLastName.ForeColor = System.Drawing.Color.Red;
            this.lblStarLastName.Location = new System.Drawing.Point(18, 63);
            this.lblStarLastName.Name = "lblStarLastName";
            this.lblStarLastName.Size = new System.Drawing.Size(15, 20);
            this.lblStarLastName.TabIndex = 16;
            this.lblStarLastName.Text = "*";
            this.lblStarLastName.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(97, 63);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(138, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(29, 65);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblStarFirstName
            // 
            this.lblStarFirstName.AutoSize = true;
            this.lblStarFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblStarFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarFirstName.ForeColor = System.Drawing.Color.Red;
            this.lblStarFirstName.Location = new System.Drawing.Point(18, 34);
            this.lblStarFirstName.Name = "lblStarFirstName";
            this.lblStarFirstName.Size = new System.Drawing.Size(15, 20);
            this.lblStarFirstName.TabIndex = 19;
            this.lblStarFirstName.Text = "*";
            this.lblStarFirstName.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(97, 34);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(138, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(29, 36);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(280, 271);
            this.Controls.Add(this.lblStarFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStarLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblStarPassword);
            this.Controls.Add(this.lblStarUsername);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Label lblStarUsername;
        private System.Windows.Forms.Label lblStarPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblStarLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStarFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
    }
}