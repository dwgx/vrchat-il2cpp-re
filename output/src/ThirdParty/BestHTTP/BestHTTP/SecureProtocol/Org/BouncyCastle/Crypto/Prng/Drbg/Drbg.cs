// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
// Classes: 5
// Methods: 45

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
{
    public class CtrSP800Drbg : Object
    {
        public long BlockSize;
        public long AES_RESEED_MAX; // 0x8
        public int TDEA_MAX_BITS_REQUEST; // 0x10
        public int AES_MAX_BITS_REQUEST; // 0x14
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource mEntropySource; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher mEngine; // 0x18
        public int mKeySizeInBits; // 0x20
        public int mSeedLength; // 0x24
        public int mSecurityStrength; // 0x28
        public byte[] mKey; // 0x30
        public byte[] mV; // 0x38
        public long mReseedCounter; // 0x40
        public bool mIsTdea; // 0x48
        public byte[] K_BITS; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB88A70
        public void CTR_DRBG_Instantiate_algorithm(){} // RVA: 0x7FFACBB88D40
        public void CTR_DRBG_Update(){} // RVA: 0x7FFACBB88F70
        public void CTR_DRBG_Reseed_algorithm(){} // RVA: 0x7FFACBB892D0
        public void XOR(){} // RVA: 0x7FFACBB89500
        public void AddOneTo(){} // RVA: 0x7FFACBB89580
        public void GetEntropy(){} // RVA: 0x7FFACBB895D0
        public void Block_Cipher_df(){} // RVA: 0x7FFACBB89690
        public void BCC(){} // RVA: 0x7FFACBB89BD0
        public void copyIntToByteArray(){} // RVA: 0x7FFACBB89ED0
        public void get_BlockSize(){} // RVA: 0x7FFACBB89F40
        public void Generate(){} // RVA: 0x7FFACBB89F60
        public void Reseed(){} // RVA: 0x7FFACBB8A460
        public void IsTdea(){} // RVA: 0x7FFACBB8A470
        public void GetMaxSecurityStrength(){} // RVA: 0x7FFACBB8A580
        public void ExpandKey(){} // RVA: 0x7FFACBB8A680
        public void PadKey(){} // RVA: 0x7FFACBB8A760
        public void .cctor(){} // RVA: 0x7FFACBB8AA30
    }

    public class DrbgUtilities : Object
    {
        public System.Collections.IDictionary maxSecurityStrengths;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBB8AB70
        public void GetMaxSecurityStrength(){} // RVA: 0x7FFACBB8B050 | overloaded x2
        public void HashDF(){} // RVA: 0x7FFACBB8B1A0
        public void IsTooLarge(){} // RVA: 0x7FFACBB87CB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HMacSP800Drbg : Object
    {
        public long BlockSize;
        public int MAX_BITS_REQUEST; // 0x8
        public byte[] mK; // 0x10
        public byte[] mV; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource mEntropySource; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mHMac; // 0x28
        public int mSecurityStrength; // 0x30
        public long mReseedCounter; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB8CE60
        public void hmac_DRBG_Update(){} // RVA: 0x7FFACBB8D390
        public void hmac_DRBG_Update_Func(){} // RVA: 0x7FFACBB8D3D0
        public void get_BlockSize(){} // RVA: 0x7FFACBB8D5E0
        public void Generate(){} // RVA: 0x7FFACBB8D600
        public void Reseed(){} // RVA: 0x7FFACBB8DB20
        public void GetEntropy(){} // RVA: 0x7FFACBB8DD50
        public void .cctor(){} // RVA: 0x7FFACBB8DE10
    }

    public class HashSP800Drbg : Object
    {
        public byte[] BlockSize;
        public long RESEED_MAX; // 0x8
        public int MAX_BITS_REQUEST; // 0x10
        public System.Collections.IDictionary seedlens; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mDigest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource mEntropySource; // 0x18
        public int mSecurityStrength; // 0x20
        public int mSeedLength; // 0x24
        public byte[] mV; // 0x28
        public byte[] mC; // 0x30
        public long mReseedCounter; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBB8B760
        public void .ctor(){} // RVA: 0x7FFACBB8BC40
        public void get_BlockSize(){} // RVA: 0x7FFACBB8C1D0
        public void Generate(){} // RVA: 0x7FFACBB8C230
        public void GetEntropy(){} // RVA: 0x7FFACBB8C670
        public void AddTo(){} // RVA: 0x7FFACBB8C730
        public void Reseed(){} // RVA: 0x7FFACBB8C7F0
        public void Hash(){} // RVA: 0x7FFACBB8CAB0
        public void DoHash(){} // RVA: 0x7FFACBB8CB50
        public void hashgen(){} // RVA: 0x7FFACBB8CC00
    }

    public class ISP80090Drbg
    {
        public object BlockSize;

        // ── Methods ──
        public void get_BlockSize(){} // RVA: 0x7FFAC2C59960
        public void Generate(){}
        public void Reseed(){} // RVA: 0x7FFAC2C70A40
    }

}