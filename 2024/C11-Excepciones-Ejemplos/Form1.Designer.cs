namespace C11_Excepciones_Ejemplos
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
            label1 = new Label();
            btnEjemplo1 = new Button();
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            nupValorB = new NumericUpDown();
            label3 = new Label();
            nupValorA = new NumericUpDown();
            label2 = new Label();
            btnEjemplo2 = new Button();
            label6 = new Label();
            nupPosicion = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupValorB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupValorA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPosicion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1040, 28);
            label1.TabIndex = 0;
            label1.Text = "En este formulario están los dos casos de ejemplo usados en la presentación de la sesión 11 para poder ser ejecutados.";
            // 
            // btnEjemplo1
            // 
            btnEjemplo1.Location = new Point(211, 368);
            btnEjemplo1.Name = "btnEjemplo1";
            btnEjemplo1.Size = new Size(272, 62);
            btnEjemplo1.TabIndex = 1;
            btnEjemplo1.Text = "Ejemplo 1 (división)";
            btnEjemplo1.UseVisualStyleBackColor = true;
            btnEjemplo1.Click += btnEjemplo1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 63);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(nupValorB);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(nupValorA);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(btnEjemplo1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ControlDark;
            splitContainer1.Panel2.Controls.Add(btnEjemplo2);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(nupPosicion);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Size = new Size(1040, 445);
            splitContainer1.SplitterDistance = 502;
            splitContainer1.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(30, 165);
            label4.Name = "label4";
            label4.Size = new Size(426, 72);
            label4.TabIndex = 6;
            label4.Text = "Se ejecuta una división de valores double y se capturan los posibles errores.";
            // 
            // nupValorB
            // 
            nupValorB.DecimalPlaces = 1;
            nupValorB.Location = new Point(156, 84);
            nupValorB.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupValorB.Name = "nupValorB";
            nupValorB.Size = new Size(150, 34);
            nupValorB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 86);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 4;
            label3.Text = "Operando b:";
            // 
            // nupValorA
            // 
            nupValorA.DecimalPlaces = 1;
            nupValorA.Location = new Point(156, 39);
            nupValorA.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupValorA.Name = "nupValorA";
            nupValorA.Size = new Size(150, 34);
            nupValorA.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 41);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 2;
            label2.Text = "Operando a:";
            // 
            // btnEjemplo2
            // 
            btnEjemplo2.Location = new Point(246, 368);
            btnEjemplo2.Name = "btnEjemplo2";
            btnEjemplo2.Size = new Size(272, 62);
            btnEjemplo2.TabIndex = 7;
            btnEjemplo2.Text = "Ejemplo 2 (acceso array)";
            btnEjemplo2.UseVisualStyleBackColor = true;
            btnEjemplo2.Click += btnEjemplo2_Click;
            // 
            // label6
            // 
            label6.Location = new Point(38, 165);
            label6.Name = "label6";
            label6.Size = new Size(426, 93);
            label6.TabIndex = 7;
            label6.Text = "Se obtiene el valor de la posición ingresada desde un array y se capturan los posibles errores.";
            // 
            // nupPosicion
            // 
            nupPosicion.Location = new Point(233, 39);
            nupPosicion.Name = "nupPosicion";
            nupPosicion.Size = new Size(130, 34);
            nupPosicion.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 39);
            label5.Name = "label5";
            label5.Size = new Size(188, 28);
            label5.TabIndex = 0;
            label5.Text = "Posición a visualizar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 530);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Ejemplos de excepciones";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nupValorB).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupValorA).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPosicion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEjemplo1;
        private SplitContainer splitContainer1;
        private Label label4;
        private NumericUpDown nupValorB;
        private Label label3;
        private NumericUpDown nupValorA;
        private Label label2;
        private Button btnEjemplo2;
        private Label label6;
        private NumericUpDown nupPosicion;
        private Label label5;
    }
}
