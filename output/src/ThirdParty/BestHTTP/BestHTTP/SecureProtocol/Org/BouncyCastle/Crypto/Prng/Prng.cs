// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
// Classes: 15
// Methods: 75

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
{
    public class BasicEntropySourceProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828378F0
        public void Get(){} // RVA: 0x7FFE89FDCB60
    }

    public class CryptoApiEntropySourceProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FDCD90 | overloaded x2
        public void Get(){} // RVA: 0x7FFE89FDCE40
    }

    public class CryptoApiRandomGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void AddSeedMaterial(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFE89FDCFE0 | overloaded x2
    }

    public class DigestRandomGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FDD180
        public void AddSeedMaterial(){} // RVA: 0x7FFE89FDD560 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFE89FDD750 | overloaded x2
        public void CycleSeed(){} // RVA: 0x7FFE89FDD940
        public void GenerateState(){} // RVA: 0x7FFE89FDD9E0
        public void DigestAddCounter(){} // RVA: 0x7FFE89FDDB90
        public void DigestUpdate(){} // RVA: 0x7FFE89FDDCC0
        public void DigestDoFinal(){} // RVA: 0x7FFE89FDDD40
    }

    public class EntropyUtilities : Object
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x7FFE89FDDDB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IDrbgProvider
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE80E2E390
    }

    public class IRandomGenerator
    {
        // ── Methods ──
        public void AddSeedMaterial(){} // RVA: 0x7FFE80E46250 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFE80E460A0 | overloaded x2
    }

    public class ReversedWindowGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FDDF50
        public void AddSeedMaterial(){} // RVA: 0x7FFE89FDE290 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFE89FDE450 | overloaded x2
        public void doNextBytes(){} // RVA: 0x7FFE89FDE460
    }

    public class SP800SecureRandom : SecureRandom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FDE6D0
        public void SetSeed(){} // RVA: 0x7FFE89FDE9B0 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFE89FDED70 | overloaded x2
        public void GenerateSeed(){} // RVA: 0x7FFE89FDEE20
        public void Reseed(){} // RVA: 0x7FFE89FDEE30
    }

    public class SP800SecureRandomBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FDF360 | overloaded x3
        public void SetPersonalizationString(){} // RVA: 0x7FFE89F97020
        public void SetSecurityStrength(){} // RVA: 0x7FFE87A38AC0
        public void SetEntropyBitsRequired(){} // RVA: 0x7FFE87A38B00
        public void BuildHash(){} // RVA: 0x7FFE89FDF420
        public void BuildCtr(){} // RVA: 0x7FFE89FDF610
        public void BuildHMac(){} // RVA: 0x7FFE89FDF810
    }

    public class ThreadedSeedGenerator : Object
    {
        // ── Methods ──
        public void GenerateSeed(){} // RVA: 0x7FFE89FDFD20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class VmpcRandomGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE0080
        public void AddSeedMaterial(){} // RVA: 0x7FFE89FE0230 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFE89FE0300 | overloaded x2
    }

    public class X931Rng : Object
    {
        public long BLOCK64_RESEED_MAX;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE05D0
        public void Generate(){} // RVA: 0x7FFE89FE0880
        public void Reseed(){} // RVA: 0x7FFE89FE1070
        public void get_EntropySource(){} // RVA: 0x7FFE810FE7C0
        public void Process(){} // RVA: 0x7FFE89FE11B0
        public void Increment(){} // RVA: 0x7FFE89FE1290
        public void IsTooLarge(){} // RVA: 0x7FFE89FE12D0
    }

    public class X931SecureRandom : SecureRandom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE12E0
        public void SetSeed(){} // RVA: 0x7FFE89FE1570 | overloaded x2
        public void NextBytes(){} // RVA: 0x7FFE89FE19A0 | overloaded x2
        public void GenerateSeed(){} // RVA: 0x7FFE89FE1A50
    }

    public class X931SecureRandomBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BADEB0 | overloaded x3
        public void SetDateTimeVector(){} // RVA: 0x7FFE89F97020
        public void Build(){} // RVA: 0x7FFE89FE1D90
    }

}