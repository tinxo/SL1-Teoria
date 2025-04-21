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
            // Declarar variables
            double notaParcial1 = (double)this.nupParcial1.Value;
            double notaParcial2 = (double)this.nupParcial2.Value;
            double notaRecuperatorio1 = (double)this.nupRecuperatorio1.Value;
            double notaRecuperatorio2 = (double)this.nupRecuperatorio2.Value;

            bool asistencia = this.chkAsistencia.Checked;
            bool practicos = this.chkPracticos.Checked;

            double promedio = 0;
            if ((notaParcial1 >= 6) & (notaParcial2 >= 6))
            {
                // Aprobó con los parciales
                promedio = (notaParcial1 + notaParcial2) / 2;
            } else
            {
                if (!(notaParcial1 >= 6) & !(notaParcial2 >= 6))
                {
                    // Cuentan los dos recuperatorios
                    promedio = (notaRecuperatorio1 + notaRecuperatorio2) / 2;
                } else
                {
                    // Tengo que buscar qué recuperatorio corresponde
                    if (notaParcial1 < 6) {
                        // Va parcial 2 y recuperatorio 1
                        promedio = (notaRecuperatorio1 + notaParcial2) / 2;
                    } else
                    {
                        // Va parcial 1 y recuperatorio 2
                        promedio = (notaParcial1 + notaRecuperatorio2) / 2;
                    }
                }
            }
            
            if ((promedio >= 6) & (promedio < 7) & asistencia) 
            {
                // Regular
                MessageBox.Show("Regular");
            } else
            {
                if ((promedio >= 7) & asistencia & practicos) 
                {
                    // Promociona
                    MessageBox.Show("Promociona");
                }
                else 
                {
                    // Libre
                    MessageBox.Show("Libre");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hacemos esto para que cunado carga el Frm se coloque vacia
            //this.lblResultados.Text = "";
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
            double notaIngresada = (double)this.nupParcial1.Value;
            validarNota(notaIngresada);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
