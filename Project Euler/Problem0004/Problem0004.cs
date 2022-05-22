using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0004;

[RegisterType]
public class Problem0004
{
    private readonly CartesianProduct cartesianProduct;

    public Problem0004(CartesianProduct cartesianProduct)
    {
        this.cartesianProduct = cartesianProduct;
    }

    public Result0004 Solve(int digits)
    {
        int min   = (int)Math.Pow(10, digits - 1);
        int max   = (int)Math.Pow(10, digits);
        int count = max - min;

        List<int> numbers = Enumerable.Range(min, count).ToList();

        Result0004? result = cartesianProduct.Create(new IEnumerable<int>[] { numbers, numbers })
                                             .Select(result => new Result0004(result))
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
}
