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
        private String _tipoVuelo = String.Empty;
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

        public void configurarFormulario(String tipoVuelo, String tipoTarifa)
        {
            int cantidadEquipaje = obtenerCantidadEquipaje(tipoTarifa);
            if (cantidadEquipaje == 1)
            {
                this.grpEquipaje2.Visible = false;
                this.grpEquipaje3.Visible = false;
            }
            else if (cantidadEquipaje == 2)
            {
                this.grpEquipaje3.Visible = false;
            }
            _tipoVuelo = tipoVuelo;
        }

        private bool verificarPesoEquipaje(double pesoEquipaje, int nroItem, string tipoVuelo)
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
                return false;
            }
            else if ((tipoVuelo.ToUpper() == "I") && (pesoEquipaje > pesoLimiteInternacional))
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
                resultado1 = verificarPesoEquipaje(pesoEquipaje1, 1, _tipoVuelo);
                if (resultado1)
                {
                    this.grpEquipaje1.BackColor = Color.Green;
                }
            }
            double pesoEquipaje2 = (double)this.numPeso2.Value;
            bool resultado2 = false;
            if (pesoEquipaje2 > 0.0)
            {
                resultado2 = verificarPesoEquipaje(pesoEquipaje2, 2, _tipoVuelo);
            }
            double pesoEquipaje3 = (double)this.numPeso3.Value;
            bool resultado3 = false;
            if (pesoEquipaje3 > 0.0)
            {
                resultado3 = verificarPesoEquipaje(pesoEquipaje3, 3, _tipoVuelo);
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
