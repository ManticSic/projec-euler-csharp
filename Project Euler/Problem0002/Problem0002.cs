using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0002;

[RegisterType]
public class Problem0002
{
    private readonly Numbers numbers;

    public Problem0002(Numbers numbers)
    {
        this.numbers = numbers;
    }

    public int Solve(int border)
    {
        return GetFibonacci(border).Where(numbers.IsEven)
                                   .Sum();
    }

    private IList<int> GetFibonacci(int border)
    {
        List<int> fibonacci = new() { 1, 1 };

        while (true)
        {
            int secondLast = fibonacci[fibonacci.Count - 2];
            int last       = fibonacci.Last();

            int value = secondLast + last;

            if (value >= border)
            {
                break;
            }

            fibonacci.Add(value);
        }

        return fibonacci;
    }
}
