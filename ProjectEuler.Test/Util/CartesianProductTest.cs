using System.Linq;
using NUnit.Framework;
using Project_Euler.Util;

namespace ProjectEuler.Test.Util;

public class CartesianProductTest : AbstractTest<CartesianProduct>
{
    [Test]
    public void TestCreate_SameArray()
    {
        // prepare

        // run
        (int, int)[] result = Sut.Create(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }).ToArray();

        // verify
        (int, int)[] expected =
        {
            (1, 1),
            (1, 2),
            (1, 3),
            (2, 1),
            (2, 2),
            (2, 3),
            (3, 1),
            (3, 2),
            (3, 3),
        };
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestCreate_DifferentArrays()
    {
        // prepare

        // run
        (int, int)[] result = Sut.Create(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }).ToArray();

        // verify
        (int, int)[] expected =
        {
            (1, 4),
            (1, 5),
            (1, 6),
            (2, 4),
            (2, 5),
            (2, 6),
            (3, 4),
            (3, 5),
            (3, 6),
        };
        Assert.AreEqual(expected, result);
    }
}
