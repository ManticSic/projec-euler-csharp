using System;
using System.Linq;
using NLog;
using NUnit.Framework;
using Project_Euler.Problem0003;

namespace ProjectEuler.Test;

public class Problem0003Test
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    [Test]
    [TestCase(13195, new[] { 5, 7, 13, 29 })]
    [TestCase(600851475143, new[] { 71, 839, 1471, 6857 })]
    public void Should(long value, int[] expected)
    {
        // prepare
        Problem0003 sut = Scope.Resolve<Problem0003>();

        // run
        long[] result = sut.Solve(value).ToArray();

        // verify
        // Assert.AreEqual(expected.Length, result.Length);
        Assert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(600851475143)]
    public void Solve(long value)
    {
        // prepare
        Problem0003 sut = Scope.Resolve<Problem0003>();

        // run
        long[] result = sut.Solve(value).ToArray();

        Logger.Info("################");
        Logger.Info("# Problem was solved");
        Logger.Info($"# Result: {String.Join(",", result)}");
        Logger.Info("################");
    }
}
