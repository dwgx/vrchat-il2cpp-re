// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
// Classes: 5
// Methods: 45

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
{
    public class CtrSP800Drbg : Object
    {
        public long TDEA_RESEED_MAX;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE2090
        public void CTR_DRBG_Instantiate_algorithm(){} // RVA: 0x7FFE89FE2360
        public void CTR_DRBG_Update(){} // RVA: 0x7FFE89FE2590
        public void CTR_DRBG_Reseed_algorithm(){} // RVA: 0x7FFE89FE28F0
        public void XOR(){} // RVA: 0x7FFE89FE2B20
        public void AddOneTo(){} // RVA: 0x7FFE89FE2BA0
        public void GetEntropy(){} // RVA: 0x7FFE89FE2BF0
        public void Block_Cipher_df(){} // RVA: 0x7FFE89FE2CB0
        public void BCC(){} // RVA: 0x7FFE89FE31F0
        public void copyIntToByteArray(){} // RVA: 0x7FFE89FE34F0
        public void get_BlockSize(){} // RVA: 0x7FFE89FE3560
        public void Generate(){} // RVA: 0x7FFE89FE3580
        public void Reseed(){} // RVA: 0x7FFE89FE3A80
        public void IsTdea(){} // RVA: 0x7FFE89FE3A90
        public void GetMaxSecurityStrength(){} // RVA: 0x7FFE89FE3BA0
        public void ExpandKey(){} // RVA: 0x7FFE89FE3CA0
        public void PadKey(){} // RVA: 0x7FFE89FE3D80
        public void .cctor(){} // RVA: 0x7FFE89FE4050
    }

    public class DrbgUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE89FE4190
        public void GetMaxSecurityStrength(){} // RVA: 0x7FFE89FE4670 | overloaded x2
        public void HashDF(){} // RVA: 0x7FFE89FE47C0
        public void IsTooLarge(){} // RVA: 0x7FFE89FE12D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HMacSP800Drbg : Object
    {
        public long RESEED_MAX;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE6480
        public void hmac_DRBG_Update(){} // RVA: 0x7FFE89FE69B0
        public void hmac_DRBG_Update_Func(){} // RVA: 0x7FFE89FE69F0
        public void get_BlockSize(){} // RVA: 0x7FFE89FE6C00
        public void Generate(){} // RVA: 0x7FFE89FE6C20
        public void Reseed(){} // RVA: 0x7FFE89FE7140
        public void GetEntropy(){} // RVA: 0x7FFE89FE7370
        public void .cctor(){} // RVA: 0x7FFE89FE7430
    }

    public class HashSP800Drbg : Object
    {
        public byte[] ONE;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE89FE4D80
        public void .ctor(){} // RVA: 0x7FFE89FE5260
        public void get_BlockSize(){} // RVA: 0x7FFE89FE57F0
        public void Generate(){} // RVA: 0x7FFE89FE5850
        public void GetEntropy(){} // RVA: 0x7FFE89FE5C90
        public void AddTo(){} // RVA: 0x7FFE89FE5D50
        public void Reseed(){} // RVA: 0x7FFE89FE5E10
        public void Hash(){} // RVA: 0x7FFE89FE60D0
        public void DoHash(){} // RVA: 0x7FFE89FE6170
        public void hashgen(){} // RVA: 0x7FFE89FE6220
    }

    public class ISP80090Drbg
    {
        // ── Methods ──
        public void get_BlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void Generate(){}
        public void Reseed(){} // RVA: 0x7FFE80E460A0
    }

}