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
        public Form_Customer_1()
        {
            InitializeComponent();
        }

        private void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(textBox_CustomerId.Text);
            textBox_FirstName.Text = cc.FindCustomer(customerID).GetFirstName();
            textBox_SirName.Text = cc.FindCustomer(customerID).GetSurName();
            textBox_Adress.Text = cc.FindCustomer(customerID).GetAdresses()[1];
        }
    }
}
