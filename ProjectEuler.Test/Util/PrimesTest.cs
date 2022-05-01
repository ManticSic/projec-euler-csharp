using System.Linq;
using NUnit.Framework;
using Project_Euler.Util;

namespace ProjectEuler.Test.Util;

public class PrimesTest : AbstractTest<Primes>
{
    [Test]
    [TestCase(0, false)]
    [TestCase(1, false)]
    [TestCase(2, true)]
    [TestCase(3, true)]
    [TestCase(15485863, true)]
    public void TestIsPrime(long value, bool expected)
    {
        // prepare

        // run
        bool result = Sut.IsPrime(value);

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(100, new long[] {2,2,5,5})]
    [TestCase(13, new long[] {13})]
    [TestCase(9463851, new long[] {3,3,3,409,857})]
    public void TestFactorization(long value, long[] expected)
    {
        // prepare

        // run
        long[] result = Sut.Factorization(value).ToArray();

        // verify
        Assert.AreEqual(expected, result);
    }
}
