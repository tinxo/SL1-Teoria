namespace C4_290424
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
            label1 = new Label();
            btnAsistencia = new Button();
            btnNotas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(342, 28);
            label1.TabIndex = 0;
            label1.Text = "Seleccione la ventana que quiere abrir";
            // 
            // btnAsistencia
            // 
            btnAsistencia.Location = new Point(155, 63);
            btnAsistencia.Name = "btnAsistencia";
            btnAsistencia.Size = new Size(260, 47);
            btnAsistencia.TabIndex = 1;
            btnAsistencia.Text = "Formulario de Asistencia";
            btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnNotas
            // 
            btnNotas.Location = new Point(155, 116);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(260, 47);
            btnNotas.TabIndex = 2;
            btnNotas.Text = "Formulario de Notas";
            btnNotas.UseVisualStyleBackColor = true;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 267);
            Controls.Add(btnNotas);
            Controls.Add(btnAsistencia);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmInicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAsistencia;
        private Button btnNotas;
    }
}