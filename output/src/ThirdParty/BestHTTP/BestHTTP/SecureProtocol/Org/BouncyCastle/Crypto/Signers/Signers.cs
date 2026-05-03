// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
// Classes: 26
// Methods: 237

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
{
    public class DsaDigestSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDsa dsa; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FC7910
        public void Init(){} // RVA: 0x7FFE89FC79C0
        public void Update(){} // RVA: 0x7FFE89FC7C10
        public void BlockUpdate(){} // RVA: 0x7FFE89FC7C70
        public void GenerateSignature(){} // RVA: 0x7FFE89FC7D00
        public void VerifySignature(){} // RVA: 0x7FFE89FC7F00
        public void Reset(){} // RVA: 0x7FFE89FC80D0
        public void GetOrder(){} // RVA: 0x7FFE89FC8120
    }

    public class DsaSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters key; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FC8270
        public void Init(){} // RVA: 0x7FFE89FC82B0
        public void get_Order(){} // RVA: 0x7FFE89FC86F0
        public void GenerateSignature(){} // RVA: 0x7FFE89FC8720
        public void VerifySignature(){} // RVA: 0x7FFE89FC8AE0
        public void CalculateE(){} // RVA: 0x7FFE89FC8D40
        public void InitSecureRandom(){} // RVA: 0x7FFE89FC8E20
    }

    public class ECDsaSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Eight;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FC8F20
        public void Init(){} // RVA: 0x7FFE89FC8F60
        public void get_Order(){} // RVA: 0x7FFE89FC93A0
        public void GenerateSignature(){} // RVA: 0x7FFE89FC93D0
        public void VerifySignature(){} // RVA: 0x7FFE89FC99B0
        public void CalculateE(){} // RVA: 0x7FFE89FC9DF0
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFE89FC9EC0
        public void GetDenominator(){} // RVA: 0x7FFE89FC9F00
        public void InitSecureRandom(){} // RVA: 0x7FFE89FC9FB0
        public void .cctor(){} // RVA: 0x7FFE89FCA020
    }

    public class ECGost3410Signer : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECKeyParameters key; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x18

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8189C080
        public void Init(){} // RVA: 0x7FFE89FCA0F0
        public void get_Order(){} // RVA: 0x7FFE89FCA570
        public void GenerateSignature(){} // RVA: 0x7FFE89FCA5A0
        public void VerifySignature(){} // RVA: 0x7FFE89FCAAE0
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFE89FCAEB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ECNRSigner : Object
    {
        public bool forSigning; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECKeyParameters key; // 0x18

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FCAEF0
        public void Init(){} // RVA: 0x7FFE89FCAF30
        public void get_Order(){} // RVA: 0x7FFE89FC93A0
        public void GenerateSignature(){} // RVA: 0x7FFE89FCB3B0
        public void VerifySignature(){} // RVA: 0x7FFE89FCB9B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Ed25519Signer : Object
    {
        public Buffer buffer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FCD530
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FCD5D0
        public void Init(){} // RVA: 0x7FFE89FCD610
        public void Update(){} // RVA: 0x7FFE869997A0
        public void BlockUpdate(){} // RVA: 0x7FFE86999860
        public void GenerateSignature(){} // RVA: 0x7FFE89FCD8C0
        public void VerifySignature(){} // RVA: 0x7FFE89FCD950
        public void Reset(){} // RVA: 0x7FFE89FCC310
    }

    public class Ed25519ctxSigner : Object
    {
        public Buffer buffer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FCBD30
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FCBEE0
        public void Init(){} // RVA: 0x7FFE89FCBF20
        public void Update(){} // RVA: 0x7FFE869997A0
        public void BlockUpdate(){} // RVA: 0x7FFE86999860
        public void GenerateSignature(){} // RVA: 0x7FFE89FCC1D0
        public void VerifySignature(){} // RVA: 0x7FFE89FCC270
        public void Reset(){} // RVA: 0x7FFE89FCC310
    }

    public class Ed25519phSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest prehash; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FCCA00
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FCCBE0
        public void Init(){} // RVA: 0x7FFE89FCCC20
        public void Update(){} // RVA: 0x7FFE89FCCEF0
        public void BlockUpdate(){} // RVA: 0x7FFE89FCCF50
        public void GenerateSignature(){} // RVA: 0x7FFE89FCCFE0
        public void VerifySignature(){} // RVA: 0x7FFE89FCD250
        public void Reset(){} // RVA: 0x7FFE89FCD4E0
    }

    public class Ed448Signer : Object
    {
        public Buffer buffer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FCEA40
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FCEBF0
        public void Init(){} // RVA: 0x7FFE89FCEC30
        public void Update(){} // RVA: 0x7FFE869997A0
        public void BlockUpdate(){} // RVA: 0x7FFE86999860
        public void GenerateSignature(){} // RVA: 0x7FFE89FCEEE0
        public void VerifySignature(){} // RVA: 0x7FFE89FCEF80
        public void Reset(){} // RVA: 0x7FFE89FCC310
    }

    public class Ed448phSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IXof prehash; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FCDF10
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FCE0F0
        public void Init(){} // RVA: 0x7FFE89FCE130
        public void Update(){} // RVA: 0x7FFE89FCE400
        public void BlockUpdate(){} // RVA: 0x7FFE89FCE460
        public void GenerateSignature(){} // RVA: 0x7FFE89FCE4F0
        public void VerifySignature(){} // RVA: 0x7FFE89FCE760
        public void Reset(){} // RVA: 0x7FFE89FCE9F0
    }

    public class GenericSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FCF560
        public void Init(){} // RVA: 0x7FFE89FCF6B0
        public void Update(){} // RVA: 0x7FFE89FCF900
        public void BlockUpdate(){} // RVA: 0x7FFE89FCF960
        public void GenerateSignature(){} // RVA: 0x7FFE89FCF9F0
        public void VerifySignature(){} // RVA: 0x7FFE89FCFB40
        public void Reset(){} // RVA: 0x7FFE89FCFDA0
    }

    public class Gost3410DigestSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FCFDF0
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FCFF10
        public void Init(){} // RVA: 0x7FFE89FCFFC0
        public void Update(){} // RVA: 0x7FFE89FD0210
        public void BlockUpdate(){} // RVA: 0x7FFE89FD0270
        public void GenerateSignature(){} // RVA: 0x7FFE89FD0300
        public void VerifySignature(){} // RVA: 0x7FFE89FD0570
        public void Reset(){} // RVA: 0x7FFE89FD07A0
    }

    public class Gost3410Signer : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters key; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x18

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FD07F0
        public void Init(){} // RVA: 0x7FFE89FD0830
        public void get_Order(){} // RVA: 0x7FFE89FD0CA0
        public void GenerateSignature(){} // RVA: 0x7FFE89FD0CD0
        public void VerifySignature(){} // RVA: 0x7FFE89FD10B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HMacDsaKCalculator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs.HMac hMac; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FD13D0
        public void get_IsDeterministic(){} // RVA: 0x7FFE811E0850
        public void Init(){} // RVA: 0x7FFE89FD15F0 | overloaded x2
        public void NextK(){} // RVA: 0x7FFE89FD1BC0
        public void BitsToInt(){} // RVA: 0x7FFE89FD1F30
    }

    public class IDsaEncoding
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x7FFE80E3FC10
        public void Encode(){} // RVA: 0x7FFE80E403A0
    }

    public class IDsaKCalculator
    {
        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0x7FFE80E2F150
        public void Init(){} // RVA: 0x7FFE80E50660 | overloaded x2
        public void NextK(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Iso9796d2PssSigner : Object
    {
        public int TrailerImplicit;

        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0x7FFE81199370
        public void .ctor(){} // RVA: 0x7FFE89FD21F0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FD2210
        public void Init(){} // RVA: 0x7FFE89FD2280
        public void IsSameAs(){} // RVA: 0x7FFE89FD2840
        public void ClearBlock(){} // RVA: 0x7FFE89FD28C0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7FFE89FD28F0
        public void Update(){} // RVA: 0x7FFE89FD2E10
        public void BlockUpdate(){} // RVA: 0x7FFE89FD2EC0
        public void Reset(){} // RVA: 0x7FFE89FD2FA0
        public void GenerateSignature(){} // RVA: 0x7FFE89FD3150
        public void VerifySignature(){} // RVA: 0x7FFE89FD3610
        public void HasFullMessage(){} // RVA: 0x7FFE813A1140
        public void ItoOSP(){} // RVA: 0x7FFE89FD3BB0
        public void LtoOSP(){} // RVA: 0x7FFE89FD3C10
        public void MaskGeneratorFunction1(){} // RVA: 0x7FFE89FD3CC0
    }

    public class Iso9796d2Signer : Object
    {
        public int TrailerImplicit;

        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE89FD42E0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FD4300
        public void Init(){} // RVA: 0x7FFE89FD4370
        public void IsSameAs(){} // RVA: 0x7FFE89FD4630
        public void ClearBlock(){} // RVA: 0x7FFE89FD28C0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7FFE89FD4700
        public void Update(){} // RVA: 0x7FFE89FD4B80
        public void BlockUpdate(){} // RVA: 0x7FFE89FD4C10
        public void Reset(){} // RVA: 0x7FFE89FD4CF0
        public void GenerateSignature(){} // RVA: 0x7FFE89FD4EB0
        public void VerifySignature(){} // RVA: 0x7FFE89FD51A0
        public void ReturnFalse(){} // RVA: 0x7FFE89FD5970
        public void HasFullMessage(){} // RVA: 0x7FFE812604E0
    }

    public class IsoTrailers : Object
    {
        // ── Methods ──
        public void CreateTrailerMap(){} // RVA: 0x7FFE89FD59C0
        public void GetTrailer(){} // RVA: 0x7FFE89FD5DF0
        public void NoTrailerAvailable(){} // RVA: 0x7FFE89FD5EF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89FD5FB0
    }

    public class PlainDsaEncoding : Object
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x7FFE89FD6050
        public void Encode(){} // RVA: 0x7FFE89FD6230
        public void CheckValue(){} // RVA: 0x7FFE89FD6330
        public void DecodeValue(){} // RVA: 0x7FFE89FD63D0
        public void EncodeValue(){} // RVA: 0x7FFE89FD6490
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89FD65E0
    }

    public class PssSigner : Object
    {
        public byte TrailerImplicit;

        // ── Methods ──
        public void CreateRawSigner(){} // RVA: 0x7FFE89FD6780 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE89FD6A70 | overloaded x8
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FD6DA0
        public void Init(){} // RVA: 0x7FFE89FD6E10
        public void ClearBlock(){} // RVA: 0x7FFE89FD28C0
        public void Update(){} // RVA: 0x7FFE89FD71C0
        public void BlockUpdate(){} // RVA: 0x7FFE89FD7220
        public void Reset(){} // RVA: 0x7FFE89FD72B0
        public void GenerateSignature(){} // RVA: 0x7FFE89FD7300
        public void VerifySignature(){} // RVA: 0x7FFE89FD7640
        public void ItoOSP(){} // RVA: 0x7FFE89FD3BB0
        public void MaskGeneratorFunction1(){} // RVA: 0x7FFE89FD7A60
    }

    public class RandomDsaKCalculator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x10

        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0x7FFE810FB320
        public void Init(){} // RVA: 0x7FFE89FD7EE0 | overloaded x2
        public void NextK(){} // RVA: 0x7FFE89FD7F30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RsaDigestSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher rsaEngine; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE89FD7FE0
        public void .ctor(){} // RVA: 0x7FFE89FD8AD0 | overloaded x6
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FD8C40
        public void Init(){} // RVA: 0x7FFE89FD8CB0
        public void Update(){} // RVA: 0x7FFE89FD8F00
        public void BlockUpdate(){} // RVA: 0x7FFE89FD8F60
        public void GenerateSignature(){} // RVA: 0x7FFE89FD8FF0
        public void VerifySignature(){} // RVA: 0x7FFE89FD9140
        public void Reset(){} // RVA: 0x7FFE89FD9420
        public void DerEncode(){} // RVA: 0x7FFE89FD9470
    }

    public class SM2Signer : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FD96B0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FD9800
        public void Init(){} // RVA: 0x7FFE89FD9840
        public void Update(){} // RVA: 0x7FFE89FDA150
        public void BlockUpdate(){} // RVA: 0x7FFE89FDA1B0
        public void VerifySignature(){} // RVA: 0x7FFE89FDABA0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE89FDA2F0
        public void GenerateSignature(){} // RVA: 0x7FFE89FDA380
        public void GetZ(){} // RVA: 0x7FFE89FDAE90
        public void AddUserID(){} // RVA: 0x7FFE89FDB400
        public void AddFieldElement(){} // RVA: 0x7FFE89FDB4C0
        public void CalculateE(){} // RVA: 0x7FFE89FDB550
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFE89FDB5D0
    }

    public class StandardDsaEncoding : Object
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x7FFE89FDB610
        public void Encode(){} // RVA: 0x7FFE89FDB920
        public void CheckValue(){} // RVA: 0x7FFE89FDBAB0
        public void DecodeValue(){} // RVA: 0x7FFE89FDBB50
        public void EncodeValue(){} // RVA: 0x7FFE89FDBC30
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89FDBD50
    }

    public class X931Signer : Object
    {
        public int TRAILER_IMPLICIT;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FDC070 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE89FDBFA0
        public void Init(){} // RVA: 0x7FFE89FDC210
        public void ClearBlock(){} // RVA: 0x7FFE89FD28C0
        public void Update(){} // RVA: 0x7FFE89FDC430
        public void BlockUpdate(){} // RVA: 0x7FFE89FDC490
        public void Reset(){} // RVA: 0x7FFE89FDC520
        public void GenerateSignature(){} // RVA: 0x7FFE89FDC570
        public void CreateSignatureBlock(){} // RVA: 0x7FFE89FDC6E0
        public void VerifySignature(){} // RVA: 0x7FFE89FDC890
    }

}