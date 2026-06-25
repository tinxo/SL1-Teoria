using System;
using System.Collections.Generic;
using System.Text;
using Web_Check_in.Modelos.Exceptions;

namespace Web_Check_in.Modelos
{
    public class Pasajero
    {
        // Definición de atributos
        private string _nombre;
        private string _apellido;
        private string _documento;
        private string _pasajeroFrecuente;
        private List<Equipaje> _equipajes = new List<Equipaje>();


        // Definición del constructor
        public Pasajero(string nombre, 
            string apellido, 
            string documento, 
            string pasajeroFrecuente)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                // lanzar exception para datos invalidos
                throw new DatosInvalidosException(
                    "Nombre", "El nombre no puede estar vacío."
                    );
            }
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
                if (value != String.Empty) { 
                    _nombre = value;
                }
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set {
                // Validación para que no se pueda asignar un valor vacío
                if (value != String.Empty) { 
                    _apellido = value;
                }
            }
        }

        public string Documento { get; set; }

        public string PasajeroFrecuente { get; set; }

        public List<Equipaje> getEquipajes()
        {
            return _equipajes;
        }

        public void agregarEquipaje(Equipaje unEquipaje)
        {
            _equipajes.Add(unEquipaje);
        }

        }
}
