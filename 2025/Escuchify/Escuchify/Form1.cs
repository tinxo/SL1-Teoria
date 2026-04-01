using Escuchify.Modelos;

namespace Escuchify
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // se toman los datos cargados en la UI
            string nombreCompleto = txtNombreCompleto.Text;
            string nombreArtistico = txtNombreArtistico.Text;
            int anioInicio = (int)nupAnioInicio.Value;
            string nacionalidad = String.Empty;
            if (cbxNacionalidad.SelectedItem.ToString() != String.Empty)
            {
                nacionalidad = cbxNacionalidad.SelectedItem.ToString();
            }
            string discografica = String.Empty;
            if (cbxDiscografica.SelectedText.ToString() != String.Empty)
            {
                discografica = cbxDiscografica.SelectedItem.ToString();
            }
            // instanciar un objeto de la clase Artista
            Artista unArtista = new Artista(nombreCompleto, nombreArtistico);
            unArtista.setAnioInicio(anioInicio);
            unArtista.Nacionalidad = nacionalidad;
            unArtista.Discografica = discografica;
        }
    }
}
