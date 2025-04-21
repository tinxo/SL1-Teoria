using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_20052024.Stock
{
    internal class Movimiento
    {
        public string Id { get; }
        public int Cantidad { get; }
        public DateTime Fecha { get; }
        public string Observaciones { get; }

        public Movimiento(string id, int cantidad, 
            DateTime fecha, string observaciones)
        {
            Id = id;
            Cantidad = cantidad;
            Fecha = fecha;
            Observaciones = observaciones;
        }   
    }
}
