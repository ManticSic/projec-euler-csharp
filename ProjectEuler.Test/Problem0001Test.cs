using NUnit.Framework;
using Project_Euler.Problem0001;

namespace ProjectEuler.Test;

/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 *
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

public class Problem0001Test : AbstractProblemTest<Problem0001>
{
    [Test]
    [TestCase(new[] { 3, 5 }, 10, 23)]
    [TestCase(new[] { 3, 5 }, 1000, 233168)]
    public void Should(int[] multiples, int border, int expected)
    {
        // prepare

        // run
        int result = Sut.Solve(multiples, border);

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(new[] { 3, 5 }, 1000)]
    public void Solve(int[] multiples, int border)
    {
        // prepare

        // run
        Solve(() => Sut.Solve(multiples, border));
    }
}
