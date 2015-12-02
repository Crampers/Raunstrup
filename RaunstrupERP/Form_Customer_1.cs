using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaunstrupERP
{
    public partial class Form_Customer_1 : Form
    {
        private ControllerCatalog cc = new ControllerCatalog();
        private int customerID = 0;
        //private CustomerDBkobling currentCustomer;
        public Form_Customer_1()
        {
            InitializeComponent();
        }

        private void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            button_ToggleEdit.Visible = true;
            customerID = Convert.ToInt32(textBox_CustomerId.Text);
            //currentCustomer = cc.FindCustomer(customerID);

            //FirstName
            textBox_FirstName.Text = cc.FindCustomer(customerID).GetFirstName();
            //SurName
            textBox_SirName.Text = cc.FindCustomer(customerID).GetSurName();
            //Adress
            comboBox_Adresses.Items.Clear();
            foreach (string adress in cc.FindCustomer(customerID).GetAdresses())
            {
                comboBox_Adresses.Items.Add(adress);
            }
            comboBox_Adresses.SelectedItem = comboBox_Adresses.Items[0];
            //Phones
            comboBox_PhoneNumbers.Items.Clear();
            foreach (int number in cc.FindCustomer(customerID).getTlf())
            {
                comboBox_PhoneNumbers.Items.Add(number);
            }
            comboBox_PhoneNumbers.SelectedItem = comboBox_PhoneNumbers.Items[0];
        }
        //CURRENT FIX FOR ADRESS
        private void comboBox_Adresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_CityName.Text = cc.FindCustomer(customerID).getCity()[comboBox_Adresses.SelectedIndex];
            textBox_PostalCode.Text = cc.FindCustomer(customerID).GetPostalCodes()[comboBox_Adresses.SelectedIndex].ToString();
        }

        //TOGGLE EDIT BUTTONS
        private void button_ToggleEdit_Click(object sender, EventArgs e)
        {
            if (panel_Edit.Visible == false)
            {
                button_ToggleEdit.Text = "Færdig";
                textBox_CustomerId.ReadOnly = true;
                button_SearchCustomer.Visible = false;
                panel_Edit.Visible = true;
            }
            else
            {
                button_ToggleEdit.Text = "Rediger";
                textBox_CustomerId.ReadOnly = false;
                button_SearchCustomer.Visible = true;
                panel_Edit.Visible = false;
            }
        }

        //EDIT FIRSTNAME
        private void button_EditFName_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.ReadOnly == true)
            {
                button_EditFName.Text = "Gem";
                textBox_FirstName.ReadOnly = false;
            }
            else
            {
                button_EditFName.Text = "Rediger";
                cc.FindCustomer(customerID).AlterFirstName(textBox_FirstName.Text);
                textBox_FirstName.ReadOnly = true;
            }
        }

        //EDIT SURNAME
        private void button_EditSurName_Click(object sender, EventArgs e)
        {
            if (textBox_SirName.ReadOnly == true)
            {
                button_EditSurName.Text = "Gem";
                textBox_SirName.ReadOnly = false;
            }
            else
            {
                button_EditSurName.Text = "Rediger";
                cc.FindCustomer(customerID).AlterSurname(textBox_SirName.Text);
                textBox_SirName.ReadOnly = true;
            }
        }
        //EDIT SELECTED PHONE NUMBER
        private void button_EditPhone_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Visible == false)
            {
                button_EditPhone.Text = "Gem";
                maskedTextBox1.Text = comboBox_PhoneNumbers.SelectedItem.ToString();
                maskedTextBox1.Visible = true;
            }
            else
            {
                cc.FindCustomer(customerID).AlterPhone(Convert.ToInt32(comboBox_PhoneNumbers.SelectedItem), Convert.ToInt32(maskedTextBox1.Text));
                button_EditPhone.Text = "Rediger";
                maskedTextBox1.Visible = false;
                //Phones (READ AGAIN TO UPDATE FORM)
                comboBox_PhoneNumbers.Items.Clear();
                foreach (int number in cc.FindCustomer(customerID).getTlf())
                {
                    comboBox_PhoneNumbers.Items.Add(number);
                }
                comboBox_PhoneNumbers.SelectedItem = comboBox_PhoneNumbers.Items[0];
            }
        }
        //Create Customer (OPENS NEW WINDOW)
        private void button_CreateCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
