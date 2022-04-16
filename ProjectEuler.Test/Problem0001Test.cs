using NLog;
using NUnit.Framework;
using Project_Euler.Problem0001;

namespace ProjectEuler.Test;

/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 *
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

public class Problem0001Test
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    [Test]
    [TestCase(new[] { 3, 5 }, 10, 23)]
    [TestCase(new[] { 3, 5 }, 1000, 233168)]
    public void Should(int[] multiples, int border, int expected)
    {
        // prepare
        Problem0001 sut = Scope.Resolve<Problem0001>();

        // run
        int result = sut.Solve(multiples, border);

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(new[] { 3, 5 }, 1000)]
    public void Solve(int[] multiples, int border)
    {
        // prepare
        Problem0001 sut = Scope.Resolve<Problem0001>();

        // run
        int result = sut.Solve(multiples, border);

        Logger.Info("################");
        Logger.Info("# Problem was solved");
        Logger.Info($"# Result: {result}");
        Logger.Info("################");
    }
}
