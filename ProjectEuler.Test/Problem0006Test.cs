using NUnit.Framework;
using Project_Euler.Problem0006;

namespace ProjectEuler.Test;

public class Problem0006Test : AbstractProblemTest<Problem0006>
{
    [Test]
    [TestCase(10, 2640)]
    [TestCase(100, 25164150)]
    public void Should(int upperBorder, int expected)
    {
        // prepare

        // run
        Result0006 result = Sut.Solve(upperBorder);

        // verify
        Assert.AreEqual(expected, result.Diff);
    }

    [Test]
    [TestCase(100)]
    public void Solve(int upperBorder)
    {
        // prepare

        // run
        Solve(() => Sut.Solve(upperBorder));
    }
}
