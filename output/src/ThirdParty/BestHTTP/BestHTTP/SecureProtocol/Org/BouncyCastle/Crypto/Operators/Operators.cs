// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
// Classes: 16
// Methods: 60

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
    public class Asn1CipherBuilderWithKey : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter AlgorithmDetails; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Key; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA1BE0
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2F247C0
        public void GetMaxOutputSize(){} // RVA: 0x7FFACBBA1DC0
        public void BuildCipher(){} // RVA: 0x7FFACBBA1E00
        public void get_Key(){} // RVA: 0x7FFAC2F3C380
    }

    public class Asn1KeyWrapper : Object
    {
        public string AlgorithmDetails; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IKeyWrapper wrapper; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA22C0
        public void get_AlgorithmDetails(){} // RVA: 0x7FFACBBA2420
        public void Wrap(){} // RVA: 0x7FFACBBA2470
    }

    public class Asn1SignatureFactory : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmDetails; // 0x10
        public string SignatureAlgNames; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA5DA0 | overloaded x2
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2F3C380
        public void CreateCalculator(){} // RVA: 0x7FFACBBA5F70
        public void get_SignatureAlgNames(){} // RVA: 0x7FFACBBA60B0
    }

    public class Asn1VerifierFactory : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmDetails; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86BFC90 | overloaded x2
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2F3C380
        public void CreateCalculator(){} // RVA: 0x7FFACBBA62A0
    }

    public class Asn1VerifierFactoryProvider : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter SignatureAlgNames; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void CreateVerifierFactory(){} // RVA: 0x7FFACBBA6410
        public void get_SignatureAlgNames(){} // RVA: 0x7FFACBBA64D0
    }

    public class BufferedCipherWrapper : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher Stream; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO.CipherStream stream; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA20D0
        public void GetMaxOutputSize(){} // RVA: 0x7FFACBBA2200
        public void GetUpdateOutputSize(){} // RVA: 0x7FFACBBA2260
        public void get_Stream(){} // RVA: 0x7FFAC2F247C0
    }

    public class DefaultSignatureCalculator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO.SignerSink Stream; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA6520
        public void get_Stream(){} // RVA: 0x7FFAC2F3C380
        public void GetResult(){} // RVA: 0x7FFACBBA65E0
    }

    public class DefaultSignatureResult : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner mSigner; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Collect(){} // RVA: 0x7FFACBBA66E0 | overloaded x2
    }

    public class DefaultVerifierCalculator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO.SignerSink Stream; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA6770
        public void get_Stream(){} // RVA: 0x7FFAC2F3C380
        public void GetResult(){} // RVA: 0x7FFACBBA6830
    }

    public class DefaultVerifierResult : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner mSigner; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void IsVerified(){} // RVA: 0x7FFACBBA6940 | overloaded x2
    }

    public class GenericKey : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmIdentifier; // 0x10
        public object Representation; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void get_AlgorithmIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void get_Representation(){} // RVA: 0x7FFAC2F247C0
    }

    public class KeyWrapperUtil : Object
    {
        public System.Collections.IDictionary providerMap;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBBA24D0
        public void WrapperForName(){} // RVA: 0x7FFACBBA2A30
        public void UnwrapperForName(){} // RVA: 0x7FFACBBA2C70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RsaOaepWrapper : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmDetails; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA2EB0
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAC2F3C380
        public void Unwrap(){} // RVA: 0x7FFACBBA32E0
        public void Wrap(){} // RVA: 0x7FFACBBA33E0
    }

    public class RsaOaepWrapperProvider : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier digestOid; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.WrapperProvider.CreateWrapper(){} // RVA: 0x7FFACBBA34E0
    }

    public class WrapperProvider
    {
        // ── Methods ──
        public void CreateWrapper(){}
    }

    public class X509Utilities : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Null derNull;
        public System.Collections.IDictionary algorithms; // 0x8
        public System.Collections.IDictionary exParams; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet noParams; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBBA3570
        public void GetDigestAlgName(){} // RVA: 0x7FFACBBA4E40
        public void GetSignatureName(){} // RVA: 0x7FFACBBA5320
        public void CreatePssParams(){} // RVA: 0x7FFACBBA5660
        public void GetAlgorithmOid(){} // RVA: 0x7FFACBBA57B0
        public void GetSigAlgID(){} // RVA: 0x7FFACBBA5940
        public void GetAlgNames(){} // RVA: 0x7FFACBBA5C30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}