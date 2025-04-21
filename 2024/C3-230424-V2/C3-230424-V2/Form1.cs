using Microsoft.VisualBasic;

namespace C3_230424_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Declaración de variables
            string nombrePersona = this.txtNombreApellido.Text;
            string nroDocumento = this.txtDocumento.Text;
            // Un nupdown trae por defecto un valor decimal
            int anioIngreso = (int)this.nupAnioIngreso.Value;
            int cantidadMateriasAprobadas = (int)this.nupMateriasAprobadas.Value;
            double promedioSA = (double)this.nupPromedio.Value;
            // Genero una variable con los resultados
            string resultado = $"Estudiante {nombrePersona}, DNI: {nroDocumento} \n Año de ingreso: {anioIngreso} - Materias aprobadas: {cantidadMateriasAprobadas} \n Promedio sin aplazos: {promedioSA}";
            // "Imprimo" los resultados a la label correspondiente
            this.lblResultados.Text = resultado;
            // Ahora habilitamos que verifique notas
            this.grpNotas.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hacemos esto para que cunado carga el Frm se coloque vacia
            this.lblResultados.Text = "";
        }

        void validarNota(double notaIngresada)
        {
            // Valor ok
            if (notaIngresada >= 6)
            {
                MessageBox.Show($"La persona aprobó el examen con nota: {notaIngresada}");
            }
            else
            {
                MessageBox.Show($"La persona no aprobó el examen");
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double notaIngresada = (double)this.nupNota.Value;
            validarNota(notaIngresada);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
