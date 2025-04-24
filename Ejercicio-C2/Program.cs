// See https://aka.ms/new-console-template for more information

void validarNota(double nota)
{
    if (nota >= 6) // mejorar límites superior e inferior
    {
        Console.WriteLine("Examen aprobado.");
    }
    else
    {
        Console.WriteLine("Examen desaprobado");
    }
    return;
}

Console.WriteLine("Inicio del programa.");

// Definición de variables
string nombrePersona = "Bart Simpson";
string nroDocumento = "88765432";
int anioIngreso = 2024;
int cantidadAprobadas = 6;
double promedioSA = 8.55;

// Imprimo los valores
Console.WriteLine($"Nombre: {nombrePersona}");
Console.WriteLine($"Nro. de Documento: {nroDocumento}");
Console.WriteLine($"Ingreso en {anioIngreso}, aprobó {cantidadAprobadas} materias y tiene un promedio (sin aplazos) de {promedioSA}");

// Evaluación de la calificación de un examen

string respuesta;
Console.WriteLine($"Ingrese la nota de un examen para {nombrePersona}:");
respuesta = Console.ReadLine(); // ajustar qué pasa si es null

double nota; //= Convert.ToDouble();
if (double.TryParse(respuesta, out nota))
{
    validarNota(nota);
}

