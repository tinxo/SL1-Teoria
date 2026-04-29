namespace App_Checkin
{
    partial class FrmEquipaje
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
            grpEquipaje1 = new GroupBox();
            numPeso1 = new NumericUpDown();
            label2 = new Label();
            btnVerificar = new Button();
            grpEquipaje2 = new GroupBox();
            numPeso2 = new NumericUpDown();
            label3 = new Label();
            grpEquipaje3 = new GroupBox();
            numPeso3 = new NumericUpDown();
            label4 = new Label();
            btnVolver = new Button();
            grpEquipaje1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPeso1).BeginInit();
            grpEquipaje2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPeso2).BeginInit();
            grpEquipaje3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPeso3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(456, 28);
            label1.TabIndex = 0;
            label1.Text = "Se van a ingresar los datos de 3 piezas de equipaje:";
            // 
            // grpEquipaje1
            // 
            grpEquipaje1.BackColor = SystemColors.InactiveCaption;
            grpEquipaje1.Controls.Add(numPeso1);
            grpEquipaje1.Controls.Add(label2);
            grpEquipaje1.Location = new Point(13, 52);
            grpEquipaje1.Name = "grpEquipaje1";
            grpEquipaje1.Size = new Size(444, 161);
            grpEquipaje1.TabIndex = 1;
            grpEquipaje1.TabStop = false;
            grpEquipaje1.Text = "Ingrese el peso del equipaje 1:";
            // 
            // numPeso1
            // 
            numPeso1.DecimalPlaces = 2;
            numPeso1.Location = new Point(158, 44);
            numPeso1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numPeso1.Name = "numPeso1";
            numPeso1.Size = new Size(150, 34);
            numPeso1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 0;
            label2.Text = "Ingrese el peso:";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(501, 514);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(145, 49);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // grpEquipaje2
            // 
            grpEquipaje2.BackColor = SystemColors.InactiveCaption;
            grpEquipaje2.Controls.Add(numPeso2);
            grpEquipaje2.Controls.Add(label3);
            grpEquipaje2.Location = new Point(13, 233);
            grpEquipaje2.Name = "grpEquipaje2";
            grpEquipaje2.Size = new Size(444, 161);
            grpEquipaje2.TabIndex = 3;
            grpEquipaje2.TabStop = false;
            grpEquipaje2.Text = "Ingrese el peso del equipaje 2:";
            // 
            // numPeso2
            // 
            numPeso2.DecimalPlaces = 2;
            numPeso2.Location = new Point(158, 44);
            numPeso2.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numPeso2.Name = "numPeso2";
            numPeso2.Size = new Size(150, 34);
            numPeso2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 46);
            label3.Name = "label3";
            label3.Size = new Size(146, 28);
            label3.TabIndex = 0;
            label3.Text = "Ingrese el peso:";
            // 
            // grpEquipaje3
            // 
            grpEquipaje3.BackColor = SystemColors.InactiveCaption;
            grpEquipaje3.Controls.Add(numPeso3);
            grpEquipaje3.Controls.Add(label4);
            grpEquipaje3.Location = new Point(13, 417);
            grpEquipaje3.Name = "grpEquipaje3";
            grpEquipaje3.Size = new Size(444, 161);
            grpEquipaje3.TabIndex = 3;
            grpEquipaje3.TabStop = false;
            grpEquipaje3.Text = "Ingrese el peso del equipaje 3:";
            // 
            // numPeso3
            // 
            numPeso3.DecimalPlaces = 2;
            numPeso3.Location = new Point(158, 44);
            numPeso3.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numPeso3.Name = "numPeso3";
            numPeso3.Size = new Size(150, 34);
            numPeso3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 46);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 0;
            label4.Text = "Ingrese el peso:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(501, 569);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 49);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // FrmEquipaje
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 630);
            Controls.Add(btnVerificar);
            Controls.Add(btnVolver);
            Controls.Add(grpEquipaje2);
            Controls.Add(grpEquipaje3);
            Controls.Add(grpEquipaje1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmEquipaje";
            Text = "FrmEquipaje";
            grpEquipaje1.ResumeLayout(false);
            grpEquipaje1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPeso1).EndInit();
            grpEquipaje2.ResumeLayout(false);
            grpEquipaje2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPeso2).EndInit();
            grpEquipaje3.ResumeLayout(false);
            grpEquipaje3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPeso3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpEquipaje1;
        private Button btnVerificar;
        private NumericUpDown numPeso1;
        private Label label2;
        private GroupBox grpEquipaje2;
        private NumericUpDown numPeso2;
        private Label label3;
        private GroupBox grpEquipaje3;
        private NumericUpDown numPeso3;
        private Label label4;
        private Button btnVolver;
    }
}