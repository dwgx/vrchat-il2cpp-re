// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance
// Classes: 6
// Methods: 23

namespace VRC.SDKBase.Validation.Performance
{
    public class AvatarPerformance : Object
    {
        public 0x6664C5B4 AvatarPerformanceRatingMinimumToDisplayDefault;

        // ── Methods ──
        public void get_ShouldIgnoreComponent(){} // RVA: 0x7FFE8A4EA550
        public void set_ShouldIgnoreComponent(){} // RVA: 0x7FFE8A4EA5B0
        public void CalculatePerformanceStats(){} // RVA: 0x7FFE8A4EA670
        public void CalculatePerformanceStatsEnumerator(){} // RVA: 0x7FFE8A4EA7C0
        public void ApplyPerformanceFiltersEnumerator(){} // RVA: 0x7FFE8A4EA930
        public void GetPerformanceScannerSet(){} // RVA: 0x7FFE8A4EAAB0
        public void GetPerformanceFilterSet(){} // RVA: 0x7FFE8A4EABC0
        public void IsEditorOnly(){} // RVA: 0x7FFE8A4EAC30
        public void ShouldIgnoreComponentInternal(){} // RVA: 0x7FFE8A4EAD50
        public void .cctor(){} // RVA: 0x7FFE8A4EAE20
    }

    public class IVRCConstraint
    {
        // ── Methods ──
        public void get_LatestValidExecutionGroupIndex(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IVRCRaycast
    {
    }

    public class MeshUtils : Object
    {
        // ── Methods ──
        public void GatherPrimitives(){} // RVA: 0x7FFE8A4EB500
        public void GetMeshTriangleCount(){} // RVA: 0x7FFE8A4EB880
        public void IsPrimitiveMesh(){} // RVA: 0x7FFE8A4EBAA0
        public void IsSkinnedMesh(){} // RVA: 0x7FFE8A4EBD40
        public void .cctor(){} // RVA: 0x7FFE8A4EBF60
        public void <GatherPrimitives>g__GetPrimitiveMesh|2_0(){} // RVA: 0x7FFE8A4EC040
    }

    public class PerformanceFilterSet : ScriptableObject
    {
        // ── Methods ──
        public void ApplyPerformanceFilters(){} // RVA: 0x7FFE8A4EC2A0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class PerformanceScannerSet : Object
    {
        // ── Methods ──
        public void InitForPlatform(){} // RVA: 0x7FFE8A4EC890
        public void RunPerformanceScan(){} // RVA: 0x7FFE8A4ECD00
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFE8A4ECE90
        public void .ctor(){} // RVA: 0x7FFE8A4ED050
    }

}