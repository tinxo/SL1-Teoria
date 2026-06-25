using System;
using System.Collections.Generic;
using System.Text;

namespace Web_Check_in.Modelos
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
