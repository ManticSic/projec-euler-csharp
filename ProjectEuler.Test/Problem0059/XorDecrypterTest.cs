using System.Linq;
using System.Text;
using NUnit.Framework;
using Project_Euler.Problem0059;

namespace ProjectEuler.Test;

public class XorDecryterTest : AbstractProblemTest<XorDecrypter>
{
    [Test]
    [TestCase(new byte[] { 65 }, "*", "k")]
    [TestCase(new byte[] { 65, 65 }, "*", "kk")]
    [TestCase(new byte[] { 65, 65, 65 }, "*", "kkk")]
    [TestCase(new byte[] { 43 }, "@", "k")]
    [TestCase(new byte[] { 40, 4, 44, 13, 47 }, "@a", "hello")]
    public void TestDecrypt(byte[] input, string secret, string expected)
    {
        // prepare

        // run
        byte[] result         = Sut.Decrypt(input, secret).ToArray();
        string resultAsString = Encoding.ASCII.GetString(result);

        // validate
        Assert.AreEqual(expected, resultAsString);
    }
}
