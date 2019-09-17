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
        List<string> allInfos = new List<string> {  };

        
        
        private void ShowInfo()
        {
            purchaseRichTextBox.Text = " ";
            string see = " ";
            allInfos.AddRange(names);
            allInfos.AddRange(numbers);
            allInfos.AddRange(addresses);
            allInfos.AddRange(comboBoxItems);
            //allInfo.AddRange(Convert.ToInt32(quantities));
            int totalPrice = 0;
            for(int i=0;i<names.Count();i++)
            {
                see +="\nName: " + names[i]+"\n";
                see += "Number: " + numbers[i] + "\n";
                see += "Address: " + addresses[i] + "\n";
                see += "Order: " + comboBoxItems[i] + "\n";
                see += "Quantity: " + quantities[i] + "\n";
                for (int j = 0; j < quantities.Count(); j++)
                {

                    if (comboBoxItems[j] == "Black")
                    {
                        totalPrice = quantities[j] * 120;
                    }
                    else if (comboBoxItems[i] == "Cold")
                    {
                        totalPrice = quantities[j] * 100;
                    }
                    else if (comboBoxItems[i] == "Hot")
                    {
                        totalPrice = quantities[j] * 90;
                    }
                    else if (comboBoxItems[i] == "Regular")
                    {
                        totalPrice = quantities[j] * 80;
                    }
                }
            }
            /*for(int i=0;i<numbers.Count();i++)
            {
                see +="Number: "+ numbers[i]+"\n";
            }*/
            /*foreach (string address in addresses)
            {
                see += "Address: " + address + "\n";
            }
            foreach (string order in comboBoxItems)
            {
                see += "Order: " + order + "\n";
            }
            foreach (int quantity in quantities)
            {
                see += "Quantity: " + quantity + "\n";
            }*/
            purchaseRichTextBox.AppendText(see+totalPrice);


        }


        private void AddInfo()
        {
            purchaseRichTextBox.Text = "Purchase Information";
            /*List<string> names = new List<string> { };
            List<string> numbers = new List<string> { };
            List<string> addresses = new List<string> { };
            List<string> comboBoxItems = new List<string> { };
            List<int> quantities = new List<int> { };*/
            names.Add(nameTextBox.Text);
            numbers.Add(ContactNumberTextBox.Text);
            addresses.Add(addressTextBox.Text);

            comboBoxItems.Add(itemComboBox.Text);

            
            quantities.Add(Convert.ToInt32(quantityTextBox.Text));

            string seeInfo = " ";
            int totalPrice = 0;
            /* foreach (string name in names)
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
             }*/
            for (int i = 0; i < names.Count(); i++)
            {
                seeInfo += "Name: " + names[i] + "\n";
                seeInfo += "Number: " + numbers[i] + "\n";
                seeInfo += "Address: " + addresses[i] + "\n";
                seeInfo += "Order: " + comboBoxItems[i] + "\n";
                seeInfo += "Quantity: " + quantities[i] + "\n";


            }


                if (itemComboBox.Text == "Black")
                {
                    totalPrice = quantities[0] * 120;
                }
                else if (itemComboBox.Text == "Cold")
                {
                    totalPrice = quantities[0] * 100;
                }
                else if (itemComboBox.Text == "Hot")
                {
                    totalPrice = quantities[0] * 90;
                }
                else if (itemComboBox.Text == "Regular")
                {
                    totalPrice = quantities[0] * 80;
                }
            
            purchaseRichTextBox.AppendText("\n" + seeInfo + "Total Price: " + totalPrice);
            // MessageBox.Show("\n" + seeInfo + "\nTotal Price: " + totalPrice);
           // purchaseRichTextBox.Text = "Purchase Information\n";

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
            //purchaseRichTextBox.Text = " ";
            
        }
    }
}
