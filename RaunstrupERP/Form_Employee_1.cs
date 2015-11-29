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
    public partial class Form_Employee_1 : Form
    {
        ControllerCatalog cc = new ControllerCatalog();
        public Form_Employee_1()
        {
            InitializeComponent();
        }

        private void Form_Employee_1_Load(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
            foreach (EmployeeDescription item in cc.GetEmployeeList())
            {
                listBox_EmployeesSelect.Items.Add(item.GetFullName());
            }
        }

        private void listBox_EmployeesSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Id.Text = cc.GetEmployee(listBox_EmployeesSelect.SelectedIndex + 1).GetId().ToString();
            textBox_FirstName.Text = cc.GetEmployee(listBox_EmployeesSelect.SelectedIndex + 1).GetFirstName();
            textBox_SirName.Text = cc.GetEmployee(listBox_EmployeesSelect.SelectedIndex + 1).GetSurName();
            textBox_Adress.Text = cc.GetEmployee(listBox_EmployeesSelect.SelectedIndex + 1).GetAdress();
            textBox_PostalCode.Text = cc.GetEmployee(listBox_EmployeesSelect.SelectedIndex + 1).GetPostal().ToString();
            textBox_City.Text = cc.GetEmployee(listBox_EmployeesSelect.SelectedIndex + 1).GetCity();
            textBox_Phone.Text = cc.GetEmployee(listBox_EmployeesSelect.SelectedIndex + 1).GetPhone().ToString();
            textBox_Salary.Text = cc.GetEmployee(listBox_EmployeesSelect.SelectedIndex + 1).GetSalary().ToString();
            textBox_Special.Text = cc.GetEmployee(listBox_EmployeesSelect.SelectedIndex + 1).GetSpeciality();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            Form_Employee_Create CreateNew = new Form_Employee_Create();
            CreateNew.ShowDialog();
        }

        private void Form_Employee_1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox_EmployeesSelect.Items.Clear();
            foreach (EmployeeDescription item in cc.GetEmployeeList())
            {
                listBox_EmployeesSelect.Items.Add(item.GetFullName());
            }
        }

        private void button_toggleEdit_Click(object sender, EventArgs e)
        {
            if (panel_edit.Visible == false)
            {
                panel_edit.Visible = true;
                button_toggleEdit.Text = "Stop";
            }
            else
            {
                panel_edit.Visible = false;
                button_toggleEdit.Text = "Redigér";
            }
        }
    }
}
