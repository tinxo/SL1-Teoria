namespace C4_290424
{
    partial class frmAsistencia
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
            txtNombrePersona = new TextBox();
            lstAsistentes = new ListBox();
            btnAgregar = new Button();
            label3 = new Label();
            lblContador = new Label();
            btnReiniciar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(388, 28);
            label1.TabIndex = 0;
            label1.Text = "Formulario para toma de asistencia a clases";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 53);
            label2.Name = "label2";
            label2.Size = new Size(366, 28);
            label2.TabIndex = 1;
            label2.Text = "Ingrese nombre y apellido de la persona:";
            // 
            // txtNombrePersona
            // 
            txtNombrePersona.Location = new Point(413, 50);
            txtNombrePersona.Name = "txtNombrePersona";
            txtNombrePersona.Size = new Size(328, 34);
            txtNombrePersona.TabIndex = 2;
            txtNombrePersona.KeyPress += txtNombrePersona_KeyPress;
            // 
            // lstAsistentes
            // 
            lstAsistentes.FormattingEnabled = true;
            lstAsistentes.ItemHeight = 28;
            lstAsistentes.Location = new Point(41, 189);
            lstAsistentes.Name = "lstAsistentes";
            lstAsistentes.Size = new Size(369, 228);
            lstAsistentes.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(536, 90);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(205, 44);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar asistente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 158);
            label3.Name = "label3";
            label3.Size = new Size(195, 28);
            label3.TabIndex = 5;
            label3.Text = "Listado de asistentes:";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(445, 189);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(211, 28);
            lblContador.TabIndex = 6;
            lblContador.Text = "Cantidad de asistentes:";
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(380, 423);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(213, 48);
            btnReiniciar.TabIndex = 7;
            btnReiniciar.Text = "Reiniciar operación";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(599, 423);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(213, 48);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir a inicio";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 488);
            Controls.Add(btnSalir);
            Controls.Add(btnReiniciar);
            Controls.Add(lblContador);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(lstAsistentes);
            Controls.Add(txtNombrePersona);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmAsistencia";
            Text = "Control de asistencia a clases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombrePersona;
        private ListBox lstAsistentes;
        private Button btnAgregar;
        private Label label3;
        private Label lblContador;
        private Button btnReiniciar;
        private Button btnSalir;
    }
}
