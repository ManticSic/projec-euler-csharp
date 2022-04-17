namespace Project_Euler.Problem0004;

public record Result0004
{
    public Result0004(int[] factors)
    {
        Factors = factors;
        product = new Lazy<int>(CalculateProduct);
    }

    private Lazy<int> product;

    public int[] Factors { get; }
    public int   Product => product.Value;

    private int CalculateProduct()
    {
        return Factors.Aggregate((result, nextFactor) => result * nextFactor);
    }

    public override string ToString()
    {
        return $"[Factors: {String.Join(",", Factors)}, Product: {Product}]";
    }
}
