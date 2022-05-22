using NUnit.Framework;
using Project_Euler.Problem0008;

namespace ProjectEuler.Test;

public class Problem0008Test : AbstractProblemTest<Problem0008>
{
    [Test]
    [TestCase(4, new []{9,9,8,9}, 5832)]
    [TestCase(13, new []{5,5,7,6,6,8,9,6,6,4,8,9,5}, 23514624000)]
    public void Should(int count, int[] expectedOrder, long expectedProduct)
    {
        // prepare

        // run
        Result0008? result = Sut.Solve(count);

        // verify
        Assert.IsNotNull(result);
        Assert.AreEqual(expectedOrder, result?.Order);
        Assert.AreEqual(expectedProduct, result?.Product);
    }

    [Test]
    [TestCase(13)]
    public void Solve(int count)
    {
        // prepare

        // run
        Solve(() => Sut.Solve(count));
    }
}
