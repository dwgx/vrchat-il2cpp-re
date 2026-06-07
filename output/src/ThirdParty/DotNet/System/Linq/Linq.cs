// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq
// Classes: 16
// Methods: 137

namespace ThirdParty.DotNet.System.Linq
{
    public class Buffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void ToArray(){} // RVA: 0xCD60
    }

    public class EmptyEnumerable`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
    }

    public class Enumerable
    {
        // ── Methods ──
        public void Where(){} // RVA: 0xCEC0 | overloaded x2
        public void WhereIterator(){} // RVA: 0xCEC0
        public void Select(){} // RVA: 0xCEC0 | overloaded x2
        public void SelectIterator(){} // RVA: 0xCEC0
        public void CombinePredicates(){} // RVA: 0xCEC0
        public void CombineSelectors(){} // RVA: 0xCEC0
        public void SelectMany(){} // RVA: 0x1D550 | overloaded x2
        public void SelectManyIterator(){} // RVA: 0x1D550 | overloaded x2
        public void Take(){} // RVA: 0x1BF70
        public void TakeIterator(){} // RVA: 0x1BF70
        public void Skip(){} // RVA: 0x1BF70
        public void SkipIterator(){} // RVA: 0x1BF70
        public void OrderBy(){} // RVA: 0x1D550 | overloaded x2
        public void OrderByDescending(){} // RVA: 0x1D550 | overloaded x2
        public void ThenBy(){} // RVA: 0xCEC0
        public void GroupBy(){} // RVA: 0x1D550 | overloaded x3
        public void Concat(){} // RVA: 0xCEC0
        public void ConcatIterator(){} // RVA: 0xCEC0
        public void Append(){} // RVA: 0x283FA0
        public void AppendIterator(){} // RVA: 0x283FA0
        public void Prepend(){} // RVA: 0x283FA0
        public void PrependIterator(){} // RVA: 0x283FA0
        public void Zip(){} // RVA: 0x1D550
        public void ZipIterator(){} // RVA: 0x1D550
        public void Distinct(){} // RVA: 0xCEC0 | overloaded x2
        public void DistinctIterator(){} // RVA: 0xCEC0
        public void Union(){} // RVA: 0xCEC0
        public void UnionIterator(){} // RVA: 0x1D550
        public void Intersect(){} // RVA: 0xCEC0
        public void IntersectIterator(){} // RVA: 0x1D550
        public void Except(){} // RVA: 0xCEC0
        public void ExceptIterator(){} // RVA: 0x1D550
        public void Reverse(){} // RVA: 0xCE50
        public void ReverseIterator(){} // RVA: 0xCE50
        public void SequenceEqual(){} // RVA: 0x114C0 | overloaded x2
        public void AsEnumerable(){} // RVA: 0xCE50
        public void ToArray(){} // RVA: 0xCE50
        public void ToList(){} // RVA: 0xCE50
        public void ToDictionary(){} // RVA: 0x1F150 | overloaded x3
        public void OfType(){} // RVA: 0xCE50
        public void OfTypeIterator(){} // RVA: 0xCE50
        public void Cast(){} // RVA: 0xCE50
        public void CastIterator(){} // RVA: 0xCE50
        public void First(){} // RVA: 0x283FA0 | overloaded x2
        public void FirstOrDefault(){} // RVA: 0x283FA0 | overloaded x2
        public void Last(){} // RVA: 0x283FA0
        public void LastOrDefault(){} // RVA: 0x283FA0 | overloaded x2
        public void Single(){} // RVA: 0x283FA0 | overloaded x2
        public void SingleOrDefault(){} // RVA: 0x283FA0 | overloaded x2
        public void ElementAt(){} // RVA: 0x283FA0
        public void ElementAtOrDefault(){} // RVA: 0x283FA0
        public void Range(){} // RVA: 0x65A7500
        public void RangeIterator(){} // RVA: 0x65A75C0
        public void Empty(){} // RVA: 0xC960
        public void Any(){} // RVA: 0xE230 | overloaded x2
        public void All(){} // RVA: 0xE230
        public void Count(){} // RVA: 0x12610 | overloaded x2
        public void Contains(){} // RVA: 0x283FA0 | overloaded x2
        public void Aggregate(){} // RVA: 0x283FA0 | overloaded x2
        public void Sum(){} // RVA: 0x12610 | overloaded x2
        public void Min(){} // RVA: 0x65A7800
        public void Max(){} // RVA: 0x12610 | overloaded x2
        public void ToHashSet(){} // RVA: 0xCEC0 | overloaded x2
    }

    public class EnumerableSorter`1
    {
        // ── Methods ──
        public void ComputeKeys(){} // RVA: 0x2BAA0
        public void CompareKeys(){} // RVA: 0x14170
        public void Sort(){} // RVA: 0x2ECAC10
        public void QuickSort(){} // RVA: 0x2ECACF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EnumerableSorter`2
    {
        // ── Methods ──
        public void .ctor(){}
        public void ComputeKeys(){} // RVA: 0x2BAA0
        public void CompareKeys(){} // RVA: 0x14170
    }

    public class Error
    {
        // ── Methods ──
        public void ArgumentNull(){} // RVA: 0x65A71A0
        public void ArgumentOutOfRange(){} // RVA: 0x65A7230
        public void MoreThanOneElement(){} // RVA: 0x65A72C0
        public void MoreThanOneMatch(){} // RVA: 0x65A7330
        public void NoElements(){} // RVA: 0x65A73A0
        public void NoMatch(){} // RVA: 0x65A7410
        public void NotSupported(){} // RVA: 0x65A7480
    }

    public class GroupedEnumerable`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2F9F0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class GroupedEnumerable`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2FCA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class IGrouping`2
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x283FA0
    }

    public class ILookup`2
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x283FA0
    }

    public class IOrderedEnumerable`1
    {
        // ── Methods ──
        public void CreateOrderedEnumerable(){}
    }

    public class IdentityFunction`1
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0xC960
    }

    public class Lookup`2
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x1F150
        public void .ctor(){} // RVA: 0x24B10
        public void get_Item(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void ApplyResultSelector(){} // RVA: 0xCE10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void InternalGetHashCode(){} // RVA: 0x283FA0
        public void GetGrouping(){} // RVA: 0x283FA0
        public void Resize(){} // RVA: 0x24A50
    }

    public class OrderedEnumerable`1
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0xCD60
        public void GetEnumerableSorter(){} // RVA: 0xCE10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(){}
        public void .ctor(){} // RVA: 0x24A50
    }

    public class OrderedEnumerable`2
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetEnumerableSorter(){} // RVA: 0xCE10
    }

    public class Set`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void Add(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void Find(){} // RVA: 0x283FA0
        public void Resize(){} // RVA: 0x24A50
        public void InternalGetHashCode(){} // RVA: 0x283FA0
    }

}