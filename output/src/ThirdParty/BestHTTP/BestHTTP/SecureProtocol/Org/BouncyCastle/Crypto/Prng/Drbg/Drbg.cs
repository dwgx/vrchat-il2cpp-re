// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
// Classes: 5
// Methods: 45

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
{
    public class CtrSP800Drbg
    {
        public long TDEA_RESEED_MAX;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x957FCC0
        public void CTR_DRBG_Instantiate_algorithm(){} // RVA: 0x957FF90
        public void CTR_DRBG_Update(){} // RVA: 0x95801C0
        public void CTR_DRBG_Reseed_algorithm(){} // RVA: 0x9580520
        public void XOR(){} // RVA: 0x9580750
        public void AddOneTo(){} // RVA: 0x95807D0
        public void GetEntropy(){} // RVA: 0x9580820
        public void Block_Cipher_df(){} // RVA: 0x95808E0
        public void BCC(){} // RVA: 0x9580E20
        public void copyIntToByteArray(){} // RVA: 0x9581120
        public void get_BlockSize(){} // RVA: 0x9581190
        public void Generate(){} // RVA: 0x95811B0
        public void Reseed(){} // RVA: 0x95816B0
        public void IsTdea(){} // RVA: 0x95816C0
        public void GetMaxSecurityStrength(){} // RVA: 0x95817D0
        public void ExpandKey(){} // RVA: 0x95818D0
        public void PadKey(){} // RVA: 0x95819B0
        public void .cctor(){} // RVA: 0x9581C80
    }

    public class DrbgUtilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9581DC0
        public void GetMaxSecurityStrength(){} // RVA: 0x95822A0 | overloaded x2
        public void HashDF(){} // RVA: 0x95823F0
        public void IsTooLarge(){} // RVA: 0x957EF00
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HMacSP800Drbg
    {
        public long RESEED_MAX;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95840B0
        public void hmac_DRBG_Update(){} // RVA: 0x95845E0
        public void hmac_DRBG_Update_Func(){} // RVA: 0x9584620
        public void get_BlockSize(){} // RVA: 0x9584830
        public void Generate(){} // RVA: 0x9584850
        public void Reseed(){} // RVA: 0x9584D70
        public void GetEntropy(){} // RVA: 0x9584FA0
        public void .cctor(){} // RVA: 0x9585060
    }

    public class HashSP800Drbg
    {
        public byte[] ONE;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x95829B0
        public void .ctor(){} // RVA: 0x9582E90
        public void get_BlockSize(){} // RVA: 0x9583420
        public void Generate(){} // RVA: 0x9583480
        public void GetEntropy(){} // RVA: 0x95838C0
        public void AddTo(){} // RVA: 0x9583980
        public void Reseed(){} // RVA: 0x9583A40
        public void Hash(){} // RVA: 0x9583D00
        public void DoHash(){} // RVA: 0x9583DA0
        public void hashgen(){} // RVA: 0x9583E50
    }

    public class ISP80090Drbg
    {
        // ── Methods ──
        public void get_BlockSize(){} // RVA: 0xD840
        public void Generate(){}
        public void Reseed(){} // RVA: 0x24B10
    }

}