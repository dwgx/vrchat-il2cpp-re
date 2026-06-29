// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
// Classes: 5
// Methods: 44

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
{
    public class CtrSP800Drbg : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B64B0
        public void CTR_DRBG_Instantiate_algorithm(){} // RVA: 0x7B13B6780
        public void CTR_DRBG_Update(){} // RVA: 0x7B13B69C0
        public void CTR_DRBG_Reseed_algorithm(){} // RVA: 0x7B13B6D10
        public void XOR(){} // RVA: 0x7B13B6F40
        public void AddOneTo(){} // RVA: 0x7B13B6FC0
        public void GetEntropy(){} // RVA: 0x7B13B7010
        public void Block_Cipher_df(){} // RVA: 0x7B13B70D0
        public void BCC(){} // RVA: 0x7B13B7610
        public void copyIntToByteArray(){} // RVA: 0x7B13B7930
        public void get_BlockSize(){} // RVA: 0x7B13B79A0
        public void Generate(){} // RVA: 0x7B13B79C0
        public void Reseed(){} // RVA: 0x7B13B7EC0
        public void IsTdea(){} // RVA: 0x7B13B7ED0
        public void GetMaxSecurityStrength(){} // RVA: 0x7B13B7FE0
        public void ExpandKey(){} // RVA: 0x7B13B80E0
        public void PadKey(){} // RVA: 0x7B13B81C0
        public void .cctor(){} // RVA: 0x7B13B84A0
    }

    public class DrbgUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B13B85E0
        public void GetMaxSecurityStrength(){} // RVA: 0x7B13B8AC0
        public void HashDF(){} // RVA: 0x7B13B8C10
        public void IsTooLarge(){} // RVA: 0x7B13B57A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HMacSP800Drbg : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BA920
        public void hmac_DRBG_Update(){} // RVA: 0x7B13BAE50
        public void hmac_DRBG_Update_Func(){} // RVA: 0x7B13BAE90
        public void get_BlockSize(){} // RVA: 0x7B13BB0A0
        public void Generate(){} // RVA: 0x7B13BB0C0
        public void Reseed(){} // RVA: 0x7B13BB5E0
        public void GetEntropy(){} // RVA: 0x7B13BB810
        public void .cctor(){} // RVA: 0x7B13BB8D0
    }

    public class HashSP800Drbg : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B13B91D0
        public void .ctor(){} // RVA: 0x7B13B96B0
        public void get_BlockSize(){} // RVA: 0x7B13B9C50
        public void Generate(){} // RVA: 0x7B13B9CB0
        public void GetEntropy(){} // RVA: 0x7B13BA110
        public void AddTo(){} // RVA: 0x7B13BA1D0
        public void Reseed(){} // RVA: 0x7B13BA2B0
        public void Hash(){} // RVA: 0x7B13BA570
        public void DoHash(){} // RVA: 0x7B13BA610
        public void hashgen(){} // RVA: 0x7B13BA6C0
    }

    public class ISP80090Drbg
    {
        // ── Methods ──
        public void get_BlockSize(){} // RVA: 0x7A7E00710
        public void Generate(){} // RVA: 0x7A7E07650
        public void Reseed(){} // RVA: 0x7A7E18800
    }

}