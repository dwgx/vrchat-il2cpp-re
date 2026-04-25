// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling
// Classes: 6
// Methods: 34

namespace ThirdParty.Other.Unity.Profiling
{
    public class DebugScreenCapture : ValueType
    {
        public Unity.Collections.NativeArray`1<byte> RawImageDataReference; // 0x10
        public 0x6B17C078 ImageFormat; // 0x20
        public int Width; // 0x24
        public int Height; // 0x28

        // ── Methods ──
        public void set_RawImageDataReference(){} // RVA: 0x7FFAC450BA60
        public void set_ImageFormat(){} // RVA: 0x7FFAC2F240C0
        public void set_Width(){} // RVA: 0x7FFAC33D4990
        public void set_Height(){} // RVA: 0x7FFAC392CD10
    }

    public class IgnoredByDeepProfilerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ProfilerCategory : ValueType
    {
        public ushort Name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4AC85F0
        public void get_Name(){} // RVA: 0x7FFAC984F200
        public void ToString(){} // RVA: 0x7FFAC984F280
        public void get_Render(){} // RVA: 0x7FFAC34F9180
        public void get_Scripts(){} // RVA: 0x7FFAC3013AF0
        public void get_Vr(){} // RVA: 0x7FFAC31719D0
        public void get_Memory(){} // RVA: 0x7FFAC3641DE0
        public void get_Internal(){} // RVA: 0x7FFAC530B550
        public void op_Implicit(){} // RVA: 0x7FFAC984F290
    }

    public class ProfilerMarker : ValueType
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC984F2A0 | overloaded x2
        public void Auto(){} // RVA: 0x7FFAC30F0D50
    }

    public class ProfilerRecorder : ValueType
    {
        public ulong Valid; // 0x10
        public 0x6B177378 LastValueAsDouble;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC984F330
        public void StartNew(){} // RVA: 0x7FFAC984F3C0
        public void get_Valid(){} // RVA: 0x7FFAC984F460
        public void get_LastValueAsDouble(){} // RVA: 0x7FFAC984F4D0
        public void get_Count(){} // RVA: 0x7FFAC984F580
        public void Create(){} // RVA: 0x7FFAC984F630
        public void Control(){} // RVA: 0x7FFAC984F6B0
        public void GetLastValueAsDouble(){} // RVA: 0x7FFAC984F710
        public void GetCount(){} // RVA: 0x7FFAC984F760
        public void GetValid(){} // RVA: 0x7FFAC984F7C0
        public void Dispose(){} // RVA: 0x7FFAC984F810
        public void CheckInitializedAndThrow(){} // RVA: 0x7FFAC984F880
        public void Create_Injected(){} // RVA: 0x7FFAC984F8F0
        public void Control_Injected(){} // RVA: 0x7FFAC984F970
        public void GetLastValueAsDouble_Injected(){} // RVA: 0x7FFAC984F9D0
        public void GetCount_Injected(){} // RVA: 0x7FFAC984FA20
        public void GetValid_Injected(){} // RVA: 0x7FFAC984FA80
    }

    public class ProfilerRecorderDebugView : Object
    {
    }

}