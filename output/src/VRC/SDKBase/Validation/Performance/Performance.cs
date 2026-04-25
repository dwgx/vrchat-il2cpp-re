// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance
// Classes: 6
// Methods: 23

namespace VRC.SDKBase.Validation.Performance
{
    public class AvatarPerformance : Object
    {
        public 0x6B252B90 ShouldIgnoreComponent;
        public 0x6B252B90 AvatarPerformanceRatingMinimumToDisplayMin; // 0x4
        public 0x6B252B90 AvatarPerformanceRatingMinimumToDisplayMax; // 0x8
        public IgnoreDelegate <ShouldIgnoreComponent>k__BackingField; // 0x10

        // ── Methods ──
        public void get_ShouldIgnoreComponent(){} // RVA: 0x7FFACC084570
        public void set_ShouldIgnoreComponent(){} // RVA: 0x7FFACC0845D0
        public void CalculatePerformanceStats(){} // RVA: 0x7FFACC084690
        public void CalculatePerformanceStatsEnumerator(){} // RVA: 0x7FFACC0847E0
        public void ApplyPerformanceFiltersEnumerator(){} // RVA: 0x7FFACC084950
        public void GetPerformanceScannerSet(){} // RVA: 0x7FFACC084AD0
        public void GetPerformanceFilterSet(){} // RVA: 0x7FFACC084BE0
        public void IsEditorOnly(){} // RVA: 0x7FFACC084C50
        public void ShouldIgnoreComponentInternal(){} // RVA: 0x7FFACC084D70
        public void .cctor(){} // RVA: 0x7FFACC084E40
    }

    public class IVRCConstraint
    {
        public object LatestValidExecutionGroupIndex;

        // ── Methods ──
        public void get_LatestValidExecutionGroupIndex(){} // RVA: 0x7FFAC2C59960
    }

    public class IVRCRaycast
    {
    }

    public class MeshUtils : Object
    {
        public UnityEngine.Mesh[] _primitiveMeshes;
        public System.Collections.Generic.List`1<UnityEngine.BoneWeight> _boneWeightsBuffer; // 0x8

        // ── Methods ──
        public void GatherPrimitives(){} // RVA: 0x7FFACC085520
        public void GetMeshTriangleCount(){} // RVA: 0x7FFACC0858A0
        public void IsPrimitiveMesh(){} // RVA: 0x7FFACC085AC0
        public void IsSkinnedMesh(){} // RVA: 0x7FFACC085D60
        public void .cctor(){} // RVA: 0x7FFACC085F80
        public void <GatherPrimitives>g__GetPrimitiveMesh|2_0(){} // RVA: 0x7FFACC086060
    }

    public class PerformanceFilterSet : ScriptableObject
    {
        public VRC.SDKBase.Validation.Performance.Filters.AbstractPerformanceFilter[] performanceFilters; // 0x18

        // ── Methods ──
        public void ApplyPerformanceFilters(){} // RVA: 0x7FFACC0862C0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class PerformanceScannerSet : Object
    {
        public System.Collections.Generic.List`1<VRC.SDKBase.Validation.Performance.Scanners.AbstractPerformanceScanner> performanceScanners; // 0x10

        // ── Methods ──
        public void InitForPlatform(){} // RVA: 0x7FFACC0868B0
        public void RunPerformanceScan(){} // RVA: 0x7FFACC086D30
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFACC086EC0
        public void .ctor(){} // RVA: 0x7FFACC087080
    }

}