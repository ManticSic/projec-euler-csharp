using NUnit.Framework;
using Project_Euler.Problem0005;

namespace ProjectEuler.Test;

/*
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 *
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */

public class Problem0005Test : AbstractProblemTest<Problem0005>
{
    [Test]
    [TestCase(10, 2520)]
    [TestCase(20, 232792560)]
    public void Should(int upperBorder, int expected)
    {
        // prepare

        // run
        int result = Sut.Solve(upperBorder);

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(20)]
    public void Solve(int upperBorder)
    {
        // prepare

        // run
        Solve(() => Sut.Solve(upperBorder));
    }
}
