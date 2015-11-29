namespace RaunstrupERP
{
    partial class Form_Employee_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Id = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_SirName = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.label_PostalCode = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Salary = new System.Windows.Forms.Label();
            this.label_Special = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_SirName = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_PostalCode = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.listBox_EmployeesSelect = new System.Windows.Forms.ListBox();
            this.textBox_Special = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_EditFName = new System.Windows.Forms.Button();
            this.button_EditSurName = new System.Windows.Forms.Button();
            this.button_EditAdress = new System.Windows.Forms.Button();
            this.button_EditPostal = new System.Windows.Forms.Button();
            this.button_EditCityName = new System.Windows.Forms.Button();
            this.button_EditPhoneNumber = new System.Windows.Forms.Button();
            this.button_EditSalary = new System.Windows.Forms.Button();
            this.button_EditSpecial = new System.Windows.Forms.Button();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.button_toggleEdit = new System.Windows.Forms.Button();
            this.maskedTextBox_PostalEdit = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_PhoneEdit = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown_EditSalary = new System.Windows.Forms.NumericUpDown();
            this.comboBox_SpecialEdit = new System.Windows.Forms.ComboBox();
            this.panel_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(285, 12);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(16, 13);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "Id";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(282, 38);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(46, 13);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "Fornavn";
            // 
            // label_SirName
            // 
            this.label_SirName.AutoSize = true;
            this.label_SirName.Location = new System.Drawing.Point(282, 64);
            this.label_SirName.Name = "label_SirName";
            this.label_SirName.Size = new System.Drawing.Size(53, 13);
            this.label_SirName.TabIndex = 2;
            this.label_SirName.Text = "Efternavn";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(282, 90);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(45, 13);
            this.label_Adress.TabIndex = 3;
            this.label_Adress.Text = "Adresse";
            // 
            // label_PostalCode
            // 
            this.label_PostalCode.AutoSize = true;
            this.label_PostalCode.Location = new System.Drawing.Point(282, 116);
            this.label_PostalCode.Name = "label_PostalCode";
            this.label_PostalCode.Size = new System.Drawing.Size(65, 13);
            this.label_PostalCode.TabIndex = 4;
            this.label_PostalCode.Text = "Postnummer";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(282, 142);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(43, 13);
            this.label_City.TabIndex = 5;
            this.label_City.Text = "Bynavn";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(282, 168);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(43, 13);
            this.label_Phone.TabIndex = 6;
            this.label_Phone.Text = "Telefon";
            // 
            // label_Salary
            // 
            this.label_Salary.AutoSize = true;
            this.label_Salary.Location = new System.Drawing.Point(282, 194);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(25, 13);
            this.label_Salary.TabIndex = 7;
            this.label_Salary.Text = "Løn";
            // 
            // label_Special
            // 
            this.label_Special.AutoSize = true;
            this.label_Special.Location = new System.Drawing.Point(282, 220);
            this.label_Special.Name = "label_Special";
            this.label_Special.Size = new System.Drawing.Size(48, 13);
            this.label_Special.TabIndex = 8;
            this.label_Special.Text = "Speciale";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(353, 9);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(100, 20);
            this.textBox_Id.TabIndex = 9;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(353, 35);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.ReadOnly = true;
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_FirstName.TabIndex = 10;
            // 
            // textBox_SirName
            // 
            this.textBox_SirName.Location = new System.Drawing.Point(353, 61);
            this.textBox_SirName.Name = "textBox_SirName";
            this.textBox_SirName.ReadOnly = true;
            this.textBox_SirName.Size = new System.Drawing.Size(100, 20);
            this.textBox_SirName.TabIndex = 11;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(353, 87);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.ReadOnly = true;
            this.textBox_Adress.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adress.TabIndex = 12;
            // 
            // textBox_PostalCode
            // 
            this.textBox_PostalCode.Location = new System.Drawing.Point(353, 113);
            this.textBox_PostalCode.Name = "textBox_PostalCode";
            this.textBox_PostalCode.ReadOnly = true;
            this.textBox_PostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBox_PostalCode.TabIndex = 13;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(353, 139);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.ReadOnly = true;
            this.textBox_City.Size = new System.Drawing.Size(100, 20);
            this.textBox_City.TabIndex = 14;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(353, 165);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.ReadOnly = true;
            this.textBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_Phone.TabIndex = 15;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(353, 191);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.ReadOnly = true;
            this.textBox_Salary.Size = new System.Drawing.Size(100, 20);
            this.textBox_Salary.TabIndex = 16;
            // 
            // listBox_EmployeesSelect
            // 
            this.listBox_EmployeesSelect.FormattingEnabled = true;
            this.listBox_EmployeesSelect.Location = new System.Drawing.Point(12, 12);
            this.listBox_EmployeesSelect.Name = "listBox_EmployeesSelect";
            this.listBox_EmployeesSelect.Size = new System.Drawing.Size(267, 264);
            this.listBox_EmployeesSelect.TabIndex = 18;
            this.listBox_EmployeesSelect.SelectedIndexChanged += new System.EventHandler(this.listBox_EmployeesSelect_SelectedIndexChanged);
            // 
            // textBox_Special
            // 
            this.textBox_Special.Location = new System.Drawing.Point(353, 217);
            this.textBox_Special.Name = "textBox_Special";
            this.textBox_Special.ReadOnly = true;
            this.textBox_Special.Size = new System.Drawing.Size(100, 20);
            this.textBox_Special.TabIndex = 19;
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(288, 253);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 20;
            this.button_Create.Text = "Opret Ny";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_EditFName
            // 
            this.button_EditFName.Location = new System.Drawing.Point(3, 21);
            this.button_EditFName.Name = "button_EditFName";
            this.button_EditFName.Size = new System.Drawing.Size(75, 23);
            this.button_EditFName.TabIndex = 21;
            this.button_EditFName.Text = "Rediger";
            this.button_EditFName.UseVisualStyleBackColor = true;
            this.button_EditFName.Click += new System.EventHandler(this.button_EditFName_Click);
            // 
            // button_EditSurName
            // 
            this.button_EditSurName.Location = new System.Drawing.Point(3, 47);
            this.button_EditSurName.Name = "button_EditSurName";
            this.button_EditSurName.Size = new System.Drawing.Size(75, 23);
            this.button_EditSurName.TabIndex = 22;
            this.button_EditSurName.Text = "Rediger";
            this.button_EditSurName.UseVisualStyleBackColor = true;
            this.button_EditSurName.Click += new System.EventHandler(this.button_EditSurName_Click);
            // 
            // button_EditAdress
            // 
            this.button_EditAdress.Location = new System.Drawing.Point(3, 73);
            this.button_EditAdress.Name = "button_EditAdress";
            this.button_EditAdress.Size = new System.Drawing.Size(75, 23);
            this.button_EditAdress.TabIndex = 23;
            this.button_EditAdress.Text = "Rediger";
            this.button_EditAdress.UseVisualStyleBackColor = true;
            this.button_EditAdress.Click += new System.EventHandler(this.button_EditAdress_Click);
            // 
            // button_EditPostal
            // 
            this.button_EditPostal.Location = new System.Drawing.Point(3, 99);
            this.button_EditPostal.Name = "button_EditPostal";
            this.button_EditPostal.Size = new System.Drawing.Size(75, 23);
            this.button_EditPostal.TabIndex = 24;
            this.button_EditPostal.Text = "Rediger";
            this.button_EditPostal.UseVisualStyleBackColor = true;
            this.button_EditPostal.Click += new System.EventHandler(this.button_EditPostal_Click);
            // 
            // button_EditCityName
            // 
            this.button_EditCityName.Location = new System.Drawing.Point(3, 125);
            this.button_EditCityName.Name = "button_EditCityName";
            this.button_EditCityName.Size = new System.Drawing.Size(75, 23);
            this.button_EditCityName.TabIndex = 25;
            this.button_EditCityName.Text = "Rediger";
            this.button_EditCityName.UseVisualStyleBackColor = true;
            this.button_EditCityName.Click += new System.EventHandler(this.button_EditCityName_Click);
            // 
            // button_EditPhoneNumber
            // 
            this.button_EditPhoneNumber.Location = new System.Drawing.Point(3, 151);
            this.button_EditPhoneNumber.Name = "button_EditPhoneNumber";
            this.button_EditPhoneNumber.Size = new System.Drawing.Size(75, 23);
            this.button_EditPhoneNumber.TabIndex = 26;
            this.button_EditPhoneNumber.Text = "Rediger";
            this.button_EditPhoneNumber.UseVisualStyleBackColor = true;
            this.button_EditPhoneNumber.Click += new System.EventHandler(this.button_EditPhoneNumber_Click);
            // 
            // button_EditSalary
            // 
            this.button_EditSalary.Location = new System.Drawing.Point(3, 177);
            this.button_EditSalary.Name = "button_EditSalary";
            this.button_EditSalary.Size = new System.Drawing.Size(75, 23);
            this.button_EditSalary.TabIndex = 27;
            this.button_EditSalary.Text = "Rediger";
            this.button_EditSalary.UseVisualStyleBackColor = true;
            this.button_EditSalary.Click += new System.EventHandler(this.button_EditSalary_Click);
            // 
            // button_EditSpecial
            // 
            this.button_EditSpecial.Location = new System.Drawing.Point(3, 203);
            this.button_EditSpecial.Name = "button_EditSpecial";
            this.button_EditSpecial.Size = new System.Drawing.Size(75, 23);
            this.button_EditSpecial.TabIndex = 28;
            this.button_EditSpecial.Text = "Rediger";
            this.button_EditSpecial.UseVisualStyleBackColor = true;
            this.button_EditSpecial.Click += new System.EventHandler(this.button_EditSpecial_Click);
            // 
            // panel_edit
            // 
            this.panel_edit.Controls.Add(this.button_EditFName);
            this.panel_edit.Controls.Add(this.button_EditSpecial);
            this.panel_edit.Controls.Add(this.button_EditSurName);
            this.panel_edit.Controls.Add(this.button_EditAdress);
            this.panel_edit.Controls.Add(this.button_EditPostal);
            this.panel_edit.Controls.Add(this.button_EditSalary);
            this.panel_edit.Controls.Add(this.button_EditCityName);
            this.panel_edit.Controls.Add(this.button_EditPhoneNumber);
            this.panel_edit.Location = new System.Drawing.Point(459, 12);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(224, 243);
            this.panel_edit.TabIndex = 29;
            // 
            // button_toggleEdit
            // 
            this.button_toggleEdit.Location = new System.Drawing.Point(369, 253);
            this.button_toggleEdit.Name = "button_toggleEdit";
            this.button_toggleEdit.Size = new System.Drawing.Size(75, 23);
            this.button_toggleEdit.TabIndex = 30;
            this.button_toggleEdit.Text = "Redigér";
            this.button_toggleEdit.UseVisualStyleBackColor = true;
            this.button_toggleEdit.Visible = false;
            this.button_toggleEdit.Click += new System.EventHandler(this.button_toggleEdit_Click);
            // 
            // maskedTextBox_PostalEdit
            // 
            this.maskedTextBox_PostalEdit.Location = new System.Drawing.Point(353, 113);
            this.maskedTextBox_PostalEdit.Mask = "0000";
            this.maskedTextBox_PostalEdit.Name = "maskedTextBox_PostalEdit";
            this.maskedTextBox_PostalEdit.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_PostalEdit.TabIndex = 29;
            this.maskedTextBox_PostalEdit.Visible = false;
            // 
            // maskedTextBox_PhoneEdit
            // 
            this.maskedTextBox_PhoneEdit.Location = new System.Drawing.Point(353, 165);
            this.maskedTextBox_PhoneEdit.Mask = "00000000";
            this.maskedTextBox_PhoneEdit.Name = "maskedTextBox_PhoneEdit";
            this.maskedTextBox_PhoneEdit.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_PhoneEdit.TabIndex = 31;
            this.maskedTextBox_PhoneEdit.Visible = false;
            // 
            // numericUpDown_EditSalary
            // 
            this.numericUpDown_EditSalary.DecimalPlaces = 2;
            this.numericUpDown_EditSalary.Location = new System.Drawing.Point(353, 191);
            this.numericUpDown_EditSalary.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDown_EditSalary.Name = "numericUpDown_EditSalary";
            this.numericUpDown_EditSalary.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_EditSalary.TabIndex = 29;
            this.numericUpDown_EditSalary.Visible = false;
            // 
            // comboBox_SpecialEdit
            // 
            this.comboBox_SpecialEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SpecialEdit.FormattingEnabled = true;
            this.comboBox_SpecialEdit.Items.AddRange(new object[] {
            "Sælger",
            "Håndværker"});
            this.comboBox_SpecialEdit.Location = new System.Drawing.Point(353, 217);
            this.comboBox_SpecialEdit.Name = "comboBox_SpecialEdit";
            this.comboBox_SpecialEdit.Size = new System.Drawing.Size(100, 21);
            this.comboBox_SpecialEdit.TabIndex = 29;
            this.comboBox_SpecialEdit.Visible = false;
            // 
            // Form_Employee_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 484);
            this.Controls.Add(this.comboBox_SpecialEdit);
            this.Controls.Add(this.numericUpDown_EditSalary);
            this.Controls.Add(this.maskedTextBox_PhoneEdit);
            this.Controls.Add(this.maskedTextBox_PostalEdit);
            this.Controls.Add(this.button_toggleEdit);
            this.Controls.Add(this.panel_edit);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_Special);
            this.Controls.Add(this.listBox_EmployeesSelect);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.textBox_PostalCode);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_SirName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Special);
            this.Controls.Add(this.label_Salary);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_PostalCode);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_SirName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_Id);
            this.Name = "Form_Employee_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Employee_1";
            this.Load += new System.EventHandler(this.Form_Employee_1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_Employee_1_MouseClick);
            this.panel_edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_SirName;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Label label_PostalCode;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Salary;
        private System.Windows.Forms.Label label_Special;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_SirName;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_PostalCode;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.ListBox listBox_EmployeesSelect;
        private System.Windows.Forms.TextBox textBox_Special;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_EditFName;
        private System.Windows.Forms.Button button_EditSurName;
        private System.Windows.Forms.Button button_EditAdress;
        private System.Windows.Forms.Button button_EditPostal;
        private System.Windows.Forms.Button button_EditCityName;
        private System.Windows.Forms.Button button_EditPhoneNumber;
        private System.Windows.Forms.Button button_EditSalary;
        private System.Windows.Forms.Button button_EditSpecial;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Button button_toggleEdit;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PostalEdit;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PhoneEdit;
        private System.Windows.Forms.NumericUpDown numericUpDown_EditSalary;
        private System.Windows.Forms.ComboBox comboBox_SpecialEdit;
    }
}