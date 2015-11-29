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
        int ID;
        List<EmployeeDescription> currentEmployees;
        public Form_Employee_1()
        {
            InitializeComponent();
        }

        private void Form_Employee_1_Load(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
            currentEmployees = cc.GetEmployeeList();
            foreach (EmployeeDescription item in currentEmployees)
            {
                listBox_EmployeesSelect.Items.Add(item.GetFullName());
            }
        }

        private void listBox_EmployeesSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_EmployeesSelect.SelectedItem != null)
            {
                ID = currentEmployees[listBox_EmployeesSelect.SelectedIndex].GetId();
                textBox_Id.Text = ID.ToString();
                textBox_FirstName.Text = currentEmployees[listBox_EmployeesSelect.SelectedIndex].GetFirstName();
                textBox_SirName.Text = currentEmployees[listBox_EmployeesSelect.SelectedIndex].GetSurName();
                textBox_Adress.Text = currentEmployees[listBox_EmployeesSelect.SelectedIndex].GetAdress();
                textBox_PostalCode.Text = currentEmployees[listBox_EmployeesSelect.SelectedIndex].GetPostal().ToString();
                textBox_City.Text = currentEmployees[listBox_EmployeesSelect.SelectedIndex].GetCity();
                textBox_Phone.Text = currentEmployees[listBox_EmployeesSelect.SelectedIndex].GetPhone().ToString();
                textBox_Salary.Text = currentEmployees[listBox_EmployeesSelect.SelectedIndex].GetSalary().ToString();
                textBox_Special.Text = currentEmployees[listBox_EmployeesSelect.SelectedIndex].GetSpeciality();
                button_toggleEdit.Visible = true;
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            Form_Employee_Create CreateNew = new Form_Employee_Create();
            CreateNew.ShowDialog();
        }

        private void Form_Employee_1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox_EmployeesSelect.Items.Clear();
            currentEmployees = cc.GetEmployeeList();
            foreach (EmployeeDescription item in currentEmployees)
            {
                listBox_EmployeesSelect.Items.Add(item.GetFullName());
            }
        }

        private void button_toggleEdit_Click(object sender, EventArgs e)
        {
            if (panel_edit.Visible == false)
            {
                listBox_EmployeesSelect.Visible = false;
                panel_edit.Visible = true;
                button_toggleEdit.Text = "Gem";
            }
            else
            {
                listBox_EmployeesSelect.Visible = true;
                panel_edit.Visible = false;
                button_toggleEdit.Text = "Redigér";
            }
        }

        private void button_EditFName_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.ReadOnly == true)
            {
                button_EditFName.Text = "Gem";
                textBox_FirstName.ReadOnly = false;
            }
            else
            {
                cc.EmployeeAlterFirstName(ID, textBox_FirstName.Text);
                button_EditFName.Text = "Rediger";
                textBox_FirstName.ReadOnly = true;
            }
        }

        private void button_EditSurName_Click(object sender, EventArgs e)
        {
            if (textBox_SirName.ReadOnly == true)
            {
                button_EditSurName.Text = "Gem";
                textBox_SirName.ReadOnly = false;
            }
            else
            {
                cc.EmployeeAlterSurname(ID, textBox_SirName.Text);
                button_EditSurName.Text = "Rediger";
                textBox_SirName.ReadOnly = true;
            }
        }

        private void button_EditAdress_Click(object sender, EventArgs e)
        {
            if (textBox_Adress.ReadOnly == true)
            {
                button_EditAdress.Text = "Gem";
                textBox_Adress.ReadOnly = false;
            }
            else
            {
                cc.EmployeeAlterAdress(ID, textBox_Adress.Text);
                button_EditAdress.Text = "Rediger";
                textBox_Adress.ReadOnly = true;
            }
        }

        private void button_EditPostal_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_PostalEdit.Visible == false)
            {
                button_EditPostal.Text = "Gem";
                textBox_PostalCode.Visible = false;
                maskedTextBox_PostalEdit.Text = textBox_PostalCode.Text;
                maskedTextBox_PostalEdit.Visible = true;
            }
            else
            {
                cc.EmployeeAlterPostalCode(ID, Convert.ToInt32(maskedTextBox_PostalEdit.Text));
                button_EditPostal.Text = "Rediger";
                textBox_PostalCode.Visible = true;
                textBox_PostalCode.Text = maskedTextBox_PostalEdit.Text;
                maskedTextBox_PostalEdit.Visible = false;
            }
        }

        private void button_EditCityName_Click(object sender, EventArgs e)
        {
            if (textBox_City.ReadOnly == true)
            {
                button_EditCityName.Text = "Gem";
                textBox_City.ReadOnly = false;
            }
            else
            {
                cc.EmployeeAlterCity(ID, textBox_City.Text);
                button_EditCityName.Text = "Rediger";
                textBox_City.ReadOnly = true;
            }
        }

        private void button_EditPhoneNumber_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_PhoneEdit.Visible == false)
            {
                button_EditPhoneNumber.Text = "Gem";
                textBox_Phone.Visible = false;
                maskedTextBox_PhoneEdit.Text = textBox_Phone.Text;
                maskedTextBox_PhoneEdit.Visible = true;
            }
            else
            {
                cc.EmployeeAlterPhone(ID, Convert.ToInt32(maskedTextBox_PhoneEdit.Text));
                button_EditPhoneNumber.Text = "Rediger";
                textBox_Phone.Visible = true;
                textBox_Phone.Text = maskedTextBox_PhoneEdit.Text;
                maskedTextBox_PhoneEdit.Visible = false;
            }
        }

        private void button_EditSalary_Click(object sender, EventArgs e)
        {
            if (numericUpDown_EditSalary.Visible == false)
            {
                button_EditSalary.Text = "Gem";
                textBox_Salary.Visible = false;
                numericUpDown_EditSalary.Value = Convert.ToDecimal(cc.GetEmployee(ID).GetSalary());
                numericUpDown_EditSalary.Visible = true;
            }
            else
            {
                cc.EmployeeAlterSalary(ID, Convert.ToDouble(numericUpDown_EditSalary.Value));
                button_EditSalary.Text = "Rediger";
                textBox_Salary.Visible = true;
                textBox_Salary.Text = numericUpDown_EditSalary.Value.ToString();
                numericUpDown_EditSalary.Visible = false;
            }
        }

        private void button_EditSpecial_Click(object sender, EventArgs e)
        {
            if (comboBox_SpecialEdit.Visible == false)
            {
                button_EditSpecial.Text = "Gem";
                textBox_Special.Visible = false;
                comboBox_SpecialEdit.SelectedValue = cc.GetEmployee(ID).GetSpeciality();
                comboBox_SpecialEdit.Visible = true;
            }
            else
            {
                if (comboBox_SpecialEdit.SelectedIndex == 0)
                {
                    cc.GetEmployee(ID).SetSalesMan();
                }
                if (comboBox_SpecialEdit.SelectedIndex == 1)
                {
                    cc.GetEmployee(ID).SetCraftsMan();
                }
                button_EditSpecial.Text = "Rediger";
                textBox_Special.Visible = true;
                textBox_Special.Text = cc.GetEmployee(ID).GetSpeciality();
                comboBox_SpecialEdit.Visible = false;
            }
        }
    }
}
