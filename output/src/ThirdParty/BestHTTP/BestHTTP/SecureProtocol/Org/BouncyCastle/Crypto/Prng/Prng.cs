// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
// Classes: 15
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
{
    public class BasicEntropySourceProvider : Object
    {
        public object mSecureRandom;
        public object mPredictionResistant;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x237A5A0
        public void Get(){} // RVA: 0xA21C930
    }

    public class CryptoApiEntropySourceProvider : Object
    {
        public object mRng;
        public object mPredictionResistant;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA21CB60
        public void Get(){} // RVA: 0xA21CC10
    }

    public class CryptoApiRandomGenerator : Object
    {
        public object rndProv;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void AddSeedMaterial(){} // RVA: 0xB43310
        public void NextBytes(){} // RVA: 0xA21CDB0
    }

    public class DigestRandomGenerator : Object
    {
        public object CYCLE_COUNT;
        public object stateCounter;
        public object seedCounter;
        public object digest;
        public object state;
        public object seed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA21CF50
        public void AddSeedMaterial(){} // RVA: 0xA21D2F0
        public void NextBytes(){} // RVA: 0xA21D4B0
        public void CycleSeed(){} // RVA: 0xA21D660
        public void GenerateState(){} // RVA: 0xA21D700
        public void DigestAddCounter(){} // RVA: 0xA21D8B0
        public void DigestUpdate(){} // RVA: 0xA21D9E0
        public void DigestDoFinal(){} // RVA: 0xA21DA60
    }

    public class EntropyUtilities : Object
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0xA21DAD0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IDrbgProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x87C540
    }

    public class IRandomGenerator
    {
        // ── Methods ──
        public void AddSeedMaterial(){} // RVA: 0x8943F0
        public void NextBytes(){} // RVA: 0x89B9B0
    }

    public class ReversedWindowGenerator : Object
    {
        public object generator;
        public object window;
        public object windowCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA21DC70
        public void AddSeedMaterial(){} // RVA: 0xA21DF80
        public void NextBytes(){} // RVA: 0xA21E100
        public void doNextBytes(){} // RVA: 0xA21E110
    }

    public class SP800SecureRandom : SecureRandom
    {
        public object mDrbgProvider;
        public object mPredictionResistant;
        public object mRandomSource;
        public object mEntropySource;
        public object mDrbg;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA21E340
        public void SetSeed(){} // RVA: 0xA21E5E0
        public void NextBytes(){} // RVA: 0xA21E920
        public void GenerateSeed(){} // RVA: 0xA21E9D0
        public void Reseed(){} // RVA: 0xA21E9E0
    }

    public class SP800SecureRandomBuilder : Object
    {
        public object mRandom;
        public object mEntropySourceProvider;
        public object mPersonalizationString;
        public object mSecurityStrength;
        public object mEntropyBitsRequired;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA21EED0
        public void SetPersonalizationString(){} // RVA: 0xA1D6890
        public void SetSecurityStrength(){} // RVA: 0x7943910
        public void SetEntropyBitsRequired(){} // RVA: 0x7943950
        public void BuildHash(){} // RVA: 0xA21EF90
        public void BuildCtr(){} // RVA: 0xA21F180
        public void BuildHMac(){} // RVA: 0xA21F380
    }

    public class ThreadedSeedGenerator : Object
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0xA21F890
        public void .ctor(){} // RVA: 0xB43310
    }

    public class VmpcRandomGenerator : Object
    {
        public object n;
        public object P;
        public object s;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA21FC00
        public void AddSeedMaterial(){} // RVA: 0xA21FDB0
        public void NextBytes(){} // RVA: 0xA21FE80
    }

    public class X931Rng : Object
    {
        public object BLOCK64_RESEED_MAX;
        public object BLOCK128_RESEED_MAX;
        public object BLOCK64_MAX_BITS_REQUEST;
        public object BLOCK128_MAX_BITS_REQUEST;
        public object mEngine;
        public object mEntropySource;
        public object mDT;
        public object mI;
        public object mR;
        public object mV;
        public object mReseedCounter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA220120
        public void Generate(){} // RVA: 0xA2203E0
        public void Reseed(){} // RVA: 0xA220C10
        public void get_EntropySource(){} // RVA: 0xB465B0
        public void Process(){} // RVA: 0xA220D50
        public void Increment(){} // RVA: 0xA220E40
        public void IsTooLarge(){} // RVA: 0xA220EA0
    }

    public class X931SecureRandom : SecureRandom
    {
        public object mPredictionResistant;
        public object mRandomSource;
        public object mDrbg;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA220EB0
        public void SetSeed(){} // RVA: 0xA221100
        public void NextBytes(){} // RVA: 0xA2214C0
        public void GenerateSeed(){} // RVA: 0xA221570
    }

    public class X931SecureRandomBuilder : Object
    {
        public object mRandom;
        public object mEntropySourceProvider;
        public object mDateTimeVector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AE09C0
        public void SetDateTimeVector(){} // RVA: 0xA1D6890
        public void Build(){} // RVA: 0xA2218B0
    }

}