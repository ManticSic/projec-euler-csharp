using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0003;

[RegisterType]
public class Problem0003
{
    private readonly Primes primes;

    public Problem0003(Primes primes)
    {
        this.primes = primes;
    }

    public IReadOnlyCollection<long> Solve(long value)
    {
        return primes.Factorization(value);
    }
}
