// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling
// Classes: 9
// Methods: 93

namespace ThirdParty.Other.Unity.Profiling
{
    public class DebugScreenCapture : ValueType
    {
        public object _rawImageDataReference;
        public object _imageFormat;
        public object _width;
        public object _height;

        // ── Methods ──
        public void set_RawImageDataReference(){} // RVA: 0x7BE90
        public void set_ImageFormat(){} // RVA: 0x8C7F0
        public void set_Width(){} // RVA: 0xAFF60
        public void set_Height(){} // RVA: 0x9E810
    }

    public class IgnoredByDeepProfilerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IgnoredByDeepProfilerAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ProfilerCategory : ValueType
    {
        public object m_CategoryId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xE32F0
        public void get_Name(){} // RVA: 0x95EC40
        public void ToString(){} // RVA: 0x95EC50
        public void get_Render(){} // RVA: 0xDAC980
        public void get_Scripts(){} // RVA: 0xC3CCE0
        public void get_Vr(){} // RVA: 0xE686A0
        public void get_Memory(){} // RVA: 0x10AC210
        public void get_Internal(){} // RVA: 0x2AFB690
        public void op_Implicit(){} // RVA: 0x7B491B0
    }

    public class ProfilerCategory[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E80D00
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5A00
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E367A0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ProfilerMarker : ValueType
    {
        public object m_Ptr;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95EC90
        public void Auto(){} // RVA: 0x95ECC0
    }

    public class ProfilerMarker[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7D9E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E33ED0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ProfilerRecorder : ValueType
    {
        public object handle;
        public object SharedRecorder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95ED90
        public void StartNew(){} // RVA: 0x7B49310
        public void get_Valid(){} // RVA: 0x95EDA0
        public void get_LastValueAsDouble(){} // RVA: 0x95EDB0
        public void get_Count(){} // RVA: 0x95EDC0
        public void Create(){} // RVA: 0x7B49580
        public void Control(){} // RVA: 0x7B49600
        public void GetLastValueAsDouble(){} // RVA: 0x7B49660
        public void GetCount(){} // RVA: 0x7B496B0
        public void GetValid(){} // RVA: 0x7B49710
        public void Dispose(){} // RVA: 0x95EDD0
        public void CheckInitializedAndThrow(){} // RVA: 0x95EE40
        public void Create_Injected(){} // RVA: 0x7B49840
        public void Control_Injected(){} // RVA: 0x7B498C0
        public void GetLastValueAsDouble_Injected(){} // RVA: 0x7B49920
        public void GetCount_Injected(){} // RVA: 0x7B49970
        public void GetValid_Injected(){} // RVA: 0x7B499D0
    }

    public class ProfilerRecorder[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}