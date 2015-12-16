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
            this.listBox_WorkTasks = new System.Windows.Forms.ListBox();
            this.label_Opgaver = new System.Windows.Forms.Label();
            this.button_findOrder = new System.Windows.Forms.Button();
            this.panel_CustomerSalesInfo = new System.Windows.Forms.Panel();
            this.panel_MaterialInfo = new System.Windows.Forms.Panel();
            this.button_AddCompleteItems = new System.Windows.Forms.Button();
            this.numericUpDown_AmountCompleted = new System.Windows.Forms.NumericUpDown();
            this.checkBox_ItemLineIsComplete = new System.Windows.Forms.CheckBox();
            this.textBox_MaterialeName = new System.Windows.Forms.TextBox();
            this.label_MaterialInformation = new System.Windows.Forms.Label();
            this.panel_OrderInfo = new System.Windows.Forms.Panel();
            this.label_OrderCost = new System.Windows.Forms.Label();
            this.textBox_OrderCost = new System.Windows.Forms.TextBox();
            this.label_OrderValue = new System.Windows.Forms.Label();
            this.textBox_OrderValue = new System.Windows.Forms.TextBox();
            this.textBox_TaskValueCompletedTotal = new System.Windows.Forms.TextBox();
            this.checkBox_TaskIsComplete = new System.Windows.Forms.CheckBox();
            this.label_TaskValueCompleted = new System.Windows.Forms.Label();
            this.label_TaskValueTotal = new System.Windows.Forms.Label();
            this.textBox_TaskValueTotal = new System.Windows.Forms.TextBox();
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
            this.numericUpDown_OrderID = new System.Windows.Forms.NumericUpDown();
            this.button_PrintXML = new System.Windows.Forms.Button();
            this.button_ReadXML = new System.Windows.Forms.Button();
            this.button_PrintReceipt = new System.Windows.Forms.Button();
            this.panel_CustomerSalesInfo.SuspendLayout();
            this.panel_MaterialInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AmountCompleted)).BeginInit();
            this.panel_OrderInfo.SuspendLayout();
            this.panel_TasksInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OrderID)).BeginInit();
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
            this.panel_CustomerSalesInfo.Controls.Add(this.panel_MaterialInfo);
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
            this.panel_CustomerSalesInfo.Size = new System.Drawing.Size(821, 464);
            this.panel_CustomerSalesInfo.TabIndex = 5;
            // 
            // panel_MaterialInfo
            // 
            this.panel_MaterialInfo.Controls.Add(this.button_AddCompleteItems);
            this.panel_MaterialInfo.Controls.Add(this.numericUpDown_AmountCompleted);
            this.panel_MaterialInfo.Controls.Add(this.checkBox_ItemLineIsComplete);
            this.panel_MaterialInfo.Controls.Add(this.textBox_MaterialeName);
            this.panel_MaterialInfo.Controls.Add(this.label_MaterialInformation);
            this.panel_MaterialInfo.Location = new System.Drawing.Point(332, 337);
            this.panel_MaterialInfo.Name = "panel_MaterialInfo";
            this.panel_MaterialInfo.Size = new System.Drawing.Size(243, 110);
            this.panel_MaterialInfo.TabIndex = 24;
            // 
            // button_AddCompleteItems
            // 
            this.button_AddCompleteItems.Location = new System.Drawing.Point(6, 68);
            this.button_AddCompleteItems.Name = "button_AddCompleteItems";
            this.button_AddCompleteItems.Size = new System.Drawing.Size(75, 23);
            this.button_AddCompleteItems.TabIndex = 28;
            this.button_AddCompleteItems.Text = "Afregn";
            this.button_AddCompleteItems.UseVisualStyleBackColor = true;
            this.button_AddCompleteItems.Click += new System.EventHandler(this.button_AddCompleteItems_Click);
            // 
            // numericUpDown_AmountCompleted
            // 
            this.numericUpDown_AmountCompleted.Location = new System.Drawing.Point(6, 42);
            this.numericUpDown_AmountCompleted.Name = "numericUpDown_AmountCompleted";
            this.numericUpDown_AmountCompleted.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_AmountCompleted.TabIndex = 27;
            // 
            // checkBox_ItemLineIsComplete
            // 
            this.checkBox_ItemLineIsComplete.AutoSize = true;
            this.checkBox_ItemLineIsComplete.Location = new System.Drawing.Point(112, 18);
            this.checkBox_ItemLineIsComplete.Name = "checkBox_ItemLineIsComplete";
            this.checkBox_ItemLineIsComplete.Size = new System.Drawing.Size(59, 17);
            this.checkBox_ItemLineIsComplete.TabIndex = 26;
            this.checkBox_ItemLineIsComplete.Text = "Færdig";
            this.checkBox_ItemLineIsComplete.UseVisualStyleBackColor = true;
            this.checkBox_ItemLineIsComplete.CheckedChanged += new System.EventHandler(this.checkBox_IsComplete_CheckedChanged);
            // 
            // textBox_MaterialeName
            // 
            this.textBox_MaterialeName.Location = new System.Drawing.Point(6, 16);
            this.textBox_MaterialeName.Name = "textBox_MaterialeName";
            this.textBox_MaterialeName.ReadOnly = true;
            this.textBox_MaterialeName.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaterialeName.TabIndex = 25;
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
            // panel_OrderInfo
            // 
            this.panel_OrderInfo.Controls.Add(this.label_OrderCost);
            this.panel_OrderInfo.Controls.Add(this.textBox_OrderCost);
            this.panel_OrderInfo.Controls.Add(this.label_OrderValue);
            this.panel_OrderInfo.Controls.Add(this.textBox_OrderValue);
            this.panel_OrderInfo.Controls.Add(this.textBox_TaskValueCompletedTotal);
            this.panel_OrderInfo.Controls.Add(this.checkBox_TaskIsComplete);
            this.panel_OrderInfo.Controls.Add(this.label_TaskValueCompleted);
            this.panel_OrderInfo.Controls.Add(this.listBox_WorkTasks);
            this.panel_OrderInfo.Controls.Add(this.label_Opgaver);
            this.panel_OrderInfo.Controls.Add(this.label_TaskValueTotal);
            this.panel_OrderInfo.Controls.Add(this.textBox_TaskValueTotal);
            this.panel_OrderInfo.Location = new System.Drawing.Point(6, 87);
            this.panel_OrderInfo.Name = "panel_OrderInfo";
            this.panel_OrderInfo.Size = new System.Drawing.Size(320, 312);
            this.panel_OrderInfo.TabIndex = 23;
            // 
            // label_OrderCost
            // 
            this.label_OrderCost.AutoSize = true;
            this.label_OrderCost.Location = new System.Drawing.Point(109, 257);
            this.label_OrderCost.Name = "label_OrderCost";
            this.label_OrderCost.Size = new System.Drawing.Size(101, 13);
            this.label_OrderCost.TabIndex = 30;
            this.label_OrderCost.Text = "Ordre Omkostninger";
            // 
            // textBox_OrderCost
            // 
            this.textBox_OrderCost.Location = new System.Drawing.Point(112, 273);
            this.textBox_OrderCost.Name = "textBox_OrderCost";
            this.textBox_OrderCost.ReadOnly = true;
            this.textBox_OrderCost.Size = new System.Drawing.Size(100, 20);
            this.textBox_OrderCost.TabIndex = 31;
            // 
            // label_OrderValue
            // 
            this.label_OrderValue.AutoSize = true;
            this.label_OrderValue.Location = new System.Drawing.Point(3, 257);
            this.label_OrderValue.Name = "label_OrderValue";
            this.label_OrderValue.Size = new System.Drawing.Size(64, 13);
            this.label_OrderValue.TabIndex = 28;
            this.label_OrderValue.Text = "Ordre Værdi";
            // 
            // textBox_OrderValue
            // 
            this.textBox_OrderValue.Location = new System.Drawing.Point(6, 273);
            this.textBox_OrderValue.Name = "textBox_OrderValue";
            this.textBox_OrderValue.ReadOnly = true;
            this.textBox_OrderValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_OrderValue.TabIndex = 29;
            // 
            // textBox_TaskValueCompletedTotal
            // 
            this.textBox_TaskValueCompletedTotal.Location = new System.Drawing.Point(112, 234);
            this.textBox_TaskValueCompletedTotal.Name = "textBox_TaskValueCompletedTotal";
            this.textBox_TaskValueCompletedTotal.ReadOnly = true;
            this.textBox_TaskValueCompletedTotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_TaskValueCompletedTotal.TabIndex = 27;
            // 
            // checkBox_TaskIsComplete
            // 
            this.checkBox_TaskIsComplete.AutoSize = true;
            this.checkBox_TaskIsComplete.Location = new System.Drawing.Point(233, 16);
            this.checkBox_TaskIsComplete.Name = "checkBox_TaskIsComplete";
            this.checkBox_TaskIsComplete.Size = new System.Drawing.Size(59, 17);
            this.checkBox_TaskIsComplete.TabIndex = 27;
            this.checkBox_TaskIsComplete.Text = "Færdig";
            this.checkBox_TaskIsComplete.UseVisualStyleBackColor = true;
            // 
            // label_TaskValueCompleted
            // 
            this.label_TaskValueCompleted.AutoSize = true;
            this.label_TaskValueCompleted.Location = new System.Drawing.Point(109, 218);
            this.label_TaskValueCompleted.Name = "label_TaskValueCompleted";
            this.label_TaskValueCompleted.Size = new System.Drawing.Size(113, 13);
            this.label_TaskValueCompleted.TabIndex = 26;
            this.label_TaskValueCompleted.Text = "Opgave Omkostninger";
            // 
            // label_TaskValueTotal
            // 
            this.label_TaskValueTotal.AutoSize = true;
            this.label_TaskValueTotal.Location = new System.Drawing.Point(3, 218);
            this.label_TaskValueTotal.Name = "label_TaskValueTotal";
            this.label_TaskValueTotal.Size = new System.Drawing.Size(76, 13);
            this.label_TaskValueTotal.TabIndex = 24;
            this.label_TaskValueTotal.Text = "Opgave Værdi";
            // 
            // textBox_TaskValueTotal
            // 
            this.textBox_TaskValueTotal.Location = new System.Drawing.Point(6, 234);
            this.textBox_TaskValueTotal.Name = "textBox_TaskValueTotal";
            this.textBox_TaskValueTotal.ReadOnly = true;
            this.textBox_TaskValueTotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_TaskValueTotal.TabIndex = 25;
            // 
            // panel_TasksInfo
            // 
            this.panel_TasksInfo.Controls.Add(this.label_Items);
            this.panel_TasksInfo.Controls.Add(this.listBox_Materials);
            this.panel_TasksInfo.Controls.Add(this.listBox_Employees);
            this.panel_TasksInfo.Controls.Add(this.label_TaskEmployees);
            this.panel_TasksInfo.Location = new System.Drawing.Point(332, 87);
            this.panel_TasksInfo.Name = "panel_TasksInfo";
            this.panel_TasksInfo.Size = new System.Drawing.Size(479, 244);
            this.panel_TasksInfo.TabIndex = 22;
            // 
            // label_Items
            // 
            this.label_Items.AutoSize = true;
            this.label_Items.Location = new System.Drawing.Point(3, 0);
            this.label_Items.Name = "label_Items";
            this.label_Items.Size = new System.Drawing.Size(53, 13);
            this.label_Items.TabIndex = 23;
            this.label_Items.Text = "Materialer";
            // 
            // listBox_Materials
            // 
            this.listBox_Materials.FormattingEnabled = true;
            this.listBox_Materials.Location = new System.Drawing.Point(3, 16);
            this.listBox_Materials.Name = "listBox_Materials";
            this.listBox_Materials.Size = new System.Drawing.Size(238, 160);
            this.listBox_Materials.TabIndex = 22;
            this.listBox_Materials.SelectedIndexChanged += new System.EventHandler(this.listBox_Materials_SelectedIndexChanged);
            // 
            // listBox_Employees
            // 
            this.listBox_Employees.FormattingEnabled = true;
            this.listBox_Employees.Location = new System.Drawing.Point(250, 16);
            this.listBox_Employees.Name = "listBox_Employees";
            this.listBox_Employees.Size = new System.Drawing.Size(221, 160);
            this.listBox_Employees.TabIndex = 21;
            this.listBox_Employees.Visible = false;
            // 
            // label_TaskEmployees
            // 
            this.label_TaskEmployees.AutoSize = true;
            this.label_TaskEmployees.Location = new System.Drawing.Point(247, 0);
            this.label_TaskEmployees.Name = "label_TaskEmployees";
            this.label_TaskEmployees.Size = new System.Drawing.Size(72, 13);
            this.label_TaskEmployees.TabIndex = 20;
            this.label_TaskEmployees.Text = "Medarbejdere";
            this.label_TaskEmployees.Visible = false;
            // 
            // textBox_CustomerId
            // 
            this.textBox_CustomerId.Location = new System.Drawing.Point(3, 22);
            this.textBox_CustomerId.Name = "textBox_CustomerId";
            this.textBox_CustomerId.ReadOnly = true;
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
            this.textBox_SalesmanPhone.ReadOnly = true;
            this.textBox_SalesmanPhone.Size = new System.Drawing.Size(100, 20);
            this.textBox_SalesmanPhone.TabIndex = 17;
            this.textBox_SalesmanPhone.Visible = false;
            // 
            // label_SalesmanPhone
            // 
            this.label_SalesmanPhone.AutoSize = true;
            this.label_SalesmanPhone.Location = new System.Drawing.Point(106, 45);
            this.label_SalesmanPhone.Name = "label_SalesmanPhone";
            this.label_SalesmanPhone.Size = new System.Drawing.Size(60, 13);
            this.label_SalesmanPhone.TabIndex = 16;
            this.label_SalesmanPhone.Text = "Telefon Nr.";
            this.label_SalesmanPhone.Visible = false;
            // 
            // textBox_CustomerPhone
            // 
            this.textBox_CustomerPhone.Location = new System.Drawing.Point(482, 22);
            this.textBox_CustomerPhone.Name = "textBox_CustomerPhone";
            this.textBox_CustomerPhone.ReadOnly = true;
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
            this.textBox_CustomerCity.ReadOnly = true;
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
            this.textBox_CustomerPostalCode.ReadOnly = true;
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
            this.textBox_CustomerAdress.ReadOnly = true;
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
            this.textBox_Salesman.ReadOnly = true;
            this.textBox_Salesman.Size = new System.Drawing.Size(100, 20);
            this.textBox_Salesman.TabIndex = 7;
            this.textBox_Salesman.Visible = false;
            // 
            // label_Salesman
            // 
            this.label_Salesman.AutoSize = true;
            this.label_Salesman.Location = new System.Drawing.Point(3, 45);
            this.label_Salesman.Name = "label_Salesman";
            this.label_Salesman.Size = new System.Drawing.Size(41, 13);
            this.label_Salesman.TabIndex = 6;
            this.label_Salesman.Text = "Sælger";
            this.label_Salesman.Visible = false;
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Location = new System.Drawing.Point(109, 22);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.ReadOnly = true;
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
            // numericUpDown_OrderID
            // 
            this.numericUpDown_OrderID.Location = new System.Drawing.Point(91, 6);
            this.numericUpDown_OrderID.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_OrderID.Name = "numericUpDown_OrderID";
            this.numericUpDown_OrderID.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_OrderID.TabIndex = 6;
            // 
            // button_PrintXML
            // 
            this.button_PrintXML.Location = new System.Drawing.Point(227, 3);
            this.button_PrintXML.Name = "button_PrintXML";
            this.button_PrintXML.Size = new System.Drawing.Size(75, 23);
            this.button_PrintXML.TabIndex = 7;
            this.button_PrintXML.Text = "Gem til XML";
            this.button_PrintXML.UseVisualStyleBackColor = true;
            this.button_PrintXML.Click += new System.EventHandler(this.button_PrintXML_Click);
            // 
            // button_ReadXML
            // 
            this.button_ReadXML.Location = new System.Drawing.Point(308, 3);
            this.button_ReadXML.Name = "button_ReadXML";
            this.button_ReadXML.Size = new System.Drawing.Size(75, 23);
            this.button_ReadXML.TabIndex = 8;
            this.button_ReadXML.Text = "Indlæs XML";
            this.button_ReadXML.UseVisualStyleBackColor = true;
            this.button_ReadXML.Click += new System.EventHandler(this.button_ReadXML_Click);
            // 
            // button_PrintReceipt
            // 
            this.button_PrintReceipt.Location = new System.Drawing.Point(389, 3);
            this.button_PrintReceipt.Name = "button_PrintReceipt";
            this.button_PrintReceipt.Size = new System.Drawing.Size(133, 23);
            this.button_PrintReceipt.TabIndex = 9;
            this.button_PrintReceipt.Text = "Print Kvittering";
            this.button_PrintReceipt.UseVisualStyleBackColor = true;
            this.button_PrintReceipt.Click += new System.EventHandler(this.button_PrintReceipt_Click);
            // 
            // Form_Status_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 503);
            this.Controls.Add(this.button_PrintReceipt);
            this.Controls.Add(this.button_ReadXML);
            this.Controls.Add(this.button_PrintXML);
            this.Controls.Add(this.numericUpDown_OrderID);
            this.Controls.Add(this.panel_CustomerSalesInfo);
            this.Controls.Add(this.button_findOrder);
            this.Controls.Add(this.label_OrderID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Status_1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordre Status";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Status_1_FormClosed);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_Status_1_MouseClick);
            this.panel_CustomerSalesInfo.ResumeLayout(false);
            this.panel_CustomerSalesInfo.PerformLayout();
            this.panel_MaterialInfo.ResumeLayout(false);
            this.panel_MaterialInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AmountCompleted)).EndInit();
            this.panel_OrderInfo.ResumeLayout(false);
            this.panel_OrderInfo.PerformLayout();
            this.panel_TasksInfo.ResumeLayout(false);
            this.panel_TasksInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OrderID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_OrderID;
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
        private System.Windows.Forms.Panel panel_MaterialInfo;
        private System.Windows.Forms.Label label_MaterialInformation;
        private System.Windows.Forms.TextBox textBox_MaterialeName;
        private System.Windows.Forms.CheckBox checkBox_ItemLineIsComplete;
        private System.Windows.Forms.NumericUpDown numericUpDown_OrderID;
        private System.Windows.Forms.CheckBox checkBox_TaskIsComplete;
        private System.Windows.Forms.TextBox textBox_TaskValueCompletedTotal;
        private System.Windows.Forms.Label label_TaskValueCompleted;
        private System.Windows.Forms.TextBox textBox_TaskValueTotal;
        private System.Windows.Forms.Label label_TaskValueTotal;
        private System.Windows.Forms.NumericUpDown numericUpDown_AmountCompleted;
        private System.Windows.Forms.Button button_AddCompleteItems;
        private System.Windows.Forms.Label label_OrderValue;
        private System.Windows.Forms.TextBox textBox_OrderValue;
        private System.Windows.Forms.Label label_OrderCost;
        private System.Windows.Forms.TextBox textBox_OrderCost;
        private System.Windows.Forms.Button button_PrintXML;
        private System.Windows.Forms.Button button_ReadXML;
        private System.Windows.Forms.Button button_PrintReceipt;
    }
}