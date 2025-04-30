namespace Ejercicio_C2_UI
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
            btnVerPersona = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnVerPersona
            // 
            btnVerPersona.BackColor = SystemColors.ControlDark;
            btnVerPersona.Location = new Point(387, 242);
            btnVerPersona.Margin = new Padding(4);
            btnVerPersona.Name = "btnVerPersona";
            btnVerPersona.Size = new Size(411, 81);
            btnVerPersona.TabIndex = 1;
            btnVerPersona.Text = "Ver persona";
            btnVerPersona.UseVisualStyleBackColor = false;
            btnVerPersona.Click += btnVerPersona_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 2;
            label1.Text = "Datos de la persona:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 48);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 3;
            label2.Text = "Nombre y apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(238, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 34);
            txtNombre.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(238, 97);
            numericUpDown1.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2010, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 34);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 2010, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 97);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 6;
            label3.Text = "Año de ingreso:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 630);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVerPersona);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVerPersona;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private NumericUpDown numericUpDown1;
        private Label label3;
    }
}
