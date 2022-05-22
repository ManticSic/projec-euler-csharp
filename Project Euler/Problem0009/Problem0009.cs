using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0009;

[RegisterType]
public class Problem0009
{
    private readonly CartesianProduct cartesianProduct;

    public Problem0009(CartesianProduct cartesianProduct)
    {
        this.cartesianProduct = cartesianProduct;
    }

#pragma warning disable AV1500
    public long Solve()
#pragma warning restore AV1500
    {
        List<int> estimatedRange = Enumerable.Range(1, 1000)
                                             .ToList();

        IEnumerable<IEnumerable<int>> pythagoreanNumbers = new List<List<int>> { estimatedRange, estimatedRange };

        List<PythagoreanTriplet> foo = cartesianProduct.Create(pythagoreanNumbers)
                                                       .Select(cartesian =>
                                                               {
                                                                   double itemA = cartesian.First();
                                                                   double itemB = cartesian.Last();
                                                                   return new PythagoreanTriplet(itemA, itemB);
                                                               })
                                                       .ToList();

        PythagoreanTriplet result = foo.Find(triplet => Math.Abs(triplet.Sum - 1000) < 0.001);

        return Convert.ToInt64(result.Product);
    }
}
