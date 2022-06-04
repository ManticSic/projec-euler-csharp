namespace Project_Euler.Problem0014;

public record Result0014
{
    public Result0014(IList<long> chain)
    {
        Count = chain.Count;
        Chain = chain.ToList();
    }

    public IReadOnlyList<long> Chain { get; }

    public int Count { get; }

    public override string ToString()
    {
        return $"[Count: {Count}, Chain: {String.Join(',', Chain)}]";
    }
}
