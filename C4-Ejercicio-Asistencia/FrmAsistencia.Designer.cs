namespace C4_Ejercicio_Asistencia
{
    partial class FrmAsistencia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstPresentes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario de registro de asistencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre y apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(231, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 30);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegistrar.Location = new System.Drawing.Point(447, 122);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(317, 44);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar asistencia";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lstPresentes
            // 
            this.lstPresentes.FormattingEnabled = true;
            this.lstPresentes.ItemHeight = 25;
            this.lstPresentes.Location = new System.Drawing.Point(32, 223);
            this.lstPresentes.Name = "lstPresentes";
            this.lstPresentes.Size = new System.Drawing.Size(696, 129);
            this.lstPresentes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listado de presentes:";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReiniciar.Location = new System.Drawing.Point(411, 371);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(317, 44);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "Reiniciar pantalla";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(27, 381);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(217, 25);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad de asistentes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 578);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPresentes);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lstPresentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblCantidad;
    }
}

