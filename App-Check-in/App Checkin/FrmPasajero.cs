using App_Checkin.Modelos;

namespace App_Checkin
{
    public partial class FrmPasajero : Form
    {
        // TODO: mover acá las variables
        Pasajero unPax;
        Pasaje ticket;

        public FrmPasajero()
        {
            InitializeComponent();
        }

        private void evetoClickBtnProcesar(object sender, EventArgs e)
        {
            if ((txtNombre.Text == String.Empty) || 
                (txtApellido.Text == String.Empty) ||
                (txtDocumento.Text == String.Empty))
            {
                MessageBox.Show("Los campos del formulario no pueden estar vacíos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // TODO: falta algo de feedback visual para indicar qué campo tiene problemas
                return;
            }
            
            // Se obtienen los datos del pasajero
            unPax = new Pasajero(
                txtNombre.Text,
                txtApellido.Text,
                txtDocumento.Text,
                txtPaxFrecuente.Text
            );
            // Usamos la clase Pasajeros para guardar los datos

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
            // TODO: Agregar verificación para que sí o sí uno tenga que estar seleccionado
            if (cbxTipoTarifa.SelectedItem != null)
            {
                tipoTarifa = cbxTipoTarifa.SelectedItem.ToString();
            }
            string nroVuelo = "AR1766";
            ticket = new Pasaje(tipoVuelo, tipoTarifa, nroVuelo);

            // Informar datos cargados
            /*MessageBox.Show($"Datos del pasajero: +" +
                $"\n {apellido}, {nombre}: +" +
                $"\nDNI: {documento} - NPxFrecuente: {pasajeroFrecuente} +" +
                $"\n Vuelo: {tipoVuelo} con la tarifa {tipoTarifa}");
            */
            // Se pasa a visible el área para mostrar los resultados
            this.grpDatosPax.Visible = true;
            // Se cargan los resultados (datos del pasajero)
            this.lblDatosPax.Text = $"{unPax.Apellido}, {unPax.Nombre}:" +
                $"\n DNI: {unPax.Documento} - NPxFrecuente: {unPax.PasajeroFrecuente}" +
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
            /**
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
            }**/
            if ((ticket.TipoTarifa == String.Empty) || (ticket.TipoVuelo == String.Empty)) {
                // No tiene que abrir el formulario
                MessageBox.Show("Para cargar el equipaje se requiere el tipo de vuelo y tipo de tarifa.",
                    "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            } else
            {
                FrmEquipaje frmEquipaje = new FrmEquipaje();
                frmEquipaje.configurarFormulario(ticket);
                frmEquipaje.ShowDialog();
            }
            
        }
    }
}
