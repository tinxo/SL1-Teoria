using C10_100624.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C10_100624
{
    public partial class FrmProductos : Form
    {

        // Colección de productos para usar
        private List<Producto> _listaProductos = new List<Producto>();
        // Un producto en particular para usar
        private Producto _unProducto;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Se leen los valores desde la interfaz
            string idIngresado = txtID.Text;
            string nombreIngresado = txtNombre.Text;
            string descripcionIngresada = txtDescripcion.Text;
            double precioUnitarioIngresado = (double)nupPrecioUnitario.Value;
            int stockMinimoIngresado = (int)nupStockMinimo.Value;

            if (this.btnCargar.Text.Contains("Cargar"))
            {
                // Se genera el objeto Producto
                Producto productoTemp = new Producto(idIngresado,
                    nombreIngresado, descripcionIngresada,
                    precioUnitarioIngresado, stockMinimoIngresado);
                // Se carga en la lista en memoria
                this._listaProductos.Add(productoTemp);
            }
            else
            {
                // Estamos EDITANDO
                _unProducto.Nombre = nombreIngresado;
                _unProducto.Descripcion = descripcionIngresada;
                _unProducto.PrecioUnitario = precioUnitarioIngresado;
                _unProducto.StockMinimo = stockMinimoIngresado;
                //this._listaProductos[this.lstProductos.SelectedIndex] = productoTemp;
                // Volvemos a dejar la UI como al inicio
                this.btnCargar.Text = "Cargar producto";
                this.txtID.Enabled = true;
            }

            // Se carga en el listbox para visualización
            this.sincronizarListado();
        }

        private void btnCrearMovimiento_Click(object sender, EventArgs e)
        {
            if (this.lstProductos.SelectedIndex != -1)
            {
                // Hay algo seleccionado
                // Se necesita un movimiento seleccionado
                _unProducto = this._listaProductos[this.lstProductos.SelectedIndex];
                // Se va a cargar un movimiento nuevo
                int cantidadIngresada = (int)this.nupCantidad.Value;
                string observacionesMovimiento = this.txtObservaciones.Text;
                if (this.cbxTipoMovimiento.SelectedIndex == 0)
                {
                    // Ingreso
                    _unProducto.agregarUnidades("123", cantidadIngresada, DateTime.Now, observacionesMovimiento);
                }
                else
                {
                    // Egreso
                    try
                    {
                        _unProducto.restarUnidades("123", cantidadIngresada, DateTime.Now, observacionesMovimiento);
                    }
                    catch (StockException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                // Se actualiza en el listbox la visualización
                this.sincronizarListado();
            }
            else
            {
                MessageBox.Show("Se tiene que seleccionar un Producto desde la lista.");
            }

        }

        private void sincronizarListado()
        {
            this.lstProductos.Items.Clear();
            foreach (var producto in this._listaProductos)
            {
                this.lstProductos.Items.Add(producto);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.lstProductos.SelectedIndex != -1)
            {
                // Hay algo seleccionado
                // Se necesita un movimiento seleccionado
                _unProducto = this._listaProductos[this.lstProductos.SelectedIndex];
                // Carga de los valores del objeto en la UI
                this.txtID.Text = _unProducto.Id;
                this.txtID.Enabled = false;
                this.txtNombre.Text = _unProducto.Nombre;
                this.txtDescripcion.Text = _unProducto.Descripcion;
                this.nupPrecioUnitario.Value = (decimal)_unProducto.PrecioUnitario;
                this.nupStockMinimo.Value = (int)_unProducto.StockMinimo;
                // Reescritura del text del btnCargar para que sea de guardado
                this.btnCargar.Text = "Guardar cambios";
            }
            else
            {
                MessageBox.Show("Se tiene que seleccionar un Producto desde la lista.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstProductos.SelectedIndex != -1)
            {
                // Hay algo seleccionado
                DialogResult respuesta = MessageBox.Show("Esta por eliminar el producto, ¿esta seguro?", "Pregunta", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    this._listaProductos.RemoveAt(this.lstProductos.SelectedIndex);
                }
                // Se actualiza en el listbox la visualización
                this.sincronizarListado();
            }
            else
            {
                MessageBox.Show("Se tiene que seleccionar un Producto desde la lista.");
            }
        }

        Producto buscarProducto(string idBuscado)
        {
            if (_listaProductos.Count == 0)
            {
                // Lista vacía
                throw new Exception("La lista está vacía, no se puede hacer una búsqueda.");
            } 
            else
            {
                foreach (var producto in _listaProductos)
                {
                    if (producto.Id == idBuscado)
                    {
                        // Encuentra el producto
                        return producto;
                    }
                }
                // Si NO encuentro el producto
                throw new Exception("Producto no encontrado.");
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                string idIngresado = txtID.Text;
                try
                {
                    this._unProducto = buscarProducto(idIngresado);
                    MessageBox.Show($"Producto encontrado: {_unProducto.ToString}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
            else
            {
                MessageBox.Show("Se tiene cargar un ID para hacer la búsqueda.");
            }
        }
    }
}
