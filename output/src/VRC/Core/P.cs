// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 7
// Methods: 83

namespace VRC.Core
{
    public class PagedApiCalendarResult
    {
        public System.Collections.Generic.List`1<VRC.Core.APICalendarEntry> <results>k__BackingField; // 0x68
        public string <nextCursor>k__BackingField; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x358D50
        public void set_results(){} // RVA: 0x358D60
        public void get_nextCursor(){} // RVA: 0x3A5590
        public void set_nextCursor(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x98D1D80
    }

    public class PagedApiGroupResult
    {
        public System.Collections.Generic.List`1<VRC.Core.APIGroup> <results>k__BackingField; // 0x68
        public string <nextCursor>k__BackingField; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x358D50
        public void set_results(){} // RVA: 0x358D60
        public void get_nextCursor(){} // RVA: 0x3A5590
        public void set_nextCursor(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x98D1DD0
    }

    public class PipelineManager
    {
        // ── Methods ──
        public void IsMyContent(){} // RVA: 0x94250D0
        public void AssignId(){} // RVA: 0x94253A0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DDD50
        public void .cctor(){} // RVA: 0x9425830
        public void <IsMyContent>b__12_0(){} // RVA: 0x9425A40
        public void <IsMyContent>b__12_1(){} // RVA: 0x9425B50
        public void <IsMyContent>b__12_2(){} // RVA: 0x9425B60
        public void <IsMyContent>b__12_3(){} // RVA: 0x9425B50
    }

    public class PriorityQueue`1
    {
        public System.Collections.Generic.List`1<T> data;
        public System.Collections.Generic.List`1<T> concatBuffer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xCD60
        public void get_Count(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x24FA0 | overloaded x2
        public void Concat(){} // RVA: 0x24B10
        public void Push(){} // RVA: 0x283FA0
        public void Pop(){} // RVA: 0xDE40
        public void Peek(){} // RVA: 0xDE40
        public void PeekNextMatch(){}
        public void PopNextMatch(){}
        public void RemoveWhere(){} // RVA: 0x24B10
        public void Remove(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void Clear(){} // RVA: 0x24A50
        public void ReverseIndex(){} // RVA: 0x13FB0
        public void .cctor(){} // RVA: 0x24A80
    }

    public class PriorityQueue`1
    {
        public System.Collections.Generic.List`1<CacheEntry> data; // 0x10
        public System.Collections.Generic.List`1<CacheEntry> concatBuffer; // 0x18

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void get_Count(){} // RVA: 0xF3F910
        public void .ctor(){} // RVA: 0x3E090F0 | overloaded x2
        public void Concat(){} // RVA: 0x3E0B870
        public void Push(){} // RVA: 0x3E0C0D0
        public void Pop(){} // RVA: 0x3E0C400
        public void Peek(){} // RVA: 0x3E0C4F0
        public void PeekNextMatch(){} // RVA: 0x3E0C5C0
        public void PopNextMatch(){} // RVA: 0x3E0C750
        public void RemoveWhere(){} // RVA: 0x3E0C7D0
        public void Remove(){} // RVA: 0x3E0C800
        public void RemoveAt(){} // RVA: 0x3E0C8A0
        public void Clear(){} // RVA: 0x2BCC740
        public void ReverseIndex(){} // RVA: 0x3E09F60
        public void .cctor(){} // RVA: 0x2DD310
    }

    public class PriorityQueue`1
    {
        public System.Collections.Generic.List`1<ÏÎÏÌÎÎÌÌÏÌÏÏÌÎÍÏÌÌÏÍÎÎÌ> data; // 0x10
        public System.Collections.Generic.List`1<ÏÎÏÌÎÎÌÌÏÌÏÏÌÎÍÏÌÌÏÍÎÎÌ> concatBuffer; // 0x18

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void get_Count(){} // RVA: 0xF3F910
        public void .ctor(){} // RVA: 0x3E090F0 | overloaded x2
        public void Concat(){} // RVA: 0x3E091C0
        public void Push(){} // RVA: 0x3E09860
        public void Pop(){} // RVA: 0x3E09B30
        public void Peek(){} // RVA: 0x3E09C10
        public void PeekNextMatch(){} // RVA: 0x3E09CC0
        public void PopNextMatch(){} // RVA: 0x3E09E00
        public void RemoveWhere(){} // RVA: 0x3E09EB0
        public void Remove(){} // RVA: 0x3E09EE0
        public void RemoveAt(){} // RVA: 0x3E09F10
        public void Clear(){} // RVA: 0x2BCC740
        public void ReverseIndex(){} // RVA: 0x3E09F60
        public void .cctor(){} // RVA: 0x2DD310
    }

    public class PriorityQueue`1
    {
        public System.Collections.Generic.List`1<QueuedJob> data; // 0x10
        public System.Collections.Generic.List`1<QueuedJob> concatBuffer; // 0x18

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void get_Count(){} // RVA: 0xF3F910
        public void .ctor(){} // RVA: 0x3E090F0 | overloaded x2
        public void Concat(){} // RVA: 0x3E0C8D0
        public void Push(){} // RVA: 0x3E0D0A0
        public void Pop(){} // RVA: 0x3E0C400
        public void Peek(){} // RVA: 0x3E0C4F0
        public void PeekNextMatch(){} // RVA: 0x3E0C5C0
        public void PopNextMatch(){} // RVA: 0x3E0C750
        public void RemoveWhere(){} // RVA: 0x3E0C7D0
        public void Remove(){} // RVA: 0x3E0D330
        public void RemoveAt(){} // RVA: 0x3E0C8A0
        public void Clear(){} // RVA: 0x2BCC740
        public void ReverseIndex(){} // RVA: 0x3E09F60
        public void .cctor(){} // RVA: 0x2DD310
    }

}