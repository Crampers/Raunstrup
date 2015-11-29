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
    public partial class Form_Employee_Create : Form
    {
        ControllerCatalog cc = new ControllerCatalog();
        public Form_Employee_Create()
        {
            InitializeComponent();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            String fn = textBox_Firstname.Text;
            String sn = textBox_Surname.Text;
            String adress = textBox_Adress.Text;
            int postal = Convert.ToInt32(maskedTextBox_PostalCode.Text);
            String city = textBox_CityName.Text;
            int phone = Convert.ToInt32(maskedTextBox_PhoneNumber.Text);
            Double salary = Convert.ToDouble(numericUpDown_Salary.Value);
            cc.AddEmployee(fn, sn, adress, postal, city, phone, salary);
            /*SETS WETHER CRAFTMAN OR SALESMAN!*/
            if (comboBox_Special.SelectedIndex == 0)
            {
                cc.GetEmployee(cc.GetLastUsedEmployeeId()).SetSalesMan();
            }
            if (comboBox_Special.SelectedIndex == 1)
            {
                cc.GetEmployee(cc.GetLastUsedEmployeeId()).SetCraftsMan();
            }
            this.Close();
        }
    }
}
