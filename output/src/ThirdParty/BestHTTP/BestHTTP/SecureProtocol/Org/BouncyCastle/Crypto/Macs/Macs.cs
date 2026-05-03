// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
// Classes: 14
// Methods: 148

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
    public class CMac : Object
    {
        public byte CONSTANT_128;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A026EA0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A027290
        public void ShiftLeft(){} // RVA: 0x7FFE8A0272E0
        public void DoubleLu(){} // RVA: 0x7FFE8A027350
        public void Init(){} // RVA: 0x7FFE8A027440
        public void GetMacSize(){} // RVA: 0x7FFE81D46090
        public void Update(){} // RVA: 0x7FFE8A0276D0
        public void BlockUpdate(){} // RVA: 0x7FFE8A027780
        public void DoFinal(){} // RVA: 0x7FFE8A0279B0
        public void Reset(){} // RVA: 0x7FFE8A027BB0
    }

    public class CbcBlockCipherMac : Object
    {
        public byte[] buf; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0253B0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0255F0
        public void Init(){} // RVA: 0x7FFE8A025640
        public void GetMacSize(){} // RVA: 0x7FFE81156CD0
        public void Update(){} // RVA: 0x7FFE8A0256B0
        public void BlockUpdate(){} // RVA: 0x7FFE8A025760
        public void DoFinal(){} // RVA: 0x7FFE8A025990
        public void Reset(){} // RVA: 0x7FFE8A025B70
    }

    public class CfbBlockCipherMac : Object
    {
        public byte[] mac; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0264E0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A026780
        public void Init(){} // RVA: 0x7FFE8A0268A0
        public void GetMacSize(){} // RVA: 0x7FFE81D46090
        public void Update(){} // RVA: 0x7FFE8A026A30
        public void BlockUpdate(){} // RVA: 0x7FFE8A026AC0
        public void DoFinal(){} // RVA: 0x7FFE8A026C20
        public void Reset(){} // RVA: 0x7FFE8A026DE0
    }

    public class Dstu7564Mac : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests.Dstu7564Digest engine; // 0x10

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A027C30
        public void .ctor(){} // RVA: 0x7FFE8A027C70
        public void Init(){} // RVA: 0x7FFE8A027D30
        public void GetMacSize(){} // RVA: 0x7FFE813DB630
        public void BlockUpdate(){} // RVA: 0x7FFE8A027FC0
        public void Update(){} // RVA: 0x7FFE8A028120
        public void DoFinal(){} // RVA: 0x7FFE8A028160
        public void Reset(){} // RVA: 0x7FFE8A028410
        public void Pad(){} // RVA: 0x7FFE8A028490
        public void PadKey(){} // RVA: 0x7FFE8A0285D0
    }

    public class Dstu7624Mac : Object
    {
        public int macSize; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0287C0
        public void Init(){} // RVA: 0x7FFE8A028A40
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A028BD0
        public void GetMacSize(){} // RVA: 0x7FFE811485C0
        public void Update(){} // RVA: 0x7FFE8A028C10
        public void BlockUpdate(){} // RVA: 0x7FFE8A028D20
        public void processBlock(){} // RVA: 0x7FFE8A028FB0
        public void Xor(){} // RVA: 0x7FFE8A029080
        public void DoFinal(){} // RVA: 0x7FFE8A029130
        public void Reset(){} // RVA: 0x7FFE8A029370
    }

    public class GMac : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.GcmBlockCipher cipher; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A029550
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A029730
        public void GetMacSize(){} // RVA: 0x7FFE8A0297B0
        public void Update(){} // RVA: 0x7FFE8A0297C0
        public void BlockUpdate(){} // RVA: 0x7FFE8A029850
        public void DoFinal(){} // RVA: 0x7FFE8A029880
        public void Reset(){} // RVA: 0x7FFE8A029920
    }

    public class Gost28147Mac : Object
    {
        public int blockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A029950
        public void GenerateWorkingKey(){} // RVA: 0x7FFE8A029AE0
        public void Init(){} // RVA: 0x7FFE8A029C10
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A02A120
        public void GetMacSize(){} // RVA: 0x7FFE8180E590
        public void gost28147_mainStep(){} // RVA: 0x7FFE8A02A160
        public void gost28147MacFunc(){} // RVA: 0x7FFE8A02A2D0
        public void bytesToint(){} // RVA: 0x7FFE8A02A4F0
        public void intTobytes(){} // RVA: 0x7FFE8A02A570
        public void CM5func(){} // RVA: 0x7FFE8A02A5E0
        public void Update(){} // RVA: 0x7FFE8A02A6C0
        public void BlockUpdate(){} // RVA: 0x7FFE8A02A7F0
        public void DoFinal(){} // RVA: 0x7FFE8A02AB60
        public void Reset(){} // RVA: 0x7FFE8A02AD90
    }

    public class HMac : Object
    {
        public byte IPAD;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A02ADD0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A02AF70
        public void GetUnderlyingDigest(){} // RVA: 0x7FFE81116380
        public void Init(){} // RVA: 0x7FFE8A02AFE0
        public void GetMacSize(){} // RVA: 0x7FFE813DB630
        public void Update(){} // RVA: 0x7FFE8A02B460
        public void BlockUpdate(){} // RVA: 0x7FFE8A02B4C0
        public void DoFinal(){} // RVA: 0x7FFE8A02B550
        public void Reset(){} // RVA: 0x7FFE8A02B7D0
        public void XorPad(){} // RVA: 0x7FFE8A02B860
    }

    public class ISO9797Alg3Mac : Object
    {
        public byte[] mac; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A02B9D0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A02BD10
        public void Init(){} // RVA: 0x7FFE8A02BD50
        public void GetMacSize(){} // RVA: 0x7FFE81D46090
        public void Update(){} // RVA: 0x7FFE8A02C320
        public void BlockUpdate(){} // RVA: 0x7FFE8A02C3D0
        public void DoFinal(){} // RVA: 0x7FFE8A02C600
        public void Reset(){} // RVA: 0x7FFE8A02C8B0
    }

    public class MacCFBBlockCipher : Object
    {
        public byte[] IV; // 0x10
        public byte[] cfbV; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A025BF0
        public void Init(){} // RVA: 0x7FFE8A025E50
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A025F90
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE811E0850
        public void GetBlockSize(){} // RVA: 0x7FFE81549710
        public void ProcessBlock(){} // RVA: 0x7FFE8A0260A0
        public void Reset(){} // RVA: 0x7FFE8A0262D0
        public void GetMacBlock(){} // RVA: 0x7FFE8A026340
    }

    public class Poly1305 : Object
    {
        public int BlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A02CA90 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A02CC70
        public void SetKey(){} // RVA: 0x7FFE8A02CEA0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A02D3F0
        public void GetMacSize(){} // RVA: 0x7FFE835C1D80
        public void Update(){} // RVA: 0x7FFE8A02D480
        public void BlockUpdate(){} // RVA: 0x7FFE8A02D570
        public void ProcessBlock(){} // RVA: 0x7FFE8A02D650
        public void DoFinal(){} // RVA: 0x7FFE8A02DA20
        public void Reset(){} // RVA: 0x7FFE8A02DDE0
        public void mul32x32_64(){} // RVA: 0x7FFE8695FB20
    }

    public class SipHash : Object
    {
        public int c; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE85072A80 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A02DDF0
        public void GetMacSize(){} // RVA: 0x7FFE82199910
        public void Init(){} // RVA: 0x7FFE8A02DE80
        public void Update(){} // RVA: 0x7FFE8A02E020
        public void BlockUpdate(){} // RVA: 0x7FFE8A02E070
        public void DoFinal(){} // RVA: 0x7FFE8A02E330 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE8A02E380
        public void ProcessMessageWord(){} // RVA: 0x7FFE8A02E3E0
        public void ApplySipRounds(){} // RVA: 0x7FFE8A02E420
        public void RotateLeft(){} // RVA: 0x7FFE87338DF0
    }

    public class SkeinMac : Object
    {
        public int SKEIN_256;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A02E5B0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A02E6C0
        public void Init(){} // RVA: 0x7FFE8A02E880
        public void GetMacSize(){} // RVA: 0x7FFE81CCB610
        public void Reset(){} // RVA: 0x7FFE8A02EC70
        public void Update(){} // RVA: 0x7FFE8A02ECD0
        public void BlockUpdate(){} // RVA: 0x7FFE8A02ECF0
        public void DoFinal(){} // RVA: 0x7FFE8A02ED20
    }

    public class VmpcMac : Object
    {
        public byte g; // 0x10

        // ── Methods ──
        public void DoFinal(){} // RVA: 0x7FFE8A02ED40
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A02F230
        public void GetMacSize(){} // RVA: 0x7FFE813FC490
        public void Init(){} // RVA: 0x7FFE8A02F270
        public void initKey(){} // RVA: 0x7FFE8A02F580
        public void Reset(){} // RVA: 0x7FFE8A02F810
        public void Update(){} // RVA: 0x7FFE8A02F8F0
        public void BlockUpdate(){} // RVA: 0x7FFE8A02FB80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}