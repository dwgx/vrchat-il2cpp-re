// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
// Classes: 14
// Methods: 133

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
    public class CMac : Object
    {
        public object CONSTANT_128;
        public object CONSTANT_64;
        public object ZEROES;
        public object mac;
        public object buf;
        public object bufOff;
        public object cipher;
        public object macSize;
        public object L;
        public object Lu;
        public object Lu2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2672A0
        public void get_AlgorithmName(){} // RVA: 0xA267690
        public void ShiftLeft(){} // RVA: 0xA2676E0
        public void DoubleLu(){} // RVA: 0xA267760
        public void Init(){} // RVA: 0xA267850
        public void GetMacSize(){} // RVA: 0x18A0130
        public void Update(){} // RVA: 0xA267AE0
        public void BlockUpdate(){} // RVA: 0xA267B90
        public void DoFinal(){} // RVA: 0xA267DC0
        public void Reset(){} // RVA: 0xA267FD0
    }

    public class CbcBlockCipherMac : Object
    {
        public object buf;
        public object bufOff;
        public object cipher;
        public object padding;
        public object macSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2657A0
        public void get_AlgorithmName(){} // RVA: 0xA2659E0
        public void Init(){} // RVA: 0xA265A30
        public void GetMacSize(){} // RVA: 0xB9E080
        public void Update(){} // RVA: 0xA265AA0
        public void BlockUpdate(){} // RVA: 0xA265B50
        public void DoFinal(){} // RVA: 0xA265D80
        public void Reset(){} // RVA: 0xA265F60
    }

    public class CfbBlockCipherMac : Object
    {
        public object mac;
        public object Buffer;
        public object bufOff;
        public object cipher;
        public object padding;
        public object macSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2668E0
        public void get_AlgorithmName(){} // RVA: 0xA266B80
        public void Init(){} // RVA: 0xA266CA0
        public void GetMacSize(){} // RVA: 0x18A0130
        public void Update(){} // RVA: 0xA266E30
        public void BlockUpdate(){} // RVA: 0xA266EC0
        public void DoFinal(){} // RVA: 0xA267020
        public void Reset(){} // RVA: 0xA2671E0
    }

    public class Dstu7564Mac : Object
    {
        public object engine;
        public object macSize;
        public object inputLength;
        public object paddedKey;
        public object invertedKey;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA268050
        public void .ctor(){} // RVA: 0xA268090
        public void Init(){} // RVA: 0xA268150
        public void GetMacSize(){} // RVA: 0xE62D00
        public void BlockUpdate(){} // RVA: 0xA2683E0
        public void Update(){} // RVA: 0xA268540
        public void DoFinal(){} // RVA: 0xA268580
        public void Reset(){} // RVA: 0xA268830
        public void Pad(){} // RVA: 0xA2688B0
        public void PadKey(){} // RVA: 0xA2689F0
    }

    public class Dstu7624Mac : Object
    {
        public object macSize;
        public object engine;
        public object blockSize;
        public object c;
        public object cTemp;
        public object kDelta;
        public object buf;
        public object bufOff;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA268BE0
        public void Init(){} // RVA: 0xA268E60
        public void get_AlgorithmName(){} // RVA: 0xA268FF0
        public void GetMacSize(){} // RVA: 0xB8F8F0
        public void Update(){} // RVA: 0xA269030
        public void BlockUpdate(){} // RVA: 0xA269140
        public void processBlock(){} // RVA: 0xA2693F0
        public void Xor(){} // RVA: 0xA2694C0
        public void DoFinal(){} // RVA: 0xA269570
        public void Reset(){} // RVA: 0xA2697A0
    }

    public class GMac : Object
    {
        public object cipher;
        public object macSizeBits;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
        public void Init(){} // RVA: 0xA269980
        public void get_AlgorithmName(){} // RVA: 0xA269B60
        public void GetMacSize(){} // RVA: 0xA269BE0
        public void Update(){} // RVA: 0xA269BF0
        public void BlockUpdate(){} // RVA: 0xA269C80
        public void DoFinal(){} // RVA: 0xA269CB0
        public void Reset(){} // RVA: 0xA269D50
    }

    public class Gost28147Mac : Object
    {
        public object blockSize;
        public object macSize;
        public object bufOff;
        public object buf;
        public object mac;
        public object firstStep;
        public object workingKey;
        public object macIV;
        public object S;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA269D80
        public void GenerateWorkingKey(){} // RVA: 0xA269F10
        public void Init(){} // RVA: 0xA26A030
        public void get_AlgorithmName(){} // RVA: 0xA26A540
        public void GetMacSize(){} // RVA: 0x1347420
        public void gost28147_mainStep(){} // RVA: 0xA26A580
        public void gost28147MacFunc(){} // RVA: 0xA26A700
        public void bytesToint(){} // RVA: 0xA26A940
        public void intTobytes(){} // RVA: 0xA26A9C0
        public void CM5func(){} // RVA: 0xA26AA30
        public void Update(){} // RVA: 0xA26AB10
        public void BlockUpdate(){} // RVA: 0xA26AC40
        public void DoFinal(){} // RVA: 0xA26AFB0
        public void Reset(){} // RVA: 0xA26B1E0
    }

    public class HMac : Object
    {
        public object IPAD;
        public object OPAD;
        public object digest;
        public object digestSize;
        public object blockLength;
        public object ipadState;
        public object opadState;
        public object inputPad;
        public object outputBuf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA26B220
        public void get_AlgorithmName(){} // RVA: 0xA26B3C0
        public void GetUnderlyingDigest(){} // RVA: 0xB5DBF0
        public void Init(){} // RVA: 0xA26B430
        public void GetMacSize(){} // RVA: 0xE62D00
        public void Update(){} // RVA: 0xA26B8D0
        public void BlockUpdate(){} // RVA: 0xA26B930
        public void DoFinal(){} // RVA: 0xA26B9C0
        public void Reset(){} // RVA: 0xA26BC40
        public void XorPad(){} // RVA: 0xA26BCD0
    }

    public class ISO9797Alg3Mac : Object
    {
        public object mac;
        public object buf;
        public object bufOff;
        public object cipher;
        public object padding;
        public object macSize;
        public object lastKey2;
        public object lastKey3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA26BE60
        public void get_AlgorithmName(){} // RVA: 0xA26C1A0
        public void Init(){} // RVA: 0xA26C1E0
        public void GetMacSize(){} // RVA: 0x18A0130
        public void Update(){} // RVA: 0xA26C7A0
        public void BlockUpdate(){} // RVA: 0xA26C850
        public void DoFinal(){} // RVA: 0xA26CA80
        public void Reset(){} // RVA: 0xA26CD30
    }

    public class MacCFBBlockCipher : Object
    {
        public object IV;
        public object cfbV;
        public object cfbOutV;
        public object blockSize;
        public object cipher;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA265FE0
        public void Init(){} // RVA: 0xA266240
        public void get_AlgorithmName(){} // RVA: 0xA266380
        public void get_IsPartialBlockOkay(){} // RVA: 0xC2E4C0
        public void GetBlockSize(){} // RVA: 0x1065D50
        public void ProcessBlock(){} // RVA: 0xA266490
        public void Reset(){} // RVA: 0xA2666D0
        public void GetMacBlock(){} // RVA: 0xA266740
    }

    public class Poly1305 : Object
    {
        public object BlockSize;
        public object cipher;
        public object singleByte;
        public object r0;
        public object r1;
        public object r2;
        public object r3;
        public object r4;
        public object s1;
        public object s2;
        public object s3;
        public object s4;
        public object k0;
        public object k1;
        public object k2;
        public object k3;
        public object currentBlock;
        public object currentBlockOffset;
        public object h0;
        public object h1;
        public object h2;
        public object h3;
        public object h4;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA26CF10
        public void Init(){} // RVA: 0xA26D0F0
        public void SetKey(){} // RVA: 0xA26D310
        public void get_AlgorithmName(){} // RVA: 0xA26D860
        public void GetMacSize(){} // RVA: 0x2AFB680
        public void Update(){} // RVA: 0xA26D8F0
        public void BlockUpdate(){} // RVA: 0xA26D9E0
        public void ProcessBlock(){} // RVA: 0xA26DAC0
        public void DoFinal(){} // RVA: 0xA26DEA0
        public void Reset(){} // RVA: 0xA26E290
        public void mul32x32_64(){} // RVA: 0x6898710
    }

    public class SipHash : Object
    {
        public object c;
        public object d;
        public object k0;
        public object k1;
        public object v0;
        public object v1;
        public object v2;
        public object v3;
        public object m;
        public object wordPos;
        public object wordCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F358F0
        public void get_AlgorithmName(){} // RVA: 0xA26E2A0
        public void GetMacSize(){} // RVA: 0x17FCE50
        public void Init(){} // RVA: 0xA26E330
        public void Update(){} // RVA: 0xA26E4C0
        public void BlockUpdate(){} // RVA: 0xA26E510
        public void DoFinal(){} // RVA: 0xA26E7C0
        public void Reset(){} // RVA: 0xA26E810
        public void ProcessMessageWord(){} // RVA: 0xA26E870
        public void ApplySipRounds(){} // RVA: 0xA26E8B0
        public void RotateLeft(){} // RVA: 0x725ED90
    }

    public class SkeinMac : Object
    {
        public object SKEIN_256;
        public object SKEIN_512;
        public object SKEIN_1024;
        public object engine;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA26EA20
        public void get_AlgorithmName(){} // RVA: 0xA26EB30
        public void Init(){} // RVA: 0xA26ECF0
        public void GetMacSize(){} // RVA: 0x17F0080
        public void Reset(){} // RVA: 0xA26F210
        public void Update(){} // RVA: 0xA26F270
        public void BlockUpdate(){} // RVA: 0xA26F290
        public void DoFinal(){} // RVA: 0xA26F2C0
    }

    public class VmpcMac : Object
    {
        public object g;
        public object n;
        public object P;
        public object s;
        public object T;
        public object workingIV;
        public object workingKey;
        public object x1;
        public object x2;
        public object x3;
        public object x4;

        // ── Methods ──
        public void DoFinal(){} // RVA: 0xA26F2E0
        public void get_AlgorithmName(){} // RVA: 0xA26F7D0
        public void GetMacSize(){} // RVA: 0xD354C0
        public void Init(){} // RVA: 0xA26F810
        public void initKey(){} // RVA: 0xA26FB20
        public void Reset(){} // RVA: 0xA26FDC0
        public void Update(){} // RVA: 0xA26FEA0
        public void BlockUpdate(){} // RVA: 0xA270140
        public void .ctor(){} // RVA: 0xB43310
    }

}