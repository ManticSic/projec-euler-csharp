using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0004;

[RegisterType]
public class Problem0004
{
    public Result0004 Solve(int digits)
    {
        int min   = (int)Math.Pow(10, digits - 1);
        int max   = (int)Math.Pow(10, digits);
        int count = max - min;

        int[] numbers = Enumerable.Range(min, count).ToArray();

        Result0004? result = CartesianProduct.Create(numbers, numbers)
                                             .Distinct(CustomTupleIEqualityComparer.Instance)
                                             .Select(tuple => new Result0004(new[] { tuple.Item1, tuple.Item2 }))
                                             .Where(possibleResult => IsPalindrome(possibleResult.Product))
                                             .MaxBy(possibleResult => possibleResult.Product);

        return result ?? throw new InvalidOperationException("Failed to find a result");
    }

    private bool IsPalindrome(int number)
    {
        return number == ReverseNumber(number);
    }

    private int ReverseNumber(int number)
    {
        int reverse = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number  = number / 10;
        }

        return reverse;
    }

    private class CustomTupleIEqualityComparer : IEqualityComparer<(int, int)>
    {
        public static readonly IEqualityComparer<(int, int)> Instance = new CustomTupleIEqualityComparer();

        public bool Equals((int, int) x, (int, int) y)
        {
            if (x.Item1 == y.Item1 && x.Item2 == y.Item2)
            {
                return true;
            }
            else if (x.Item1 == y.Item2 && x.Item2 == y.Item1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode((int, int) obj)
        {
            if (obj.Item1 < obj.Item2)
            {
                return HashCode.Combine(obj.Item1, obj.Item2);
            }
            else
            {
                return HashCode.Combine(obj.Item2, obj.Item1);
            }
        }
    }
}
