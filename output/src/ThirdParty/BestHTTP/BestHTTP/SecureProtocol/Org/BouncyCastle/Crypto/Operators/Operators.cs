// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
// Classes: 16
// Methods: 60

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
    public class Asn1CipherBuilderWithKey : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9598E30
        public void get_AlgorithmDetails(){} // RVA: 0x2E07C0
        public void GetMaxOutputSize(){} // RVA: 0x9599010
        public void BuildCipher(){} // RVA: 0x9599050
        public void get_Key(){} // RVA: 0x2F8380
    }

    public class Asn1KeyWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9599510
        public void get_AlgorithmDetails(){} // RVA: 0x9599670
        public void Wrap(){} // RVA: 0x95996C0
    }

    public class Asn1SignatureFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x959CFF0 | overloaded x2
        public void get_AlgorithmDetails(){} // RVA: 0x2F8380
        public void CreateCalculator(){} // RVA: 0x959D1C0
        public void get_SignatureAlgNames(){} // RVA: 0x959D300
    }

    public class Asn1VerifierFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F28620 | overloaded x2
        public void get_AlgorithmDetails(){} // RVA: 0x2F8380
        public void CreateCalculator(){} // RVA: 0x959D4F0
    }

    public class Asn1VerifierFactoryProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void CreateVerifierFactory(){} // RVA: 0x959D660
        public void get_SignatureAlgNames(){} // RVA: 0x959D720
    }

    public class BufferedCipherWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9599320
        public void GetMaxOutputSize(){} // RVA: 0x9599450
        public void GetUpdateOutputSize(){} // RVA: 0x95994B0
        public void get_Stream(){} // RVA: 0x2E07C0
    }

    public class DefaultSignatureCalculator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x959D770
        public void get_Stream(){} // RVA: 0x2F8380
        public void GetResult(){} // RVA: 0x959D830
    }

    public class DefaultSignatureResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Collect(){} // RVA: 0x959D930 | overloaded x2
    }

    public class DefaultVerifierCalculator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x959D9C0
        public void get_Stream(){} // RVA: 0x2F8380
        public void GetResult(){} // RVA: 0x959DA80
    }

    public class DefaultVerifierResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void IsVerified(){} // RVA: 0x959DB90 | overloaded x2
    }

    public class GenericKey
    {
        public object AlgorithmName;
        public object IsPartialBlockOkay;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void get_AlgorithmIdentifier(){} // RVA: 0x2F8380
        public void get_Representation(){} // RVA: 0x2E07C0
    }

    public class KeyWrapperUtil
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9599720
        public void WrapperForName(){} // RVA: 0x9599C80
        public void UnwrapperForName(){} // RVA: 0x9599EC0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RsaOaepWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x959A100
        public void get_AlgorithmDetails(){} // RVA: 0x2F8380
        public void Unwrap(){} // RVA: 0x959A530
        public void Wrap(){} // RVA: 0x959A630
    }

    public class RsaOaepWrapperProvider : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.WrapperProvider.CreateWrapper(){} // RVA: 0x959A730
    }

    public class WrapperProvider
    {
        // ── Methods ──
        public void CreateWrapper(){}
    }

    public class X509Utilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x959A7C0
        public void GetDigestAlgName(){} // RVA: 0x959C090
        public void GetSignatureName(){} // RVA: 0x959C570
        public void CreatePssParams(){} // RVA: 0x959C8B0
        public void GetAlgorithmOid(){} // RVA: 0x959CA00
        public void GetSigAlgID(){} // RVA: 0x959CB90
        public void GetAlgNames(){} // RVA: 0x959CE80
        public void .ctor(){} // RVA: 0x2DD310
    }

}