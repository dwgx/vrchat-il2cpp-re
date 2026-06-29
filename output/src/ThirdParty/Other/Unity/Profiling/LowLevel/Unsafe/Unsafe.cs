// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
// Classes: 6
// Methods: 69

namespace ThirdParty.Other.Unity.Profiling.LowLevel.Unsafe
{
    public class ProfilerRecorderDescription : ValueType
    {
        public object category;
        public object flags;
        public object dataType;
        public object unitType;
        public object reserved0;
        public object nameUtf8Len;
        public object nameUtf8;

        // ── Methods ──
        public void get_Category(){} // RVA: 0xE3300
        public void get_Name(){} // RVA: 0x95EE50
    }

    public class ProfilerRecorderDescription[] : Array
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

    public class ProfilerRecorderHandle : ValueType
    {
        public object handle;

        // ── Methods ──
        public void get_Valid(){} // RVA: 0x95EE60
        public void GetDescription(){} // RVA: 0x7B49A50
        public void GetAvailable(){} // RVA: 0x7B49B50
        public void GetByName__Unmanaged(){} // RVA: 0x7B49E40
        public void GetByName(){} // RVA: 0x7B49EC0
        public void GetByName_Unsafe(){} // RVA: 0x7B49ED0
        public void GetDescriptionInternal(){} // RVA: 0x7B49F50
        public void GetAvailable_Injected(){} // RVA: 0x7B49FC0
        public void GetByName__Unmanaged_Injected(){} // RVA: 0x7B4A010
        public void GetByName_Unsafe_Injected(){} // RVA: 0x7B4A090
        public void GetDescriptionInternal_Injected(){} // RVA: 0x7B4A110
    }

    public class ProfilerRecorderHandle[] : Array
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

    public class ProfilerUnsafeUtility : Object
    {
        // ── Methods ──
        public void CreateCategory__Unmanaged(){} // RVA: 0x7B4A170
        public void GetCategoryDescription(){} // RVA: 0x7B4A1E0
        public void CreateMarker(){} // RVA: 0x7B4A250
        public void CreateMarker__Unmanaged(){} // RVA: 0x7B4A3C0
        public void SetMarkerMetadata__Unmanaged(){} // RVA: 0x7B4A450
        public void BeginSample(){} // RVA: 0x7B4A4F0
        public void EndSample(){} // RVA: 0x7B4A540
        public void CreateCounterValue__Unmanaged(){} // RVA: 0x7B4A590
        public void Utf8ToString(){} // RVA: 0x7B4A660
        public void GetCategoryDescription_Injected(){} // RVA: 0x7B4A750
        public void CreateMarker_Injected(){} // RVA: 0x7B4A7B0
    }

    public class ProfilerUnsafeUtility[] : Array
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

}