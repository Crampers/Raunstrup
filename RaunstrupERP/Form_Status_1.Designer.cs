namespace RaunstrupERP
{
    partial class Form_Status_1
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
            this.label_OrderID = new System.Windows.Forms.Label();
            this.maskedTextBox_OrderID = new System.Windows.Forms.MaskedTextBox();
            this.listBox_WorkTasks = new System.Windows.Forms.ListBox();
            this.label_Opgaver = new System.Windows.Forms.Label();
            this.button_findOrder = new System.Windows.Forms.Button();
            this.panel_CustomerSalesInfo = new System.Windows.Forms.Panel();
            this.panel_OrderInfo = new System.Windows.Forms.Panel();
            this.panel_TasksInfo = new System.Windows.Forms.Panel();
            this.label_Items = new System.Windows.Forms.Label();
            this.listBox_Materials = new System.Windows.Forms.ListBox();
            this.listBox_Employees = new System.Windows.Forms.ListBox();
            this.label_TaskEmployees = new System.Windows.Forms.Label();
            this.textBox_CustomerId = new System.Windows.Forms.TextBox();
            this.label_CustomerId = new System.Windows.Forms.Label();
            this.textBox_SalesmanPhone = new System.Windows.Forms.TextBox();
            this.label_SalesmanPhone = new System.Windows.Forms.Label();
            this.textBox_CustomerPhone = new System.Windows.Forms.TextBox();
            this.label_CustomerPhone = new System.Windows.Forms.Label();
            this.textBox_CustomerCity = new System.Windows.Forms.TextBox();
            this.label_CustomerCity = new System.Windows.Forms.Label();
            this.textBox_CustomerPostalCode = new System.Windows.Forms.TextBox();
            this.label_CustomerPostalCode = new System.Windows.Forms.Label();
            this.textBox_CustomerAdress = new System.Windows.Forms.TextBox();
            this.label_CustomerAdress = new System.Windows.Forms.Label();
            this.textBox_Salesman = new System.Windows.Forms.TextBox();
            this.label_Salesman = new System.Windows.Forms.Label();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.label_CustomerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_MaterialInformation = new System.Windows.Forms.Label();
            this.textBox_MaterialeName = new System.Windows.Forms.TextBox();
            this.checkBox_IsComplete = new System.Windows.Forms.CheckBox();
            this.panel_CustomerSalesInfo.SuspendLayout();
            this.panel_OrderInfo.SuspendLayout();
            this.panel_TasksInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_OrderID
            // 
            this.label_OrderID.AutoSize = true;
            this.label_OrderID.Location = new System.Drawing.Point(15, 9);
            this.label_OrderID.Name = "label_OrderID";
            this.label_OrderID.Size = new System.Drawing.Size(75, 13);
            this.label_OrderID.TabIndex = 0;
            this.label_OrderID.Text = "Ordre Nummer";
            // 
            // maskedTextBox_OrderID
            // 
            this.maskedTextBox_OrderID.Location = new System.Drawing.Point(96, 6);
            this.maskedTextBox_OrderID.Mask = "9999999999";
            this.maskedTextBox_OrderID.Name = "maskedTextBox_OrderID";
            this.maskedTextBox_OrderID.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBox_OrderID.TabIndex = 1;
            // 
            // listBox_WorkTasks
            // 
            this.listBox_WorkTasks.FormattingEnabled = true;
            this.listBox_WorkTasks.Location = new System.Drawing.Point(6, 16);
            this.listBox_WorkTasks.Name = "listBox_WorkTasks";
            this.listBox_WorkTasks.Size = new System.Drawing.Size(221, 199);
            this.listBox_WorkTasks.TabIndex = 2;
            this.listBox_WorkTasks.SelectedIndexChanged += new System.EventHandler(this.listBox_WorkTasks_SelectedIndexChanged);
            // 
            // label_Opgaver
            // 
            this.label_Opgaver.AutoSize = true;
            this.label_Opgaver.Location = new System.Drawing.Point(3, 0);
            this.label_Opgaver.Name = "label_Opgaver";
            this.label_Opgaver.Size = new System.Drawing.Size(48, 13);
            this.label_Opgaver.TabIndex = 3;
            this.label_Opgaver.Text = "Opgaver";
            // 
            // button_findOrder
            // 
            this.button_findOrder.Location = new System.Drawing.Point(146, 4);
            this.button_findOrder.Name = "button_findOrder";
            this.button_findOrder.Size = new System.Drawing.Size(75, 23);
            this.button_findOrder.TabIndex = 4;
            this.button_findOrder.Text = "Find Ordre";
            this.button_findOrder.UseVisualStyleBackColor = true;
            this.button_findOrder.Click += new System.EventHandler(this.button_findOrder_Click);
            // 
            // panel_CustomerSalesInfo
            // 
            this.panel_CustomerSalesInfo.Controls.Add(this.panel1);
            this.panel_CustomerSalesInfo.Controls.Add(this.panel_OrderInfo);
            this.panel_CustomerSalesInfo.Controls.Add(this.panel_TasksInfo);
            this.panel_CustomerSalesInfo.Controls.Add(this.textBox_CustomerId);
            this.panel_CustomerSalesInfo.Controls.Add(this.label_CustomerId);
            this.panel_CustomerSalesInfo.Controls.Add(this.textBox_SalesmanPhone);
            this.panel_CustomerSalesInfo.Controls.Add(this.label_SalesmanPhone);
            this.panel_CustomerSalesInfo.Controls.Add(this.textBox_CustomerPhone);
            this.panel_CustomerSalesInfo.Controls.Add(this.label_CustomerPhone);
            this.panel_CustomerSalesInfo.Controls.Add(this.textBox_CustomerCity);
            this.panel_CustomerSalesInfo.Controls.Add(this.label_CustomerCity);
            this.panel_CustomerSalesInfo.Controls.Add(this.textBox_CustomerPostalCode);
            this.panel_CustomerSalesInfo.Controls.Add(this.label_CustomerPostalCode);
            this.panel_CustomerSalesInfo.Controls.Add(this.textBox_CustomerAdress);
            this.panel_CustomerSalesInfo.Controls.Add(this.label_CustomerAdress);
            this.panel_CustomerSalesInfo.Controls.Add(this.textBox_Salesman);
            this.panel_CustomerSalesInfo.Controls.Add(this.label_Salesman);
            this.panel_CustomerSalesInfo.Controls.Add(this.textBox_CustomerName);
            this.panel_CustomerSalesInfo.Controls.Add(this.label_CustomerName);
            this.panel_CustomerSalesInfo.Location = new System.Drawing.Point(12, 33);
            this.panel_CustomerSalesInfo.Name = "panel_CustomerSalesInfo";
            this.panel_CustomerSalesInfo.Size = new System.Drawing.Size(879, 606);
            this.panel_CustomerSalesInfo.TabIndex = 5;
            // 
            // panel_OrderInfo
            // 
            this.panel_OrderInfo.Controls.Add(this.listBox_WorkTasks);
            this.panel_OrderInfo.Controls.Add(this.label_Opgaver);
            this.panel_OrderInfo.Location = new System.Drawing.Point(6, 87);
            this.panel_OrderInfo.Name = "panel_OrderInfo";
            this.panel_OrderInfo.Size = new System.Drawing.Size(479, 244);
            this.panel_OrderInfo.TabIndex = 23;
            // 
            // panel_TasksInfo
            // 
            this.panel_TasksInfo.Controls.Add(this.label_Items);
            this.panel_TasksInfo.Controls.Add(this.listBox_Materials);
            this.panel_TasksInfo.Controls.Add(this.listBox_Employees);
            this.panel_TasksInfo.Controls.Add(this.label_TaskEmployees);
            this.panel_TasksInfo.Location = new System.Drawing.Point(6, 337);
            this.panel_TasksInfo.Name = "panel_TasksInfo";
            this.panel_TasksInfo.Size = new System.Drawing.Size(479, 236);
            this.panel_TasksInfo.TabIndex = 22;
            // 
            // label_Items
            // 
            this.label_Items.AutoSize = true;
            this.label_Items.Location = new System.Drawing.Point(233, 0);
            this.label_Items.Name = "label_Items";
            this.label_Items.Size = new System.Drawing.Size(53, 13);
            this.label_Items.TabIndex = 23;
            this.label_Items.Text = "Materialer";
            // 
            // listBox_Materials
            // 
            this.listBox_Materials.FormattingEnabled = true;
            this.listBox_Materials.Location = new System.Drawing.Point(233, 16);
            this.listBox_Materials.Name = "listBox_Materials";
            this.listBox_Materials.Size = new System.Drawing.Size(238, 160);
            this.listBox_Materials.TabIndex = 22;
            this.listBox_Materials.SelectedIndexChanged += new System.EventHandler(this.listBox_Materials_SelectedIndexChanged);
            // 
            // listBox_Employees
            // 
            this.listBox_Employees.FormattingEnabled = true;
            this.listBox_Employees.Location = new System.Drawing.Point(6, 16);
            this.listBox_Employees.Name = "listBox_Employees";
            this.listBox_Employees.Size = new System.Drawing.Size(221, 160);
            this.listBox_Employees.TabIndex = 21;
            // 
            // label_TaskEmployees
            // 
            this.label_TaskEmployees.AutoSize = true;
            this.label_TaskEmployees.Location = new System.Drawing.Point(3, 0);
            this.label_TaskEmployees.Name = "label_TaskEmployees";
            this.label_TaskEmployees.Size = new System.Drawing.Size(72, 13);
            this.label_TaskEmployees.TabIndex = 20;
            this.label_TaskEmployees.Text = "Medarbejdere";
            // 
            // textBox_CustomerId
            // 
            this.textBox_CustomerId.Location = new System.Drawing.Point(3, 22);
            this.textBox_CustomerId.Name = "textBox_CustomerId";
            this.textBox_CustomerId.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerId.TabIndex = 19;
            // 
            // label_CustomerId
            // 
            this.label_CustomerId.AutoSize = true;
            this.label_CustomerId.Location = new System.Drawing.Point(3, 6);
            this.label_CustomerId.Name = "label_CustomerId";
            this.label_CustomerId.Size = new System.Drawing.Size(75, 13);
            this.label_CustomerId.TabIndex = 18;
            this.label_CustomerId.Text = "Kundenummer";
            // 
            // textBox_SalesmanPhone
            // 
            this.textBox_SalesmanPhone.Location = new System.Drawing.Point(109, 61);
            this.textBox_SalesmanPhone.Name = "textBox_SalesmanPhone";
            this.textBox_SalesmanPhone.Size = new System.Drawing.Size(100, 20);
            this.textBox_SalesmanPhone.TabIndex = 17;
            // 
            // label_SalesmanPhone
            // 
            this.label_SalesmanPhone.AutoSize = true;
            this.label_SalesmanPhone.Location = new System.Drawing.Point(106, 45);
            this.label_SalesmanPhone.Name = "label_SalesmanPhone";
            this.label_SalesmanPhone.Size = new System.Drawing.Size(60, 13);
            this.label_SalesmanPhone.TabIndex = 16;
            this.label_SalesmanPhone.Text = "Telefon Nr.";
            // 
            // textBox_CustomerPhone
            // 
            this.textBox_CustomerPhone.Location = new System.Drawing.Point(482, 22);
            this.textBox_CustomerPhone.Name = "textBox_CustomerPhone";
            this.textBox_CustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerPhone.TabIndex = 15;
            // 
            // label_CustomerPhone
            // 
            this.label_CustomerPhone.AutoSize = true;
            this.label_CustomerPhone.Location = new System.Drawing.Point(479, 6);
            this.label_CustomerPhone.Name = "label_CustomerPhone";
            this.label_CustomerPhone.Size = new System.Drawing.Size(60, 13);
            this.label_CustomerPhone.TabIndex = 14;
            this.label_CustomerPhone.Text = "Telefon Nr.";
            // 
            // textBox_CustomerCity
            // 
            this.textBox_CustomerCity.Location = new System.Drawing.Point(377, 22);
            this.textBox_CustomerCity.Name = "textBox_CustomerCity";
            this.textBox_CustomerCity.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerCity.TabIndex = 13;
            // 
            // label_CustomerCity
            // 
            this.label_CustomerCity.AutoSize = true;
            this.label_CustomerCity.Location = new System.Drawing.Point(377, 6);
            this.label_CustomerCity.Name = "label_CustomerCity";
            this.label_CustomerCity.Size = new System.Drawing.Size(19, 13);
            this.label_CustomerCity.TabIndex = 12;
            this.label_CustomerCity.Text = "By";
            // 
            // textBox_CustomerPostalCode
            // 
            this.textBox_CustomerPostalCode.Location = new System.Drawing.Point(321, 22);
            this.textBox_CustomerPostalCode.Name = "textBox_CustomerPostalCode";
            this.textBox_CustomerPostalCode.Size = new System.Drawing.Size(50, 20);
            this.textBox_CustomerPostalCode.TabIndex = 11;
            // 
            // label_CustomerPostalCode
            // 
            this.label_CustomerPostalCode.AutoSize = true;
            this.label_CustomerPostalCode.Location = new System.Drawing.Point(318, 6);
            this.label_CustomerPostalCode.Name = "label_CustomerPostalCode";
            this.label_CustomerPostalCode.Size = new System.Drawing.Size(45, 13);
            this.label_CustomerPostalCode.TabIndex = 10;
            this.label_CustomerPostalCode.Text = "Post Nr.";
            // 
            // textBox_CustomerAdress
            // 
            this.textBox_CustomerAdress.Location = new System.Drawing.Point(215, 22);
            this.textBox_CustomerAdress.Name = "textBox_CustomerAdress";
            this.textBox_CustomerAdress.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerAdress.TabIndex = 9;
            // 
            // label_CustomerAdress
            // 
            this.label_CustomerAdress.AutoSize = true;
            this.label_CustomerAdress.Location = new System.Drawing.Point(212, 6);
            this.label_CustomerAdress.Name = "label_CustomerAdress";
            this.label_CustomerAdress.Size = new System.Drawing.Size(45, 13);
            this.label_CustomerAdress.TabIndex = 8;
            this.label_CustomerAdress.Text = "Adresse";
            // 
            // textBox_Salesman
            // 
            this.textBox_Salesman.Location = new System.Drawing.Point(3, 61);
            this.textBox_Salesman.Name = "textBox_Salesman";
            this.textBox_Salesman.Size = new System.Drawing.Size(100, 20);
            this.textBox_Salesman.TabIndex = 7;
            // 
            // label_Salesman
            // 
            this.label_Salesman.AutoSize = true;
            this.label_Salesman.Location = new System.Drawing.Point(3, 45);
            this.label_Salesman.Name = "label_Salesman";
            this.label_Salesman.Size = new System.Drawing.Size(41, 13);
            this.label_Salesman.TabIndex = 6;
            this.label_Salesman.Text = "Sælger";
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Location = new System.Drawing.Point(109, 22);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(100, 20);
            this.textBox_CustomerName.TabIndex = 5;
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.AutoSize = true;
            this.label_CustomerName.Location = new System.Drawing.Point(106, 6);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(33, 13);
            this.label_CustomerName.TabIndex = 4;
            this.label_CustomerName.Text = "Navn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox_IsComplete);
            this.panel1.Controls.Add(this.textBox_MaterialeName);
            this.panel1.Controls.Add(this.label_MaterialInformation);
            this.panel1.Location = new System.Drawing.Point(491, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 236);
            this.panel1.TabIndex = 24;
            // 
            // label_MaterialInformation
            // 
            this.label_MaterialInformation.AutoSize = true;
            this.label_MaterialInformation.Location = new System.Drawing.Point(3, 0);
            this.label_MaterialInformation.Name = "label_MaterialInformation";
            this.label_MaterialInformation.Size = new System.Drawing.Size(71, 13);
            this.label_MaterialInformation.TabIndex = 24;
            this.label_MaterialInformation.Text = "Materiale Info";
            // 
            // textBox_MaterialeName
            // 
            this.textBox_MaterialeName.Location = new System.Drawing.Point(6, 16);
            this.textBox_MaterialeName.Name = "textBox_MaterialeName";
            this.textBox_MaterialeName.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaterialeName.TabIndex = 25;
            // 
            // checkBox_IsComplete
            // 
            this.checkBox_IsComplete.AutoSize = true;
            this.checkBox_IsComplete.Location = new System.Drawing.Point(112, 18);
            this.checkBox_IsComplete.Name = "checkBox_IsComplete";
            this.checkBox_IsComplete.Size = new System.Drawing.Size(59, 17);
            this.checkBox_IsComplete.TabIndex = 26;
            this.checkBox_IsComplete.Text = "Færdig";
            this.checkBox_IsComplete.UseVisualStyleBackColor = true;
            // 
            // Form_Status_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 651);
            this.Controls.Add(this.panel_CustomerSalesInfo);
            this.Controls.Add(this.button_findOrder);
            this.Controls.Add(this.maskedTextBox_OrderID);
            this.Controls.Add(this.label_OrderID);
            this.MinimizeBox = false;
            this.Name = "Form_Status_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Status_1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Status_1_FormClosed);
            this.panel_CustomerSalesInfo.ResumeLayout(false);
            this.panel_CustomerSalesInfo.PerformLayout();
            this.panel_OrderInfo.ResumeLayout(false);
            this.panel_OrderInfo.PerformLayout();
            this.panel_TasksInfo.ResumeLayout(false);
            this.panel_TasksInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_OrderID;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_OrderID;
        private System.Windows.Forms.ListBox listBox_WorkTasks;
        private System.Windows.Forms.Label label_Opgaver;
        private System.Windows.Forms.Button button_findOrder;
        private System.Windows.Forms.Panel panel_CustomerSalesInfo;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.Label label_CustomerName;
        private System.Windows.Forms.TextBox textBox_Salesman;
        private System.Windows.Forms.Label label_Salesman;
        private System.Windows.Forms.TextBox textBox_CustomerAdress;
        private System.Windows.Forms.Label label_CustomerAdress;
        private System.Windows.Forms.TextBox textBox_CustomerCity;
        private System.Windows.Forms.Label label_CustomerCity;
        private System.Windows.Forms.TextBox textBox_CustomerPostalCode;
        private System.Windows.Forms.Label label_CustomerPostalCode;
        private System.Windows.Forms.TextBox textBox_CustomerPhone;
        private System.Windows.Forms.Label label_CustomerPhone;
        private System.Windows.Forms.TextBox textBox_SalesmanPhone;
        private System.Windows.Forms.Label label_SalesmanPhone;
        private System.Windows.Forms.TextBox textBox_CustomerId;
        private System.Windows.Forms.Label label_CustomerId;
        private System.Windows.Forms.Label label_TaskEmployees;
        private System.Windows.Forms.ListBox listBox_Employees;
        private System.Windows.Forms.Panel panel_TasksInfo;
        private System.Windows.Forms.Panel panel_OrderInfo;
        private System.Windows.Forms.Label label_Items;
        private System.Windows.Forms.ListBox listBox_Materials;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_MaterialInformation;
        private System.Windows.Forms.TextBox textBox_MaterialeName;
        private System.Windows.Forms.CheckBox checkBox_IsComplete;
    }
}