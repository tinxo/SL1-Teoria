namespace App_Checkin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
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
            } else
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
            MessageBox.Show($"Datos del pasajero: +" +
                $"\n {apellido}, {nombre}: +" +
                $"\nDNI: {documento} - NPxFrecuente: {pasajeroFrecuente} +" +
                $"\n Vuelo: {tipoVuelo} con la tarifa {tipoTarifa}");
        }
    }
}
