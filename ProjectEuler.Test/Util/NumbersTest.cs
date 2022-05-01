using System;
using NUnit.Framework;
using Project_Euler.Util;

namespace ProjectEuler.Test.Util;

public class NumbersTest : AbstractTest<Numbers>
{
    [Test]
    [TestCase(1, 0, true)]
    [TestCase(1, 1, true)]
    [TestCase(5, 15, true)]
    [TestCase(15, 5, false)]
    [TestCase(6, 5, false)]
    public void TestIsMultipleOf(int multiple, int value, bool expected)
    {
        // prepare

        // run
        bool result = Sut.IsMultipleOf(multiple, value);

        // verify
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestIsMultipleOf_DiveByZero()
    {
        // prepare

        // run & verify
        Assert.Throws<DivideByZeroException>(() =>
                                             {
                                                 Sut.IsMultipleOf(0, 10);
                                             });
    }

    [Test]
    [TestCase(2, true)]
    [TestCase(12, true)]
    [TestCase(0, true)]
    [TestCase(3, false)]
    [TestCase(13, false)]
    public void TestIsEven(int value, bool expected)
    {
        // prepare

        // run
        bool result = Sut.IsEven(value);

        // verify
        Assert.AreEqual(expected, result);
    }
}
