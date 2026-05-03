// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
// Classes: 33
// Methods: 537

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
    public class Blake2bDigest : Object
    {
        public ulong[] blake2b_IV;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0AE020 | overloaded x5
        public void Init(){} // RVA: 0x7FFE8A0AE3A0
        public void InitializeInternalState(){} // RVA: 0x7FFE8A0AE780
        public void Update(){} // RVA: 0x7FFE8A0AE950
        public void BlockUpdate(){} // RVA: 0x7FFE8A0AEA00
        public void DoFinal(){} // RVA: 0x7FFE8A0AEB50
        public void Reset(){} // RVA: 0x7FFE8A0AED30
        public void Compress(){} // RVA: 0x7FFE8A0AEE10
        public void G(){} // RVA: 0x7FFE8A0AF6C0
        public void Rotr64(){} // RVA: 0x7FFE867DB690
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0AF900
        public void GetDigestSize(){} // RVA: 0x7FFE811485C0
        public void GetByteLength(){} // RVA: 0x7FFE835C5D00
        public void ClearKey(){} // RVA: 0x7FFE8A0AF940
        public void ClearSalt(){} // RVA: 0x7FFE8A0AF9A0
        public void .cctor(){} // RVA: 0x7FFE8A0AF9C0
    }

    public class Blake2sDigest : Object
    {
        public uint[] blake2s_IV;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0B0320 | overloaded x5
        public void Init(){} // RVA: 0x7FFE8A0B06A0
        public void InitializeInternalState(){} // RVA: 0x7FFE8A0B0B50
        public void Update(){} // RVA: 0x7FFE8A0B0D00
        public void BlockUpdate(){} // RVA: 0x7FFE8A0B0DB0
        public void DoFinal(){} // RVA: 0x7FFE8A0B0F00
        public void Reset(){} // RVA: 0x7FFE8A0B1100
        public void Compress(){} // RVA: 0x7FFE8A0B11D0
        public void G(){} // RVA: 0x7FFE8A0B1930
        public void rotr32(){} // RVA: 0x7FFE8A0B1B20
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0B1B40
        public void GetDigestSize(){} // RVA: 0x7FFE811485C0
        public void GetByteLength(){} // RVA: 0x7FFE81914040
        public void ClearKey(){} // RVA: 0x7FFE8A0AF940
        public void ClearSalt(){} // RVA: 0x7FFE8A0AF9A0
        public void .cctor(){} // RVA: 0x7FFE8A0B1B80
    }

    public class Dstu7564Digest : Object
    {
        public int NB_512;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0B2090 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0B1D50
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0B2330
        public void GetDigestSize(){} // RVA: 0x7FFE811485C0
        public void GetByteLength(){} // RVA: 0x7FFE8164B230
        public void Update(){} // RVA: 0x7FFE8A0B2370
        public void BlockUpdate(){} // RVA: 0x7FFE8A0B23E0
        public void DoFinal(){} // RVA: 0x7FFE8A0B24F0
        public void Reset(){} // RVA: 0x7FFE8A0B3AE0 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x7FFE8A0B2930
        public void P(){} // RVA: 0x7FFE8A0B2B70
        public void Q(){} // RVA: 0x7FFE8A0B2C10
        public void MixColumn(){} // RVA: 0x7FFE8A0B2CF0
        public void MixColumns(){} // RVA: 0x7FFE8A0B2E30
        public void Rotate(){} // RVA: 0x7FFE8A06BF80
        public void ShiftRows(){} // RVA: 0x7FFE8A0B3020
        public void SubBytes(){} // RVA: 0x7FFE8A0B3800
        public void Copy(){} // RVA: 0x7FFE8A0B3A80
        public void .cctor(){} // RVA: 0x7FFE8A0B3B70
    }

    public class GeneralDigest : Object
    {
        public int BYTE_LENGTH;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0B3EE0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0B3FD0
        public void Update(){} // RVA: 0x7FFE8A0B4030
        public void BlockUpdate(){} // RVA: 0x7FFE8A0B40B0
        public void Finish(){} // RVA: 0x7FFE8A0B4230
        public void Reset(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void GetByteLength(){} // RVA: 0x7FFE81914040
        public void ProcessWord(){} // RVA: 0x7FFE80E4D070
        public void ProcessLength(){} // RVA: 0x7FFE80E46250
        public void ProcessBlock(){} // RVA: 0x7FFE80E45FE0
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void GetDigestSize(){} // RVA: 0x7FFE80E2EDB0
        public void DoFinal(){}
        public void Copy(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Gost3411Digest : Object
    {
        public int DIGEST_LENGTH;

        // ── Methods ──
        public void MakeC(){} // RVA: 0x7FFE8A0B4350
        public void .ctor(){} // RVA: 0x7FFE8A0B5420 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0B5B40
        public void GetDigestSize(){} // RVA: 0x7FFE835C28C0
        public void Update(){} // RVA: 0x7FFE8A0B5B80
        public void BlockUpdate(){} // RVA: 0x7FFE8A0B5C60
        public void P(){} // RVA: 0x7FFE8A0B5DF0
        public void A(){} // RVA: 0x7FFE8A0B5F00
        public void E(){} // RVA: 0x7FFE8A0B5FD0
        public void fw(){} // RVA: 0x7FFE8A0B60D0
        public void processBlock(){} // RVA: 0x7FFE8A0B62E0
        public void finish(){} // RVA: 0x7FFE8A0B67A0
        public void DoFinal(){} // RVA: 0x7FFE8A0B68A0
        public void Reset(){} // RVA: 0x7FFE8A0B6D80 | overloaded x2
        public void sumByteArray(){} // RVA: 0x7FFE8A0B6B80
        public void cpyBytesToShort(){} // RVA: 0x7FFE8A0B6C00
        public void cpyShortToBytes(){} // RVA: 0x7FFE8A0B6C90
        public void GetByteLength(){} // RVA: 0x7FFE835C28C0
        public void Copy(){} // RVA: 0x7FFE8A0B6D20
        public void .cctor(){} // RVA: 0x7FFE8A0B7100
    }

    public class Gost3411_2012Digest : Object
    {
        public byte[] IV; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0B71E0
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void Copy(){} // RVA: 0x7FFE80E2E2E0
        public void DoFinal(){} // RVA: 0x7FFE8A0B7730
        public void GetByteLength(){} // RVA: 0x7FFE81914040
        public void GetDigestSize(){} // RVA: 0x7FFE80E2EDB0
        public void Reset(){} // RVA: 0x7FFE8A0B7EE0 | overloaded x2
        public void Update(){} // RVA: 0x7FFE8A0B8060
        public void BlockUpdate(){} // RVA: 0x7FFE8A0B82A0
        public void F(){} // RVA: 0x7FFE8A0B85F0
        public void xor512(){} // RVA: 0x7FFE8A0B9A20
        public void E(){} // RVA: 0x7FFE8A0B9A70
        public void g_N(){} // RVA: 0x7FFE8A0B9D00
        public void addMod512(){} // RVA: 0x7FFE8A0B9EC0 | overloaded x2
        public void reverse(){} // RVA: 0x7FFE8A0B9F30
        public void .cctor(){} // RVA: 0x7FFE8A0B9FA0
    }

    public class Gost3411_2012_256Digest : Gost3411_2012Digest
    {
        public byte[] IV;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0BA750
        public void .ctor(){} // RVA: 0x7FFE8A0BA830 | overloaded x2
        public void GetDigestSize(){} // RVA: 0x7FFE835C28C0
        public void DoFinal(){} // RVA: 0x7FFE8A0BA8E0
        public void Copy(){} // RVA: 0x7FFE8A0BA990
        public void .cctor(){} // RVA: 0x7FFE8A0BAA80
    }

    public class Gost3411_2012_512Digest : Gost3411_2012Digest
    {
        public byte[] IV;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0BAB60
        public void .ctor(){} // RVA: 0x7FFE8A0BAC40 | overloaded x2
        public void GetDigestSize(){} // RVA: 0x7FFE81914040
        public void Copy(){} // RVA: 0x7FFE8A0BACF0
        public void .cctor(){} // RVA: 0x7FFE8A0BADE0
    }

    public class KeccakDigest : Object
    {
        public ulong[] KeccakRoundConstants;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0BAFE0 | overloaded x3
        public void CopyIn(){} // RVA: 0x7FFE8A0BB170
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0BB210
        public void GetDigestSize(){} // RVA: 0x7FFE8A0BB260
        public void Update(){} // RVA: 0x7FFE8A0BB270
        public void BlockUpdate(){} // RVA: 0x7FFE8A0BB300
        public void DoFinal(){} // RVA: 0x7FFE8A0BB360 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE8A0BCAE0 | overloaded x2
        public void GetByteLength(){} // RVA: 0x7FFE8A0BB400
        public void Init(){} // RVA: 0x7FFE8A0BB410
        public void InitSponge(){} // RVA: 0x7FFE8A0BB5F0
        public void Absorb(){} // RVA: 0x7FFE8A0BB730
        public void AbsorbBits(){} // RVA: 0x7FFE8A0BB910
        public void PadAndSwitchToSqueezingPhase(){} // RVA: 0x7FFE8A0BBA80
        public void Squeeze(){} // RVA: 0x7FFE8A0BBC70
        public void KeccakAbsorb(){} // RVA: 0x7FFE8A0BBDD0
        public void KeccakExtract(){} // RVA: 0x7FFE8A0BBE70
        public void KeccakPermutation(){} // RVA: 0x7FFE8A0BBFB0
        public void Copy(){} // RVA: 0x7FFE8A0BCA80
        public void .cctor(){} // RVA: 0x7FFE8A0BCBE0
    }

    public class LongDigest : Object
    {
        public int MyByteLength; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0BCDF0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0BCF40
        public void Update(){} // RVA: 0x7FFE8A0BD030
        public void BlockUpdate(){} // RVA: 0x7FFE8A0BD0A0
        public void Finish(){} // RVA: 0x7FFE8A0BD280
        public void Reset(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void ProcessWord(){} // RVA: 0x7FFE8A0BD480
        public void AdjustByteCounts(){} // RVA: 0x7FFE8A0BD500
        public void ProcessLength(){} // RVA: 0x7FFE8A0BD530
        public void ProcessBlock(){} // RVA: 0x7FFE8A0BD5A0
        public void Ch(){} // RVA: 0x7FFE867DB6B0
        public void Maj(){} // RVA: 0x7FFE867DB6C0
        public void Sum0(){} // RVA: 0x7FFE8A0BDFA0
        public void Sum1(){} // RVA: 0x7FFE8A0BDFE0
        public void Sigma0(){} // RVA: 0x7FFE8A0BE020
        public void Sigma1(){} // RVA: 0x7FFE8A0BE050
        public void GetByteLength(){} // RVA: 0x7FFE811485C0
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void GetDigestSize(){} // RVA: 0x7FFE80E2EDB0
        public void DoFinal(){}
        public void Copy(){} // RVA: 0x7FFE80E2E2E0
        public void .cctor(){} // RVA: 0x7FFE8A0BE080
    }

    public class MD2Digest : Object
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0BE2D0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0BE450
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0BE520
        public void GetDigestSize(){} // RVA: 0x7FFE835C1D80
        public void GetByteLength(){} // RVA: 0x7FFE835C1D80
        public void DoFinal(){} // RVA: 0x7FFE8A0BE560
        public void Reset(){} // RVA: 0x7FFE8A0BEDC0 | overloaded x2
        public void Update(){} // RVA: 0x7FFE8A0BE740
        public void BlockUpdate(){} // RVA: 0x7FFE8A0BE7B0
        public void ProcessChecksum(){} // RVA: 0x7FFE8A0BE940
        public void ProcessBlock(){} // RVA: 0x7FFE8A0BEA70
        public void Copy(){} // RVA: 0x7FFE8A0BEC10
        public void .cctor(){} // RVA: 0x7FFE8A0BEE50
    }

    public class MD4Digest : GeneralDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0BEFE0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0BF0A0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0BF150
        public void GetDigestSize(){} // RVA: 0x7FFE835C1D80
        public void ProcessWord(){} // RVA: 0x7FFE8A0BF190
        public void ProcessLength(){} // RVA: 0x7FFE8A0BF260
        public void UnpackWord(){} // RVA: 0x7FFE8A0BF2D0
        public void DoFinal(){} // RVA: 0x7FFE8A0BF340
        public void Reset(){} // RVA: 0x7FFE8A0C0040 | overloaded x2
        public void RotateLeft(){} // RVA: 0x7FFE8A078D90
        public void F(){} // RVA: 0x7FFE8671EB20
        public void G(){} // RVA: 0x7FFE8671EB30
        public void H(){} // RVA: 0x7FFE8671EB40
        public void ProcessBlock(){} // RVA: 0x7FFE8A0BF590
        public void Copy(){} // RVA: 0x7FFE8A0BFF50
    }

    public class MD5Digest : GeneralDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0C0180 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0BF0A0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0C0240
        public void GetDigestSize(){} // RVA: 0x7FFE835C1D80
        public void ProcessWord(){} // RVA: 0x7FFE8A0C0280
        public void ProcessLength(){} // RVA: 0x7FFE8A0C0340
        public void DoFinal(){} // RVA: 0x7FFE8A0BF340
        public void Reset(){} // RVA: 0x7FFE8A0C16D0 | overloaded x2
        public void RotateLeft(){} // RVA: 0x7FFE869D7C70
        public void F(){} // RVA: 0x7FFE867CDDA0
        public void G(){} // RVA: 0x7FFE867CDDC0
        public void H(){} // RVA: 0x7FFE867CDD90
        public void K(){} // RVA: 0x7FFE8A0C03F0
        public void ProcessBlock(){} // RVA: 0x7FFE8A0C0400
        public void Copy(){} // RVA: 0x7FFE8A0C1670
        public void .cctor(){} // RVA: 0x7FFE8A0C1760
    }

    public class NonMemoableDigest : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mBaseDigest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0C18E0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0C1990
        public void GetDigestSize(){} // RVA: 0x7FFE8A0C19E0
        public void Update(){} // RVA: 0x7FFE8A0C1A30
        public void BlockUpdate(){} // RVA: 0x7FFE8A0C1A90
        public void DoFinal(){} // RVA: 0x7FFE8A0C1B20
        public void Reset(){} // RVA: 0x7FFE8A0C1B90
        public void GetByteLength(){} // RVA: 0x7FFE8A0C1BE0
    }

    public class NullDigest : Object
    {
        public System.IO.MemoryStream bOut; // 0x10

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0C1C30
        public void GetByteLength(){} // RVA: 0x7FFE813240E0
        public void GetDigestSize(){} // RVA: 0x7FFE87119A80
        public void Update(){} // RVA: 0x7FFE869997A0
        public void BlockUpdate(){} // RVA: 0x7FFE86999860
        public void DoFinal(){} // RVA: 0x7FFE8A0C1C70
        public void Reset(){} // RVA: 0x7FFE8A0C1E00
        public void .ctor(){} // RVA: 0x7FFE8A0C1E30
    }

    public class RipeMD128Digest : GeneralDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0C1F80 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0BF0A0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0C2040
        public void GetDigestSize(){} // RVA: 0x7FFE835C1D80
        public void ProcessWord(){} // RVA: 0x7FFE8A0BF190
        public void ProcessLength(){} // RVA: 0x7FFE8A0BF260
        public void UnpackWord(){} // RVA: 0x7FFE8A0BF2D0
        public void DoFinal(){} // RVA: 0x7FFE8A0BF340
        public void Reset(){} // RVA: 0x7FFE8A0C3AF0 | overloaded x2
        public void RL(){} // RVA: 0x7FFE8A078D90
        public void F1(){} // RVA: 0x7FFE8A0C20A0 | overloaded x2
        public void F2(){} // RVA: 0x7FFE8A0C20D0 | overloaded x2
        public void F3(){} // RVA: 0x7FFE8A0C2110 | overloaded x2
        public void F4(){} // RVA: 0x7FFE8A0C2150 | overloaded x2
        public void FF1(){} // RVA: 0x7FFE8A0C20A0
        public void FF2(){} // RVA: 0x7FFE8A0C2190
        public void FF3(){} // RVA: 0x7FFE8A0C21D0
        public void FF4(){} // RVA: 0x7FFE8A0C2210
        public void ProcessBlock(){} // RVA: 0x7FFE8A0C2250
        public void Copy(){} // RVA: 0x7FFE8A0C3A00
    }

    public class RipeMD160Digest : GeneralDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0C3C30 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0C3CF0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0C3DB0
        public void GetDigestSize(){} // RVA: 0x7FFE813FC490
        public void ProcessWord(){} // RVA: 0x7FFE8A0C3DF0
        public void ProcessLength(){} // RVA: 0x7FFE8A0C3EC0
        public void UnpackWord(){} // RVA: 0x7FFE8A0BF2D0
        public void DoFinal(){} // RVA: 0x7FFE8A0C3F30
        public void Reset(){} // RVA: 0x7FFE8A0C8B70 | overloaded x2
        public void RL(){} // RVA: 0x7FFE8A078D90
        public void F1(){} // RVA: 0x7FFE8671EB40
        public void F2(){} // RVA: 0x7FFE8671EB20
        public void F3(){} // RVA: 0x7FFE8A0C2080
        public void F4(){} // RVA: 0x7FFE8A0C2090
        public void F5(){} // RVA: 0x7FFE8A0C41E0
        public void ProcessBlock(){} // RVA: 0x7FFE8A0C41F0
        public void Copy(){} // RVA: 0x7FFE8A0C8A80
    }

    public class RipeMD256Digest : GeneralDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0C8C00
        public void GetDigestSize(){} // RVA: 0x7FFE835C28C0
        public void .ctor(){} // RVA: 0x7FFE8A0C8CF0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0C8DB0
        public void ProcessWord(){} // RVA: 0x7FFE8A0C8E80
        public void ProcessLength(){} // RVA: 0x7FFE8A0C8F50
        public void UnpackWord(){} // RVA: 0x7FFE8A0BF2D0
        public void DoFinal(){} // RVA: 0x7FFE8A0C8FC0
        public void Reset(){} // RVA: 0x7FFE8A0CAC00 | overloaded x2
        public void RL(){} // RVA: 0x7FFE8A078D90
        public void F1(){} // RVA: 0x7FFE8A0C20A0 | overloaded x2
        public void F2(){} // RVA: 0x7FFE8A0C20D0 | overloaded x2
        public void F3(){} // RVA: 0x7FFE8A0C2110 | overloaded x2
        public void F4(){} // RVA: 0x7FFE8A0C2150 | overloaded x2
        public void FF1(){} // RVA: 0x7FFE8A0C20A0
        public void FF2(){} // RVA: 0x7FFE8A0C2190
        public void FF3(){} // RVA: 0x7FFE8A0C21D0
        public void FF4(){} // RVA: 0x7FFE8A0C2210
        public void ProcessBlock(){} // RVA: 0x7FFE8A0C9390
        public void Copy(){} // RVA: 0x7FFE8A0CAB10
    }

    public class RipeMD320Digest : GeneralDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0CAC90
        public void GetDigestSize(){} // RVA: 0x7FFE835C1DA0
        public void .ctor(){} // RVA: 0x7FFE8A0CAD80 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0CAE40
        public void ProcessWord(){} // RVA: 0x7FFE8A0CAF20
        public void ProcessLength(){} // RVA: 0x7FFE8A0CAFF0
        public void UnpackWord(){} // RVA: 0x7FFE8A0BF2D0
        public void DoFinal(){} // RVA: 0x7FFE8A0CB060
        public void Reset(){} // RVA: 0x7FFE8A0CFEF0 | overloaded x2
        public void RL(){} // RVA: 0x7FFE8A078D90
        public void F1(){} // RVA: 0x7FFE8671EB40
        public void F2(){} // RVA: 0x7FFE8671EB20
        public void F3(){} // RVA: 0x7FFE8A0C2080
        public void F4(){} // RVA: 0x7FFE8A0C2090
        public void F5(){} // RVA: 0x7FFE8A0C41E0
        public void ProcessBlock(){} // RVA: 0x7FFE8A0CB4E0
        public void Copy(){} // RVA: 0x7FFE8A0CFE00
    }

    public class SM3Digest : GeneralDigest
    {
        public int DIGEST_LENGTH;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A0D9E00
        public void .ctor(){} // RVA: 0x7FFE8A0DA110 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0DA2F0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0DA380
        public void GetDigestSize(){} // RVA: 0x7FFE835C28C0
        public void Copy(){} // RVA: 0x7FFE8A0DA3C0
        public void Reset(){} // RVA: 0x7FFE8A0DA540 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFE8A0DA660
        public void ProcessWord(){} // RVA: 0x7FFE8A0DA740
        public void ProcessLength(){} // RVA: 0x7FFE8A0DA810
        public void P0(){} // RVA: 0x7FFE8A0DA8F0
        public void P1(){} // RVA: 0x7FFE8A0DA920
        public void FF0(){} // RVA: 0x7FFE8671EB40
        public void FF1(){} // RVA: 0x7FFE8671EB30
        public void GG0(){} // RVA: 0x7FFE8671EB40
        public void GG1(){} // RVA: 0x7FFE8671EB20
        public void ProcessBlock(){} // RVA: 0x7FFE8A0DA950
    }

    public class Sha1Digest : GeneralDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0D0030 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0C3CF0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D00F0
        public void GetDigestSize(){} // RVA: 0x7FFE813FC490
        public void ProcessWord(){} // RVA: 0x7FFE8A0D0130
        public void ProcessLength(){} // RVA: 0x7FFE8A0D0200
        public void DoFinal(){} // RVA: 0x7FFE8A0D0270
        public void Reset(){} // RVA: 0x7FFE8A0D0D60 | overloaded x2
        public void F(){} // RVA: 0x7FFE867CDDA0
        public void H(){} // RVA: 0x7FFE867CDD90
        public void G(){} // RVA: 0x7FFE8A0D0510
        public void ProcessBlock(){} // RVA: 0x7FFE8A0D0520
        public void Copy(){} // RVA: 0x7FFE8A0D0D00
    }

    public class Sha224Digest : GeneralDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0D0EA0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0C8DB0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D0F60
        public void GetDigestSize(){} // RVA: 0x7FFE87633430
        public void ProcessWord(){} // RVA: 0x7FFE8A0D0FA0
        public void ProcessLength(){} // RVA: 0x7FFE8A0D1070
        public void DoFinal(){} // RVA: 0x7FFE8A0D10E0
        public void Reset(){} // RVA: 0x7FFE8A0D1E10 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x7FFE8A0D1440
        public void Ch(){} // RVA: 0x7FFE867D9B30
        public void Maj(){} // RVA: 0x7FFE867D9B40
        public void Sum0(){} // RVA: 0x7FFE8A0D1D30
        public void Sum1(){} // RVA: 0x7FFE8A0D1D70
        public void Theta0(){} // RVA: 0x7FFE8A070420
        public void Theta1(){} // RVA: 0x7FFE8A070450
        public void Copy(){} // RVA: 0x7FFE8A0D1DB0
        public void .cctor(){} // RVA: 0x7FFE8A0D1EA0
    }

    public class Sha256Digest : GeneralDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0D2050 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0C8DB0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D2110
        public void GetDigestSize(){} // RVA: 0x7FFE835C28C0
        public void ProcessWord(){} // RVA: 0x7FFE8A0D0FA0
        public void ProcessLength(){} // RVA: 0x7FFE8A0D1070
        public void DoFinal(){} // RVA: 0x7FFE8A0D2150
        public void Reset(){} // RVA: 0x7FFE8A0D2F20 | overloaded x2
        public void initHs(){} // RVA: 0x7FFE8A0D2510
        public void ProcessBlock(){} // RVA: 0x7FFE8A0D2550
        public void Sum1Ch(){} // RVA: 0x7FFE8A0D2E20
        public void Sum0Maj(){} // RVA: 0x7FFE8A0D2E70
        public void Theta0(){} // RVA: 0x7FFE8A070420
        public void Theta1(){} // RVA: 0x7FFE8A070450
        public void Copy(){} // RVA: 0x7FFE8A0D2EC0
        public void .cctor(){} // RVA: 0x7FFE8A0D2FB0
    }

    public class Sha384Digest : LongDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0D30E0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D3140
        public void GetDigestSize(){} // RVA: 0x7FFE835C28A0
        public void DoFinal(){} // RVA: 0x7FFE8A0D3180
        public void Reset(){} // RVA: 0x7FFE8A0D36C0 | overloaded x2
        public void Copy(){} // RVA: 0x7FFE8A0D3630
    }

    public class Sha3Digest : KeccakDigest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x7FFE8A0D3750
        public void .ctor(){} // RVA: 0x7FFE8A0D3920 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D3980
        public void DoFinal(){} // RVA: 0x7FFE8A0D3A50 | overloaded x2
        public void Copy(){} // RVA: 0x7FFE8A0D3BF0
    }

    public class Sha512Digest : LongDigest
    {
        public int DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0D3CD0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D3D30
        public void GetDigestSize(){} // RVA: 0x7FFE81914040
        public void DoFinal(){} // RVA: 0x7FFE8A0D3D70
        public void Reset(){} // RVA: 0x7FFE8A0D4430 | overloaded x2
        public void Copy(){} // RVA: 0x7FFE8A0D43A0
    }

    public class Sha512tDigest : LongDigest
    {
        public ulong A5;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0D46A0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D4730
        public void GetDigestSize(){} // RVA: 0x7FFE8194AD00
        public void DoFinal(){} // RVA: 0x7FFE8A0D4800
        public void Reset(){} // RVA: 0x7FFE8A0D5200 | overloaded x2
        public void tIvGenerate(){} // RVA: 0x7FFE8A0D49D0
        public void UInt64_To_BE(){} // RVA: 0x7FFE8A0D4F70
        public void UInt32_To_BE(){} // RVA: 0x7FFE8A0D5070
        public void Copy(){} // RVA: 0x7FFE8A0D5140
    }

    public class ShakeDigest : KeccakDigest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x7FFE8A0D5360
        public void .ctor(){} // RVA: 0x7FFE8A0D5560 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D55C0
        public void DoFinal(){} // RVA: 0x7FFE8A0D57B0 | overloaded x4
        public void DoOutput(){} // RVA: 0x7FFE8A0D56C0
        public void Copy(){} // RVA: 0x7FFE8A0D5940
    }

    public class ShortenedDigest : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest baseDigest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0D59D0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D5B20
        public void GetDigestSize(){} // RVA: 0x7FFE813DB630
        public void Update(){} // RVA: 0x7FFE8A0D5C50
        public void BlockUpdate(){} // RVA: 0x7FFE8A0D5CB0
        public void DoFinal(){} // RVA: 0x7FFE8A0D5D40
        public void Reset(){} // RVA: 0x7FFE8A0D5E20
        public void GetByteLength(){} // RVA: 0x7FFE8A0D5E70
    }

    public class SkeinDigest : Object
    {
        public int SKEIN_256;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0D5F90 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE8A02EC70 | overloaded x2
        public void Copy(){} // RVA: 0x7FFE8A0D6250
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0D6390
        public void GetDigestSize(){} // RVA: 0x7FFE81CCB610
        public void GetByteLength(){} // RVA: 0x7FFE8A0D6550
        public void Init(){} // RVA: 0x7FFE8A0D6590
        public void Update(){} // RVA: 0x7FFE8A02ECD0
        public void BlockUpdate(){} // RVA: 0x7FFE8A02ECF0
        public void DoFinal(){} // RVA: 0x7FFE8A02ED20
    }

    public class SkeinEngine : Object
    {
        public int SKEIN_256;
        public int SKEIN_512;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A0D65B0
        public void InitialState(){} // RVA: 0x7FFE8A0D6970
        public void VariantIdentifier(){} // RVA: 0x7FFE8A0D6A70
        public void .ctor(){} // RVA: 0x7FFE8A0D6D10 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFE8A0D6D80
        public void Clone(){} // RVA: 0x7FFE8A0D7100
        public void Copy(){} // RVA: 0x7FFE8A0D71A0
        public void Reset(){} // RVA: 0x7FFE8A0D82D0 | overloaded x2
        public void get_OutputSize(){} // RVA: 0x7FFE813DB630
        public void get_BlockSize(){} // RVA: 0x7FFE815889F0
        public void Init(){} // RVA: 0x7FFE8A0D7380
        public void InitParams(){} // RVA: 0x7FFE8A0D7580
        public void CreateInitialState(){} // RVA: 0x7FFE8A0D7C30
        public void UbiComplete(){} // RVA: 0x7FFE8A0D8320
        public void UbiInit(){} // RVA: 0x7FFE8A0D8390
        public void UbiFinal(){} // RVA: 0x7FFE8A0D8460
        public void CheckInitialised(){} // RVA: 0x7FFE8A0D8490
        public void Update(){} // RVA: 0x7FFE8A0D85B0 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFE8A0D8630
        public void Output(){} // RVA: 0x7FFE8A0D8900
    }

    public class TigerDigest : Object
    {
        public int MyByteLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0DB060 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0DB270
        public void GetDigestSize(){} // RVA: 0x7FFE835C1D90
        public void GetByteLength(){} // RVA: 0x7FFE81914040
        public void ProcessWord(){} // RVA: 0x7FFE8A0DB2B0
        public void Update(){} // RVA: 0x7FFE8A0DB420
        public void BlockUpdate(){} // RVA: 0x7FFE8A0DB490
        public void RoundABC(){} // RVA: 0x7FFE8A0DB600
        public void RoundBCA(){} // RVA: 0x7FFE8A0DB7F0
        public void RoundCAB(){} // RVA: 0x7FFE8A0DB9E0
        public void KeySchedule(){} // RVA: 0x7FFE8A0DBBD0
        public void ProcessBlock(){} // RVA: 0x7FFE8A0DBEF0
        public void UnpackWord(){} // RVA: 0x7FFE8A0DC3B0
        public void ProcessLength(){} // RVA: 0x7FFE8A0DC4A0
        public void Finish(){} // RVA: 0x7FFE8A0DC4D0
        public void DoFinal(){} // RVA: 0x7FFE8A0DC5C0
        public void Reset(){} // RVA: 0x7FFE8A0DC870 | overloaded x2
        public void Copy(){} // RVA: 0x7FFE8A0DC810
        public void .cctor(){} // RVA: 0x7FFE8A0DC980
    }

    public class WhirlpoolDigest : Object
    {
        public int BYTE_LENGTH;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A0DCC60
        public void .ctor(){} // RVA: 0x7FFE8A0DDC80 | overloaded x2
        public void packIntoLong(){} // RVA: 0x7FFE8A0DDC00
        public void maskWithReductionPolynomial(){} // RVA: 0x7FFE8A0DDC60
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0DE000
        public void GetDigestSize(){} // RVA: 0x7FFE81914040
        public void DoFinal(){} // RVA: 0x7FFE8A0DE040
        public void Reset(){} // RVA: 0x7FFE8A0DF7D0 | overloaded x2
        public void processFilledBuffer(){} // RVA: 0x7FFE8A0DE430
        public void bytesToLongFromBuffer(){} // RVA: 0x7FFE8A0DE630
        public void convertLongToByteArray(){} // RVA: 0x7FFE8A0DE750
        public void processBlock(){} // RVA: 0x7FFE8A0DE7B0
        public void Update(){} // RVA: 0x7FFE8A0DF160
        public void increment(){} // RVA: 0x7FFE8A0DF2C0
        public void BlockUpdate(){} // RVA: 0x7FFE8A0DF3E0
        public void finish(){} // RVA: 0x7FFE8A0DF590
        public void copyBitLength(){} // RVA: 0x7FFE8A0DF6E0
        public void GetByteLength(){} // RVA: 0x7FFE81914040
        public void Copy(){} // RVA: 0x7FFE8A0DF770
    }

}