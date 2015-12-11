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
        List<EmployeeAdress> adressList = new List<EmployeeAdress>();
        int EmployeeID;
        public Form_Employee_1()
        {
            InitializeComponent();
        }

        private void Form_Employee_1_Load(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            Form_Employee_Create CreateNew = new Form_Employee_Create();
            CreateNew.ShowDialog();
        }

        private void Form_Employee_1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        //START EDITING
        private void button_toggleEdit_Click(object sender, EventArgs e)
        {
            if (panel_edit.Visible == false)
            {

                panel_edit.Visible = true;
                button_toggleEdit.Text = "Gem";
            }
            else
            {
                panel_edit.Visible = false;
                button_toggleEdit.Text = "Redigér";
            }
        }

        //EDIT FIRST NAME
        private void button_EditFName_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.ReadOnly == true)
            {
                button_EditFName.Text = "Gem";
                textBox_FirstName.ReadOnly = false;
            }
            else
            {
                //cc.EmployeeAlterFirstName(ID, textBox_FirstName.Text);
                button_EditFName.Text = "Rediger";
                textBox_FirstName.ReadOnly = true;
            }
        }

        //EDIT SUR NAME
        private void button_EditSurName_Click(object sender, EventArgs e)
        {
            if (textBox_SirName.ReadOnly == true)
            {
                button_EditSurName.Text = "Gem";
                textBox_SirName.ReadOnly = false;
            }
            else
            {
                //cc.EmployeeAlterSurname(ID, textBox_SirName.Text);
                button_EditSurName.Text = "Rediger";
                textBox_SirName.ReadOnly = true;
            }
        }

        //EDIT ADRESS
        private void button_EditAdress_Click(object sender, EventArgs e)
        {

        }
        //EDIT SELECTED PHONENUMBER
        private void button_EditPhoneNumber_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_PhoneEdit.Visible == false)
            {
                button_EditPhoneNumber.Text = "Gem";
                //textBox_Phone.Visible = false;
                //maskedTextBox_PhoneEdit.Text = textBox_Phone.Text;
                maskedTextBox_PhoneEdit.Visible = true;
            }
            else
            {
                //cc.EmployeeAlterPhone(ID, Convert.ToInt32(maskedTextBox_PhoneEdit.Text));
                button_EditPhoneNumber.Text = "Rediger";
                //textBox_Phone.Visible = true;
                //textBox_Phone.Text = maskedTextBox_PhoneEdit.Text;
                maskedTextBox_PhoneEdit.Visible = false;
            }
        }

        //EDIT SALARY
        private void button_EditSalary_Click(object sender, EventArgs e)
        {
            if (numericUpDown_EditSalary.Visible == false)
            {
                button_EditSalary.Text = "Gem";
                textBox_Salary.Visible = false;
                //numericUpDown_EditSalary.Value = Convert.ToDecimal(cc.GetEmployee(ID).GetSalary());
                numericUpDown_EditSalary.Visible = true;
            }
            else
            {
                //cc.EmployeeAlterSalary(ID, Convert.ToDouble(numericUpDown_EditSalary.Value));
                button_EditSalary.Text = "Rediger";
                textBox_Salary.Visible = true;
                textBox_Salary.Text = numericUpDown_EditSalary.Value.ToString();
                numericUpDown_EditSalary.Visible = false;
            }
        }

        //EDIT EMPLOYEES SPECIALTY
        private void button_EditSpecial_Click(object sender, EventArgs e)
        {
            if (comboBox_SpecialEdit.Visible == false)
            {
                button_EditSpecial.Text = "Gem";
                textBox_Special.Visible = false;
                //comboBox_SpecialEdit.SelectedValue = cc.GetEmployee(ID).GetSpeciality();
                comboBox_SpecialEdit.Visible = true;
            }
            else
            {
                if (comboBox_SpecialEdit.SelectedIndex == 0)
                {
                    //cc.GetEmployee(ID).SetSalesMan();
                }
                if (comboBox_SpecialEdit.SelectedIndex == 1)
                {
                    //cc.GetEmployee(ID).SetCraftsMan();
                }
                button_EditSpecial.Text = "Rediger";
                textBox_Special.Visible = true;
                //textBox_Special.Text = cc.GetEmployee(ID).GetSpeciality();
                comboBox_SpecialEdit.Visible = false;
            }
        }

        //SEARCH FOR EMPLOYEE
        private void numericUpDown_CustomerID_ValueChanged(object sender, EventArgs e)
        {
            EmployeeID = Convert.ToInt32(numericUpDown_CustomerID.Value);
            textBox_FirstName.Text = cc.FindEmployee(EmployeeID).GetFirstName();
            textBox_SirName.Text = cc.FindEmployee(EmployeeID).GetSurName();
            adressList = cc.FindEmployee(EmployeeID).GetAdresses();
            comboBox_Adresses.Items.Clear();
            foreach (var adress in adressList)
            {
                comboBox_Adresses.Items.Add(adress.GetAdress());
            }
            textBox_Salary.Text = cc.FindEmployee(EmployeeID).GetSalary().ToString();
            comboBox_PhoneNumbers.Items.Clear();
            foreach (var phone in cc.FindEmployee(EmployeeID).getTlf())
            {
                comboBox_PhoneNumbers.Items.Add(phone);
            }
            textBox_Special.Text = cc.FindEmployee(EmployeeID).GetProfesion();
        }

        //ONE ADRESS SELECT
        private void comboBox_Adresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_PostalCode.Text = adressList[comboBox_Adresses.SelectedIndex].GetPostalCode().ToString();
            textBox_City.Text = cc.GetCityName(adressList[comboBox_Adresses.SelectedIndex].GetPostalCode());
        }
    }
}
