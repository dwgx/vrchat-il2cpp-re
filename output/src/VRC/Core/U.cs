// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 39

namespace VRC.Core
{
    public class UnityEventFilter : Object
    {
        public System.Collections.Generic.HashSet`1<System.Type> _name;
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<System.Type,ÌÏÍÏÍÏÎÌÏÎÎÎÏÌÏÏÌÎÎÎÎÎÏ>> _hideFlags; // 0x8
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<System.Type,ÏÎÎÌÌÌÌÌÌÌÏÏÌÍÏÌÏÏÍÍÍÏÍ>> f_918; // 0x10
        public System.Lazy`1<string> ÍÍÌÏÍÎÌÎÍÏÎÎÌÎÎÍÏÌÌÍÎÏÏ; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Type,ÌÏÍÏÍÏÎÌÏÎÎÎÏÌÏÏÌÎÎÎÎÎÏ> ÌÏÌÌÎÏÏÏÌÏÌÏÌÎÌÍÎÎÌÏÌÍÍ; // 0x20
        public System.Collections.Generic.HashSet`1<string> ÎÏÏÍÏÏÌÍÌÎÌÏÏÏÏÎÎÌÍÌÌÏÏ; // 0x28

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC3A5BBF0
        public void Equals(){} // RVA: 0x7FFAC3A5BC70
        public void GetHashCode(){} // RVA: 0x7FFAC3A5BCF0
        public void op_Implicit(){} // RVA: 0x7FFAC3A5BD70
        public void InitializeLazy(){} // RVA: 0x7FFAC3A5BE40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3A5BFB0
        public void GetCachedPtr(){} // RVA: 0x7FFAC3A5C380
        public void set_name_2EEE284FFCA1_2EEE284FFCA1(){} // RVA: 0x7FFAC3A5C5B0 | overloaded x2
        public void Instantiate(){} // RVA: 0x7FFAC3A5D080 | overloaded x4
        public void ToString_D9C5E482C810(){} // RVA: 0x7FFAC3A5D870 | overloaded x3
        public void TryProcessNetworkAction(){} // RVA: 0x7FFAC3A5DDC0
        public void ProcessEventFilter(){} // RVA: 0x7FFAC3A5DE60
        public void InitializeEventFilterState(){} // RVA: 0x7FFAC3A5DF00
        public void Destroy(){} // RVA: 0x7FFAC3A5E140
        public void ApplyEventFilteringLogic(){} // RVA: 0x7FFAC3A5E420
        public void .cctor(){} // RVA: 0x7FFAC3A5E710
        public void DestroyImmediate(){} // RVA: 0x7FFAC3A63130
        public void FindObjectsOfType(){} // RVA: 0x7FFAC3A63250
    }

    public class UnityVersion : ValueType
    {
        public System.Text.RegularExpressions.Regex versionRegex;
        public int major; // 0x10
        public int minor; // 0x14
        public int update; // 0x18
        public int revision; // 0x1C
        public bool patch; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF34C70
        public void CompareTo(){} // RVA: 0x7FFACBF34C90
        public void Parse(){} // RVA: 0x7FFACBF34D60
        public void TryParse(){} // RVA: 0x7FFACBF351A0
        public void ToString(){} // RVA: 0x7FFACBF355B0
        public void .cctor(){} // RVA: 0x7FFACBF35860
    }

    public class UpdateDelegator : Object
    {
        public object _queueLock;
        public VRC.Core.PriorityQueue`1<QueuedJob> _jobQueue; // 0x8
        public int MaxJobsPerFrame;

        // ── Methods ──
        public void Dispatch(){} // RVA: 0x7FFACBF35940
        public void DispatchAfter(){} // RVA: 0x7FFACBF35C60
        public void ManagedUpdate(){} // RVA: 0x7FFACBF35E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF36260
    }

    public class UrlAllowlistConfig : Object
    {
        public System.Lazy`1<System.ValueTuple`2<System.Collections.Generic.List`1<string>,System.Collections.Generic.List`1<string>>> DomainExplicitAllowlist;

        // ── Methods ──
        public void GetRemoteLists(){} // RVA: 0x7FFACBF2A400
        public void get_DomainExplicitAllowlist(){} // RVA: 0x7FFACBF2A920
        public void get_DomainWildcardAllowlist(){} // RVA: 0x7FFACBF2A9B0
        public void .cctor(){} // RVA: 0x7FFACBF2AA40
    }

}