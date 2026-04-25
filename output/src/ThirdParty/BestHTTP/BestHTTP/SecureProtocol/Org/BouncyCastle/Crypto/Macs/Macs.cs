// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
// Classes: 14
// Methods: 148

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
    public class CMac : Object
    {
        public byte AlgorithmName;
        public byte CONSTANT_64;
        public byte[] ZEROES; // 0x10
        public byte[] mac; // 0x18
        public byte[] buf; // 0x20
        public int bufOff; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x30
        public int macSize; // 0x38
        public byte[] L; // 0x40
        public byte[] Lu; // 0x48
        public byte[] Lu2; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBCD880 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBCDC70
        public void ShiftLeft(){} // RVA: 0x7FFACBBCDCC0
        public void DoubleLu(){} // RVA: 0x7FFACBBCDD30
        public void Init(){} // RVA: 0x7FFACBBCDE20
        public void GetMacSize(){} // RVA: 0x7FFAC358A870
        public void Update(){} // RVA: 0x7FFACBBCE0B0
        public void BlockUpdate(){} // RVA: 0x7FFACBBCE160
        public void DoFinal(){} // RVA: 0x7FFACBBCE390
        public void Reset(){} // RVA: 0x7FFACBBCE590
    }

    public class CbcBlockCipherMac : Object
    {
        public byte[] AlgorithmName; // 0x10
        public int bufOff; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding; // 0x28
        public int macSize; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBCBD90 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBCBFD0
        public void Init(){} // RVA: 0x7FFACBBCC020
        public void GetMacSize(){} // RVA: 0x7FFAC2F7CCD0
        public void Update(){} // RVA: 0x7FFACBBCC090
        public void BlockUpdate(){} // RVA: 0x7FFACBBCC140
        public void DoFinal(){} // RVA: 0x7FFACBBCC370
        public void Reset(){} // RVA: 0x7FFACBBCC550
    }

    public class CfbBlockCipherMac : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] Buffer; // 0x18
        public int bufOff; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs.MacCFBBlockCipher cipher; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding; // 0x30
        public int macSize; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBCCEC0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBCD160
        public void Init(){} // RVA: 0x7FFACBBCD280
        public void GetMacSize(){} // RVA: 0x7FFAC358A870
        public void Update(){} // RVA: 0x7FFACBBCD410
        public void BlockUpdate(){} // RVA: 0x7FFACBBCD4A0
        public void DoFinal(){} // RVA: 0x7FFACBBCD600
        public void Reset(){} // RVA: 0x7FFACBBCD7C0
    }

    public class Dstu7564Mac : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests.Dstu7564Digest AlgorithmName; // 0x10
        public int macSize; // 0x18
        public ulong inputLength; // 0x20
        public byte[] paddedKey; // 0x28
        public byte[] invertedKey; // 0x30

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBCE610
        public void .ctor(){} // RVA: 0x7FFACBBCE650
        public void Init(){} // RVA: 0x7FFACBBCE710
        public void GetMacSize(){} // RVA: 0x7FFAC3157800
        public void BlockUpdate(){} // RVA: 0x7FFACBBCE9A0
        public void Update(){} // RVA: 0x7FFACBBCEB00
        public void DoFinal(){} // RVA: 0x7FFACBBCEB40
        public void Reset(){} // RVA: 0x7FFACBBCEDF0
        public void Pad(){} // RVA: 0x7FFACBBCEE70
        public void PadKey(){} // RVA: 0x7FFACBBCEFB0
    }

    public class Dstu7624Mac : Object
    {
        public int AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines.Dstu7624Engine engine; // 0x18
        public int blockSize; // 0x20
        public byte[] c; // 0x28
        public byte[] cTemp; // 0x30
        public byte[] kDelta; // 0x38
        public byte[] buf; // 0x40
        public int bufOff; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBCF1A0
        public void Init(){} // RVA: 0x7FFACBBCF420
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBCF5B0
        public void GetMacSize(){} // RVA: 0x7FFAC2F6E5C0
        public void Update(){} // RVA: 0x7FFACBBCF5F0
        public void BlockUpdate(){} // RVA: 0x7FFACBBCF700
        public void processBlock(){} // RVA: 0x7FFACBBCF990
        public void Xor(){} // RVA: 0x7FFACBBCFA60
        public void DoFinal(){} // RVA: 0x7FFACBBCFB10
        public void Reset(){} // RVA: 0x7FFACBBCFD50
    }

    public class GMac : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.GcmBlockCipher AlgorithmName; // 0x10
        public int macSizeBits; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBBCFF30
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBD0110
        public void GetMacSize(){} // RVA: 0x7FFACBBD0190
        public void Update(){} // RVA: 0x7FFACBBD01A0
        public void BlockUpdate(){} // RVA: 0x7FFACBBD0230
        public void DoFinal(){} // RVA: 0x7FFACBBD0260
        public void Reset(){} // RVA: 0x7FFACBBD0300
    }

    public class Gost28147Mac : Object
    {
        public int AlgorithmName;
        public int macSize;
        public int bufOff; // 0x10
        public byte[] buf; // 0x18
        public byte[] mac; // 0x20
        public bool firstStep; // 0x28
        public int[] workingKey; // 0x30
        public byte[] macIV; // 0x38
        public byte[] S; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD0330
        public void GenerateWorkingKey(){} // RVA: 0x7FFACBBD04C0
        public void Init(){} // RVA: 0x7FFACBBD05F0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBD0B00
        public void GetMacSize(){} // RVA: 0x7FFAC36C3910
        public void gost28147_mainStep(){} // RVA: 0x7FFACBBD0B40
        public void gost28147MacFunc(){} // RVA: 0x7FFACBBD0CB0
        public void bytesToint(){} // RVA: 0x7FFACBBD0ED0
        public void intTobytes(){} // RVA: 0x7FFACBBD0F50
        public void CM5func(){} // RVA: 0x7FFACBBD0FC0
        public void Update(){} // RVA: 0x7FFACBBD10A0
        public void BlockUpdate(){} // RVA: 0x7FFACBBD11D0
        public void DoFinal(){} // RVA: 0x7FFACBBD1540
        public void Reset(){} // RVA: 0x7FFACBBD1770
    }

    public class HMac : Object
    {
        public byte AlgorithmName;
        public byte OPAD;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10
        public int digestSize; // 0x18
        public int blockLength; // 0x1C
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IMemoable ipadState; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IMemoable opadState; // 0x28
        public byte[] inputPad; // 0x30
        public byte[] outputBuf; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD17B0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBD1950
        public void GetUnderlyingDigest(){} // RVA: 0x7FFAC2F3C380
        public void Init(){} // RVA: 0x7FFACBBD19C0
        public void GetMacSize(){} // RVA: 0x7FFAC3157800
        public void Update(){} // RVA: 0x7FFACBBD1E40
        public void BlockUpdate(){} // RVA: 0x7FFACBBD1EA0
        public void DoFinal(){} // RVA: 0x7FFACBBD1F30
        public void Reset(){} // RVA: 0x7FFACBBD21B0
        public void XorPad(){} // RVA: 0x7FFACBBD2240
    }

    public class ISO9797Alg3Mac : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] buf; // 0x18
        public int bufOff; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding; // 0x30
        public int macSize; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter lastKey2; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter lastKey3; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD23B0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBD26F0
        public void Init(){} // RVA: 0x7FFACBBD2730
        public void GetMacSize(){} // RVA: 0x7FFAC358A870
        public void Update(){} // RVA: 0x7FFACBBD2D00
        public void BlockUpdate(){} // RVA: 0x7FFACBBD2DB0
        public void DoFinal(){} // RVA: 0x7FFACBBD2FE0
        public void Reset(){} // RVA: 0x7FFACBBD3290
    }

    public class MacCFBBlockCipher : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] IsPartialBlockOkay; // 0x18
        public byte[] cfbOutV; // 0x20
        public int blockSize; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBCC5D0
        public void Init(){} // RVA: 0x7FFACBBCC830
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBCC970
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC3006850
        public void GetBlockSize(){} // RVA: 0x7FFAC32EC4C0
        public void ProcessBlock(){} // RVA: 0x7FFACBBCCA80
        public void Reset(){} // RVA: 0x7FFACBBCCCB0
        public void GetMacBlock(){} // RVA: 0x7FFACBBCCD20
    }

    public class Poly1305 : Object
    {
        public int AlgorithmName;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x10
        public byte[] singleByte; // 0x18
        public uint r0; // 0x20
        public uint r1; // 0x24
        public uint r2; // 0x28
        public uint r3; // 0x2C
        public uint r4; // 0x30
        public uint s1; // 0x34
        public uint s2; // 0x38
        public uint s3; // 0x3C
        public uint s4; // 0x40
        public uint k0; // 0x44
        public uint k1; // 0x48
        public uint k2; // 0x4C
        public uint k3; // 0x50
        public byte[] currentBlock; // 0x58
        public int currentBlockOffset; // 0x60
        public uint h0; // 0x64
        public uint h1; // 0x68
        public uint h2; // 0x6C
        public uint h3; // 0x70
        public uint h4; // 0x74

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD3470 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBBD3650
        public void SetKey(){} // RVA: 0x7FFACBBD3880
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBD3DD0
        public void GetMacSize(){} // RVA: 0x7FFAC530B540
        public void Update(){} // RVA: 0x7FFACBBD3E60
        public void BlockUpdate(){} // RVA: 0x7FFACBBD3F50
        public void ProcessBlock(){} // RVA: 0x7FFACBBD4030
        public void DoFinal(){} // RVA: 0x7FFACBBD4400
        public void Reset(){} // RVA: 0x7FFACBBD47C0
        public void mul32x32_64(){} // RVA: 0x7FFAC85B6350
    }

    public class SipHash : Object
    {
        public int AlgorithmName; // 0x10
        public int d; // 0x14
        public long k0; // 0x18
        public long k1; // 0x20
        public long v0; // 0x28
        public long v1; // 0x30
        public long v2; // 0x38
        public long v3; // 0x40
        public long m; // 0x48
        public int wordPos; // 0x50
        public int wordCount; // 0x54

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6CEC5A0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBD47D0
        public void GetMacSize(){} // RVA: 0x7FFAC3ED8E80
        public void Init(){} // RVA: 0x7FFACBBD4860
        public void Update(){} // RVA: 0x7FFACBBD4A00
        public void BlockUpdate(){} // RVA: 0x7FFACBBD4A50
        public void DoFinal(){} // RVA: 0x7FFACBBD4D10 | overloaded x2
        public void Reset(){} // RVA: 0x7FFACBBD4D60
        public void ProcessMessageWord(){} // RVA: 0x7FFACBBD4DC0
        public void ApplySipRounds(){} // RVA: 0x7FFACBBD4E00
        public void RotateLeft(){} // RVA: 0x7FFAC8F909D0
    }

    public class SkeinMac : Object
    {
        public int AlgorithmName;
        public int SKEIN_512;
        public int SKEIN_1024;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests.SkeinEngine engine; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD4F90 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBD50A0
        public void Init(){} // RVA: 0x7FFACBBD5260
        public void GetMacSize(){} // RVA: 0x7FFAC3510620
        public void Reset(){} // RVA: 0x7FFACBBD5650
        public void Update(){} // RVA: 0x7FFACBBD56B0
        public void BlockUpdate(){} // RVA: 0x7FFACBBD56D0
        public void DoFinal(){} // RVA: 0x7FFACBBD5700
    }

    public class VmpcMac : Object
    {
        public byte AlgorithmName; // 0x10
        public byte n; // 0x11
        public byte[] P; // 0x18
        public byte s; // 0x20
        public byte[] T; // 0x28
        public byte[] workingIV; // 0x30
        public byte[] workingKey; // 0x38
        public byte x1; // 0x40
        public byte x2; // 0x41
        public byte x3; // 0x42
        public byte x4; // 0x43

        // ── Methods ──
        public void DoFinal(){} // RVA: 0x7FFACBBD5720
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBD5C10
        public void GetMacSize(){} // RVA: 0x7FFAC3195EF0
        public void Init(){} // RVA: 0x7FFACBBD5C50
        public void initKey(){} // RVA: 0x7FFACBBD5F60
        public void Reset(){} // RVA: 0x7FFACBBD61F0
        public void Update(){} // RVA: 0x7FFACBBD62D0
        public void BlockUpdate(){} // RVA: 0x7FFACBBD6560
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}