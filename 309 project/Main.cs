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
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Initialize Public Variables
        public string activeCategory;   // Stores the current category
        public string[] gameFiles = { "Action.txt", "Adventure.txt", "FPS.txt", "RPG.txt", "Online.txt" };    // Parallel Arrays that 
        public string[] categories = { "Action", "Adventure", "FPS", "RPG", "Online" };                       // store category info
        public string title;                         // The name of the currently selected game
        public double price = 0;                     // The price of the currently selected item
        public string[] games = new string[100];     // Stores names of ordered games
        public double[] prices = new double[100];    // Stores prices of ordered games
        public int numOfItems = 0;                   // The number of items ordered so far
        public double total = 0;                     // The total order price
        public string titleCart;                     // The name of the game selected in the cart
        public double priceCart = 0;                 // The name of the price selected in the cart
        public int selectedIndex = 0;                // The location in the Cart listbox
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)  
        {
            // This is the command that updates the form labels when a user selects a different item.    -MB

            // Create Title
            lblTitle.Visible = true;
            title = Convert.ToString(listGames.SelectedItem);
            lblTitle.Text = title;

            // Create Description
            lblDescription.Visible = true;
            lblDescription.Text = activeCategory;
            string game = null;
            bool found = false;

            // Open File
            FileStream inFile = new FileStream(activeCategory, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            // Search for a match
            game = reader.ReadLine();
            while (game != null && found == false)
            {
                if(game == title)
                {
                    lblDescription.Text = reader.ReadLine();
                    price = Convert.ToDouble(reader.ReadLine());
                    lblPrice.Text = price.ToString("C2");

                    found = true;
                }
                else
                {
                    reader.ReadLine();
                    reader.ReadLine();
                    game = reader.ReadLine();
                }
            }

            // Close File
            reader.Close();
            inFile.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            LoadGames("Action.txt");
        }

        private void btnAdventure_Click(object sender, EventArgs e)
        {
            LoadGames("Adventure.txt");
        }

        private void btnFPS_Click(object sender, EventArgs e)
        {
            LoadGames("FPS.txt");
        }

        private void btnRPG_Click(object sender, EventArgs e)
        {
            LoadGames("RPG.txt");
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            LoadGames("Online.txt");
        }

        private void LoadGames(string z)          
        {
            // This custom method updates the form.   -MB

            // Clear ListBox, Sort Items
            this.listGames.Items.Clear();
            this.listGames.Sorted = true;

            // Declare Variables
            string[] games = new string[100];
            string[] descriptions = new string[100];
            string[] prices = new string[100];
            string FILENAME = z;
            activeCategory = FILENAME;

            // Open File
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            // Load Games into Array
            games[0] = reader.ReadLine();
            int x = 0;
            while (games[x] != null)
            {
                descriptions[x] = reader.ReadLine();
                prices[x] = reader.ReadLine();
                this.listGames.Items.AddRange(new object[] {      // Sets listbox vales 
                games[x] });
                ++x;
                games[x] = reader.ReadLine();
            }

            // Update Category Title
            for (int y = 0; y < 5; ++y)
            {
                if (FILENAME == gameFiles[y])
                {
                    lblCategory.Text = categories[y];
                }
            }
            
            // Close File
            reader.Close();
            inFile.Close(); 

            // Select top item
            this.listGames.SelectedIndex = 0;
        }

        private void UpdateSession()
        {
            // Read User Session Info
            const string FILENAME = "Session.txt";
            string username;
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            username = reader.ReadLine();
            lblWelcomeUser.Text = ("Welcome, " + username + "!");
            reader.Close();
            inFile.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UpdateSession();  

            LoadGames("Action.txt");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart();    // Adds items to the cart using a button
        }

        private void DoubleClick(object sender, EventArgs e)
        {
            AddToCart();    // Adds items to the cart on a Double Click
        }
        

        private void AddToCart()
        {
            // Check if game is already in the cart
            bool copy = false;
            for(int x = 0; x < 100; ++x)
            {
                if(title == games[x])
                {
                    copy = true;
                    MessageBox.Show("Game Already Added.");
                }                    
            }

            // If game is not added yet, add it to the array
            if(copy == false)
            {
                games[numOfItems] = title;
                prices[numOfItems] = price;
                ++numOfItems;

                // Update ListBox
                this.lstCart.Items.Clear();
                for (int y = 0; y < 100; ++y)
                {
                    if (games[y] != null)
                        this.lstCart.Items.Add(games[y]);
                }
            }

            // Calculate Total
            total = 0;
            for (int y = 0; y < 100; ++y )
                total += prices[y];
            lblTotal.Text = total.ToString("C2");
        }

        private void Delete(object sender, EventArgs e)
        {
            // Search for an array value matching the listBox and delete it. 
            int b = 0;
            bool found = false;
            while (found == false)
            {
                if ((titleCart) == games[b])
                {
                    games[b] = null;
                    prices[b] = 0;
                    this.lstCart.Items.RemoveAt(selectedIndex);
                    found = true;
                }
                ++b;
            }
            
            // Recalculate Total
            total = 0;
            for (int y = 0; y < 100; ++y)
                total += prices[y];
            lblTotal.Text = total.ToString("C2");
        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = Convert.ToInt32(lstCart.SelectedIndex);    // Sets the public selectedIndex variable
            titleCart = Convert.ToString(lstCart.SelectedItem);        // Sets the public titleCart variable
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Billing secondForm = new Billing();
            secondForm.Show();

            //open new stream
            FileStream outFile = new FileStream("CartItems.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            //record data to session.txt
            writer.WriteLine(total);
            int itemsNum = lstCart.Items.Count;          
            for (int z = 0; z < itemsNum; z++)
            {
                
                writer.WriteLine(lstCart.Items[z].ToString());

            }

            writer.Close();
            outFile.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
