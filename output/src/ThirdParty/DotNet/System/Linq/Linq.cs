// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq
// Classes: 15
// Methods: 127

namespace ThirdParty.DotNet.System.Linq
{
    public class Buffer`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void ToArray(){} // RVA: 0x7FFD4E078E90
    }

    public class EmptyEnumerable`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class Enumerable : Object
    {
        // ── Methods ──
        public void Where(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
        public void WhereIterator(){} // RVA: 0x7FFD4E078FF0
        public void Select(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
        public void SelectIterator(){} // RVA: 0x7FFD4E078FF0
        public void CombinePredicates(){} // RVA: 0x7FFD4E078FF0
        public void CombineSelectors(){} // RVA: 0x7FFD4E078FF0
        public void SelectMany(){} // RVA: 0x7FFD4E089600 | overloaded x2
        public void SelectManyIterator(){} // RVA: 0x7FFD4E089600 | overloaded x2
        public void Take(){} // RVA: 0x7FFD4E088090
        public void TakeIterator(){} // RVA: 0x7FFD4E088090
        public void Skip(){} // RVA: 0x7FFD4E088090
        public void SkipIterator(){} // RVA: 0x7FFD4E088090
        public void OrderBy(){} // RVA: 0x7FFD4E089600 | overloaded x2
        public void OrderByDescending(){} // RVA: 0x7FFD4E089600 | overloaded x2
        public void ThenBy(){} // RVA: 0x7FFD4E078FF0
        public void GroupBy(){} // RVA: 0x7FFD4E089600 | overloaded x3
        public void Concat(){} // RVA: 0x7FFD4E078FF0
        public void ConcatIterator(){} // RVA: 0x7FFD4E078FF0
        public void Append(){} // RVA: 0x7FFD4E2ADC40
        public void AppendIterator(){} // RVA: 0x7FFD4E2ADC40
        public void Prepend(){} // RVA: 0x7FFD4E2ADC40
        public void PrependIterator(){} // RVA: 0x7FFD4E2ADC40
        public void Zip(){} // RVA: 0x7FFD4E089600
        public void ZipIterator(){} // RVA: 0x7FFD4E089600
        public void Distinct(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
        public void DistinctIterator(){} // RVA: 0x7FFD4E078FF0
        public void Union(){} // RVA: 0x7FFD4E078FF0
        public void UnionIterator(){} // RVA: 0x7FFD4E089600
        public void Intersect(){} // RVA: 0x7FFD4E078FF0
        public void IntersectIterator(){} // RVA: 0x7FFD4E089600
        public void Except(){} // RVA: 0x7FFD4E078FF0
        public void ExceptIterator(){} // RVA: 0x7FFD4E089600
        public void Reverse(){} // RVA: 0x7FFD4E078F80
        public void ReverseIterator(){} // RVA: 0x7FFD4E078F80
        public void SequenceEqual(){} // RVA: 0x7FFD4E07D5A0 | overloaded x2
        public void AsEnumerable(){} // RVA: 0x7FFD4E078F80
        public void ToArray(){} // RVA: 0x7FFD4E078F80
        public void ToList(){} // RVA: 0x7FFD4E078F80
        public void ToDictionary(){} // RVA: 0x7FFD4E08B1A0 | overloaded x3
        public void OfType(){} // RVA: 0x7FFD4E078F80
        public void OfTypeIterator(){} // RVA: 0x7FFD4E078F80
        public void Cast(){} // RVA: 0x7FFD4E078F80
        public void CastIterator(){} // RVA: 0x7FFD4E078F80
        public void First(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void FirstOrDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Last(){} // RVA: 0x7FFD4E2ADC40
        public void LastOrDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Single(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SingleOrDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ElementAt(){} // RVA: 0x7FFD4E2ADC40
        public void Range(){} // RVA: 0x7FFD5415E0A0
        public void RangeIterator(){} // RVA: 0x7FFD5415E160
        public void Empty(){} // RVA: 0x7FFD4E078A90
        public void Any(){} // RVA: 0x7FFD4E07A350 | overloaded x2
        public void All(){} // RVA: 0x7FFD4E07A350
        public void Count(){} // RVA: 0x7FFD4E07E730 | overloaded x2
        public void Contains(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Aggregate(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Min(){} // RVA: 0x7FFD5415E1D0
        public void Max(){} // RVA: 0x7FFD4E07E730 | overloaded x2
        public void ToHashSet(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
    }

    public class EnumerableSorter`1 : Object
    {
        // ── Methods ──
        public void ComputeKeys(){} // RVA: 0x7FFD4E097970
        public void CompareKeys(){} // RVA: 0x7FFD4E080290
        public void Sort(){} // RVA: 0x7FFD50C7D2A0
        public void QuickSort(){} // RVA: 0x7FFD50C7D380
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EnumerableSorter`2 : EnumerableSorter`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void ComputeKeys(){} // RVA: 0x7FFD4E097970
        public void CompareKeys(){} // RVA: 0x7FFD4E080290
    }

    public class GroupedEnumerable`3 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09B8C0
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class GroupedEnumerable`4 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09BB70
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class IGrouping`2
    {
        public object Key;

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ILookup`2
    {
        public object Item;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IOrderedEnumerable`1
    {
        // ── Methods ──
        public void CreateOrderedEnumerable(){}
    }

    public class IdentityFunction`1 : Object
    {
        public object Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD4E078A90
    }

    public class Lookup`2 : Object
    {
        public object Item;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E08B1A0
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void ApplyResultSelector(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E2ADC40
        public void GetGrouping(){} // RVA: 0x7FFD4E2ADC40
        public void Resize(){} // RVA: 0x7FFD4E090980
    }

    public class OrderedEnumerable`1 : Object
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerableSorter(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class OrderedEnumerable`2 : OrderedEnumerable`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetEnumerableSorter(){} // RVA: 0x7FFD4E078F40
    }

    public class Set`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void Find(){} // RVA: 0x7FFD4E2ADC40
        public void Resize(){} // RVA: 0x7FFD4E090980
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E2ADC40
    }

}