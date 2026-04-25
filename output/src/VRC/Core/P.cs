// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 33

namespace VRC.Core
{
    public class PagedApiCalendarResult : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APICalendarEntry> results; // 0x68
        public string nextCursor; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFAC2F9CD50
        public void set_results(){} // RVA: 0x7FFAC2F9CD60
        public void get_nextCursor(){} // RVA: 0x7FFAC2FE9590
        public void set_nextCursor(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBED2B10
    }

    public class PagedApiGroupResult : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APIGroup> results; // 0x68
        public string nextCursor; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFAC2F9CD50
        public void set_results(){} // RVA: 0x7FFAC2F9CD60
        public void get_nextCursor(){} // RVA: 0x7FFAC2FE9590
        public void set_nextCursor(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBED2B60
    }

    public class PipelineManager : MonoBehaviour
    {
        public System.Collections.Generic.Dictionary`2<0x6B2E4F20,string> BlueprintIdPrefixMap;
        public bool launchedFromSDKPipeline; // 0x20
        public bool completedSDKPipeline; // 0x21
        public string blueprintId; // 0x28
        public VRC.Core.APIUser user; // 0x30
        public 0x6B2E4F20 contentType; // 0x38
        public string assetBundleUnityVersion; // 0x40
        public 0x6B2E4F78 fallbackStatus; // 0x48
        public 0x6B2E4FD0 owned; // 0x4C

        // ── Methods ──
        public void IsMyContent(){} // RVA: 0x7FFACBA2DED0
        public void AssignId(){} // RVA: 0x7FFACBA2E1A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void .cctor(){} // RVA: 0x7FFACBA2E630
        public void <IsMyContent>b__12_0(){} // RVA: 0x7FFACBA2E7F0
        public void <IsMyContent>b__12_1(){} // RVA: 0x7FFACBA2E900
        public void <IsMyContent>b__12_2(){} // RVA: 0x7FFACBA2E910
        public void <IsMyContent>b__12_3(){} // RVA: 0x7FFACBA2E900
    }

    public class PriorityQueue`1 : Object
    {
        public System.Collections.Generic.List`1<T> Data;
        public System.Collections.Generic.List`1<T> Count;
        public ReverseComparer<T> reverseComparer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2C58E90
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0 | overloaded x2
        public void Concat(){} // RVA: 0x7FFAC2C70A40
        public void Push(){} // RVA: 0x7FFAC2E8DC40
        public void Pop(){} // RVA: 0x7FFAC2C59F60
        public void Peek(){} // RVA: 0x7FFAC2C59F60
        public void PopNextMatch(){}
        public void RemoveWhere(){} // RVA: 0x7FFAC2C70A40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

}