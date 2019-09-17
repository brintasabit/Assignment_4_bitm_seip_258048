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


        int index = 0;
        
        private void ShowInfo()
        {
            MessageBox.Show(purchaseRichTextBox.Text);


        }


        private void AddInfo()
        {
             List<string> names = new List<string> { };
             List<string> numbers = new List<string> { };
             List<string> addresses = new List<string> { };
             List<string> comboBoxItems = new List<string> { };
             List<int> quantities = new List<int> { };
            names.Add(nameTextBox.Text);
            numbers.Add(ContactNumberTextBox.Text);
            addresses.Add(addressTextBox.Text);

            comboBoxItems.Add(itemComboBox.Text);


            quantities.Add(Convert.ToInt32(quantityTextBox.Text));

            string seeInfo = " ";
            int totalPrice = 0;
            foreach (string name in names)
            {
                seeInfo += "\nName: " + name;
            }
            foreach (string number in numbers)
            {
                seeInfo += "\nContact Number: " + number;
            }
            foreach (string address in addresses)
            {
                seeInfo += "\nAddress: " + address;
            }
            foreach (string comboBoxItem in comboBoxItems)
            {
                seeInfo += "\nOrder: " + comboBoxItem;
            }
            foreach (int quantity in quantities)
            {
                seeInfo += "\nQuantity: " + quantity;
            }
            if (itemComboBox.Text == "Black")
            {
                totalPrice = quantities[index] * 120;
            }
            else if (itemComboBox.Text == "Cold")
            {
                totalPrice = quantities[index] * 100;
            }
            else if (itemComboBox.Text == "Hot")
            {
                totalPrice = quantities[index] * 90;
            }
            else if (itemComboBox.Text == "Regular")
            {
                totalPrice = quantities[index] * 80;
            }

            purchaseRichTextBox.AppendText("\n" + seeInfo + "\nTotal Price: " + totalPrice);
            
            
            
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
            AddInfo();
            nameTextBox.Text = " ";
            ContactNumberTextBox.Text = " ";
            addressTextBox.Text = " ";
            itemComboBox.Text = "Select An Item";
            quantityTextBox.Text = " ";
           // purchaseRichTextBox.Text = " ";
        }
    }
}
