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
    public partial class Form_Items_Create : Form
    {
        ControllerCatalog cc = new ControllerCatalog();
        public Form_Items_Create()
        {
            InitializeComponent();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            cc.CreateItem(richTextBox_Desc.Text, Convert.ToDouble(numericUpDown_SalesPrice.Value), Convert.ToDouble(numericUpDown_PurchasePrice.Value));
            MessageBox.Show("Materiale Oprettet!");
            this.Close();
        }
    }
}
