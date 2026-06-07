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
        public void get_Category(){} // RVA: 0x1FA63F0
        public void get_Name(){} // RVA: 0x70B7090
    }

    public class ProfilerRecorderHandle
    {
        // ── Methods ──
        public void get_Valid(){} // RVA: 0x70B70A0
        public void GetDescription(){} // RVA: 0x70B70C0
        public void GetAvailable(){} // RVA: 0x70B71C0
        public void GetByName__Unmanaged(){} // RVA: 0x70B7210
        public void GetByName(){} // RVA: 0x70B7290
        public void GetByName_Unsafe(){} // RVA: 0x70B72A0
        public void GetDescriptionInternal(){} // RVA: 0x70B7320
        public void GetByName__Unmanaged_Injected(){} // RVA: 0x70B7390
        public void GetByName_Unsafe_Injected(){} // RVA: 0x70B7410
        public void GetDescriptionInternal_Injected(){} // RVA: 0x70B7490
    }

    public class ProfilerUnsafeUtility
    {
        // ── Methods ──
        public void CreateCategory__Unmanaged(){} // RVA: 0x70B74F0
        public void GetCategoryDescription(){} // RVA: 0x70B7560
        public void CreateMarker(){} // RVA: 0x70B75D0
        public void CreateMarker__Unmanaged(){} // RVA: 0x70B7650
        public void SetMarkerMetadata__Unmanaged(){} // RVA: 0x70B76E0
        public void BeginSample(){} // RVA: 0x70B7780
        public void EndSample(){} // RVA: 0x70B77D0
        public void CreateCounterValue__Unmanaged(){} // RVA: 0x70B7820
        public void Utf8ToString(){} // RVA: 0x70B78F0
        public void GetCategoryDescription_Injected(){} // RVA: 0x70B79E0
    }

}