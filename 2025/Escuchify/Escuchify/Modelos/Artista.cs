using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuchify.Modelos
{
    public class Artista
    {
        // declaracion de atributos de la clase
        private string _nombreCompleto;
        private string _nombreArtistico;
        private int _anioInicio;
        private string _nacionalidad;
        private string _discografica;

        // constructor de la clase
        public Artista(string nombreCompleto, string nombreArtistico) 
        {
            // inicializacion de valores
            _nombreCompleto = nombreCompleto;
            _nombreArtistico = nombreArtistico;
        }

        /// <summary>
        /// Establece el valor del año de inicio de actividad del artista.
        /// </summary>
        /// <param name="anioInicio">El valor del año.</param>
        /// <returns>No se devuelve un valor.</returns>
        public void setAnioInicio(int anioInicio) 
        {
            _anioInicio = anioInicio;
        }

        public int getAnioInicio() 
        { 
            return _anioInicio; 
        }

        public string Nacionalidad 
        {
            get { return _nacionalidad;}
            set 
            { 
                if (value != String.Empty)
                {
                    _nacionalidad = value;
                }
            }
        }

        public string Discografica
        {
            get { return _discografica; }
            set
            {
                if (value != String.Empty)
                {
                    _discografica = value;
                }
            }
        }

        public string NombreCompleto { get { return _nombreCompleto; } }
        
        public string NombreArtistico { get { return _nombreArtistico; } }
    }
}
