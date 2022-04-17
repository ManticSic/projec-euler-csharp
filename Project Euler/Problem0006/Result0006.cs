namespace Project_Euler.Problem0006;

public record Result0006(int SumOfSquares, int SquaresOfSum, int Diff)
{
    public override string ToString()
    {
        return $"[Sum of squares: {SumOfSquares}, Square of sum: {SquaresOfSum}, Diff: {Diff}]";
    }
}
