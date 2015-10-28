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
    public partial class OrderConfirmation : Form
    {
        public OrderConfirmation()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Processed! Returning to Main Page.");
            this.Close();
        }

        private void OrderConfirmation_Load(object sender, EventArgs e)
        {
            // Declare Variables
            //string lastNameB, firstNameB, cardType, cardNum, expMonth, expYear, secCode, addressB, cityB, zipB, stateB, phoneB, lastNameS, firstNameS, addressS, cityS, zipS, stateS, phoneS;

            // Open FileStream to show billing info
            const string FILENAME = "Order.txt";
            FileStream inFile3 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(inFile3);

           

            //read data
            lblLastB.Text = reader3.ReadLine();
            lblFirstB.Text  = reader3.ReadLine();
            lblCardType.Text = reader3.ReadLine();
            lblCardNum.Text = reader3.ReadLine();
            lblExpM.Text = reader3.ReadLine();
            lblExpY.Text = reader3.ReadLine();
            lblSecCode.Text = reader3.ReadLine();
            lblAddressB.Text = reader3.ReadLine();
            lblCityB.Text = reader3.ReadLine();
            lblZipB.Text = reader3.ReadLine();
            lblStateb.Text = reader3.ReadLine();
            lblPhoneB.Text = reader3.ReadLine();
            lblLastS.Text = reader3.ReadLine();
            lblFirstS.Text = reader3.ReadLine();
            lblAddressS.Text = reader3.ReadLine();
            lblCityS.Text = reader3.ReadLine();
            lblZipS.Text = reader3.ReadLine();
            lblStateS.Text = reader3.ReadLine();
            lblPhoneS.Text = reader3.ReadLine();


            //close filestream for billing info
            reader3.Close();
            inFile3.Close();

            //open new streamfile to show cart 
            FileStream inFile4 = new FileStream("CartItems.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader4 = new StreamReader(inFile4);
            double totalPrice = Convert.ToDouble(reader4.ReadLine());
            lblTotal.Text = totalPrice.ToString("C2");
            string gameTitle = reader4.ReadLine();
            while (gameTitle != null)
            {
                lstCart.Items.Add(gameTitle);
                gameTitle = reader4.ReadLine();
            }

            reader4.Close();
            inFile4.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Billing secondForm = new Billing();
            secondForm.Show();
            this.Close();
        }


    }
}
