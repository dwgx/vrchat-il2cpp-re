// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
// Classes: 16
// Methods: 54

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators
{
    public class Asn1CipherBuilderWithKey : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CF820
        public void get_AlgorithmDetails(){} // RVA: 0x7A80DA7B0
        public void GetMaxOutputSize(){} // RVA: 0x7B13CFA00
        public void BuildCipher(){} // RVA: 0x7B13CFA40
        public void get_Key(){} // RVA: 0x7A80F2570
    }

    public class Asn1KeyWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CFF20
        public void get_AlgorithmDetails(){} // RVA: 0x7B13D0080
        public void Wrap(){} // RVA: 0x7B13D00D0
    }

    public class Asn1SignatureFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D38F0
        public void get_AlgorithmDetails(){} // RVA: 0x7A80F2570
        public void CreateCalculator(){} // RVA: 0x7B13D3AC0
        public void get_SignatureAlgNames(){} // RVA: 0x7B13D3C00
    }

    public class Asn1VerifierFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD17380
        public void get_AlgorithmDetails(){} // RVA: 0x7A80F2570
        public void CreateCalculator(){} // RVA: 0x7B13D3DF0
    }

    public class Asn1VerifierFactoryProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void CreateVerifierFactory(){} // RVA: 0x7B13D3F60
        public void get_SignatureAlgNames(){} // RVA: 0x7B13D4020
    }

    public class BufferedCipherWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CFD20
        public void GetMaxOutputSize(){} // RVA: 0x7B13CFE60
        public void GetUpdateOutputSize(){} // RVA: 0x7B13CFEC0
        public void get_Stream(){} // RVA: 0x7A80DA7B0
    }

    public class DefaultSignatureCalculator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D4070
        public void get_Stream(){} // RVA: 0x7A80F2570
        public void GetResult(){} // RVA: 0x7B13D4130
    }

    public class DefaultSignatureResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Collect(){} // RVA: 0x7B13D4230
    }

    public class DefaultVerifierCalculator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D42C0
        public void get_Stream(){} // RVA: 0x7A80F2570
        public void GetResult(){} // RVA: 0x7B13D4380
    }

    public class DefaultVerifierResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void IsVerified(){} // RVA: 0x7B13D4490
    }

    public class GenericKey : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_AlgorithmIdentifier(){} // RVA: 0x7A80F2570
        public void get_Representation(){} // RVA: 0x7A80DA7B0
    }

    public class KeyWrapperUtil : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B13D0130
        public void WrapperForName(){} // RVA: 0x7B13D0690
        public void UnwrapperForName(){} // RVA: 0x7B13D0840
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RsaOaepWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D09F0
        public void get_AlgorithmDetails(){} // RVA: 0x7A80F2570
        public void Unwrap(){} // RVA: 0x7B13D0E30
        public void Wrap(){} // RVA: 0x7B13D0F30
    }

    public class RsaOaepWrapperProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Operators.WrapperProvider.CreateWrapper(){} // RVA: 0x7B13D1030
    }

    public class WrapperProvider
    {
        // ── Methods ──
        public void CreateWrapper(){} // RVA: 0x7A7E10900
    }

    public class X509Utilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B13D10C0
        public void GetDigestAlgName(){} // RVA: 0x7B13D2990
        public void GetSignatureName(){} // RVA: 0x7B13D2E70
        public void CreatePssParams(){} // RVA: 0x7B13D31B0
        public void GetAlgorithmOid(){} // RVA: 0x7B13D3300
        public void GetSigAlgID(){} // RVA: 0x7B13D3490
        public void GetAlgNames(){} // RVA: 0x7B13D3780
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}