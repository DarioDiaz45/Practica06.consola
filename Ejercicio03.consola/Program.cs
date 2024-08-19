const int tamañoArray = 8;
string[] nombres = new string[tamañoArray];

for (int i = 0; i < tamañoArray; i++)
{
    string nombre;
    do
    {
        Console.Write($"Ingrese el nombre {i + 1} (máximo 12 caracteres): ");
        nombre = Console.ReadLine();
        if (string.IsNullOrEmpty(nombre) || nombre.Length > 12)
        {
            Console.WriteLine("El nombre no puede ser nulo y debe tener 12 caracteres o menos. Inténtelo de nuevo.");
        }
    } while (string.IsNullOrEmpty(nombre) || nombre.Length > 12);

    nombres[i] = nombre;
}


Console.Write("Ingrese la letra con la que deben comenzar los nombres (por ejemplo, 'C'): ");
char letra = char.ToUpper(Console.ReadLine()[0]);
Console.WriteLine($"\nNombres que comienzan con '{letra}':");
foreach (string nombre in nombres)
{
    if (nombre[0] == letra)
    {
        Console.WriteLine(nombre);
    }
}


int contadorVocales = 0;
foreach (string nombre in nombres)
{
    if ("AEIOU".IndexOf(char.ToUpper(nombre[0])) >= 0)
    {
        contadorVocales++;
    }
}
Console.WriteLine($"nCantidad de nombres que comienzan con una vocal: {contadorVocales}");


Console.WriteLine("Nombre Cantidad de Caracteres Cantidad de Vocales");
foreach (string nombre in nombres)
{
    int cantidadVocales = ContarVocales(nombre);
    Console.WriteLine($"{nombre} {nombre.Length} {cantidadVocales}");
}
    

    
    static int ContarVocales(string nombre)
{
    int contador = 0;
    foreach (char c in nombre.ToUpper())
    {
        if ("AEIOU".IndexOf(c) >= 0)
        {
            contador++;
        }
    }
    return contador;
}