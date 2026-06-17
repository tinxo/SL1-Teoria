using App_Checkin.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Checkin
{
    public static class CheckinSession
    {
        // Esta clase guarda en memoria los datos
        // que se están procesando en un moento dado.

        public static Pasajero? Pasajero { get; set; }
        public static Pasaje? Pasaje { get; set; }
    }
}
