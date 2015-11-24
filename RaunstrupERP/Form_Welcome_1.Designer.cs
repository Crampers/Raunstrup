namespace RaunstrupERP
{
    partial class Form_Welcome_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Salesman = new System.Windows.Forms.Button();
            this.button_Craftman = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vælg Medarbejdertype";
            // 
            // button_Salesman
            // 
            this.button_Salesman.Location = new System.Drawing.Point(109, 25);
            this.button_Salesman.Name = "button_Salesman";
            this.button_Salesman.Size = new System.Drawing.Size(98, 23);
            this.button_Salesman.TabIndex = 4;
            this.button_Salesman.Text = "Salesman_PH";
            this.button_Salesman.UseVisualStyleBackColor = true;
            // 
            // button_Craftman
            // 
            this.button_Craftman.Location = new System.Drawing.Point(12, 25);
            this.button_Craftman.Name = "button_Craftman";
            this.button_Craftman.Size = new System.Drawing.Size(91, 23);
            this.button_Craftman.TabIndex = 3;
            this.button_Craftman.Text = "Craftsman_PH";
            this.button_Craftman.UseVisualStyleBackColor = true;
            this.button_Craftman.Click += new System.EventHandler(this.button_Craftman_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form_Welcome_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 360);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Salesman);
            this.Controls.Add(this.button_Craftman);
            this.Name = "Form_Welcome_1";
            this.Text = "Form_Welcome_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Salesman;
        private System.Windows.Forms.Button button_Craftman;
        private System.Windows.Forms.TextBox textBox1;
    }
}