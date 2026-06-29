// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
// Classes: 26
// Methods: 211

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
{
    public class DsaDigestSigner : Object
    {
        public object dsa;
        public object digest;
        public object encoding;
        public object forSigning;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_AlgorithmName(){} // RVA: 0xA2077C0
        public void Init(){} // RVA: 0xA207870
        public void Update(){} // RVA: 0xA207AC0
        public void BlockUpdate(){} // RVA: 0xA207B20
        public void GenerateSignature(){} // RVA: 0xA207BB0
        public void VerifySignature(){} // RVA: 0xA207DB0
        public void Reset(){} // RVA: 0xA207F80
        public void GetOrder(){} // RVA: 0xA207FD0
    }

    public class DsaSigner : Object
    {
        public object kCalculator;
        public object key;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_AlgorithmName(){} // RVA: 0xA208120
        public void Init(){} // RVA: 0xA208160
        public void get_Order(){} // RVA: 0xA2085A0
        public void GenerateSignature(){} // RVA: 0xA2085D0
        public void VerifySignature(){} // RVA: 0xA208980
        public void CalculateE(){} // RVA: 0xA208BE0
        public void InitSecureRandom(){} // RVA: 0xA208CC0
    }

    public class ECDsaSigner : Object
    {
        public object Eight;
        public object kCalculator;
        public object key;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_AlgorithmName(){} // RVA: 0xA208DC0
        public void Init(){} // RVA: 0xA208E00
        public void get_Order(){} // RVA: 0xA209240
        public void GenerateSignature(){} // RVA: 0xA209270
        public void VerifySignature(){} // RVA: 0xA209840
        public void CalculateE(){} // RVA: 0xA209C80
        public void CreateBasePointMultiplier(){} // RVA: 0xA209D50
        public void GetDenominator(){} // RVA: 0xA209D90
        public void InitSecureRandom(){} // RVA: 0xA209E40
        public void .cctor(){} // RVA: 0xA209EB0
    }

    public class ECGost3410Signer : Object
    {
        public object key;
        public object random;
        public object forSigning;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x13F9400
        public void Init(){} // RVA: 0xA209F80
        public void get_Order(){} // RVA: 0xA20A400
        public void GenerateSignature(){} // RVA: 0xA20A430
        public void VerifySignature(){} // RVA: 0xA20A970
        public void CreateBasePointMultiplier(){} // RVA: 0xA20AD40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ECNRSigner : Object
    {
        public object forSigning;
        public object key;
        public object random;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA20AD80
        public void Init(){} // RVA: 0xA20ADC0
        public void get_Order(){} // RVA: 0xA209240
        public void GenerateSignature(){} // RVA: 0xA20B240
        public void VerifySignature(){} // RVA: 0xA20B840
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Ed25519Signer : Object
    {
        public object buffer;
        public object forSigning;
        public object privateKey;
        public object publicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA20D330
        public void get_AlgorithmName(){} // RVA: 0xA20D3D0
        public void Init(){} // RVA: 0xA20D410
        public void Update(){} // RVA: 0x68D2080
        public void BlockUpdate(){} // RVA: 0x68D2140
        public void GenerateSignature(){} // RVA: 0xA20D6C0
        public void VerifySignature(){} // RVA: 0xA20D750
        public void Reset(){} // RVA: 0xA20C1A0
    }

    public class Ed25519ctxSigner : Object
    {
        public object buffer;
        public object context;
        public object forSigning;
        public object privateKey;
        public object publicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA20BBC0
        public void get_AlgorithmName(){} // RVA: 0xA20BD70
        public void Init(){} // RVA: 0xA20BDB0
        public void Update(){} // RVA: 0x68D2080
        public void BlockUpdate(){} // RVA: 0x68D2140
        public void GenerateSignature(){} // RVA: 0xA20C060
        public void VerifySignature(){} // RVA: 0xA20C100
        public void Reset(){} // RVA: 0xA20C1A0
    }

    public class Ed25519phSigner : Object
    {
        public object prehash;
        public object context;
        public object forSigning;
        public object privateKey;
        public object publicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA20C800
        public void get_AlgorithmName(){} // RVA: 0xA20C9E0
        public void Init(){} // RVA: 0xA20CA20
        public void Update(){} // RVA: 0xA20CCF0
        public void BlockUpdate(){} // RVA: 0xA20CD50
        public void GenerateSignature(){} // RVA: 0xA20CDE0
        public void VerifySignature(){} // RVA: 0xA20D050
        public void Reset(){} // RVA: 0xA20D2E0
    }

    public class Ed448Signer : Object
    {
        public object buffer;
        public object context;
        public object forSigning;
        public object privateKey;
        public object publicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA20E7E0
        public void get_AlgorithmName(){} // RVA: 0xA20E990
        public void Init(){} // RVA: 0xA20E9D0
        public void Update(){} // RVA: 0x68D2080
        public void BlockUpdate(){} // RVA: 0x68D2140
        public void GenerateSignature(){} // RVA: 0xA20EC80
        public void VerifySignature(){} // RVA: 0xA20ED20
        public void Reset(){} // RVA: 0xA20C1A0
    }

    public class Ed448phSigner : Object
    {
        public object prehash;
        public object context;
        public object forSigning;
        public object privateKey;
        public object publicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA20DCB0
        public void get_AlgorithmName(){} // RVA: 0xA20DE90
        public void Init(){} // RVA: 0xA20DED0
        public void Update(){} // RVA: 0xA20E1A0
        public void BlockUpdate(){} // RVA: 0xA20E200
        public void GenerateSignature(){} // RVA: 0xA20E290
        public void VerifySignature(){} // RVA: 0xA20E500
        public void Reset(){} // RVA: 0xA20E790
    }

    public class GenericSigner : Object
    {
        public object engine;
        public object digest;
        public object forSigning;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_AlgorithmName(){} // RVA: 0xA20F290
        public void Init(){} // RVA: 0xA20F3E0
        public void Update(){} // RVA: 0xA20F630
        public void BlockUpdate(){} // RVA: 0xA20F690
        public void GenerateSignature(){} // RVA: 0xA20F720
        public void VerifySignature(){} // RVA: 0xA20F870
        public void Reset(){} // RVA: 0xA20FAD0
    }

    public class Gost3410DigestSigner : Object
    {
        public object digest;
        public object dsaSigner;
        public object size;
        public object halfSize;
        public object forSigning;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA20FB20
        public void get_AlgorithmName(){} // RVA: 0xA20FC40
        public void Init(){} // RVA: 0xA20FCF0
        public void Update(){} // RVA: 0xA20FF40
        public void BlockUpdate(){} // RVA: 0xA20FFA0
        public void GenerateSignature(){} // RVA: 0xA210030
        public void VerifySignature(){} // RVA: 0xA2102A0
        public void Reset(){} // RVA: 0xA2104D0
    }

    public class Gost3410Signer : Object
    {
        public object key;
        public object random;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA210520
        public void Init(){} // RVA: 0xA210560
        public void get_Order(){} // RVA: 0xA2109D0
        public void GenerateSignature(){} // RVA: 0xA210A00
        public void VerifySignature(){} // RVA: 0xA210DD0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HMacDsaKCalculator : Object
    {
        public object hMac;
        public object K;
        public object V;
        public object n;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2110F0
        public void get_IsDeterministic(){} // RVA: 0xC2E4C0
        public void Init(){} // RVA: 0xA211310
        public void NextK(){} // RVA: 0xA2118F0
        public void BitsToInt(){} // RVA: 0xA211C60
    }

    public class IDsaEncoding
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x87C5F0
        public void Encode(){} // RVA: 0x882090
    }

    public class IDsaKCalculator
    {
        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0x87D280
        public void Init(){} // RVA: 0x8954D0
        public void NextK(){} // RVA: 0x87C0A0
    }

    public class Iso9796d2PssSigner : Object
    {
        public object TrailerImplicit;
        public object TrailerRipeMD160;
        public object TrailerRipeMD128;
        public object TrailerSha1;
        public object TrailerSha256;
        public object TrailerSha512;
        public object TrailerSha384;
        public object TrailerWhirlpool;
        public object digest;
        public object cipher;
        public object random;
        public object standardSalt;
        public object hLen;
        public object trailer;
        public object keyBits;
        public object block;
        public object mBuf;
        public object messageLength;
        public object saltLength;
        public object fullMessage;
        public object recoveredMessage;
        public object preSig;
        public object preBlock;
        public object preMStart;
        public object preTLength;

        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0xBE2C60
        public void .ctor(){} // RVA: 0xA211F20
        public void get_AlgorithmName(){} // RVA: 0xA211F40
        public void Init(){} // RVA: 0xA211FB0
        public void IsSameAs(){} // RVA: 0xA212580
        public void ClearBlock(){} // RVA: 0xA212610
        public void UpdateWithRecoveredMessage(){} // RVA: 0xA212640
        public void Update(){} // RVA: 0xA212B90
        public void BlockUpdate(){} // RVA: 0xA212C40
        public void Reset(){} // RVA: 0xA212D40
        public void GenerateSignature(){} // RVA: 0xA212EF0
        public void VerifySignature(){} // RVA: 0xA2133B0
        public void HasFullMessage(){} // RVA: 0xE3F480
        public void ItoOSP(){} // RVA: 0xA213980
        public void LtoOSP(){} // RVA: 0xA2139E0
        public void MaskGeneratorFunction1(){} // RVA: 0xA213A90
    }

    public class Iso9796d2Signer : Object
    {
        public object TrailerImplicit;
        public object TrailerRipeMD160;
        public object TrailerRipeMD128;
        public object TrailerSha1;
        public object TrailerSha256;
        public object TrailerSha512;
        public object TrailerSha384;
        public object TrailerWhirlpool;
        public object digest;
        public object cipher;
        public object trailer;
        public object keyBits;
        public object block;
        public object mBuf;
        public object messageLength;
        public object fullMessage;
        public object recoveredMessage;
        public object preSig;
        public object preBlock;

        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xA2140B0
        public void get_AlgorithmName(){} // RVA: 0xA2140D0
        public void Init(){} // RVA: 0xA214140
        public void IsSameAs(){} // RVA: 0xA2143F0
        public void ClearBlock(){} // RVA: 0xA212610
        public void UpdateWithRecoveredMessage(){} // RVA: 0xA2144B0
        public void Update(){} // RVA: 0xA214930
        public void BlockUpdate(){} // RVA: 0xA2149C0
        public void Reset(){} // RVA: 0xA214AB0
        public void GenerateSignature(){} // RVA: 0xA214C70
        public void VerifySignature(){} // RVA: 0xA214F50
        public void ReturnFalse(){} // RVA: 0xA215730
        public void HasFullMessage(){} // RVA: 0xCB23E0
    }

    public class IsoTrailers : Object
    {
        public object TRAILER_IMPLICIT;
        public object TRAILER_RIPEMD160;
        public object TRAILER_RIPEMD128;
        public object TRAILER_SHA1;
        public object TRAILER_SHA256;
        public object TRAILER_SHA512;
        public object TRAILER_SHA384;
        public object TRAILER_WHIRLPOOL;
        public object TRAILER_SHA224;
        public object TRAILER_SHA512_224;
        public object TRAILER_SHA512_256;
        public object trailerMap;

        // ── Methods ──
        public void CreateTrailerMap(){} // RVA: 0xA215780
        public void GetTrailer(){} // RVA: 0xA215BA0
        public void NoTrailerAvailable(){} // RVA: 0xA215C90
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA215D50
    }

    public class PlainDsaEncoding : Object
    {
        public object Instance;

        // ── Methods ──
        public void Decode(){} // RVA: 0xA215DF0
        public void Encode(){} // RVA: 0xA215FD0
        public void CheckValue(){} // RVA: 0xA2160D0
        public void DecodeValue(){} // RVA: 0xA216170
        public void EncodeValue(){} // RVA: 0xA216230
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA216380
    }

    public class PssSigner : Object
    {
        public object TrailerImplicit;
        public object contentDigest1;
        public object contentDigest2;
        public object mgfDigest;
        public object cipher;
        public object random;
        public object hLen;
        public object mgfhLen;
        public object sLen;
        public object sSet;
        public object emBits;
        public object salt;
        public object mDash;
        public object block;
        public object trailer;

        // ── Methods ──
        public void CreateRawSigner(){} // RVA: 0xA216520
        public void .ctor(){} // RVA: 0xA216810
        public void get_AlgorithmName(){} // RVA: 0xA216B50
        public void Init(){} // RVA: 0xA216BC0
        public void ClearBlock(){} // RVA: 0xA212610
        public void Update(){} // RVA: 0xA216F80
        public void BlockUpdate(){} // RVA: 0xA216FE0
        public void Reset(){} // RVA: 0xA217070
        public void GenerateSignature(){} // RVA: 0xA2170C0
        public void VerifySignature(){} // RVA: 0xA2173F0
        public void ItoOSP(){} // RVA: 0xA213980
        public void MaskGeneratorFunction1(){} // RVA: 0xA217810
    }

    public class RandomDsaKCalculator : Object
    {
        public object q;
        public object random;

        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0xB43320
        public void Init(){} // RVA: 0xA217C90
        public void NextK(){} // RVA: 0xA217CE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RsaDigestSigner : Object
    {
        public object rsaEngine;
        public object algId;
        public object digest;
        public object forSigning;
        public object oidMap;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA217D90
        public void .ctor(){} // RVA: 0xA218880
        public void get_AlgorithmName(){} // RVA: 0xA218A00
        public void Init(){} // RVA: 0xA218A70
        public void Update(){} // RVA: 0xA218CC0
        public void BlockUpdate(){} // RVA: 0xA218D20
        public void GenerateSignature(){} // RVA: 0xA218DB0
        public void VerifySignature(){} // RVA: 0xA218F00
        public void Reset(){} // RVA: 0xA219210
        public void DerEncode(){} // RVA: 0xA219260
    }

    public class SM2Signer : Object
    {
        public object kCalculator;
        public object digest;
        public object encoding;
        public object ecParams;
        public object pubPoint;
        public object ecKey;
        public object z;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2194A0
        public void get_AlgorithmName(){} // RVA: 0xA2195F0
        public void Init(){} // RVA: 0xA219630
        public void Update(){} // RVA: 0xA219F40
        public void BlockUpdate(){} // RVA: 0xA219FA0
        public void VerifySignature(){} // RVA: 0xA21A980
        public void Reset(){} // RVA: 0xA21A0E0
        public void GenerateSignature(){} // RVA: 0xA21A170
        public void GetZ(){} // RVA: 0xA21AC70
        public void AddUserID(){} // RVA: 0xA21B1E0
        public void AddFieldElement(){} // RVA: 0xA21B2A0
        public void CalculateE(){} // RVA: 0xA21B330
        public void CreateBasePointMultiplier(){} // RVA: 0xA21B3B0
    }

    public class StandardDsaEncoding : Object
    {
        public object Instance;

        // ── Methods ──
        public void Decode(){} // RVA: 0xA21B3F0
        public void Encode(){} // RVA: 0xA21B700
        public void CheckValue(){} // RVA: 0xA21B890
        public void DecodeValue(){} // RVA: 0xA21B930
        public void EncodeValue(){} // RVA: 0xA21BA10
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA21BB30
    }

    public class X931Signer : Object
    {
        public object TRAILER_IMPLICIT;
        public object TRAILER_RIPEMD160;
        public object TRAILER_RIPEMD128;
        public object TRAILER_SHA1;
        public object TRAILER_SHA256;
        public object TRAILER_SHA512;
        public object TRAILER_SHA384;
        public object TRAILER_WHIRLPOOL;
        public object TRAILER_SHA224;
        public object digest;
        public object cipher;
        public object kParam;
        public object trailer;
        public object keyBits;
        public object block;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA21BE50
        public void get_AlgorithmName(){} // RVA: 0xA21BD80
        public void Init(){} // RVA: 0xA21BFF0
        public void ClearBlock(){} // RVA: 0xA212610
        public void Update(){} // RVA: 0xA21C210
        public void BlockUpdate(){} // RVA: 0xA21C270
        public void Reset(){} // RVA: 0xA21C300
        public void GenerateSignature(){} // RVA: 0xA21C350
        public void CreateSignatureBlock(){} // RVA: 0xA21C4C0
        public void VerifySignature(){} // RVA: 0xA21C650
    }

}