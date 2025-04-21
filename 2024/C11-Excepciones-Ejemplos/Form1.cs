namespace C11_Excepciones_Ejemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double divisionControlada(double x, double y)
        {
            if (y == 0)
            {
                // Se lanza un tipo específico de excepción
                throw new DivideByZeroException();
            }
            return x / y;
        }

        private void btnEjemplo1_Click(object sender, EventArgs e)
        {
            // Se definen los valores de entrada para probar
            double a = (double)nupValorA.Value;
            double b = (double)nupValorB.Value;
            double resultado;

            // Se usa un bloque try-catch para verificar 
            // si se genera una excepción en la división
            try
            {
                resultado = divisionControlada(a, b);
                MessageBox.Show($"Operación: {a} / {b} = {resultado}",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (DivideByZeroException) // Se puede colocar un tipo específico
            {
                MessageBox.Show("Se intentó una división por cero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        int getValorEnIndice(int[] coleccion, int posicion)
        {
            try
            {
                return coleccion[posicion];
            }
            catch (IndexOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException(
                    "El parámetro de índice esta fuera de rango.", e);
            }
        }

        private void btnEjemplo2_Click(object sender, EventArgs e)
        {
            int[] valores = { 9, 3, 5, 6, 7, 0 };
            int indice = (int)nupPosicion.Value;
            Exception excepcion = null;
            try
            {
                int resultado = getValorEnIndice(valores, indice);
                MessageBox.Show($"Valor en la posición: {indice} = {resultado}",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Se controla el error y se muestra el mensaje
                MessageBox.Show($"Hubo un error. {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                excepcion = ex;
            }
            finally
            {
                // Este bloque se ejecuta con o sin errores
                if (excepcion == null)
                {
                    MessageBox.Show("Ejecución finalizada correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ejecución finalizada con errores.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}