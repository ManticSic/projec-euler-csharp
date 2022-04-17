using System.Linq;
using NUnit.Framework;
using Project_Euler.Problem0004;

namespace ProjectEuler.Test;

/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 *
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

public class Problem0004Test : AbstractProblemTest<Problem0004>
{
    [Test]
    [TestCase(2, new[] { 91, 99 })]
    [TestCase(3, new[] { 913, 993 })]
    public void Should(int digits, int[] expected)
    {
        // prepare

        // run
        Result0004 result = Sut.Solve(digits);

        // verify
        Assert.AreEqual(expected, result.Factors);
    }

    [Test]
    [TestCase(3)]
    public void Solve(int digits)
    {
        // prepare

        // run
        Solve(() => Sut.Solve(digits));
    }
}
