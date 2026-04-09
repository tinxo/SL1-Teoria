// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sistema de Check-in para Aerolineas Argentinas");
Console.WriteLine("Ingrese su nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido:");
string apellido = Console.ReadLine();
Console.WriteLine("Ingrese su número documento / pasaporte:");
string documento = Console.ReadLine();
Console.WriteLine("Ingrese su número pasajero frecuente:");
string pasajeroFrecuente = Console.ReadLine();
Console.WriteLine("¿Se trata de un vuelo nacional o internacional? (N/I):");
string tipoVuelo = Console.ReadLine();
Console.WriteLine("Ingrese el tipo de tarifa contratada (P|B|F|PE):");
string tipoTarifa = Console.ReadLine();
// Numero de vuelo fijo para el ejercicio
string nroVuelo = "AR1766";

// Imprimir
Console.WriteLine("\n--- Detalles del Check-in ---");
Console.WriteLine($"Nombre: {nombre} {apellido}");
Console.WriteLine($"Documento/Pasaporte: {documento}");
Console.WriteLine($"Número Pasajero Frecuente: {pasajeroFrecuente}");
Console.WriteLine($"Tipo de Vuelo: {(tipoVuelo.ToUpper() == "N" ? "Nacional" : "Internacional")}");
Console.WriteLine($"Tipo de Tarifa: {tipoTarifa}");
Console.WriteLine($"Número de Vuelo: {nroVuelo}");

// Pesaje de equipaje
int cantidadItems;
if (tipoTarifa.ToUpper() == "P" || tipoTarifa.ToUpper() == "B")
{
    cantidadItems = 1;
} else if (tipoTarifa.ToUpper() == "F")
{
    cantidadItems = 2;
} else
{
    cantidadItems = 3;
}
Console.WriteLine($"Cantidad de items de equipaje a despachar: {cantidadItems}");
double pesoLimiteNacional = 0.0;
double pesoLimiteInternacional = 0.0;
for (int i = 1; i <= cantidadItems; i++)
{
    Console.WriteLine($"Ingrese el peso total del equipaje (kg) para el item {i}:");
    double pesoEquipaje = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Peso del equipaje para el item {i}: {pesoEquipaje} kg");
    if (i == 1)
    {
        // solo el primer item tiene estas restricciones de peso
        pesoLimiteNacional = 8.0;
        pesoLimiteInternacional = 10.0;
    } else
    {
        // item despachado en bodega, tiene estas restricciones de peso
        pesoLimiteNacional = 15.0;
        pesoLimiteInternacional = 23.0;
    }
    if (tipoVuelo.ToUpper() == "N")
    {
        if (pesoEquipaje > pesoLimiteNacional)
        {
            Console.WriteLine($"El equipaje del item {i} excede el peso permitido para vuelos nacionales.");
        }
    }
    else if (tipoVuelo.ToUpper() == "I")
    {
        if (pesoEquipaje > pesoLimiteInternacional)
        {
            Console.WriteLine($"El equipaje del item {i} excede el peso permitido para vuelos internacionales.");
        }
    }
}


Console.WriteLine("-----------------------------");