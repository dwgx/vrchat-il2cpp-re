// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
// Classes: 3
// Methods: 22

namespace ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
{
    public class ProfilerRecorderDescription : ValueType
    {
        public object dataType; // 0x32C9B510
        public object nameUtf8Len; // 0x32C9B510

        // ── Original Methods ──
        public void get_Category(){} // RVA: 0x7ffaaa4cb7c0
        public void get_Name(){} // RVA: 0x7ffaaf271a30
    }

    public class ProfilerRecorderHandle : ValueType
    {
        // ── Original Methods ──
        public void get_Valid(){} // RVA: 0x7ffaaf271a40
        // ── Binary Analysis Named ──
        public void GetDescription(){} // RVA: 0x7ffaaf271a60
        public void GetAvailable(){} // RVA: 0x7ffaaf271b60
        public void GetByName__Unmanaged(){} // RVA: 0x7ffaaf271bb0
        public void GetByName(){} // RVA: 0x7ffaaf271c30
        public void GetByName_Unsafe(){} // RVA: 0x7ffaaf271c40
        public void GetDescriptionInternal(){} // RVA: 0x7ffaaf271cc0
        public void GetByName__Unmanaged_Injected(){} // RVA: 0x7ffaaf271d30
        public void GetByName_Unsafe_Injected(){} // RVA: 0x7ffaaf271db0
        public void GetDescriptionInternal_Injected(){} // RVA: 0x7ffaaf271e30
    }

    public class ProfilerUnsafeUtility : Object
    {
        // ── Original Methods ──
        public void CreateCategory__Unmanaged(){} // RVA: 0x7ffaaf271e90
        public void CreateMarker(){} // RVA: 0x7ffaaf271f70
        public void CreateMarker__Unmanaged(){} // RVA: 0x7ffaaf271ff0
        public void EndSample(){} // RVA: 0x7ffaaf272170
        public void CreateCounterValue__Unmanaged(){} // RVA: 0x7ffaaf2721c0
        public void Utf8ToString(){} // RVA: 0x7ffaaf272290
        // ── Binary Analysis Named ──
        public void GetCategoryDescription(){} // RVA: 0x7ffaaf271f00
        public void SetMarkerMetadata__Unmanaged(){} // RVA: 0x7ffaaf272080
        public void BeginSample(){} // RVA: 0x7ffaaf272120
        public void GetCategoryDescription_Injected(){} // RVA: 0x7ffaaf272380
    }

}