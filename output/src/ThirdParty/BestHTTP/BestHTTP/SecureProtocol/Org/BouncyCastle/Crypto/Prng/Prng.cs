// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
// Classes: 15
// Methods: 75

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
{
    public class BasicEntropySourceProvider : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45641A0
        public void Get(){} // RVA: 0x7FFAFC02A790
    }

    public class CryptoApiEntropySourceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC02A9C0 | overloaded x2
        public void Get(){} // RVA: 0x7FFAFC02AA70
    }

    public class CryptoApiRandomGenerator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void AddSeedMaterial(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFAFC02AC10 | overloaded x2
    }

    public class DigestRandomGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC02ADB0
        public void AddSeedMaterial(){} // RVA: 0x7FFAFC02B190 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFAFC02B380 | overloaded x2
        public void CycleSeed(){} // RVA: 0x7FFAFC02B570
        public void GenerateState(){} // RVA: 0x7FFAFC02B610
        public void DigestAddCounter(){} // RVA: 0x7FFAFC02B7C0
        public void DigestUpdate(){} // RVA: 0x7FFAFC02B8F0
        public void DigestDoFinal(){} // RVA: 0x7FFAFC02B970
    }

    public class EntropyUtilities
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x7FFAFC02B9E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IDrbgProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IRandomGenerator
    {
        // ── Methods ──
        public void AddSeedMaterial(){} // RVA: 0x7FFAF2AD4CC0 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
    }

    public class ReversedWindowGenerator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC02BB80
        public void AddSeedMaterial(){} // RVA: 0x7FFAFC02BEC0 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFAFC02C080 | overloaded x2
        public void doNextBytes(){} // RVA: 0x7FFAFC02C090
    }

    public class SP800SecureRandom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC02C300
        public void SetSeed(){} // RVA: 0x7FFAFC02C5E0 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFAFC02C9A0 | overloaded x2
        public void GenerateSeed(){} // RVA: 0x7FFAFC02CA50
        public void Reseed(){} // RVA: 0x7FFAFC02CA60
    }

    public class SP800SecureRandomBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC02CF90 | overloaded x3
        public void SetPersonalizationString(){} // RVA: 0x7FFAFBFE4C50
        public void SetSecurityStrength(){} // RVA: 0x7FFAF99A7C30
        public void SetEntropyBitsRequired(){} // RVA: 0x7FFAF99A7C70
        public void BuildHash(){} // RVA: 0x7FFAFC02D050
        public void BuildCtr(){} // RVA: 0x7FFAFC02D240
        public void BuildHMac(){} // RVA: 0x7FFAFC02D440
    }

    public class ThreadedSeedGenerator
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x7FFAFC02D950
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class VmpcRandomGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC02DCB0
        public void AddSeedMaterial(){} // RVA: 0x7FFAFC02DE60 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFAFC02DF30 | overloaded x2
    }

    public class X931Rng
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC02E200
        public void Generate(){} // RVA: 0x7FFAFC02E4B0
        public void Reseed(){} // RVA: 0x7FFAFC02ECA0
        public void get_EntropySource(){} // RVA: 0x7FFAF2D907C0
        public void Process(){} // RVA: 0x7FFAFC02EDE0
        public void Increment(){} // RVA: 0x7FFAFC02EEC0
        public void IsTooLarge(){} // RVA: 0x7FFAFC02EF00
    }

    public class X931SecureRandom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC02EF10
        public void SetSeed(){} // RVA: 0x7FFAFC02F1A0 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFAFC02F5D0 | overloaded x2
        public void GenerateSeed(){} // RVA: 0x7FFAFC02F680
    }

    public class X931SecureRandomBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B1D0E0 | overloaded x3
        public void SetDateTimeVector(){} // RVA: 0x7FFAFBFE4C50
        public void Build(){} // RVA: 0x7FFAFC02F9C0
    }

}