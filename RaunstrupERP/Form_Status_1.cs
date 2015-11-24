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
        int orderID;

        public Form_Status_1()
        {
            InitializeComponent();
            panel_CustomerSalesInfo.Visible = false;
        }

        private void Form_Status_1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button_findOrder_Click(object sender, EventArgs e)
        {
            panel_CustomerSalesInfo.Visible = true;
            orderID = Convert.ToInt32(maskedTextBox_OrderID.Text); /*Converts string to Int*/
            /*CHECK IF ORDER EXISTS*/
            if (cc.GetOrder(orderID) != null)
            {
                /*LOAD CUSTOMER INFO*/
                textBox_CustomerName.Text = cc.GetOrder(orderID).GetOffer().GetBuyer().getFullName();
                textBox_CustomerAdress.Text = cc.GetOrder(orderID).GetOffer().GetBuyer().getAdress();
                textBox_CustomerCity.Text = cc.GetOrder(orderID).GetOffer().GetBuyer().getCity();
                textBox_CustomerPostalCode.Text = cc.GetOrder(orderID).GetOffer().GetBuyer().getPostal().ToString();
                textBox_CustomerPhone.Text = cc.GetOrder(orderID).GetOffer().GetBuyer().getTlf().ToString();
                textBox_CustomerId.Text = cc.GetOrder(orderID).GetOffer().GetBuyer().getID().ToString();
                /*LOAD SALESMAN INFO*/
                textBox_Salesman.Text = cc.GetOrder(orderID).GetOffer().GetSalesMan().GetFullName();
                textBox_SalesmanPhone.Text = cc.GetOrder(orderID).GetOffer().GetSalesMan().GetPhone().ToString();

                /*LOAD ORDER AND TASK INFO*/
                listBox_WorkTasks.Items.Clear();
                /*ONLY DO THIS, IF WORK TASKS EXIST!*/
                if (cc.GetOrder(orderID).GetOffer().GetWorkTasks() != null)
                {
                    foreach (TaskDescription item in cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTasks())
                    {
                        listBox_WorkTasks.Items.Add(item.GetDesc());
                    }
                }

            }
        }

        private void listBox_WorkTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Employees.Items.Clear();
            listBox_Materials.Items.Clear();
            foreach (EmployeeDescription item in cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getEmployees())
            {
                listBox_Employees.Items.Add("Id: " + item.GetId() + " " + item.GetFullName());
            }
            foreach (ItemLine item in cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getMaterials())
            {
                listBox_Materials.Items.Add("Antal: " + item.getAmount() + " - " + item.GetItem().GetDesc() + " - Pris: " + item.GetTotalSalesPrice() + " Kr.");
            }
        }

        private void listBox_Materials_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_MaterialeName.Text = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex).GetItem().GetDesc();
            checkBox_IsComplete.Checked = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex).getStatus();
        }
    }
}
