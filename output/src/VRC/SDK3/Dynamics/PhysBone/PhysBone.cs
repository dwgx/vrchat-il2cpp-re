// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Dynamics.PhysBone
// Classes: 2
// Methods: 12

namespace VRC.SDK3.Dynamics.PhysBone
{
    public class PhysBoneMigration : Object
    {
        public URA.woDigitYearMax<?> HumanoidBoneCache;
        public ÍÎÌÍÍÌÌÎÏÏ StiffToMaxAngle; // 0x8
        public bool HasInitDBConversionTables; // 0x10

        // ── Methods ──
        public void Convert(){} // RVA: 0x7FFD552973A0
        public void InitConversionTables(){} // RVA: 0x7FFD55297B40
        public void AverageWorldBoneLength(){} // RVA: 0x7FFD55297ED0
        public void IsPartOfHand(){} // RVA: 0x7FFD55298350
        public void GetAllHumanoidTransforms(){} // RVA: 0x7FFD552986D0
        public void FindValidTransforms(){} // RVA: 0x7FFD55298910
        public void SmoothCurve(){} // RVA: 0x7FFD55298C10
        public void .cctor(){} // RVA: 0x7FFD55298CE0
        public void <Convert>g__CreatePBChain|3_0(){} // RVA: 0x7FFD55298DD0
        public void <IsPartOfHand>g__IsChildOf|8_0(){} // RVA: 0x7FFD5529AED0
    }

    public class PhysBonePerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFD5529B4F0
        public void .ctor(){} // RVA: 0x7FFD552965C0
    }

}