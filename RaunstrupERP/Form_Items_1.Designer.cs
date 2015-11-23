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
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_SalesPrice = new System.Windows.Forms.TextBox();
            this.textBox_shopsPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Location = new System.Drawing.Point(49, 70);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(61, 13);
            this.label_desc.TabIndex = 0;
            this.label_desc.Text = "Beskrivelse";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(49, 50);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "ID";
            // 
            // label_SalesPrice
            // 
            this.label_SalesPrice.AutoSize = true;
            this.label_SalesPrice.Location = new System.Drawing.Point(49, 185);
            this.label_SalesPrice.Name = "label_SalesPrice";
            this.label_SalesPrice.Size = new System.Drawing.Size(49, 13);
            this.label_SalesPrice.TabIndex = 2;
            this.label_SalesPrice.Text = "Salgspris";
            // 
            // label_ShopsPrice
            // 
            this.label_ShopsPrice.AutoSize = true;
            this.label_ShopsPrice.Location = new System.Drawing.Point(49, 225);
            this.label_ShopsPrice.Name = "label_ShopsPrice";
            this.label_ShopsPrice.Size = new System.Drawing.Size(61, 13);
            this.label_ShopsPrice.TabIndex = 3;
            this.label_ShopsPrice.Text = "Indkøbspris";
            // 
            // richTextBox_Desc
            // 
            this.richTextBox_Desc.Location = new System.Drawing.Point(52, 86);
            this.richTextBox_Desc.Name = "richTextBox_Desc";
            this.richTextBox_Desc.Size = new System.Drawing.Size(244, 96);
            this.richTextBox_Desc.TabIndex = 4;
            this.richTextBox_Desc.Text = "";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(73, 47);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(100, 20);
            this.textBox_Id.TabIndex = 5;
            // 
            // textBox_SalesPrice
            // 
            this.textBox_SalesPrice.Location = new System.Drawing.Point(52, 202);
            this.textBox_SalesPrice.Name = "textBox_SalesPrice";
            this.textBox_SalesPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox_SalesPrice.TabIndex = 6;
            // 
            // textBox_shopsPrice
            // 
            this.textBox_shopsPrice.Location = new System.Drawing.Point(52, 241);
            this.textBox_shopsPrice.Name = "textBox_shopsPrice";
            this.textBox_shopsPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox_shopsPrice.TabIndex = 7;
            // 
            // Form_Items_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 512);
            this.Controls.Add(this.textBox_shopsPrice);
            this.Controls.Add(this.textBox_SalesPrice);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.richTextBox_Desc);
            this.Controls.Add(this.label_ShopsPrice);
            this.Controls.Add(this.label_SalesPrice);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_desc);
            this.Name = "Form_Items_1";
            this.Text = "Form_Items_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_SalesPrice;
        private System.Windows.Forms.Label label_ShopsPrice;
        private System.Windows.Forms.RichTextBox richTextBox_Desc;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_SalesPrice;
        private System.Windows.Forms.TextBox textBox_shopsPrice;
    }
}