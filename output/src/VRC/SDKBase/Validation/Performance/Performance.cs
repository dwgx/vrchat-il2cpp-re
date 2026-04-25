// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance
// Classes: 3
// Methods: 12

namespace VRC.SDKBase.Validation.Performance
{
    public class AvatarPerformance : Object
    {
        public 0x665B2B90 ShouldIgnoreComponent;
        public 0x665B2B90 AvatarPerformanceRatingMinimumToDisplayMin; // 0x4
        public 0x665B2B90 AvatarPerformanceRatingMinimumToDisplayMax; // 0x8
        public IgnoreDelegate <ShouldIgnoreComponent>k__BackingField; // 0x10

        // ── Methods ──
        public void get_ShouldIgnoreComponent(){} // RVA: 0x7FFD574A4570
        public void set_ShouldIgnoreComponent(){} // RVA: 0x7FFD574A45D0
        public void CalculatePerformanceStats(){} // RVA: 0x7FFD574A4690
        public void CalculatePerformanceStatsEnumerator(){} // RVA: 0x7FFD574A47E0
        public void ApplyPerformanceFiltersEnumerator(){} // RVA: 0x7FFD574A4950
        public void GetPerformanceScannerSet(){} // RVA: 0x7FFD574A4AD0
        public void GetPerformanceFilterSet(){} // RVA: 0x7FFD574A4BE0
        public void IsEditorOnly(){} // RVA: 0x7FFD574A4C50
        public void ShouldIgnoreComponentInternal(){} // RVA: 0x7FFD574A4D70
        public void .cctor(){} // RVA: 0x7FFD574A4E40
    }

    public class IVRCRaycast
    {
    }

    public class PerformanceFilterSet : ScriptableObject
    {
        public VRC.SDKBase.Validation.Performance.Filters.AbstractPerformanceFilter[] performanceFilters; // 0x18

        // ── Methods ──
        public void ApplyPerformanceFilters(){} // RVA: 0x7FFD574A62C0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

}