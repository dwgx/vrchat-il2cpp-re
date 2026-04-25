// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Dynamics.PhysBone
// Classes: 2
// Methods: 12

namespace VRC.SDK3.Dynamics.PhysBone
{
    public class PhysBoneMigration : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.Transform> HumanoidBoneCache;
        public UnityEngine.AnimationCurve StiffToMaxAngle; // 0x8
        public bool HasInitDBConversionTables; // 0x10

        // ── Methods ──
        public void Convert(){} // RVA: 0x7FFAC9E773A0
        public void InitConversionTables(){} // RVA: 0x7FFAC9E77B40
        public void AverageWorldBoneLength(){} // RVA: 0x7FFAC9E77ED0
        public void IsPartOfHand(){} // RVA: 0x7FFAC9E78350
        public void GetAllHumanoidTransforms(){} // RVA: 0x7FFAC9E786D0
        public void FindValidTransforms(){} // RVA: 0x7FFAC9E78910
        public void SmoothCurve(){} // RVA: 0x7FFAC9E78C10
        public void .cctor(){} // RVA: 0x7FFAC9E78CE0
        public void <Convert>g__CreatePBChain|3_0(){} // RVA: 0x7FFAC9E78DD0
        public void <IsPartOfHand>g__IsChildOf|8_0(){} // RVA: 0x7FFAC9E7AED0
    }

    public class PhysBonePerformanceScanner : AbstractPerformanceScanner
    {
        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFAC9E7B4F0
        public void .ctor(){} // RVA: 0x7FFAC9E765C0
    }

}