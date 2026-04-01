namespace Ejercicio_C2_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerPersona_Click(object sender, EventArgs e)
        {
            // Definición de variables
            string nombrePersona = txtNombre.Text;
            //string nroDocumento = "88765432";
            int anioIngreso = (int)numericUpDown1.Value;
            //int cantidadAprobadas = 6;
            //double promedioSA = 8.55;

            MessageBox.Show($"La persona {nombrePersona} ingreso en {anioIngreso}");

            // Imprimo los valores
            /*lblPersona.Text = $"Nombre: {nombrePersona} \n" +
                $"Nro. de Documento: {nroDocumento} \n " +
                $"Ingreso en {anioIngreso}, \n aprobó {cantidadAprobadas} materias \n" +
                $"y tiene un promedio (sin aplazos) de {promedioSA}";
            */
        }
    }
}
