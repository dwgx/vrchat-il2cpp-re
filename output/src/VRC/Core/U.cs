// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 39

namespace VRC.Core
{
    public class UnityEventFilter : Object
    {
        public System.Collections.Generic.HashSet`1<System.Type> _m_CachedPtr;
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<System.Type,ÍÏÌÍÎÌÎÏÎÏÎÌÎÌÏÎÍÍÌÏÍÏÌ>> _offsetOfInstanceIDInCPlusPlusObject; // 0x8
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<System.Type,ÏÍÌÌÌÏÏÍÏÌÍÏÌÌÌÏÌÌÌÍÌÎÌ>> f_24F; // 0x10

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81BBB9E0
        public void Equals(){} // RVA: 0x7FFE81BBBA60
        public void GetHashCode(){} // RVA: 0x7FFE81BBBAE0
        public void op_Implicit(){} // RVA: 0x7FFE81BBBB60
        public void InitializeLazy(){} // RVA: 0x7FFE81BBBC30
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81BBBDA0
        public void GetCachedPtr(){} // RVA: 0x7FFE81BBC170
        public void set_name(){} // RVA: 0x7FFE81BBC3A0 | overloaded x2
        public void Instantiate(){} // RVA: 0x7FFE81BBCE70 | overloaded x4
        public void ToString(){} // RVA: 0x7FFE81BBD660 | overloaded x3
        public void TryProcessNetworkAction(){} // RVA: 0x7FFE81BBDB40
        public void ProcessEventFilter(){} // RVA: 0x7FFE81BBDBE0
        public void InitializeEventFilterState(){} // RVA: 0x7FFE81BBDC80
        public void Destroy(){} // RVA: 0x7FFE81BBDEC0
        public void ApplyEventFilteringLogic(){} // RVA: 0x7FFE81BBE1A0
        public void .cctor(){} // RVA: 0x7FFE81BBE490
        public void DestroyImmediate(){} // RVA: 0x7FFE81BC2EB0
        public void FindObjectsOfType(){} // RVA: 0x7FFE81BC2FD0
    }

    public class UnityVersion : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3957E0
        public void CompareTo(){} // RVA: 0x7FFE8A395800
        public void Parse(){} // RVA: 0x7FFE8A3958D0
        public void TryParse(){} // RVA: 0x7FFE8A395D10
        public void ToString(){} // RVA: 0x7FFE8A396120
        public void .cctor(){} // RVA: 0x7FFE8A3963D0
    }

    public class UpdateDelegator : Object
    {
        // ── Methods ──
        public void Dispatch(){} // RVA: 0x7FFE8A3964B0
        public void DispatchAfter(){} // RVA: 0x7FFE8A3967D0
        public void ManagedUpdate(){} // RVA: 0x7FFE8A396A00
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A396DD0
    }

    public class UrlAllowlistConfig : Object
    {
        public System.Lazy`1<System.ValueTuple`2<System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>>> _urlAllowlist;
        public object field_1; // 0xFA8

        // ── Methods ──
        public void GetRemoteLists(){} // RVA: 0x7FFE8A38AB70
        public void get_DomainExplicitAllowlist(){} // RVA: 0x7FFE8A38B090
        public void get_DomainWildcardAllowlist(){} // RVA: 0x7FFE8A38B120
        public void .cctor(){} // RVA: 0x7FFE8A38B1B0
    }

}