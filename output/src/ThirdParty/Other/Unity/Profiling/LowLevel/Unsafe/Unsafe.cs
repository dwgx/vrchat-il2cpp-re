// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
// Classes: 3
// Methods: 22

namespace ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
{
    public class ProfilerRecorderDescription : ValueType
    {
        public object Category; // 0x10
        public ÍÏ.ÎÍÎÎÎÍÍÏ Name; // 0x12
        public ÍÏ.? dataType; // 0x14
        public ÏÌ unitType; // 0x15
        public int reserved0; // 0x18
        public int nameUtf8Len; // 0x1C
        public IntPtr nameUtf8; // 0x20

        // ── Methods ──
        public void get_Category(){} // RVA: 0x7FFD4FEE85D0
        public void get_Name(){} // RVA: 0x7FFD54C6FAD0
    }

    public class ProfilerRecorderHandle : ValueType
    {
        public ulong Valid; // 0x10

        // ── Methods ──
        public void get_Valid(){} // RVA: 0x7FFD54C6FAE0
        public void GetDescription(){} // RVA: 0x7FFD54C6FB00
        public void GetAvailable(){} // RVA: 0x7FFD54C6FC00
        public void GetByName__Unmanaged(){} // RVA: 0x7FFD54C6FC50
        public void GetByName(){} // RVA: 0x7FFD54C6FCD0
        public void GetByName_Unsafe(){} // RVA: 0x7FFD54C6FCE0
        public void GetDescriptionInternal(){} // RVA: 0x7FFD54C6FD60
        public void GetByName__Unmanaged_Injected(){} // RVA: 0x7FFD54C6FDD0
        public void GetByName_Unsafe_Injected(){} // RVA: 0x7FFD54C6FE50
        public void GetDescriptionInternal_Injected(){} // RVA: 0x7FFD54C6FED0
    }

    public class ProfilerUnsafeUtility : Object
    {
        // ── Methods ──
        public void CreateCategory__Unmanaged(){} // RVA: 0x7FFD54C6FF30
        public void GetCategoryDescription(){} // RVA: 0x7FFD54C6FFA0
        public void CreateMarker(){} // RVA: 0x7FFD54C70010
        public void CreateMarker__Unmanaged(){} // RVA: 0x7FFD54C70090
        public void SetMarkerMetadata__Unmanaged(){} // RVA: 0x7FFD54C70120
        public void BeginSample(){} // RVA: 0x7FFD54C701C0
        public void EndSample(){} // RVA: 0x7FFD54C70210
        public void CreateCounterValue__Unmanaged(){} // RVA: 0x7FFD54C70260
        public void Utf8ToString(){} // RVA: 0x7FFD54C70330
        public void GetCategoryDescription_Injected(){} // RVA: 0x7FFD54C70420
    }

}