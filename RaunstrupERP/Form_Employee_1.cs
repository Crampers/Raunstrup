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
            foreach (int postalCode in cc.GetPostalCodes())
            {
                comboBox_EditPostalCode.Items.Add(postalCode);
            }
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
                cc.AlterEmployeeFirstName(EmployeeID, textBox_FirstName.Text);
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
                cc.AlterEmployeeSurName(EmployeeID, textBox_SirName.Text);
                button_EditSurName.Text = "Rediger";
                textBox_SirName.ReadOnly = true;
            }
        }

        //EDIT ADRESS
        private void button_EditAdress_Click(object sender, EventArgs e)
        {
            if (textBox_EditAdress.Visible == false)
            {
                button_EditAdress.Text = "Gem";
                comboBox_Adresses.Visible = false;
                textBox_PostalCode.Visible = false;
                textBox_EditAdress.Visible = true;
                if (comboBox_Adresses.SelectedItem != null)
                {
                    textBox_EditAdress.Text = comboBox_Adresses.SelectedItem.ToString();
                }
                textBox_EditCity.Visible = true;
                comboBox_EditPostalCode.Visible = true;
                comboBox_EditPostalCode.SelectedIndex = comboBox_Adresses.SelectedIndex;
            }
            else
            {
                if (comboBox_Adresses.SelectedItem != null)
                {
                    cc.AlterEmployeeAdress(EmployeeID, comboBox_Adresses.SelectedItem.ToString(), textBox_EditAdress.Text, Convert.ToInt32(comboBox_EditPostalCode.SelectedItem));
                }
                button_EditAdress.Text = "Rediger";
                comboBox_Adresses.Visible = true;
                textBox_PostalCode.Visible = true;
                textBox_EditAdress.Visible = false;
                textBox_EditCity.Visible = false;
                comboBox_EditPostalCode.Visible = false;
            }
        }
        //EDIT SELECTED PHONENUMBER
        private void button_EditPhoneNumber_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_PhoneEdit.Visible == false)
            {
                button_EditPhoneNumber.Text = "Gem";
                maskedTextBox_PhoneEdit.Text = comboBox_PhoneNumbers.SelectedItem.ToString();
                maskedTextBox_PhoneEdit.Visible = true;
                comboBox_PhoneNumbers.Visible = false;
            }
            else
            {
                cc.AlterEmployeePhone(EmployeeID, Convert.ToInt32(comboBox_PhoneNumbers.SelectedItem), Convert.ToInt32(maskedTextBox_PhoneEdit.Text));
                button_EditPhoneNumber.Text = "Rediger";
                comboBox_PhoneNumbers.SelectedItem = maskedTextBox_PhoneEdit.Text;
                comboBox_PhoneNumbers.Visible = true;
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
                numericUpDown_EditSalary.Value = Convert.ToDecimal(textBox_Salary.Text);
                numericUpDown_EditSalary.Visible = true;
            }
            else
            {
                cc.AlterEmployeeSalary(EmployeeID, Convert.ToInt32(numericUpDown_EditSalary.Value));
                button_EditSalary.Text = "Rediger";
                textBox_Salary.Visible = true;
                textBox_Salary.Text = numericUpDown_EditSalary.Value.ToString();
                numericUpDown_EditSalary.Visible = false;
            }
        }

        //EDIT EMPLOYEES SPECIALTY - CURRENT UNUSUED: CAN BE IMPLEMENTED LATER
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
            textBox_PostalCode.Text = "";
            textBox_City.Text = "";
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

        //ON ADRESS SELECT
        private void comboBox_Adresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_PostalCode.Text = adressList[comboBox_Adresses.SelectedIndex].GetPostalCode().ToString();
            textBox_City.Text = cc.GetCityName(adressList[comboBox_Adresses.SelectedIndex].GetPostalCode());
        }
        //ON ADRESSEDIT SELECT
        private void comboBox_EditPostalCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_EditCity.Text = cc.GetCityName(Convert.ToInt32( comboBox_EditPostalCode.SelectedItem));
        }
    }
}
