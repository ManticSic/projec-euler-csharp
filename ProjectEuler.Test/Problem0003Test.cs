using System.Linq;
using NUnit.Framework;
using Project_Euler.Problem0003;

namespace ProjectEuler.Test;

/*
 * The prime factors of 13195 are 5, 7, 13 and 29.
 *
 * What is the largest prime factor of the number 600851475143 ?
 */

public class Problem0003Test : AbstractProblemTest<Problem0003>
{
    [Test]
    [TestCase(13195, new[] { 5, 7, 13, 29 })]
    [TestCase(600851475143, new[] { 71, 839, 1471, 6857 })]
    public void Should(long value, int[] expected)
    {
        // prepare

        // run
        long[] result = Sut.Solve(value).ToArray();

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(600851475143)]
    public void Solve(long value)
    {
        // prepare

        // run
        Solve(() => Sut.Solve(value).ToArray());
    }
}
