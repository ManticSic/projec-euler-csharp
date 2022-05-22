using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Util;

[RegisterType]
public sealed class IntCollectionEqualityComparer : IEqualityComparer<IEnumerable<int>>
{
    public bool Equals(IEnumerable<int>? item1, IEnumerable<int>? item2)
    {
        if (Object.Equals(item1, item2))
        {
            return true;
        }

        if ((item1 == null) ^ (item2 == null))
        {
            return false;
        }

        int[] item1AsArray = item1!.ToArray();
        int[] item2AsArray = item2!.ToArray();

        if (item1AsArray.Length != item2AsArray.Length)
        {
            return false;
        }

        return !item1AsArray.Where((item, index) => item != item2AsArray[index]).Any();
    }

    public int GetHashCode(IEnumerable<int> obj)
    {
        return obj.Sum(item => item.GetHashCode());
    }
}
