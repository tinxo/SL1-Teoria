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
            btnProcesar = new Button();
            grpNotas = new GroupBox();
            nupRecuperatorio2 = new NumericUpDown();
            label2 = new Label();
            nupRecuperatorio1 = new NumericUpDown();
            label3 = new Label();
            nupParcial2 = new NumericUpDown();
            label1 = new Label();
            nupParcial1 = new NumericUpDown();
            label8 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            chkPracticos = new CheckBox();
            chkAsistencia = new CheckBox();
            grpNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupRecuperatorio2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupRecuperatorio1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupParcial2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupParcial1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(357, 420);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(305, 56);
            btnProcesar.TabIndex = 11;
            btnProcesar.Text = "Procesar estado de cursado";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // grpNotas
            // 
            grpNotas.Controls.Add(nupRecuperatorio2);
            grpNotas.Controls.Add(label2);
            grpNotas.Controls.Add(nupRecuperatorio1);
            grpNotas.Controls.Add(label3);
            grpNotas.Controls.Add(nupParcial2);
            grpNotas.Controls.Add(label1);
            grpNotas.Controls.Add(nupParcial1);
            grpNotas.Controls.Add(label8);
            grpNotas.Enabled = false;
            grpNotas.Location = new Point(12, 54);
            grpNotas.Name = "grpNotas";
            grpNotas.Size = new Size(650, 205);
            grpNotas.TabIndex = 14;
            grpNotas.TabStop = false;
            grpNotas.Text = "Notas de parciales:";
            // 
            // nupRecuperatorio2
            // 
            nupRecuperatorio2.DecimalPlaces = 2;
            nupRecuperatorio2.Location = new Point(301, 164);
            nupRecuperatorio2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupRecuperatorio2.Name = "nupRecuperatorio2";
            nupRecuperatorio2.Size = new Size(150, 34);
            nupRecuperatorio2.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 166);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 20;
            label2.Text = "Recuperatorio 2do. parcial:";
            // 
            // nupRecuperatorio1
            // 
            nupRecuperatorio1.DecimalPlaces = 2;
            nupRecuperatorio1.Location = new Point(301, 123);
            nupRecuperatorio1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupRecuperatorio1.Name = "nupRecuperatorio1";
            nupRecuperatorio1.Size = new Size(150, 34);
            nupRecuperatorio1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 125);
            label3.Name = "label3";
            label3.Size = new Size(239, 28);
            label3.TabIndex = 18;
            label3.Text = "Recuperatorio 1er. parcial:";
            // 
            // nupParcial2
            // 
            nupParcial2.DecimalPlaces = 2;
            nupParcial2.Location = new Point(301, 80);
            nupParcial2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupParcial2.Name = "nupParcial2";
            nupParcial2.Size = new Size(150, 34);
            nupParcial2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 82);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 16;
            label1.Text = "2do. parcial:";
            // 
            // nupParcial1
            // 
            nupParcial1.DecimalPlaces = 2;
            nupParcial1.Location = new Point(301, 39);
            nupParcial1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupParcial1.Name = "nupParcial1";
            nupParcial1.Size = new Size(150, 34);
            nupParcial1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 41);
            label8.Name = "label8";
            label8.Size = new Size(111, 28);
            label8.TabIndex = 0;
            label8.Text = "1er. parcial:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(386, 28);
            label10.TabIndex = 16;
            label10.Text = "Procesamiento de notas de los estudiantes:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkPracticos);
            groupBox1.Controls.Add(chkAsistencia);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(12, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(650, 130);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Condiciones extra:";
            // 
            // chkPracticos
            // 
            chkPracticos.AutoSize = true;
            chkPracticos.Location = new Point(21, 85);
            chkPracticos.Name = "chkPracticos";
            chkPracticos.Size = new Size(463, 32);
            chkPracticos.TabIndex = 18;
            chkPracticos.Text = "¿Cumple con % de TPs presentados / aprobados?";
            chkPracticos.UseVisualStyleBackColor = true;
            // 
            // chkAsistencia
            // 
            chkAsistencia.AutoSize = true;
            chkAsistencia.Location = new Point(21, 47);
            chkAsistencia.Name = "chkAsistencia";
            chkAsistencia.Size = new Size(292, 32);
            chkAsistencia.TabIndex = 17;
            chkAsistencia.Text = "¿Cumple con % de asistencia?";
            chkAsistencia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 512);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(grpNotas);
            Controls.Add(btnProcesar);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Procesamiento de datos de estudiantes";
            Load += Form1_Load;
            grpNotas.ResumeLayout(false);
            grpNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupRecuperatorio2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupRecuperatorio1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupParcial2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupParcial1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProcesar;
        private GroupBox grpNotas;
        private Button btnEvaluar;
        private NumericUpDown nupParcial1;
        private Label label8;
        private Label label10;
        private NumericUpDown nupRecuperatorio2;
        private Label label2;
        private NumericUpDown nupRecuperatorio1;
        private Label label3;
        private NumericUpDown nupParcial2;
        private Label label1;
        private GroupBox groupBox1;
        private CheckBox chkPracticos;
        private CheckBox chkAsistencia;
    }
}
