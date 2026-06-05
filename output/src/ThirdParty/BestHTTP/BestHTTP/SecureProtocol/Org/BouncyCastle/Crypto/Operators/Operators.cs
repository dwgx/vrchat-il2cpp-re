// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
// Classes: 16
// Methods: 60

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
    public class Asn1CipherBuilderWithKey : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC048E30
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2D907C0
        public void GetMaxOutputSize(){} // RVA: 0x7FFAFC049010
        public void BuildCipher(){} // RVA: 0x7FFAFC049050
        public void get_Key(){} // RVA: 0x7FFAF2DA8380
    }

    public class Asn1KeyWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC049510
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAFC049670
        public void Wrap(){} // RVA: 0x7FFAFC0496C0
    }

    public class Asn1SignatureFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC04CFF0 | overloaded x2
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2DA8380
        public void CreateCalculator(){} // RVA: 0x7FFAFC04D1C0
        public void get_SignatureAlgNames(){} // RVA: 0x7FFAFC04D300
    }

    public class Asn1VerifierFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF89D8620 | overloaded x2
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2DA8380
        public void CreateCalculator(){} // RVA: 0x7FFAFC04D4F0
    }

    public class Asn1VerifierFactoryProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void CreateVerifierFactory(){} // RVA: 0x7FFAFC04D660
        public void get_SignatureAlgNames(){} // RVA: 0x7FFAFC04D720
    }

    public class BufferedCipherWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC049320
        public void GetMaxOutputSize(){} // RVA: 0x7FFAFC049450
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAFC0494B0
        public void get_Stream(){} // RVA: 0x7FFAF2D907C0
    }

    public class DefaultSignatureCalculator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC04D770
        public void get_Stream(){} // RVA: 0x7FFAF2DA8380
        public void GetResult(){} // RVA: 0x7FFAFC04D830
    }

    public class DefaultSignatureResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Collect(){} // RVA: 0x7FFAFC04D930 | overloaded x2
    }

    public class DefaultVerifierCalculator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC04D9C0
        public void get_Stream(){} // RVA: 0x7FFAF2DA8380
        public void GetResult(){} // RVA: 0x7FFAFC04DA80
    }

    public class DefaultVerifierResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void IsVerified(){} // RVA: 0x7FFAFC04DB90 | overloaded x2
    }

    public class GenericKey
    {
        public object AlgorithmName;
        public object IsPartialBlockOkay;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x3
        public void get_AlgorithmIdentifier(){} // RVA: 0x7FFAF2DA8380
        public void get_Representation(){} // RVA: 0x7FFAF2D907C0
    }

    public class KeyWrapperUtil
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC049720
        public void WrapperForName(){} // RVA: 0x7FFAFC049C80
        public void UnwrapperForName(){} // RVA: 0x7FFAFC049EC0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class RsaOaepWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC04A100
        public void get_AlgorithmDetails(){} // RVA: 0x7FFAF2DA8380
        public void Unwrap(){} // RVA: 0x7FFAFC04A530
        public void Wrap(){} // RVA: 0x7FFAFC04A630
    }

    public class RsaOaepWrapperProvider : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.WrapperProvider.CreateWrapper(){} // RVA: 0x7FFAFC04A730
    }

    public class WrapperProvider
    {
        // ── Methods ──
        public void CreateWrapper(){}
    }

    public class X509Utilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC04A7C0
        public void GetDigestAlgName(){} // RVA: 0x7FFAFC04C090
        public void GetSignatureName(){} // RVA: 0x7FFAFC04C570
        public void CreatePssParams(){} // RVA: 0x7FFAFC04C8B0
        public void GetAlgorithmOid(){} // RVA: 0x7FFAFC04CA00
        public void GetSigAlgID(){} // RVA: 0x7FFAFC04CB90
        public void GetAlgNames(){} // RVA: 0x7FFAFC04CE80
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}