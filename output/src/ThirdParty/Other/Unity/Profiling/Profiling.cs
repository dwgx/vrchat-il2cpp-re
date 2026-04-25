// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling
// Classes: 4
// Methods: 30

namespace ThirdParty.Other.Unity.Profiling
{
    public class IgnoredByDeepProfilerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ProfilerCategory : ValueType
    {
        public ushort Name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FEE85F0
        public void get_Name(){} // RVA: 0x7FFD54C6F200
        public void ToString(){} // RVA: 0x7FFD54C6F280
        public void get_Render(){} // RVA: 0x7FFD4E919180
        public void get_Scripts(){} // RVA: 0x7FFD4E433AF0
        public void get_Vr(){} // RVA: 0x7FFD4E5919D0
        public void get_Memory(){} // RVA: 0x7FFD4EA61DE0
        public void get_Internal(){} // RVA: 0x7FFD5072B550
        public void op_Implicit(){} // RVA: 0x7FFD54C6F290
    }

    public class ProfilerMarker : ValueType
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C6F2A0 | overloaded x2
        public void Auto(){} // RVA: 0x7FFD4E510D50
    }

    public class ProfilerRecorder : ValueType
    {
        public ulong Valid; // 0x10
        public 0x664D7378 LastValueAsDouble;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C6F330
        public void StartNew(){} // RVA: 0x7FFD54C6F3C0
        public void get_Valid(){} // RVA: 0x7FFD54C6F460
        public void get_LastValueAsDouble(){} // RVA: 0x7FFD54C6F4D0
        public void get_Count(){} // RVA: 0x7FFD54C6F580
        public void Create(){} // RVA: 0x7FFD54C6F630
        public void Control(){} // RVA: 0x7FFD54C6F6B0
        public void GetLastValueAsDouble(){} // RVA: 0x7FFD54C6F710
        public void GetCount(){} // RVA: 0x7FFD54C6F760
        public void GetValid(){} // RVA: 0x7FFD54C6F7C0
        public void Dispose(){} // RVA: 0x7FFD54C6F810
        public void CheckInitializedAndThrow(){} // RVA: 0x7FFD54C6F880
        public void Create_Injected(){} // RVA: 0x7FFD54C6F8F0
        public void Control_Injected(){} // RVA: 0x7FFD54C6F970
        public void GetLastValueAsDouble_Injected(){} // RVA: 0x7FFD54C6F9D0
        public void GetCount_Injected(){} // RVA: 0x7FFD54C6FA20
        public void GetValid_Injected(){} // RVA: 0x7FFD54C6FA80
    }

}