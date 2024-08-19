const int tamañoArray = 20;
Punto[] puntos = new Punto[tamañoArray];
Random rand = new Random();


for (int i = 0; i < tamañoArray; i++)
{
    puntos[i] = new Punto(rand.NextDouble() * 200 - 100, rand.NextDouble() * 200 - 100);
}


Console.WriteLine("Puntos y su distancia al origen:");
for (int i = 0; i < tamañoArray; i++)
{
    Console.WriteLine($"Punto {i + 1}: {puntos[i]} - Distancia al origen: {puntos[i].DistanciaAlOrigen():F2}");
}


Console.WriteLine("Filtrar puntos por cuadrante:");
for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"Cuadrante {i}:");
    foreach (Punto punto in puntos)
    {
        if (punto.Cuadrante() == i)
        {
            Console.WriteLine(punto);
        }
    }
}


Console.WriteLine("Distancias entre puntos:");
for (int i = 0; i < tamañoArray - 1; i++)
{
    double distancia = CalcularDistancia(puntos[i], puntos[i + 1]);
    Console.WriteLine($"Distancia entre Punto {i + 1} y Punto {i + 2}: {distancia:F2}");
}


Console.Write("Ingrese el índice del punto que desea modificar (1 a 20): ");
int indice = int.Parse(Console.ReadLine()) - 1;

if (indice >= 0 && indice < tamañoArray)
{
    Console.Write("Ingrese la nueva coordenada X: ");
    double nuevaX = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la nueva coordenada Y: ");
    double nuevaY = double.Parse(Console.ReadLine());

    puntos[indice] = new Punto(nuevaX, nuevaY);
    Console.WriteLine($"Punto {indice + 1} modificado a: {puntos[indice]}");
}
else
{
    Console.WriteLine("Índice fuera de rango!!!");
}
    

    
    static double CalcularDistancia(Punto p1, Punto p2)
{
    return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
}

