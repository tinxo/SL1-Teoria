using App_Checkin.Modelos;
using App_Checkin.Modelos.Exceptions;
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
        private CheckinService servicio = new CheckinService();
        public FrmEquipaje()
        {
            InitializeComponent();
        }

        

        public void configurarFormulario()
            // TODO: ENVIAR al pasajero para poder después asignarle cada item de equipaje
        {
            int cantidadEquipaje = servicio.obtenerCantidadEquipaje(CheckinSession.Pasaje.TipoTarifa);
            if (cantidadEquipaje == 1)
            {
                this.grpEquipaje2.Visible = false;
                this.grpEquipaje3.Visible = false;
            }
            else if (cantidadEquipaje == 2)
            {
                this.grpEquipaje3.Visible = false;
            }
        }

        

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double pesoEquipaje1 = (double)this.numPeso1.Value;
            string tipoVuelo = CheckinSession.Pasaje.TipoVuelo;
            try
            {
                if (pesoEquipaje1 > 0.0)
                {
                    servicio.verificarPesoEquipaje(pesoEquipaje1, 1, tipoVuelo);
                    this.grpEquipaje1.BackColor = Color.Green;
                    // TODO: este objeto tiene que ir directo a la colección del
                    // pasajero con el que se está operando
                    Equipaje elemento1 = new Equipaje(pesoEquipaje1, "1");
                    servicio.AgregarEquipaje(elemento1);
                }

                if (grpEquipaje2.Visible)
                {
                    double pesoEquipaje2 = (double)this.numPeso2.Value;
                    if (pesoEquipaje2 > 0.0)
                    {
                        servicio.verificarPesoEquipaje(pesoEquipaje2, 2, tipoVuelo);
                        this.grpEquipaje2.BackColor = Color.Green;
                        // TODO: este objeto tiene que ir directo a la colección del
                        // pasajero con el que se está operando
                        Equipaje elemento2 = new Equipaje(pesoEquipaje2, "2");
                        servicio.AgregarEquipaje(elemento2);
                    }
                }

                if (grpEquipaje3.Visible)
                {
                    double pesoEquipaje3 = (double)this.numPeso3.Value;
                    if (pesoEquipaje3 > 0.0)
                    {
                        servicio.verificarPesoEquipaje(pesoEquipaje3, 3, tipoVuelo);
                        this.grpEquipaje3.BackColor = Color.Green;
                        // TODO: este objeto tiene que ir directo a la colección del
                        // pasajero con el que se está operando
                        Equipaje elemento3 = new Equipaje(pesoEquipaje3, "3");
                        servicio.AgregarEquipaje(elemento3);
                    }
                }

            } catch (PesoExcedidoException ex)
            {
                // TODO: mejorar para usar el mensaje que viene vía la exception
                MessageBox.Show($"Error: {ex.Message}. Revise los valores e intente nuevamente.");
                return;
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
