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
    public partial class Form_Items_1 : Form
    {
        ControllerCatalog cc = new ControllerCatalog();
        ItemDescription currentItem = null;
        public Form_Items_1()
        {
            InitializeComponent();
        }
        //FIND ITEM
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            currentItem = cc.FindItem(Convert.ToInt32(numericUpDown1.Value));
            if (currentItem != null)
            {
                richTextBox_Desc.Text = currentItem.GetDesc();
                textBox_SalesPrice.Text = currentItem.GetSalesPrice().ToString();
                textBox_shopsPrice.Text = currentItem.GetShopsPrice().ToString();
            }
            else
            {
                richTextBox_Desc.Text = "";
                textBox_SalesPrice.Text = "";
                textBox_shopsPrice.Text = "";
            }
        }
        //TOGGLE BUTTON
        private void button_ToggleEdit_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                numericUpDown1.Enabled = false;
                button_ToggleEdit.Text = "Gem";
                panel1.Visible = true;
            }
            else
            {
                numericUpDown1.Enabled = true;
                button_ToggleEdit.Text = "Rediger";
                panel1.Visible = false;
            }
        }
        //EDIT DESCRIPTION
        private void button_EditDesc_Click(object sender, EventArgs e)
        {
            if (richTextBox_EditDesc.Visible == false)
            {
                button_EditDesc.Text = "Gem";
                richTextBox_EditDesc.Text = richTextBox_Desc.Text;
                richTextBox_EditDesc.Visible = true;
                richTextBox_Desc.Visible = false;
            }
            else
            {
                cc.AlterItemDesc(currentItem.GetID(), richTextBox_EditDesc.Text);
                button_EditDesc.Text = "Rediger";
                richTextBox_Desc.Text = richTextBox_EditDesc.Text;
                richTextBox_EditDesc.Visible = false;
                richTextBox_Desc.Visible = true;
            }
        }
        //EDIT SALESPRICE
        private void button_EditSalesPrice_Click(object sender, EventArgs e)
        {
            if (numericUpDown_EditSalesPrice.Visible == false)
            {
                button_EditSalesPrice.Text = "Gem";
                textBox_SalesPrice.Visible = false;
                numericUpDown_EditSalesPrice.Visible = true;
                numericUpDown_EditSalesPrice.Value = Convert.ToDecimal(textBox_SalesPrice.Text);
            }
            else
            {
                cc.AlterItemMSRP(currentItem.GetID(), Convert.ToDouble(numericUpDown_EditSalesPrice.Value));
                button_EditSalesPrice.Text = "Rediger";
                textBox_SalesPrice.Visible = true;
                textBox_SalesPrice.Text = numericUpDown_EditSalesPrice.Value.ToString();
                numericUpDown_EditSalesPrice.Visible = false;
            }
        }
        //EDIT SHOPSPRICE
        private void button_EditShopsPrice_Click(object sender, EventArgs e)
        {
            if (numericUpDown_EditPurchasePrice.Visible == false)
            {
                button_EditShopsPrice.Text = "Gem";
                textBox_shopsPrice.Visible = false;
                numericUpDown_EditPurchasePrice.Visible = true;
                numericUpDown_EditPurchasePrice.Value = Convert.ToDecimal(textBox_shopsPrice.Text);
            }
            else
            {
                cc.AlterItemPurchasingPrice(currentItem.GetID(), Convert.ToDouble(numericUpDown_EditPurchasePrice.Value));
                button_EditShopsPrice.Text = "Rediger";
                textBox_shopsPrice.Visible = true;
                textBox_shopsPrice.Text = numericUpDown_EditPurchasePrice.Value.ToString();
                numericUpDown_EditPurchasePrice.Visible = false;
            }
        }

        private void button_CreateItem_Click(object sender, EventArgs e)
        {
            Form_Items_Create ItemCreate = new Form_Items_Create();
            ItemCreate.ShowDialog();
        }
    }
}
