const int TamañoArray = 10;
int[] numeros = new int[TamañoArray];
Random random = new Random();
for(int i = 0; i < TamañoArray; i++)
{
    numeros[i] = random.Next(1, 101);

}
Console.WriteLine("Número Binario Hexadecimal");
foreach(int numero in numeros)
{
    Console.WriteLine($"{numero} {Convert.ToString(numero, 2).PadLeft(8, '0')} {numero:X}");
}
int mayor = EncontrarMayor(numeros);
int menor = EncontrarMenor(numeros);
Console.WriteLine($"El numero mayor es:{mayor}");
Console.WriteLine($"El numero menor es:{menor}");
Console.WriteLine("Numeros Pares:");
foreach(int numero in numeros)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);

    }
}
Console.WriteLine("Numeros Primos:");
foreach(int numero in numeros)
{
    Console.WriteLine(numero);
}
int EncontrarMayor(int[] array)
{
    int mayor = array[0];
    foreach(int numero in array)
    {
        if (numero > mayor)
        {
            mayor = numero;
        }
    }
    return mayor;
}
int EncontrarMenor(int[] array)
{
    int menor = array[0];
    foreach( int numero in array)
    {
        if (numero < menor)
        {
            menor = numero;
        }
    }
    return menor;
}
bool EsPrimo(int numero)
{
    if (numero <= 1) return false;
    if (numero == 2) return true;
    if (numero % 2 == 0) return false; 

    for (int i = 3; i <= Math.Sqrt(numero); i += 2)
    {
        if (numero % i == 0)
        {
            return false;
        }
    }
    return true;
}


