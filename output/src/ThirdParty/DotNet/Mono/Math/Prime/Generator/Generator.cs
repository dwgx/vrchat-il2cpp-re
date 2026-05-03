// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Math.Prime.Generator
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.Mono.Math.Prime.Generator
{
    public class PrimeGeneratorBase : Object
    {
        // ── Methods ──
        public void get_Confidence(){} // RVA: 0x7FFE81200CB0
        public void get_PrimalityTest(){} // RVA: 0x7FFE867309C0
        public void get_TrialDivisionBounds(){} // RVA: 0x7FFE86730A30
        public void GenerateNewPrime(){} // RVA: 0x7FFE80E3D230
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
    {
        // ── Methods ──
        public void GenerateSearchBase(){} // RVA: 0x7FFE86730A40
        public void GenerateNewPrime(){} // RVA: 0x7FFE86730AE0 | overloaded x2
        public void IsPrimeAcceptable(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}