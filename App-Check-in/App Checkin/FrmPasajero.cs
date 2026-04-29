namespace App_Checkin
{
    public partial class FrmPasajero : Form
    {
        // TODO: mover acá las variables
        public FrmPasajero()
        {
            InitializeComponent();
        }

        private void evetoClickBtnProcesar(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string documento = txtDocumento.Text;
            string pasajeroFrecuente = txtPaxFrecuente.Text;
            string tipoVuelo; // "N" o "I"
            // TODO: Agregar verificación para que sí o sí uno tenga que estar seleccionado
            if (rdbInternacional.Checked)
            {
                tipoVuelo = "I";
            }
            else
            {
                tipoVuelo = "N";
            }
            string tipoTarifa = String.Empty;
            if (cbxTipoTarifa.SelectedItem != null)
            {
                tipoTarifa = cbxTipoTarifa.SelectedItem.ToString();
            }
            // Agregar verificación para que sí o sí uno tenga que estar seleccionado
            string nroVuelo = "AR1766";

            // Informar datos cargados
            /*MessageBox.Show($"Datos del pasajero: +" +
                $"\n {apellido}, {nombre}: +" +
                $"\nDNI: {documento} - NPxFrecuente: {pasajeroFrecuente} +" +
                $"\n Vuelo: {tipoVuelo} con la tarifa {tipoTarifa}");
            */
            // Se pasa a visible el área para mostrar los resultados
            this.grpDatosPax.Visible = true;
            // Se cargan los resultados (datos del pasajero)
            this.lblDatosPax.Text = $"{apellido}, {nombre}:" +
                $"\n DNI: {documento} - NPxFrecuente: {pasajeroFrecuente}" +
                $"\n Vuelo: {tipoVuelo} con la tarifa {tipoTarifa}";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.grpDatosPax.Visible = false;
            this.lblDatosPax.Text = String.Empty;
            this.txtNombre.Text = String.Empty;
            this.txtApellido.Text = String.Empty;
            this.txtDocumento.Text = String.Empty;
            this.txtPaxFrecuente.Text = String.Empty;
            this.rdbInternacional.Checked = false;
            this.rdbNacional.Checked = false;
            this.cbxTipoTarifa.SelectedText = String.Empty;
        }

        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            String tipoVuelo = String.Empty;
            if (rdbInternacional.Checked)
            {
                tipoVuelo = "I";
            }
            else
            {
                tipoVuelo = "N";
            }
            string tipoTarifa = String.Empty;
            if (cbxTipoTarifa.SelectedItem != null)
            {
                tipoTarifa = cbxTipoTarifa.SelectedItem.ToString();
            }
            if ((tipoTarifa == String.Empty) || (tipoVuelo == String.Empty)) {
                // No tiene que abrir el formulario
                MessageBox.Show("Para cargar el equipaje se requiere el tipo de vuelo y tipo de tarifa.",
                    "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            } else
            {
                FrmEquipaje frmEquipaje = new FrmEquipaje();
                frmEquipaje.configurarFormulario(tipoVuelo, tipoTarifa);
                frmEquipaje.ShowDialog();
            }
            
        }
    }
}
