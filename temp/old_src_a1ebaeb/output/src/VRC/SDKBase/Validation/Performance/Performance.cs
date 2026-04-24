// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance
// Classes: 3
// Methods: 16

namespace VRC.SDKBase.Validation.Performance
{
    public class AvatarPerformance : Object
    {
        public object AvatarPerformanceRatingMinimumToDisplayMax; // 0x36795E50

        // ── Original Methods ──
        public void get_ShouldIgnoreComponent(){} // RVA: 0x7ffab1aa0480
        public void set_ShouldIgnoreComponent(){} // RVA: 0x7ffab1aa04e0
        public void CalculatePerformanceStats(){} // RVA: 0x7ffab1aa05a0
        public void CalculatePerformanceStatsEnumerator(){} // RVA: 0x7ffab1aa06f0
        public void ApplyPerformanceFiltersEnumerator(){} // RVA: 0x7ffab1aa0860
        public void IsEditorOnly(){} // RVA: 0x7ffab1aa0b60
        public void ShouldIgnoreComponentInternal(){} // RVA: 0x7ffab1aa0c80
        public void .cctor(){} // RVA: 0x7ffab1aa0d50
        // ── Binary Analysis Named ──
        public void GetPerformanceScannerSet(){} // RVA: 0x7ffab1aa09e0
        public void GetPerformanceFilterSet(){} // RVA: 0x7ffab1aa0af0
    }

    public class IVRCRaycast
    {
        // ── Original Methods ──
        public void get_CommandIndex(){} // RVA: 0x7ffaa8649ca0
        public void set_CommandIndex(){} // RVA: 0x7ffaa8661210
        public void PopulateRaycastCommand(){} // RVA: 0x7ffaa864a2a0
        public void HandleRaycastResult(){}
    }

    public class PerformanceFilterSet : ScriptableObject
    {
        // ── Original Methods ──
        public void ApplyPerformanceFilters(){} // RVA: 0x7ffab1aa21d0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

}