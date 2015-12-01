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
            this.comboBox_PostalCodes = new System.Windows.Forms.ComboBox();
            this.comboBox_Cities = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(18, 18);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(18, 13);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "ID";
            // 
            // label_Firstname
            // 
            this.label_Firstname.AutoSize = true;
            this.label_Firstname.Location = new System.Drawing.Point(18, 44);
            this.label_Firstname.Name = "label_Firstname";
            this.label_Firstname.Size = new System.Drawing.Size(46, 13);
            this.label_Firstname.TabIndex = 1;
            this.label_Firstname.Text = "Fornavn";
            // 
            // label_SirName
            // 
            this.label_SirName.AutoSize = true;
            this.label_SirName.Location = new System.Drawing.Point(18, 70);
            this.label_SirName.Name = "label_SirName";
            this.label_SirName.Size = new System.Drawing.Size(53, 13);
            this.label_SirName.TabIndex = 2;
            this.label_SirName.Text = "Efternavn";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(18, 96);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(45, 13);
            this.label_Adress.TabIndex = 3;
            this.label_Adress.Text = "Adresse";
            // 
            // label_PostalCode
            // 
            this.label_PostalCode.AutoSize = true;
            this.label_PostalCode.Location = new System.Drawing.Point(18, 123);
            this.label_PostalCode.Name = "label_PostalCode";
            this.label_PostalCode.Size = new System.Drawing.Size(65, 13);
            this.label_PostalCode.TabIndex = 4;
            this.label_PostalCode.Text = "Postnummer";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(18, 150);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(43, 13);
            this.label_City.TabIndex = 5;
            this.label_City.Text = "Bynavn";
            // 
            // label_Tlf
            // 
            this.label_Tlf.AutoSize = true;
            this.label_Tlf.Location = new System.Drawing.Point(18, 177);
            this.label_Tlf.Name = "label_Tlf";
            this.label_Tlf.Size = new System.Drawing.Size(85, 13);
            this.label_Tlf.TabIndex = 6;
            this.label_Tlf.Text = "Telefon Nummer";
            // 
            // textBox_CustomerId
            // 
            this.textBox_CustomerId.Location = new System.Drawing.Point(109, 15);
            this.textBox_CustomerId.Name = "textBox_CustomerId";
            this.textBox_CustomerId.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerId.TabIndex = 7;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(109, 41);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_FirstName.TabIndex = 8;
            // 
            // textBox_SirName
            // 
            this.textBox_SirName.Location = new System.Drawing.Point(109, 67);
            this.textBox_SirName.Name = "textBox_SirName";
            this.textBox_SirName.Size = new System.Drawing.Size(100, 20);
            this.textBox_SirName.TabIndex = 9;
            // 
            // button_SearchCustomer
            // 
            this.button_SearchCustomer.Location = new System.Drawing.Point(215, 13);
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
            this.comboBox_PhoneNumbers.Location = new System.Drawing.Point(109, 174);
            this.comboBox_PhoneNumbers.Name = "comboBox_PhoneNumbers";
            this.comboBox_PhoneNumbers.Size = new System.Drawing.Size(100, 21);
            this.comboBox_PhoneNumbers.TabIndex = 15;
            // 
            // comboBox_Adresses
            // 
            this.comboBox_Adresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Adresses.FormattingEnabled = true;
            this.comboBox_Adresses.Location = new System.Drawing.Point(109, 93);
            this.comboBox_Adresses.Name = "comboBox_Adresses";
            this.comboBox_Adresses.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Adresses.TabIndex = 16;
            // 
            // comboBox_PostalCodes
            // 
            this.comboBox_PostalCodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PostalCodes.FormattingEnabled = true;
            this.comboBox_PostalCodes.Location = new System.Drawing.Point(109, 120);
            this.comboBox_PostalCodes.Name = "comboBox_PostalCodes";
            this.comboBox_PostalCodes.Size = new System.Drawing.Size(100, 21);
            this.comboBox_PostalCodes.TabIndex = 17;
            // 
            // comboBox_Cities
            // 
            this.comboBox_Cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cities.FormattingEnabled = true;
            this.comboBox_Cities.Location = new System.Drawing.Point(109, 147);
            this.comboBox_Cities.Name = "comboBox_Cities";
            this.comboBox_Cities.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Cities.TabIndex = 18;
            // 
            // Form_Customer_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 423);
            this.Controls.Add(this.comboBox_Cities);
            this.Controls.Add(this.comboBox_PostalCodes);
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
        private System.Windows.Forms.ComboBox comboBox_PostalCodes;
        private System.Windows.Forms.ComboBox comboBox_Cities;
    }
}