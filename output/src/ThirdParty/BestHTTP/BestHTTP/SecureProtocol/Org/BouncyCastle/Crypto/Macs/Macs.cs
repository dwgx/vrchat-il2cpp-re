// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
// Classes: 14
// Methods: 133

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
    public class CMac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13FBCB0
        public void get_AlgorithmName(){} // RVA: 0x7B13FC0A0
        public void ShiftLeft(){} // RVA: 0x7B13FC0F0
        public void DoubleLu(){} // RVA: 0x7B13FC170
        public void Init(){} // RVA: 0x7B13FC260
        public void GetMacSize(){} // RVA: 0x7A8D863F0
        public void Update(){} // RVA: 0x7B13FC4F0
        public void BlockUpdate(){} // RVA: 0x7B13FC5A0
        public void DoFinal(){} // RVA: 0x7B13FC7D0
        public void Reset(){} // RVA: 0x7B13FC9E0
    }

    public class CbcBlockCipherMac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13FA1B0
        public void get_AlgorithmName(){} // RVA: 0x7B13FA3F0
        public void Init(){} // RVA: 0x7B13FA440
        public void GetMacSize(){} // RVA: 0x7A8133100
        public void Update(){} // RVA: 0x7B13FA4B0
        public void BlockUpdate(){} // RVA: 0x7B13FA560
        public void DoFinal(){} // RVA: 0x7B13FA790
        public void Reset(){} // RVA: 0x7B13FA970
    }

    public class CfbBlockCipherMac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13FB2F0
        public void get_AlgorithmName(){} // RVA: 0x7B13FB590
        public void Init(){} // RVA: 0x7B13FB6B0
        public void GetMacSize(){} // RVA: 0x7A8D863F0
        public void Update(){} // RVA: 0x7B13FB840
        public void BlockUpdate(){} // RVA: 0x7B13FB8D0
        public void DoFinal(){} // RVA: 0x7B13FBA30
        public void Reset(){} // RVA: 0x7B13FBBF0
    }

    public class Dstu7564Mac : Object
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B13FCA60
        public void .ctor(){} // RVA: 0x7B13FCAA0
        public void Init(){} // RVA: 0x7B13FCB60
        public void GetMacSize(){} // RVA: 0x7A83782A0
        public void BlockUpdate(){} // RVA: 0x7B13FCDF0
        public void Update(){} // RVA: 0x7B13FCF50
        public void DoFinal(){} // RVA: 0x7B13FCF90
        public void Reset(){} // RVA: 0x7B13FD240
        public void Pad(){} // RVA: 0x7B13FD2C0
        public void PadKey(){} // RVA: 0x7B13FD400
    }

    public class Dstu7624Mac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13FD5F0
        public void Init(){} // RVA: 0x7B13FD870
        public void get_AlgorithmName(){} // RVA: 0x7B13FDA00
        public void GetMacSize(){} // RVA: 0x7A8124910
        public void Update(){} // RVA: 0x7B13FDA40
        public void BlockUpdate(){} // RVA: 0x7B13FDB50
        public void processBlock(){} // RVA: 0x7B13FDE00
        public void Xor(){} // RVA: 0x7B13FDED0
        public void DoFinal(){} // RVA: 0x7B13FDF80
        public void Reset(){} // RVA: 0x7B13FE1B0
    }

    public class GMac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B6A000
        public void Init(){} // RVA: 0x7B13FE390
        public void get_AlgorithmName(){} // RVA: 0x7B13FE570
        public void GetMacSize(){} // RVA: 0x7B13FE5F0
        public void Update(){} // RVA: 0x7B13FE600
        public void BlockUpdate(){} // RVA: 0x7B13FE690
        public void DoFinal(){} // RVA: 0x7B13FE6C0
        public void Reset(){} // RVA: 0x7B13FE760
    }

    public class Gost28147Mac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13FE790
        public void GenerateWorkingKey(){} // RVA: 0x7B13FE920
        public void Init(){} // RVA: 0x7B13FEA40
        public void get_AlgorithmName(){} // RVA: 0x7B13FEF50
        public void GetMacSize(){} // RVA: 0x7A883BE70
        public void gost28147_mainStep(){} // RVA: 0x7B13FEF90
        public void gost28147MacFunc(){} // RVA: 0x7B13FF110
        public void bytesToint(){} // RVA: 0x7B13FF350
        public void intTobytes(){} // RVA: 0x7B13FF3D0
        public void CM5func(){} // RVA: 0x7B13FF440
        public void Update(){} // RVA: 0x7B13FF520
        public void BlockUpdate(){} // RVA: 0x7B13FF650
        public void DoFinal(){} // RVA: 0x7B13FF9C0
        public void Reset(){} // RVA: 0x7B13FFBF0
    }

    public class HMac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13FFC30
        public void get_AlgorithmName(){} // RVA: 0x7B13FFDD0
        public void GetUnderlyingDigest(){} // RVA: 0x7A80F2570
        public void Init(){} // RVA: 0x7B13FFE40
        public void GetMacSize(){} // RVA: 0x7A83782A0
        public void Update(){} // RVA: 0x7B14002E0
        public void BlockUpdate(){} // RVA: 0x7B1400340
        public void DoFinal(){} // RVA: 0x7B14003D0
        public void Reset(){} // RVA: 0x7B1400650
        public void XorPad(){} // RVA: 0x7B14006E0
    }

    public class ISO9797Alg3Mac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1400870
        public void get_AlgorithmName(){} // RVA: 0x7B1400BB0
        public void Init(){} // RVA: 0x7B1400BF0
        public void GetMacSize(){} // RVA: 0x7A8D863F0
        public void Update(){} // RVA: 0x7B14011B0
        public void BlockUpdate(){} // RVA: 0x7B1401260
        public void DoFinal(){} // RVA: 0x7B1401490
        public void Reset(){} // RVA: 0x7B1401740
    }

    public class MacCFBBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13FA9F0
        public void Init(){} // RVA: 0x7B13FAC50
        public void get_AlgorithmName(){} // RVA: 0x7B13FAD90
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A81BD750
        public void GetBlockSize(){} // RVA: 0x7A854FDE0
        public void ProcessBlock(){} // RVA: 0x7B13FAEA0
        public void Reset(){} // RVA: 0x7B13FB0E0
        public void GetMacBlock(){} // RVA: 0x7B13FB150
    }

    public class Poly1305 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1401920
        public void Init(){} // RVA: 0x7B1401B00
        public void SetKey(){} // RVA: 0x7B1401D20
        public void get_AlgorithmName(){} // RVA: 0x7B1402270
        public void GetMacSize(){} // RVA: 0x7A9F22B20
        public void Update(){} // RVA: 0x7B1402300
        public void BlockUpdate(){} // RVA: 0x7B14023F0
        public void ProcessBlock(){} // RVA: 0x7B14024D0
        public void DoFinal(){} // RVA: 0x7B14028B0
        public void Reset(){} // RVA: 0x7B1402CA0
        public void mul32x32_64(){} // RVA: 0x7ADC0D4C0
    }

    public class SipHash : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC226C00
        public void get_AlgorithmName(){} // RVA: 0x7B1402CB0
        public void GetMacSize(){} // RVA: 0x7A88217C0
        public void Init(){} // RVA: 0x7B1402D40
        public void Update(){} // RVA: 0x7B1402ED0
        public void BlockUpdate(){} // RVA: 0x7B1402F20
        public void DoFinal(){} // RVA: 0x7B14031D0
        public void Reset(){} // RVA: 0x7B1403220
        public void ProcessMessageWord(){} // RVA: 0x7B1403280
        public void ApplySipRounds(){} // RVA: 0x7B14032C0
        public void RotateLeft(){} // RVA: 0x7AE5E8370
    }

    public class SkeinMac : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1403430
        public void get_AlgorithmName(){} // RVA: 0x7B1403540
        public void Init(){} // RVA: 0x7B1403700
        public void GetMacSize(){} // RVA: 0x7A8D0A110
        public void Reset(){} // RVA: 0x7B1403C30
        public void Update(){} // RVA: 0x7B1403C90
        public void BlockUpdate(){} // RVA: 0x7B1403CB0
        public void DoFinal(){} // RVA: 0x7B1403CE0
    }

    public class VmpcMac : Object
    {
        // ── Methods ──
        public void DoFinal(){} // RVA: 0x7B1403D00
        public void get_AlgorithmName(){} // RVA: 0x7B14041F0
        public void GetMacSize(){} // RVA: 0x7A83B4040
        public void Init(){} // RVA: 0x7B1404230
        public void initKey(){} // RVA: 0x7B1404540
        public void Reset(){} // RVA: 0x7B14047E0
        public void Update(){} // RVA: 0x7B14048C0
        public void BlockUpdate(){} // RVA: 0x7B1404B60
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}