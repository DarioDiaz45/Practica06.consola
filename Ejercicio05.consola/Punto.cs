struct Punto
{
    public double X { get; set; }
    public double Y { get; set; }

    public Punto(double x, double y)
    {
        X = x;
        Y = y;
    }

    
    public double DistanciaAlOrigen()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

    public int Cuadrante()
    {
        if (X > 0 && Y > 0) return 1;
        if (X < 0 && Y > 0) return 2;
        if (X < 0 && Y < 0) return 3;
        if (X > 0 && Y < 0) return 4;
        return 0; 
    }

    
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}