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
    public partial class Form_Main_1 : Form
    {
        ControllerCatalog cc = new ControllerCatalog();
        public Form_Main_1()
        {
            InitializeComponent();
            cc.AddOrder(new OfferDescription(1, new TaskCatalog()));
            TaskCatalog tc1 = new TaskCatalog();
            tc1.AddTask("Test af Singleton!");
            tc1.AddTaskItems(1, new ItemDescription("Test Item", 1, 20, 20), 10);
            cc.GetOrder(1).GetOffer().SetWorkTasks(tc1);
        }

        private void Form_Main_1_Shown(object sender, EventArgs e)
        {

        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Status_1 stat1 = new Form_Status_1();
            stat1.MdiParent = this;
            stat1.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_Order_1 orders = new Form_Order_1();
            orders.MdiParent = this;
            orders.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form_Offer_1 offers = new Form_Offer_1();
            offers.MdiParent = this;
            offers.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form_Customer_1 customers = new Form_Customer_1();
            customers.MdiParent = this;
            customers.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form_Status_1 stat1 = new Form_Status_1();
            stat1.MdiParent = this;
            stat1.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form_Items_1 items = new Form_Items_1();
            items.MdiParent = this;
            items.Show();
        }

        private void ordreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Order_1 orders = new Form_Order_1();
            orders.MdiParent = this;
            orders.Show();
        }

        private void tilbudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Offer_1 offers = new Form_Offer_1();
            offers.MdiParent = this;
            offers.Show();
        }

        private void kundeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Customer_1 customers = new Form_Customer_1();
            customers.MdiParent = this;
            customers.Show();
        }

        private void statusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Status_1 stat1 = new Form_Status_1();
            stat1.MdiParent = this;
            stat1.Show();
        }

        private void materialerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Items_1 items = new Form_Items_1();
            items.MdiParent = this;
            items.Show();
        }

        private void medarbejderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Employee_1 employees = new Form_Employee_1();
            employees.MdiParent = this;
            employees.Show();
        }

        private void håndværkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginToolStripMenuItem.Visible = false;
            craftsmanToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = true;
        }

        private void sælgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginToolStripMenuItem.Visible = false;
            salesStripMenuItem1.Visible = true;
            logoutToolStripMenuItem.Visible = true;
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginToolStripMenuItem.Visible = false;
            adminToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logoutToolStripMenuItem.Visible = false;
            loginToolStripMenuItem.Visible = true;
            adminToolStripMenuItem.Visible = false;
            salesStripMenuItem1.Visible = false;
            craftsmanToolStripMenuItem.Visible = false;
        }
    }
}
