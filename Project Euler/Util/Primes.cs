using System.Text.Json;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Util;

[RegisterType]
public class Primes
{
    private readonly Lazy<IDictionary<string, long>> primesAsDictionaryLazy;
    private readonly Lazy<List<long>>                primesAsCollectionLazy;

    public Primes()
    {
        primesAsDictionaryLazy = new Lazy<IDictionary<string, long>>(LoadFromAssets);
        primesAsCollectionLazy = new Lazy<List<long>>(ProcessAsCollection);
    }

    public IReadOnlyList<long> Values => primesAsCollectionLazy.Value.AsReadOnly();

    public bool IsPrime(long value)
    {
        return primesAsCollectionLazy.Value.Contains(value);
    }

    public IReadOnlyCollection<long> Factorization(long value)
    {
        int primeStartingIndex = 0;

        return FactorizationInternal(value, primeStartingIndex)
            .ToList()
            .AsReadOnly();
    }

    private IEnumerable<long> FactorizationInternal(long value, int primeStartingIndex)
    {
        if (IsPrime(value))
        {
            return new List<long> { value }.AsReadOnly();
        }

        int lowestPrimeFactorIndex = FindLowestPrimeFactorIndex(value, primeStartingIndex);

        long primeValue = Values[lowestPrimeFactorIndex];

        long newValue = value / primeValue;

        IEnumerable<long> subResults = FactorizationInternal(newValue, lowestPrimeFactorIndex);

        return subResults.Prepend(primeValue);
    }

    private int FindLowestPrimeFactorIndex(long value, int startingIndex)
    {
        for (int primeIndex = startingIndex; ; primeIndex++)
        {
            if (value % Values[primeIndex] == 0)
            {
                return primeIndex;
            }
        }
    }

    private IDictionary<string, long> LoadFromAssets()
    {
        string foobar    = File.ReadAllText("./Assets/primes.json");

        Dictionary<string, long>? allPrimes = JsonSerializer.Deserialize<Dictionary<string, long>>(foobar);

        if (allPrimes is null)
        {
            throw new InvalidOperationException("Something went wrong while loading primes.");
        }

        return allPrimes;
    }

    private List<long> ProcessAsCollection()
    {
        return primesAsDictionaryLazy.Value
                                     .Select(kv => kv.Value)
                                     .ToList();
    }
}
