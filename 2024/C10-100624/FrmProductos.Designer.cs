namespace C10_100624
{
    partial class FrmProductos
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
            btnCargar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            nupPrecioUnitario = new NumericUpDown();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            label6 = new Label();
            label8 = new Label();
            nupStockMinimo = new NumericUpDown();
            label7 = new Label();
            lstProductos = new ListBox();
            label9 = new Label();
            grpMovimientos = new GroupBox();
            btnCrearMovimiento = new Button();
            txtObservaciones = new TextBox();
            nupCantidad = new NumericUpDown();
            cbxTipoMovimiento = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)nupPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupStockMinimo).BeginInit();
            grpMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los datos del producto:";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(832, 190);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(213, 54);
            btnCargar.TabIndex = 10;
            btnCargar.Text = "Cargar producto";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 1;
            label2.Text = "ID del producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(208, 28);
            label3.TabIndex = 2;
            label3.Text = "Nombre del producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(237, 28);
            label4.TabIndex = 3;
            label4.Text = "Descripción del producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 173);
            label5.Name = "label5";
            label5.Size = new Size(262, 28);
            label5.TabIndex = 4;
            label5.Text = "Precio unitario del producto:";
            // 
            // txtID
            // 
            txtID.Location = new Point(280, 56);
            txtID.Name = "txtID";
            txtID.Size = new Size(408, 34);
            txtID.TabIndex = 5;
            // 
            // nupPrecioUnitario
            // 
            nupPrecioUnitario.DecimalPlaces = 2;
            nupPrecioUnitario.Location = new Point(280, 171);
            nupPrecioUnitario.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nupPrecioUnitario.Name = "nupPrecioUnitario";
            nupPrecioUnitario.Size = new Size(239, 34);
            nupPrecioUnitario.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(280, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(408, 34);
            txtNombre.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(280, 132);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(408, 34);
            txtDescripcion.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 173);
            label6.Name = "label6";
            label6.Size = new Size(60, 28);
            label6.TabIndex = 9;
            label6.Text = "(AR$)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 212);
            label8.Name = "label8";
            label8.Size = new Size(255, 28);
            label8.TabIndex = 12;
            label8.Text = "Stock mínimo del producto:";
            // 
            // nupStockMinimo
            // 
            nupStockMinimo.Location = new Point(280, 210);
            nupStockMinimo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nupStockMinimo.Name = "nupStockMinimo";
            nupStockMinimo.Size = new Size(239, 34);
            nupStockMinimo.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 212);
            label7.Name = "label7";
            label7.Size = new Size(106, 28);
            label7.TabIndex = 14;
            label7.Text = "(Unidades)";
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 28;
            lstProductos.Location = new Point(12, 317);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(803, 144);
            lstProductos.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 286);
            label9.Name = "label9";
            label9.Size = new Size(203, 28);
            label9.TabIndex = 16;
            label9.Text = "Productos cargados:";
            // 
            // grpMovimientos
            // 
            grpMovimientos.BackColor = SystemColors.InactiveCaption;
            grpMovimientos.Controls.Add(btnCrearMovimiento);
            grpMovimientos.Controls.Add(txtObservaciones);
            grpMovimientos.Controls.Add(nupCantidad);
            grpMovimientos.Controls.Add(cbxTipoMovimiento);
            grpMovimientos.Controls.Add(label12);
            grpMovimientos.Controls.Add(label11);
            grpMovimientos.Controls.Add(label10);
            grpMovimientos.Font = new Font("Segoe UI", 12F);
            grpMovimientos.Location = new Point(12, 467);
            grpMovimientos.Name = "grpMovimientos";
            grpMovimientos.Size = new Size(1057, 184);
            grpMovimientos.TabIndex = 18;
            grpMovimientos.TabStop = false;
            grpMovimientos.Text = "Registro de movimientos de un producto:";
            // 
            // btnCrearMovimiento
            // 
            btnCrearMovimiento.Location = new Point(820, 102);
            btnCrearMovimiento.Name = "btnCrearMovimiento";
            btnCrearMovimiento.Size = new Size(213, 54);
            btnCrearMovimiento.TabIndex = 11;
            btnCrearMovimiento.Text = "Cargar movimeinto";
            btnCrearMovimiento.UseVisualStyleBackColor = true;
            btnCrearMovimiento.Click += btnCrearMovimiento_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(251, 122);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(368, 34);
            txtObservaciones.TabIndex = 5;
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(251, 81);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(228, 34);
            nupCantidad.TabIndex = 4;
            // 
            // cbxTipoMovimiento
            // 
            cbxTipoMovimiento.FormattingEnabled = true;
            cbxTipoMovimiento.Items.AddRange(new object[] { "Ingreso", "Egreso" });
            cbxTipoMovimiento.Location = new Point(248, 39);
            cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            cbxTipoMovimiento.Size = new Size(231, 36);
            cbxTipoMovimiento.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 125);
            label12.Name = "label12";
            label12.Size = new Size(143, 28);
            label12.TabIndex = 2;
            label12.Text = "Observaciones:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 83);
            label11.Name = "label11";
            label11.Size = new Size(206, 28);
            label11.TabIndex = 1;
            label11.Text = "Cantidad de unidades:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 42);
            label10.Name = "label10";
            label10.Size = new Size(193, 28);
            label10.TabIndex = 0;
            label10.Text = "Tipo de movimeinto:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(832, 317);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(213, 54);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar producto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(832, 377);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(213, 54);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(832, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(213, 54);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar producto";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 663);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(grpMovimientos);
            Controls.Add(label9);
            Controls.Add(lstProductos);
            Controls.Add(label7);
            Controls.Add(nupStockMinimo);
            Controls.Add(label8);
            Controls.Add(btnCargar);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(nupPrecioUnitario);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmProductos";
            Text = "Gestión de Productos - CRUD";
            ((System.ComponentModel.ISupportInitialize)nupPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupStockMinimo).EndInit();
            grpMovimientos.ResumeLayout(false);
            grpMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCargar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private NumericUpDown nupPrecioUnitario;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label label6;
        private Label label8;
        private NumericUpDown nupStockMinimo;
        private Label label7;
        private ListBox lstProductos;
        private Label label9;
        private GroupBox grpMovimientos;
        private Button btnCrearMovimiento;
        private TextBox txtObservaciones;
        private NumericUpDown nupCantidad;
        private ComboBox cbxTipoMovimiento;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnBuscar;
    }
}