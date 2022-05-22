using System.Collections.Generic;
using NUnit.Framework;
using Project_Euler.Util;

namespace ProjectEuler.Test.Util;

public class CartesianProductTest : AbstractTest<CartesianProduct>
{
    [Test]
    public void TestCreate()
    {
        // prepare
        IEnumerable<IEnumerable<int>> itemsToTest = new List<List<int>>
                                                    {
                                                        new() { 1, 2, 3 },
                                                        new() { 1, 2, 3 },
                                                    };

        // run
        IEnumerable<IEnumerable<int>> result = Sut.Create(itemsToTest);

        // verify
        IEnumerable<IEnumerable<int>> expected = new List<IEnumerable<int>>()
        {
            new List<int> {1, 1},
            new List<int> {1, 2},
            new List<int> {1, 3},
            new List<int> {2, 1},
            new List<int> {2, 2},
            new List<int> {2, 3},
            new List<int> {3, 1},
            new List<int> {3, 2},
            new List<int> {3, 3},
        };
        Assert.AreEqual(expected, result);
    }
}
