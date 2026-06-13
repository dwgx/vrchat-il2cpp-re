// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
// Classes: 14
// Methods: 148

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
    public class CMac
    {
        public byte CONSTANT_128;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95C4AC0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x95C4EB0
        public void ShiftLeft(){} // RVA: 0x95C4F00
        public void DoubleLu(){} // RVA: 0x95C4F70
        public void Init(){} // RVA: 0x95C5060
        public void GetMacSize(){} // RVA: 0xFDC9F0
        public void Update(){} // RVA: 0x95C52F0
        public void BlockUpdate(){} // RVA: 0x95C53A0
        public void DoFinal(){} // RVA: 0x95C55D0
        public void Reset(){} // RVA: 0x95C57D0
    }

    public class CbcBlockCipherMac
    {
        public byte[] buf; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95C2FD0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x95C3210
        public void Init(){} // RVA: 0x95C3260
        public void GetMacSize(){} // RVA: 0x338CD0
        public void Update(){} // RVA: 0x95C32D0
        public void BlockUpdate(){} // RVA: 0x95C3380
        public void DoFinal(){} // RVA: 0x95C35B0
        public void Reset(){} // RVA: 0x95C3790
    }

    public class CfbBlockCipherMac
    {
        public byte[] mac; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95C4100 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x95C43A0
        public void Init(){} // RVA: 0x95C44C0
        public void GetMacSize(){} // RVA: 0xFDC9F0
        public void Update(){} // RVA: 0x95C4650
        public void BlockUpdate(){} // RVA: 0x95C46E0
        public void DoFinal(){} // RVA: 0x95C4840
        public void Reset(){} // RVA: 0x95C4A00
    }

    public class Dstu7564Mac
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests.Dstu7564Digest engine; // 0x10

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x95C5850
        public void .ctor(){} // RVA: 0x95C5890
        public void Init(){} // RVA: 0x95C5950
        public void GetMacSize(){} // RVA: 0x5BED50
        public void BlockUpdate(){} // RVA: 0x95C5BE0
        public void Update(){} // RVA: 0x95C5D40
        public void DoFinal(){} // RVA: 0x95C5D80
        public void Reset(){} // RVA: 0x95C6030
        public void Pad(){} // RVA: 0x95C60B0
        public void PadKey(){} // RVA: 0x95C61F0
    }

    public class Dstu7624Mac
    {
        public int macSize; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95C63E0
        public void Init(){} // RVA: 0x95C6660
        public void get_AlgorithmName(){} // RVA: 0x95C67F0
        public void GetMacSize(){} // RVA: 0x32A5C0
        public void Update(){} // RVA: 0x95C6830
        public void BlockUpdate(){} // RVA: 0x95C6940
        public void processBlock(){} // RVA: 0x95C6BD0
        public void Xor(){} // RVA: 0x95C6CA0
        public void DoFinal(){} // RVA: 0x95C6D50
        public void Reset(){} // RVA: 0x95C6F90
    }

    public class GMac
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.GcmBlockCipher cipher; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50 | overloaded x2
        public void Init(){} // RVA: 0x95C7170
        public void get_AlgorithmName(){} // RVA: 0x95C7350
        public void GetMacSize(){} // RVA: 0x95C73D0
        public void Update(){} // RVA: 0x95C73E0
        public void BlockUpdate(){} // RVA: 0x95C7470
        public void DoFinal(){} // RVA: 0x95C74A0
        public void Reset(){} // RVA: 0x95C7540
    }

    public class Gost28147Mac
    {
        public int blockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95C7570
        public void GenerateWorkingKey(){} // RVA: 0x95C7700
        public void Init(){} // RVA: 0x95C7830
        public void get_AlgorithmName(){} // RVA: 0x95C7D40
        public void GetMacSize(){} // RVA: 0xA7E130
        public void gost28147_mainStep(){} // RVA: 0x95C7D80
        public void gost28147MacFunc(){} // RVA: 0x95C7EF0
        public void bytesToint(){} // RVA: 0x95C8110
        public void intTobytes(){} // RVA: 0x95C8190
        public void CM5func(){} // RVA: 0x95C8200
        public void Update(){} // RVA: 0x95C82E0
        public void BlockUpdate(){} // RVA: 0x95C8410
        public void DoFinal(){} // RVA: 0x95C8780
        public void Reset(){} // RVA: 0x95C89B0
    }

    public class HMac
    {
        public byte IPAD;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95C89F0
        public void get_AlgorithmName(){} // RVA: 0x95C8B90
        public void GetUnderlyingDigest(){} // RVA: 0x2F8380
        public void Init(){} // RVA: 0x95C8C00
        public void GetMacSize(){} // RVA: 0x5BED50
        public void Update(){} // RVA: 0x95C9080
        public void BlockUpdate(){} // RVA: 0x95C90E0
        public void DoFinal(){} // RVA: 0x95C9170
        public void Reset(){} // RVA: 0x95C93F0
        public void XorPad(){} // RVA: 0x95C9480
    }

    public class ISO9797Alg3Mac
    {
        public byte[] mac; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95C95F0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x95C9930
        public void Init(){} // RVA: 0x95C9970
        public void GetMacSize(){} // RVA: 0xFDC9F0
        public void Update(){} // RVA: 0x95C9F40
        public void BlockUpdate(){} // RVA: 0x95C9FF0
        public void DoFinal(){} // RVA: 0x95CA220
        public void Reset(){} // RVA: 0x95CA4D0
    }

    public class MacCFBBlockCipher
    {
        public byte[] IV; // 0x10
        public byte[] cfbV; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95C3810
        public void Init(){} // RVA: 0x95C3A70
        public void get_AlgorithmName(){} // RVA: 0x95C3BB0
        public void get_IsPartialBlockOkay(){} // RVA: 0x3C2850
        public void GetBlockSize(){} // RVA: 0x791DC0
        public void ProcessBlock(){} // RVA: 0x95C3CC0
        public void Reset(){} // RVA: 0x95C3EF0
        public void GetMacBlock(){} // RVA: 0x95C3F60
    }

    public class Poly1305
    {
        public int BlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95CA6B0 | overloaded x2
        public void Init(){} // RVA: 0x95CA890
        public void SetKey(){} // RVA: 0x95CAAC0
        public void get_AlgorithmName(){} // RVA: 0x95CB010
        public void GetMacSize(){} // RVA: 0x210E2B0
        public void Update(){} // RVA: 0x95CB0A0
        public void BlockUpdate(){} // RVA: 0x95CB190
        public void ProcessBlock(){} // RVA: 0x95CB270
        public void DoFinal(){} // RVA: 0x95CB640
        public void Reset(){} // RVA: 0x95CBA00
        public void mul32x32_64(){} // RVA: 0x5E1ECE0
    }

    public class SipHash
    {
        public int c; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4438000 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x95CBA10
        public void GetMacSize(){} // RVA: 0xA63AE0
        public void Init(){} // RVA: 0x95CBAA0
        public void Update(){} // RVA: 0x95CBC40
        public void BlockUpdate(){} // RVA: 0x95CBC90
        public void DoFinal(){} // RVA: 0x95CBF50 | overloaded x2
        public void Reset(){} // RVA: 0x95CBFA0
        public void ProcessMessageWord(){} // RVA: 0x95CC000
        public void ApplySipRounds(){} // RVA: 0x95CC040
        public void RotateLeft(){} // RVA: 0x67F9B10
    }

    public class SkeinMac
    {
        public int SKEIN_256;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95CC1D0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x95CC2E0
        public void Init(){} // RVA: 0x95CC4A0
        public void GetMacSize(){} // RVA: 0xF3F910
        public void Reset(){} // RVA: 0x95CC890
        public void Update(){} // RVA: 0x95CC8F0
        public void BlockUpdate(){} // RVA: 0x95CC910
        public void DoFinal(){} // RVA: 0x95CC940
    }

    public class VmpcMac
    {
        public byte g; // 0x10

        // ── Methods ──
        public void DoFinal(){} // RVA: 0x95CC960
        public void get_AlgorithmName(){} // RVA: 0x95CCE50
        public void GetMacSize(){} // RVA: 0x5FAB20
        public void Init(){} // RVA: 0x95CCE90
        public void initKey(){} // RVA: 0x95CD1A0
        public void Reset(){} // RVA: 0x95CD430
        public void Update(){} // RVA: 0x95CD510
        public void BlockUpdate(){} // RVA: 0x95CD7A0
        public void .ctor(){} // RVA: 0x2DD310
    }

}