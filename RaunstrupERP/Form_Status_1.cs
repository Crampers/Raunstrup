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
    public partial class Form_Status_1 : Form
    {
        ControllerCatalog cc = new ControllerCatalog();

        public Form_Status_1()
        {
            InitializeComponent();
            cc.AddOrder(new OfferDescription(1, new TaskCatalog()));
            TaskCatalog tc1 = new TaskCatalog();
            tc1.AddTask("Test");
            tc1.AddTask("Installation af vindue");
            tc1.AddTask("Installation af vindue 2");
            tc1.AddTask("Installation af vindue 3");
            tc1.AddTask("Installation af vindue 4");
            tc1.AddTask("Installation af vindue 5");
            tc1.AddTaskItems(1, new ItemDescription("Test Item", 1, 20, 20), 10);
            cc.GetOrder(2).GetOffer().SetWorkTasks(tc1);
            cc.GetOrder(1).GetOffer().SetBuyer(cc.GetCustommer(1));
            cc.GetOrder(2).GetOffer().SetBuyer(cc.GetCustommer(2));
        }

        private void Form_Status_1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button_findOrder_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(maskedTextBox_OrderID.Text); /*Converts string to ID*/
            String customerName = cc.GetOrder(orderID).GetOffer().GetBuyer().getFirstName() + " " + cc.GetOrder(orderID).GetOffer().GetBuyer().getSurName();
            textBox_CustomerName.Text = customerName;
            listBox1.Items.Clear();
            foreach (TaskDescription item in cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTasks())
            {
                listBox1.Items.Add(item.GetDesc());
            }
        }
    }
}
