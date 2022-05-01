using System.Text;
using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0059;

[RegisterType]
public class Problem0059
{
    private const string SecretChars  = "abcdefghijklmnopqrstuvwxyz";
    private const int    SecretLength = 3;

    private static readonly string[] MostCommonEnglishWords = new[]
                                                              {
                                                                  "the",
                                                                  "be",
                                                                  "to",
                                                                  "of",
                                                                  "a",
                                                                  "in",
                                                                  "that",
                                                                  "have",
                                                              };

    private readonly CartesianProduct cartesianProduct;
    private readonly XorDecrypter     xorDecrypter;

    public Problem0059(CartesianProduct cartesianProduct, XorDecrypter xorDecrypter)
    {
        this.cartesianProduct = cartesianProduct;
        this.xorDecrypter     = xorDecrypter;
    }

    public long Solve()
    {
        ICollection<string> possibleSecrets = GeneratePossibleSecrets(SecretLength);

        byte[] encryptedTest = LoadEncryptedText();

        long? sum = null;

        foreach (string possibleSecret in possibleSecrets)
        {
            char[] textAsArray = xorDecrypter.Decrypt(encryptedTest, possibleSecret)
                                             .Select(Convert.ToChar)
                                             .ToArray();
            string text = new(textAsArray);

            if (IsValidText(text))
            {
               sum = SumByteValue(text);
            }
        }

        return sum ?? -1;
    }

    private ICollection<string> GeneratePossibleSecrets(int length)
    {
        List<char> secretChars = SecretChars.ToCharArray().ToList();

        List<List<char>> setsForCartesianProduct = new();
        for (int index = 0; index < length; index++)
        {
            setsForCartesianProduct.Add(secretChars);
        }

        return cartesianProduct.Create(setsForCartesianProduct)
                               .Select(stringAsArray => String.Join("", stringAsArray))
                               .ToList();
    }

    private byte[] LoadEncryptedText()
    {
        string text = File.ReadAllText("./Assets/0059/p059_cipher.txt");
        return text.Split(',')
                   .Select(value => Convert.ToInt32(value))
                   .Select(value => Convert.ToByte(value))
                   .ToArray();
    }

    private bool IsValidText(string possibleText)
    {
        string[] possibleWords = possibleText.Split(" ");
        return MostCommonEnglishWords.All(commonWord => possibleWords.Contains(commonWord));

        // return possibleText.Split(" ")
                           // .Select(word => word.ToLower())
                           // .All(word => MostCommonEnglishWords.Contains(word));
    }

    private long SumByteValue(string text)
    {
        byte[] textAsBytes = Encoding.ASCII.GetBytes(text);
        return textAsBytes.Select(Convert.ToInt32)
                          .Sum();
    }
}
