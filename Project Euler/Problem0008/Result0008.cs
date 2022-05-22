namespace Project_Euler.Problem0008;

public record Result0008(int Count, ICollection<int> Order, long Product)
{
    public override string ToString()
    {
        return $"[Count: {Count}, Order: {String.Join(',', Order)}, Product: {Product}]";
    }
}
