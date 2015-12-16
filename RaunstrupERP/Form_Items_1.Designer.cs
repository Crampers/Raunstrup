namespace RaunstrupERP
{
    partial class Form_Items_1
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
            this.label_desc = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_SalesPrice = new System.Windows.Forms.Label();
            this.label_ShopsPrice = new System.Windows.Forms.Label();
            this.richTextBox_Desc = new System.Windows.Forms.RichTextBox();
            this.textBox_SalesPrice = new System.Windows.Forms.TextBox();
            this.textBox_shopsPrice = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_ToggleEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_EditShopsPrice = new System.Windows.Forms.Button();
            this.button_EditSalesPrice = new System.Windows.Forms.Button();
            this.button_EditDesc = new System.Windows.Forms.Button();
            this.numericUpDown_EditPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_EditSalesPrice = new System.Windows.Forms.NumericUpDown();
            this.richTextBox_EditDesc = new System.Windows.Forms.RichTextBox();
            this.button_CreateItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditSalesPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Location = new System.Drawing.Point(12, 29);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(61, 13);
            this.label_desc.TabIndex = 0;
            this.label_desc.Text = "Beskrivelse";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(12, 9);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "ID";
            // 
            // label_SalesPrice
            // 
            this.label_SalesPrice.AutoSize = true;
            this.label_SalesPrice.Location = new System.Drawing.Point(12, 144);
            this.label_SalesPrice.Name = "label_SalesPrice";
            this.label_SalesPrice.Size = new System.Drawing.Size(49, 13);
            this.label_SalesPrice.TabIndex = 2;
            this.label_SalesPrice.Text = "Salgspris";
            // 
            // label_ShopsPrice
            // 
            this.label_ShopsPrice.AutoSize = true;
            this.label_ShopsPrice.Location = new System.Drawing.Point(12, 184);
            this.label_ShopsPrice.Name = "label_ShopsPrice";
            this.label_ShopsPrice.Size = new System.Drawing.Size(61, 13);
            this.label_ShopsPrice.TabIndex = 3;
            this.label_ShopsPrice.Text = "Indkøbspris";
            // 
            // richTextBox_Desc
            // 
            this.richTextBox_Desc.Location = new System.Drawing.Point(15, 45);
            this.richTextBox_Desc.Name = "richTextBox_Desc";
            this.richTextBox_Desc.ReadOnly = true;
            this.richTextBox_Desc.Size = new System.Drawing.Size(141, 96);
            this.richTextBox_Desc.TabIndex = 4;
            this.richTextBox_Desc.Text = "";
            // 
            // textBox_SalesPrice
            // 
            this.textBox_SalesPrice.Location = new System.Drawing.Point(15, 161);
            this.textBox_SalesPrice.Name = "textBox_SalesPrice";
            this.textBox_SalesPrice.ReadOnly = true;
            this.textBox_SalesPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox_SalesPrice.TabIndex = 6;
            // 
            // textBox_shopsPrice
            // 
            this.textBox_shopsPrice.Location = new System.Drawing.Point(15, 200);
            this.textBox_shopsPrice.Name = "textBox_shopsPrice";
            this.textBox_shopsPrice.ReadOnly = true;
            this.textBox_shopsPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox_shopsPrice.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(36, 7);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button_ToggleEdit
            // 
            this.button_ToggleEdit.Location = new System.Drawing.Point(15, 227);
            this.button_ToggleEdit.Name = "button_ToggleEdit";
            this.button_ToggleEdit.Size = new System.Drawing.Size(75, 23);
            this.button_ToggleEdit.TabIndex = 9;
            this.button_ToggleEdit.Text = "Rediger";
            this.button_ToggleEdit.UseVisualStyleBackColor = true;
            this.button_ToggleEdit.Click += new System.EventHandler(this.button_ToggleEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_EditShopsPrice);
            this.panel1.Controls.Add(this.button_EditSalesPrice);
            this.panel1.Controls.Add(this.button_EditDesc);
            this.panel1.Location = new System.Drawing.Point(162, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 243);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // button_EditShopsPrice
            // 
            this.button_EditShopsPrice.Location = new System.Drawing.Point(3, 191);
            this.button_EditShopsPrice.Name = "button_EditShopsPrice";
            this.button_EditShopsPrice.Size = new System.Drawing.Size(75, 23);
            this.button_EditShopsPrice.TabIndex = 2;
            this.button_EditShopsPrice.Text = "Rediger";
            this.button_EditShopsPrice.UseVisualStyleBackColor = true;
            this.button_EditShopsPrice.Click += new System.EventHandler(this.button_EditShopsPrice_Click);
            // 
            // button_EditSalesPrice
            // 
            this.button_EditSalesPrice.Location = new System.Drawing.Point(3, 152);
            this.button_EditSalesPrice.Name = "button_EditSalesPrice";
            this.button_EditSalesPrice.Size = new System.Drawing.Size(75, 23);
            this.button_EditSalesPrice.TabIndex = 1;
            this.button_EditSalesPrice.Text = "Rediger";
            this.button_EditSalesPrice.UseVisualStyleBackColor = true;
            this.button_EditSalesPrice.Click += new System.EventHandler(this.button_EditSalesPrice_Click);
            // 
            // button_EditDesc
            // 
            this.button_EditDesc.Location = new System.Drawing.Point(3, 36);
            this.button_EditDesc.Name = "button_EditDesc";
            this.button_EditDesc.Size = new System.Drawing.Size(75, 23);
            this.button_EditDesc.TabIndex = 0;
            this.button_EditDesc.Text = "Rediger";
            this.button_EditDesc.UseVisualStyleBackColor = true;
            this.button_EditDesc.Click += new System.EventHandler(this.button_EditDesc_Click);
            // 
            // numericUpDown_EditPurchasePrice
            // 
            this.numericUpDown_EditPurchasePrice.Location = new System.Drawing.Point(15, 201);
            this.numericUpDown_EditPurchasePrice.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown_EditPurchasePrice.Name = "numericUpDown_EditPurchasePrice";
            this.numericUpDown_EditPurchasePrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_EditPurchasePrice.TabIndex = 12;
            this.numericUpDown_EditPurchasePrice.Visible = false;
            // 
            // numericUpDown_EditSalesPrice
            // 
            this.numericUpDown_EditSalesPrice.Location = new System.Drawing.Point(15, 162);
            this.numericUpDown_EditSalesPrice.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown_EditSalesPrice.Name = "numericUpDown_EditSalesPrice";
            this.numericUpDown_EditSalesPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_EditSalesPrice.TabIndex = 11;
            this.numericUpDown_EditSalesPrice.Visible = false;
            // 
            // richTextBox_EditDesc
            // 
            this.richTextBox_EditDesc.Location = new System.Drawing.Point(15, 45);
            this.richTextBox_EditDesc.Name = "richTextBox_EditDesc";
            this.richTextBox_EditDesc.Size = new System.Drawing.Size(141, 96);
            this.richTextBox_EditDesc.TabIndex = 11;
            this.richTextBox_EditDesc.Text = "";
            this.richTextBox_EditDesc.Visible = false;
            // 
            // button_CreateItem
            // 
            this.button_CreateItem.Location = new System.Drawing.Point(15, 256);
            this.button_CreateItem.Name = "button_CreateItem";
            this.button_CreateItem.Size = new System.Drawing.Size(75, 23);
            this.button_CreateItem.TabIndex = 13;
            this.button_CreateItem.Text = "Opret Ny";
            this.button_CreateItem.UseVisualStyleBackColor = true;
            this.button_CreateItem.Click += new System.EventHandler(this.button_CreateItem_Click);
            // 
            // Form_Items_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 303);
            this.Controls.Add(this.button_CreateItem);
            this.Controls.Add(this.numericUpDown_EditPurchasePrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown_EditSalesPrice);
            this.Controls.Add(this.richTextBox_EditDesc);
            this.Controls.Add(this.button_ToggleEdit);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox_shopsPrice);
            this.Controls.Add(this.textBox_SalesPrice);
            this.Controls.Add(this.richTextBox_Desc);
            this.Controls.Add(this.label_ShopsPrice);
            this.Controls.Add(this.label_SalesPrice);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_desc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Items_1";
            this.ShowIcon = false;
            this.Text = "Søg Materiale";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EditSalesPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_SalesPrice;
        private System.Windows.Forms.Label label_ShopsPrice;
        private System.Windows.Forms.RichTextBox richTextBox_Desc;
        private System.Windows.Forms.TextBox textBox_SalesPrice;
        private System.Windows.Forms.TextBox textBox_shopsPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_ToggleEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_EditShopsPrice;
        private System.Windows.Forms.Button button_EditSalesPrice;
        private System.Windows.Forms.Button button_EditDesc;
        private System.Windows.Forms.RichTextBox richTextBox_EditDesc;
        private System.Windows.Forms.NumericUpDown numericUpDown_EditPurchasePrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_EditSalesPrice;
        private System.Windows.Forms.Button button_CreateItem;
    }
}