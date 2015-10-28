namespace _309_Project
{
    partial class Billing
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
            /*close streamfile
            writer.Close();
            outFile.Close();*/
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.lblLastB = new System.Windows.Forms.Label();
            this.lblFirstB = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblBilling = new System.Windows.Forms.Label();
            this.lblSecCode = new System.Windows.Forms.Label();
            this.txtLastB = new System.Windows.Forms.TextBox();
            this.txtFirstB = new System.Windows.Forms.TextBox();
            this.txtSecCode = new System.Windows.Forms.TextBox();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.lblAddressB = new System.Windows.Forms.Label();
            this.txtAddressB = new System.Windows.Forms.TextBox();
            this.lblCityB = new System.Windows.Forms.Label();
            this.txtCityB = new System.Windows.Forms.TextBox();
            this.lblZipB = new System.Windows.Forms.Label();
            this.txtZipB = new System.Windows.Forms.TextBox();
            this.lblStateB = new System.Windows.Forms.Label();
            this.cmbStateB = new System.Windows.Forms.ComboBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblLastS = new System.Windows.Forms.Label();
            this.lblFirstS = new System.Windows.Forms.Label();
            this.lblAddressS = new System.Windows.Forms.Label();
            this.lblCityS = new System.Windows.Forms.Label();
            this.lblZipS = new System.Windows.Forms.Label();
            this.lblStateS = new System.Windows.Forms.Label();
            this.txtLastS = new System.Windows.Forms.TextBox();
            this.txtFirstS = new System.Windows.Forms.TextBox();
            this.txtAddressS = new System.Windows.Forms.TextBox();
            this.txtCityS = new System.Windows.Forms.TextBox();
            this.txtZipS = new System.Windows.Forms.TextBox();
            this.txtPhoneS = new System.Windows.Forms.TextBox();
            this.txtPhoneB = new System.Windows.Forms.TextBox();
            this.lblPhoneB = new System.Windows.Forms.Label();
            this.lblPhoneS = new System.Windows.Forms.Label();
            this.cmbStateS = new System.Windows.Forms.ComboBox();
            this.chkSame = new System.Windows.Forms.CheckBox();
            this.linklblTerms = new System.Windows.Forms.LinkLabel();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLastB
            // 
            this.lblLastB.AutoSize = true;
            this.lblLastB.BackColor = System.Drawing.Color.Transparent;
            this.lblLastB.ForeColor = System.Drawing.Color.White;
            this.lblLastB.Location = new System.Drawing.Point(44, 94);
            this.lblLastB.Name = "lblLastB";
            this.lblLastB.Size = new System.Drawing.Size(61, 13);
            this.lblLastB.TabIndex = 0;
            this.lblLastB.Text = "Last Name:";
            // 
            // lblFirstB
            // 
            this.lblFirstB.AutoSize = true;
            this.lblFirstB.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstB.ForeColor = System.Drawing.Color.White;
            this.lblFirstB.Location = new System.Drawing.Point(292, 94);
            this.lblFirstB.Name = "lblFirstB";
            this.lblFirstB.Size = new System.Drawing.Size(60, 13);
            this.lblFirstB.TabIndex = 0;
            this.lblFirstB.Text = "First Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(44, 122);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(59, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Card Type:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblCardNumber.ForeColor = System.Drawing.Color.White;
            this.lblCardNumber.Location = new System.Drawing.Point(280, 122);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(72, 13);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpDate.ForeColor = System.Drawing.Color.White;
            this.lblExpDate.Location = new System.Drawing.Point(23, 150);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(82, 13);
            this.lblExpDate.TabIndex = 0;
            this.lblExpDate.Text = "Expiration Date:";
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.BackColor = System.Drawing.Color.Transparent;
            this.lblBilling.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.lblBilling.ForeColor = System.Drawing.Color.White;
            this.lblBilling.Location = new System.Drawing.Point(235, 44);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(75, 32);
            this.lblBilling.TabIndex = 0;
            this.lblBilling.Text = "Billing";
            // 
            // lblSecCode
            // 
            this.lblSecCode.AutoSize = true;
            this.lblSecCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSecCode.ForeColor = System.Drawing.Color.White;
            this.lblSecCode.Location = new System.Drawing.Point(276, 151);
            this.lblSecCode.Name = "lblSecCode";
            this.lblSecCode.Size = new System.Drawing.Size(76, 13);
            this.lblSecCode.TabIndex = 0;
            this.lblSecCode.Text = "Security Code:";
            // 
            // txtLastB
            // 
            this.txtLastB.Location = new System.Drawing.Point(109, 90);
            this.txtLastB.Name = "txtLastB";
            this.txtLastB.Size = new System.Drawing.Size(137, 20);
            this.txtLastB.TabIndex = 1;
            // 
            // txtFirstB
            // 
            this.txtFirstB.Location = new System.Drawing.Point(358, 90);
            this.txtFirstB.Name = "txtFirstB";
            this.txtFirstB.Size = new System.Drawing.Size(137, 20);
            this.txtFirstB.TabIndex = 2;
            // 
            // txtSecCode
            // 
            this.txtSecCode.Location = new System.Drawing.Point(358, 148);
            this.txtSecCode.Name = "txtSecCode";
            this.txtSecCode.Size = new System.Drawing.Size(137, 20);
            this.txtSecCode.TabIndex = 7;
            // 
            // cmbCardType
            // 
            this.cmbCardType.AutoCompleteCustomSource.AddRange(new string[] {
            "American Express",
            "Discover",
            "Master Card",
            "Visa"});
            this.cmbCardType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Items.AddRange(new object[] {
            "American Express",
            "Discover",
            "Master Card",
            "Visa"});
            this.cmbCardType.Location = new System.Drawing.Point(109, 119);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(137, 21);
            this.cmbCardType.TabIndex = 3;
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(109, 147);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(66, 21);
            this.cmbMonth.TabIndex = 5;
            // 
            // cmbYear
            // 
            this.cmbYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbYear.Location = new System.Drawing.Point(188, 147);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(58, 21);
            this.cmbYear.TabIndex = 6;
            // 
            // txtCardNum
            // 
            this.txtCardNum.Location = new System.Drawing.Point(358, 119);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(137, 20);
            this.txtCardNum.TabIndex = 4;
            // 
            // lblAddressB
            // 
            this.lblAddressB.AutoSize = true;
            this.lblAddressB.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressB.ForeColor = System.Drawing.Color.White;
            this.lblAddressB.Location = new System.Drawing.Point(57, 180);
            this.lblAddressB.Name = "lblAddressB";
            this.lblAddressB.Size = new System.Drawing.Size(48, 13);
            this.lblAddressB.TabIndex = 0;
            this.lblAddressB.Text = "Address:";
            // 
            // txtAddressB
            // 
            this.txtAddressB.Location = new System.Drawing.Point(109, 177);
            this.txtAddressB.Name = "txtAddressB";
            this.txtAddressB.Size = new System.Drawing.Size(386, 20);
            this.txtAddressB.TabIndex = 8;
            // 
            // lblCityB
            // 
            this.lblCityB.AutoSize = true;
            this.lblCityB.BackColor = System.Drawing.Color.Transparent;
            this.lblCityB.ForeColor = System.Drawing.Color.White;
            this.lblCityB.Location = new System.Drawing.Point(76, 208);
            this.lblCityB.Name = "lblCityB";
            this.lblCityB.Size = new System.Drawing.Size(27, 13);
            this.lblCityB.TabIndex = 0;
            this.lblCityB.Text = "City:";
            // 
            // txtCityB
            // 
            this.txtCityB.Location = new System.Drawing.Point(109, 205);
            this.txtCityB.Name = "txtCityB";
            this.txtCityB.Size = new System.Drawing.Size(137, 20);
            this.txtCityB.TabIndex = 9;
            // 
            // lblZipB
            // 
            this.lblZipB.AutoSize = true;
            this.lblZipB.BackColor = System.Drawing.Color.Transparent;
            this.lblZipB.ForeColor = System.Drawing.Color.White;
            this.lblZipB.Location = new System.Drawing.Point(265, 208);
            this.lblZipB.Name = "lblZipB";
            this.lblZipB.Size = new System.Drawing.Size(87, 13);
            this.lblZipB.TabIndex = 0;
            this.lblZipB.Text = "Zip/Postal Code:";
            // 
            // txtZipB
            // 
            this.txtZipB.Location = new System.Drawing.Point(358, 205);
            this.txtZipB.Name = "txtZipB";
            this.txtZipB.Size = new System.Drawing.Size(137, 20);
            this.txtZipB.TabIndex = 10;
            // 
            // lblStateB
            // 
            this.lblStateB.AutoSize = true;
            this.lblStateB.BackColor = System.Drawing.Color.Transparent;
            this.lblStateB.ForeColor = System.Drawing.Color.White;
            this.lblStateB.Location = new System.Drawing.Point(68, 237);
            this.lblStateB.Name = "lblStateB";
            this.lblStateB.Size = new System.Drawing.Size(35, 13);
            this.lblStateB.TabIndex = 0;
            this.lblStateB.Text = "State:";
            // 
            // cmbStateB
            // 
            this.cmbStateB.AutoCompleteCustomSource.AddRange(new string[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois ",
            "Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana ",
            "Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania ",
            "Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
            this.cmbStateB.FormattingEnabled = true;
            this.cmbStateB.Items.AddRange(new object[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois ",
            "Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana ",
            "Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania ",
            "Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
            this.cmbStateB.Location = new System.Drawing.Point(109, 234);
            this.cmbStateB.Name = "cmbStateB";
            this.cmbStateB.Size = new System.Drawing.Size(137, 21);
            this.cmbStateB.TabIndex = 11;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.BackColor = System.Drawing.Color.Transparent;
            this.lblShipping.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.lblShipping.ForeColor = System.Drawing.Color.White;
            this.lblShipping.Location = new System.Drawing.Point(225, 283);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(105, 32);
            this.lblShipping.TabIndex = 0;
            this.lblShipping.Text = "Shipping";
            // 
            // lblLastS
            // 
            this.lblLastS.AutoSize = true;
            this.lblLastS.BackColor = System.Drawing.Color.Transparent;
            this.lblLastS.ForeColor = System.Drawing.Color.White;
            this.lblLastS.Location = new System.Drawing.Point(44, 341);
            this.lblLastS.Name = "lblLastS";
            this.lblLastS.Size = new System.Drawing.Size(61, 13);
            this.lblLastS.TabIndex = 0;
            this.lblLastS.Text = "Last Name:";
            // 
            // lblFirstS
            // 
            this.lblFirstS.AutoSize = true;
            this.lblFirstS.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstS.ForeColor = System.Drawing.Color.White;
            this.lblFirstS.Location = new System.Drawing.Point(292, 341);
            this.lblFirstS.Name = "lblFirstS";
            this.lblFirstS.Size = new System.Drawing.Size(60, 13);
            this.lblFirstS.TabIndex = 24;
            this.lblFirstS.Text = "First Name:";
            // 
            // lblAddressS
            // 
            this.lblAddressS.AutoSize = true;
            this.lblAddressS.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressS.ForeColor = System.Drawing.Color.White;
            this.lblAddressS.Location = new System.Drawing.Point(55, 370);
            this.lblAddressS.Name = "lblAddressS";
            this.lblAddressS.Size = new System.Drawing.Size(48, 13);
            this.lblAddressS.TabIndex = 0;
            this.lblAddressS.Text = "Address:";
            // 
            // lblCityS
            // 
            this.lblCityS.AutoSize = true;
            this.lblCityS.BackColor = System.Drawing.Color.Transparent;
            this.lblCityS.ForeColor = System.Drawing.Color.White;
            this.lblCityS.Location = new System.Drawing.Point(76, 400);
            this.lblCityS.Name = "lblCityS";
            this.lblCityS.Size = new System.Drawing.Size(27, 13);
            this.lblCityS.TabIndex = 0;
            this.lblCityS.Text = "City:";
            // 
            // lblZipS
            // 
            this.lblZipS.AutoSize = true;
            this.lblZipS.BackColor = System.Drawing.Color.Transparent;
            this.lblZipS.ForeColor = System.Drawing.Color.White;
            this.lblZipS.Location = new System.Drawing.Point(265, 400);
            this.lblZipS.Name = "lblZipS";
            this.lblZipS.Size = new System.Drawing.Size(87, 13);
            this.lblZipS.TabIndex = 0;
            this.lblZipS.Text = "Zip/Postal Code:";
            // 
            // lblStateS
            // 
            this.lblStateS.AutoSize = true;
            this.lblStateS.BackColor = System.Drawing.Color.Transparent;
            this.lblStateS.ForeColor = System.Drawing.Color.White;
            this.lblStateS.Location = new System.Drawing.Point(68, 431);
            this.lblStateS.Name = "lblStateS";
            this.lblStateS.Size = new System.Drawing.Size(35, 13);
            this.lblStateS.TabIndex = 0;
            this.lblStateS.Text = "State:";
            // 
            // txtLastS
            // 
            this.txtLastS.Location = new System.Drawing.Point(109, 338);
            this.txtLastS.Name = "txtLastS";
            this.txtLastS.Size = new System.Drawing.Size(137, 20);
            this.txtLastS.TabIndex = 14;
            // 
            // txtFirstS
            // 
            this.txtFirstS.Location = new System.Drawing.Point(358, 338);
            this.txtFirstS.Name = "txtFirstS";
            this.txtFirstS.Size = new System.Drawing.Size(137, 20);
            this.txtFirstS.TabIndex = 15;
            // 
            // txtAddressS
            // 
            this.txtAddressS.Location = new System.Drawing.Point(109, 367);
            this.txtAddressS.Name = "txtAddressS";
            this.txtAddressS.Size = new System.Drawing.Size(386, 20);
            this.txtAddressS.TabIndex = 16;
            // 
            // txtCityS
            // 
            this.txtCityS.Location = new System.Drawing.Point(109, 397);
            this.txtCityS.Name = "txtCityS";
            this.txtCityS.Size = new System.Drawing.Size(137, 20);
            this.txtCityS.TabIndex = 17;
            // 
            // txtZipS
            // 
            this.txtZipS.Location = new System.Drawing.Point(358, 397);
            this.txtZipS.Name = "txtZipS";
            this.txtZipS.Size = new System.Drawing.Size(137, 20);
            this.txtZipS.TabIndex = 18;
            // 
            // txtPhoneS
            // 
            this.txtPhoneS.Location = new System.Drawing.Point(358, 428);
            this.txtPhoneS.Name = "txtPhoneS";
            this.txtPhoneS.Size = new System.Drawing.Size(137, 20);
            this.txtPhoneS.TabIndex = 20;
            // 
            // txtPhoneB
            // 
            this.txtPhoneB.Location = new System.Drawing.Point(358, 237);
            this.txtPhoneB.Name = "txtPhoneB";
            this.txtPhoneB.Size = new System.Drawing.Size(137, 20);
            this.txtPhoneB.TabIndex = 12;
            // 
            // lblPhoneB
            // 
            this.lblPhoneB.AutoSize = true;
            this.lblPhoneB.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneB.ForeColor = System.Drawing.Color.White;
            this.lblPhoneB.Location = new System.Drawing.Point(271, 240);
            this.lblPhoneB.Name = "lblPhoneB";
            this.lblPhoneB.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneB.TabIndex = 0;
            this.lblPhoneB.Text = "Phone Number:";
            // 
            // lblPhoneS
            // 
            this.lblPhoneS.AutoSize = true;
            this.lblPhoneS.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneS.ForeColor = System.Drawing.Color.White;
            this.lblPhoneS.Location = new System.Drawing.Point(271, 431);
            this.lblPhoneS.Name = "lblPhoneS";
            this.lblPhoneS.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneS.TabIndex = 0;
            this.lblPhoneS.Text = "Phone Number:";
            // 
            // cmbStateS
            // 
            this.cmbStateS.FormattingEnabled = true;
            this.cmbStateS.Items.AddRange(new object[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois ",
            "Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana ",
            "Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania ",
            "Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
            this.cmbStateS.Location = new System.Drawing.Point(109, 428);
            this.cmbStateS.Name = "cmbStateS";
            this.cmbStateS.Size = new System.Drawing.Size(137, 21);
            this.cmbStateS.TabIndex = 19;
            // 
            // chkSame
            // 
            this.chkSame.AutoSize = true;
            this.chkSame.BackColor = System.Drawing.Color.Transparent;
            this.chkSame.ForeColor = System.Drawing.Color.White;
            this.chkSame.Location = new System.Drawing.Point(84, 297);
            this.chkSame.Name = "chkSame";
            this.chkSame.Size = new System.Drawing.Size(97, 17);
            this.chkSame.TabIndex = 13;
            this.chkSame.Text = "Same as Billing";
            this.chkSame.UseVisualStyleBackColor = false;
            this.chkSame.CheckedChanged += new System.EventHandler(this.chkSame_CheckedChanged);
            // 
            // linklblTerms
            // 
            this.linklblTerms.AutoSize = true;
            this.linklblTerms.BackColor = System.Drawing.Color.Transparent;
            this.linklblTerms.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linklblTerms.Location = new System.Drawing.Point(246, 494);
            this.linklblTerms.Name = "linklblTerms";
            this.linklblTerms.Size = new System.Drawing.Size(109, 13);
            this.linklblTerms.TabIndex = 21;
            this.linklblTerms.TabStop = true;
            this.linklblTerms.Text = "Terms and Conditions";
            this.linklblTerms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblTerms_LinkClicked);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(378, 488);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(117, 25);
            this.btnPurchase.TabIndex = 23;
            this.btnPurchase.Text = "Confirm Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(109, 489);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(68, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(441, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "In order to continue with your purchase, please enter in your billing and shippin" +
    "g information. ";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 534);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.linklblTerms);
            this.Controls.Add(this.chkSame);
            this.Controls.Add(this.cmbStateS);
            this.Controls.Add(this.lblPhoneS);
            this.Controls.Add(this.lblPhoneB);
            this.Controls.Add(this.txtPhoneB);
            this.Controls.Add(this.txtPhoneS);
            this.Controls.Add(this.txtZipS);
            this.Controls.Add(this.txtCityS);
            this.Controls.Add(this.txtAddressS);
            this.Controls.Add(this.txtFirstS);
            this.Controls.Add(this.txtLastS);
            this.Controls.Add(this.lblStateS);
            this.Controls.Add(this.lblZipS);
            this.Controls.Add(this.lblCityS);
            this.Controls.Add(this.lblAddressS);
            this.Controls.Add(this.lblFirstS);
            this.Controls.Add(this.lblLastS);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.cmbStateB);
            this.Controls.Add(this.lblStateB);
            this.Controls.Add(this.txtZipB);
            this.Controls.Add(this.lblZipB);
            this.Controls.Add(this.txtCityB);
            this.Controls.Add(this.lblCityB);
            this.Controls.Add(this.txtAddressB);
            this.Controls.Add(this.lblAddressB);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbCardType);
            this.Controls.Add(this.txtSecCode);
            this.Controls.Add(this.txtCardNum);
            this.Controls.Add(this.txtFirstB);
            this.Controls.Add(this.txtLastB);
            this.Controls.Add(this.lblSecCode);
            this.Controls.Add(this.lblBilling);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblFirstB);
            this.Controls.Add(this.lblLastB);
            this.Name = "Billing";
            this.Text = "Payment Information";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastB;
        private System.Windows.Forms.Label lblFirstB;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.Label lblSecCode;
        private System.Windows.Forms.TextBox txtLastB;
        private System.Windows.Forms.TextBox txtFirstB;
        private System.Windows.Forms.TextBox txtSecCode;
        private System.Windows.Forms.ComboBox cmbCardType;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label lblAddressB;
        private System.Windows.Forms.TextBox txtAddressB;
        private System.Windows.Forms.Label lblCityB;
        private System.Windows.Forms.TextBox txtCityB;
        private System.Windows.Forms.Label lblZipB;
        private System.Windows.Forms.TextBox txtZipB;
        private System.Windows.Forms.Label lblStateB;
        private System.Windows.Forms.ComboBox cmbStateB;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblLastS;
        private System.Windows.Forms.Label lblFirstS;
        private System.Windows.Forms.Label lblAddressS;
        private System.Windows.Forms.Label lblCityS;
        private System.Windows.Forms.Label lblZipS;
        private System.Windows.Forms.Label lblStateS;
        private System.Windows.Forms.TextBox txtLastS;
        private System.Windows.Forms.TextBox txtFirstS;
        private System.Windows.Forms.TextBox txtAddressS;
        private System.Windows.Forms.TextBox txtCityS;
        private System.Windows.Forms.TextBox txtZipS;
        private System.Windows.Forms.TextBox txtPhoneS;
        private System.Windows.Forms.TextBox txtPhoneB;
        private System.Windows.Forms.Label lblPhoneB;
        private System.Windows.Forms.Label lblPhoneS;
        private System.Windows.Forms.ComboBox cmbStateS;
        private System.Windows.Forms.CheckBox chkSame;
        private System.Windows.Forms.LinkLabel linklblTerms;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label21;
    }
}