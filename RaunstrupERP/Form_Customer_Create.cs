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
    public partial class Form_Customer_Create : Form
    {
        ControllerCatalog cc = new ControllerCatalog();
        public Form_Customer_Create()
        {
            InitializeComponent();
            foreach (int item in cc.GetPostalCodes())
            {
                comboBox_SelectPostal.Items.Add(item);
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            cc.CreateCustomer(textBox_FirstName.Text, textBox_SirName.Text, textBox_Adress.Text, Convert.ToInt32(comboBox_SelectPostal.SelectedItem), Convert.ToInt32(textBox_Phone.Text));
            this.Close();
        }

        private void comboBox_SelectPostal_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_CityName.Text = cc.GetCityName(Convert.ToInt32(comboBox_SelectPostal.SelectedItem));
        }
    }
}
