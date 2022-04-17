using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0006;

[RegisterType]
public class Problem0006
{
    public Result0006 Solve(int upperBorder)
    {
        List<int> numbers = Enumerable.Range(1, upperBorder)
                                      .ToList();

        int sumOfSquares = GetSumOfSquares(numbers);
        int squareOfSum  = GetSquareOfSum(numbers);

        int result = squareOfSum - sumOfSquares;

        return new Result0006(sumOfSquares, squareOfSum, result);
    }

    private int GetSumOfSquares(IEnumerable<int> numbers)
    {
        return (int)numbers.Select(number => Math.Pow(number, 2))
                           .Sum();
    }

    private int GetSquareOfSum(IEnumerable<int> numbers)
    {
        int sum = numbers.Sum();
        return (int)Math.Pow(sum, 2);
    }
}
