using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_CoffeShop_List
{
    
    public partial class CoffeeShopHome : Form
    {

        List<string> names = new List<string> { };
        List<string> numbers = new List<string> { };
        List<string> addresses = new List<string> { };
        List<string> comboBoxItems = new List<string> { };
        List<int> quantities = new List<int> { };
        List<int> totalPrices = new List<int> { };
        
        
        private void ShowInfo()
        {
            purchaseRichTextBox.Text = "Purchase Information";
            string see = " ";
            for(int i=0;i<names.Count();i++)
            {
                see +="\nName: " + names[i]+"\n";
                see += "Number: " + numbers[i] + "\n";
                see += "Address: " + addresses[i] + "\n";
                see += "Order: " + comboBoxItems[i] + "\n";
                see += "Quantity: " + quantities[i] + "\n";
                see +="Total Price: "+totalPrices[i] + "\n";
            }
            
            purchaseRichTextBox.Text+=see;
        }


        private void AddInfo(string cNumber, int quantity, string item)
        {
            //int totalPrice = 0;
            names.Add(nameTextBox.Text);        
            numbers.Add(cNumber);
            addresses.Add(addressTextBox.Text);
            comboBoxItems.Add(item);
            quantities.Add(quantity);

            if (item == "Black")
            {
                totalPrices.Add(quantity * 120);
            }
            else if (item == "Cold")
            {

                totalPrices.Add(quantity * 100);
            }
            else if (item == "Hot")
            {
                totalPrices.Add(quantity * 90);

            }
            else if (item == "Regular")
            {
                totalPrices.Add(quantity * 80);

            }
            string seeInfo = " ";
            
            for (int i = 0; i < names.Count(); i++)
            {
                seeInfo += "\nName: " + names[i] + "\n";
                seeInfo += "Number: " + numbers[i] + "\n";
                seeInfo += "Address: " + addresses[i] + "\n";
                seeInfo += "Order: " + comboBoxItems[i] + "\n";
                seeInfo += "Quantity: " + quantities[i] + "\n";
                seeInfo += "Total Price: " + totalPrices[i] + "\n";

            }
            purchaseRichTextBox.Text +=seeInfo;
            // MessageBox.Show("\n" + seeInfo + "\nTotal Price: " + totalPrice);
            //purchaseRichTextBox.Text = " ";

        }
        public CoffeeShopHome()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            ShowInfo();

        }
              
               
        private void saveButton_Click(object sender, EventArgs e)
        {
            //purchaseRichTextBox.Text = "Purchase Information";
            if (numbers.Contains(contactNumberTextBox.Text) == true)
            {
                MessageBox.Show("Number Already Exists");
            }
            else if (itemComboBox.Text=="Select An Item")
            {
                MessageBox.Show("Items Must Be Selected");
            }
            else if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Quantity Can't Be Empty");

            }
            
            else
            {
                // Convert.ToInt32(quantityTextBox.Text);
             AddInfo(contactNumberTextBox.Text, Convert.ToInt32(quantityTextBox.Text), itemComboBox.Text);
                

            }
            
            nameTextBox.Text = " ";
            contactNumberTextBox.Text = " ";
            addressTextBox.Text = " ";
            itemComboBox.Text = "Select An Item";
            quantityTextBox.Text = " ";
            
            
        }
    }
}
