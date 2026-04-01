using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4_Ejercicio_Asistencia
{
    public partial class FrmAsistencia : Form
    {
        string mensajeLabel = "Cantidad de asistentes:";

        private void cargarElemento()
        {
            // Se toma el valor ingresado
            string nombreIngresado = txtNombre.Text;
            if (nombreIngresado == string.Empty)
            {
                MessageBox.Show("Se debe ingresar un valor",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                // Agrego el valor al listbox
                lstPresentes.Items.Add(nombreIngresado);
                // Se actualiza el valor de cantidad en la label
                lblCantidad.Text = $"{mensajeLabel} {lstPresentes.Items.Count}";
            }
            // Se limpia el valor del textbox
            txtNombre.Text = "";
            txtNombre.Focus();
        }

        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cargarElemento();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
           DialogResult respuesta = MessageBox.Show("¿Quiere reiniciar el listado?",
                "Pregunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                // Se tiene que limpiar la listbox y sacar el count de la label
                lstPresentes.Items.Clear();
                lblCantidad.Text = mensajeLabel;
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cargarElemento();
            }
        }
    }
}
