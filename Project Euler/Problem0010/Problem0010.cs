using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0010;

[RegisterType]
public class Problem0010
{
    private readonly Primes primes;

    public Problem0010(Primes primes)
    {
        this.primes = primes;
    }

    public long Solve(int border)
    {
        return primes.GetRange(border)
              .Sum();
    }
}
