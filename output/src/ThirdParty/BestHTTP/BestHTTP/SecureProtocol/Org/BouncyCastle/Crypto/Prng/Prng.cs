// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
// Classes: 15
// Methods: 75

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
{
    public class BasicEntropySourceProvider : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AB41A0
        public void Get(){} // RVA: 0x957A790
    }

    public class CryptoApiEntropySourceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x957A9C0 | overloaded x2
        public void Get(){} // RVA: 0x957AA70
    }

    public class CryptoApiRandomGenerator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void AddSeedMaterial(){} // RVA: 0x2DD310 | overloaded x2
        public void NextBytes(){} // RVA: 0x957AC10 | overloaded x2
    }

    public class DigestRandomGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x957ADB0
        public void AddSeedMaterial(){} // RVA: 0x957B190 | overloaded x2
        public void NextBytes(){} // RVA: 0x957B380 | overloaded x2
        public void CycleSeed(){} // RVA: 0x957B570
        public void GenerateState(){} // RVA: 0x957B610
        public void DigestAddCounter(){} // RVA: 0x957B7C0
        public void DigestUpdate(){} // RVA: 0x957B8F0
        public void DigestDoFinal(){} // RVA: 0x957B970
    }

    public class EntropyUtilities
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x957B9E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IDrbgProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0xCE10
    }

    public class IRandomGenerator
    {
        // ── Methods ──
        public void AddSeedMaterial(){} // RVA: 0x24CC0 | overloaded x2
        public void NextBytes(){} // RVA: 0x24B10 | overloaded x2
    }

    public class ReversedWindowGenerator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x957BB80
        public void AddSeedMaterial(){} // RVA: 0x957BEC0 | overloaded x2
        public void NextBytes(){} // RVA: 0x957C080 | overloaded x2
        public void doNextBytes(){} // RVA: 0x957C090
    }

    public class SP800SecureRandom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x957C300
        public void SetSeed(){} // RVA: 0x957C5E0 | overloaded x2
        public void NextBytes(){} // RVA: 0x957C9A0 | overloaded x2
        public void GenerateSeed(){} // RVA: 0x957CA50
        public void Reseed(){} // RVA: 0x957CA60
    }

    public class SP800SecureRandomBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x957CF90 | overloaded x3
        public void SetPersonalizationString(){} // RVA: 0x9534C50
        public void SetSecurityStrength(){} // RVA: 0x6EF7C30
        public void SetEntropyBitsRequired(){} // RVA: 0x6EF7C70
        public void BuildHash(){} // RVA: 0x957D050
        public void BuildCtr(){} // RVA: 0x957D240
        public void BuildHMac(){} // RVA: 0x957D440
    }

    public class ThreadedSeedGenerator
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x957D950
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class VmpcRandomGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x957DCB0
        public void AddSeedMaterial(){} // RVA: 0x957DE60 | overloaded x2
        public void NextBytes(){} // RVA: 0x957DF30 | overloaded x2
    }

    public class X931Rng
    {
        public long BLOCK64_RESEED_MAX;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x957E200
        public void Generate(){} // RVA: 0x957E4B0
        public void Reseed(){} // RVA: 0x957ECA0
        public void get_EntropySource(){} // RVA: 0x2E07C0
        public void Process(){} // RVA: 0x957EDE0
        public void Increment(){} // RVA: 0x957EEC0
        public void IsTooLarge(){} // RVA: 0x957EF00
    }

    public class X931SecureRandom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x957EF10
        public void SetSeed(){} // RVA: 0x957F1A0 | overloaded x2
        public void NextBytes(){} // RVA: 0x957F5D0 | overloaded x2
        public void GenerateSeed(){} // RVA: 0x957F680
    }

    public class X931SecureRandomBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x606D0E0 | overloaded x3
        public void SetDateTimeVector(){} // RVA: 0x9534C50
        public void Build(){} // RVA: 0x957F9C0
    }

}