// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
// Classes: 16
// Methods: 60

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
    public class Asn1CipherBuilderWithKey : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FFB200
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE810FE7C0
        public void GetMaxOutputSize(){} // RVA: 0x7FFE89FFB3E0
        public void BuildCipher(){} // RVA: 0x7FFE89FFB420
        public void get_Key(){} // RVA: 0x7FFE81116380
    }

    public class Asn1KeyWrapper : Object
    {
        public string algorithm; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FFB8E0
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE89FFBA40
        public void Wrap(){} // RVA: 0x7FFE89FFBA90
    }

    public class Asn1SignatureFactory : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID; // 0x10
        public string algorithm; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FFF3C0 | overloaded x2
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE81116380
        public void CreateCalculator(){} // RVA: 0x7FFE89FFF590
        public void get_SignatureAlgNames(){} // RVA: 0x7FFE89FFF6D0
    }

    public class Asn1VerifierFactory : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A69440 | overloaded x2
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE81116380
        public void CreateCalculator(){} // RVA: 0x7FFE89FFF8C0
    }

    public class Asn1VerifierFactoryProvider : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void CreateVerifierFactory(){} // RVA: 0x7FFE89FFFA30
        public void get_SignatureAlgNames(){} // RVA: 0x7FFE89FFFAF0
    }

    public class BufferedCipherWrapper : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher bufferedCipher; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FFB6F0
        public void GetMaxOutputSize(){} // RVA: 0x7FFE89FFB820
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE89FFB880
        public void get_Stream(){} // RVA: 0x7FFE810FE7C0
    }

    public class DefaultSignatureCalculator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO.SignerSink mSignerSink; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FFFB40
        public void get_Stream(){} // RVA: 0x7FFE81116380
        public void GetResult(){} // RVA: 0x7FFE89FFFC00
    }

    public class DefaultSignatureResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Collect(){} // RVA: 0x7FFE89FFFD00 | overloaded x2
    }

    public class DefaultVerifierCalculator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IO.SignerSink mSignerSink; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FFFD90
        public void get_Stream(){} // RVA: 0x7FFE81116380
        public void GetResult(){} // RVA: 0x7FFE89FFFE50
    }

    public class DefaultVerifierResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void IsVerified(){} // RVA: 0x7FFE89FFFF60 | overloaded x2
    }

    public class GenericKey : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier; // 0x10
        public object representation; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void get_AlgorithmIdentifier(){} // RVA: 0x7FFE81116380
        public void get_Representation(){} // RVA: 0x7FFE810FE7C0
    }

    public class KeyWrapperUtil : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE89FFBAF0
        public void WrapperForName(){} // RVA: 0x7FFE89FFC050
        public void UnwrapperForName(){} // RVA: 0x7FFE89FFC290
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RsaOaepWrapper : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FFC4D0
        public void get_AlgorithmDetails(){} // RVA: 0x7FFE81116380
        public void Unwrap(){} // RVA: 0x7FFE89FFC900
        public void Wrap(){} // RVA: 0x7FFE89FFCA00
    }

    public class RsaOaepWrapperProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.WrapperProvider.CreateWrapper(){} // RVA: 0x7FFE89FFCB00
    }

    public class WrapperProvider
    {
        // ── Methods ──
        public void CreateWrapper(){}
    }

    public class X509Utilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE89FFCB90
        public void GetDigestAlgName(){} // RVA: 0x7FFE89FFE460
        public void GetSignatureName(){} // RVA: 0x7FFE89FFE940
        public void CreatePssParams(){} // RVA: 0x7FFE89FFEC80
        public void GetAlgorithmOid(){} // RVA: 0x7FFE89FFEDD0
        public void GetSigAlgID(){} // RVA: 0x7FFE89FFEF60
        public void GetAlgNames(){} // RVA: 0x7FFE89FFF250
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}