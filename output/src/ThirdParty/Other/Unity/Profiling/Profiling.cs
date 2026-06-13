// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling
// Classes: 6
// Methods: 34

namespace ThirdParty.Other.Unity.Profiling
{
    public class DebugScreenCapture
    {
        public Unity.Collections.NativeArray`1<byte> <RawImageDataReference>k__BackingField; // 0x10
        public 0x65898078 <ImageFormat>k__BackingField; // 0x20
        public int <Width>k__BackingField; // 0x24
        public int <Height>k__BackingField; // 0x28

        // ── Methods ──
        public void set_RawImageDataReference(){} // RVA: 0x1A53740
        public void set_ImageFormat(){} // RVA: 0x2E00C0
        public void set_Width(){} // RVA: 0x8AC660
        public void set_Height(){} // RVA: 0x6374E0
    }

    public class IgnoredByDeepProfilerAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ProfilerCategory
    {
        public ushort m_CategoryId; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1FA6400
        public void get_Name(){} // RVA: 0x70B67C0
        public void ToString(){} // RVA: 0x70B6840
        public void get_Render(){} // RVA: 0x519240
        public void get_Scripts(){} // RVA: 0x3CFAF0
        public void get_Vr(){} // RVA: 0x5D5200
        public void get_Memory(){} // RVA: 0x9FD990
        public void get_Internal(){} // RVA: 0x210E290
        public void op_Implicit(){} // RVA: 0x70B6850
    }

    public class ProfilerMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70B6860 | overloaded x2
        public void Auto(){} // RVA: 0x4A39A0
    }

    public class ProfilerRecorder
    {
        public ulong handle; // 0x10
        public 0x658932C8 SharedRecorder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70B68F0
        public void StartNew(){} // RVA: 0x70B6980
        public void get_Valid(){} // RVA: 0x70B6A20
        public void get_LastValueAsDouble(){} // RVA: 0x70B6A90
        public void get_Count(){} // RVA: 0x70B6B40
        public void Create(){} // RVA: 0x70B6BF0
        public void Control(){} // RVA: 0x70B6C70
        public void GetLastValueAsDouble(){} // RVA: 0x70B6CD0
        public void GetCount(){} // RVA: 0x70B6D20
        public void GetValid(){} // RVA: 0x70B6D80
        public void Dispose(){} // RVA: 0x70B6DD0
        public void CheckInitializedAndThrow(){} // RVA: 0x70B6E40
        public void Create_Injected(){} // RVA: 0x70B6EB0
        public void Control_Injected(){} // RVA: 0x70B6F30
        public void GetLastValueAsDouble_Injected(){} // RVA: 0x70B6F90
        public void GetCount_Injected(){} // RVA: 0x70B6FE0
        public void GetValid_Injected(){} // RVA: 0x70B7040
    }

    public class ProfilerRecorderDebugView
    {
    }

}