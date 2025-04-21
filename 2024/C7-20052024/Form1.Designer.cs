namespace C7_20052024
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            nupPrecioUnitario = new NumericUpDown();
            nupStockMinimo = new NumericUpDown();
            cbxTipoMovimiento = new ComboBox();
            label6 = new Label();
            nupCantidadUnivdades = new NumericUpDown();
            label7 = new Label();
            txtObservaciones = new TextBox();
            label8 = new Label();
            button2 = new Button();
            lblProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)nupPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidadUnivdades).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(580, 228);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(296, 59);
            button1.TabIndex = 0;
            button1.Text = "Crear producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 1;
            label1.Text = "ID del producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 28);
            label2.TabIndex = 2;
            label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(237, 28);
            label3.TabIndex = 3;
            label3.Text = "Descripción del producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 4;
            label4.Text = "Precio unitario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 178);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 5;
            label5.Text = "Stock mínimo:";
            // 
            // txtID
            // 
            txtID.Location = new Point(332, 10);
            txtID.Name = "txtID";
            txtID.Size = new Size(193, 34);
            txtID.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(332, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 34);
            txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(332, 96);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(193, 34);
            txtDescripcion.TabIndex = 8;
            // 
            // nupPrecioUnitario
            // 
            nupPrecioUnitario.DecimalPlaces = 2;
            nupPrecioUnitario.Location = new Point(408, 137);
            nupPrecioUnitario.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nupPrecioUnitario.Name = "nupPrecioUnitario";
            nupPrecioUnitario.Size = new Size(117, 34);
            nupPrecioUnitario.TabIndex = 9;
            // 
            // nupStockMinimo
            // 
            nupStockMinimo.Location = new Point(408, 176);
            nupStockMinimo.Name = "nupStockMinimo";
            nupStockMinimo.Size = new Size(117, 34);
            nupStockMinimo.TabIndex = 10;
            // 
            // cbxTipoMovimiento
            // 
            cbxTipoMovimiento.FormattingEnabled = true;
            cbxTipoMovimiento.Items.AddRange(new object[] { "Ingreso", "Egreso" });
            cbxTipoMovimiento.Location = new Point(252, 308);
            cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            cbxTipoMovimiento.Size = new Size(200, 36);
            cbxTipoMovimiento.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 311);
            label6.Name = "label6";
            label6.Size = new Size(189, 28);
            label6.TabIndex = 12;
            label6.Text = "Tipo de movimiento";
            // 
            // nupCantidadUnivdades
            // 
            nupCantidadUnivdades.Location = new Point(252, 362);
            nupCantidadUnivdades.Name = "nupCantidadUnivdades";
            nupCantidadUnivdades.Size = new Size(150, 34);
            nupCantidadUnivdades.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 364);
            label7.Name = "label7";
            label7.Size = new Size(202, 28);
            label7.TabIndex = 14;
            label7.Text = "Cantidad de unidades";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(252, 413);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(200, 34);
            txtObservaciones.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 416);
            label8.Name = "label8";
            label8.Size = new Size(139, 28);
            label8.TabIndex = 16;
            label8.Text = "Observaciones";
            // 
            // button2
            // 
            button2.Location = new Point(580, 385);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(296, 59);
            button2.TabIndex = 17;
            button2.Text = "Cargar movimiento";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(73, 243);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(97, 28);
            lblProducto.TabIndex = 18;
            lblProducto.Text = "Producto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 630);
            Controls.Add(lblProducto);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(txtObservaciones);
            Controls.Add(label7);
            Controls.Add(nupCantidadUnivdades);
            Controls.Add(label6);
            Controls.Add(cbxTipoMovimiento);
            Controls.Add(nupStockMinimo);
            Controls.Add(nupPrecioUnitario);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nupPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidadUnivdades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private NumericUpDown nupPrecioUnitario;
        private NumericUpDown nupStockMinimo;
        private ComboBox cbxTipoMovimiento;
        private Label label6;
        private NumericUpDown nupCantidadUnivdades;
        private Label label7;
        private TextBox txtObservaciones;
        private Label label8;
        private Button button2;
        private Label lblProducto;
    }
}
