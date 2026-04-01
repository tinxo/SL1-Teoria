using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuchify.Modelos
{
    public class Disco
    {
        // definición de atributos
        private string _nombre;
        private int _anioLanzamiento;
        private int _cantidadCanciones;
        private int _duracionTotal;
        private string _tipoDisco; //estudio, en vivo, antología, etc

        public Disco (string nombre, int anioLanzamiento, int cantidadCanciones, int duracionTotal, string tipoDisco)
        {
            _nombre = nombre;
            _anioLanzamiento = anioLanzamiento;
            _cantidadCanciones = cantidadCanciones;
            _duracionTotal = duracionTotal;
            _tipoDisco = tipoDisco;
        }

        public string Nombre {  get { return _nombre; } }

        public int AnioLanzamiento { get { return _anioLanzamiento; } }
    }
}
