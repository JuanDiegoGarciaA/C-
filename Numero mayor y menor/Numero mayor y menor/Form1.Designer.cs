namespace Numero_mayor_y_menor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbln1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.lbln3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Location = new System.Drawing.Point(181, 89);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(63, 15);
            this.lbln1.TabIndex = 0;
            this.lbln1.Text = "Numero 1:";
            this.lbln1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.Location = new System.Drawing.Point(181, 134);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(63, 15);
            this.lbln2.TabIndex = 1;
            this.lbln2.Text = "Numero 2:";
            // 
            // lbln3
            // 
            this.lbln3.AutoSize = true;
            this.lbln3.Location = new System.Drawing.Point(181, 183);
            this.lbln3.Name = "lbln3";
            this.lbln3.Size = new System.Drawing.Size(63, 15);
            this.lbln3.TabIndex = 2;
            this.lbln3.Text = "Numero 3:";
            this.lbln3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(265, 86);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(150, 23);
            this.txt1.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(265, 131);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(150, 23);
            this.txt2.TabIndex = 4;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(265, 180);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(150, 23);
            this.txt3.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(211, 272);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(204, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbln3);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbln1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbln1;
        private Label lbln2;
        private Label lbln3;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private Button btnCalcular;
    }
}