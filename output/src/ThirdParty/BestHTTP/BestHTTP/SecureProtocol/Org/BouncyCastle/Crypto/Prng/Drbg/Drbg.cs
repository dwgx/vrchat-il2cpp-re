// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
// Classes: 5
// Methods: 45

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
{
    public class CtrSP800Drbg
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC02FCC0
        public void CTR_DRBG_Instantiate_algorithm(){} // RVA: 0x7FFAFC02FF90
        public void CTR_DRBG_Update(){} // RVA: 0x7FFAFC0301C0
        public void CTR_DRBG_Reseed_algorithm(){} // RVA: 0x7FFAFC030520
        public void XOR(){} // RVA: 0x7FFAFC030750
        public void AddOneTo(){} // RVA: 0x7FFAFC0307D0
        public void GetEntropy(){} // RVA: 0x7FFAFC030820
        public void Block_Cipher_df(){} // RVA: 0x7FFAFC0308E0
        public void BCC(){} // RVA: 0x7FFAFC030E20
        public void copyIntToByteArray(){} // RVA: 0x7FFAFC031120
        public void get_BlockSize(){} // RVA: 0x7FFAFC031190
        public void Generate(){} // RVA: 0x7FFAFC0311B0
        public void Reseed(){} // RVA: 0x7FFAFC0316B0
        public void IsTdea(){} // RVA: 0x7FFAFC0316C0
        public void GetMaxSecurityStrength(){} // RVA: 0x7FFAFC0317D0
        public void ExpandKey(){} // RVA: 0x7FFAFC0318D0
        public void PadKey(){} // RVA: 0x7FFAFC0319B0
        public void .cctor(){} // RVA: 0x7FFAFC031C80
    }

    public class DrbgUtilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC031DC0
        public void GetMaxSecurityStrength(){} // RVA: 0x7FFAFC0322A0 | overloaded x2
        public void HashDF(){} // RVA: 0x7FFAFC0323F0
        public void IsTooLarge(){} // RVA: 0x7FFAFC02EF00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HMacSP800Drbg
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0340B0
        public void hmac_DRBG_Update(){} // RVA: 0x7FFAFC0345E0
        public void hmac_DRBG_Update_Func(){} // RVA: 0x7FFAFC034620
        public void get_BlockSize(){} // RVA: 0x7FFAFC034830
        public void Generate(){} // RVA: 0x7FFAFC034850
        public void Reseed(){} // RVA: 0x7FFAFC034D70
        public void GetEntropy(){} // RVA: 0x7FFAFC034FA0
        public void .cctor(){} // RVA: 0x7FFAFC035060
    }

    public class HashSP800Drbg
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC0329B0
        public void .ctor(){} // RVA: 0x7FFAFC032E90
        public void get_BlockSize(){} // RVA: 0x7FFAFC033420
        public void Generate(){} // RVA: 0x7FFAFC033480
        public void GetEntropy(){} // RVA: 0x7FFAFC0338C0
        public void AddTo(){} // RVA: 0x7FFAFC033980
        public void Reseed(){} // RVA: 0x7FFAFC033A40
        public void Hash(){} // RVA: 0x7FFAFC033D00
        public void DoHash(){} // RVA: 0x7FFAFC033DA0
        public void hashgen(){} // RVA: 0x7FFAFC033E50
    }

    public class ISP80090Drbg
    {
        // ── Methods ──
        public void get_BlockSize(){} // RVA: 0x7FFAF2ABD840
        public void Generate(){}
        public void Reseed(){} // RVA: 0x7FFAF2AD4B10
    }

}