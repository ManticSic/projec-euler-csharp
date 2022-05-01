namespace Project_Euler.Problem0004;

public record Result0004
{
    private readonly Lazy<int> product;

    public Result0004(IEnumerable<int> factors)
    {
        Factors = factors.ToArray();
        product = new Lazy<int>(CalculateProduct);
    }

    public int[] Factors { get; }
    public int   Product => product.Value;

    public override string ToString()
    {
        return $"[Factors: {String.Join(",", Factors)}, Product: {Product}]";
    }

    private int CalculateProduct()
    {
        return Factors.Aggregate((result, nextFactor) => result * nextFactor);
    }
}
