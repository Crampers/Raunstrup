namespace RaunstrupERP
{
    partial class Form_Items_Create
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
            this.numericUpDown_PurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SalesPrice = new System.Windows.Forms.NumericUpDown();
            this.richTextBox_Desc = new System.Windows.Forms.RichTextBox();
            this.label_ShopsPrice = new System.Windows.Forms.Label();
            this.label_SalesPrice = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.button_Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SalesPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_PurchasePrice
            // 
            this.numericUpDown_PurchasePrice.Location = new System.Drawing.Point(15, 181);
            this.numericUpDown_PurchasePrice.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown_PurchasePrice.Name = "numericUpDown_PurchasePrice";
            this.numericUpDown_PurchasePrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_PurchasePrice.TabIndex = 18;
            // 
            // numericUpDown_SalesPrice
            // 
            this.numericUpDown_SalesPrice.Location = new System.Drawing.Point(15, 142);
            this.numericUpDown_SalesPrice.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown_SalesPrice.Name = "numericUpDown_SalesPrice";
            this.numericUpDown_SalesPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_SalesPrice.TabIndex = 16;
            // 
            // richTextBox_Desc
            // 
            this.richTextBox_Desc.Location = new System.Drawing.Point(15, 25);
            this.richTextBox_Desc.Name = "richTextBox_Desc";
            this.richTextBox_Desc.Size = new System.Drawing.Size(141, 96);
            this.richTextBox_Desc.TabIndex = 17;
            this.richTextBox_Desc.Text = "";
            // 
            // label_ShopsPrice
            // 
            this.label_ShopsPrice.AutoSize = true;
            this.label_ShopsPrice.Location = new System.Drawing.Point(12, 164);
            this.label_ShopsPrice.Name = "label_ShopsPrice";
            this.label_ShopsPrice.Size = new System.Drawing.Size(61, 13);
            this.label_ShopsPrice.TabIndex = 15;
            this.label_ShopsPrice.Text = "Indkøbspris";
            // 
            // label_SalesPrice
            // 
            this.label_SalesPrice.AutoSize = true;
            this.label_SalesPrice.Location = new System.Drawing.Point(12, 124);
            this.label_SalesPrice.Name = "label_SalesPrice";
            this.label_SalesPrice.Size = new System.Drawing.Size(49, 13);
            this.label_SalesPrice.TabIndex = 14;
            this.label_SalesPrice.Text = "Salgspris";
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Location = new System.Drawing.Point(12, 9);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(61, 13);
            this.label_desc.TabIndex = 13;
            this.label_desc.Text = "Beskrivelse";
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(15, 207);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 19;
            this.button_Confirm.Text = "Godkend";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // Form_Items_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 260);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.numericUpDown_PurchasePrice);
            this.Controls.Add(this.numericUpDown_SalesPrice);
            this.Controls.Add(this.richTextBox_Desc);
            this.Controls.Add(this.label_ShopsPrice);
            this.Controls.Add(this.label_SalesPrice);
            this.Controls.Add(this.label_desc);
            this.Name = "Form_Items_Create";
            this.Text = "Form_Items_Create";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SalesPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_PurchasePrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_SalesPrice;
        private System.Windows.Forms.RichTextBox richTextBox_Desc;
        private System.Windows.Forms.Label label_ShopsPrice;
        private System.Windows.Forms.Label label_SalesPrice;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.Button button_Confirm;
    }
}