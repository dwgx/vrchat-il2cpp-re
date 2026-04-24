// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Dynamics.PhysBone
// Classes: 2
// Methods: 12

namespace VRC.SDK3.Dynamics.PhysBone
{
    public class PhysBoneMigration : Object
    {
        public object HasInitDBConversionTables; // 0x3399C7C0
        public object 0 00; // 0x854C81B0

        // ── Original Methods ──
        public void Convert(){} // RVA: 0x7ffaaf899dc0
        public void InitConversionTables(){} // RVA: 0x7ffaaf89a560
        public void AverageWorldBoneLength(){} // RVA: 0x7ffaaf89a8f0
        public void IsPartOfHand(){} // RVA: 0x7ffaaf89ad70
        public void FindValidTransforms(){} // RVA: 0x7ffaaf89b330
        public void SmoothCurve(){} // RVA: 0x7ffaaf89b630
        public void .cctor(){} // RVA: 0x7ffaaf89b700
        public void <Convert>g__CreatePBChain|3_0(){} // RVA: 0x7ffaaf89b7f0
        public void <IsPartOfHand>g__IsChildOf|8_0(){} // RVA: 0x7ffaaf89d8f0
        // ── Binary Analysis Named ──
        public void GetAllHumanoidTransforms(){} // RVA: 0x7ffaaf89b0f0
    }

    public class PhysBonePerformanceScanner : AbstractPerformanceScanner
    {
        // ── Original Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7ffaaf89df10
        public void .ctor(){} // RVA: 0x7ffaaf898fe0
    }

}