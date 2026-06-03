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

        private void verificarPesoEquipaje(double pesoEquipaje, int nroItem)
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
                throw new ArgumentOutOfRangeException($"equipaje #{nroItem}");
            }
            else if ((ticket.TipoVuelo.ToUpper() == "I") && (pesoEquipaje > pesoLimiteInternacional))
            {
                throw new ArgumentOutOfRangeException($"equipaje #{nroItem}");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double pesoEquipaje1 = (double)this.numPeso1.Value;
            try
            {
                if (pesoEquipaje1 > 0.0)
                {
                    verificarPesoEquipaje(pesoEquipaje1, 1);
                    this.grpEquipaje1.BackColor = Color.Green;
                    // TODO: este objeto tiene que ir directo a la colección del
                    // pasajero con el que se está operando
                    Equipaje elemento1 = new Equipaje(pesoEquipaje1, "1");
                }

                if (grpEquipaje2.Visible)
                {
                    double pesoEquipaje2 = (double)this.numPeso2.Value;
                    if (pesoEquipaje2 > 0.0)
                    {
                        verificarPesoEquipaje(pesoEquipaje2, 2);
                        this.grpEquipaje2.BackColor = Color.Green;
                        // TODO: este objeto tiene que ir directo a la colección del
                        // pasajero con el que se está operando
                        Equipaje elemento1 = new Equipaje(pesoEquipaje1, "2");
                    }
                }

                if (grpEquipaje3.Visible)
                {
                    double pesoEquipaje3 = (double)this.numPeso3.Value;
                    if (pesoEquipaje3 > 0.0)
                    {
                        verificarPesoEquipaje(pesoEquipaje3, 3);
                        this.grpEquipaje3.BackColor = Color.Green;
                        // TODO: este objeto tiene que ir directo a la colección del
                        // pasajero con el que se está operando
                        Equipaje elemento1 = new Equipaje(pesoEquipaje1, "3");
                    }
                }

            } catch (ArgumentOutOfRangeException ex)
            {
                // TODO: mejorar para usar el mensaje que viene vía la exception
                MessageBox.Show($"El {ex.Message} no cumple con las restricciones de peso.");
            }

            // TODO: mejorar la lógica
            MessageBox.Show(
                "Pesaje OK. Todos los items están dentro del límite.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

        }
    }
}
