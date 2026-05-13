using App_Checkin.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App_Checkin
{
    public partial class FrmEquipaje : Form
    {
        //private String _tipoVuelo = String.Empty;
        private Pasaje ticket;
        public FrmEquipaje()
        {
            InitializeComponent();
        }

        private int obtenerCantidadEquipaje(string tipoTarifa)
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

        public void configurarFormulario(Pasaje unTicket)
            // TODO: ENVIAR al pasajero para poder después asignarle cada item de equipaje
        {
            ticket = unTicket;
            int cantidadEquipaje = obtenerCantidadEquipaje(ticket.TipoTarifa);
            if (cantidadEquipaje == 1)
            {
                this.grpEquipaje2.Visible = false;
                this.grpEquipaje3.Visible = false;
            }
            else if (cantidadEquipaje == 2)
            {
                this.grpEquipaje3.Visible = false;
            }
            //_tipoVuelo = tipoVuelo;
        }

        private bool verificarPesoEquipaje(double pesoEquipaje, int nroItem)
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
            if ((ticket.TipoVuelo.ToUpper() == "N") && (pesoEquipaje > pesoLimiteNacional))
            {
                return false;
            }
            else if ((ticket.TipoVuelo.ToUpper() == "I") && (pesoEquipaje > pesoLimiteInternacional))
            {
                return false;
            }
            else
            {
                return true; // el peso del equipaje es válido para el tipo de vuelo
            }

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double pesoEquipaje1 = (double)this.numPeso1.Value;
            bool resultado1 = false;
            if (pesoEquipaje1 > 0.0)
            {
                resultado1 = verificarPesoEquipaje(pesoEquipaje1, 1);
                if (resultado1)
                {
                    this.grpEquipaje1.BackColor = Color.Green;
                    // TODO: este objeto tiene que ir directo a la colección del
                    // pasajero con el que se está operando
                    Equipaje elemento1 = new Equipaje(pesoEquipaje1, "1");
                }
            }
            double pesoEquipaje2 = (double)this.numPeso2.Value;
            bool resultado2 = false;
            if (pesoEquipaje2 > 0.0)
            {
                resultado2 = verificarPesoEquipaje(pesoEquipaje2, 2);
            }
            double pesoEquipaje3 = (double)this.numPeso3.Value;
            bool resultado3 = false;
            if (pesoEquipaje3 > 0.0)
            {
                resultado3 = verificarPesoEquipaje(pesoEquipaje3, 3);
            }
            // TODO: mejorar la lógica
            if ((!resultado1 && !resultado2) && (!resultado3))
            {
                MessageBox.Show("Pesaje OK");
            } else
            {
                MessageBox.Show("Pesaje con error.");
            }

        }
    }
}
