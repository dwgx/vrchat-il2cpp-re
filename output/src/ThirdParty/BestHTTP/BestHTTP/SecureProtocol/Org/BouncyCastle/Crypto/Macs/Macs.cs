// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
// Classes: 14
// Methods: 148

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
    public class CMac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC074AC0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC074EB0
        public void ShiftLeft(){} // RVA: 0x7FFAFC074F00
        public void DoubleLu(){} // RVA: 0x7FFAFC074F70
        public void Init(){} // RVA: 0x7FFAFC075060
        public void GetMacSize(){} // RVA: 0x7FFAF3A8C9F0
        public void Update(){} // RVA: 0x7FFAFC0752F0
        public void BlockUpdate(){} // RVA: 0x7FFAFC0753A0
        public void DoFinal(){} // RVA: 0x7FFAFC0755D0
        public void Reset(){} // RVA: 0x7FFAFC0757D0
    }

    public class CbcBlockCipherMac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC072FD0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC073210
        public void Init(){} // RVA: 0x7FFAFC073260
        public void GetMacSize(){} // RVA: 0x7FFAF2DE8CD0
        public void Update(){} // RVA: 0x7FFAFC0732D0
        public void BlockUpdate(){} // RVA: 0x7FFAFC073380
        public void DoFinal(){} // RVA: 0x7FFAFC0735B0
        public void Reset(){} // RVA: 0x7FFAFC073790
    }

    public class CfbBlockCipherMac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC074100 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC0743A0
        public void Init(){} // RVA: 0x7FFAFC0744C0
        public void GetMacSize(){} // RVA: 0x7FFAF3A8C9F0
        public void Update(){} // RVA: 0x7FFAFC074650
        public void BlockUpdate(){} // RVA: 0x7FFAFC0746E0
        public void DoFinal(){} // RVA: 0x7FFAFC074840
        public void Reset(){} // RVA: 0x7FFAFC074A00
    }

    public class Dstu7564Mac
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC075850
        public void .ctor(){} // RVA: 0x7FFAFC075890
        public void Init(){} // RVA: 0x7FFAFC075950
        public void GetMacSize(){} // RVA: 0x7FFAF306ED50
        public void BlockUpdate(){} // RVA: 0x7FFAFC075BE0
        public void Update(){} // RVA: 0x7FFAFC075D40
        public void DoFinal(){} // RVA: 0x7FFAFC075D80
        public void Reset(){} // RVA: 0x7FFAFC076030
        public void Pad(){} // RVA: 0x7FFAFC0760B0
        public void PadKey(){} // RVA: 0x7FFAFC0761F0
    }

    public class Dstu7624Mac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0763E0
        public void Init(){} // RVA: 0x7FFAFC076660
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC0767F0
        public void GetMacSize(){} // RVA: 0x7FFAF2DDA5C0
        public void Update(){} // RVA: 0x7FFAFC076830
        public void BlockUpdate(){} // RVA: 0x7FFAFC076940
        public void processBlock(){} // RVA: 0x7FFAFC076BD0
        public void Xor(){} // RVA: 0x7FFAFC076CA0
        public void DoFinal(){} // RVA: 0x7FFAFC076D50
        public void Reset(){} // RVA: 0x7FFAFC076F90
    }

    public class GMac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4816A50 | overloaded x2
        public void Init(){} // RVA: 0x7FFAFC077170
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC077350
        public void GetMacSize(){} // RVA: 0x7FFAFC0773D0
        public void Update(){} // RVA: 0x7FFAFC0773E0
        public void BlockUpdate(){} // RVA: 0x7FFAFC077470
        public void DoFinal(){} // RVA: 0x7FFAFC0774A0
        public void Reset(){} // RVA: 0x7FFAFC077540
    }

    public class Gost28147Mac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC077570
        public void GenerateWorkingKey(){} // RVA: 0x7FFAFC077700
        public void Init(){} // RVA: 0x7FFAFC077830
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC077D40
        public void GetMacSize(){} // RVA: 0x7FFAF352E130
        public void gost28147_mainStep(){} // RVA: 0x7FFAFC077D80
        public void gost28147MacFunc(){} // RVA: 0x7FFAFC077EF0
        public void bytesToint(){} // RVA: 0x7FFAFC078110
        public void intTobytes(){} // RVA: 0x7FFAFC078190
        public void CM5func(){} // RVA: 0x7FFAFC078200
        public void Update(){} // RVA: 0x7FFAFC0782E0
        public void BlockUpdate(){} // RVA: 0x7FFAFC078410
        public void DoFinal(){} // RVA: 0x7FFAFC078780
        public void Reset(){} // RVA: 0x7FFAFC0789B0
    }

    public class HMac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0789F0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC078B90
        public void GetUnderlyingDigest(){} // RVA: 0x7FFAF2DA8380
        public void Init(){} // RVA: 0x7FFAFC078C00
        public void GetMacSize(){} // RVA: 0x7FFAF306ED50
        public void Update(){} // RVA: 0x7FFAFC079080
        public void BlockUpdate(){} // RVA: 0x7FFAFC0790E0
        public void DoFinal(){} // RVA: 0x7FFAFC079170
        public void Reset(){} // RVA: 0x7FFAFC0793F0
        public void XorPad(){} // RVA: 0x7FFAFC079480
    }

    public class ISO9797Alg3Mac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0795F0 | overloaded x4
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC079930
        public void Init(){} // RVA: 0x7FFAFC079970
        public void GetMacSize(){} // RVA: 0x7FFAF3A8C9F0
        public void Update(){} // RVA: 0x7FFAFC079F40
        public void BlockUpdate(){} // RVA: 0x7FFAFC079FF0
        public void DoFinal(){} // RVA: 0x7FFAFC07A220
        public void Reset(){} // RVA: 0x7FFAFC07A4D0
    }

    public class MacCFBBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC073810
        public void Init(){} // RVA: 0x7FFAFC073A70
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC073BB0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAF2E72850
        public void GetBlockSize(){} // RVA: 0x7FFAF3241DC0
        public void ProcessBlock(){} // RVA: 0x7FFAFC073CC0
        public void Reset(){} // RVA: 0x7FFAFC073EF0
        public void GetMacBlock(){} // RVA: 0x7FFAFC073F60
    }

    public class Poly1305
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC07A6B0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAFC07A890
        public void SetKey(){} // RVA: 0x7FFAFC07AAC0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC07B010
        public void GetMacSize(){} // RVA: 0x7FFAF4BBE2B0
        public void Update(){} // RVA: 0x7FFAFC07B0A0
        public void BlockUpdate(){} // RVA: 0x7FFAFC07B190
        public void ProcessBlock(){} // RVA: 0x7FFAFC07B270
        public void DoFinal(){} // RVA: 0x7FFAFC07B640
        public void Reset(){} // RVA: 0x7FFAFC07BA00
        public void mul32x32_64(){} // RVA: 0x7FFAF88CECE0
    }

    public class SipHash
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EE8000 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC07BA10
        public void GetMacSize(){} // RVA: 0x7FFAF3513AE0
        public void Init(){} // RVA: 0x7FFAFC07BAA0
        public void Update(){} // RVA: 0x7FFAFC07BC40
        public void BlockUpdate(){} // RVA: 0x7FFAFC07BC90
        public void DoFinal(){} // RVA: 0x7FFAFC07BF50 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAFC07BFA0
        public void ProcessMessageWord(){} // RVA: 0x7FFAFC07C000
        public void ApplySipRounds(){} // RVA: 0x7FFAFC07C040
        public void RotateLeft(){} // RVA: 0x7FFAF92A9B10
    }

    public class SkeinMac
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC07C1D0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC07C2E0
        public void Init(){} // RVA: 0x7FFAFC07C4A0
        public void GetMacSize(){} // RVA: 0x7FFAF39EF910
        public void Reset(){} // RVA: 0x7FFAFC07C890
        public void Update(){} // RVA: 0x7FFAFC07C8F0
        public void BlockUpdate(){} // RVA: 0x7FFAFC07C910
        public void DoFinal(){} // RVA: 0x7FFAFC07C940
    }

    public class VmpcMac
    {
        // ── Methods ──
        public void DoFinal(){} // RVA: 0x7FFAFC07C960
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC07CE50
        public void GetMacSize(){} // RVA: 0x7FFAF30AAB20
        public void Init(){} // RVA: 0x7FFAFC07CE90
        public void initKey(){} // RVA: 0x7FFAFC07D1A0
        public void Reset(){} // RVA: 0x7FFAFC07D430
        public void Update(){} // RVA: 0x7FFAFC07D510
        public void BlockUpdate(){} // RVA: 0x7FFAFC07D7A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}