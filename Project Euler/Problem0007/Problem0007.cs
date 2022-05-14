using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0007;

[RegisterType]
public class Problem0007
{
    private readonly Primes primes;

    public Problem0007(Primes primes)
    {
        this.primes = primes;
    }

    public long Solve(int position)
    {
        return primes.GetPrimeByIndex(position -1);
    }
}
