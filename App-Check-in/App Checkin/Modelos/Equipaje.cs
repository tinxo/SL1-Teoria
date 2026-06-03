using System;
using System.Collections.Generic;
using System.Text;

namespace App_Checkin.Modelos
{
    public class Equipaje
    {
        private double _pesoKg;
        private string _id;

        public Equipaje(double pesoKg, string id)
        {
            _pesoKg = pesoKg;
            _id = id;
        }

        public double PesoKg { get { return _pesoKg; } }

    }
}
