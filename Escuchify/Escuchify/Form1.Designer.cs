namespace Escuchify
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
            label7 = new Label();
            txtNombreCompleto = new TextBox();
            txtNombreArtistico = new TextBox();
            nupAnioInicio = new NumericUpDown();
            cbxNacionalidad = new ComboBox();
            cbxDiscografica = new ComboBox();
            btnGuardar = new Button();
            label8 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nupAnioInicio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 0;
            label1.Text = "Escuchify 1.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 59);
            label2.Name = "label2";
            label2.Size = new Size(194, 21);
            label2.TabIndex = 1;
            label2.Text = "Carga de datos de Artistas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 112);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 157);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 3;
            label4.Text = "Nombre artístico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 202);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 4;
            label5.Text = "Año de incio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 247);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 5;
            label6.Text = "Nacionalidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 293);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 6;
            label7.Text = "Discográfica:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(271, 109);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(336, 29);
            txtNombreCompleto.TabIndex = 7;
            // 
            // txtNombreArtistico
            // 
            txtNombreArtistico.Location = new Point(271, 154);
            txtNombreArtistico.Name = "txtNombreArtistico";
            txtNombreArtistico.Size = new Size(336, 29);
            txtNombreArtistico.TabIndex = 8;
            // 
            // nupAnioInicio
            // 
            nupAnioInicio.Location = new Point(271, 200);
            nupAnioInicio.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nupAnioInicio.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nupAnioInicio.Name = "nupAnioInicio";
            nupAnioInicio.Size = new Size(138, 29);
            nupAnioInicio.TabIndex = 9;
            nupAnioInicio.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // cbxNacionalidad
            // 
            cbxNacionalidad.FormattingEnabled = true;
            cbxNacionalidad.Items.AddRange(new object[] { "Argentina", "Estados Unidos de Norteamérica", "Reino Unido", "España", "Italia", "Brasil" });
            cbxNacionalidad.Location = new Point(271, 244);
            cbxNacionalidad.Name = "cbxNacionalidad";
            cbxNacionalidad.Size = new Size(336, 29);
            cbxNacionalidad.TabIndex = 10;
            // 
            // cbxDiscografica
            // 
            cbxDiscografica.FormattingEnabled = true;
            cbxDiscografica.Items.AddRange(new object[] { "Sony", "Warner", "Otras" });
            cbxDiscografica.Location = new Point(271, 290);
            cbxDiscografica.Name = "cbxDiscografica";
            cbxDiscografica.Size = new Size(336, 29);
            cbxDiscografica.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(438, 343);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(169, 35);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 399);
            label8.Name = "label8";
            label8.Size = new Size(250, 21);
            label8.TabIndex = 13;
            label8.Text = "Artistas agregados a la plataforma:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(29, 437);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(577, 88);
            listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 550);
            Controls.Add(listBox1);
            Controls.Add(label8);
            Controls.Add(btnGuardar);
            Controls.Add(cbxDiscografica);
            Controls.Add(cbxNacionalidad);
            Controls.Add(nupAnioInicio);
            Controls.Add(txtNombreArtistico);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Gestión de Artistas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupAnioInicio).EndInit();
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
        private Label label7;
        private TextBox txtNombreCompleto;
        private TextBox txtNombreArtistico;
        private NumericUpDown nupAnioInicio;
        private ComboBox cbxNacionalidad;
        private ComboBox cbxDiscografica;
        private Button btnGuardar;
        private Label label8;
        private ListBox listBox1;
    }
}
