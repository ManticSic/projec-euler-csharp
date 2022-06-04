using Unity.Lifetime;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Util;

[RegisterType(lifetimeManager: typeof(SingletonLifetimeManager))]
public class Numbers
{
    public bool IsMultipleOf(int multiple, int value)
    {
        return value % multiple == 0;
    }

    public bool IsEven(int value)
    {
        return IsEven((long)value);
    }

    public bool IsEven(long value)
    {
        return value % 2 == 0;
    }
}
