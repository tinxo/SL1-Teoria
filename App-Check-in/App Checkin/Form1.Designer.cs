namespace App_Checkin
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
            label8 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDocumento = new MaskedTextBox();
            txtPaxFrecuente = new TextBox();
            rdbNacional = new RadioButton();
            rdbInternacional = new RadioButton();
            cbxTipoTarifa = new ComboBox();
            btnProcesar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(472, 25);
            label1.TabIndex = 0;
            label1.Text = "Aplicación para Check-In - Aerolineas Argentinas (AR)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(253, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingrese los datos del pasajero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 101);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido(s):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 138);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 3;
            label4.Text = "Nombre(s):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 178);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 4;
            label5.Text = "Nro. Documento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 215);
            label6.Name = "label6";
            label6.Size = new Size(201, 25);
            label6.TabIndex = 5;
            label6.Text = "Nro. Pasajero Frecuente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 256);
            label7.Name = "label7";
            label7.Size = new Size(124, 25);
            label7.TabIndex = 6;
            label7.Text = "Tipo de vuelo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 295);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 7;
            label8.Text = "Tipo de tarifa:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(255, 98);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(246, 31);
            txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(255, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 31);
            txtNombre.TabIndex = 9;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(255, 175);
            txtDocumento.Mask = "##,###,###";
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(246, 31);
            txtDocumento.TabIndex = 10;
            // 
            // txtPaxFrecuente
            // 
            txtPaxFrecuente.Location = new Point(255, 212);
            txtPaxFrecuente.Name = "txtPaxFrecuente";
            txtPaxFrecuente.Size = new Size(246, 31);
            txtPaxFrecuente.TabIndex = 11;
            // 
            // rdbNacional
            // 
            rdbNacional.AutoSize = true;
            rdbNacional.Location = new Point(255, 254);
            rdbNacional.Name = "rdbNacional";
            rdbNacional.Size = new Size(101, 29);
            rdbNacional.TabIndex = 12;
            rdbNacional.TabStop = true;
            rdbNacional.Text = "Nacional";
            rdbNacional.UseVisualStyleBackColor = true;
            // 
            // rdbInternacional
            // 
            rdbInternacional.AutoSize = true;
            rdbInternacional.Location = new Point(367, 254);
            rdbInternacional.Name = "rdbInternacional";
            rdbInternacional.Size = new Size(134, 29);
            rdbInternacional.TabIndex = 13;
            rdbInternacional.TabStop = true;
            rdbInternacional.Text = "Internacional";
            rdbInternacional.UseVisualStyleBackColor = true;
            // 
            // cbxTipoTarifa
            // 
            cbxTipoTarifa.FormattingEnabled = true;
            cbxTipoTarifa.Items.AddRange(new object[] { "P", "B", "F", "PE" });
            cbxTipoTarifa.Location = new Point(255, 292);
            cbxTipoTarifa.Name = "cbxTipoTarifa";
            cbxTipoTarifa.Size = new Size(246, 33);
            cbxTipoTarifa.TabIndex = 14;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(533, 337);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(217, 48);
            btnProcesar.TabIndex = 15;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 562);
            Controls.Add(btnProcesar);
            Controls.Add(cbxTipoTarifa);
            Controls.Add(rdbInternacional);
            Controls.Add(rdbNacional);
            Controls.Add(txtPaxFrecuente);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Aerolineas Argentinas - Aplicación de Check-In (v 2026.1)";
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
        private Label label8;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private MaskedTextBox txtDocumento;
        private TextBox txtPaxFrecuente;
        private RadioButton rdbNacional;
        private RadioButton rdbInternacional;
        private ComboBox cbxTipoTarifa;
        private Button btnProcesar;
    }
}
