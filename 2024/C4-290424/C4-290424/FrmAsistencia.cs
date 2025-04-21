namespace C4_290424
{
    public partial class frmAsistencia : Form
    {
        public frmAsistencia()
        {
            InitializeComponent();
        }

        // Texto para el contador de asistentes
        private string textoContador = "Cantidad de asistentes: ";

        private void cargarNombreEnLista()
        {
            string nombreIngresado = this.txtNombrePersona.Text;
            // Se limpian los espacios en blanco iniciales y finales
            nombreIngresado = nombreIngresado.Trim();
            if (nombreIngresado == "")
            {
                MessageBox.Show("Se debe ingresar un valor.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                // Tengo que cargar la listbox con ese valor
                this.lstAsistentes.Items.Add(nombreIngresado);
                // Actualizo el valor del contador
                int cantidadElementos = this.lstAsistentes.Items.Count;
                this.lblContador.Text = $"{this.textoContador}{cantidadElementos}";
            }
            // Vaciar el cuadro de texto para el siguiente caso
            this.txtNombrePersona.Text = "";
            txtNombrePersona.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarNombreEnLista();
        }

        private void txtNombrePersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Presionó enter en el txtbox
                cargarNombreEnLista();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quiene reiniciar listado?",
                "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (respuesta == DialogResult.Yes)
            {
                // Limpiar la lista
                this.lstAsistentes.Items.Clear();
                // Volver a valor por defecto a lbl de conteo
                this.lblContador.Text = this.textoContador;
                // Volver al txtbox de nombre a vacío
                this.txtNombrePersona.Text = "";
                txtNombrePersona.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
