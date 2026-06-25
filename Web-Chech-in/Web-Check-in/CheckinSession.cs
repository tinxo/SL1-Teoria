using Web_Check_in.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web_Check_in
{
    public static class CheckinSession
    {
        // Esta clase guarda en memoria los datos
        // que se están procesando en un moento dado.

        public static Pasajero? Pasajero { get; set; }
        public static Pasaje? Pasaje { get; set; }
    }
}
