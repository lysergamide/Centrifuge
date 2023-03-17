using System;
using System.Linq;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Centrifuge.Server;
public class KeyGen {
    public static AsymmetricCipherKeyPair GenerateKeyPair() {
        var secureRandom = new SecureRandom();
        var keyParams = new KeyGenerationParameters(secureRandom, 1);

        var generator = new Ed25519KeyPairGenerator();
            generator.Init(keyParams);
        AsymmetricCipherKeyPair keyPair = generator.GenerateKeyPair();

        var privateKey = keyPair.Private as Ed25519PrivateKeyParameters;
        var publicKey = keyPair.Public as Ed25519PublicKeyParameters;

        Console.WriteLine($"Private key: {ToHex(privateKey.GetEncoded())}");
        Console.WriteLine($"Public key: {ToHex(publicKey.GetEncoded())}");

        return keyPair;
    }
    
    static string ToHex(byte[] data) => String.Concat(data.Select(x => x.ToString("x2")));

}