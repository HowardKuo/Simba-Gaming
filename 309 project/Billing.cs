using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _309_Project
{
    public partial class Billing : Form
    {


        public Billing()
        {
            InitializeComponent();
        }
        private void chkSame_CheckedChanged(object sender, EventArgs e)
        {
            //copying data from billing to shipment
            if (chkSame.Checked == false)
            {
                txtLastS.Text = null; 
                txtLastS.Text = null;
                txtFirstS.Text = null;
                txtAddressS.Text = null;
                txtCityS.Text = null;
                txtZipS.Text = null;
                cmbStateS.Text = null;
                txtPhoneS.Text = null;
               
            }
            else if (chkSame.Checked == true)
            {
                txtLastS.Text = txtLastB.Text; 
                txtFirstS.Text = txtFirstB.Text;
                txtAddressS.Text = txtAddressB.Text;
                txtCityS.Text = txtCityB.Text;
                txtZipS.Text = txtZipB.Text;
                cmbStateS.Text = cmbStateB.Text;
                txtPhoneS.Text = txtPhoneB.Text;
            }

        }


        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtLastB.Text != "" && txtFirstB.Text != "" && cmbCardType.Text != "" && 
                txtCardNum.Text != "" && cmbMonth.Text != "" && cmbYear.Text != "" && 
                txtSecCode.Text != "" && txtAddressB.Text != "" && txtCityB.Text != "" && 
                txtZipB.Text != "" && cmbStateB.Text != "" && txtPhoneB.Text != "" && 
                txtLastS.Text != "" && txtFirstS.Text != "" && txtAddressS.Text != "" && txtCityS.Text != "" && 
                txtZipS.Text != "" && cmbStateS.Text != "" && txtPhoneS.Text != "")
            {
                //creating file stream to create an order
                FileStream outFile = new FileStream("Order.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outFile);

                //recording data to text file and go to confirm purchase page


                writer.WriteLine(txtLastB.Text);
                writer.WriteLine(txtFirstB.Text);
                writer.WriteLine(cmbCardType.Text);
                writer.WriteLine(txtCardNum.Text);
                writer.WriteLine(cmbMonth.Text);
                writer.WriteLine(cmbYear.Text);
                writer.WriteLine(txtSecCode.Text);
                writer.WriteLine(txtAddressB.Text);
                writer.WriteLine(txtCityB.Text);
                writer.WriteLine(txtZipB.Text);
                writer.WriteLine(cmbStateB.Text);
                writer.WriteLine(txtPhoneB.Text);
                writer.WriteLine(txtLastS.Text);
                writer.WriteLine(txtFirstS.Text);
                writer.WriteLine(txtAddressS.Text);
                writer.WriteLine(txtCityS.Text);
                writer.WriteLine(txtZipS.Text);
                writer.WriteLine(cmbStateS.Text);
                writer.WriteLine(txtPhoneS.Text);


                //close streamfile
                writer.Close();
                outFile.Close();

                OrderConfirmation secondForm = new OrderConfirmation();
                secondForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Fields are missing. Make sure to fill in all fields.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //close checkout page
            Close();
        }

        private void linklblTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //terms and conditions pop up text document
            System.Diagnostics.Process.Start
                ("notepad.exe", "TermsAndConditions.txt");
               
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            // This code loads in the users' first and last name. 

            // Declare Variables
            string firstName;
            string lastName;

            // Open FileStream
            const string FILENAME = "Session.txt";
            FileStream inFile2 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(inFile2);

            // Read in Data
            firstName = reader2.ReadLine();
            lastName = reader2.ReadLine();

            // Apply data to text boxes
            txtFirstB.Text = firstName;
            txtLastB.Text = lastName;

            // Close File
            inFile2.Close();
            reader2.Close();
        }


    }
}
