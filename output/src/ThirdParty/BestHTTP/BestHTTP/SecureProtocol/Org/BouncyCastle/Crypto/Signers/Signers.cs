// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
// Classes: 26
// Methods: 237

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
{
    public class DsaDigestSigner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9565540
        public void Init(){} // RVA: 0x95655F0
        public void Update(){} // RVA: 0x9565840
        public void BlockUpdate(){} // RVA: 0x95658A0
        public void GenerateSignature(){} // RVA: 0x9565930
        public void VerifySignature(){} // RVA: 0x9565B30
        public void Reset(){} // RVA: 0x9565D00
        public void GetOrder(){} // RVA: 0x9565D50
    }

    public class DsaSigner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9565EA0
        public void Init(){} // RVA: 0x9565EE0
        public void get_Order(){} // RVA: 0x9566320
        public void GenerateSignature(){} // RVA: 0x9566350
        public void VerifySignature(){} // RVA: 0x9566710
        public void CalculateE(){} // RVA: 0x9566970
        public void InitSecureRandom(){} // RVA: 0x9566A50
    }

    public class ECDsaSigner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9566B50
        public void Init(){} // RVA: 0x9566B90
        public void get_Order(){} // RVA: 0x9566FD0
        public void GenerateSignature(){} // RVA: 0x9567000
        public void VerifySignature(){} // RVA: 0x95675E0
        public void CalculateE(){} // RVA: 0x9567A20
        public void CreateBasePointMultiplier(){} // RVA: 0x9567AF0
        public void GetDenominator(){} // RVA: 0x9567B30
        public void InitSecureRandom(){} // RVA: 0x9567BE0
        public void .cctor(){} // RVA: 0x9567C50
    }

    public class ECGost3410Signer
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xB2EEA0
        public void Init(){} // RVA: 0x9567D20
        public void get_Order(){} // RVA: 0x95681A0
        public void GenerateSignature(){} // RVA: 0x95681D0
        public void VerifySignature(){} // RVA: 0x9568710
        public void CreateBasePointMultiplier(){} // RVA: 0x9568AE0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ECNRSigner
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x9568B20
        public void Init(){} // RVA: 0x9568B60
        public void get_Order(){} // RVA: 0x9566FD0
        public void GenerateSignature(){} // RVA: 0x9568FE0
        public void VerifySignature(){} // RVA: 0x95695E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Ed25519Signer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x956B160
        public void get_AlgorithmName(){} // RVA: 0x956B200
        public void Init(){} // RVA: 0x956B240
        public void Update(){} // RVA: 0x5E58960
        public void BlockUpdate(){} // RVA: 0x5E58A20
        public void GenerateSignature(){} // RVA: 0x956B4F0
        public void VerifySignature(){} // RVA: 0x956B580
        public void Reset(){} // RVA: 0x9569F40
    }

    public class Ed25519ctxSigner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9569960
        public void get_AlgorithmName(){} // RVA: 0x9569B10
        public void Init(){} // RVA: 0x9569B50
        public void Update(){} // RVA: 0x5E58960
        public void BlockUpdate(){} // RVA: 0x5E58A20
        public void GenerateSignature(){} // RVA: 0x9569E00
        public void VerifySignature(){} // RVA: 0x9569EA0
        public void Reset(){} // RVA: 0x9569F40
    }

    public class Ed25519phSigner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x956A630
        public void get_AlgorithmName(){} // RVA: 0x956A810
        public void Init(){} // RVA: 0x956A850
        public void Update(){} // RVA: 0x956AB20
        public void BlockUpdate(){} // RVA: 0x956AB80
        public void GenerateSignature(){} // RVA: 0x956AC10
        public void VerifySignature(){} // RVA: 0x956AE80
        public void Reset(){} // RVA: 0x956B110
    }

    public class Ed448Signer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x956C670
        public void get_AlgorithmName(){} // RVA: 0x956C820
        public void Init(){} // RVA: 0x956C860
        public void Update(){} // RVA: 0x5E58960
        public void BlockUpdate(){} // RVA: 0x5E58A20
        public void GenerateSignature(){} // RVA: 0x956CB10
        public void VerifySignature(){} // RVA: 0x956CBB0
        public void Reset(){} // RVA: 0x9569F40
    }

    public class Ed448phSigner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x956BB40
        public void get_AlgorithmName(){} // RVA: 0x956BD20
        public void Init(){} // RVA: 0x956BD60
        public void Update(){} // RVA: 0x956C030
        public void BlockUpdate(){} // RVA: 0x956C090
        public void GenerateSignature(){} // RVA: 0x956C120
        public void VerifySignature(){} // RVA: 0x956C390
        public void Reset(){} // RVA: 0x956C620
    }

    public class GenericSigner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_AlgorithmName(){} // RVA: 0x956D190
        public void Init(){} // RVA: 0x956D2E0
        public void Update(){} // RVA: 0x956D530
        public void BlockUpdate(){} // RVA: 0x956D590
        public void GenerateSignature(){} // RVA: 0x956D620
        public void VerifySignature(){} // RVA: 0x956D770
        public void Reset(){} // RVA: 0x956D9D0
    }

    public class Gost3410DigestSigner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x956DA20
        public void get_AlgorithmName(){} // RVA: 0x956DB40
        public void Init(){} // RVA: 0x956DBF0
        public void Update(){} // RVA: 0x956DE40
        public void BlockUpdate(){} // RVA: 0x956DEA0
        public void GenerateSignature(){} // RVA: 0x956DF30
        public void VerifySignature(){} // RVA: 0x956E1A0
        public void Reset(){} // RVA: 0x956E3D0
    }

    public class Gost3410Signer
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x956E420
        public void Init(){} // RVA: 0x956E460
        public void get_Order(){} // RVA: 0x956E8D0
        public void GenerateSignature(){} // RVA: 0x956E900
        public void VerifySignature(){} // RVA: 0x956ECE0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HMacDsaKCalculator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x956F000
        public void get_IsDeterministic(){} // RVA: 0x3C2850
        public void Init(){} // RVA: 0x956F220 | overloaded x2
        public void NextK(){} // RVA: 0x956F7F0
        public void BitsToInt(){} // RVA: 0x956FB60
    }

    public class IDsaEncoding
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x1E6A0
        public void Encode(){} // RVA: 0x1EE30
    }

    public class IDsaKCalculator
    {
        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0xDBE0
        public void Init(){} // RVA: 0x2F090 | overloaded x2
        public void NextK(){} // RVA: 0xCD60
    }

    public class Iso9796d2PssSigner
    {
        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0x37B370
        public void .ctor(){} // RVA: 0x956FE20 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x956FE40
        public void Init(){} // RVA: 0x956FEB0
        public void IsSameAs(){} // RVA: 0x9570470
        public void ClearBlock(){} // RVA: 0x95704F0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x9570520
        public void Update(){} // RVA: 0x9570A40
        public void BlockUpdate(){} // RVA: 0x9570AF0
        public void Reset(){} // RVA: 0x9570BD0
        public void GenerateSignature(){} // RVA: 0x9570D80
        public void VerifySignature(){} // RVA: 0x9571240
        public void HasFullMessage(){} // RVA: 0x59FF30
        public void ItoOSP(){} // RVA: 0x95717E0
        public void LtoOSP(){} // RVA: 0x9571840
        public void MaskGeneratorFunction1(){} // RVA: 0x95718F0
    }

    public class Iso9796d2Signer
    {
        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x9571F10 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9571F30
        public void Init(){} // RVA: 0x9571FA0
        public void IsSameAs(){} // RVA: 0x9572260
        public void ClearBlock(){} // RVA: 0x95704F0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x9572330
        public void Update(){} // RVA: 0x95727B0
        public void BlockUpdate(){} // RVA: 0x9572840
        public void Reset(){} // RVA: 0x9572920
        public void GenerateSignature(){} // RVA: 0x9572AE0
        public void VerifySignature(){} // RVA: 0x9572DD0
        public void ReturnFalse(){} // RVA: 0x95735A0
        public void HasFullMessage(){} // RVA: 0x4424E0
    }

    public class IsoTrailers
    {
        // ── Methods ──
        public void CreateTrailerMap(){} // RVA: 0x95735F0
        public void GetTrailer(){} // RVA: 0x9573A20
        public void NoTrailerAvailable(){} // RVA: 0x9573B20
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9573BE0
    }

    public class PlainDsaEncoding
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x9573C80
        public void Encode(){} // RVA: 0x9573E60
        public void CheckValue(){} // RVA: 0x9573F60
        public void DecodeValue(){} // RVA: 0x9574000
        public void EncodeValue(){} // RVA: 0x95740C0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9574210
    }

    public class PssSigner
    {
        // ── Methods ──
        public void CreateRawSigner(){} // RVA: 0x95743B0 | overloaded x2
        public void .ctor(){} // RVA: 0x95746A0 | overloaded x8
        public void get_AlgorithmName(){} // RVA: 0x95749D0
        public void Init(){} // RVA: 0x9574A40
        public void ClearBlock(){} // RVA: 0x95704F0
        public void Update(){} // RVA: 0x9574DF0
        public void BlockUpdate(){} // RVA: 0x9574E50
        public void Reset(){} // RVA: 0x9574EE0
        public void GenerateSignature(){} // RVA: 0x9574F30
        public void VerifySignature(){} // RVA: 0x9575270
        public void ItoOSP(){} // RVA: 0x95717E0
        public void MaskGeneratorFunction1(){} // RVA: 0x9575690
    }

    public class RandomDsaKCalculator
    {
        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0x2DD320
        public void Init(){} // RVA: 0x9575B10 | overloaded x2
        public void NextK(){} // RVA: 0x9575B60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RsaDigestSigner
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9575C10
        public void .ctor(){} // RVA: 0x9576700 | overloaded x6
        public void get_AlgorithmName(){} // RVA: 0x9576870
        public void Init(){} // RVA: 0x95768E0
        public void Update(){} // RVA: 0x9576B30
        public void BlockUpdate(){} // RVA: 0x9576B90
        public void GenerateSignature(){} // RVA: 0x9576C20
        public void VerifySignature(){} // RVA: 0x9576D70
        public void Reset(){} // RVA: 0x9577050
        public void DerEncode(){} // RVA: 0x95770A0
    }

    public class SM2Signer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95772E0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x9577430
        public void Init(){} // RVA: 0x9577470
        public void Update(){} // RVA: 0x9577D80
        public void BlockUpdate(){} // RVA: 0x9577DE0
        public void VerifySignature(){} // RVA: 0x95787D0 | overloaded x2
        public void Reset(){} // RVA: 0x9577F20
        public void GenerateSignature(){} // RVA: 0x9577FB0
        public void GetZ(){} // RVA: 0x9578AC0
        public void AddUserID(){} // RVA: 0x9579030
        public void AddFieldElement(){} // RVA: 0x95790F0
        public void CalculateE(){} // RVA: 0x9579180
        public void CreateBasePointMultiplier(){} // RVA: 0x9579200
    }

    public class StandardDsaEncoding
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x9579240
        public void Encode(){} // RVA: 0x9579550
        public void CheckValue(){} // RVA: 0x95796E0
        public void DecodeValue(){} // RVA: 0x9579780
        public void EncodeValue(){} // RVA: 0x9579860
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9579980
    }

    public class X931Signer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9579CA0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9579BD0
        public void Init(){} // RVA: 0x9579E40
        public void ClearBlock(){} // RVA: 0x95704F0
        public void Update(){} // RVA: 0x957A060
        public void BlockUpdate(){} // RVA: 0x957A0C0
        public void Reset(){} // RVA: 0x957A150
        public void GenerateSignature(){} // RVA: 0x957A1A0
        public void CreateSignatureBlock(){} // RVA: 0x957A310
        public void VerifySignature(){} // RVA: 0x957A4C0
    }

}