namespace Project_Euler.Problem0009;

public struct PythagoreanTriplet
{
#pragma warning disable AV1706
    public double A { get; }
    public double B { get; }
    public double C { get; }
#pragma warning restore AV1706

    public double ASquare { get; }
    public double BSquare { get; }
    public double CSquare { get; }

    public double Sum { get; }

    public double Product { get; }

#pragma warning disable AV1706
    public PythagoreanTriplet(double a, double b)
#pragma warning restore AV1706
    {
        A = a;
        B = b;

        ASquare = A * A;
        BSquare = B * B;
        CSquare = ASquare + BSquare;

        C = Math.Sqrt(CSquare);

        Sum     = A + B + C;
        Product = A * B * C;
    }
}
