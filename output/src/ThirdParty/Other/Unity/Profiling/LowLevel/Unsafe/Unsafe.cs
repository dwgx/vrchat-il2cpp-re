// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
// Classes: 4
// Methods: 22

namespace ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
{
    public class ProfilerCategoryDescription : ValueType
    {
    }

    public class ProfilerRecorderDescription : ValueType
    {
        public Unity.Profiling.ProfilerCategory category; // 0x10
        public 0x66570DF4 flags; // 0x12

        // ── Methods ──
        public void get_Category(){} // RVA: 0x7FFE82D33010
        public void get_Name(){} // RVA: 0x7FFE87BF8070
    }

    public class ProfilerRecorderHandle : ValueType
    {
        public ulong handle; // 0x10

        // ── Methods ──
        public void get_Valid(){} // RVA: 0x7FFE87BF8080
        public void GetDescription(){} // RVA: 0x7FFE87BF80A0
        public void GetAvailable(){} // RVA: 0x7FFE87BF81A0
        public void GetByName__Unmanaged(){} // RVA: 0x7FFE87BF81F0
        public void GetByName(){} // RVA: 0x7FFE87BF8270
        public void GetByName_Unsafe(){} // RVA: 0x7FFE87BF8280
        public void GetDescriptionInternal(){} // RVA: 0x7FFE87BF8300
        public void GetByName__Unmanaged_Injected(){} // RVA: 0x7FFE87BF8370
        public void GetByName_Unsafe_Injected(){} // RVA: 0x7FFE87BF83F0
        public void GetDescriptionInternal_Injected(){} // RVA: 0x7FFE87BF8470
    }

    public class ProfilerUnsafeUtility : Object
    {
        // ── Methods ──
        public void CreateCategory__Unmanaged(){} // RVA: 0x7FFE87BF84D0
        public void GetCategoryDescription(){} // RVA: 0x7FFE87BF8540
        public void CreateMarker(){} // RVA: 0x7FFE87BF85B0
        public void CreateMarker__Unmanaged(){} // RVA: 0x7FFE87BF8630
        public void SetMarkerMetadata__Unmanaged(){} // RVA: 0x7FFE87BF86C0
        public void BeginSample(){} // RVA: 0x7FFE87BF8760
        public void EndSample(){} // RVA: 0x7FFE87BF87B0
        public void CreateCounterValue__Unmanaged(){} // RVA: 0x7FFE87BF8800
        public void Utf8ToString(){} // RVA: 0x7FFE87BF88D0
        public void GetCategoryDescription_Injected(){} // RVA: 0x7FFE87BF89C0
    }

}