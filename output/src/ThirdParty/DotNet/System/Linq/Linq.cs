// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq
// Classes: 16
// Methods: 134

namespace ThirdParty.DotNet.System.Linq
{
    public class Buffer`1 : ValueType
    {
        public T[] items;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
    }

    public class EmptyEnumerable`1 : Object
    {
        public T[] Instance;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class Enumerable : Object
    {
        // ── Methods ──
        public void Where(){} // RVA: 0x7FFAC2C58FF0 | overloaded x2
        public void WhereIterator(){} // RVA: 0x7FFAC2C58FF0
        public void Select(){} // RVA: 0x7FFAC2C58FF0 | overloaded x2
        public void SelectIterator(){} // RVA: 0x7FFAC2C58FF0
        public void CombinePredicates(){} // RVA: 0x7FFAC2C58FF0
        public void CombineSelectors(){} // RVA: 0x7FFAC2C58FF0
        public void SelectMany(){} // RVA: 0x7FFAC2C69600 | overloaded x2
        public void SelectManyIterator(){} // RVA: 0x7FFAC2C69600 | overloaded x2
        public void Take(){} // RVA: 0x7FFAC2C68090
        public void TakeIterator(){} // RVA: 0x7FFAC2C68090
        public void Skip(){} // RVA: 0x7FFAC2C68090
        public void SkipIterator(){} // RVA: 0x7FFAC2C68090
        public void OrderBy(){} // RVA: 0x7FFAC2C69600 | overloaded x2
        public void OrderByDescending(){} // RVA: 0x7FFAC2C69600 | overloaded x2
        public void ThenBy(){} // RVA: 0x7FFAC2C58FF0
        public void GroupBy(){} // RVA: 0x7FFAC2C69600 | overloaded x3
        public void Concat(){} // RVA: 0x7FFAC2C58FF0
        public void ConcatIterator(){} // RVA: 0x7FFAC2C58FF0
        public void Append(){} // RVA: 0x7FFAC2E8DC40
        public void AppendIterator(){} // RVA: 0x7FFAC2E8DC40
        public void Prepend(){} // RVA: 0x7FFAC2E8DC40
        public void PrependIterator(){} // RVA: 0x7FFAC2E8DC40
        public void Zip(){} // RVA: 0x7FFAC2C69600
        public void ZipIterator(){} // RVA: 0x7FFAC2C69600
        public void Distinct(){} // RVA: 0x7FFAC2C58FF0 | overloaded x2
        public void DistinctIterator(){} // RVA: 0x7FFAC2C58FF0
        public void Union(){} // RVA: 0x7FFAC2C58FF0
        public void UnionIterator(){} // RVA: 0x7FFAC2C69600
        public void Intersect(){} // RVA: 0x7FFAC2C58FF0
        public void IntersectIterator(){} // RVA: 0x7FFAC2C69600
        public void Except(){} // RVA: 0x7FFAC2C58FF0
        public void ExceptIterator(){} // RVA: 0x7FFAC2C69600
        public void Reverse(){} // RVA: 0x7FFAC2C58F80
        public void ReverseIterator(){} // RVA: 0x7FFAC2C58F80
        public void SequenceEqual(){} // RVA: 0x7FFAC2C5D5A0 | overloaded x2
        public void AsEnumerable(){} // RVA: 0x7FFAC2C58F80
        public void ToArray(){} // RVA: 0x7FFAC2C58F80
        public void ToList(){} // RVA: 0x7FFAC2C58F80
        public void ToDictionary(){} // RVA: 0x7FFAC2C6B1A0 | overloaded x3
        public void OfType(){} // RVA: 0x7FFAC2C58F80
        public void OfTypeIterator(){} // RVA: 0x7FFAC2C58F80
        public void Cast(){} // RVA: 0x7FFAC2C58F80
        public void CastIterator(){} // RVA: 0x7FFAC2C58F80
        public void First(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void FirstOrDefault(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Last(){} // RVA: 0x7FFAC2E8DC40
        public void LastOrDefault(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Single(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SingleOrDefault(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ElementAt(){} // RVA: 0x7FFAC2E8DC40
        public void Range(){} // RVA: 0x7FFAC8D3E0A0
        public void RangeIterator(){} // RVA: 0x7FFAC8D3E160
        public void Empty(){} // RVA: 0x7FFAC2C58A90
        public void Any(){} // RVA: 0x7FFAC2C5A350 | overloaded x2
        public void All(){} // RVA: 0x7FFAC2C5A350
        public void Count(){} // RVA: 0x7FFAC2C5E730 | overloaded x2
        public void Contains(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Aggregate(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Min(){} // RVA: 0x7FFAC8D3E1D0
        public void Max(){} // RVA: 0x7FFAC2C5E730 | overloaded x2
        public void ToHashSet(){} // RVA: 0x7FFAC2C58FF0 | overloaded x2
    }

    public class EnumerableSorter`1 : Object
    {
        // ── Methods ──
        public void ComputeKeys(){} // RVA: 0x7FFAC2C77970
        public void CompareKeys(){} // RVA: 0x7FFAC2C60290
        public void Sort(){} // RVA: 0x7FFAC585D2A0
        public void QuickSort(){} // RVA: 0x7FFAC585D380
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EnumerableSorter`2 : EnumerableSorter`1
    {
        public System.Func`2<U,T> keySelector;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public bool descending;
        public System.Linq.EnumerableSorter`1<U> next;
        public T[] keys;

        // ── Methods ──
        public void .ctor(){}
        public void ComputeKeys(){} // RVA: 0x7FFAC2C77970
        public void CompareKeys(){} // RVA: 0x7FFAC2C60290
    }

    public class Error : Object
    {
        // ── Methods ──
        public void ArgumentNull(){} // RVA: 0x7FFAC8D3DD40
        public void ArgumentOutOfRange(){} // RVA: 0x7FFAC8D3DDD0
        public void MoreThanOneElement(){} // RVA: 0x7FFAC8D3DE60
        public void MoreThanOneMatch(){} // RVA: 0x7FFAC8D3DED0
        public void NoElements(){} // RVA: 0x7FFAC8D3DF40
        public void NoMatch(){} // RVA: 0x7FFAC8D3DFB0
        public void NotSupported(){} // RVA: 0x7FFAC8D3E020
    }

    public class GroupedEnumerable`3 : Object
    {
        public System.Collections.Generic.IEnumerable`1<U> source;
        public System.Func`2<U,V> keySelector;
        public System.Func`2<U,T> elementSelector;
        public System.Collections.Generic.IEqualityComparer`1<V> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7B8C0
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class GroupedEnumerable`4 : Object
    {
        public System.Collections.Generic.IEnumerable`1<U> source;
        public System.Func`2<U,V> keySelector;
        public System.Func`2<U,W> elementSelector;
        public System.Collections.Generic.IEqualityComparer`1<V> comparer;
        public System.Func`3<V,System.Collections.Generic.IEnumerable`1<W>,T> resultSelector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7BB70
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class IGrouping`2
    {
        public object Key;

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ILookup`2
    {
        public object Item;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
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
        public void get_Instance(){} // RVA: 0x7FFAC2C58A90
    }

    public class Lookup`2 : Object
    {
        public System.Collections.Generic.IEqualityComparer`1<U> Item;
        public Grouping<U,T>[] groupings;
        public Grouping<U,T> lastGrouping;
        public int count;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2C6B1A0
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void ApplyResultSelector(){} // RVA: 0x7FFAC2C58F40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2E8DC40
        public void GetGrouping(){} // RVA: 0x7FFAC2E8DC40
        public void Resize(){} // RVA: 0x7FFAC2C70980
    }

    public class OrderedEnumerable`1 : Object
    {
        public System.Collections.Generic.IEnumerable`1<T> source;

        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void GetEnumerableSorter(){} // RVA: 0x7FFAC2C58F40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(){}
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class OrderedEnumerable`2 : OrderedEnumerable`1
    {
        public System.Linq.OrderedEnumerable`1<U> parent;
        public System.Func`2<U,T> keySelector;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public bool descending;

        // ── Methods ──
        public void .ctor(){}
        public void GetEnumerableSorter(){} // RVA: 0x7FFAC2C58F40
    }

    public class Set`1 : Object
    {
        public int[] buckets;
        public Slot<T>[] slots;
        public int count;
        public int freeList;
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void Find(){} // RVA: 0x7FFAC2E8DC40
        public void Resize(){} // RVA: 0x7FFAC2C70980
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2E8DC40
    }

}