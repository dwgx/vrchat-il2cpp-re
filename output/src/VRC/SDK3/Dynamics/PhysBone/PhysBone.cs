// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Dynamics.PhysBone
// Classes: 2
// Methods: 12

namespace VRC.SDK3.Dynamics.PhysBone
{
    public class PhysBoneMigration : Object
    {
        public object HumanoidBoneCache;
        public object StiffToMaxAngle;
        public object HasInitDBConversionTables;

        // ── Methods ──
        public void Convert(){} // RVA: 0x832BD40
        public void InitConversionTables(){} // RVA: 0x832C540
        public void AverageWorldBoneLength(){} // RVA: 0x832C8D0
        public void IsPartOfHand(){} // RVA: 0x832CCD0
        public void GetAllHumanoidTransforms(){} // RVA: 0x832D010
        public void FindValidTransforms(){} // RVA: 0x832D210
        public void SmoothCurve(){} // RVA: 0x832D4B0
        public void .cctor(){} // RVA: 0x832D5B0
        public void <Convert>g__CreatePBChain|3_0(){} // RVA: 0x832D6A0
        public void <IsPartOfHand>g__IsChildOf|8_0(){} // RVA: 0x832F5C0
    }

    public class PhysBonePerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x832FB90
        public void .ctor(){} // RVA: 0x832AF20
    }

}