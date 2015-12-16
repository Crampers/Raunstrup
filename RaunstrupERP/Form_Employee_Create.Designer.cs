namespace RaunstrupERP
{
    partial class Form_Employee_Create
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
            this.label_Special = new System.Windows.Forms.Label();
            this.label_Salary = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_PostalCode = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.label_SirName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.comboBox_Special = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Firstname = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_CityName = new System.Windows.Forms.TextBox();
            this.numericUpDown_Salary = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Salary)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Special
            // 
            this.label_Special.AutoSize = true;
            this.label_Special.Location = new System.Drawing.Point(12, 191);
            this.label_Special.Name = "label_Special";
            this.label_Special.Size = new System.Drawing.Size(48, 13);
            this.label_Special.TabIndex = 27;
            this.label_Special.Text = "Speciale";
            this.label_Special.Visible = false;
            // 
            // label_Salary
            // 
            this.label_Salary.AutoSize = true;
            this.label_Salary.Location = new System.Drawing.Point(12, 165);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(25, 13);
            this.label_Salary.TabIndex = 26;
            this.label_Salary.Text = "Løn";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(12, 139);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(43, 13);
            this.label_Phone.TabIndex = 25;
            this.label_Phone.Text = "Telefon";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(12, 113);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(43, 13);
            this.label_City.TabIndex = 24;
            this.label_City.Text = "Bynavn";
            // 
            // label_PostalCode
            // 
            this.label_PostalCode.AutoSize = true;
            this.label_PostalCode.Location = new System.Drawing.Point(12, 87);
            this.label_PostalCode.Name = "label_PostalCode";
            this.label_PostalCode.Size = new System.Drawing.Size(65, 13);
            this.label_PostalCode.TabIndex = 23;
            this.label_PostalCode.Text = "Postnummer";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(12, 61);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(45, 13);
            this.label_Adress.TabIndex = 22;
            this.label_Adress.Text = "Adresse";
            // 
            // label_SirName
            // 
            this.label_SirName.AutoSize = true;
            this.label_SirName.Location = new System.Drawing.Point(12, 35);
            this.label_SirName.Name = "label_SirName";
            this.label_SirName.Size = new System.Drawing.Size(53, 13);
            this.label_SirName.TabIndex = 21;
            this.label_SirName.Text = "Efternavn";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(12, 9);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(46, 13);
            this.label_FirstName.TabIndex = 20;
            this.label_FirstName.Text = "Fornavn";
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(12, 232);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 9;
            this.button_Confirm.Text = "Godkend";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // comboBox_Special
            // 
            this.comboBox_Special.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Special.FormattingEnabled = true;
            this.comboBox_Special.Items.AddRange(new object[] {
            "Sælger",
            "Håndværker"});
            this.comboBox_Special.Location = new System.Drawing.Point(83, 191);
            this.comboBox_Special.Name = "comboBox_Special";
            this.comboBox_Special.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Special.TabIndex = 8;
            this.comboBox_Special.Visible = false;
            // 
            // maskedTextBox_PhoneNumber
            // 
            this.maskedTextBox_PhoneNumber.Location = new System.Drawing.Point(83, 136);
            this.maskedTextBox_PhoneNumber.Mask = "00000000";
            this.maskedTextBox_PhoneNumber.Name = "maskedTextBox_PhoneNumber";
            this.maskedTextBox_PhoneNumber.Size = new System.Drawing.Size(58, 20);
            this.maskedTextBox_PhoneNumber.TabIndex = 6;
            // 
            // textBox_Firstname
            // 
            this.textBox_Firstname.Location = new System.Drawing.Point(83, 6);
            this.textBox_Firstname.Name = "textBox_Firstname";
            this.textBox_Firstname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Firstname.TabIndex = 1;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(83, 32);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 2;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(83, 58);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adress.TabIndex = 3;
            // 
            // textBox_CityName
            // 
            this.textBox_CityName.Location = new System.Drawing.Point(83, 110);
            this.textBox_CityName.Name = "textBox_CityName";
            this.textBox_CityName.ReadOnly = true;
            this.textBox_CityName.Size = new System.Drawing.Size(100, 20);
            this.textBox_CityName.TabIndex = 5;
            // 
            // numericUpDown_Salary
            // 
            this.numericUpDown_Salary.DecimalPlaces = 2;
            this.numericUpDown_Salary.Location = new System.Drawing.Point(83, 163);
            this.numericUpDown_Salary.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown_Salary.Name = "numericUpDown_Salary";
            this.numericUpDown_Salary.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_Salary.TabIndex = 7;
            this.numericUpDown_Salary.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form_Employee_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 281);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown_Salary);
            this.Controls.Add(this.textBox_CityName);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Firstname);
            this.Controls.Add(this.maskedTextBox_PhoneNumber);
            this.Controls.Add(this.comboBox_Special);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.label_Special);
            this.Controls.Add(this.label_Salary);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_PostalCode);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_SirName);
            this.Controls.Add(this.label_FirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Employee_Create";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opret Medarbejder";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Special;
        private System.Windows.Forms.Label label_Salary;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_PostalCode;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Label label_SirName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.ComboBox comboBox_Special;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_Firstname;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.TextBox textBox_CityName;
        private System.Windows.Forms.NumericUpDown numericUpDown_Salary;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}