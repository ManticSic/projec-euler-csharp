using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0008;

[RegisterType]
public class Problem0008
{
    private readonly Lazy<string> lazyDigitAsString;

    public Problem0008()
    {
        lazyDigitAsString = new Lazy<string>(ReadDigit);
    }

    public Result0008? Solve(int count)
    {
        return SolveRecursive(count, 0, null);
    }

    private Result0008? SolveRecursive(int count, int startingIndex, Result0008? largestResult)
    {
        ICollection<int> digits = GetDigits(startingIndex, count);

        if (digits.Count < count)
        {
            return largestResult;
        }

        // if (digits.Any(digit => digit == 0))
        // {
            // return SolveRecursive(count, ++startingIndex, largestResult);
        // }

        Result0008 possibleResult = CreateResult(count, digits);

        if (largestResult == null || possibleResult.Product > largestResult.Product)
        {
            return SolveRecursive(count, ++startingIndex, possibleResult);
        }

        return SolveRecursive(count, ++startingIndex, largestResult);
    }

    private Result0008 CreateResult(int count, ICollection<int> digits)
    {
        long product = 1;
        foreach (long digit in digits)
        {
            product *= digit;
        }
        // long product = digits.Aggregate((current, next) => current * next);

        return new Result0008(count, digits, product);
    }

    private ICollection<int> GetDigits(int startingIndex, int count)
    {
        List<int> digits    = new();
        string    longDigit = lazyDigitAsString.Value;
        int       maxIndex  = longDigit.Length - 1;

        for (int iteration = 0; iteration < count; iteration++)
        {
            int currentIndex = iteration + startingIndex;

            if (currentIndex + count > maxIndex)
            {
                break;
            }

            string singleDigitAsString = longDigit[currentIndex].ToString();
            int  singleDigit         = Convert.ToInt32(singleDigitAsString);
            digits.Add(singleDigit);
        }

        return digits;
    }

    private string ReadDigit()
    {
        string[] lines = File.ReadAllLines("./Assets/0008/p008_1000digit.txt");
        return String.Join("", lines);
    }
}
