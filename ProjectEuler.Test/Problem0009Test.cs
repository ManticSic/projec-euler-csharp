using NUnit.Framework;
using Project_Euler.Problem0009;

namespace ProjectEuler.Test;

/*
 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
 * a2 + b2 = c2
 * For example, 32 + 42 = 9 + 16 = 25 = 52.
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc.
 */

public class Problem0009Test : AbstractProblemTest<Problem0009>
{
    [Test]
    [TestCase(31875000)]
    public void Should(long expected)
    {
        // preapre

        // run
        long result = Sut.Solve();

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Solve()
    {
        // prepare

        // run
        Solve(() => Sut.Solve());
    }
}
