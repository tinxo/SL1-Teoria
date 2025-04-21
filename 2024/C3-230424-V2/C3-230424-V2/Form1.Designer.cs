namespace C3_230424_V2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreApellido = new TextBox();
            txtDocumento = new TextBox();
            nupAnioIngreso = new NumericUpDown();
            nupMateriasAprobadas = new NumericUpDown();
            nupPromedio = new NumericUpDown();
            btnProcesar = new Button();
            label7 = new Label();
            lblResultados = new Label();
            grpNotas = new GroupBox();
            btnEvaluar = new Button();
            nupNota = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)nupAnioIngreso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupMateriasAprobadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPromedio).BeginInit();
            grpNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupNota).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los datos de una persona:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre y apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 2;
            label3.Text = "Nro. de documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(299, 28);
            label4.TabIndex = 4;
            label4.Text = "Cantidad de materias aprobadas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 178);
            label5.Name = "label5";
            label5.Size = new Size(249, 28);
            label5.TabIndex = 3;
            label5.Text = "Año de ingreso a la carrera:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 257);
            label6.Name = "label6";
            label6.Size = new Size(202, 28);
            label6.TabIndex = 5;
            label6.Text = "Promedio sin aplazos:";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(317, 95);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(265, 34);
            txtNombreApellido.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(317, 134);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(265, 34);
            txtDocumento.TabIndex = 7;
            // 
            // nupAnioIngreso
            // 
            nupAnioIngreso.Location = new Point(432, 176);
            nupAnioIngreso.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            nupAnioIngreso.Minimum = new decimal(new int[] { 1994, 0, 0, 0 });
            nupAnioIngreso.Name = "nupAnioIngreso";
            nupAnioIngreso.Size = new Size(150, 34);
            nupAnioIngreso.TabIndex = 8;
            nupAnioIngreso.Value = new decimal(new int[] { 1994, 0, 0, 0 });
            // 
            // nupMateriasAprobadas
            // 
            nupMateriasAprobadas.Location = new Point(432, 215);
            nupMateriasAprobadas.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            nupMateriasAprobadas.Name = "nupMateriasAprobadas";
            nupMateriasAprobadas.Size = new Size(150, 34);
            nupMateriasAprobadas.TabIndex = 9;
            // 
            // nupPromedio
            // 
            nupPromedio.DecimalPlaces = 2;
            nupPromedio.Location = new Point(432, 255);
            nupPromedio.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupPromedio.Name = "nupPromedio";
            nupPromedio.Size = new Size(150, 34);
            nupPromedio.TabIndex = 10;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(404, 295);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(178, 56);
            btnProcesar.TabIndex = 11;
            btnProcesar.Text = "Procesar datos";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 352);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 12;
            label7.Text = "Resultado:";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(12, 380);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(28, 28);
            lblResultados.TabIndex = 13;
            lblResultados.Text = "....";
            // 
            // grpNotas
            // 
            grpNotas.Controls.Add(btnEvaluar);
            grpNotas.Controls.Add(nupNota);
            grpNotas.Controls.Add(label8);
            grpNotas.Enabled = false;
            grpNotas.Location = new Point(12, 476);
            grpNotas.Name = "grpNotas";
            grpNotas.Size = new Size(650, 106);
            grpNotas.TabIndex = 14;
            grpNotas.TabStop = false;
            grpNotas.Text = "Calificación de un examen";
            // 
            // btnEvaluar
            // 
            btnEvaluar.Location = new Point(447, 33);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(187, 45);
            btnEvaluar.TabIndex = 16;
            btnEvaluar.Text = "¿Es aprobado?";
            btnEvaluar.UseVisualStyleBackColor = true;
            btnEvaluar.Click += btnEvaluar_Click;
            // 
            // nupNota
            // 
            nupNota.DecimalPlaces = 2;
            nupNota.Location = new Point(275, 39);
            nupNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupNota.Name = "nupNota";
            nupNota.Size = new Size(150, 34);
            nupNota.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 41);
            label8.Name = "label8";
            label8.Size = new Size(228, 28);
            label8.TabIndex = 0;
            label8.Text = "Ingrese la nota obtenida:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 47);
            label9.Name = "label9";
            label9.Size = new Size(556, 28);
            label9.TabIndex = 15;
            label9.Text = "Primero, cargue los datos de la persona y haga clic en Procesar";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 445);
            label10.Name = "label10";
            label10.Size = new Size(495, 28);
            label10.TabIndex = 16;
            label10.Text = "Con los datos cargados, ahora puede verificar una nota:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 590);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(grpNotas);
            Controls.Add(lblResultados);
            Controls.Add(label7);
            Controls.Add(btnProcesar);
            Controls.Add(nupPromedio);
            Controls.Add(nupMateriasAprobadas);
            Controls.Add(nupAnioIngreso);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombreApellido);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Procesamiento de datos de estudiantes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupAnioIngreso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupMateriasAprobadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPromedio).EndInit();
            grpNotas.ResumeLayout(false);
            grpNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreApellido;
        private TextBox txtDocumento;
        private NumericUpDown nupAnioIngreso;
        private NumericUpDown nupMateriasAprobadas;
        private NumericUpDown nupPromedio;
        private Button btnProcesar;
        private Label label7;
        private Label lblResultados;
        private GroupBox grpNotas;
        private Button btnEvaluar;
        private NumericUpDown nupNota;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
