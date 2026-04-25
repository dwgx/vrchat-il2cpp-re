// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
// Classes: 33
// Methods: 537

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
    public class Blake2bDigest : Object
    {
        public ulong[] AlgorithmName;
        public byte[,] blake2b_sigma; // 0x8
        public int ROUNDS;
        public int BLOCK_LENGTH_BYTES;
        public int digestLength; // 0x10
        public int keyLength; // 0x14
        public byte[] salt; // 0x18
        public byte[] personalization; // 0x20
        public byte[] key; // 0x28
        public byte[] buffer; // 0x30
        public int bufferPos; // 0x38
        public ulong[] internalState; // 0x40
        public ulong[] chainValue; // 0x48
        public ulong t0; // 0x50
        public ulong t1; // 0x58
        public ulong f0; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC54A00 | overloaded x5
        public void Init(){} // RVA: 0x7FFACBC54D80
        public void InitializeInternalState(){} // RVA: 0x7FFACBC55160
        public void Update(){} // RVA: 0x7FFACBC55330
        public void BlockUpdate(){} // RVA: 0x7FFACBC553E0
        public void DoFinal(){} // RVA: 0x7FFACBC55530
        public void Reset(){} // RVA: 0x7FFACBC55710
        public void Compress(){} // RVA: 0x7FFACBC557F0
        public void G(){} // RVA: 0x7FFACBC560A0
        public void Rotr64(){} // RVA: 0x7FFAC8431D80
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC562E0
        public void GetDigestSize(){} // RVA: 0x7FFAC2F6E5C0
        public void GetByteLength(){} // RVA: 0x7FFAC530F430
        public void ClearKey(){} // RVA: 0x7FFACBC56320
        public void ClearSalt(){} // RVA: 0x7FFACBC56380
        public void .cctor(){} // RVA: 0x7FFACBC563A0
    }

    public class Blake2sDigest : Object
    {
        public uint[] AlgorithmName;
        public byte[,] blake2s_sigma; // 0x8
        public int ROUNDS;
        public int BLOCK_LENGTH_BYTES;
        public int digestLength; // 0x10
        public int keyLength; // 0x14
        public byte[] salt; // 0x18
        public byte[] personalization; // 0x20
        public byte[] key; // 0x28
        public byte[] buffer; // 0x30
        public int bufferPos; // 0x38
        public uint[] internalState; // 0x40
        public uint[] chainValue; // 0x48
        public uint t0; // 0x50
        public uint t1; // 0x54
        public uint f0; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC56D00 | overloaded x5
        public void Init(){} // RVA: 0x7FFACBC57080
        public void InitializeInternalState(){} // RVA: 0x7FFACBC57530
        public void Update(){} // RVA: 0x7FFACBC576E0
        public void BlockUpdate(){} // RVA: 0x7FFACBC57790
        public void DoFinal(){} // RVA: 0x7FFACBC578E0
        public void Reset(){} // RVA: 0x7FFACBC57AE0
        public void Compress(){} // RVA: 0x7FFACBC57BB0
        public void G(){} // RVA: 0x7FFACBC58310
        public void rotr32(){} // RVA: 0x7FFACBC58500
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC58520
        public void GetDigestSize(){} // RVA: 0x7FFAC2F6E5C0
        public void GetByteLength(){} // RVA: 0x7FFAC3408770
        public void ClearKey(){} // RVA: 0x7FFACBC56320
        public void ClearSalt(){} // RVA: 0x7FFACBC56380
        public void .cctor(){} // RVA: 0x7FFACBC58560
    }

    public class Dstu7564Digest : Object
    {
        public int AlgorithmName;
        public int NB_1024;
        public int NR_512;
        public int NR_1024;
        public int hashSize; // 0x10
        public int blockSize; // 0x14
        public int columns; // 0x18
        public int rounds; // 0x1C
        public ulong[] state; // 0x20
        public ulong[] tempState1; // 0x28
        public ulong[] tempState2; // 0x30
        public ulong inputBlocks; // 0x38
        public int bufOff; // 0x40
        public byte[] buf; // 0x48
        public byte[] S0;
        public byte[] S1; // 0x8
        public byte[] S2; // 0x10
        public byte[] S3; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC58A70 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC58730
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC58D10
        public void GetDigestSize(){} // RVA: 0x7FFAC2F6E5C0
        public void GetByteLength(){} // RVA: 0x7FFAC33D5A20
        public void Update(){} // RVA: 0x7FFACBC58D50
        public void BlockUpdate(){} // RVA: 0x7FFACBC58DC0
        public void DoFinal(){} // RVA: 0x7FFACBC58ED0
        public void Reset(){} // RVA: 0x7FFACBC5A4C0 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x7FFACBC59310
        public void P(){} // RVA: 0x7FFACBC59550
        public void Q(){} // RVA: 0x7FFACBC595F0
        public void MixColumn(){} // RVA: 0x7FFACBC596D0
        public void MixColumns(){} // RVA: 0x7FFACBC59810
        public void Rotate(){} // RVA: 0x7FFACBC12960
        public void ShiftRows(){} // RVA: 0x7FFACBC59A00
        public void SubBytes(){} // RVA: 0x7FFACBC5A1E0
        public void Copy(){} // RVA: 0x7FFACBC5A460
        public void .cctor(){} // RVA: 0x7FFACBC5A550
    }

    public class GeneralDigest : Object
    {
        public int AlgorithmName;
        public byte[] xBuf; // 0x10
        public int xBufOff; // 0x18
        public long byteCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC5A8C0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC5A9B0
        public void Update(){} // RVA: 0x7FFACBC5AA10
        public void BlockUpdate(){} // RVA: 0x7FFACBC5AA90
        public void Finish(){} // RVA: 0x7FFACBC5AC10
        public void Reset(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void GetByteLength(){} // RVA: 0x7FFAC3408770
        public void ProcessWord(){} // RVA: 0x7FFAC2C77970
        public void ProcessLength(){} // RVA: 0x7FFAC2C70BF0
        public void ProcessBlock(){} // RVA: 0x7FFAC2C70980
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void GetDigestSize(){} // RVA: 0x7FFAC2C59960
        public void DoFinal(){}
        public void Copy(){} // RVA: 0x7FFAC2C58E90
    }

    public class Gost3411Digest : Object
    {
        public int AlgorithmName;
        public byte[] H; // 0x10
        public byte[] L; // 0x18
        public byte[] M; // 0x20
        public byte[] Sum; // 0x28
        public byte[][] C; // 0x30
        public byte[] xBuf; // 0x38
        public int xBufOff; // 0x40
        public ulong byteCount; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x50
        public byte[] sBox; // 0x58
        public byte[] K; // 0x60
        public byte[] a; // 0x68
        public short[] wS; // 0x70
        public short[] w_S; // 0x78
        public byte[] S; // 0x80
        public byte[] U; // 0x88
        public byte[] V; // 0x90
        public byte[] W; // 0x98
        public byte[] C2;

        // ── Methods ──
        public void MakeC(){} // RVA: 0x7FFACBC5AD30
        public void .ctor(){} // RVA: 0x7FFACBC5BE00 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC5C520
        public void GetDigestSize(){} // RVA: 0x7FFAC530BFF0
        public void Update(){} // RVA: 0x7FFACBC5C560
        public void BlockUpdate(){} // RVA: 0x7FFACBC5C640
        public void P(){} // RVA: 0x7FFACBC5C7D0
        public void A(){} // RVA: 0x7FFACBC5C8E0
        public void E(){} // RVA: 0x7FFACBC5C9B0
        public void fw(){} // RVA: 0x7FFACBC5CAB0
        public void processBlock(){} // RVA: 0x7FFACBC5CCC0
        public void finish(){} // RVA: 0x7FFACBC5D180
        public void DoFinal(){} // RVA: 0x7FFACBC5D280
        public void Reset(){} // RVA: 0x7FFACBC5D760 | overloaded x2
        public void sumByteArray(){} // RVA: 0x7FFACBC5D560
        public void cpyBytesToShort(){} // RVA: 0x7FFACBC5D5E0
        public void cpyShortToBytes(){} // RVA: 0x7FFACBC5D670
        public void GetByteLength(){} // RVA: 0x7FFAC530BFF0
        public void Copy(){} // RVA: 0x7FFACBC5D700
        public void .cctor(){} // RVA: 0x7FFACBC5DAE0
    }

    public class Gost3411_2012Digest : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] N; // 0x18
        public byte[] Sigma; // 0x20
        public byte[] Ki; // 0x28
        public byte[] m; // 0x30
        public byte[] h; // 0x38
        public byte[] tmp; // 0x40
        public byte[] block; // 0x48
        public int bOff; // 0x50
        public byte[][] C;
        public byte[] Zero; // 0x8
        public ulong[][] T; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC5DBC0
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void Copy(){} // RVA: 0x7FFAC2C58E90
        public void DoFinal(){} // RVA: 0x7FFACBC5E110
        public void GetByteLength(){} // RVA: 0x7FFAC3408770
        public void GetDigestSize(){} // RVA: 0x7FFAC2C59960
        public void Reset(){} // RVA: 0x7FFACBC5E8C0 | overloaded x2
        public void Update(){} // RVA: 0x7FFACBC5EA40
        public void BlockUpdate(){} // RVA: 0x7FFACBC5EC80
        public void F(){} // RVA: 0x7FFACBC5EFD0
        public void xor512(){} // RVA: 0x7FFACBC60400
        public void E(){} // RVA: 0x7FFACBC60450
        public void g_N(){} // RVA: 0x7FFACBC606E0
        public void addMod512(){} // RVA: 0x7FFACBC608A0 | overloaded x2
        public void reverse(){} // RVA: 0x7FFACBC60910
        public void .cctor(){} // RVA: 0x7FFACBC60980
    }

    public class Gost3411_2012_256Digest : Gost3411_2012Digest
    {
        public byte[] AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC61130
        public void .ctor(){} // RVA: 0x7FFACBC61210 | overloaded x2
        public void GetDigestSize(){} // RVA: 0x7FFAC530BFF0
        public void DoFinal(){} // RVA: 0x7FFACBC612C0
        public void Copy(){} // RVA: 0x7FFACBC61370
        public void .cctor(){} // RVA: 0x7FFACBC61460
    }

    public class Gost3411_2012_512Digest : Gost3411_2012Digest
    {
        public byte[] AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC61540
        public void .ctor(){} // RVA: 0x7FFACBC61620 | overloaded x2
        public void GetDigestSize(){} // RVA: 0x7FFAC3408770
        public void Copy(){} // RVA: 0x7FFACBC616D0
        public void .cctor(){} // RVA: 0x7FFACBC617C0
    }

    public class KeccakDigest : Object
    {
        public ulong[] AlgorithmName;
        public ulong[] state; // 0x10
        public byte[] dataQueue; // 0x18
        public int rate; // 0x20
        public int bitsInQueue; // 0x24
        public int fixedOutputLength; // 0x28
        public bool squeezing; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC619C0 | overloaded x3
        public void CopyIn(){} // RVA: 0x7FFACBC61B50
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC61BF0
        public void GetDigestSize(){} // RVA: 0x7FFACBC61C40
        public void Update(){} // RVA: 0x7FFACBC61C50
        public void BlockUpdate(){} // RVA: 0x7FFACBC61CE0
        public void DoFinal(){} // RVA: 0x7FFACBC61D40 | overloaded x2
        public void Reset(){} // RVA: 0x7FFACBC634C0 | overloaded x2
        public void GetByteLength(){} // RVA: 0x7FFACBC61DE0
        public void Init(){} // RVA: 0x7FFACBC61DF0
        public void InitSponge(){} // RVA: 0x7FFACBC61FD0
        public void Absorb(){} // RVA: 0x7FFACBC62110
        public void AbsorbBits(){} // RVA: 0x7FFACBC622F0
        public void PadAndSwitchToSqueezingPhase(){} // RVA: 0x7FFACBC62460
        public void Squeeze(){} // RVA: 0x7FFACBC62650
        public void KeccakAbsorb(){} // RVA: 0x7FFACBC627B0
        public void KeccakExtract(){} // RVA: 0x7FFACBC62850
        public void KeccakPermutation(){} // RVA: 0x7FFACBC62990
        public void Copy(){} // RVA: 0x7FFACBC63460
        public void .cctor(){} // RVA: 0x7FFACBC635C0
    }

    public class LongDigest : Object
    {
        public int AlgorithmName; // 0x10
        public byte[] xBuf; // 0x18
        public int xBufOff; // 0x20
        public long byteCount1; // 0x28
        public long byteCount2; // 0x30
        public ulong H1; // 0x38
        public ulong H2; // 0x40
        public ulong H3; // 0x48
        public ulong H4; // 0x50
        public ulong H5; // 0x58
        public ulong H6; // 0x60
        public ulong H7; // 0x68
        public ulong H8; // 0x70
        public ulong[] W; // 0x78
        public int wOff; // 0x80
        public ulong[] K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC637D0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC63920
        public void Update(){} // RVA: 0x7FFACBC63A10
        public void BlockUpdate(){} // RVA: 0x7FFACBC63A80
        public void Finish(){} // RVA: 0x7FFACBC63C60
        public void Reset(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void ProcessWord(){} // RVA: 0x7FFACBC63E60
        public void AdjustByteCounts(){} // RVA: 0x7FFACBC63EE0
        public void ProcessLength(){} // RVA: 0x7FFACBC63F10
        public void ProcessBlock(){} // RVA: 0x7FFACBC63F80
        public void Ch(){} // RVA: 0x7FFAC8431DA0
        public void Maj(){} // RVA: 0x7FFAC8431DB0
        public void Sum0(){} // RVA: 0x7FFACBC64980
        public void Sum1(){} // RVA: 0x7FFACBC649C0
        public void Sigma0(){} // RVA: 0x7FFACBC64A00
        public void Sigma1(){} // RVA: 0x7FFACBC64A30
        public void GetByteLength(){} // RVA: 0x7FFAC2F6E5C0
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void GetDigestSize(){} // RVA: 0x7FFAC2C59960
        public void DoFinal(){}
        public void Copy(){} // RVA: 0x7FFAC2C58E90
        public void .cctor(){} // RVA: 0x7FFACBC64A60
    }

    public class MD2Digest : Object
    {
        public int AlgorithmName;
        public int BYTE_LENGTH;
        public byte[] X; // 0x10
        public int xOff; // 0x18
        public byte[] M; // 0x20
        public int mOff; // 0x28
        public byte[] C; // 0x30
        public int COff; // 0x38
        public byte[] S;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC64CB0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC64E30
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC64F00
        public void GetDigestSize(){} // RVA: 0x7FFAC530B540
        public void GetByteLength(){} // RVA: 0x7FFAC530B540
        public void DoFinal(){} // RVA: 0x7FFACBC64F40
        public void Reset(){} // RVA: 0x7FFACBC657A0 | overloaded x2
        public void Update(){} // RVA: 0x7FFACBC65120
        public void BlockUpdate(){} // RVA: 0x7FFACBC65190
        public void ProcessChecksum(){} // RVA: 0x7FFACBC65320
        public void ProcessBlock(){} // RVA: 0x7FFACBC65450
        public void Copy(){} // RVA: 0x7FFACBC655F0
        public void .cctor(){} // RVA: 0x7FFACBC65830
    }

    public class MD4Digest : GeneralDigest
    {
        public int AlgorithmName;
        public int H1; // 0x28
        public int H2; // 0x2C
        public int H3; // 0x30
        public int H4; // 0x34
        public int[] X; // 0x38
        public int xOff; // 0x40
        public int S11;
        public int S12;
        public int S13;
        public int S14;
        public int S21;
        public int S22;
        public int S23;
        public int S24;
        public int S31;
        public int S32;
        public int S33;
        public int S34;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC659C0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC65A80
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC65B30
        public void GetDigestSize(){} // RVA: 0x7FFAC530B540
        public void ProcessWord(){} // RVA: 0x7FFACBC65B70
        public void ProcessLength(){} // RVA: 0x7FFACBC65C40
        public void UnpackWord(){} // RVA: 0x7FFACBC65CB0
        public void DoFinal(){} // RVA: 0x7FFACBC65D20
        public void Reset(){} // RVA: 0x7FFACBC66A20 | overloaded x2
        public void RotateLeft(){} // RVA: 0x7FFACBC1F770
        public void F(){} // RVA: 0x7FFAC8375220
        public void G(){} // RVA: 0x7FFAC8375230
        public void H(){} // RVA: 0x7FFAC8375240
        public void ProcessBlock(){} // RVA: 0x7FFACBC65F70
        public void Copy(){} // RVA: 0x7FFACBC66930
    }

    public class MD5Digest : GeneralDigest
    {
        public int AlgorithmName;
        public uint H1; // 0x28
        public uint H2; // 0x2C
        public uint H3; // 0x30
        public uint H4; // 0x34
        public uint[] X; // 0x38
        public int xOff; // 0x40
        public int S11;
        public int S12; // 0x4
        public int S13; // 0x8
        public int S14; // 0xC
        public int S21; // 0x10
        public int S22; // 0x14
        public int S23; // 0x18
        public int S24; // 0x1C
        public int S31; // 0x20
        public int S32; // 0x24
        public int S33; // 0x28
        public int S34; // 0x2C
        public int S41; // 0x30
        public int S42; // 0x34
        public int S43; // 0x38
        public int S44; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC66B60 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC65A80
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC66C20
        public void GetDigestSize(){} // RVA: 0x7FFAC530B540
        public void ProcessWord(){} // RVA: 0x7FFACBC66C60
        public void ProcessLength(){} // RVA: 0x7FFACBC66D20
        public void DoFinal(){} // RVA: 0x7FFACBC65D20
        public void Reset(){} // RVA: 0x7FFACBC680B0 | overloaded x2
        public void RotateLeft(){} // RVA: 0x7FFAC862E4A0
        public void F(){} // RVA: 0x7FFAC8424490
        public void G(){} // RVA: 0x7FFAC84244B0
        public void H(){} // RVA: 0x7FFAC8424480
        public void K(){} // RVA: 0x7FFACBC66DD0
        public void ProcessBlock(){} // RVA: 0x7FFACBC66DE0
        public void Copy(){} // RVA: 0x7FFACBC68050
        public void .cctor(){} // RVA: 0x7FFACBC68140
    }

    public class NonMemoableDigest : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest AlgorithmName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC682C0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC68370
        public void GetDigestSize(){} // RVA: 0x7FFACBC683C0
        public void Update(){} // RVA: 0x7FFACBC68410
        public void BlockUpdate(){} // RVA: 0x7FFACBC68470
        public void DoFinal(){} // RVA: 0x7FFACBC68500
        public void Reset(){} // RVA: 0x7FFACBC68570
        public void GetByteLength(){} // RVA: 0x7FFACBC685C0
    }

    public class NullDigest : Object
    {
        public System.IO.MemoryStream AlgorithmName; // 0x10

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC68610
        public void GetByteLength(){} // RVA: 0x7FFAC34F9180
        public void GetDigestSize(){} // RVA: 0x7FFAC8D71650
        public void Update(){} // RVA: 0x7FFAC85EFFD0
        public void BlockUpdate(){} // RVA: 0x7FFAC85F0090
        public void DoFinal(){} // RVA: 0x7FFACBC68650
        public void Reset(){} // RVA: 0x7FFACBC687E0
        public void .ctor(){} // RVA: 0x7FFACBC68810
    }

    public class RipeMD128Digest : GeneralDigest
    {
        public int AlgorithmName;
        public int H0; // 0x28
        public int H1; // 0x2C
        public int H2; // 0x30
        public int H3; // 0x34
        public int[] X; // 0x38
        public int xOff; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC68960 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC65A80
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC68A20
        public void GetDigestSize(){} // RVA: 0x7FFAC530B540
        public void ProcessWord(){} // RVA: 0x7FFACBC65B70
        public void ProcessLength(){} // RVA: 0x7FFACBC65C40
        public void UnpackWord(){} // RVA: 0x7FFACBC65CB0
        public void DoFinal(){} // RVA: 0x7FFACBC65D20
        public void Reset(){} // RVA: 0x7FFACBC6A4D0 | overloaded x2
        public void RL(){} // RVA: 0x7FFACBC1F770
        public void F1(){} // RVA: 0x7FFACBC68A80 | overloaded x2
        public void F2(){} // RVA: 0x7FFACBC68AB0 | overloaded x2
        public void F3(){} // RVA: 0x7FFACBC68AF0 | overloaded x2
        public void F4(){} // RVA: 0x7FFACBC68B30 | overloaded x2
        public void FF1(){} // RVA: 0x7FFACBC68A80
        public void FF2(){} // RVA: 0x7FFACBC68B70
        public void FF3(){} // RVA: 0x7FFACBC68BB0
        public void FF4(){} // RVA: 0x7FFACBC68BF0
        public void ProcessBlock(){} // RVA: 0x7FFACBC68C30
        public void Copy(){} // RVA: 0x7FFACBC6A3E0
    }

    public class RipeMD160Digest : GeneralDigest
    {
        public int AlgorithmName;
        public int H0; // 0x28
        public int H1; // 0x2C
        public int H2; // 0x30
        public int H3; // 0x34
        public int H4; // 0x38
        public int[] X; // 0x40
        public int xOff; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC6A610 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC6A6D0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC6A790
        public void GetDigestSize(){} // RVA: 0x7FFAC3195EF0
        public void ProcessWord(){} // RVA: 0x7FFACBC6A7D0
        public void ProcessLength(){} // RVA: 0x7FFACBC6A8A0
        public void UnpackWord(){} // RVA: 0x7FFACBC65CB0
        public void DoFinal(){} // RVA: 0x7FFACBC6A910
        public void Reset(){} // RVA: 0x7FFACBC6F550 | overloaded x2
        public void RL(){} // RVA: 0x7FFACBC1F770
        public void F1(){} // RVA: 0x7FFAC8375240
        public void F2(){} // RVA: 0x7FFAC8375220
        public void F3(){} // RVA: 0x7FFACBC68A60
        public void F4(){} // RVA: 0x7FFACBC68A70
        public void F5(){} // RVA: 0x7FFACBC6ABC0
        public void ProcessBlock(){} // RVA: 0x7FFACBC6ABD0
        public void Copy(){} // RVA: 0x7FFACBC6F460
    }

    public class RipeMD256Digest : GeneralDigest
    {
        public int AlgorithmName;
        public int H0; // 0x28
        public int H1; // 0x2C
        public int H2; // 0x30
        public int H3; // 0x34
        public int H4; // 0x38
        public int H5; // 0x3C
        public int H6; // 0x40
        public int H7; // 0x44
        public int[] X; // 0x48
        public int xOff; // 0x50

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC6F5E0
        public void GetDigestSize(){} // RVA: 0x7FFAC530BFF0
        public void .ctor(){} // RVA: 0x7FFACBC6F6D0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC6F790
        public void ProcessWord(){} // RVA: 0x7FFACBC6F860
        public void ProcessLength(){} // RVA: 0x7FFACBC6F930
        public void UnpackWord(){} // RVA: 0x7FFACBC65CB0
        public void DoFinal(){} // RVA: 0x7FFACBC6F9A0
        public void Reset(){} // RVA: 0x7FFACBC715E0 | overloaded x2
        public void RL(){} // RVA: 0x7FFACBC1F770
        public void F1(){} // RVA: 0x7FFACBC68A80 | overloaded x2
        public void F2(){} // RVA: 0x7FFACBC68AB0 | overloaded x2
        public void F3(){} // RVA: 0x7FFACBC68AF0 | overloaded x2
        public void F4(){} // RVA: 0x7FFACBC68B30 | overloaded x2
        public void FF1(){} // RVA: 0x7FFACBC68A80
        public void FF2(){} // RVA: 0x7FFACBC68B70
        public void FF3(){} // RVA: 0x7FFACBC68BB0
        public void FF4(){} // RVA: 0x7FFACBC68BF0
        public void ProcessBlock(){} // RVA: 0x7FFACBC6FD70
        public void Copy(){} // RVA: 0x7FFACBC714F0
    }

    public class RipeMD320Digest : GeneralDigest
    {
        public int AlgorithmName;
        public int H0; // 0x28
        public int H1; // 0x2C
        public int H2; // 0x30
        public int H3; // 0x34
        public int H4; // 0x38
        public int H5; // 0x3C
        public int H6; // 0x40
        public int H7; // 0x44
        public int H8; // 0x48
        public int H9; // 0x4C
        public int[] X; // 0x50
        public int xOff; // 0x58

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC71670
        public void GetDigestSize(){} // RVA: 0x7FFAC530B560
        public void .ctor(){} // RVA: 0x7FFACBC71760 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC71820
        public void ProcessWord(){} // RVA: 0x7FFACBC71900
        public void ProcessLength(){} // RVA: 0x7FFACBC719D0
        public void UnpackWord(){} // RVA: 0x7FFACBC65CB0
        public void DoFinal(){} // RVA: 0x7FFACBC71A40
        public void Reset(){} // RVA: 0x7FFACBC768D0 | overloaded x2
        public void RL(){} // RVA: 0x7FFACBC1F770
        public void F1(){} // RVA: 0x7FFAC8375240
        public void F2(){} // RVA: 0x7FFAC8375220
        public void F3(){} // RVA: 0x7FFACBC68A60
        public void F4(){} // RVA: 0x7FFACBC68A70
        public void F5(){} // RVA: 0x7FFACBC6ABC0
        public void ProcessBlock(){} // RVA: 0x7FFACBC71EC0
        public void Copy(){} // RVA: 0x7FFACBC767E0
    }

    public class SM3Digest : GeneralDigest
    {
        public int AlgorithmName;
        public int BLOCK_SIZE;
        public uint[] V; // 0x28
        public uint[] inwords; // 0x30
        public int xOff; // 0x38
        public uint[] W; // 0x40
        public uint[] T;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBC807E0
        public void .ctor(){} // RVA: 0x7FFACBC80AF0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC80CD0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC80D60
        public void GetDigestSize(){} // RVA: 0x7FFAC530BFF0
        public void Copy(){} // RVA: 0x7FFACBC80DA0
        public void Reset(){} // RVA: 0x7FFACBC80F20 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFACBC81040
        public void ProcessWord(){} // RVA: 0x7FFACBC81120
        public void ProcessLength(){} // RVA: 0x7FFACBC811F0
        public void P0(){} // RVA: 0x7FFACBC812D0
        public void P1(){} // RVA: 0x7FFACBC81300
        public void FF0(){} // RVA: 0x7FFAC8375240
        public void FF1(){} // RVA: 0x7FFAC8375230
        public void GG0(){} // RVA: 0x7FFAC8375240
        public void GG1(){} // RVA: 0x7FFAC8375220
        public void ProcessBlock(){} // RVA: 0x7FFACBC81330
    }

    public class Sha1Digest : GeneralDigest
    {
        public int AlgorithmName;
        public uint H1; // 0x28
        public uint H2; // 0x2C
        public uint H3; // 0x30
        public uint H4; // 0x34
        public uint H5; // 0x38
        public uint[] X; // 0x40
        public int xOff; // 0x48
        public uint Y1;
        public uint Y2;
        public uint Y3;
        public uint Y4;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC76A10 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC6A6D0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC76AD0
        public void GetDigestSize(){} // RVA: 0x7FFAC3195EF0
        public void ProcessWord(){} // RVA: 0x7FFACBC76B10
        public void ProcessLength(){} // RVA: 0x7FFACBC76BE0
        public void DoFinal(){} // RVA: 0x7FFACBC76C50
        public void Reset(){} // RVA: 0x7FFACBC77740 | overloaded x2
        public void F(){} // RVA: 0x7FFAC8424490
        public void H(){} // RVA: 0x7FFAC8424480
        public void G(){} // RVA: 0x7FFACBC76EF0
        public void ProcessBlock(){} // RVA: 0x7FFACBC76F00
        public void Copy(){} // RVA: 0x7FFACBC776E0
    }

    public class Sha224Digest : GeneralDigest
    {
        public int AlgorithmName;
        public uint H1; // 0x28
        public uint H2; // 0x2C
        public uint H3; // 0x30
        public uint H4; // 0x34
        public uint H5; // 0x38
        public uint H6; // 0x3C
        public uint H7; // 0x40
        public uint H8; // 0x44
        public uint[] X; // 0x48
        public int xOff; // 0x50
        public uint[] K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC77880 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC6F790
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC77940
        public void GetDigestSize(){} // RVA: 0x7FFAC928ACB0
        public void ProcessWord(){} // RVA: 0x7FFACBC77980
        public void ProcessLength(){} // RVA: 0x7FFACBC77A50
        public void DoFinal(){} // RVA: 0x7FFACBC77AC0
        public void Reset(){} // RVA: 0x7FFACBC787F0 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x7FFACBC77E20
        public void Ch(){} // RVA: 0x7FFAC8430220
        public void Maj(){} // RVA: 0x7FFAC8430230
        public void Sum0(){} // RVA: 0x7FFACBC78710
        public void Sum1(){} // RVA: 0x7FFACBC78750
        public void Theta0(){} // RVA: 0x7FFACBC16E00
        public void Theta1(){} // RVA: 0x7FFACBC16E30
        public void Copy(){} // RVA: 0x7FFACBC78790
        public void .cctor(){} // RVA: 0x7FFACBC78880
    }

    public class Sha256Digest : GeneralDigest
    {
        public int AlgorithmName;
        public uint H1; // 0x28
        public uint H2; // 0x2C
        public uint H3; // 0x30
        public uint H4; // 0x34
        public uint H5; // 0x38
        public uint H6; // 0x3C
        public uint H7; // 0x40
        public uint H8; // 0x44
        public uint[] X; // 0x48
        public int xOff; // 0x50
        public uint[] K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC78A30 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC6F790
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC78AF0
        public void GetDigestSize(){} // RVA: 0x7FFAC530BFF0
        public void ProcessWord(){} // RVA: 0x7FFACBC77980
        public void ProcessLength(){} // RVA: 0x7FFACBC77A50
        public void DoFinal(){} // RVA: 0x7FFACBC78B30
        public void Reset(){} // RVA: 0x7FFACBC79900 | overloaded x2
        public void initHs(){} // RVA: 0x7FFACBC78EF0
        public void ProcessBlock(){} // RVA: 0x7FFACBC78F30
        public void Sum1Ch(){} // RVA: 0x7FFACBC79800
        public void Sum0Maj(){} // RVA: 0x7FFACBC79850
        public void Theta0(){} // RVA: 0x7FFACBC16E00
        public void Theta1(){} // RVA: 0x7FFACBC16E30
        public void Copy(){} // RVA: 0x7FFACBC798A0
        public void .cctor(){} // RVA: 0x7FFACBC79990
    }

    public class Sha384Digest : LongDigest
    {
        public int AlgorithmName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC79AC0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC79B20
        public void GetDigestSize(){} // RVA: 0x7FFAC530BFD0
        public void DoFinal(){} // RVA: 0x7FFACBC79B60
        public void Reset(){} // RVA: 0x7FFACBC7A0A0 | overloaded x2
        public void Copy(){} // RVA: 0x7FFACBC7A010
    }

    public class Sha3Digest : KeccakDigest
    {
        public object AlgorithmName;

        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x7FFACBC7A130
        public void .ctor(){} // RVA: 0x7FFACBC7A300 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC7A360
        public void DoFinal(){} // RVA: 0x7FFACBC7A430 | overloaded x2
        public void Copy(){} // RVA: 0x7FFACBC7A5D0
    }

    public class Sha512Digest : LongDigest
    {
        public int AlgorithmName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC7A6B0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC7A710
        public void GetDigestSize(){} // RVA: 0x7FFAC3408770
        public void DoFinal(){} // RVA: 0x7FFACBC7A750
        public void Reset(){} // RVA: 0x7FFACBC7AE10 | overloaded x2
        public void Copy(){} // RVA: 0x7FFACBC7AD80
    }

    public class Sha512tDigest : LongDigest
    {
        public ulong AlgorithmName;
        public int digestLength; // 0x88
        public ulong H1t; // 0x90
        public ulong H2t; // 0x98
        public ulong H3t; // 0xA0
        public ulong H4t; // 0xA8
        public ulong H5t; // 0xB0
        public ulong H6t; // 0xB8
        public ulong H7t; // 0xC0
        public ulong H8t; // 0xC8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC7B080 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC7B110
        public void GetDigestSize(){} // RVA: 0x7FFAC37EE8C0
        public void DoFinal(){} // RVA: 0x7FFACBC7B1E0
        public void Reset(){} // RVA: 0x7FFACBC7BBE0 | overloaded x2
        public void tIvGenerate(){} // RVA: 0x7FFACBC7B3B0
        public void UInt64_To_BE(){} // RVA: 0x7FFACBC7B950
        public void UInt32_To_BE(){} // RVA: 0x7FFACBC7BA50
        public void Copy(){} // RVA: 0x7FFACBC7BB20
    }

    public class ShakeDigest : KeccakDigest
    {
        public object AlgorithmName;

        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x7FFACBC7BD40
        public void .ctor(){} // RVA: 0x7FFACBC7BF40 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC7BFA0
        public void DoFinal(){} // RVA: 0x7FFACBC7C190 | overloaded x4
        public void DoOutput(){} // RVA: 0x7FFACBC7C0A0
        public void Copy(){} // RVA: 0x7FFACBC7C320
    }

    public class ShortenedDigest : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest AlgorithmName; // 0x10
        public int length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC7C3B0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC7C500
        public void GetDigestSize(){} // RVA: 0x7FFAC3157800
        public void Update(){} // RVA: 0x7FFACBC7C630
        public void BlockUpdate(){} // RVA: 0x7FFACBC7C690
        public void DoFinal(){} // RVA: 0x7FFACBC7C720
        public void Reset(){} // RVA: 0x7FFACBC7C800
        public void GetByteLength(){} // RVA: 0x7FFACBC7C850
    }

    public class SkeinDigest : Object
    {
        public int AlgorithmName;
        public int SKEIN_512;
        public int SKEIN_1024;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests.SkeinEngine engine; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC7C970 | overloaded x2
        public void Reset(){} // RVA: 0x7FFACBBD5650 | overloaded x2
        public void Copy(){} // RVA: 0x7FFACBC7CC30
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC7CD70
        public void GetDigestSize(){} // RVA: 0x7FFAC3510620
        public void GetByteLength(){} // RVA: 0x7FFACBC7CF30
        public void Init(){} // RVA: 0x7FFACBC7CF70
        public void Update(){} // RVA: 0x7FFACBBD56B0
        public void BlockUpdate(){} // RVA: 0x7FFACBBD56D0
        public void DoFinal(){} // RVA: 0x7FFACBBD5700
    }

    public class SkeinEngine : Object
    {
        public int OutputSize;
        public int BlockSize;
        public int SKEIN_1024;
        public int PARAM_TYPE_KEY;
        public int PARAM_TYPE_CONFIG;
        public int PARAM_TYPE_MESSAGE;
        public int PARAM_TYPE_OUTPUT;
        public System.Collections.IDictionary INITIAL_STATES;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines.ThreefishEngine threefish; // 0x10
        public int outputSizeBytes; // 0x18
        public ulong[] chain; // 0x20
        public ulong[] initialState; // 0x28
        public byte[] key; // 0x30
        public Parameter[] preMessageParameters; // 0x38
        public Parameter[] postMessageParameters; // 0x40
        public UBI ubi; // 0x48
        public byte[] singleByte; // 0x50

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBC7CF90
        public void InitialState(){} // RVA: 0x7FFACBC7D350
        public void VariantIdentifier(){} // RVA: 0x7FFACBC7D450
        public void .ctor(){} // RVA: 0x7FFACBC7D6F0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFACBC7D760
        public void Clone(){} // RVA: 0x7FFACBC7DAE0
        public void Copy(){} // RVA: 0x7FFACBC7DB80
        public void Reset(){} // RVA: 0x7FFACBC7ECB0 | overloaded x2
        public void get_OutputSize(){} // RVA: 0x7FFAC3157800
        public void get_BlockSize(){} // RVA: 0x7FFAC8D71620
        public void Init(){} // RVA: 0x7FFACBC7DD60
        public void InitParams(){} // RVA: 0x7FFACBC7DF60
        public void CreateInitialState(){} // RVA: 0x7FFACBC7E610
        public void UbiComplete(){} // RVA: 0x7FFACBC7ED00
        public void UbiInit(){} // RVA: 0x7FFACBC7ED70
        public void UbiFinal(){} // RVA: 0x7FFACBC7EE40
        public void CheckInitialised(){} // RVA: 0x7FFACBC7EE70
        public void Update(){} // RVA: 0x7FFACBC7EF90 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFACBC7F010
        public void Output(){} // RVA: 0x7FFACBC7F2E0
    }

    public class TigerDigest : Object
    {
        public int AlgorithmName;
        public long[] t1;
        public long[] t2; // 0x8
        public long[] t3; // 0x10
        public long[] t4; // 0x18
        public int DigestLength;
        public long a; // 0x10
        public long b; // 0x18
        public long c; // 0x20
        public long byteCount; // 0x28
        public byte[] Buffer; // 0x30
        public int bOff; // 0x38
        public long[] x; // 0x40
        public int xOff; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC81A40 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC81C50
        public void GetDigestSize(){} // RVA: 0x7FFAC530B550
        public void GetByteLength(){} // RVA: 0x7FFAC3408770
        public void ProcessWord(){} // RVA: 0x7FFACBC81C90
        public void Update(){} // RVA: 0x7FFACBC81E00
        public void BlockUpdate(){} // RVA: 0x7FFACBC81E70
        public void RoundABC(){} // RVA: 0x7FFACBC81FE0
        public void RoundBCA(){} // RVA: 0x7FFACBC821D0
        public void RoundCAB(){} // RVA: 0x7FFACBC823C0
        public void KeySchedule(){} // RVA: 0x7FFACBC825B0
        public void ProcessBlock(){} // RVA: 0x7FFACBC828D0
        public void UnpackWord(){} // RVA: 0x7FFACBC82D90
        public void ProcessLength(){} // RVA: 0x7FFACBC82E80
        public void Finish(){} // RVA: 0x7FFACBC82EB0
        public void DoFinal(){} // RVA: 0x7FFACBC82FA0
        public void Reset(){} // RVA: 0x7FFACBC83250 | overloaded x2
        public void Copy(){} // RVA: 0x7FFACBC831F0
        public void .cctor(){} // RVA: 0x7FFACBC83360
    }

    public class WhirlpoolDigest : Object
    {
        public int AlgorithmName;
        public int DIGEST_LENGTH_BYTES;
        public int ROUNDS;
        public int REDUCTION_POLYNOMIAL;
        public int[] SBOX;
        public long[] C0; // 0x8
        public long[] C1; // 0x10
        public long[] C2; // 0x18
        public long[] C3; // 0x20
        public long[] C4; // 0x28
        public long[] C5; // 0x30
        public long[] C6; // 0x38
        public long[] C7; // 0x40
        public long[] _rc; // 0x10
        public short[] EIGHT; // 0x48
        public int BITCOUNT_ARRAY_SIZE;
        public byte[] _buffer; // 0x18
        public int _bufferPos; // 0x20
        public short[] _bitCount; // 0x28
        public long[] _hash; // 0x30
        public long[] _K; // 0x38
        public long[] _L; // 0x40
        public long[] _block; // 0x48
        public long[] _state; // 0x50

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBC83640
        public void .ctor(){} // RVA: 0x7FFACBC84660 | overloaded x2
        public void packIntoLong(){} // RVA: 0x7FFACBC845E0
        public void maskWithReductionPolynomial(){} // RVA: 0x7FFACBC84640
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC849E0
        public void GetDigestSize(){} // RVA: 0x7FFAC3408770
        public void DoFinal(){} // RVA: 0x7FFACBC84A20
        public void Reset(){} // RVA: 0x7FFACBC861B0 | overloaded x2
        public void processFilledBuffer(){} // RVA: 0x7FFACBC84E10
        public void bytesToLongFromBuffer(){} // RVA: 0x7FFACBC85010
        public void convertLongToByteArray(){} // RVA: 0x7FFACBC85130
        public void processBlock(){} // RVA: 0x7FFACBC85190
        public void Update(){} // RVA: 0x7FFACBC85B40
        public void increment(){} // RVA: 0x7FFACBC85CA0
        public void BlockUpdate(){} // RVA: 0x7FFACBC85DC0
        public void finish(){} // RVA: 0x7FFACBC85F70
        public void copyBitLength(){} // RVA: 0x7FFACBC860C0
        public void GetByteLength(){} // RVA: 0x7FFAC3408770
        public void Copy(){} // RVA: 0x7FFACBC86150
    }

}