﻿using System;
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
        private List<CustomerAdress> adressList;
        private int customerID = 0;
        //private CustomerDBkobling currentCustomer;
        public Form_Customer_1()
        {
            InitializeComponent();
        }

        private void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            button_ToggleEdit.Visible = true;
            panel_Additions.Visible = true;
            textBox_PostalCode.Text = "";
            customerID = Convert.ToInt32(numericUpDown_CustomerID.Text);
            //currentCustomer = cc.FindCustomer(customerID);

            //FirstName
            textBox_FirstName.Text = cc.FindCustomer(customerID).GetFirstName();
            //SurName
            textBox_SirName.Text = cc.FindCustomer(customerID).GetSurName();
            //Adress
            adressList = cc.FindCustomer(customerID).GetAdresses();
            
            comboBox_Adresses.Items.Clear();
            foreach (CustomerAdress item in cc.FindCustomer(customerID).GetAdresses())
            {
                comboBox_Adresses.Items.Add(item.GetAdress());
                comboBox_Adresses.SelectedItem = item.GetAdress();
            }
            
            //Phones
            comboBox_PhoneNumbers.Items.Clear();
            foreach (int number in cc.FindCustomer(customerID).getTlf())
            {
                comboBox_PhoneNumbers.Items.Add(number);
                comboBox_PhoneNumbers.SelectedItem = number;
            }
        }
        //CURRENT FIX FOR ADRESS
        private void comboBox_Adresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adressList != null)
            {
                textBox_PostalCode.Text = adressList[comboBox_Adresses.SelectedIndex].GetPostalCode().ToString();
            }
            else
            {
                textBox_PostalCode.Text = "";
            }
        }

        //TOGGLE EDIT BUTTONS
        private void button_ToggleEdit_Click(object sender, EventArgs e)
        {
            if (panel_Edit.Visible == false)
            {
                button_ToggleEdit.Text = "Færdig";
                numericUpDown_CustomerID.ReadOnly = true;
                numericUpDown_CustomerID.Enabled = false;
                button_SearchCustomer.Visible = false;
                button_CreateCustomer.Visible = false;
                panel_Additions.Visible = false;
                panel_Edit.Visible = true;
            }
            else
            {
                button_ToggleEdit.Text = "Rediger";
                numericUpDown_CustomerID.ReadOnly = false;
                numericUpDown_CustomerID.Enabled = true;
                button_SearchCustomer.Visible = true;
                button_CreateCustomer.Visible = true;
                panel_Additions.Visible = true;
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
            if (maskedTextBox_PhoneCreate.Visible == false)
            {
                button_EditPhone.Text = "Gem";
                maskedTextBox_PhoneCreate.Text = comboBox_PhoneNumbers.SelectedItem.ToString();
                comboBox_PhoneNumbers.Visible = false;
                maskedTextBox_PhoneCreate.Visible = true;
            }
            else
            {
                cc.FindCustomer(customerID).AlterPhone(Convert.ToInt32(comboBox_PhoneNumbers.SelectedItem), Convert.ToInt32(maskedTextBox_PhoneCreate.Text));
                button_EditPhone.Text = "Rediger";
                maskedTextBox_PhoneCreate.Visible = false;
                comboBox_PhoneNumbers.Visible = true;
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
            Form_Customer_Create createNew = new Form_Customer_Create();
            createNew.ShowDialog();
        }
        //EDIT ADRESS
        private void button_EditAdress_Click(object sender, EventArgs e)
        {
            
        }
        //ADD ADDITIONAL ADRESS
        private void button_AddAdress_Click(object sender, EventArgs e)
        {

        }
        //ADD ADDITIONAL NUMBERS
        private void button_AddNumber_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_PhoneCreate.Visible == false)
            {
                button_AddNumber.Text = "Gem";
                maskedTextBox_PhoneCreate.Text = "";
                maskedTextBox_PhoneCreate.Visible = true;
                comboBox_PhoneNumbers.Visible = false;
            }
            else
            {
                cc.FindCustomer(customerID).AddPhone(Convert.ToInt32(maskedTextBox_PhoneCreate.Text));
                button_AddNumber.Text = "Tilføj";
                maskedTextBox_PhoneCreate.Visible = false;
                comboBox_PhoneNumbers.Visible = true;
            }
        }
    }
}
