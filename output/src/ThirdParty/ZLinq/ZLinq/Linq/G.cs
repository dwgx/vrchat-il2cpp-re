// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq.Linq
// Classes: 6
// Methods: 52

namespace ThirdParty.ZLinq.ZLinq.Linq
{
    public class GroupBy2`4 : ValueType
    {
        public object <keySelector>P;
        public object <elementSelector>P;
        public object <comparer>P;
        public object source;
        public object init;
        public object rootGrouping;
        public object currentGrouping;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void TryGetNonEnumeratedCount(){} // RVA: 0x87D350
        public void TryGetSpan(){} // RVA: 0x87D350
        public void TryCopyTo(){} // RVA: 0xA94080
        public void TryGetNext(){} // RVA: 0x87D350
        public void Dispose(){} // RVA: 0x894290
        public void BuildRoot(){} // RVA: 0x87C0A0
    }

    public class GroupBy3`4 : ValueType
    {
        public object <keySelector>P;
        public object <resultSelector>P;
        public object <comparer>P;
        public object source;
        public object init;
        public object rootGrouping;
        public object currentGrouping;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void TryGetNonEnumeratedCount(){} // RVA: 0x87D350
        public void TryGetSpan(){} // RVA: 0x87D350
        public void TryCopyTo(){} // RVA: 0xA94080
        public void TryGetNext(){} // RVA: 0x87D350
        public void Dispose(){} // RVA: 0x894290
        public void BuildRoot(){} // RVA: 0x87C0A0
    }

    public class GroupBy4`5 : ValueType
    {
        public object <keySelector>P;
        public object <elementSelector>P;
        public object <resultSelector>P;
        public object <comparer>P;
        public object source;
        public object init;
        public object rootGrouping;
        public object currentGrouping;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void TryGetNonEnumeratedCount(){} // RVA: 0x87D350
        public void TryGetSpan(){} // RVA: 0x87D350
        public void TryCopyTo(){} // RVA: 0xA94080
        public void TryGetNext(){} // RVA: 0x87D350
        public void Dispose(){} // RVA: 0x894290
        public void BuildRoot(){} // RVA: 0x87C0A0
    }

    public class GroupBy`3 : ValueType
    {
        public object <keySelector>P;
        public object <comparer>P;
        public object source;
        public object init;
        public object rootGrouping;
        public object currentGrouping;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void TryGetNonEnumeratedCount(){} // RVA: 0x87D350
        public void TryGetSpan(){} // RVA: 0x87D350
        public void TryCopyTo(){} // RVA: 0xA94080
        public void TryGetNext(){} // RVA: 0x87D350
        public void Dispose(){} // RVA: 0x894290
        public void BuildRoot(){} // RVA: 0x87C0A0
    }

    public class GroupJoin`6 : ValueType
    {
        public object <outerKeySelector>P;
        public object <innerKeySelector>P;
        public object <resultSelector>P;
        public object <comparer>P;
        public object source;
        public object inner;
        public object innerLookup;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void TryGetNonEnumeratedCount(){} // RVA: 0x87D350
        public void TryGetSpan(){} // RVA: 0x87D350
        public void TryCopyTo(){} // RVA: 0xA94080
        public void TryGetNext(){} // RVA: 0x87D350
        public void Dispose(){} // RVA: 0x894290
    }

    public class Grouping`2 : Object
    {
        public object key;
        public object hashCode;
        public object elements;
        public object count;
        public object NextGroupInAddOrder;
        public object NextGroupInSameHashCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void get_Key(){} // RVA: 0xA94080
        public void get_HashCode(){} // RVA: 0x87C130
        public void get_Count(){} // RVA: 0x87C130
        public void Add(){} // RVA: 0xA94080
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void IndexOf(){} // RVA: 0xA94080
        public void Insert(){} // RVA: 0xA94080
        public void RemoveAt(){} // RVA: 0x8944F0
        public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void Remove(){} // RVA: 0xA94080
    }

}