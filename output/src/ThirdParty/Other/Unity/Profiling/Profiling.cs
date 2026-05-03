// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling
// Classes: 6
// Methods: 34

namespace ThirdParty.Other.Unity.Profiling
{
    public class DebugScreenCapture : ValueType
    {
        public Unity.Collections.NativeArray`1<byte> _rawImageDataReference; // 0x10
        public 0x665758E4 _imageFormat; // 0x20
        public int _width; // 0x24
        public int _height; // 0x28

        // ── Methods ──
        public void set_RawImageDataReference(){} // RVA: 0x7FFE827D9C10
        public void set_ImageFormat(){} // RVA: 0x7FFE810FE0C0
        public void set_Width(){} // RVA: 0x7FFE8164E0F0
        public void set_Height(){} // RVA: 0x7FFE8144DF00
    }

    public class IgnoredByDeepProfilerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ProfilerCategory : ValueType
    {
        public ushort m_CategoryId; // 0x10
        public object get_Category; // 0xF030
        public object get_Category; // 0xEEC0
        public object field_3; // 0x5E80
        public string field_4; // 0xD9A0
        public object field_5; // 0xEAD0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82D33000
        public void get_Name(){} // RVA: 0x7FFE87BF77A0
        public void ToString(){} // RVA: 0x7FFE87BF7820
        public void get_Render(){} // RVA: 0x7FFE813240E0
        public void get_Scripts(){} // RVA: 0x7FFE811EDAF0
        public void get_Vr(){} // RVA: 0x7FFE813DA8C0
        public void get_Memory(){} // RVA: 0x7FFE8178CF30
        public void get_Internal(){} // RVA: 0x7FFE835C1D90
        public void op_Implicit(){} // RVA: 0x7FFE87BF7830
    }

    public class ProfilerMarker : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BF7840 | overloaded x2
        public void Auto(){} // RVA: 0x7FFE812C4B40
    }

    public class ProfilerRecorder : ValueType
    {
        public ulong handle; // 0x10
        public 0x66570BE4 SharedRecorder;
        public object field_2; // 0x87D8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BF78D0
        public void StartNew(){} // RVA: 0x7FFE87BF7960
        public void get_Valid(){} // RVA: 0x7FFE87BF7A00
        public void get_LastValueAsDouble(){} // RVA: 0x7FFE87BF7A70
        public void get_Count(){} // RVA: 0x7FFE87BF7B20
        public void Create(){} // RVA: 0x7FFE87BF7BD0
        public void Control(){} // RVA: 0x7FFE87BF7C50
        public void GetLastValueAsDouble(){} // RVA: 0x7FFE87BF7CB0
        public void GetCount(){} // RVA: 0x7FFE87BF7D00
        public void GetValid(){} // RVA: 0x7FFE87BF7D60
        public void Dispose(){} // RVA: 0x7FFE87BF7DB0
        public void CheckInitializedAndThrow(){} // RVA: 0x7FFE87BF7E20
        public void Create_Injected(){} // RVA: 0x7FFE87BF7E90
        public void Control_Injected(){} // RVA: 0x7FFE87BF7F10
        public void GetLastValueAsDouble_Injected(){} // RVA: 0x7FFE87BF7F70
        public void GetCount_Injected(){} // RVA: 0x7FFE87BF7FC0
        public void GetValid_Injected(){} // RVA: 0x7FFE87BF8020
    }

    public class ProfilerRecorderDebugView : Object
    {
    }

}