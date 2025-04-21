namespace C3_22042024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaración de variables
            string nombrePersona = this.txtNombreApellido.Text;
            //string nroDocumento = "77822943";
            //int anioIngreso = 2023;
            //int cantidadMateriasAprobadas = 3;
            //double promedioSA = 8.25;
            this.lblResultado.Text = nombrePersona;
        }
    }
}