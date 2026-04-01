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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void botones_Click(object sender, EventArgs e)
        {
            Button botonPresionado = sender as Button;
            // Controlar cuál fue el presionado
            if (botonPresionado.Text.ToLower().Contains("asistencia"))
            {
                // Abrir formulario de asistencia
                FrmAsistencia frm = new FrmAsistencia();
                frm.ShowDialog();
            } else
            {
                // No implementado
                MessageBox.Show("En breve.");
            }
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            btnAsistencia.Click += new EventHandler(botones_Click);
            btnPersona.Click += new EventHandler(botones_Click);
        }
    }
}
