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
        ControllerCatalog cc = new ControllerCatalog();
        int customerID;
        CustomerDBkobling currentCustomer;
        public Form_Customer_1()
        {
            InitializeComponent();
        }

        private void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            customerID = Convert.ToInt32(textBox_CustomerId.Text);
            currentCustomer = cc.FindCustomer(customerID);
            //FirstName
            textBox_FirstName.Text = currentCustomer.GetFirstName();
            //SurName
            textBox_SirName.Text = currentCustomer.GetSurName();
            //Adress
            foreach (string adress in currentCustomer.GetAdresses())
            {
                comboBox_Adresses.Items.Add(adress);
            }
            comboBox_Adresses.SelectedItem = comboBox_Adresses.Items[0];
            //Postal
            foreach (int postalcode in currentCustomer.GetPostalCodes())
            {
                comboBox_PostalCodes.Items.Add(postalcode);
            }
            comboBox_PostalCodes.SelectedItem = comboBox_PostalCodes.Items[0];
            //City
            foreach (string city in currentCustomer.getCity())
            {
                comboBox_Cities.Items.Add(city);
            }
            comboBox_Cities.SelectedItem = comboBox_Cities.Items[0];
            //Phones
            foreach (int number in currentCustomer.getTlf())
            {
                comboBox_PhoneNumbers.Items.Add(number);
            }
            comboBox_PhoneNumbers.SelectedItem = comboBox_PhoneNumbers.Items[0];
        }
    }
}
