// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
// Classes: 16
// Methods: 54

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
    public class Asn1CipherBuilderWithKey : Object
    {
        public object encKey;
        public object algorithmIdentifier;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA23AE10
        public void get_AlgorithmDetails(){} // RVA: 0xB465B0
        public void GetMaxOutputSize(){} // RVA: 0xA23AFF0
        public void BuildCipher(){} // RVA: 0xA23B030
        public void get_Key(){} // RVA: 0xB5DBF0
    }

    public class Asn1KeyWrapper : Object
    {
        public object algorithm;
        public object wrapper;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA23B510
        public void get_AlgorithmDetails(){} // RVA: 0xA23B670
        public void Wrap(){} // RVA: 0xA23B6C0
    }

    public class Asn1SignatureFactory : Object
    {
        public object algID;
        public object algorithm;
        public object privateKey;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA23EEE0
        public void get_AlgorithmDetails(){} // RVA: 0xB5DBF0
        public void CreateCalculator(){} // RVA: 0xA23F0B0
        public void get_SignatureAlgNames(){} // RVA: 0xA23F1F0
    }

    public class Asn1VerifierFactory : Object
    {
        public object algID;
        public object publicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69A01B0
        public void get_AlgorithmDetails(){} // RVA: 0xB5DBF0
        public void CreateCalculator(){} // RVA: 0xA23F3E0
    }

    public class Asn1VerifierFactoryProvider : Object
    {
        public object publicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void CreateVerifierFactory(){} // RVA: 0xA23F550
        public void get_SignatureAlgNames(){} // RVA: 0xA23F610
    }

    public class BufferedCipherWrapper : Object
    {
        public object bufferedCipher;
        public object stream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA23B310
        public void GetMaxOutputSize(){} // RVA: 0xA23B450
        public void GetUpdateOutputSize(){} // RVA: 0xA23B4B0
        public void get_Stream(){} // RVA: 0xB465B0
    }

    public class DefaultSignatureCalculator : Object
    {
        public object mSignerSink;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA23F660
        public void get_Stream(){} // RVA: 0xB5DBF0
        public void GetResult(){} // RVA: 0xA23F720
    }

    public class DefaultSignatureResult : Object
    {
        public object mSigner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Collect(){} // RVA: 0xA23F820
    }

    public class DefaultVerifierCalculator : Object
    {
        public object mSignerSink;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA23F8B0
        public void get_Stream(){} // RVA: 0xB5DBF0
        public void GetResult(){} // RVA: 0xA23F970
    }

    public class DefaultVerifierResult : Object
    {
        public object mSigner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void IsVerified(){} // RVA: 0xA23FA80
    }

    public class GenericKey : Object
    {
        public object algorithmIdentifier;
        public object representation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_AlgorithmIdentifier(){} // RVA: 0xB5DBF0
        public void get_Representation(){} // RVA: 0xB465B0
    }

    public class KeyWrapperUtil : Object
    {
        public object providerMap;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA23B720
        public void WrapperForName(){} // RVA: 0xA23BC80
        public void UnwrapperForName(){} // RVA: 0xA23BE30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RsaOaepWrapper : Object
    {
        public object algId;
        public object engine;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA23BFE0
        public void get_AlgorithmDetails(){} // RVA: 0xB5DBF0
        public void Unwrap(){} // RVA: 0xA23C420
        public void Wrap(){} // RVA: 0xA23C520
    }

    public class RsaOaepWrapperProvider : Object
    {
        public object digestOid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.WrapperProvider.CreateWrapper(){} // RVA: 0xA23C620
    }

    public class WrapperProvider
    {
        // ── Methods ──
        public void CreateWrapper(){} // RVA: 0x88C320
    }

    public class X509Utilities : Object
    {
        public object derNull;
        public object algorithms;
        public object exParams;
        public object noParams;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA23C6B0
        public void GetDigestAlgName(){} // RVA: 0xA23DF80
        public void GetSignatureName(){} // RVA: 0xA23E460
        public void CreatePssParams(){} // RVA: 0xA23E7A0
        public void GetAlgorithmOid(){} // RVA: 0xA23E8F0
        public void GetSigAlgID(){} // RVA: 0xA23EA80
        public void GetAlgNames(){} // RVA: 0xA23ED70
        public void .ctor(){} // RVA: 0xB43310
    }

}