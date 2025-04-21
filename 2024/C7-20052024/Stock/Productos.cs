using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_20052024.Stock
{
    public class Productos
    {
        // Definición de atributos
        private string _id;
        private string _nombre;
        private string _descripcion;
        private double _precioUnitario;
        // Se omite este atributo por usar la clase Movimiento
        // private int _stockActual;
        private int _stockMinimo;

        // Definición del constructor
        public Productos(string id, string nombre, string descripcion, double precioUnitario)
        {
            // Inicialización de los valores de los atributos
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _stockMinimo = 0; // Valor por regla de negocio
            // Se omite este atributo por usar la clase Movimiento
            //_stockActual = 0; // Valor por regla de negocio
            _precioUnitario = precioUnitario;
        }

        // Definición de propiedades
        public string Id { get; } // Propiedad de solo lectura
        public string Nombre 
        {
            get { return  _nombre; }
            set 
            { 
                if (value != String.Empty)
                {
                    _nombre = value;
                }
            }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                if (value != String.Empty)
                {
                    _descripcion = value;
                }
            }
        }
        public int StockMinimo
        {
            get { return _stockMinimo; }
            set
            {
                if (value > 0 )
                {
                    _stockMinimo = value;
                }
            }
        }
        public double PrecioUnitario
        {
            get { return _precioUnitario; }
            set
            {
                if (value > 0)
                {
                    _precioUnitario = value;
                }
            }
        }

        public int StockActual 
        {
            get 
            {
                int stockActual = 0;
                foreach (var movimiento in this._movimientos)
                {
                    stockActual += movimiento.Cantidad;
                }
                return stockActual;
            }
        }

        // Se define la lista de movimientos de stock
        private List<Movimiento> _movimientos = new List<Movimiento>();

        // Se definen los métodos para agregar y restar stock
        public void agregarUnidades(string idMovimiento, int cantidadUnidades,
            DateTime fecha, string descripcion)
        {
            // Se genera el objeto para registrar el movimiento
            Movimiento carga = new Movimiento(idMovimiento, cantidadUnidades,
                fecha, descripcion);
            // Se carga el movimiento en la lista del objeto
            _movimientos.Add(carga);
        }

        public void restarUnidades(string idMovimiento, int cantidadUnidades,
            DateTime fecha, string descripcion)
        {
            // Se genera el objeto para registrar el movimiento
            Movimiento descarga = new Movimiento(idMovimiento, -cantidadUnidades,
                fecha, descripcion);
            // Se carga el movimiento en la lista del objeto
            _movimientos.Add(descarga);
        }

    }
}
