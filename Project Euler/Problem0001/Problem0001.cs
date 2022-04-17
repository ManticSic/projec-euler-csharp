using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0001;

[RegisterType]
public class Problem0001
{
    private readonly Numbers numbers;

    public Problem0001(Numbers numbers)
    {
        this.numbers = numbers;
    }

    public int Solve(IReadOnlyList<int> multiples, int border)
    {
        return Enumerable.Range(1, border - 1)
                         .Where(value => IsMultiple(multiples, value))
                         .Aggregate(0, (total, next) => total + next);
    }

    private bool IsMultiple(IReadOnlyList<int> multiples, int value)
    {
        return multiples.Any(multiple => numbers.IsMultipleOf(multiple, value));
    }
}
