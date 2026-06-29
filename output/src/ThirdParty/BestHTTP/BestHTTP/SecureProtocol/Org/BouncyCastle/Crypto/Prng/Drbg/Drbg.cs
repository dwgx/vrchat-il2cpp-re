// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
// Classes: 5
// Methods: 44

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
{
    public class CtrSP800Drbg : Object
    {
        public object TDEA_RESEED_MAX;
        public object AES_RESEED_MAX;
        public object TDEA_MAX_BITS_REQUEST;
        public object AES_MAX_BITS_REQUEST;
        public object mEntropySource;
        public object mEngine;
        public object mKeySizeInBits;
        public object mSeedLength;
        public object mSecurityStrength;
        public object mKey;
        public object mV;
        public object mReseedCounter;
        public object mIsTdea;
        public object K_BITS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA221BB0
        public void CTR_DRBG_Instantiate_algorithm(){} // RVA: 0xA221E80
        public void CTR_DRBG_Update(){} // RVA: 0xA2220C0
        public void CTR_DRBG_Reseed_algorithm(){} // RVA: 0xA222410
        public void XOR(){} // RVA: 0xA222640
        public void AddOneTo(){} // RVA: 0xA2226C0
        public void GetEntropy(){} // RVA: 0xA222710
        public void Block_Cipher_df(){} // RVA: 0xA2227D0
        public void BCC(){} // RVA: 0xA222D10
        public void copyIntToByteArray(){} // RVA: 0xA223030
        public void get_BlockSize(){} // RVA: 0xA2230A0
        public void Generate(){} // RVA: 0xA2230C0
        public void Reseed(){} // RVA: 0xA2235C0
        public void IsTdea(){} // RVA: 0xA2235D0
        public void GetMaxSecurityStrength(){} // RVA: 0xA2236E0
        public void ExpandKey(){} // RVA: 0xA2237E0
        public void PadKey(){} // RVA: 0xA2238C0
        public void .cctor(){} // RVA: 0xA223BA0
    }

    public class DrbgUtilities : Object
    {
        public object maxSecurityStrengths;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA223CE0
        public void GetMaxSecurityStrength(){} // RVA: 0xA2241A0
        public void HashDF(){} // RVA: 0xA2242D0
        public void IsTooLarge(){} // RVA: 0xA220EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HMacSP800Drbg : Object
    {
        public object RESEED_MAX;
        public object MAX_BITS_REQUEST;
        public object mK;
        public object mV;
        public object mEntropySource;
        public object mHMac;
        public object mSecurityStrength;
        public object mReseedCounter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA225FA0
        public void hmac_DRBG_Update(){} // RVA: 0xA2264C0
        public void hmac_DRBG_Update_Func(){} // RVA: 0xA226500
        public void get_BlockSize(){} // RVA: 0xA226710
        public void Generate(){} // RVA: 0xA226730
        public void Reseed(){} // RVA: 0xA226C50
        public void GetEntropy(){} // RVA: 0xA226E80
        public void .cctor(){} // RVA: 0xA226F40
    }

    public class HashSP800Drbg : Object
    {
        public object ONE;
        public object RESEED_MAX;
        public object MAX_BITS_REQUEST;
        public object seedlens;
        public object mDigest;
        public object mEntropySource;
        public object mSecurityStrength;
        public object mSeedLength;
        public object mV;
        public object mC;
        public object mReseedCounter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA224890
        public void .ctor(){} // RVA: 0xA224D60
        public void get_BlockSize(){} // RVA: 0xA2252D0
        public void Generate(){} // RVA: 0xA225330
        public void GetEntropy(){} // RVA: 0xA225790
        public void AddTo(){} // RVA: 0xA225850
        public void Reseed(){} // RVA: 0xA225930
        public void Hash(){} // RVA: 0xA225BF0
        public void DoHash(){} // RVA: 0xA225C90
        public void hashgen(){} // RVA: 0xA225D40
    }

    public class ISP80090Drbg
    {
        // ── Methods ──
        public void get_BlockSize(){} // RVA: 0x87C130
        public void Generate(){} // RVA: 0x883010
        public void Reseed(){} // RVA: 0x894320
    }

}