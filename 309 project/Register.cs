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
    public partial class Register : Form
    {
        // Declare String Arrays to Store Info during Registration
        public string[] userName = new string[1000];
        public string[] password = new string[1000];
        public string[] firstName = new string[1000];
        public string[] lastName = new string[1000];
        public int x;   // Represents the number of users stored

        public Register()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /* This code will read in the user registration information, store it in the next avaliable array 
             * value, and write all the data back to the text file.      -MB    */

            // Declare Variables
            const string FILENAME = "Login.txt";

            // Read User Data
            userName[x] = txtUserName.Text;
            password[x] = txtPassword.Text;
            firstName[x] = txtFirstName.Text;
            lastName[x] = txtLastName.Text;

            // Check Username against Array
            bool userConflict = false;
            for(int z = 0; z < x; z++)
            {
                if (userName[x] == userName[z])
                {
                    userConflict = true;
                    lblError.Text = "Username already exists.";
                }
            }

            // Open File
            FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            // Check for empty text boxes
            lblError.Visible = true;
            if (userName[x] == "")
            {
                lblStarUsername.Visible = true;
                lblError.Text = "Please enter all required fields.";
            }
            else
                lblStarUsername.Visible = false;
            if (password[x] == "")
            {
                lblStarPassword.Visible = true;
                lblError.Text = "Please enter all required fields.";
            }
            else
                lblStarPassword.Visible = false;
            if (firstName[x] == "")
            {
                lblStarFirstName.Visible = true;
                lblError.Text = "Please enter all required fields.";
            }
            else
                lblStarFirstName.Visible = false;
            if (lastName[x] == "")
            {
                lblStarLastName.Visible = true;
                lblError.Text = "Please enter all required fields.";
            }
            else
                lblStarLastName.Visible = false;

            // Write new Registration Info to File
            if ((userName[x] != "") && (password[x] != "") && (firstName[x] != "") && (lastName[x] != "") && (userConflict == false))
            {
                writer.WriteLine(userName[x]);
                writer.WriteLine(password[x]);
                writer.WriteLine(firstName[x]);
                writer.WriteLine(lastName[x]);
                lblError.Text = "Your information has been submitted.";
                ++x; 
            }

            // Close Writer and Read
            writer.Close();
            outFile.Close();
        }

        private Form Login;

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            // Close page
            Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // This code reads in the data from the text file to an array for quick use.     -MB 

            // Open File
            const string FILENAME = "Login.txt";
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            // Read in Text File Data to Array
            userName[0] = reader.ReadLine();
            while (userName[x] != null)
            {
                password[x] = reader.ReadLine();
                firstName[x] = reader.ReadLine();
                lastName[x] = reader.ReadLine();
                ++x;
                userName[x] = reader.ReadLine();
            }

            // Close Reader and inFile
            reader.Close();
            inFile.Close();
        }
    }
}
