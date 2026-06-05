// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
// Classes: 4
// Methods: 22

namespace ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
{
    public class ProfilerCategoryDescription
    {
    }

    public class ProfilerRecorderDescription
    {
        public object Valid;

        // ── Methods ──
        public void get_Category(){} // RVA: 0x7FFAF4A563F0
        public void get_Name(){} // RVA: 0x7FFAF9B67090
    }

    public class ProfilerRecorderHandle
    {
        // ── Methods ──
        public void get_Valid(){} // RVA: 0x7FFAF9B670A0
        public void GetDescription(){} // RVA: 0x7FFAF9B670C0
        public void GetAvailable(){} // RVA: 0x7FFAF9B671C0
        public void GetByName__Unmanaged(){} // RVA: 0x7FFAF9B67210
        public void GetByName(){} // RVA: 0x7FFAF9B67290
        public void GetByName_Unsafe(){} // RVA: 0x7FFAF9B672A0
        public void GetDescriptionInternal(){} // RVA: 0x7FFAF9B67320
        public void GetByName__Unmanaged_Injected(){} // RVA: 0x7FFAF9B67390
        public void GetByName_Unsafe_Injected(){} // RVA: 0x7FFAF9B67410
        public void GetDescriptionInternal_Injected(){} // RVA: 0x7FFAF9B67490
    }

    public class ProfilerUnsafeUtility
    {
        // ── Methods ──
        public void CreateCategory__Unmanaged(){} // RVA: 0x7FFAF9B674F0
        public void GetCategoryDescription(){} // RVA: 0x7FFAF9B67560
        public void CreateMarker(){} // RVA: 0x7FFAF9B675D0
        public void CreateMarker__Unmanaged(){} // RVA: 0x7FFAF9B67650
        public void SetMarkerMetadata__Unmanaged(){} // RVA: 0x7FFAF9B676E0
        public void BeginSample(){} // RVA: 0x7FFAF9B67780
        public void EndSample(){} // RVA: 0x7FFAF9B677D0
        public void CreateCounterValue__Unmanaged(){} // RVA: 0x7FFAF9B67820
        public void Utf8ToString(){} // RVA: 0x7FFAF9B678F0
        public void GetCategoryDescription_Injected(){} // RVA: 0x7FFAF9B679E0
    }

}