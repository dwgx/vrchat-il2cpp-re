// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
// Classes: 15
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
{
    public class BasicEntropySourceProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A986DB30
        public void Get(){} // RVA: 0x7B13B1230
    }

    public class CryptoApiEntropySourceProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B1460
        public void Get(){} // RVA: 0x7B13B1510
    }

    public class CryptoApiRandomGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void AddSeedMaterial(){} // RVA: 0x7A80D7310
        public void NextBytes(){} // RVA: 0x7B13B16B0
    }

    public class DigestRandomGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B1850
        public void AddSeedMaterial(){} // RVA: 0x7B13B1BF0
        public void NextBytes(){} // RVA: 0x7B13B1DB0
        public void CycleSeed(){} // RVA: 0x7B13B1F60
        public void GenerateState(){} // RVA: 0x7B13B2000
        public void DigestAddCounter(){} // RVA: 0x7B13B21B0
        public void DigestUpdate(){} // RVA: 0x7B13B22E0
        public void DigestDoFinal(){} // RVA: 0x7B13B2360
    }

    public class EntropyUtilities : Object
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x7B13B23D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IDrbgProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7A7E00B20
    }

    public class IRandomGenerator
    {
        // ── Methods ──
        public void AddSeedMaterial(){} // RVA: 0x7A7E188D0
        public void NextBytes(){} // RVA: 0x7A7E1E220
    }

    public class ReversedWindowGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B2570
        public void AddSeedMaterial(){} // RVA: 0x7B13B2880
        public void NextBytes(){} // RVA: 0x7B13B2A00
        public void doNextBytes(){} // RVA: 0x7B13B2A10
    }

    public class SP800SecureRandom : SecureRandom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B2C40
        public void SetSeed(){} // RVA: 0x7B13B2EE0
        public void NextBytes(){} // RVA: 0x7B13B3220
        public void GenerateSeed(){} // RVA: 0x7B13B32D0
        public void Reseed(){} // RVA: 0x7B13B32E0
    }

    public class SP800SecureRandomBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B37D0
        public void SetPersonalizationString(){} // RVA: 0x7B136AFB0
        public void SetSecurityStrength(){} // RVA: 0x7AECD6310
        public void SetEntropyBitsRequired(){} // RVA: 0x7AECD6350
        public void BuildHash(){} // RVA: 0x7B13B3890
        public void BuildCtr(){} // RVA: 0x7B13B3A80
        public void BuildHMac(){} // RVA: 0x7B13B3C80
    }

    public class ThreadedSeedGenerator : Object
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x7B13B4190
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class VmpcRandomGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B4500
        public void AddSeedMaterial(){} // RVA: 0x7B13B46B0
        public void NextBytes(){} // RVA: 0x7B13B4780
    }

    public class X931Rng : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B4A20
        public void Generate(){} // RVA: 0x7B13B4CE0
        public void Reseed(){} // RVA: 0x7B13B5510
        public void get_EntropySource(){} // RVA: 0x7A80DA7B0
        public void Process(){} // RVA: 0x7B13B5650
        public void Increment(){} // RVA: 0x7B13B5740
        public void IsTooLarge(){} // RVA: 0x7B13B57A0
    }

    public class X931SecureRandom : SecureRandom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13B57B0
        public void SetSeed(){} // RVA: 0x7B13B5A00
        public void NextBytes(){} // RVA: 0x7B13B5DC0
        public void GenerateSeed(){} // RVA: 0x7B13B5E70
    }

    public class X931SecureRandomBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE59430
        public void SetDateTimeVector(){} // RVA: 0x7B136AFB0
        public void Build(){} // RVA: 0x7B13B61B0
    }

}