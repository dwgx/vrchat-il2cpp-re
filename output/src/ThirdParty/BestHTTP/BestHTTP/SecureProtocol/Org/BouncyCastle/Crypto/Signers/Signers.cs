// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
// Classes: 26
// Methods: 211

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
{
    public class DsaDigestSigner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void get_AlgorithmName(){} // RVA: 0x7B139C0A0
        public void Init(){} // RVA: 0x7B139C150
        public void Update(){} // RVA: 0x7B139C3A0
        public void BlockUpdate(){} // RVA: 0x7B139C400
        public void GenerateSignature(){} // RVA: 0x7B139C490
        public void VerifySignature(){} // RVA: 0x7B139C690
        public void Reset(){} // RVA: 0x7B139C860
        public void GetOrder(){} // RVA: 0x7B139C8B0
    }

    public class DsaSigner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_AlgorithmName(){} // RVA: 0x7B139CA00
        public void Init(){} // RVA: 0x7B139CA40
        public void get_Order(){} // RVA: 0x7B139CE80
        public void GenerateSignature(){} // RVA: 0x7B139CEB0
        public void VerifySignature(){} // RVA: 0x7B139D260
        public void CalculateE(){} // RVA: 0x7B139D4C0
        public void InitSecureRandom(){} // RVA: 0x7B139D5A0
    }

    public class ECDsaSigner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_AlgorithmName(){} // RVA: 0x7B139D6A0
        public void Init(){} // RVA: 0x7B139D6E0
        public void get_Order(){} // RVA: 0x7B139DB20
        public void GenerateSignature(){} // RVA: 0x7B139DB50
        public void VerifySignature(){} // RVA: 0x7B139E120
        public void CalculateE(){} // RVA: 0x7B139E560
        public void CreateBasePointMultiplier(){} // RVA: 0x7B139E630
        public void GetDenominator(){} // RVA: 0x7B139E670
        public void InitSecureRandom(){} // RVA: 0x7B139E720
        public void .cctor(){} // RVA: 0x7B139E790
    }

    public class ECGost3410Signer : Object
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A88F4330
        public void Init(){} // RVA: 0x7B139E860
        public void get_Order(){} // RVA: 0x7B139ECE0
        public void GenerateSignature(){} // RVA: 0x7B139ED10
        public void VerifySignature(){} // RVA: 0x7B139F250
        public void CreateBasePointMultiplier(){} // RVA: 0x7B139F620
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ECNRSigner : Object
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B139F660
        public void Init(){} // RVA: 0x7B139F6A0
        public void get_Order(){} // RVA: 0x7B139DB20
        public void GenerateSignature(){} // RVA: 0x7B139FB20
        public void VerifySignature(){} // RVA: 0x7B13A0120
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Ed25519Signer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13A1C10
        public void get_AlgorithmName(){} // RVA: 0x7B13A1CB0
        public void Init(){} // RVA: 0x7B13A1CF0
        public void Update(){} // RVA: 0x7ADC47380
        public void BlockUpdate(){} // RVA: 0x7ADC47440
        public void GenerateSignature(){} // RVA: 0x7B13A1FA0
        public void VerifySignature(){} // RVA: 0x7B13A2030
        public void Reset(){} // RVA: 0x7B13A0A80
    }

    public class Ed25519ctxSigner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13A04A0
        public void get_AlgorithmName(){} // RVA: 0x7B13A0650
        public void Init(){} // RVA: 0x7B13A0690
        public void Update(){} // RVA: 0x7ADC47380
        public void BlockUpdate(){} // RVA: 0x7ADC47440
        public void GenerateSignature(){} // RVA: 0x7B13A0940
        public void VerifySignature(){} // RVA: 0x7B13A09E0
        public void Reset(){} // RVA: 0x7B13A0A80
    }

    public class Ed25519phSigner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13A10E0
        public void get_AlgorithmName(){} // RVA: 0x7B13A12C0
        public void Init(){} // RVA: 0x7B13A1300
        public void Update(){} // RVA: 0x7B13A15D0
        public void BlockUpdate(){} // RVA: 0x7B13A1630
        public void GenerateSignature(){} // RVA: 0x7B13A16C0
        public void VerifySignature(){} // RVA: 0x7B13A1930
        public void Reset(){} // RVA: 0x7B13A1BC0
    }

    public class Ed448Signer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13A30C0
        public void get_AlgorithmName(){} // RVA: 0x7B13A3270
        public void Init(){} // RVA: 0x7B13A32B0
        public void Update(){} // RVA: 0x7ADC47380
        public void BlockUpdate(){} // RVA: 0x7ADC47440
        public void GenerateSignature(){} // RVA: 0x7B13A3560
        public void VerifySignature(){} // RVA: 0x7B13A3600
        public void Reset(){} // RVA: 0x7B13A0A80
    }

    public class Ed448phSigner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13A2590
        public void get_AlgorithmName(){} // RVA: 0x7B13A2770
        public void Init(){} // RVA: 0x7B13A27B0
        public void Update(){} // RVA: 0x7B13A2A80
        public void BlockUpdate(){} // RVA: 0x7B13A2AE0
        public void GenerateSignature(){} // RVA: 0x7B13A2B70
        public void VerifySignature(){} // RVA: 0x7B13A2DE0
        public void Reset(){} // RVA: 0x7B13A3070
    }

    public class GenericSigner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_AlgorithmName(){} // RVA: 0x7B13A3B70
        public void Init(){} // RVA: 0x7B13A3CC0
        public void Update(){} // RVA: 0x7B13A3F10
        public void BlockUpdate(){} // RVA: 0x7B13A3F70
        public void GenerateSignature(){} // RVA: 0x7B13A4000
        public void VerifySignature(){} // RVA: 0x7B13A4150
        public void Reset(){} // RVA: 0x7B13A43B0
    }

    public class Gost3410DigestSigner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13A4400
        public void get_AlgorithmName(){} // RVA: 0x7B13A4520
        public void Init(){} // RVA: 0x7B13A45D0
        public void Update(){} // RVA: 0x7B13A4820
        public void BlockUpdate(){} // RVA: 0x7B13A4880
        public void GenerateSignature(){} // RVA: 0x7B13A4910
        public void VerifySignature(){} // RVA: 0x7B13A4B80
        public void Reset(){} // RVA: 0x7B13A4DB0
    }

    public class Gost3410Signer : Object
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B13A4E00
        public void Init(){} // RVA: 0x7B13A4E40
        public void get_Order(){} // RVA: 0x7B13A52B0
        public void GenerateSignature(){} // RVA: 0x7B13A52E0
        public void VerifySignature(){} // RVA: 0x7B13A56B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HMacDsaKCalculator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13A59D0
        public void get_IsDeterministic(){} // RVA: 0x7A81BD750
        public void Init(){} // RVA: 0x7B13A5BF0
        public void NextK(){} // RVA: 0x7B13A61D0
        public void BitsToInt(){} // RVA: 0x7B13A6540
    }

    public class IDsaEncoding
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x7A7E00BD0
        public void Encode(){} // RVA: 0x7A7E06710
    }

    public class IDsaKCalculator
    {
        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0x7A7E01900
        public void Init(){} // RVA: 0x7A7E1DDC0
        public void NextK(){} // RVA: 0x7A7E00680
    }

    public class Iso9796d2PssSigner : Object
    {
        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0x7A8175DF0
        public void .ctor(){} // RVA: 0x7B13A6800
        public void get_AlgorithmName(){} // RVA: 0x7B13A6820
        public void Init(){} // RVA: 0x7B13A6890
        public void IsSameAs(){} // RVA: 0x7B13A6E60
        public void ClearBlock(){} // RVA: 0x7B13A6EF0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7B13A6F20
        public void Update(){} // RVA: 0x7B13A7470
        public void BlockUpdate(){} // RVA: 0x7B13A7520
        public void Reset(){} // RVA: 0x7B13A7620
        public void GenerateSignature(){} // RVA: 0x7B13A77D0
        public void VerifySignature(){} // RVA: 0x7B13A7C90
        public void HasFullMessage(){} // RVA: 0x7A8359360
        public void ItoOSP(){} // RVA: 0x7B13A8260
        public void LtoOSP(){} // RVA: 0x7B13A82C0
        public void MaskGeneratorFunction1(){} // RVA: 0x7B13A8370
    }

    public class Iso9796d2Signer : Object
    {
        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7B13A8990
        public void get_AlgorithmName(){} // RVA: 0x7B13A89B0
        public void Init(){} // RVA: 0x7B13A8A20
        public void IsSameAs(){} // RVA: 0x7B13A8CD0
        public void ClearBlock(){} // RVA: 0x7B13A6EF0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7B13A8D90
        public void Update(){} // RVA: 0x7B13A9210
        public void BlockUpdate(){} // RVA: 0x7B13A92A0
        public void Reset(){} // RVA: 0x7B13A9390
        public void GenerateSignature(){} // RVA: 0x7B13A9550
        public void VerifySignature(){} // RVA: 0x7B13A9830
        public void ReturnFalse(){} // RVA: 0x7B13AA010
        public void HasFullMessage(){} // RVA: 0x7A823D790
    }

    public class IsoTrailers : Object
    {
        // ── Methods ──
        public void CreateTrailerMap(){} // RVA: 0x7B13AA060
        public void GetTrailer(){} // RVA: 0x7B13AA490
        public void NoTrailerAvailable(){} // RVA: 0x7B13AA590
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B13AA650
    }

    public class PlainDsaEncoding : Object
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x7B13AA6F0
        public void Encode(){} // RVA: 0x7B13AA8D0
        public void CheckValue(){} // RVA: 0x7B13AA9D0
        public void DecodeValue(){} // RVA: 0x7B13AAA70
        public void EncodeValue(){} // RVA: 0x7B13AAB30
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B13AAC80
    }

    public class PssSigner : Object
    {
        // ── Methods ──
        public void CreateRawSigner(){} // RVA: 0x7B13AAE20
        public void .ctor(){} // RVA: 0x7B13AB110
        public void get_AlgorithmName(){} // RVA: 0x7B13AB450
        public void Init(){} // RVA: 0x7B13AB4C0
        public void ClearBlock(){} // RVA: 0x7B13A6EF0
        public void Update(){} // RVA: 0x7B13AB880
        public void BlockUpdate(){} // RVA: 0x7B13AB8E0
        public void Reset(){} // RVA: 0x7B13AB970
        public void GenerateSignature(){} // RVA: 0x7B13AB9C0
        public void VerifySignature(){} // RVA: 0x7B13ABCF0
        public void ItoOSP(){} // RVA: 0x7B13A8260
        public void MaskGeneratorFunction1(){} // RVA: 0x7B13AC110
    }

    public class RandomDsaKCalculator : Object
    {
        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0x7A80D7320
        public void Init(){} // RVA: 0x7B13AC590
        public void NextK(){} // RVA: 0x7B13AC5E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RsaDigestSigner : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B13AC690
        public void .ctor(){} // RVA: 0x7B13AD180
        public void get_AlgorithmName(){} // RVA: 0x7B13AD300
        public void Init(){} // RVA: 0x7B13AD370
        public void Update(){} // RVA: 0x7B13AD5C0
        public void BlockUpdate(){} // RVA: 0x7B13AD620
        public void GenerateSignature(){} // RVA: 0x7B13AD6B0
        public void VerifySignature(){} // RVA: 0x7B13AD800
        public void Reset(){} // RVA: 0x7B13ADB10
        public void DerEncode(){} // RVA: 0x7B13ADB60
    }

    public class SM2Signer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13ADDA0
        public void get_AlgorithmName(){} // RVA: 0x7B13ADEF0
        public void Init(){} // RVA: 0x7B13ADF30
        public void Update(){} // RVA: 0x7B13AE840
        public void BlockUpdate(){} // RVA: 0x7B13AE8A0
        public void VerifySignature(){} // RVA: 0x7B13AF280
        public void Reset(){} // RVA: 0x7B13AE9E0
        public void GenerateSignature(){} // RVA: 0x7B13AEA70
        public void GetZ(){} // RVA: 0x7B13AF570
        public void AddUserID(){} // RVA: 0x7B13AFAE0
        public void AddFieldElement(){} // RVA: 0x7B13AFBA0
        public void CalculateE(){} // RVA: 0x7B13AFC30
        public void CreateBasePointMultiplier(){} // RVA: 0x7B13AFCB0
    }

    public class StandardDsaEncoding : Object
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x7B13AFCF0
        public void Encode(){} // RVA: 0x7B13B0000
        public void CheckValue(){} // RVA: 0x7B13B0190
        public void DecodeValue(){} // RVA: 0x7B13B0230
        public void EncodeValue(){} // RVA: 0x7B13B0310
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B13B0430
    }

    public class X931Signer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B0750
        public void get_AlgorithmName(){} // RVA: 0x7B13B0680
        public void Init(){} // RVA: 0x7B13B08F0
        public void ClearBlock(){} // RVA: 0x7B13A6EF0
        public void Update(){} // RVA: 0x7B13B0B10
        public void BlockUpdate(){} // RVA: 0x7B13B0B70
        public void Reset(){} // RVA: 0x7B13B0C00
        public void GenerateSignature(){} // RVA: 0x7B13B0C50
        public void CreateSignatureBlock(){} // RVA: 0x7B13B0DC0
        public void VerifySignature(){} // RVA: 0x7B13B0F50
    }

}