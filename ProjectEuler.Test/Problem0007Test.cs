using NUnit.Framework;
using Project_Euler.Problem0007;

namespace ProjectEuler.Test;

public class Problem0007Test : AbstractProblemTest<Problem0007>
{
    [Test]
    [TestCase(1, 2)]
    [TestCase(2, 3)]
    [TestCase(3, 5)]
    [TestCase(4, 7)]
    [TestCase(5, 11)]
    [TestCase(6, 13)]
    [TestCase(10001, 104743)]
    public void Should(int position, long expected)
    {
        // prepare

        // run
        long result = Sut.Solve(position);

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(10001)]
    public void Solve(int position)
    {
        // prepare

        // run
        Solve(() => Sut.Solve(position));
    }
}
