const int tamañoArray = 10;
double[] velocidadesKmh = new double[tamañoArray];
double[] velocidadesMph = new double[tamañoArray];
double sumaVelocidades = 0;

Console.WriteLine("Ingrese las velocidades en km/h (entre 100 y 300 km/h):");


for (int i = 0; i < tamañoArray; i++)
{
    double velocidad;
    do
    {
        Console.Write($"Velocidad {i + 1}: ");
        velocidad = double.Parse(Console.ReadLine());
        if (velocidad < 100 || velocidad > 300)
        {
            Console.WriteLine("La velocidad debe estar entre 100 y 300 km/h. Inténtelo de nuevo.");
        }
    } while (velocidad < 100 || velocidad > 300);

    velocidadesKmh[i] = velocidad;
    velocidadesMph[i] = ConvertirAMillasPorHora(velocidad);
    sumaVelocidades += velocidad;
}


double velocidadMedia = sumaVelocidades / tamañoArray;


double mayorVelocidad = EncontrarMayor(velocidadesKmh);
double menorVelocidad = EncontrarMenor(velocidadesKmh);


Console.WriteLine("\nListado de velocidades:");
Console.WriteLine("Velocidad (km/h)\tVelocidad (mph)");

foreach (double velocidadKmh in velocidadesKmh)
{
    double velocidadMph = ConvertirAMillasPorHora(velocidadKmh);
    string marcaAsterisco = velocidadKmh > velocidadMedia ? "*" : "";
    Console.WriteLine($"{velocidadKmh}\t\t\t{velocidadMph:F2} {marcaAsterisco}");
}


Console.WriteLine($"\nLa mayor velocidad es: {mayorVelocidad} km/h");
Console.WriteLine($"La menor velocidad es: {menorVelocidad} km/h");
Console.WriteLine($"La velocidad media es: {velocidadMedia:F2} km/h");


int countInferiorPromedio = 0;
foreach (double velocidad in velocidadesKmh)
{
    if (velocidad < velocidadMedia)
    {
        countInferiorPromedio++;
    }
}
Console.WriteLine($"Cantidad de velocidades inferiores al promedio: {countInferiorPromedio}");
    

    
    static double ConvertirAMillasPorHora(double kmh)
{
    return kmh * 0.621371;
}


static double EncontrarMayor(double[] array)
{
    double mayor = array[0];
    foreach (double numero in array)
    {
        if (numero > mayor)
        {
            mayor = numero;
        }
    }
    return mayor;
}


static double EncontrarMenor(double[] array)
{
    double menor = array[0];
    foreach (double numero in array)
    {
        if (numero < menor)
        {
            menor = numero;
        }
    }
    return menor;
}

