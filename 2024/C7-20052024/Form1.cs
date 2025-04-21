using C7_20052024.Stock;
using System.Windows.Forms.VisualStyles;

namespace C7_20052024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Productos unProducto;

        private void button1_Click(object sender, EventArgs e)
        {
            // Se leen los valores desde la interfaz
            string idIngresado = txtID.Text;
            string nombreIngresado = txtNombre.Text;
            string descripcionIngresada = txtDescripcion.Text;
            double precioUnitarioIngresado = (double)nupPrecioUnitario.Value;
            // Se genera el objeto Producto
            unProducto = new Productos(idIngresado,
                nombreIngresado, descripcionIngresada,
                precioUnitarioIngresado);
            string nombreProducto = unProducto.Nombre;
            this.lblProducto.Text = $"El producto creado fue: {nombreProducto}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Se va a cargar un movimiento nuevo
            int cantidadIngresada = (int)this.nupCantidadUnivdades.Value;
            string observacionesMovimiento = this.txtObservaciones.Text;
            if (this.cbxTipoMovimiento.SelectedIndex == 0) 
            {
                // Ingreso
                unProducto.agregarUnidades("123", cantidadIngresada, DateTime.Now, observacionesMovimiento);
            } else
            {
                // Egreso
                unProducto.restarUnidades("123", cantidadIngresada, DateTime.Now, observacionesMovimiento);
            }
            MessageBox.Show($"Stock actual del producto: {unProducto.StockActual}");
        }
    }
}
