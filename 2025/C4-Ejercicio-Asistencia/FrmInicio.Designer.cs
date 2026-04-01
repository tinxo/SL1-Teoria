namespace C4_Ejercicio_Asistencia
{
    partial class FrmInicio
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
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAsistencia.Location = new System.Drawing.Point(254, 56);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(276, 53);
            this.btnAsistencia.TabIndex = 0;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnPersona
            // 
            this.btnPersona.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPersona.Location = new System.Drawing.Point(254, 152);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(276, 53);
            this.btnPersona.TabIndex = 1;
            this.btnPersona.Text = "Personas";
            this.btnPersona.UseVisualStyleBackColor = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.btnAsistencia);
            this.Name = "FrmInicio";
            this.Text = "FormEvaluacion";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnPersona;
    }
}