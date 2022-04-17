using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0005;

[RegisterType]
public class Problem0005
{
    public int Solve(int upperBorder)
    {
        List<int> dividers = Enumerable.Range(1, upperBorder)
                                       .ToList();

        int numberToTest = upperBorder;

        while (true)
        {
            if (IsEvenlyDividable(numberToTest, dividers))
            {
                return numberToTest;
            }

            numberToTest += upperBorder;
        }
    }

    private bool IsEvenlyDividable(int value, IEnumerable<int> dividers)
    {
        return dividers.All(divider => value % divider == 0);
    }
}
