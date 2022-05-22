using System.Collections.Generic;
using NUnit.Framework;
using Project_Euler.Util;

namespace ProjectEuler.Test.Util;

public class IntCollectionEqualityComparerTest : AbstractTest<IntCollectionEqualityComparer>
{
    [Test]
    [TestCase(null, null, true)]
    [TestCase(null, new [] {1, 2, 3}, false)]
    [TestCase(new [] {1, 2, 3}, null, false)]
    [TestCase(new [] {1, 2, 3}, new [] {1, 2, 3}, true)]
    [TestCase(new [] {3, 2, 1}, new [] {1, 2, 3}, false)]
    [TestCase(new [] {1, 2, 3}, new [] {1, 2, 3, 4}, false)]
    [TestCase(new [] {1, 2, 3, 4}, new [] {1, 2, 3}, false)]
    public void TestEquals(IEnumerable<int>? item1, IEnumerable<int>? item2, bool expected)
    {
        // prepare

        // run
        bool result = Sut.Equals(item1, item2);

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestEqualsSameObject()
    {
        // prepare
        IEnumerable<int> item = new[] { 1 };

        // run
        bool result = Sut.Equals(item, item);

        // verify
        Assert.IsTrue(result);
    }

    [Test]
    [TestCase(new [] {1}, 1)]
    [TestCase(new [] {1,2}, 3)]
    [TestCase(new [] {1,2,10}, 13)]
    public void TestGetHashCode(IEnumerable<int> item, int expected)
    {
        // prepare

        // run
        int hashCode = Sut.GetHashCode(item);

        // verify
        Assert.AreEqual(expected, hashCode);
    }
}
