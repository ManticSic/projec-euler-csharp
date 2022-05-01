using System.Text;
using Unity.Lifetime;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0059;

[RegisterType(lifetimeManager: typeof(SingletonLifetimeManager))]
public class XorDecrypter
{
    public IReadOnlyCollection<byte> Decrypt(byte[] input, string secret)
    {
        byte[] secretAsBytes = Encoding.ASCII.GetBytes(secret);

        return DecryptInternal(input, secretAsBytes);
    }

    private IReadOnlyCollection<byte> DecryptInternal(byte[] input, byte[] secret)
    {
        List<byte> result  = new();
        int        pointer = 0;

        foreach (byte encryptedChar in input)
        {
            int  encryptedCharAsInteger = Convert.ToInt32(encryptedChar);
            int  secretForXor           = Convert.ToInt32(secret[pointer]);
            int  decryptedCharAsInteger = encryptedCharAsInteger ^ secretForXor;
            byte decryptedChar          = Convert.ToByte(decryptedCharAsInteger);

            result.Add(decryptedChar);

            pointer++;

            if (pointer >= secret.Length)
            {
                pointer = 0;
            }
        }

        return result;
    }
}
