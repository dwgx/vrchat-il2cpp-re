// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
// Classes: 33
// Methods: 459

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
    public class Blake2bDigest : Object
    {
        public object blake2b_IV;
        public object blake2b_sigma;
        public object ROUNDS;
        public object BLOCK_LENGTH_BYTES;
        public object digestLength;
        public object keyLength;
        public object salt;
        public object personalization;
        public object key;
        public object buffer;
        public object bufferPos;
        public object internalState;
        public object chainValue;
        public object t0;
        public object t1;
        public object f0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2EFD10
        public void Init(){} // RVA: 0xA2F00A0
        public void InitializeInternalState(){} // RVA: 0xA2F0480
        public void Update(){} // RVA: 0xA2F0650
        public void BlockUpdate(){} // RVA: 0xA2F0700
        public void DoFinal(){} // RVA: 0xA2F0850
        public void Reset(){} // RVA: 0xA2F0A30
        public void Compress(){} // RVA: 0xA2F0B10
        public void G(){} // RVA: 0xA2F1210
        public void Rotr64(){} // RVA: 0x6713170
        public void get_AlgorithmName(){} // RVA: 0xA2F1470
        public void GetDigestSize(){} // RVA: 0xB8F8F0
        public void GetByteLength(){} // RVA: 0xA2F14B0
        public void ClearKey(){} // RVA: 0xA2F14C0
        public void ClearSalt(){} // RVA: 0xA2F1520
        public void .cctor(){} // RVA: 0xA2F1540
    }

    public class Blake2sDigest : Object
    {
        public object blake2s_IV;
        public object blake2s_sigma;
        public object ROUNDS;
        public object BLOCK_LENGTH_BYTES;
        public object digestLength;
        public object keyLength;
        public object salt;
        public object personalization;
        public object key;
        public object buffer;
        public object bufferPos;
        public object internalState;
        public object chainValue;
        public object t0;
        public object t1;
        public object f0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2F1EA0
        public void Init(){} // RVA: 0xA2F2230
        public void InitializeInternalState(){} // RVA: 0xA2F26E0
        public void Update(){} // RVA: 0xA2F2890
        public void BlockUpdate(){} // RVA: 0xA2F2940
        public void DoFinal(){} // RVA: 0xA2F2A90
        public void Reset(){} // RVA: 0xA2F2C90
        public void Compress(){} // RVA: 0xA2F2D60
        public void G(){} // RVA: 0xA2F34C0
        public void rotr32(){} // RVA: 0xA2F36A0
        public void get_AlgorithmName(){} // RVA: 0xA2F36C0
        public void GetDigestSize(){} // RVA: 0xB8F8F0
        public void GetByteLength(){} // RVA: 0x151F890
        public void ClearKey(){} // RVA: 0xA2F14C0
        public void ClearSalt(){} // RVA: 0xA2F1520
        public void .cctor(){} // RVA: 0xA2F3700
    }

    public class Dstu7564Digest : Object
    {
        public object NB_512;
        public object NB_1024;
        public object NR_512;
        public object NR_1024;
        public object hashSize;
        public object blockSize;
        public object columns;
        public object rounds;
        public object state;
        public object tempState1;
        public object tempState2;
        public object inputBlocks;
        public object bufOff;
        public object buf;
        public object S0;
        public object S1;
        public object S2;
        public object S3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2F3C10
        public void CopyIn(){} // RVA: 0xA2F38D0
        public void get_AlgorithmName(){} // RVA: 0xA2F3EB0
        public void GetDigestSize(){} // RVA: 0xB8F8F0
        public void GetByteLength(){} // RVA: 0x116A650
        public void Update(){} // RVA: 0xA2F3EF0
        public void BlockUpdate(){} // RVA: 0xA2F3F60
        public void DoFinal(){} // RVA: 0xA2F4090
        public void Reset(){} // RVA: 0xA2F56C0
        public void ProcessBlock(){} // RVA: 0xA2F44E0
        public void P(){} // RVA: 0xA2F4710
        public void Q(){} // RVA: 0xA2F47C0
        public void MixColumn(){} // RVA: 0xA2F48A0
        public void MixColumns(){} // RVA: 0xA2F49E0
        public void Rotate(){} // RVA: 0xA2AD0B0
        public void ShiftRows(){} // RVA: 0xA2F4BE0
        public void SubBytes(){} // RVA: 0xA2F53D0
        public void Copy(){} // RVA: 0xA2F5660
        public void .cctor(){} // RVA: 0xA2F5750
    }

    public class GeneralDigest : Object
    {
        public object BYTE_LENGTH;
        public object xBuf;
        public object xBufOff;
        public object byteCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2F5AC0
        public void CopyIn(){} // RVA: 0xA2F5BB0
        public void Update(){} // RVA: 0xA2F5C10
        public void BlockUpdate(){} // RVA: 0xA2F5C90
        public void Finish(){} // RVA: 0xA2F5E30
        public void Reset(){} // RVA: 0x894320
        public void GetByteLength(){} // RVA: 0x151F890
        public void ProcessWord(){} // RVA: 0x899290
        public void ProcessLength(){} // RVA: 0x8943F0
        public void ProcessBlock(){} // RVA: 0x894290
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void GetDigestSize(){} // RVA: 0x87C130
        public void DoFinal(){} // RVA: 0x885970
        public void Copy(){} // RVA: 0x87C0A0
    }

    public class Gost3411Digest : Object
    {
        public object DIGEST_LENGTH;
        public object H;
        public object L;
        public object M;
        public object Sum;
        public object C;
        public object xBuf;
        public object xBufOff;
        public object byteCount;
        public object cipher;
        public object sBox;
        public object K;
        public object a;
        public object wS;
        public object w_S;
        public object S;
        public object U;
        public object V;
        public object W;
        public object C2;

        // ── Methods ──
        public void MakeC(){} // RVA: 0xA2F5F50
        public void .ctor(){} // RVA: 0xA2F7040
        public void get_AlgorithmName(){} // RVA: 0xA2F7760
        public void GetDigestSize(){} // RVA: 0x2AFBE90
        public void Update(){} // RVA: 0xA2F77A0
        public void BlockUpdate(){} // RVA: 0xA2F7880
        public void P(){} // RVA: 0xA2F7A30
        public void A(){} // RVA: 0xA2F7B50
        public void E(){} // RVA: 0xA2F7C20
        public void fw(){} // RVA: 0xA2F7D20
        public void processBlock(){} // RVA: 0xA2F7F50
        public void finish(){} // RVA: 0xA2F84F0
        public void DoFinal(){} // RVA: 0xA2F85F0
        public void Reset(){} // RVA: 0xA2F8B00
        public void sumByteArray(){} // RVA: 0xA2F88D0
        public void cpyBytesToShort(){} // RVA: 0xA2F8960
        public void cpyShortToBytes(){} // RVA: 0xA2F8A00
        public void GetByteLength(){} // RVA: 0x2AFBE90
        public void Copy(){} // RVA: 0xA2F8AA0
        public void .cctor(){} // RVA: 0xA2F8E70
    }

    public class Gost3411_2012Digest : Object
    {
        public object IV;
        public object N;
        public object Sigma;
        public object Ki;
        public object m;
        public object h;
        public object tmp;
        public object block;
        public object bOff;
        public object C;
        public object Zero;
        public object T;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2F8F50
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void Copy(){} // RVA: 0x87C0A0
        public void DoFinal(){} // RVA: 0xA2F94A0
        public void GetByteLength(){} // RVA: 0x151F890
        public void GetDigestSize(){} // RVA: 0x87C130
        public void Reset(){} // RVA: 0xA2F9CD0
        public void Update(){} // RVA: 0xA2F9E50
        public void BlockUpdate(){} // RVA: 0xA2FA0D0
        public void F(){} // RVA: 0xA2FA460
        public void xor512(){} // RVA: 0xA2FB8B0
        public void E(){} // RVA: 0xA2FB910
        public void g_N(){} // RVA: 0xA2FBBF0
        public void addMod512(){} // RVA: 0xA2FBDD0
        public void reverse(){} // RVA: 0xA2FBE50
        public void .cctor(){} // RVA: 0xA2FBEC0
    }

    public class Gost3411_2012_256Digest : Gost3411_2012Digest
    {
        public object IV;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA2FC670
        public void .ctor(){} // RVA: 0xA2FC750
        public void GetDigestSize(){} // RVA: 0x2AFBE90
        public void DoFinal(){} // RVA: 0xA2FC800
        public void Copy(){} // RVA: 0xA2FC8B0
        public void .cctor(){} // RVA: 0xA2FC9A0
    }

    public class Gost3411_2012_512Digest : Gost3411_2012Digest
    {
        public object IV;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA2FCA80
        public void .ctor(){} // RVA: 0xA2FCB60
        public void GetDigestSize(){} // RVA: 0x151F890
        public void Copy(){} // RVA: 0xA2FCC10
        public void .cctor(){} // RVA: 0xA2FCD00
    }

    public class KeccakDigest : Object
    {
        public object KeccakRoundConstants;
        public object state;
        public object dataQueue;
        public object rate;
        public object bitsInQueue;
        public object fixedOutputLength;
        public object squeezing;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2FCF00
        public void CopyIn(){} // RVA: 0xA2FD090
        public void get_AlgorithmName(){} // RVA: 0xA2FD130
        public void GetDigestSize(){} // RVA: 0xA2FD180
        public void Update(){} // RVA: 0xA2FD190
        public void BlockUpdate(){} // RVA: 0xA2FD220
        public void DoFinal(){} // RVA: 0xA2FD280
        public void Reset(){} // RVA: 0xA2FEA30
        public void GetByteLength(){} // RVA: 0xA2FD320
        public void Init(){} // RVA: 0xA2FD330
        public void InitSponge(){} // RVA: 0xA2FD510
        public void Absorb(){} // RVA: 0xA2FD640
        public void AbsorbBits(){} // RVA: 0xA2FD820
        public void PadAndSwitchToSqueezingPhase(){} // RVA: 0xA2FD990
        public void Squeeze(){} // RVA: 0xA2FDB40
        public void KeccakAbsorb(){} // RVA: 0xA2FDCA0
        public void KeccakExtract(){} // RVA: 0xA2FDD60
        public void KeccakPermutation(){} // RVA: 0xA2FDEB0
        public void Copy(){} // RVA: 0xA2FE9D0
        public void .cctor(){} // RVA: 0xA2FEB30
    }

    public class LongDigest : Object
    {
        public object MyByteLength;
        public object xBuf;
        public object xBufOff;
        public object byteCount1;
        public object byteCount2;
        public object H1;
        public object H2;
        public object H3;
        public object H4;
        public object H5;
        public object H6;
        public object H7;
        public object H8;
        public object W;
        public object wOff;
        public object K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2FED40
        public void CopyIn(){} // RVA: 0xA2FEE90
        public void Update(){} // RVA: 0xA2FEF80
        public void BlockUpdate(){} // RVA: 0xA2FEFF0
        public void Finish(){} // RVA: 0xA2FF1E0
        public void Reset(){} // RVA: 0x894320
        public void ProcessWord(){} // RVA: 0xA2FF3E0
        public void AdjustByteCounts(){} // RVA: 0xA2FF460
        public void ProcessLength(){} // RVA: 0xA2FF490
        public void ProcessBlock(){} // RVA: 0xA2FF500
        public void Ch(){} // RVA: 0x6713190
        public void Maj(){} // RVA: 0x67131A0
        public void Sum0(){} // RVA: 0xA2FFEF0
        public void Sum1(){} // RVA: 0xA2FFF30
        public void Sigma0(){} // RVA: 0xA2FFF70
        public void Sigma1(){} // RVA: 0xA2FFFA0
        public void GetByteLength(){} // RVA: 0xB8F8F0
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void GetDigestSize(){} // RVA: 0x87C130
        public void DoFinal(){} // RVA: 0x885970
        public void Copy(){} // RVA: 0x87C0A0
        public void .cctor(){} // RVA: 0xA2FFFD0
    }

    public class MD2Digest : Object
    {
        public object DigestLength;
        public object BYTE_LENGTH;
        public object X;
        public object xOff;
        public object M;
        public object mOff;
        public object C;
        public object COff;
        public object S;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA300220
        public void CopyIn(){} // RVA: 0xA3003A0
        public void get_AlgorithmName(){} // RVA: 0xA300470
        public void GetDigestSize(){} // RVA: 0x2AFB680
        public void GetByteLength(){} // RVA: 0x2AFB680
        public void DoFinal(){} // RVA: 0xA3004B0
        public void Reset(){} // RVA: 0xA300D40
        public void Update(){} // RVA: 0xA300690
        public void BlockUpdate(){} // RVA: 0xA300700
        public void ProcessChecksum(){} // RVA: 0xA3008A0
        public void ProcessBlock(){} // RVA: 0xA3009E0
        public void Copy(){} // RVA: 0xA300B90
        public void .cctor(){} // RVA: 0xA300DD0
    }

    public class MD4Digest : GeneralDigest
    {
        public object DigestLength;
        public object H1;
        public object H2;
        public object H3;
        public object H4;
        public object X;
        public object xOff;
        public object S11;
        public object S12;
        public object S13;
        public object S14;
        public object S21;
        public object S22;
        public object S23;
        public object S24;
        public object S31;
        public object S32;
        public object S33;
        public object S34;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA300F60
        public void CopyIn(){} // RVA: 0xA301020
        public void get_AlgorithmName(){} // RVA: 0xA3010D0
        public void GetDigestSize(){} // RVA: 0x2AFB680
        public void ProcessWord(){} // RVA: 0xA301110
        public void ProcessLength(){} // RVA: 0xA3011E0
        public void UnpackWord(){} // RVA: 0xA301250
        public void DoFinal(){} // RVA: 0xA3012C0
        public void Reset(){} // RVA: 0xA302000
        public void RotateLeft(){} // RVA: 0xA2BA010
        public void F(){} // RVA: 0x66566A0
        public void G(){} // RVA: 0x66566B0
        public void H(){} // RVA: 0x66566C0
        public void ProcessBlock(){} // RVA: 0xA301520
        public void Copy(){} // RVA: 0xA301F10
    }

    public class MD5Digest : GeneralDigest
    {
        public object DigestLength;
        public object H1;
        public object H2;
        public object H3;
        public object H4;
        public object X;
        public object xOff;
        public object S11;
        public object S12;
        public object S13;
        public object S14;
        public object S21;
        public object S22;
        public object S23;
        public object S24;
        public object S31;
        public object S32;
        public object S33;
        public object S34;
        public object S41;
        public object S42;
        public object S43;
        public object S44;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA302140
        public void CopyIn(){} // RVA: 0xA301020
        public void get_AlgorithmName(){} // RVA: 0xA302200
        public void GetDigestSize(){} // RVA: 0x2AFB680
        public void ProcessWord(){} // RVA: 0xA302240
        public void ProcessLength(){} // RVA: 0xA302300
        public void DoFinal(){} // RVA: 0xA3012C0
        public void Reset(){} // RVA: 0xA3036B0
        public void RotateLeft(){} // RVA: 0x69104D0
        public void F(){} // RVA: 0x67056C0
        public void G(){} // RVA: 0x67056E0
        public void H(){} // RVA: 0x67056B0
        public void K(){} // RVA: 0xA3023D0
        public void ProcessBlock(){} // RVA: 0xA3023E0
        public void Copy(){} // RVA: 0xA303650
        public void .cctor(){} // RVA: 0xA303740
    }

    public class NonMemoableDigest : Object
    {
        public object mBaseDigest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3038C0
        public void get_AlgorithmName(){} // RVA: 0xA303970
        public void GetDigestSize(){} // RVA: 0xA3039C0
        public void Update(){} // RVA: 0xA303A10
        public void BlockUpdate(){} // RVA: 0xA303A70
        public void DoFinal(){} // RVA: 0xA303B00
        public void Reset(){} // RVA: 0xA303B70
        public void GetByteLength(){} // RVA: 0xA303BC0
    }

    public class NullDigest : Object
    {
        public object bOut;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA303C10
        public void GetByteLength(){} // RVA: 0xDAC980
        public void GetDigestSize(){} // RVA: 0x7048FE0
        public void Update(){} // RVA: 0x68D2080
        public void BlockUpdate(){} // RVA: 0x68D2140
        public void DoFinal(){} // RVA: 0xA303C50
        public void Reset(){} // RVA: 0xA303DE0
        public void .ctor(){} // RVA: 0xA303E10
    }

    public class RipeMD128Digest : GeneralDigest
    {
        public object DigestLength;
        public object H0;
        public object H1;
        public object H2;
        public object H3;
        public object X;
        public object xOff;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA303F60
        public void CopyIn(){} // RVA: 0xA301020
        public void get_AlgorithmName(){} // RVA: 0xA304020
        public void GetDigestSize(){} // RVA: 0x2AFB680
        public void ProcessWord(){} // RVA: 0xA301110
        public void ProcessLength(){} // RVA: 0xA3011E0
        public void UnpackWord(){} // RVA: 0xA301250
        public void DoFinal(){} // RVA: 0xA3012C0
        public void Reset(){} // RVA: 0xA305B50
        public void RL(){} // RVA: 0xA2BA010
        public void F1(){} // RVA: 0xA304080
        public void F2(){} // RVA: 0xA3040B0
        public void F3(){} // RVA: 0xA3040F0
        public void F4(){} // RVA: 0xA304130
        public void FF1(){} // RVA: 0xA304080
        public void FF2(){} // RVA: 0xA304170
        public void FF3(){} // RVA: 0xA3041B0
        public void FF4(){} // RVA: 0xA3041F0
        public void ProcessBlock(){} // RVA: 0xA304230
        public void Copy(){} // RVA: 0xA305A60
    }

    public class RipeMD160Digest : GeneralDigest
    {
        public object DigestLength;
        public object H0;
        public object H1;
        public object H2;
        public object H3;
        public object H4;
        public object X;
        public object xOff;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA305C90
        public void CopyIn(){} // RVA: 0xA305D50
        public void get_AlgorithmName(){} // RVA: 0xA305E10
        public void GetDigestSize(){} // RVA: 0xD354C0
        public void ProcessWord(){} // RVA: 0xA305E50
        public void ProcessLength(){} // RVA: 0xA305F20
        public void UnpackWord(){} // RVA: 0xA301250
        public void DoFinal(){} // RVA: 0xA305F90
        public void Reset(){} // RVA: 0xA30AC10
        public void RL(){} // RVA: 0xA2BA010
        public void F1(){} // RVA: 0x66566C0
        public void F2(){} // RVA: 0x66566A0
        public void F3(){} // RVA: 0xA304060
        public void F4(){} // RVA: 0xA304070
        public void F5(){} // RVA: 0xA306250
        public void ProcessBlock(){} // RVA: 0xA306260
        public void Copy(){} // RVA: 0xA30AB20
    }

    public class RipeMD256Digest : GeneralDigest
    {
        public object DigestLength;
        public object H0;
        public object H1;
        public object H2;
        public object H3;
        public object H4;
        public object H5;
        public object H6;
        public object H7;
        public object X;
        public object xOff;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA30ACA0
        public void GetDigestSize(){} // RVA: 0x2AFBE90
        public void .ctor(){} // RVA: 0xA30AD90
        public void CopyIn(){} // RVA: 0xA30AE50
        public void ProcessWord(){} // RVA: 0xA30AF20
        public void ProcessLength(){} // RVA: 0xA30AFF0
        public void UnpackWord(){} // RVA: 0xA301250
        public void DoFinal(){} // RVA: 0xA30B060
        public void Reset(){} // RVA: 0xA30CD40
        public void RL(){} // RVA: 0xA2BA010
        public void F1(){} // RVA: 0xA304080
        public void F2(){} // RVA: 0xA3040B0
        public void F3(){} // RVA: 0xA3040F0
        public void F4(){} // RVA: 0xA304130
        public void FF1(){} // RVA: 0xA304080
        public void FF2(){} // RVA: 0xA304170
        public void FF3(){} // RVA: 0xA3041B0
        public void FF4(){} // RVA: 0xA3041F0
        public void ProcessBlock(){} // RVA: 0xA30B440
        public void Copy(){} // RVA: 0xA30CC50
    }

    public class RipeMD320Digest : GeneralDigest
    {
        public object DigestLength;
        public object H0;
        public object H1;
        public object H2;
        public object H3;
        public object H4;
        public object H5;
        public object H6;
        public object H7;
        public object H8;
        public object H9;
        public object X;
        public object xOff;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA30CDD0
        public void GetDigestSize(){} // RVA: 0x2AFB6A0
        public void .ctor(){} // RVA: 0xA30CEC0
        public void CopyIn(){} // RVA: 0xA30CF80
        public void ProcessWord(){} // RVA: 0xA30D060
        public void ProcessLength(){} // RVA: 0xA30D130
        public void UnpackWord(){} // RVA: 0xA301250
        public void DoFinal(){} // RVA: 0xA30D1A0
        public void Reset(){} // RVA: 0xA312050
        public void RL(){} // RVA: 0xA2BA010
        public void F1(){} // RVA: 0x66566C0
        public void F2(){} // RVA: 0x66566A0
        public void F3(){} // RVA: 0xA304060
        public void F4(){} // RVA: 0xA304070
        public void F5(){} // RVA: 0xA306250
        public void ProcessBlock(){} // RVA: 0xA30D630
        public void Copy(){} // RVA: 0xA311F60
    }

    public class SM3Digest : GeneralDigest
    {
        public object DIGEST_LENGTH;
        public object BLOCK_SIZE;
        public object V;
        public object inwords;
        public object xOff;
        public object W;
        public object T;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA31C0E0
        public void .ctor(){} // RVA: 0xA31C3F0
        public void CopyIn(){} // RVA: 0xA31C5D0
        public void get_AlgorithmName(){} // RVA: 0xA31C660
        public void GetDigestSize(){} // RVA: 0x2AFBE90
        public void Copy(){} // RVA: 0xA31C6A0
        public void Reset(){} // RVA: 0xA31C820
        public void DoFinal(){} // RVA: 0xA31C940
        public void ProcessWord(){} // RVA: 0xA31CA40
        public void ProcessLength(){} // RVA: 0xA31CB10
        public void P0(){} // RVA: 0xA31CBF0
        public void P1(){} // RVA: 0xA31CC20
        public void FF0(){} // RVA: 0x66566C0
        public void FF1(){} // RVA: 0x66566B0
        public void GG0(){} // RVA: 0x66566C0
        public void GG1(){} // RVA: 0x66566A0
        public void ProcessBlock(){} // RVA: 0xA31CC50
    }

    public class Sha1Digest : GeneralDigest
    {
        public object DigestLength;
        public object H1;
        public object H2;
        public object H3;
        public object H4;
        public object H5;
        public object X;
        public object xOff;
        public object Y1;
        public object Y2;
        public object Y3;
        public object Y4;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA312190
        public void CopyIn(){} // RVA: 0xA305D50
        public void get_AlgorithmName(){} // RVA: 0xA312250
        public void GetDigestSize(){} // RVA: 0xD354C0
        public void ProcessWord(){} // RVA: 0xA312290
        public void ProcessLength(){} // RVA: 0xA312360
        public void DoFinal(){} // RVA: 0xA3123D0
        public void Reset(){} // RVA: 0xA312FA0
        public void F(){} // RVA: 0x67056C0
        public void H(){} // RVA: 0x67056B0
        public void G(){} // RVA: 0xA312670
        public void ProcessBlock(){} // RVA: 0xA312680
        public void Copy(){} // RVA: 0xA312F40
    }

    public class Sha224Digest : GeneralDigest
    {
        public object DigestLength;
        public object H1;
        public object H2;
        public object H3;
        public object H4;
        public object H5;
        public object H6;
        public object H7;
        public object H8;
        public object X;
        public object xOff;
        public object K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3130E0
        public void CopyIn(){} // RVA: 0xA30AE50
        public void get_AlgorithmName(){} // RVA: 0xA3131A0
        public void GetDigestSize(){} // RVA: 0x2AFBEE0
        public void ProcessWord(){} // RVA: 0xA3131E0
        public void ProcessLength(){} // RVA: 0xA3132B0
        public void DoFinal(){} // RVA: 0xA313320
        public void Reset(){} // RVA: 0xA314030
        public void ProcessBlock(){} // RVA: 0xA313680
        public void Ch(){} // RVA: 0x67114D0
        public void Maj(){} // RVA: 0x67114E0
        public void Sum0(){} // RVA: 0xA313F50
        public void Sum1(){} // RVA: 0xA313F90
        public void Theta0(){} // RVA: 0xA2B14E0
        public void Theta1(){} // RVA: 0xA2B1510
        public void Copy(){} // RVA: 0xA313FD0
        public void .cctor(){} // RVA: 0xA3140C0
    }

    public class Sha256Digest : GeneralDigest
    {
        public object DigestLength;
        public object H1;
        public object H2;
        public object H3;
        public object H4;
        public object H5;
        public object H6;
        public object H7;
        public object H8;
        public object X;
        public object xOff;
        public object K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA314270
        public void CopyIn(){} // RVA: 0xA30AE50
        public void get_AlgorithmName(){} // RVA: 0xA314330
        public void GetDigestSize(){} // RVA: 0x2AFBE90
        public void ProcessWord(){} // RVA: 0xA3131E0
        public void ProcessLength(){} // RVA: 0xA3132B0
        public void DoFinal(){} // RVA: 0xA314370
        public void Reset(){} // RVA: 0xA315120
        public void initHs(){} // RVA: 0xA314730
        public void ProcessBlock(){} // RVA: 0xA314770
        public void Sum1Ch(){} // RVA: 0xA315020
        public void Sum0Maj(){} // RVA: 0xA315070
        public void Theta0(){} // RVA: 0xA2B14E0
        public void Theta1(){} // RVA: 0xA2B1510
        public void Copy(){} // RVA: 0xA3150C0
        public void .cctor(){} // RVA: 0xA3151B0
    }

    public class Sha384Digest : LongDigest
    {
        public object DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3152E0
        public void get_AlgorithmName(){} // RVA: 0xA315340
        public void GetDigestSize(){} // RVA: 0x2AFBE50
        public void DoFinal(){} // RVA: 0xA315380
        public void Reset(){} // RVA: 0xA3158C0
        public void Copy(){} // RVA: 0xA315830
    }

    public class Sha3Digest : KeccakDigest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0xA315950
        public void .ctor(){} // RVA: 0xA315B20
        public void get_AlgorithmName(){} // RVA: 0xA315B80
        public void DoFinal(){} // RVA: 0xA315C50
        public void Copy(){} // RVA: 0xA315DF0
    }

    public class Sha512Digest : LongDigest
    {
        public object DigestLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA315ED0
        public void get_AlgorithmName(){} // RVA: 0xA315F30
        public void GetDigestSize(){} // RVA: 0x151F890
        public void DoFinal(){} // RVA: 0xA315F70
        public void Reset(){} // RVA: 0xA316630
        public void Copy(){} // RVA: 0xA3165A0
    }

    public class Sha512tDigest : LongDigest
    {
        public object A5;
        public object digestLength;
        public object H1t;
        public object H2t;
        public object H3t;
        public object H4t;
        public object H5t;
        public object H6t;
        public object H7t;
        public object H8t;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3168A0
        public void get_AlgorithmName(){} // RVA: 0xA316930
        public void GetDigestSize(){} // RVA: 0x14780B0
        public void DoFinal(){} // RVA: 0xA316A00
        public void Reset(){} // RVA: 0xA3174C0
        public void tIvGenerate(){} // RVA: 0xA316D20
        public void UInt64_To_BE(){} // RVA: 0xA3172C0
        public void UInt32_To_BE(){} // RVA: 0xA317330
        public void Copy(){} // RVA: 0xA317400
    }

    public class ShakeDigest : KeccakDigest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0xA317620
        public void .ctor(){} // RVA: 0xA317820
        public void get_AlgorithmName(){} // RVA: 0xA317880
        public void DoFinal(){} // RVA: 0xA317A70
        public void DoOutput(){} // RVA: 0xA317980
        public void Copy(){} // RVA: 0xA317C00
    }

    public class ShortenedDigest : Object
    {
        public object baseDigest;
        public object length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA317C90
        public void get_AlgorithmName(){} // RVA: 0xA317DE0
        public void GetDigestSize(){} // RVA: 0xE62D00
        public void Update(){} // RVA: 0xA317F10
        public void BlockUpdate(){} // RVA: 0xA317F70
        public void DoFinal(){} // RVA: 0xA318000
        public void Reset(){} // RVA: 0xA3180E0
        public void GetByteLength(){} // RVA: 0xA318130
    }

    public class SkeinDigest : Object
    {
        public object SKEIN_256;
        public object SKEIN_512;
        public object SKEIN_1024;
        public object engine;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA318250
        public void Reset(){} // RVA: 0xA26F210
        public void Copy(){} // RVA: 0xA318510
        public void get_AlgorithmName(){} // RVA: 0xA318650
        public void GetDigestSize(){} // RVA: 0x17F0080
        public void GetByteLength(){} // RVA: 0xA318810
        public void Init(){} // RVA: 0xA318850
        public void Update(){} // RVA: 0xA26F270
        public void BlockUpdate(){} // RVA: 0xA26F290
        public void DoFinal(){} // RVA: 0xA26F2C0
    }

    public class SkeinEngine : Object
    {
        public object SKEIN_256;
        public object SKEIN_512;
        public object SKEIN_1024;
        public object PARAM_TYPE_KEY;
        public object PARAM_TYPE_CONFIG;
        public object PARAM_TYPE_MESSAGE;
        public object PARAM_TYPE_OUTPUT;
        public object INITIAL_STATES;
        public object threefish;
        public object outputSizeBytes;
        public object chain;
        public object initialState;
        public object key;
        public object preMessageParameters;
        public object postMessageParameters;
        public object ubi;
        public object singleByte;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA318870
        public void InitialState(){} // RVA: 0xA318C30
        public void VariantIdentifier(){} // RVA: 0xA318D20
        public void .ctor(){} // RVA: 0xA318FD0
        public void CopyIn(){} // RVA: 0xA319040
        public void Clone(){} // RVA: 0xA3193C0
        public void Copy(){} // RVA: 0xA319460
        public void Reset(){} // RVA: 0xA31A590
        public void get_OutputSize(){} // RVA: 0xE62D00
        public void get_BlockSize(){} // RVA: 0x10ADE70
        public void Init(){} // RVA: 0xA319640
        public void InitParams(){} // RVA: 0xA319840
        public void CreateInitialState(){} // RVA: 0xA319EF0
        public void UbiComplete(){} // RVA: 0xA31A5E0
        public void UbiInit(){} // RVA: 0xA31A650
        public void UbiFinal(){} // RVA: 0xA31A720
        public void CheckInitialised(){} // RVA: 0xA31A750
        public void Update(){} // RVA: 0xA31A870
        public void DoFinal(){} // RVA: 0xA31A8F0
        public void Output(){} // RVA: 0xA31ABC0
    }

    public class TigerDigest : Object
    {
        public object MyByteLength;
        public object t1;
        public object t2;
        public object t3;
        public object t4;
        public object DigestLength;
        public object a;
        public object b;
        public object c;
        public object byteCount;
        public object Buffer;
        public object bOff;
        public object x;
        public object xOff;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA31D3C0
        public void get_AlgorithmName(){} // RVA: 0xA31D5D0
        public void GetDigestSize(){} // RVA: 0x2AFB690
        public void GetByteLength(){} // RVA: 0x151F890
        public void ProcessWord(){} // RVA: 0xA31D610
        public void Update(){} // RVA: 0xA31D780
        public void BlockUpdate(){} // RVA: 0xA31D7F0
        public void RoundABC(){} // RVA: 0xA31D970
        public void RoundBCA(){} // RVA: 0xA31DB60
        public void RoundCAB(){} // RVA: 0xA31DD50
        public void KeySchedule(){} // RVA: 0xA31DF40
        public void ProcessBlock(){} // RVA: 0xA31E1E0
        public void UnpackWord(){} // RVA: 0xA31E6B0
        public void ProcessLength(){} // RVA: 0xA31E7A0
        public void Finish(){} // RVA: 0xA31E7D0
        public void DoFinal(){} // RVA: 0xA31E8C0
        public void Reset(){} // RVA: 0xA31EB80
        public void Copy(){} // RVA: 0xA31EB20
        public void .cctor(){} // RVA: 0xA31EC90
    }

    public class WhirlpoolDigest : Object
    {
        public object BYTE_LENGTH;
        public object DIGEST_LENGTH_BYTES;
        public object ROUNDS;
        public object REDUCTION_POLYNOMIAL;
        public object SBOX;
        public object C0;
        public object C1;
        public object C2;
        public object C3;
        public object C4;
        public object C5;
        public object C6;
        public object C7;
        public object _rc;
        public object EIGHT;
        public object BITCOUNT_ARRAY_SIZE;
        public object _buffer;
        public object _bufferPos;
        public object _bitCount;
        public object _hash;
        public object _K;
        public object _L;
        public object _block;
        public object _state;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA31EF70
        public void .ctor(){} // RVA: 0xA31FF80
        public void packIntoLong(){} // RVA: 0xA31FF00
        public void maskWithReductionPolynomial(){} // RVA: 0xA31FF60
        public void get_AlgorithmName(){} // RVA: 0xA320300
        public void GetDigestSize(){} // RVA: 0x151F890
        public void DoFinal(){} // RVA: 0xA320340
        public void Reset(){} // RVA: 0xA321B30
        public void processFilledBuffer(){} // RVA: 0xA320740
        public void bytesToLongFromBuffer(){} // RVA: 0xA320920
        public void convertLongToByteArray(){} // RVA: 0xA320A40
        public void processBlock(){} // RVA: 0xA320AA0
        public void Update(){} // RVA: 0xA321460
        public void increment(){} // RVA: 0xA3215D0
        public void BlockUpdate(){} // RVA: 0xA321700
        public void finish(){} // RVA: 0xA3218E0
        public void copyBitLength(){} // RVA: 0xA321A30
        public void GetByteLength(){} // RVA: 0x151F890
        public void Copy(){} // RVA: 0xA321AD0
    }

}