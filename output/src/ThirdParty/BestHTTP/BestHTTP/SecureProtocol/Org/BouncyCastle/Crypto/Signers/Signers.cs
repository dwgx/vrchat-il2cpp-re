// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
// Classes: 26
// Methods: 237

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
{
    public class DsaDigestSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDsa AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.IDsaEncoding encoding; // 0x20
        public bool forSigning; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB6E2F0
        public void Init(){} // RVA: 0x7FFACBB6E3A0
        public void Update(){} // RVA: 0x7FFACBB6E5F0
        public void BlockUpdate(){} // RVA: 0x7FFACBB6E650
        public void GenerateSignature(){} // RVA: 0x7FFACBB6E6E0
        public void VerifySignature(){} // RVA: 0x7FFACBB6E8E0
        public void Reset(){} // RVA: 0x7FFACBB6EAB0
        public void GetOrder(){} // RVA: 0x7FFACBB6EB00
    }

    public class DsaSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.IDsaKCalculator AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters Order; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB6EC50
        public void Init(){} // RVA: 0x7FFACBB6EC90
        public void get_Order(){} // RVA: 0x7FFACBB6F0D0
        public void GenerateSignature(){} // RVA: 0x7FFACBB6F100
        public void VerifySignature(){} // RVA: 0x7FFACBB6F4C0
        public void CalculateE(){} // RVA: 0x7FFACBB6F720
        public void InitSecureRandom(){} // RVA: 0x7FFACBB6F800
    }

    public class ECDsaSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger AlgorithmName;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.IDsaKCalculator Order; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECKeyParameters key; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB6F900
        public void Init(){} // RVA: 0x7FFACBB6F940
        public void get_Order(){} // RVA: 0x7FFACBB6FD80
        public void GenerateSignature(){} // RVA: 0x7FFACBB6FDB0
        public void VerifySignature(){} // RVA: 0x7FFACBB70390
        public void CalculateE(){} // RVA: 0x7FFACBB707D0
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFACBB708A0
        public void GetDenominator(){} // RVA: 0x7FFACBB708E0
        public void InitSecureRandom(){} // RVA: 0x7FFACBB70990
        public void .cctor(){} // RVA: 0x7FFACBB70A00
    }

    public class ECGost3410Signer : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECKeyParameters AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom Order; // 0x18
        public bool forSigning; // 0x20

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC356B610
        public void Init(){} // RVA: 0x7FFACBB70AD0
        public void get_Order(){} // RVA: 0x7FFACBB70F50
        public void GenerateSignature(){} // RVA: 0x7FFACBB70F80
        public void VerifySignature(){} // RVA: 0x7FFACBB714C0
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFACBB71890
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ECNRSigner : Object
    {
        public bool AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECKeyParameters Order; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x20

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB718D0
        public void Init(){} // RVA: 0x7FFACBB71910
        public void get_Order(){} // RVA: 0x7FFACBB6FD80
        public void GenerateSignature(){} // RVA: 0x7FFACBB71D90
        public void VerifySignature(){} // RVA: 0x7FFACBB72390
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Ed25519Signer : Object
    {
        public Buffer AlgorithmName; // 0x10
        public bool forSigning; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB73F10
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB73FB0
        public void Init(){} // RVA: 0x7FFACBB73FF0
        public void Update(){} // RVA: 0x7FFAC85EFFD0
        public void BlockUpdate(){} // RVA: 0x7FFAC85F0090
        public void GenerateSignature(){} // RVA: 0x7FFACBB742A0
        public void VerifySignature(){} // RVA: 0x7FFACBB74330
        public void Reset(){} // RVA: 0x7FFACBB72CF0
    }

    public class Ed25519ctxSigner : Object
    {
        public Buffer AlgorithmName; // 0x10
        public byte[] context; // 0x18
        public bool forSigning; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB72710
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB728C0
        public void Init(){} // RVA: 0x7FFACBB72900
        public void Update(){} // RVA: 0x7FFAC85EFFD0
        public void BlockUpdate(){} // RVA: 0x7FFAC85F0090
        public void GenerateSignature(){} // RVA: 0x7FFACBB72BB0
        public void VerifySignature(){} // RVA: 0x7FFACBB72C50
        public void Reset(){} // RVA: 0x7FFACBB72CF0
    }

    public class Ed25519phSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest AlgorithmName; // 0x10
        public byte[] context; // 0x18
        public bool forSigning; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB733E0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB735C0
        public void Init(){} // RVA: 0x7FFACBB73600
        public void Update(){} // RVA: 0x7FFACBB738D0
        public void BlockUpdate(){} // RVA: 0x7FFACBB73930
        public void GenerateSignature(){} // RVA: 0x7FFACBB739C0
        public void VerifySignature(){} // RVA: 0x7FFACBB73C30
        public void Reset(){} // RVA: 0x7FFACBB73EC0
    }

    public class Ed448Signer : Object
    {
        public Buffer AlgorithmName; // 0x10
        public byte[] context; // 0x18
        public bool forSigning; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters privateKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters publicKey; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB75420
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB755D0
        public void Init(){} // RVA: 0x7FFACBB75610
        public void Update(){} // RVA: 0x7FFAC85EFFD0
        public void BlockUpdate(){} // RVA: 0x7FFAC85F0090
        public void GenerateSignature(){} // RVA: 0x7FFACBB758C0
        public void VerifySignature(){} // RVA: 0x7FFACBB75960
        public void Reset(){} // RVA: 0x7FFACBB72CF0
    }

    public class Ed448phSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IXof AlgorithmName; // 0x10
        public byte[] context; // 0x18
        public bool forSigning; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters privateKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters publicKey; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB748F0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB74AD0
        public void Init(){} // RVA: 0x7FFACBB74B10
        public void Update(){} // RVA: 0x7FFACBB74DE0
        public void BlockUpdate(){} // RVA: 0x7FFACBB74E40
        public void GenerateSignature(){} // RVA: 0x7FFACBB74ED0
        public void VerifySignature(){} // RVA: 0x7FFACBB75140
        public void Reset(){} // RVA: 0x7FFACBB753D0
    }

    public class GenericSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x18
        public bool forSigning; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB75F40
        public void Init(){} // RVA: 0x7FFACBB76090
        public void Update(){} // RVA: 0x7FFACBB762E0
        public void BlockUpdate(){} // RVA: 0x7FFACBB76340
        public void GenerateSignature(){} // RVA: 0x7FFACBB763D0
        public void VerifySignature(){} // RVA: 0x7FFACBB76520
        public void Reset(){} // RVA: 0x7FFACBB76780
    }

    public class Gost3410DigestSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDsa dsaSigner; // 0x18
        public int size; // 0x20
        public int halfSize; // 0x24
        public bool forSigning; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB767D0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB768F0
        public void Init(){} // RVA: 0x7FFACBB769A0
        public void Update(){} // RVA: 0x7FFACBB76BF0
        public void BlockUpdate(){} // RVA: 0x7FFACBB76C50
        public void GenerateSignature(){} // RVA: 0x7FFACBB76CE0
        public void VerifySignature(){} // RVA: 0x7FFACBB76F50
        public void Reset(){} // RVA: 0x7FFACBB77180
    }

    public class Gost3410Signer : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom Order; // 0x18

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB771D0
        public void Init(){} // RVA: 0x7FFACBB77210
        public void get_Order(){} // RVA: 0x7FFACBB77680
        public void GenerateSignature(){} // RVA: 0x7FFACBB776B0
        public void VerifySignature(){} // RVA: 0x7FFACBB77A90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HMacDsaKCalculator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs.HMac IsDeterministic; // 0x10
        public byte[] K; // 0x18
        public byte[] V; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger n; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB77DB0
        public void get_IsDeterministic(){} // RVA: 0x7FFAC3006850
        public void Init(){} // RVA: 0x7FFACBB77FD0 | overloaded x2
        public void NextK(){} // RVA: 0x7FFACBB785A0
        public void BitsToInt(){} // RVA: 0x7FFACBB78910
    }

    public class IDsaEncoding
    {
        // ── Methods ──
        public void Decode(){} // RVA: 0x7FFAC2C6A6F0
        public void Encode(){} // RVA: 0x7FFAC2C6AE80
    }

    public class IDsaKCalculator
    {
        public object IsDeterministic;

        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0x7FFAC2C59D00
        public void Init(){} // RVA: 0x7FFAC2C7AF60 | overloaded x2
        public void NextK(){} // RVA: 0x7FFAC2C58E90
    }

    public class Iso9796d2PssSigner : Object
    {
        public int AlgorithmName;
        public int TrailerRipeMD160;
        public int TrailerRipeMD128;
        public int TrailerSha1;
        public int TrailerSha256;
        public int TrailerSha512;
        public int TrailerSha384;
        public int TrailerWhirlpool;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x20
        public byte[] standardSalt; // 0x28
        public int hLen; // 0x30
        public int trailer; // 0x34
        public int keyBits; // 0x38
        public byte[] block; // 0x40
        public byte[] mBuf; // 0x48
        public int messageLength; // 0x50
        public int saltLength; // 0x54
        public bool fullMessage; // 0x58
        public byte[] recoveredMessage; // 0x60
        public byte[] preSig; // 0x68
        public byte[] preBlock; // 0x70
        public int preMStart; // 0x78
        public int preTLength; // 0x7C

        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0x7FFAC2FBF370
        public void .ctor(){} // RVA: 0x7FFACBB78BD0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB78BF0
        public void Init(){} // RVA: 0x7FFACBB78C60
        public void IsSameAs(){} // RVA: 0x7FFACBB79220
        public void ClearBlock(){} // RVA: 0x7FFACBB792A0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7FFACBB792D0
        public void Update(){} // RVA: 0x7FFACBB797F0
        public void BlockUpdate(){} // RVA: 0x7FFACBB798A0
        public void Reset(){} // RVA: 0x7FFACBB79980
        public void GenerateSignature(){} // RVA: 0x7FFACBB79B30
        public void VerifySignature(){} // RVA: 0x7FFACBB79FF0
        public void HasFullMessage(){} // RVA: 0x7FFAC313F600
        public void ItoOSP(){} // RVA: 0x7FFACBB7A590
        public void LtoOSP(){} // RVA: 0x7FFACBB7A5F0
        public void MaskGeneratorFunction1(){} // RVA: 0x7FFACBB7A6A0
    }

    public class Iso9796d2Signer : Object
    {
        public int AlgorithmName;
        public int TrailerRipeMD160;
        public int TrailerRipeMD128;
        public int TrailerSha1;
        public int TrailerSha256;
        public int TrailerSha512;
        public int TrailerSha384;
        public int TrailerWhirlpool;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher; // 0x18
        public int trailer; // 0x20
        public int keyBits; // 0x24
        public byte[] block; // 0x28
        public byte[] mBuf; // 0x30
        public int messageLength; // 0x38
        public bool fullMessage; // 0x3C
        public byte[] recoveredMessage; // 0x40
        public byte[] preSig; // 0x48
        public byte[] preBlock; // 0x50

        // ── Methods ──
        public void GetRecoveredMessage(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFACBB7ACC0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB7ACE0
        public void Init(){} // RVA: 0x7FFACBB7AD50
        public void IsSameAs(){} // RVA: 0x7FFACBB7B010
        public void ClearBlock(){} // RVA: 0x7FFACBB792A0
        public void UpdateWithRecoveredMessage(){} // RVA: 0x7FFACBB7B0E0
        public void Update(){} // RVA: 0x7FFACBB7B560
        public void BlockUpdate(){} // RVA: 0x7FFACBB7B5F0
        public void Reset(){} // RVA: 0x7FFACBB7B6D0
        public void GenerateSignature(){} // RVA: 0x7FFACBB7B890
        public void VerifySignature(){} // RVA: 0x7FFACBB7BB80
        public void ReturnFalse(){} // RVA: 0x7FFACBB7C350
        public void HasFullMessage(){} // RVA: 0x7FFAC30864E0
    }

    public class IsoTrailers : Object
    {
        public int TRAILER_IMPLICIT;
        public int TRAILER_RIPEMD160;
        public int TRAILER_RIPEMD128;
        public int TRAILER_SHA1;
        public int TRAILER_SHA256;
        public int TRAILER_SHA512;
        public int TRAILER_SHA384;
        public int TRAILER_WHIRLPOOL;
        public int TRAILER_SHA224;
        public int TRAILER_SHA512_224;
        public int TRAILER_SHA512_256;
        public System.Collections.IDictionary trailerMap;

        // ── Methods ──
        public void CreateTrailerMap(){} // RVA: 0x7FFACBB7C3A0
        public void GetTrailer(){} // RVA: 0x7FFACBB7C7D0
        public void NoTrailerAvailable(){} // RVA: 0x7FFACBB7C8D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB7C990
    }

    public class PlainDsaEncoding : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.PlainDsaEncoding Instance;

        // ── Methods ──
        public void Decode(){} // RVA: 0x7FFACBB7CA30
        public void Encode(){} // RVA: 0x7FFACBB7CC10
        public void CheckValue(){} // RVA: 0x7FFACBB7CD10
        public void DecodeValue(){} // RVA: 0x7FFACBB7CDB0
        public void EncodeValue(){} // RVA: 0x7FFACBB7CE70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB7CFC0
    }

    public class PssSigner : Object
    {
        public byte AlgorithmName;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest contentDigest1; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest contentDigest2; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mgfDigest; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x30
        public int hLen; // 0x38
        public int mgfhLen; // 0x3C
        public int sLen; // 0x40
        public bool sSet; // 0x44
        public int emBits; // 0x48
        public byte[] salt; // 0x50
        public byte[] mDash; // 0x58
        public byte[] block; // 0x60
        public byte trailer; // 0x68

        // ── Methods ──
        public void CreateRawSigner(){} // RVA: 0x7FFACBB7D160 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBB7D450 | overloaded x8
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB7D780
        public void Init(){} // RVA: 0x7FFACBB7D7F0
        public void ClearBlock(){} // RVA: 0x7FFACBB792A0
        public void Update(){} // RVA: 0x7FFACBB7DBA0
        public void BlockUpdate(){} // RVA: 0x7FFACBB7DC00
        public void Reset(){} // RVA: 0x7FFACBB7DC90
        public void GenerateSignature(){} // RVA: 0x7FFACBB7DCE0
        public void VerifySignature(){} // RVA: 0x7FFACBB7E020
        public void ItoOSP(){} // RVA: 0x7FFACBB7A590
        public void MaskGeneratorFunction1(){} // RVA: 0x7FFACBB7E440
    }

    public class RandomDsaKCalculator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsDeterministic; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x18

        // ── Methods ──
        public void get_IsDeterministic(){} // RVA: 0x7FFAC2F21320
        public void Init(){} // RVA: 0x7FFACBB7E8C0 | overloaded x2
        public void NextK(){} // RVA: 0x7FFACBB7E910
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RsaDigestSigner : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x20
        public bool forSigning; // 0x28
        public System.Collections.IDictionary oidMap;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBB7E9C0
        public void .ctor(){} // RVA: 0x7FFACBB7F4B0 | overloaded x6
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB7F620
        public void Init(){} // RVA: 0x7FFACBB7F690
        public void Update(){} // RVA: 0x7FFACBB7F8E0
        public void BlockUpdate(){} // RVA: 0x7FFACBB7F940
        public void GenerateSignature(){} // RVA: 0x7FFACBB7F9D0
        public void VerifySignature(){} // RVA: 0x7FFACBB7FB20
        public void Reset(){} // RVA: 0x7FFACBB7FE00
        public void DerEncode(){} // RVA: 0x7FFACBB7FE50
    }

    public class SM2Signer : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.IDsaKCalculator AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.IDsaEncoding encoding; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParams; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint pubPoint; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECKeyParameters ecKey; // 0x38
        public byte[] z; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB80090 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB801E0
        public void Init(){} // RVA: 0x7FFACBB80220
        public void Update(){} // RVA: 0x7FFACBB80B30
        public void BlockUpdate(){} // RVA: 0x7FFACBB80B90
        public void VerifySignature(){} // RVA: 0x7FFACBB81580 | overloaded x2
        public void Reset(){} // RVA: 0x7FFACBB80CD0
        public void GenerateSignature(){} // RVA: 0x7FFACBB80D60
        public void GetZ(){} // RVA: 0x7FFACBB81870
        public void AddUserID(){} // RVA: 0x7FFACBB81DE0
        public void AddFieldElement(){} // RVA: 0x7FFACBB81EA0
        public void CalculateE(){} // RVA: 0x7FFACBB81F30
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFACBB81FB0
    }

    public class StandardDsaEncoding : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers.StandardDsaEncoding Instance;

        // ── Methods ──
        public void Decode(){} // RVA: 0x7FFACBB81FF0
        public void Encode(){} // RVA: 0x7FFACBB82300
        public void CheckValue(){} // RVA: 0x7FFACBB82490
        public void DecodeValue(){} // RVA: 0x7FFACBB82530
        public void EncodeValue(){} // RVA: 0x7FFACBB82610
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB82730
    }

    public class X931Signer : Object
    {
        public int AlgorithmName;
        public int TRAILER_RIPEMD160;
        public int TRAILER_RIPEMD128;
        public int TRAILER_SHA1;
        public int TRAILER_SHA256;
        public int TRAILER_SHA512;
        public int TRAILER_SHA384;
        public int TRAILER_WHIRLPOOL;
        public int TRAILER_SHA224;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters kParam; // 0x20
        public int trailer; // 0x28
        public int keyBits; // 0x2C
        public byte[] block; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB82A50 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBB82980
        public void Init(){} // RVA: 0x7FFACBB82BF0
        public void ClearBlock(){} // RVA: 0x7FFACBB792A0
        public void Update(){} // RVA: 0x7FFACBB82E10
        public void BlockUpdate(){} // RVA: 0x7FFACBB82E70
        public void Reset(){} // RVA: 0x7FFACBB82F00
        public void GenerateSignature(){} // RVA: 0x7FFACBB82F50
        public void CreateSignatureBlock(){} // RVA: 0x7FFACBB830C0
        public void VerifySignature(){} // RVA: 0x7FFACBB83270
    }

}