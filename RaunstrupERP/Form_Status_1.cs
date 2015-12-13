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
        OrderDescription currentOrder;
        int orderID;

        public Form_Status_1()
        {
            InitializeComponent();
            panel_CustomerSalesInfo.Visible = false;
            panel_MaterialInfo.Visible = false;
            panel_TasksInfo.Visible = false;
            checkBox_TaskIsComplete.Visible = false;
            cc.LoadItems();
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
            currentOrder = cc.FindInquiry(orderID);
            /*CHECK IF ORDER EXISTS*/
            if (currentOrder != null)
            {
                /*LOAD CUSTOMER INFO*/
                textBox_CustomerName.Text = currentOrder.GetOffer().GetBuyer().GetFullName();
                textBox_CustomerAdress.Text = currentOrder.GetOffer().GetBuyer().GetAdresses()[0].GetAdress();
                textBox_CustomerCity.Text = cc.GetCityName(currentOrder.GetOffer().GetBuyer().GetAdresses()[0].GetPostalCode());
                textBox_CustomerPostalCode.Text = currentOrder.GetOffer().GetBuyer().GetAdresses()[0].GetPostalCode().ToString();
                textBox_CustomerPhone.Text = currentOrder.GetOffer().GetBuyer().getTlf()[0].ToString();
                textBox_CustomerId.Text = currentOrder.GetOffer().GetBuyer().GetID().ToString();
                /*LOAD SALESMAN INFO*/
                textBox_Salesman.Text = currentOrder.GetOffer().GetSalesMan().GetFullName();
                textBox_SalesmanPhone.Text = currentOrder.GetOffer().GetSalesMan().GetPhone().ToString();

                /*LOAD ORDER AND TASK INFO*/
                textBox_OrderValue.Text = currentOrder.getOrderValue().ToString();
                textBox_OrderCost.Text = currentOrder.getOrderCost().ToString();
                /*ONLY DO THIS, IF WORK TASKS EXIST!*/
                if (currentOrder.GetOffer().GetWorkTasks() != null)
                {
                    foreach (TaskDescription item in currentOrder.GetOffer().GetWorkTasks().GetTasks())
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
            currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).CheckComplete();
            checkBox_TaskIsComplete.Checked = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetStatus();
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
            textBox_TaskValueTotal.Text = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotal().ToString();
            textBox_TaskValueCompletedTotal.Text = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotalCompleted().ToString();
            foreach (EmployeeDescription item in currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getEmployees())
            {
                listBox_Employees.Items.Add("Id: " + item.GetId() + " " + item.GetFullName());
            }
            foreach (ItemLine item in currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).getMaterials())
            {
                listBox_Materials.Items.Add(item.GetLineID() + " Antal: " + item.GetAmount() + " - " + item.GetItem().GetDesc() + " - Pris: " + item.GetTotalSalesPrice() + " Kr.");
            }
        }

        /*ON SELECT MATERIAL*/
        private void listBox_Materials_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*VISIBILITY!*/
            panel_MaterialInfo.Visible = true;
            /*FUNCTIONS*/
            /*SHOW VALUES*/
            textBox_TaskValueTotal.Text = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotal().ToString();
            textBox_TaskValueCompletedTotal.Text = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotalCompleted().ToString();
            if (currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetItemLineAtIndex(listBox_Materials.SelectedIndex).GetUncompletedAmount() > 0)
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
            numericUpDown_AmountCompleted.Maximum = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetItemLineAtIndex(listBox_Materials.SelectedIndex).GetUncompletedAmount();
            textBox_MaterialeName.Text = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetItemLineAtIndex(listBox_Materials.SelectedIndex).GetItem().GetDesc();
            checkBox_ItemLineIsComplete.Checked = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetItemLineAtIndex(listBox_Materials.SelectedIndex).GetStatus();
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
            currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetItemLineAtIndex(listBox_Materials.SelectedIndex).addCompleted(Convert.ToInt32(numericUpDown_AmountCompleted.Value));
            if (currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetItemLineAtIndex(listBox_Materials.SelectedIndex).GetUncompletedAmount() > 0)
            {
                numericUpDown_AmountCompleted.Visible = true;
                button_AddCompleteItems.Visible = true;
                checkBox_ItemLineIsComplete.Visible = false;
            }
            else
            {
                numericUpDown_AmountCompleted.Visible = false;
                button_AddCompleteItems.Visible = false;
                checkBox_ItemLineIsComplete.Checked = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetItemLineAtIndex(listBox_Materials.SelectedIndex).GetStatus();
                checkBox_ItemLineIsComplete.Visible = true;
            }
            numericUpDown_AmountCompleted.Maximum = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetItemLineAtIndex(listBox_Materials.SelectedIndex).GetUncompletedAmount();
            textBox_TaskValueTotal.Text = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotal().ToString();
            textBox_TaskValueCompletedTotal.Text = currentOrder.GetOffer().GetWorkTasks().GetTask(listBox_WorkTasks.SelectedIndex + 1).GetTotalCompleted().ToString();
            textBox_OrderCost.Text = currentOrder.getOrderCost().ToString();
        }

        private void button_PrintXML_Click(object sender, EventArgs e)
        {
            cc.WriteOrderXML(orderID);
        }

        private void button_ReadXML_Click(object sender, EventArgs e)
        {
            cc.ReadOrderXML();
        }

        private void button_PrintReceipt_Click(object sender, EventArgs e)
        {
            currentOrder.PrintOrder();
        }

        private void Form_Status_1_MouseClick(object sender, MouseEventArgs e)
        {
            cc.LoadItems();
        }
    }
}
