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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Stores an arrray index
        public int i = 0;

        //Declare array for imageList
        public string[] imageList = new string[5] {"Final Fantasy X, $49.99!", "World of Warcraft, $14.99!", "Call of Duty: Ghosts, $59.99!", "League of Legends, $12.99!", "Starcraft II: Wings of Liberty, $59.99!"};

        // Stores an array index
        public int x = 0; 

        // Declare String Arrays to Store Info during Registration
        public string[] userName = new string[1000];
        public string[] password = new string[1000];
        public string[] firstName = new string[1000];
        public string[] lastName = new string[1000];

        // Stores whether the user went to the Registration page or not
        bool registered = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* This code checks to see if the strings need to be updated, checks the user's credentials
             * against the credentials stored in the string, and finally allows the user to log in while
             * storing their session information in a text file.   -MB    */

            // Declare Variables
            string userNameInput, passwordInput;
            bool found = false;

            // Read User Data
            userNameInput = txtUserName.Text;
            passwordInput = txtPassword.Text;

            // Update Arrays if the User Registered
            if(registered == true)
            {
                // Open File
                const string FILENAME = "Login.txt";
                FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);

                // Read in Text File values to Array
                x = 0;
                userName[0] = reader.ReadLine();
                while (userName[x] != null)
                {
                    password[x] = reader.ReadLine();
                    firstName[x] = reader.ReadLine();
                    lastName[x] = reader.ReadLine();
                    ++x;
                    userName[x] = reader.ReadLine();
                }
                
                // Close Files
                reader.Close();
                inFile.Close();
            }

            // Makes sure TextBoxes aren't empty
            if (userNameInput == "")
            {
                lblStar1.Visible = true;
                lblError.Text = "Please enter a username AND password.";
            }
            else
                lblStar1.Visible = false;

            if (passwordInput == "")
            {
                lblStar2.Visible = true;
                lblError.Text = "Please enter a username AND password.";
            }
            else
                lblStar2.Visible = false;

            // Check Credentials for a Match
            int y = 0;
            if (userNameInput != "" && passwordInput != "")
            {             
                while ((userName[y] != null) && (found == false))
                {
                    if ((userNameInput == userName[y]) && (passwordInput == password[y]))
                        found = true;
                    ++y;
                }
            }
            --y;

            // Log User In
            lblError.Visible = true;
            if (found == true)
            {
                // Save User Session Data
                FileStream outFile = new FileStream("Session.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outFile);
                writer.WriteLine(firstName[y]);
                writer.WriteLine(lastName[y]);
                writer.Close();
                outFile.Close();

                // Load New Form
                Main secondForm = new Main();
                secondForm.Show();
                lblError.Text = "Login Successful.";

                // Clear TextBoxes
                txtPassword.Clear();
                txtUserName.Clear();
            }
            else
                lblError.Text = "Match not found.";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Opens the Registration Form 
            Register thirdForm = new Register();
            thirdForm.Show();
            registered = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /* This code loads in the Text file into an array for quick access before the user attempts
             * to log into the program.     -MB    */

            // Open File
            const string FILENAME = "Login.txt";
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            // Read in Text File values to Array
            userName[0] = reader.ReadLine();
            while (userName[x] != null)
            {
                password[x] = reader.ReadLine();
                firstName[x] = reader.ReadLine();
                lastName[x] = reader.ReadLine();
                ++x;
                userName[x] = reader.ReadLine();
            }

            // Close Files
            reader.Close();
            inFile.Close();

            //start image slideshow
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Loading label is visible while first image loads, then disappears
            lblLoading.Visible = false;

            //looping through image array and changing images every 1000 ms
            if (i < 5)
            {
                pictureBox2.Image = imageList1.Images[i];
                lblImageList.Text = imageList[i];
                i++;
            }
            //after loop finishes, restart the array to keep displaying images and prevent system exception errors
            else
            {
                i = 0;
            }

           
        }
    }
}
