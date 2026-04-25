// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq.Linq
// Classes: 89
// Methods: 540

namespace ThirdParty.ZLinq.ZLinq.Linq
{
    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__DescendingDefaultComparer`1 : Object
    {
        public System.Collections.Generic.IComparer`1<T> Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Compare(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__OrderByHelper : Object
    {
        // ── Methods ──
        public void TypeIsImplicitlyStable(){} // RVA: 0x7FFAC2C59D30
        public void QuickSelect(){} // RVA: 0x7FFACC0E1340
        public void PartialQuickSort(){} // RVA: 0x7FFACC0E15F0
        public void Min(){} // RVA: 0x7FFACC0E18E0
        public void Max(){} // RVA: 0x7FFACC0E1A50
    }

    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__UnsafeFunctions`2 : Object
    {
        public System.Func`2<U,T> Identity;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class AggregateBy2`4 : ValueType
    {
        public System.Func`2<V,W> <keySelector>P;
        public System.Func`2<W,U> <seedSelector>P;
        public System.Func`3<U,V,U> <func>P;
        public System.Collections.Generic.IEqualityComparer`1<W> <keyComparer>P;
        public U source;
        public ZLinq.Internal.DictionarySlim`2<W,U> dictionary;
        public Enumerator<W,U> enumerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Initialize(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class AggregateBy`4 : ValueType
    {
        public System.Func`2<V,W> <keySelector>P;
        public U <seed>P;
        public System.Func`3<U,V,U> <func>P;
        public System.Collections.Generic.IEqualityComparer`1<W> <keyComparer>P;
        public U source;
        public ZLinq.Internal.DictionarySlim`2<W,U> dictionary;
        public Enumerator<W,U> enumerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Initialize(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Append`2 : ValueType
    {
        public T <element>P;
        public U source;
        public byte state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class ArrayIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.ArrayIterator`1<T> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C5D200
        public void TryGetSpan(){} // RVA: 0x7FFAC2C5D200
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C5D200
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ArraySelect`2 : ValueType
    {
        public U[] source;
        public System.Func`2<U,T> selector;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class ArrayWhereSelect`2 : ValueType
    {
        public System.Func`2<U,bool> Predicate;
        public System.Func`2<U,T> Selector;
        public int index;
        public U[] source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void GetSource(){} // RVA: 0x7FFAC2C58E90
        public void get_Predicate(){} // RVA: 0x7FFAC2C58E90
        public void get_Selector(){} // RVA: 0x7FFAC2C58E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class ArrayWhere`1 : ValueType
    {
        public System.Func`2<T,bool> Predicate;
        public T[] source;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetSource(){} // RVA: 0x7FFAC2C58E90
        public void get_Predicate(){} // RVA: 0x7FFAC2C58E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Select(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Cast`3 : ValueType
    {
        public U source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Chunk`2 : ValueType
    {
        public int <size>P;
        public U source;
        public int index;
        public bool isInitialized;
        public bool isCompleted;
        public bool isCanGetSpan;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class CollectionIterator`1 : Object
    {
        // ── Methods ──
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C5D200
        public void TryGetSpan(){} // RVA: 0x7FFAC7E032A0
        public void TryCopyTo(){} // RVA: 0x7FFAC2F21320
        public void TryGetNext(){} // RVA: 0x7FFAC2C5D200
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Concat`3 : ValueType
    {
        public V first;
        public V second;
        public bool firstCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class CountBy`3 : ValueType
    {
        public System.Func`2<V,U> <keySelector>P;
        public System.Collections.Generic.IEqualityComparer`1<U> <keyComparer>P;
        public U source;
        public ZLinq.Internal.DictionarySlim`2<U,int> dictionary;
        public Enumerator<U,int> enumerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Initialize(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class DefaultIfEmpty`2 : ValueType
    {
        public U <defaultValue>P;
        public U source;
        public bool iterateDefault;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class DistinctBy`3 : ValueType
    {
        public System.Func`2<V,T> <keySelector>P;
        public System.Collections.Generic.IEqualityComparer`1<T> <comparer>P;
        public U source;
        public ZLinq.Internal.HashSetSlim`1<T> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Distinct`2 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<U> <comparer>P;
        public U source;
        public ZLinq.Internal.HashSetSlim`1<U> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class EnumerableIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.EnumerableIterator`1<T> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C5D200
        public void TryGetNext(){} // RVA: 0x7FFAC2C5D200
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void <TryGetNext>g__Initialize|3_0(){} // RVA: 0x7FFAC2C58F80
    }

    public class ExceptBy`4 : ValueType
    {
        public System.Func`2<W,U> <keySelector>P;
        public System.Collections.Generic.IEqualityComparer`1<U> <comparer>P;
        public V source;
        public ZLinq.ValueEnumerable`2<V,U> second;
        public ZLinq.Internal.HashSetSlim`1<U> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Except`3 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<T> <comparer>P;
        public V source;
        public ZLinq.ValueEnumerable`2<V,T> second;
        public ZLinq.Internal.HashSetSlim`1<T> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class FromArray`1 : ValueType
    {
        public T[] <source>P;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetSource(){} // RVA: 0x7FFAC2C58E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class FromEnumerableContent : ValueType
    {
        public object Source; // 0x10
        public int Index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BFE610
        public void ThrowIfNoEnumerable(){} // RVA: 0x7FFACC0E12D0
        public void <ThrowIfNoEnumerable>g__Throw|3_0(){} // RVA: 0x7FFACC0E12F0
    }

    public class FromEnumerable`1 : ValueType
    {
        public ZLinq.Linq.CollectionIterator`1<T> iterator;
        public ZLinq.Linq.FromEnumerableContent content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetSource(){} // RVA: 0x7FFAC2C58E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class FromList`1 : ValueType
    {
        public System.Collections.Generic.List`1<U> <source>P;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetSource(){} // RVA: 0x7FFAC2C58E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class FromMemory`1 : ValueType
    {
        public System.ReadOnlyMemory`1<T> <source>P;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class FromRange : ValueType
    {
        public int count; // 0x10
        public int start; // 0x14
        public int to; // 0x18
        public int value; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0E1BC0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC675A420
        public void TryGetSpan(){} // RVA: 0x7FFAC53E7770
        public void TryCopyTo(){} // RVA: 0x7FFACC0E1BE0
        public void TryGetNext(){} // RVA: 0x7FFACC0E1D30
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void FillIncremental(){} // RVA: 0x7FFACC0E1D50
    }

    public class GroupBy2`4 : ValueType
    {
        public System.Func`2<V,W> <keySelector>P;
        public System.Func`2<V,U> <elementSelector>P;
        public System.Collections.Generic.IEqualityComparer`1<W> <comparer>P;
        public U source;
        public bool init;
        public ZLinq.Linq.Grouping`2<W,U> rootGrouping;
        public ZLinq.Linq.Grouping`2<W,U> currentGrouping;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void BuildRoot(){} // RVA: 0x7FFAC2C58E90
    }

    public class GroupBy3`4 : ValueType
    {
        public System.Func`2<V,W> <keySelector>P;
        public System.Func`3<W,System.Collections.Generic.IEnumerable`1<V>,U> <resultSelector>P;
        public System.Collections.Generic.IEqualityComparer`1<W> <comparer>P;
        public U source;
        public bool init;
        public ZLinq.Linq.Grouping`2<W,V> rootGrouping;
        public ZLinq.Linq.Grouping`2<W,V> currentGrouping;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void BuildRoot(){} // RVA: 0x7FFAC2C58E90
    }

    public class GroupBy4`5 : ValueType
    {
        public System.Func`2<V,W> <keySelector>P;
        public System.Func`2<V,T4> <elementSelector>P;
        public System.Func`3<W,System.Collections.Generic.IEnumerable`1<T4>,T> <resultSelector>P;
        public System.Collections.Generic.IEqualityComparer`1<W> <comparer>P;
        public U source;
        public bool init;
        public ZLinq.Linq.Grouping`2<W,T4> rootGrouping;
        public ZLinq.Linq.Grouping`2<W,T4> currentGrouping;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void BuildRoot(){} // RVA: 0x7FFAC2C58E90
    }

    public class GroupBy`3 : ValueType
    {
        public System.Func`2<V,U> <keySelector>P;
        public System.Collections.Generic.IEqualityComparer`1<U> <comparer>P;
        public U source;
        public bool init;
        public ZLinq.Linq.Grouping`2<U,V> rootGrouping;
        public ZLinq.Linq.Grouping`2<U,V> currentGrouping;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void BuildRoot(){} // RVA: 0x7FFAC2C58E90
    }

    public class GroupJoin`6 : ValueType
    {
        public System.Func`2<W,T5> <outerKeySelector>P;
        public System.Func`2<T4,T5> <innerKeySelector>P;
        public System.Func`3<W,System.Collections.Generic.IEnumerable`1<T4>,U> <resultSelector>P;
        public System.Collections.Generic.IEqualityComparer`1<T5> <comparer>P;
        public V source;
        public V inner;
        public ZLinq.Linq.Lookup`2<T5,T4> innerLookup;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class GroupingDebugView`2 : Object
    {
    }

    public class Grouping`2 : Object
    {
        public U Key;
        public uint HashCode;
        public T[] Count;
        public int IsReadOnly;
        public ZLinq.Linq.Grouping`2<U,T> Item;
        public ZLinq.Linq.Grouping`2<U,T> NextGroupInSameHashCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_Key(){} // RVA: 0x7FFAC2E8DC40
        public void get_HashCode(){} // RVA: 0x7FFAC2C59960
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IListIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.IListIterator`1<T> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C5D200
        public void TryGetNext(){} // RVA: 0x7FFAC2C5D200
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class IOrderByComparable`1
    {
        // ── Methods ──
        public void GetComparer(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IOrderByComparer
    {
    }

    public class IReadOnlyListIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.IReadOnlyListIterator`1<T> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C5D200
        public void TryGetNext(){} // RVA: 0x7FFAC2C5D200
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class Index`2 : ValueType
    {
        public U source;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class IntersectBy`4 : ValueType
    {
        public System.Func`2<W,T> <keySelector>P;
        public System.Collections.Generic.IEqualityComparer`1<T> <comparer>P;
        public V source;
        public ZLinq.ValueEnumerable`2<V,T> second;
        public ZLinq.Internal.HashSetSlim`1<T> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Intersect`3 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<T> <comparer>P;
        public V source;
        public ZLinq.ValueEnumerable`2<V,T> second;
        public ZLinq.Internal.HashSetSlim`1<T> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Join`6 : ValueType
    {
        public System.Func`2<W,T5> <outerKeySelector>P;
        public System.Func`2<T4,T5> <innerKeySelector>P;
        public System.Func`3<W,T4,T> <resultSelector>P;
        public System.Collections.Generic.IEqualityComparer`1<T5> <comparer>P;
        public V source;
        public V inner;
        public ZLinq.Linq.Lookup`2<T5,T4> innerLookup;
        public ZLinq.Linq.Grouping`2<T5,T4> currentGroup;
        public int currentGroupIndex;
        public W currentOuter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class LeftJoin`6 : ValueType
    {
        public System.Func`2<W,T5> <outerKeySelector>P;
        public System.Func`2<T4,T5> <innerKeySelector>P;
        public System.Func`3<W,T4,U> <resultSelector>P;
        public System.Collections.Generic.IEqualityComparer`1<T5> <comparer>P;
        public V source;
        public V inner;
        public ZLinq.Linq.Lookup`2<T5,T4> innerLookup;
        public ZLinq.Linq.Grouping`2<T5,T4> currentGroup;
        public int currentGroupIndex;
        public W currentOuter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class ListIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.ListIterator`1<T> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C5D200
        public void TryGetSpan(){} // RVA: 0x7FFAC2C5D200
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C5D200
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ListSelect`2 : ValueType
    {
        public System.Collections.Generic.List`1<U> source;
        public System.Func`2<U,U> selector;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class ListWhereSelect`2 : ValueType
    {
        public System.Func`2<U,bool> <predicate>P;
        public System.Func`2<U,T> <selector>P;
        public int index;
        public System.Collections.Generic.List`1<U> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class ListWhere`1 : ValueType
    {
        public System.Func`2<T,bool> Predicate;
        public System.Collections.Generic.List`1<T> source;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetSource(){} // RVA: 0x7FFAC2C58E90
        public void get_Predicate(){} // RVA: 0x7FFAC2C58E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Select(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Lookup : Object
    {
        // ── Methods ──
        public void CreateForJoin(){} // RVA: 0x7FFAC2C69600
    }

    public class LookupBuilder`2 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<U> comparer;
        public ZLinq.Linq.Grouping`2<U,T>[] buckets;
        public int bucketsLength;
        public ZLinq.Linq.Grouping`2<U,T> last;
        public int groupCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetBucketIndex(){} // RVA: 0x7FFAC2C600D0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void BuildAndClear(){} // RVA: 0x7FFAC2C58E90
        public void GetRootGroupAndClear(){} // RVA: 0x7FFAC2C58E90
        public void ResizeAndRehash(){} // RVA: 0x7FFAC2C70980
    }

    public class LookupDebugView`2 : Object
    {
    }

    public class Lookup`2 : Object
    {
        public ZLinq.Linq.Lookup`2<U,T> Item;
        public ZLinq.Linq.Grouping`2<U,T>[] Count;
        public ZLinq.Linq.Grouping`2<U,T> System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.IsReadOnly;
        public int count;
        public System.Collections.Generic.IEqualityComparer`1<U> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void GetGroup(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void GetBucketIndex(){} // RVA: 0x7FFAC2C600D0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Add(){} // RVA: 0x7FFAC2C70A40
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Remove(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Clear(){} // RVA: 0x7FFAC2C70980
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Contains(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class OfType`3 : ValueType
    {
        public U source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class OrderByComparable`2 : Object
    {
        public System.Func`2<U,T> <keySelector>P;
        public ZLinq.Linq.IOrderByComparable`1<U> <parent>P;
        public bool <descending>P;
        public System.Collections.Generic.IComparer`1<T> comparer;

        // ── Methods ──
        public void .ctor(){}
        public void GetComparer(){} // RVA: 0x7FFAC2E8DC40
    }

    public class OrderByComparer`2 : Object
    {
        public T[] keys;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public ZLinq.Linq.IOrderByComparer childComparer;
        public bool descending;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Compare(){} // RVA: 0x7FFAC2C60290
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class OrderBySkipTake`3 : ValueType
    {
        public U source;
        public ZLinq.Linq.OrderByComparable`2<V,T> comparable;
        public int minIndexInclusive;
        public int maxIndexInclusive;
        public ZLinq.Internal.RentedArrayBox`1<V> buffer;
        public ZLinq.Internal.RentedArrayBox`1<int> indexMap;
        public int maxIndex;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void InitBuffer(){} // RVA: 0x7FFAC2C70980
        public void Sort(){} // RVA: 0x7FFAC2E8DC40
    }

    public class OrderBy`3 : ValueType
    {
        public System.Func`2<V,U> <keySelector>P;
        public System.Collections.Generic.IComparer`1<U> <comparer>P;
        public ZLinq.Linq.IOrderByComparable`1<V> <parent>P;
        public bool <descending>P;
        public U source;
        public ZLinq.Linq.OrderByComparable`2<V,U> comparable;
        public ZLinq.Internal.RentedArrayBox`1<V> buffer;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void InitBuffer(){} // RVA: 0x7FFAC2C70980
        public void Sort(){} // RVA: 0x7FFAC2E8DC40
        public void ThenBy(){} // RVA: 0x7FFAC2E8DC40
        public void IsAllowDirectSort(){} // RVA: 0x7FFAC2C59D00
    }

    public class Prepend`2 : ValueType
    {
        public U <element>P;
        public U source;
        public byte state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class RangeSelect`1 : ValueType
    {
        public int count;
        public int start;
        public int to;
        public int value;
        public System.Func`2<int,U> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Reverse`2 : ValueType
    {
        public U source;
        public ZLinq.Internal.RentedArrayBox`1<T> buffer;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void InitBuffer(){} // RVA: 0x7FFAC2C70980
    }

    public class RightJoin`6 : ValueType
    {
        public System.Func`2<W,T5> <outerKeySelector>P;
        public System.Func`2<T4,T5> <innerKeySelector>P;
        public System.Func`3<W,T4,U> <resultSelector>P;
        public System.Collections.Generic.IEqualityComparer`1<T5> <comparer>P;
        public V source;
        public V inner;
        public ZLinq.Linq.Lookup`2<T5,W> outerLookup;
        public ZLinq.Linq.Grouping`2<T5,W> currentGroup;
        public int currentGroupIndex;
        public T4 currentInner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Select2`3 : ValueType
    {
        public System.Func`3<V,int,T> <selector>P;
        public U source;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectMany2`3 : ValueType
    {
        public System.Func`3<V,int,System.Collections.Generic.IEnumerable`1<U>> <selector>P;
        public U source;
        public ZLinq.Linq.FromEnumerable`1<U> innerEnumerator;
        public bool hasInner;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectMany2`4 : ValueType
    {
        public System.Func`3<W,int,ZLinq.ValueEnumerable`2<V,T>> <selector>P;
        public V source;
        public V innerEnumerator;
        public bool hasInner;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectMany3`4 : ValueType
    {
        public System.Func`2<V,System.Collections.Generic.IEnumerable`1<W>> <collectionSelector>P;
        public System.Func`3<V,W,U> <resultSelector>P;
        public U source;
        public ZLinq.Linq.FromEnumerable`1<W> innerEnumerator;
        public V currentSource;
        public bool hasInner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectMany3`5 : ValueType
    {
        public System.Func`2<W,ZLinq.ValueEnumerable`2<V,T4>> <collectionSelector>P;
        public System.Func`3<W,T4,T> <resultSelector>P;
        public V source;
        public V innerEnumerator;
        public W currentSource;
        public bool hasInner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectMany4`4 : ValueType
    {
        public System.Func`3<V,int,System.Collections.Generic.IEnumerable`1<W>> <collectionSelector>P;
        public System.Func`3<V,W,U> <resultSelector>P;
        public U source;
        public ZLinq.Linq.FromEnumerable`1<W> innerEnumerator;
        public V currentSource;
        public int index;
        public bool hasInner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectMany4`5 : ValueType
    {
        public System.Func`3<W,int,ZLinq.ValueEnumerable`2<V,T4>> <collectionSelector>P;
        public System.Func`3<W,T4,T> <resultSelector>P;
        public V source;
        public V innerEnumerator;
        public W currentSource;
        public int index;
        public bool hasInner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectMany`3 : ValueType
    {
        public System.Func`2<V,System.Collections.Generic.IEnumerable`1<T>> <selector>P;
        public U source;
        public ZLinq.Linq.FromEnumerable`1<T> innerEnumerator;
        public bool hasInner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectMany`4 : ValueType
    {
        public System.Func`2<W,ZLinq.ValueEnumerable`2<V,U>> <selector>P;
        public V source;
        public V innerEnumerator;
        public bool hasInner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SelectWhere`3 : ValueType
    {
        public System.Func`2<V,T> <selector>P;
        public System.Func`2<T,bool> <predicate>P;
        public U source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Select`3 : ValueType
    {
        public U source;
        public System.Func`2<V,U> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Where(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Shuffle`2 : ValueType
    {
        public U source;
        public ZLinq.Internal.RentedArrayBox`1<U> buffer;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void InitBuffer(){} // RVA: 0x7FFAC2C70980
    }

    public class SkipLast`2 : ValueType
    {
        public U source;
        public int skipCount;
        public ZLinq.Internal.RefBox`1<ZLinq.Internal.ValueQueue`1<U>> buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SkipWhile2`2 : ValueType
    {
        public System.Func`3<U,int,bool> <predicate>P;
        public U source;
        public bool skippingDone;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class SkipWhile`2 : ValueType
    {
        public System.Func`2<U,bool> <predicate>P;
        public U source;
        public bool skippingDone;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Skip`2 : ValueType
    {
        public U source;
        public int skipCount;
        public int skipped;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class TakeLast`2 : ValueType
    {
        public U source;
        public int takeCount;
        public ZLinq.Internal.RefBox`1<ZLinq.Internal.ValueQueue`1<U>> q;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class TakeRange`2 : ValueType
    {
        public U source;
        public System.Range range;
        public int index;
        public int remains;
        public int skipIndex;
        public int fromEndQueueCount;
        public ZLinq.Internal.RefBox`1<ZLinq.Internal.ValueQueue`1<U>> q;
        public bool isInitialized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class TakeWhile2`2 : ValueType
    {
        public System.Func`3<U,int,bool> <predicate>P;
        public U source;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class TakeWhile`2 : ValueType
    {
        public System.Func`2<U,bool> <predicate>P;
        public U source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Take`2 : ValueType
    {
        public U source;
        public int takeCount;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class UnionBy`4 : ValueType
    {
        public System.Func`2<W,T> <keySelector>P;
        public System.Collections.Generic.IEqualityComparer`1<T> <comparer>P;
        public V source;
        public V second;
        public ZLinq.Internal.HashSetSlim`1<T> set;
        public byte state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Union`3 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<T> <comparer>P;
        public V source;
        public V second;
        public ZLinq.Internal.HashSetSlim`1<T> set;
        public byte state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Where2`2 : ValueType
    {
        public System.Func`3<U,int,bool> <predicate>P;
        public U source;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class WhereSelect`3 : ValueType
    {
        public System.Func`2<V,bool> Predicate;
        public System.Func`2<V,T> Selector;
        public U source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetSource(){} // RVA: 0x7FFAC2E8DC40
        public void get_Predicate(){} // RVA: 0x7FFAC2C58E90
        public void get_Selector(){} // RVA: 0x7FFAC2C58E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Where`2 : ValueType
    {
        public System.Func`2<U,bool> Predicate;
        public U source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetSource(){} // RVA: 0x7FFAC2E8DC40
        public void get_Predicate(){} // RVA: 0x7FFAC2C58E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Select(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Zip`4 : ValueType
    {
        public V source;
        public V second;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Zip`5 : ValueType
    {
        public System.Func`3<W,T4,T> <resultSelector>P;
        public V source;
        public V second;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class Zip`6 : ValueType
    {
        public T source;
        public W second;
        public W third;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFAC2C59F60
        public void TryGetSpan(){} // RVA: 0x7FFAC2C59F60
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNext(){} // RVA: 0x7FFAC2C59F60
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

}