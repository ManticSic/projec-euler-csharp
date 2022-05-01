using Unity.Lifetime;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Util;

[RegisterType(lifetimeManager: typeof(SingletonLifetimeManager))]
public class CartesianProduct
{
    public IEnumerable<(T1, T2)> Create<T1, T2>(IEnumerable<T1> set1, IEnumerable<T2> set2)
    {
        return set1.SelectMany(item1 => set2, (item1, item2) => (item1, item2))
                   .ToList();
    }
}
