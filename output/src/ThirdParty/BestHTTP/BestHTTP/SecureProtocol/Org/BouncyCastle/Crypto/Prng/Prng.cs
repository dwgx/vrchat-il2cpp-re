// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
// Classes: 15
// Methods: 75

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
{
    public class BasicEntropySourceProvider : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom mSecureRandom; // 0x10
        public bool mPredictionResistant; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45687E0
        public void Get(){} // RVA: 0x7FFACBB83540
    }

    public class CryptoApiEntropySourceProvider : Object
    {
        public System.Security.Cryptography.RandomNumberGenerator mRng; // 0x10
        public bool mPredictionResistant; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB83770 | overloaded x2
        public void Get(){} // RVA: 0x7FFACBB83820
    }

    public class CryptoApiRandomGenerator : Object
    {
        public System.Security.Cryptography.RandomNumberGenerator rndProv; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void AddSeedMaterial(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFACBB839C0 | overloaded x2
    }

    public class DigestRandomGenerator : Object
    {
        public long CYCLE_COUNT;
        public long stateCounter; // 0x10
        public long seedCounter; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x20
        public byte[] state; // 0x28
        public byte[] seed; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB83B60
        public void AddSeedMaterial(){} // RVA: 0x7FFACBB83F40 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFACBB84130 | overloaded x2
        public void CycleSeed(){} // RVA: 0x7FFACBB84320
        public void GenerateState(){} // RVA: 0x7FFACBB843C0
        public void DigestAddCounter(){} // RVA: 0x7FFACBB84570
        public void DigestUpdate(){} // RVA: 0x7FFACBB846A0
        public void DigestDoFinal(){} // RVA: 0x7FFACBB84720
    }

    public class EntropyUtilities : Object
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x7FFACBB84790
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IDrbgProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2C58F40
    }

    public class IRandomGenerator
    {
        // ── Methods ──
        public void AddSeedMaterial(){} // RVA: 0x7FFAC2C70BF0 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
    }

    public class ReversedWindowGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.IRandomGenerator generator; // 0x10
        public byte[] window; // 0x18
        public int windowCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB84930
        public void AddSeedMaterial(){} // RVA: 0x7FFACBB84C70 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFACBB84E30 | overloaded x2
        public void doNextBytes(){} // RVA: 0x7FFACBB84E40
    }

    public class SP800SecureRandom : SecureRandom
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.IDrbgProvider mDrbgProvider; // 0x28
        public bool mPredictionResistant; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom mRandomSource; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource mEntropySource; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg.ISP80090Drbg mDrbg; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB850B0
        public void SetSeed(){} // RVA: 0x7FFACBB85390 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFACBB85750 | overloaded x2
        public void GenerateSeed(){} // RVA: 0x7FFACBB85800
        public void Reseed(){} // RVA: 0x7FFACBB85810
    }

    public class SP800SecureRandomBuilder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom mRandom; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySourceProvider mEntropySourceProvider; // 0x18
        public byte[] mPersonalizationString; // 0x20
        public int mSecurityStrength; // 0x28
        public int mEntropyBitsRequired; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB85D40 | overloaded x3
        public void SetPersonalizationString(){} // RVA: 0x7FFACBB3DA00
        public void SetSecurityStrength(){} // RVA: 0x7FFAC9690360
        public void SetEntropyBitsRequired(){} // RVA: 0x7FFAC96903A0
        public void BuildHash(){} // RVA: 0x7FFACBB85E00
        public void BuildCtr(){} // RVA: 0x7FFACBB85FF0
        public void BuildHMac(){} // RVA: 0x7FFACBB861F0
    }

    public class ThreadedSeedGenerator : Object
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x7FFACBB86700
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class VmpcRandomGenerator : Object
    {
        public byte n; // 0x10
        public byte[] P; // 0x18
        public byte s; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB86A60
        public void AddSeedMaterial(){} // RVA: 0x7FFACBB86C10 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFACBB86CE0 | overloaded x2
    }

    public class X931Rng : Object
    {
        public long EntropySource;
        public long BLOCK128_RESEED_MAX;
        public int BLOCK64_MAX_BITS_REQUEST;
        public int BLOCK128_MAX_BITS_REQUEST;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher mEngine; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource mEntropySource; // 0x18
        public byte[] mDT; // 0x20
        public byte[] mI; // 0x28
        public byte[] mR; // 0x30
        public byte[] mV; // 0x38
        public long mReseedCounter; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB86FB0
        public void Generate(){} // RVA: 0x7FFACBB87260
        public void Reseed(){} // RVA: 0x7FFACBB87A50
        public void get_EntropySource(){} // RVA: 0x7FFAC2F247C0
        public void Process(){} // RVA: 0x7FFACBB87B90
        public void Increment(){} // RVA: 0x7FFACBB87C70
        public void IsTooLarge(){} // RVA: 0x7FFACBB87CB0
    }

    public class X931SecureRandom : SecureRandom
    {
        public bool mPredictionResistant; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom mRandomSource; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.X931Rng mDrbg; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB87CC0
        public void SetSeed(){} // RVA: 0x7FFACBB87F50 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFACBB88380 | overloaded x2
        public void GenerateSeed(){} // RVA: 0x7FFACBB88430
    }

    public class X931SecureRandomBuilder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom mRandom; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySourceProvider mEntropySourceProvider; // 0x18
        public byte[] mDateTimeVector; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8804790 | overloaded x3
        public void SetDateTimeVector(){} // RVA: 0x7FFACBB3DA00
        public void Build(){} // RVA: 0x7FFACBB88770
    }

}