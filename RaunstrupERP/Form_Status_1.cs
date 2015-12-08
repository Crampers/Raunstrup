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
            panel_MaterialInfo.Visible = false;
            panel_TasksInfo.Visible = false;
            checkBox_TaskIsComplete.Visible = false;
        }

        private void Form_Status_1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button_findOrder_Click(object sender, EventArgs e)
        {
            panel_CustomerSalesInfo.Visible = true;
            orderID = Convert.ToInt32(numericUpDown_OrderID.Value);
            /*CLEAR LISTBOXES*/
            listBox_WorkTasks.Items.Clear();
            listBox_Employees.Items.Clear();
            listBox_Materials.Items.Clear();
            panel_MaterialInfo.Visible = false;
            panel_TasksInfo.Visible = false;
            checkBox_TaskIsComplete.Visible = false;
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
                textBox_OrderValue.Text = cc.GetOrder(orderID).getOrderValue().ToString();
                textBox_OrderCost.Text = cc.GetOrder(orderID).getOrderCost().ToString();
                /*ONLY DO THIS, IF WORK TASKS EXIST!*/
                if (cc.GetOrder(orderID).GetOffer().GetWorkTasks() != null)
                {
                    foreach (TaskDescription item in cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTasks())
                    {
                        listBox_WorkTasks.Items.Add(item.GetDesc());
                    }
                }

            }
            else
            {
                /*LOAD CUSTOMER INFO*/
                textBox_CustomerName.Text = "";
                textBox_CustomerAdress.Text = ""; 
                textBox_CustomerCity.Text = ""; 
                textBox_CustomerPostalCode.Text = ""; 
                textBox_CustomerPhone.Text = ""; 
                textBox_CustomerId.Text = ""; 
                /*LOAD SALESMAN INFO*/
                textBox_Salesman.Text = ""; 
                textBox_SalesmanPhone.Text = "";

            }
        }
        /*ON SELECT TASK*/
        private void listBox_WorkTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*RESET*/
            listBox_Employees.Items.Clear();
            listBox_Materials.Items.Clear();
            textBox_MaterialeName.Text = "";
            panel_MaterialInfo.Visible = false;
            cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).CheckComplete();
            checkBox_TaskIsComplete.Checked = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetStatus();
            if (listBox_WorkTasks.SelectedItem != null)
            {
                checkBox_TaskIsComplete.Visible = true;
                if (checkBox_TaskIsComplete.Checked == false)
                {
                    panel_TasksInfo.Visible = true;
                }
                else
                {
                    panel_TasksInfo.Visible = false;
                }
            }

            /*DO THIS*/
            textBox_TaskValueTotal.Text = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotal().ToString();
            textBox_TaskValueCompletedTotal.Text = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotalCompleted().ToString();
            foreach (EmployeeDescription item in cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getEmployees())
            {
                listBox_Employees.Items.Add("Id: " + item.GetId() + " " + item.GetFullName());
            }
            foreach (ItemLine item in cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getMaterials())
            {
                listBox_Materials.Items.Add("Antal: " + item.GetAmount() + " - " + item.GetItem().GetDesc() + " - Pris: " + item.GetTotalSalesPrice() + " Kr.");
            }
        }

        /*ON SELECT MATERIAL*/
        private void listBox_Materials_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*VISIBILITY!*/
            panel_MaterialInfo.Visible = true;
            /*FUNCTIONS*/
            /*SHOW VALUES*/
            textBox_TaskValueTotal.Text = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotal().ToString();
            textBox_TaskValueCompletedTotal.Text = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotalCompleted().ToString();
            if (cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex + 1).GetStatus() == false)
            {
                numericUpDown_AmountCompleted.Visible = true;
                button_AddCompleteItems.Visible = true;
                checkBox_ItemLineIsComplete.Visible = false;
            }
            else
            {
                numericUpDown_AmountCompleted.Visible = false;
                button_AddCompleteItems.Visible = false;
                checkBox_ItemLineIsComplete.Visible = true;
            }
            numericUpDown_AmountCompleted.Maximum = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex + 1).GetUncompletedAmount();
            textBox_MaterialeName.Text = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex + 1).GetItem().GetDesc();
            checkBox_ItemLineIsComplete.Checked = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex + 1).GetStatus();
        }

        private void checkBox_IsComplete_CheckedChanged(object sender, EventArgs e)
        {
            //if (listBox_WorkTasks.SelectedItem != null)
            //{
            //    if (listBox_Materials.SelectedItem != null)
            //    {
            //        cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex).setStatus(checkBox_ItemLineIsComplete.Checked);
            //    }
            //}
        }

        private void button_AddCompleteItems_Click(object sender, EventArgs e)
        {
            cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex + 1).addCompleted(Convert.ToInt32(numericUpDown_AmountCompleted.Value));
            if (cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex + 1).GetUncompletedAmount() > 0)
            {
                numericUpDown_AmountCompleted.Visible = true;
                button_AddCompleteItems.Visible = true;
                checkBox_ItemLineIsComplete.Visible = false;
            }
            else
            {
                numericUpDown_AmountCompleted.Visible = false;
                button_AddCompleteItems.Visible = false;
                checkBox_ItemLineIsComplete.Checked = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex + 1).GetStatus();
                checkBox_ItemLineIsComplete.Visible = true;
            }
            numericUpDown_AmountCompleted.Maximum = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getItemLine(listBox_Materials.SelectedIndex + 1).GetUncompletedAmount();
            textBox_TaskValueTotal.Text = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotal().ToString();
            textBox_TaskValueCompletedTotal.Text = cc.GetOrder(orderID).GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotalCompleted().ToString();
            textBox_OrderCost.Text = cc.GetOrder(orderID).getOrderCost().ToString();
        }

        private void button_PrintXML_Click(object sender, EventArgs e)
        {
            cc.WriteOrderXML(orderID);
        }

        private void button_ReadXML_Click(object sender, EventArgs e)
        {
            cc.ReadOrderXML();
        }
    }
}
