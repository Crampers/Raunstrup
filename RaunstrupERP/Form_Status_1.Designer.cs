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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_Opgaver = new System.Windows.Forms.Label();
            this.button_findOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_OrderID
            // 
            this.label_OrderID.AutoSize = true;
            this.label_OrderID.Location = new System.Drawing.Point(15, 9);
            this.label_OrderID.Name = "label_OrderID";
            this.label_OrderID.Size = new System.Drawing.Size(44, 13);
            this.label_OrderID.TabIndex = 0;
            this.label_OrderID.Text = "OrderID";
            // 
            // maskedTextBox_OrderID
            // 
            this.maskedTextBox_OrderID.Location = new System.Drawing.Point(65, 6);
            this.maskedTextBox_OrderID.Name = "maskedTextBox_OrderID";
            this.maskedTextBox_OrderID.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBox_OrderID.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 199);
            this.listBox1.TabIndex = 2;
            // 
            // label_Opgaver
            // 
            this.label_Opgaver.AutoSize = true;
            this.label_Opgaver.Location = new System.Drawing.Point(3, 5);
            this.label_Opgaver.Name = "label_Opgaver";
            this.label_Opgaver.Size = new System.Drawing.Size(48, 13);
            this.label_Opgaver.TabIndex = 3;
            this.label_Opgaver.Text = "Opgaver";
            // 
            // button_findOrder
            // 
            this.button_findOrder.Location = new System.Drawing.Point(110, 4);
            this.button_findOrder.Name = "button_findOrder";
            this.button_findOrder.Size = new System.Drawing.Size(75, 23);
            this.button_findOrder.TabIndex = 4;
            this.button_findOrder.Text = "Find Ordre";
            this.button_findOrder.UseVisualStyleBackColor = true;
            this.button_findOrder.Click += new System.EventHandler(this.button_findOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label_Opgaver);
            this.panel1.Location = new System.Drawing.Point(18, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 230);
            this.panel1.TabIndex = 5;
            // 
            // Form_Status_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_findOrder);
            this.Controls.Add(this.maskedTextBox_OrderID);
            this.Controls.Add(this.label_OrderID);
            this.MinimizeBox = false;
            this.Name = "Form_Status_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Status_1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Status_1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_OrderID;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_OrderID;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_Opgaver;
        private System.Windows.Forms.Button button_findOrder;
        private System.Windows.Forms.Panel panel1;
    }
}