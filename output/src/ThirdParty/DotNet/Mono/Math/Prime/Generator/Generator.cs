// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Math.Prime.Generator
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.Mono.Math.Prime.Generator
{
    public class PrimeGeneratorBase : Object
    {
        public object Confidence;
        public object PrimalityTest;
        public object TrialDivisionBounds;

        // ── Methods ──
        public void get_Confidence(){} // RVA: 0x7FFAC3026CB0
        public void get_PrimalityTest(){} // RVA: 0x7FFAC83870C0
        public void get_TrialDivisionBounds(){} // RVA: 0x7FFAC8387130
        public void GenerateNewPrime(){} // RVA: 0x7FFAC2C67DE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
    {
        // ── Methods ──
        public void GenerateSearchBase(){} // RVA: 0x7FFAC8387140
        public void GenerateNewPrime(){} // RVA: 0x7FFAC83871E0 | overloaded x2
        public void IsPrimeAcceptable(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}