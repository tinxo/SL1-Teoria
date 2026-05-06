using System;
using System.Collections.Generic;
using System.Text;

namespace App_Checkin.Modelos
{
    public class Pasajero
    {
        // Definición de atributos
        private string _nombre;
        private string _apellido;
        private string _documento;
        private string _pasajeroFrecuente;


        // Definición del constructor
        public Pasajero(string nombre, 
            string apellido, 
            string documento, 
            string pasajeroFrecuente)
        {
            _nombre = nombre;
            _apellido = apellido;
            _documento = documento;
            _pasajeroFrecuente = pasajeroFrecuente;
        }

        // Definición de propiedades
        public string Nombre
        {
            get { return _nombre; }
            set {
                if (_nombre != String.Empty) { 
                    _nombre = value;
                }
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set {
                // Validación para que no se pueda asignar un valor vacío
                if (_apellido != String.Empty) { 
                    _apellido = value;
                }
            }
        }

        public string Documento { get; set; }

        public string PasajeroFrecuente { get; set; }

        }
}
