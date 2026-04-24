// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling
// Classes: 4
// Methods: 30

namespace ThirdParty.Other.Unity.Profiling
{
    public class IgnoredByDeepProfilerAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ProfilerCategory : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa4cb7f0
        public void get_Name(){} // RVA: 0x7ffaaf271160
        public void ToString(){} // RVA: 0x7ffaaf2711e0
        public void get_Render(){} // RVA: 0x7ffaa8f22da0
        public void get_Scripts(){} // RVA: 0x7ffaa8a24af0
        public void get_Vr(){} // RVA: 0x7ffaa8b9a420
        public void get_Memory(){} // RVA: 0x7ffaa906c740
        public void get_Internal(){} // RVA: 0x7ffaaad0d4b0
        public void op_Implicit(){} // RVA: 0x7ffaaf2711f0
    }

    public class ProfilerMarker : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf271200
        public void .ctor(){} // RVA: 0x7ffaaf271200
        public void Auto(){} // RVA: 0x7ffaa8b02040
    }

    public class ProfilerRecorder : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf271290
        public void StartNew(){} // RVA: 0x7ffaaf271320
        public void get_Valid(){} // RVA: 0x7ffaaf2713c0
        public void get_LastValueAsDouble(){} // RVA: 0x7ffaaf271430
        public void get_Count(){} // RVA: 0x7ffaaf2714e0
        public void Create(){} // RVA: 0x7ffaaf271590
        public void Control(){} // RVA: 0x7ffaaf271610
        public void Dispose(){} // RVA: 0x7ffaaf271770
        public void Create_Injected(){} // RVA: 0x7ffaaf271850
        public void Control_Injected(){} // RVA: 0x7ffaaf2718d0
        // ── Binary Analysis Named ──
        public void GetLastValueAsDouble(){} // RVA: 0x7ffaaf271670
        public void GetCount(){} // RVA: 0x7ffaaf2716c0
        public void GetValid(){} // RVA: 0x7ffaaf271720
        public void CheckInitializedAndThrow(){} // RVA: 0x7ffaaf2717e0
        public void GetLastValueAsDouble_Injected(){} // RVA: 0x7ffaaf271930
        public void GetCount_Injected(){} // RVA: 0x7ffaaf271980
        public void GetValid_Injected(){} // RVA: 0x7ffaaf2719e0
    }

}