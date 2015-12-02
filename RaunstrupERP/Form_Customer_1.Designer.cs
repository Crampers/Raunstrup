namespace RaunstrupERP
{
    partial class Form_Customer_1
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
            this.label_Firstname = new System.Windows.Forms.Label();
            this.label_SirName = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.label_PostalCode = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_Tlf = new System.Windows.Forms.Label();
            this.textBox_CustomerId = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_SirName = new System.Windows.Forms.TextBox();
            this.button_SearchCustomer = new System.Windows.Forms.Button();
            this.comboBox_PhoneNumbers = new System.Windows.Forms.ComboBox();
            this.comboBox_Adresses = new System.Windows.Forms.ComboBox();
            this.textBox_CityName = new System.Windows.Forms.TextBox();
            this.textBox_PostalCode = new System.Windows.Forms.TextBox();
            this.button_EditFName = new System.Windows.Forms.Button();
            this.button_EditSurName = new System.Windows.Forms.Button();
            this.button_EditAdress = new System.Windows.Forms.Button();
            this.button_EditPhone = new System.Windows.Forms.Button();
            this.panel_Edit = new System.Windows.Forms.Panel();
            this.button_ToggleEdit = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button_CreateCustomer = new System.Windows.Forms.Button();
            this.panel_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(12, 9);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(18, 13);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "ID";
            // 
            // label_Firstname
            // 
            this.label_Firstname.AutoSize = true;
            this.label_Firstname.Location = new System.Drawing.Point(11, 40);
            this.label_Firstname.Name = "label_Firstname";
            this.label_Firstname.Size = new System.Drawing.Size(46, 13);
            this.label_Firstname.TabIndex = 1;
            this.label_Firstname.Text = "Fornavn";
            // 
            // label_SirName
            // 
            this.label_SirName.AutoSize = true;
            this.label_SirName.Location = new System.Drawing.Point(12, 66);
            this.label_SirName.Name = "label_SirName";
            this.label_SirName.Size = new System.Drawing.Size(53, 13);
            this.label_SirName.TabIndex = 2;
            this.label_SirName.Text = "Efternavn";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(12, 92);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(45, 13);
            this.label_Adress.TabIndex = 3;
            this.label_Adress.Text = "Adresse";
            // 
            // label_PostalCode
            // 
            this.label_PostalCode.AutoSize = true;
            this.label_PostalCode.Location = new System.Drawing.Point(12, 146);
            this.label_PostalCode.Name = "label_PostalCode";
            this.label_PostalCode.Size = new System.Drawing.Size(65, 13);
            this.label_PostalCode.TabIndex = 4;
            this.label_PostalCode.Text = "Postnummer";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(12, 119);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(43, 13);
            this.label_City.TabIndex = 5;
            this.label_City.Text = "Bynavn";
            // 
            // label_Tlf
            // 
            this.label_Tlf.AutoSize = true;
            this.label_Tlf.Location = new System.Drawing.Point(12, 173);
            this.label_Tlf.Name = "label_Tlf";
            this.label_Tlf.Size = new System.Drawing.Size(85, 13);
            this.label_Tlf.TabIndex = 6;
            this.label_Tlf.Text = "Telefon Nummer";
            // 
            // textBox_CustomerId
            // 
            this.textBox_CustomerId.Location = new System.Drawing.Point(103, 6);
            this.textBox_CustomerId.Name = "textBox_CustomerId";
            this.textBox_CustomerId.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerId.TabIndex = 7;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(103, 37);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.ReadOnly = true;
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_FirstName.TabIndex = 8;
            // 
            // textBox_SirName
            // 
            this.textBox_SirName.Location = new System.Drawing.Point(103, 63);
            this.textBox_SirName.Name = "textBox_SirName";
            this.textBox_SirName.ReadOnly = true;
            this.textBox_SirName.Size = new System.Drawing.Size(100, 20);
            this.textBox_SirName.TabIndex = 9;
            // 
            // button_SearchCustomer
            // 
            this.button_SearchCustomer.Location = new System.Drawing.Point(209, 4);
            this.button_SearchCustomer.Name = "button_SearchCustomer";
            this.button_SearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.button_SearchCustomer.TabIndex = 14;
            this.button_SearchCustomer.Text = "Søg";
            this.button_SearchCustomer.UseVisualStyleBackColor = true;
            this.button_SearchCustomer.Click += new System.EventHandler(this.button_SearchCustomer_Click);
            // 
            // comboBox_PhoneNumbers
            // 
            this.comboBox_PhoneNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PhoneNumbers.FormattingEnabled = true;
            this.comboBox_PhoneNumbers.Location = new System.Drawing.Point(103, 170);
            this.comboBox_PhoneNumbers.Name = "comboBox_PhoneNumbers";
            this.comboBox_PhoneNumbers.Size = new System.Drawing.Size(100, 21);
            this.comboBox_PhoneNumbers.TabIndex = 15;
            // 
            // comboBox_Adresses
            // 
            this.comboBox_Adresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Adresses.FormattingEnabled = true;
            this.comboBox_Adresses.Location = new System.Drawing.Point(103, 89);
            this.comboBox_Adresses.Name = "comboBox_Adresses";
            this.comboBox_Adresses.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Adresses.TabIndex = 16;
            this.comboBox_Adresses.SelectedIndexChanged += new System.EventHandler(this.comboBox_Adresses_SelectedIndexChanged);
            // 
            // textBox_CityName
            // 
            this.textBox_CityName.Location = new System.Drawing.Point(103, 116);
            this.textBox_CityName.Name = "textBox_CityName";
            this.textBox_CityName.ReadOnly = true;
            this.textBox_CityName.Size = new System.Drawing.Size(100, 20);
            this.textBox_CityName.TabIndex = 17;
            // 
            // textBox_PostalCode
            // 
            this.textBox_PostalCode.Location = new System.Drawing.Point(103, 143);
            this.textBox_PostalCode.Name = "textBox_PostalCode";
            this.textBox_PostalCode.ReadOnly = true;
            this.textBox_PostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBox_PostalCode.TabIndex = 18;
            // 
            // button_EditFName
            // 
            this.button_EditFName.Location = new System.Drawing.Point(3, 3);
            this.button_EditFName.Name = "button_EditFName";
            this.button_EditFName.Size = new System.Drawing.Size(75, 23);
            this.button_EditFName.TabIndex = 19;
            this.button_EditFName.Text = "Rediger";
            this.button_EditFName.UseVisualStyleBackColor = true;
            this.button_EditFName.Click += new System.EventHandler(this.button_EditFName_Click);
            // 
            // button_EditSurName
            // 
            this.button_EditSurName.Location = new System.Drawing.Point(3, 29);
            this.button_EditSurName.Name = "button_EditSurName";
            this.button_EditSurName.Size = new System.Drawing.Size(75, 23);
            this.button_EditSurName.TabIndex = 20;
            this.button_EditSurName.Text = "Rediger";
            this.button_EditSurName.UseVisualStyleBackColor = true;
            this.button_EditSurName.Click += new System.EventHandler(this.button_EditSurName_Click);
            // 
            // button_EditAdress
            // 
            this.button_EditAdress.Location = new System.Drawing.Point(3, 55);
            this.button_EditAdress.Name = "button_EditAdress";
            this.button_EditAdress.Size = new System.Drawing.Size(75, 23);
            this.button_EditAdress.TabIndex = 21;
            this.button_EditAdress.Text = "Rediger";
            this.button_EditAdress.UseVisualStyleBackColor = true;
            // 
            // button_EditPhone
            // 
            this.button_EditPhone.Location = new System.Drawing.Point(3, 136);
            this.button_EditPhone.Name = "button_EditPhone";
            this.button_EditPhone.Size = new System.Drawing.Size(75, 23);
            this.button_EditPhone.TabIndex = 24;
            this.button_EditPhone.Text = "Rediger";
            this.button_EditPhone.UseVisualStyleBackColor = true;
            this.button_EditPhone.Click += new System.EventHandler(this.button_EditPhone_Click);
            // 
            // panel_Edit
            // 
            this.panel_Edit.Controls.Add(this.button_EditAdress);
            this.panel_Edit.Controls.Add(this.button_EditPhone);
            this.panel_Edit.Controls.Add(this.button_EditFName);
            this.panel_Edit.Controls.Add(this.button_EditSurName);
            this.panel_Edit.Location = new System.Drawing.Point(209, 32);
            this.panel_Edit.Name = "panel_Edit";
            this.panel_Edit.Size = new System.Drawing.Size(84, 167);
            this.panel_Edit.TabIndex = 25;
            this.panel_Edit.Visible = false;
            // 
            // button_ToggleEdit
            // 
            this.button_ToggleEdit.Location = new System.Drawing.Point(212, 205);
            this.button_ToggleEdit.Name = "button_ToggleEdit";
            this.button_ToggleEdit.Size = new System.Drawing.Size(75, 23);
            this.button_ToggleEdit.TabIndex = 26;
            this.button_ToggleEdit.Text = "Rediger";
            this.button_ToggleEdit.UseVisualStyleBackColor = true;
            this.button_ToggleEdit.Visible = false;
            this.button_ToggleEdit.Click += new System.EventHandler(this.button_ToggleEdit_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(103, 170);
            this.maskedTextBox1.Mask = "00000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 27;
            this.maskedTextBox1.Visible = false;
            // 
            // button_CreateCustomer
            // 
            this.button_CreateCustomer.Location = new System.Drawing.Point(116, 205);
            this.button_CreateCustomer.Name = "button_CreateCustomer";
            this.button_CreateCustomer.Size = new System.Drawing.Size(87, 23);
            this.button_CreateCustomer.TabIndex = 28;
            this.button_CreateCustomer.Text = "Opret Kunde";
            this.button_CreateCustomer.UseVisualStyleBackColor = true;
            this.button_CreateCustomer.Click += new System.EventHandler(this.button_CreateCustomer_Click);
            // 
            // Form_Customer_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 252);
            this.Controls.Add(this.button_CreateCustomer);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button_ToggleEdit);
            this.Controls.Add(this.panel_Edit);
            this.Controls.Add(this.textBox_PostalCode);
            this.Controls.Add(this.textBox_CityName);
            this.Controls.Add(this.comboBox_Adresses);
            this.Controls.Add(this.comboBox_PhoneNumbers);
            this.Controls.Add(this.button_SearchCustomer);
            this.Controls.Add(this.textBox_SirName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_CustomerId);
            this.Controls.Add(this.label_Tlf);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label_PostalCode);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_SirName);
            this.Controls.Add(this.label_Firstname);
            this.Controls.Add(this.label_Id);
            this.Name = "Form_Customer_1";
            this.Text = "Form_Customer_1";
            this.panel_Edit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Firstname;
        private System.Windows.Forms.Label label_SirName;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Label label_PostalCode;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_Tlf;
        private System.Windows.Forms.TextBox textBox_CustomerId;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_SirName;
        private System.Windows.Forms.Button button_SearchCustomer;
        private System.Windows.Forms.ComboBox comboBox_PhoneNumbers;
        private System.Windows.Forms.ComboBox comboBox_Adresses;
        private System.Windows.Forms.TextBox textBox_CityName;
        private System.Windows.Forms.TextBox textBox_PostalCode;
        private System.Windows.Forms.Button button_EditFName;
        private System.Windows.Forms.Button button_EditSurName;
        private System.Windows.Forms.Button button_EditAdress;
        private System.Windows.Forms.Button button_EditPhone;
        private System.Windows.Forms.Panel panel_Edit;
        private System.Windows.Forms.Button button_ToggleEdit;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button_CreateCustomer;
    }
}