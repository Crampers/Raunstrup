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
        int newCustomerID;
        public Form_Customer_Create()
        {
            InitializeComponent();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            cc.CreateCustomer(textBox_FirstName.Text, textBox_SirName.Text, textBox_Adress.Text, Convert.ToInt32(textBox_PostalCode.Text), Convert.ToInt32(textBox_Phone.Text));
            //this.Close();
        }
    }
}
