// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
// Classes: 4
// Methods: 22

namespace ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
{
    public class ProfilerCategoryDescription : ValueType
    {
        public ushort Id; // 0x10
        public ushort Flags; // 0x12
        public UnityEngine.Color32 Color; // 0x14
        public int reserved0; // 0x18
        public int NameUtf8Len; // 0x1C
        public byte* NameUtf8; // 0x20
    }

    public class ProfilerRecorderDescription : ValueType
    {
        public Unity.Profiling.ProfilerCategory Category; // 0x10
        public 0x6B177588 Name; // 0x12
        public 0x6B1775E0 dataType; // 0x14
        public 0x6B1772C8 unitType; // 0x15
        public int reserved0; // 0x18
        public int nameUtf8Len; // 0x1C
        public byte* nameUtf8; // 0x20

        // ── Methods ──
        public void get_Category(){} // RVA: 0x7FFAC4AC85D0
        public void get_Name(){} // RVA: 0x7FFAC984FAD0
    }

    public class ProfilerRecorderHandle : ValueType
    {
        public ulong Valid; // 0x10

        // ── Methods ──
        public void get_Valid(){} // RVA: 0x7FFAC984FAE0
        public void GetDescription(){} // RVA: 0x7FFAC984FB00
        public void GetAvailable(){} // RVA: 0x7FFAC984FC00
        public void GetByName__Unmanaged(){} // RVA: 0x7FFAC984FC50
        public void GetByName(){} // RVA: 0x7FFAC984FCD0
        public void GetByName_Unsafe(){} // RVA: 0x7FFAC984FCE0
        public void GetDescriptionInternal(){} // RVA: 0x7FFAC984FD60
        public void GetByName__Unmanaged_Injected(){} // RVA: 0x7FFAC984FDD0
        public void GetByName_Unsafe_Injected(){} // RVA: 0x7FFAC984FE50
        public void GetDescriptionInternal_Injected(){} // RVA: 0x7FFAC984FED0
    }

    public class ProfilerUnsafeUtility : Object
    {
        // ── Methods ──
        public void CreateCategory__Unmanaged(){} // RVA: 0x7FFAC984FF30
        public void GetCategoryDescription(){} // RVA: 0x7FFAC984FFA0
        public void CreateMarker(){} // RVA: 0x7FFAC9850010
        public void CreateMarker__Unmanaged(){} // RVA: 0x7FFAC9850090
        public void SetMarkerMetadata__Unmanaged(){} // RVA: 0x7FFAC9850120
        public void BeginSample(){} // RVA: 0x7FFAC98501C0
        public void EndSample(){} // RVA: 0x7FFAC9850210
        public void CreateCounterValue__Unmanaged(){} // RVA: 0x7FFAC9850260
        public void Utf8ToString(){} // RVA: 0x7FFAC9850330
        public void GetCategoryDescription_Injected(){} // RVA: 0x7FFAC9850420
    }

}