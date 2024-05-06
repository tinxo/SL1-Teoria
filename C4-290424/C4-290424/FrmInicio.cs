﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4_290424
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();

            // Defino que ambos eventos click de los botones se controlan con el mismo método
            this.btnAsistencia.Click += new EventHandler(botones_click);
            this.btnNotas.Click += new EventHandler(botones_click);
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            
        }

        private void botones_click(object sender, EventArgs e)
        {
            Button btnPresionado = sender as Button;
            MessageBox.Show($"El boton presionado fue: {btnPresionado.Name}");
        }
    }
}
