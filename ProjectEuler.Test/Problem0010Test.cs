using NUnit.Framework;
using Project_Euler.Problem0010;

namespace ProjectEuler.Test;

/*
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * Find the sum of all the primes below two million.
 */

public class Problem0010Test : AbstractProblemTest<Problem0010>
{
    [Test]
    [TestCase(10, 17)]
    [TestCase(2000000, 142913828922)]
    public void Should(int border, long expected)
    {
        // prepare

        // run
        long result = Sut.Solve(border);

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Solve()
    {
        Solve(() => Sut.Solve(2000000));
    }
}
