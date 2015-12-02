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
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            cc.CreateCustomer(textBox_FirstName.Text, textBox_SirName.Text);
            this.Close();
        }
    }
}
