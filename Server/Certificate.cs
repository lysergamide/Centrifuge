using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Security;

public class CertificateValidation : ICertificateValidator
{
    private readonly RsaKeyParameters _pinnedPublicKey;

    public CertificateValidation(byte[] pinnedPublicKey)
    {
        _pinnedPublicKey = (RsaKeyParameters)PublicKeyFactory.CreateKey(pinnedPublicKey);
    }

    public bool Validate(X509Certificate2 certificate, SslPolicyErrors errors)
    {
        var chain = new X509Chain();
        chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;
        chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
        chain.ChainPolicy.ExtraStore.Add(certificate);

        if (!chain.Build(certificate))
        {
            return false;
        }

        var serverPublicKey = chain.ChainElements[0].Certificate.GetPublicKey();
        if (!(serverPublicKey is RSACryptoServiceProvider rsa))
        {
            return false;
        }

        var serverRsaPublicKey = (RsaKeyParameters)PublicKeyFactory.CreateKey(rsa.ExportParameters(false));
        return serverRsaPublicKey.Equals(_pinnedPublicKey);
    }
}