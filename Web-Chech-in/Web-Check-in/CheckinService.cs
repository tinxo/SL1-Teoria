using Web_Check_in.Modelos;
using Web_Check_in.Modelos.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web_Check_in
{
    public class CheckinService
    {
        // Esta clase va a tener toda la lógica del negocio que
        // hoy tenemos en los formularios.De esta forma, los formularios
        // van a ser más livianos y van a tener solo la lógica de la
        // interfaz de usuario.

        public void RegistrarPasajero(string nombre, string apellido, string documento, string paxFrecuente)
        {
            CheckinSession.Pasajero = new Pasajero(nombre, apellido, documento, paxFrecuente);
        }

        public void RegistrarPasaje(string tipoVuelo, string tipoTarifa, string nroVuelo)
        {
            CheckinSession.Pasaje = new Pasaje(tipoVuelo, tipoTarifa, nroVuelo);
        }

        public void AgregarEquipaje(Equipaje unEquipaje)
        {
            CheckinSession.Pasajero?.agregarEquipaje(unEquipaje);
        }

        public int obtenerCantidadEquipaje(string tipoTarifa)
        {
            int cantidadItems;
            if (tipoTarifa.ToUpper() == "P" || tipoTarifa.ToUpper() == "B")
            {
                cantidadItems = 1;
            }
            else if (tipoTarifa.ToUpper() == "F")
            {
                cantidadItems = 2;
            }
            else
            {
                cantidadItems = 3;
            }
            return cantidadItems;
        }


        public void verificarPesoEquipaje(double pesoEquipaje, int nroItem, string tipoVuelo)
        {
            double pesoLimiteNacional = 0.0;
            double pesoLimiteInternacional = 0.0;
            if (nroItem == 1)
            {
                // solo el primer item tiene estas restricciones de peso
                pesoLimiteNacional = 8.0;
                pesoLimiteInternacional = 10.0;
            }
            else
            {
                // item despachado en bodega, tiene estas restricciones de peso
                pesoLimiteNacional = 15.0;
                pesoLimiteInternacional = 23.0;
            }

            if ((tipoVuelo.ToUpper() == "N") && (pesoEquipaje > pesoLimiteNacional))
            {
                //throw new ArgumentOutOfRangeException($"equipaje #{nroItem}");
                throw new PesoExcedidoException(pesoEquipaje, pesoLimiteNacional, nroItem);
            }
            else if ((tipoVuelo.ToUpper() == "I") && (pesoEquipaje > pesoLimiteInternacional))
            {
                //throw new ArgumentOutOfRangeException($"equipaje #{nroItem}");
                throw new PesoExcedidoException(pesoEquipaje, pesoLimiteInternacional, nroItem);
            }
        }

    }
}
