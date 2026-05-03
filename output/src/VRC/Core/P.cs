// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 33

namespace VRC.Core
{
    public class PagedApiCalendarResult : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APICalendarEntry> _results; // 0x68
        public string _nextCursor; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFE81176D50
        public void set_results(){} // RVA: 0x7FFE81176D60
        public void get_nextCursor(){} // RVA: 0x7FFE811C3590
        public void set_nextCursor(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A331A60
    }

    public class PagedApiGroupResult : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APIGroup> _results; // 0x68
        public string _nextCursor; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFE81176D50
        public void set_results(){} // RVA: 0x7FFE81176D60
        public void get_nextCursor(){} // RVA: 0x7FFE811C3590
        public void set_nextCursor(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A331AB0
    }

    public class PipelineManager : MonoBehaviour
    {
        // ── Methods ──
        public void IsMyContent(){} // RVA: 0x7FFE89E874A0
        public void AssignId(){} // RVA: 0x7FFE89E87770 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void .cctor(){} // RVA: 0x7FFE89E87C00
        public void <IsMyContent>b__12_0(){} // RVA: 0x7FFE89E87E10
        public void <IsMyContent>b__12_1(){} // RVA: 0x7FFE89E87F20
        public void <IsMyContent>b__12_2(){} // RVA: 0x7FFE89E87F30
        public void <IsMyContent>b__12_3(){} // RVA: 0x7FFE89E87F20
    }

    public class PriorityQueue`1 : Object
    {
        public System.Collections.Generic.List`1<T> data;
        public System.Collections.Generic.List`1<T> concatBuffer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE80E2E2E0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE80E46530 | overloaded x2
        public void Concat(){} // RVA: 0x7FFE80E460A0
        public void Push(){} // RVA: 0x7FFE810A1420
        public void Pop(){} // RVA: 0x7FFE80E2F3B0
        public void Peek(){} // RVA: 0x7FFE80E2F3B0
        public void PopNextMatch(){}
        public void RemoveWhere(){} // RVA: 0x7FFE80E460A0
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

}