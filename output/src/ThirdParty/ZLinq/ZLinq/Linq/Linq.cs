// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq.Linq
// Classes: 86
// Methods: 540

namespace ThirdParty.ZLinq.ZLinq.Linq
{
    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__DescendingDefaultComparer`1 : Object
    {
        public System.Collections.Generic.IComparer`1<Transmtn.DTO.Notifications.Notification> Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Compare(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__OrderByHelper : Object
    {
        // ── Methods ──
        public void TypeIsImplicitlyStable(){} // RVA: 0x7FFD4E079D30
        public void QuickSelect(){} // RVA: 0x7FFD57501340
        public void PartialQuickSort(){} // RVA: 0x7FFD575015F0
        public void Min(){} // RVA: 0x7FFD575018E0
        public void Max(){} // RVA: 0x7FFD57501A50
    }

    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__UnsafeFunctions`2 : Object
    {
        public System.Func`2<Transmtn.DTO.Notifications.Notification,long> Identity;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Initialize(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Initialize(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Append`2 : ValueType
    {
        public int <element>P; // 0x10
        public ZLinq.Linq.FromEnumerable`1<int> source; // 0x18
        public byte state; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class ArrayIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.ArrayIterator`1<System.Collections.Generic.KeyValuePair`2<string,int>> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E07D200
        public void TryGetSpan(){} // RVA: 0x7FFD4E07D200
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E07D200
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ArraySelect`2 : ValueType
    {
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ[] source; // 0x10
        public System.Func`2<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ,int> selector; // 0x18
        public int index; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class ArrayWhereSelect`2 : ValueType
    {
        public System.Func`2<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ,bool> Predicate; // 0x10
        public System.Func`2<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ,int> Selector; // 0x18
        public int index; // 0x20
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ[] source; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void GetSource(){} // RVA: 0x7FFD4E078E90
        public void get_Predicate(){} // RVA: 0x7FFD4E078E90
        public void get_Selector(){} // RVA: 0x7FFD4E078E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class ArrayWhere`1 : ValueType
    {
        public System.Func`2<ÎÎÌÏÏÏÎÌÏÌÌÏÍÍÏÌÌÍÏÎÍÏÍ,bool> Predicate; // 0x10
        public ÎÎÌÏÏÏÎÌÏÌÌÏÍÍÏÌÌÍÏÎÍÏÍ[] source; // 0x18
        public int index; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetSource(){} // RVA: 0x7FFD4E078E90
        public void get_Predicate(){} // RVA: 0x7FFD4E078E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Select(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Cast`3 : ValueType
    {
        public ZLinq.Linq.FromEnumerable`1<object> source; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class CollectionIterator`1 : Object
    {
        // ── Methods ──
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E07D200
        public void TryGetSpan(){} // RVA: 0x7FFD532232A0
        public void TryCopyTo(){} // RVA: 0x7FFD4E341320
        public void TryGetNext(){} // RVA: 0x7FFD4E07D200
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Concat`3 : ValueType
    {
        public V first;
        public V second;
        public bool firstCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class CountBy`3 : ValueType
    {
        public System.Func`2<V,U> <keySelector>P;
        public System.Collections.Generic.IEqualityComparer`1<U> <keyComparer>P;
        public U source;
        public ZLinq.Internal.DictionarySlim`2<U,int> dictionary;
        public Enumerator<U,int> enumerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Initialize(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class DefaultIfEmpty`2 : ValueType
    {
        public U <defaultValue>P;
        public U source;
        public bool iterateDefault;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class DistinctBy`3 : ValueType
    {
        public System.Func`2<ÏÏÌÎÍÎÏÌÎÍÌÌÎÌÏÍÏÏÍÎÏÎÌ,string> <keySelector>P; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<string> <comparer>P; // 0x18
        public ZLinq.Linq.Reverse`2<ZLinq.Linq.ListWhere`1<ÏÏÌÎÍÎÏÌÎÍÌÌÎÌÏÍÏÏÍÎÏÎÌ>,ÏÏÌÎÍÎÏÌÎÍÌÌÎÌÏÍÏÏÍÎÏÎÌ> source; // 0x20
        public ZLinq.Internal.HashSetSlim`1<string> set; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Distinct`2 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<U> <comparer>P;
        public U source;
        public ZLinq.Internal.HashSetSlim`1<U> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class EnumerableIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.EnumerableIterator`1<System.Collections.Generic.KeyValuePair`2<string,int>> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E07D200
        public void TryGetNext(){} // RVA: 0x7FFD4E07D200
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void <TryGetNext>g__Initialize|3_0(){} // RVA: 0x7FFD4E078F80
    }

    public class ExceptBy`4 : ValueType
    {
        public System.Func`2<W,U> <keySelector>P;
        public System.Collections.Generic.IEqualityComparer`1<U> <comparer>P;
        public V source;
        public ZLinq.ValueEnumerable`2<V,U> second;
        public ZLinq.Internal.HashSetSlim`1<U> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Except`3 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<Transmtn.DTO.Notifications.Notification> <comparer>P; // 0x10
        public ZLinq.Linq.FromList`1<Transmtn.DTO.Notifications.Notification> source; // 0x18
        public ZLinq.ValueEnumerable`2<ZLinq.Linq.ListWhere`1<Transmtn.DTO.Notifications.Notification>,Transmtn.DTO.Notifications.Notification> second; // 0x28
        public ZLinq.Internal.HashSetSlim`1<Transmtn.DTO.Notifications.Notification> set; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class FromArray`1 : ValueType
    {
        public int[] <source>P; // 0x10
        public int index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetSource(){} // RVA: 0x7FFD4E078E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class FromEnumerableContent : ValueType
    {
        public object Source; // 0x10
        public int Index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5501E610
        public void ThrowIfNoEnumerable(){} // RVA: 0x7FFD575012D0
        public void <ThrowIfNoEnumerable>g__Throw|3_0(){} // RVA: 0x7FFD575012F0
    }

    public class FromEnumerable`1 : ValueType
    {
        public ZLinq.Linq.CollectionIterator`1<System.Collections.Generic.KeyValuePair`2<string,int>> iterator; // 0x10
        public ZLinq.Linq.FromEnumerableContent content; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetSource(){} // RVA: 0x7FFD4E078E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class FromList`1 : ValueType
    {
        public System.Collections.Generic.List`1<ÌÌÏÌÏÏÍÏÍÌÎÎÌÌÏÌÌÍÍÌÍÏÌ> <source>P; // 0x10
        public int index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetSource(){} // RVA: 0x7FFD4E078E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class FromMemory`1 : ValueType
    {
        public System.ReadOnlyMemory`1<Cysharp.Threading.Tasks.UniTask`1<System.ValueTuple`3<ÎÎÏÍÏÌÏÌÎÎÏÎÎÍÍÎÎÎÍÏÍÍÏ,ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ,int>>> <source>P; // 0x10
        public int index; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class FromRange : ValueType
    {
        public int count; // 0x10
        public int start; // 0x14
        public int to; // 0x18
        public int value; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57501BC0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD51B7A420
        public void TryGetSpan(){} // RVA: 0x7FFD50807770
        public void TryCopyTo(){} // RVA: 0x7FFD57501BE0
        public void TryGetNext(){} // RVA: 0x7FFD57501D30
        public void Dispose(){} // RVA: 0x7FFD4E341310
        public void FillIncremental(){} // RVA: 0x7FFD57501D50
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void BuildRoot(){} // RVA: 0x7FFD4E078E90
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void BuildRoot(){} // RVA: 0x7FFD4E078E90
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void BuildRoot(){} // RVA: 0x7FFD4E078E90
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void BuildRoot(){} // RVA: 0x7FFD4E078E90
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_Key(){} // RVA: 0x7FFD4E2ADC40
        public void get_HashCode(){} // RVA: 0x7FFD4E079960
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IListIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.IListIterator`1<System.Collections.Generic.KeyValuePair`2<string,int>> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E07D200
        public void TryGetNext(){} // RVA: 0x7FFD4E07D200
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class IOrderByComparable`1
    {
        // ── Methods ──
        public void GetComparer(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IReadOnlyListIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.IReadOnlyListIterator`1<System.Collections.Generic.KeyValuePair`2<string,int>> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E07D200
        public void TryGetNext(){} // RVA: 0x7FFD4E07D200
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class Index`2 : ValueType
    {
        public ZLinq.Linq.FromEnumerable`1<ÎÎÏÌÍÌÌÍÍÌÏÎÍÍÏÍÌÎÌÍÎÍÏ> source; // 0x10
        public int index; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class IntersectBy`4 : ValueType
    {
        public System.Func`2<W,T> <keySelector>P;
        public System.Collections.Generic.IEqualityComparer`1<T> <comparer>P;
        public V source;
        public ZLinq.ValueEnumerable`2<V,T> second;
        public ZLinq.Internal.HashSetSlim`1<T> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Intersect`3 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<T> <comparer>P;
        public V source;
        public ZLinq.ValueEnumerable`2<V,T> second;
        public ZLinq.Internal.HashSetSlim`1<T> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class ListIterator`1 : CollectionIterator`1
    {
        public ZLinq.Linq.ListIterator`1<System.Collections.Generic.KeyValuePair`2<string,int>> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E07D200
        public void TryGetSpan(){} // RVA: 0x7FFD4E07D200
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E07D200
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ListSelect`2 : ValueType
    {
        public System.Collections.Generic.List`1<Transmtn.DTO.Notifications.Notification> source; // 0x10
        public System.Func`2<Transmtn.DTO.Notifications.Notification,ÍÎÎÍÏÌÎÏÏÌÌÏÌÌÏÎÏÌÌÌÌÍÏ> selector; // 0x18
        public int index; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class ListWhereSelect`2 : ValueType
    {
        public System.Func`2<U,bool> <predicate>P;
        public System.Func`2<U,T> <selector>P;
        public int index;
        public System.Collections.Generic.List`1<U> source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class ListWhere`1 : ValueType
    {
        public System.Func`2<Transmtn.DTO.Notifications.Notification,bool> Predicate; // 0x10
        public System.Collections.Generic.List`1<Transmtn.DTO.Notifications.Notification> source; // 0x18
        public int index; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetSource(){} // RVA: 0x7FFD4E078E90
        public void get_Predicate(){} // RVA: 0x7FFD4E078E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Select(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Lookup : Object
    {
        // ── Methods ──
        public void CreateForJoin(){} // RVA: 0x7FFD4E089600
    }

    public class LookupBuilder`2 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<U> comparer;
        public ZLinq.Linq.Grouping`2<U,T>[] buckets;
        public int bucketsLength;
        public ZLinq.Linq.Grouping`2<U,T> last;
        public int groupCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetBucketIndex(){} // RVA: 0x7FFD4E0800D0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void BuildAndClear(){} // RVA: 0x7FFD4E078E90
        public void GetRootGroupAndClear(){} // RVA: 0x7FFD4E078E90
        public void ResizeAndRehash(){} // RVA: 0x7FFD4E090980
    }

    public class Lookup`2 : Object
    {
        public ZLinq.Linq.Lookup`2<U,T> Item;
        public ZLinq.Linq.Grouping`2<U,T>[] Count;
        public ZLinq.Linq.Grouping`2<U,T> System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.IsReadOnly;
        public int count;
        public System.Collections.Generic.IEqualityComparer`1<U> comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void GetGroup(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetBucketIndex(){} // RVA: 0x7FFD4E0800D0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Add(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Remove(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.CopyTo(){} // RVA: 0x7FFD4E097970
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class OfType`3 : ValueType
    {
        public U source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class OrderByComparable`2 : Object
    {
        public System.Func`2<Transmtn.DTO.Notifications.Notification,long> <keySelector>P; // 0x10
        public ZLinq.Linq.IOrderByComparable`1<Transmtn.DTO.Notifications.Notification> <parent>P; // 0x18
        public bool <descending>P; // 0x20
        public System.Collections.Generic.IComparer`1<long> comparer; // 0x28

        // ── Methods ──
        public void .ctor(){}
        public void GetComparer(){} // RVA: 0x7FFD4E2ADC40
    }

    public class OrderByComparer`2 : Object
    {
        public long[] keys; // 0x10
        public System.Collections.Generic.IComparer`1<long> comparer; // 0x18
        public 0x665C5B70 childComparer; // 0x20
        public bool descending; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Compare(){} // RVA: 0x7FFD4E080290
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void InitBuffer(){} // RVA: 0x7FFD4E090980
        public void Sort(){} // RVA: 0x7FFD4E2ADC40
    }

    public class OrderBy`3 : ValueType
    {
        public System.Func`2<Transmtn.DTO.Notifications.Notification,long> <keySelector>P; // 0x10
        public System.Collections.Generic.IComparer`1<long> <comparer>P; // 0x18
        public ZLinq.Linq.IOrderByComparable`1<Transmtn.DTO.Notifications.Notification> <parent>P; // 0x20
        public bool <descending>P; // 0x28
        public ZLinq.Linq.FromList`1<Transmtn.DTO.Notifications.Notification> source; // 0x30
        public ZLinq.Linq.OrderByComparable`2<Transmtn.DTO.Notifications.Notification,long> comparable; // 0x40
        public ZLinq.Internal.RentedArrayBox`1<Transmtn.DTO.Notifications.Notification> buffer; // 0x48
        public int index; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void InitBuffer(){} // RVA: 0x7FFD4E090980
        public void Sort(){} // RVA: 0x7FFD4E2ADC40
        public void ThenBy(){} // RVA: 0x7FFD4E2ADC40
        public void IsAllowDirectSort(){} // RVA: 0x7FFD4E079D00
    }

    public class Prepend`2 : ValueType
    {
        public U <element>P;
        public U source;
        public byte state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class RangeSelect`1 : ValueType
    {
        public int count;
        public int start;
        public int to;
        public int value;
        public System.Func`2<int,U> selector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Reverse`2 : ValueType
    {
        public ZLinq.Linq.ListWhere`1<ÏÏÌÎÍÎÏÌÎÍÌÌÎÌÏÍÏÏÍÎÏÎÌ> source; // 0x10
        public ZLinq.Internal.RentedArrayBox`1<ÏÏÌÎÍÎÏÌÎÍÌÌÎÌÏÍÏÏÍÎÏÎÌ> buffer; // 0x28
        public int index; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void InitBuffer(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Select2`3 : ValueType
    {
        public System.Func`3<V,int,T> <selector>P;
        public U source;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class SelectMany2`3 : ValueType
    {
        public System.Func`3<V,int,System.Collections.Generic.IEnumerable`1<U>> <selector>P;
        public U source;
        public ZLinq.Linq.FromEnumerable`1<U> innerEnumerator;
        public bool hasInner;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class SelectMany2`4 : ValueType
    {
        public System.Func`3<W,int,ZLinq.ValueEnumerable`2<V,T>> <selector>P;
        public V source;
        public V innerEnumerator;
        public bool hasInner;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class SelectMany`3 : ValueType
    {
        public System.Func`2<System.Collections.Generic.SortedSet`1<Transmtn.DTO.Notifications.Notification>,System.Collections.Generic.IEnumerable`1<Transmtn.DTO.Notifications.Notification>> <selector>P; // 0x10
        public ZLinq.Linq.FromEnumerable`1<System.Collections.Generic.SortedSet`1<Transmtn.DTO.Notifications.Notification>> source; // 0x18
        public ZLinq.Linq.FromEnumerable`1<Transmtn.DTO.Notifications.Notification> innerEnumerator; // 0x30
        public bool hasInner; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class SelectMany`4 : ValueType
    {
        public System.Func`2<W,ZLinq.ValueEnumerable`2<V,U>> <selector>P;
        public V source;
        public V innerEnumerator;
        public bool hasInner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class SelectWhere`3 : ValueType
    {
        public System.Func`2<LoadingInfoData,float> <selector>P; // 0x10
        public System.Func`2<float,bool> <predicate>P; // 0x18
        public ZLinq.Linq.FromList`1<LoadingInfoData> source; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Select`3 : ValueType
    {
        public ZLinq.Linq.FromList`1<LoadingInfoData> source; // 0x10
        public System.Func`2<LoadingInfoData,float> selector; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Where(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Shuffle`2 : ValueType
    {
        public U source;
        public ZLinq.Internal.RentedArrayBox`1<U> buffer;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void InitBuffer(){} // RVA: 0x7FFD4E090980
    }

    public class SkipLast`2 : ValueType
    {
        public U source;
        public int skipCount;
        public ZLinq.Internal.RefBox`1<ZLinq.Internal.ValueQueue`1<U>> buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class SkipWhile2`2 : ValueType
    {
        public System.Func`3<U,int,bool> <predicate>P;
        public U source;
        public bool skippingDone;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class SkipWhile`2 : ValueType
    {
        public System.Func`2<U,bool> <predicate>P;
        public U source;
        public bool skippingDone;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Skip`2 : ValueType
    {
        public ZLinq.Linq.ListWhere`1<ÌÌÍÏÏÎÎÏÎÍÍÌÍÌÍÏÌÎÏÏÍÏÏ> source; // 0x10
        public int skipCount; // 0x28
        public int skipped; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class TakeLast`2 : ValueType
    {
        public U source;
        public int takeCount;
        public ZLinq.Internal.RefBox`1<ZLinq.Internal.ValueQueue`1<U>> q;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Init(){} // RVA: 0x7FFD4E090980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class TakeWhile2`2 : ValueType
    {
        public System.Func`3<U,int,bool> <predicate>P;
        public U source;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class TakeWhile`2 : ValueType
    {
        public System.Func`2<U,bool> <predicate>P;
        public U source;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Take`2 : ValueType
    {
        public U source;
        public int takeCount;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
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
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Union`3 : ValueType
    {
        public System.Collections.Generic.IEqualityComparer`1<T> <comparer>P;
        public V source;
        public V second;
        public ZLinq.Internal.HashSetSlim`1<T> set;
        public byte state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Where2`2 : ValueType
    {
        public System.Func`3<U,int,bool> <predicate>P;
        public U source;
        public int index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class WhereSelect`3 : ValueType
    {
        public System.Func`2<ÍÍÎÎÍÍÍÍÏÍÍÏÎÏÍÏÏÏÏÏÏÏÎ,bool> Predicate; // 0x10
        public System.Func`2<ÍÍÎÎÍÍÍÍÏÍÍÏÎÏÍÏÏÏÏÏÏÏÎ,string> Selector; // 0x18
        public ZLinq.Linq.FromEnumerable`1<ÍÍÎÎÍÍÍÍÏÍÍÏÎÏÍÏÏÏÏÏÏÏÎ> source; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetSource(){} // RVA: 0x7FFD4E2ADC40
        public void get_Predicate(){} // RVA: 0x7FFD4E078E90
        public void get_Selector(){} // RVA: 0x7FFD4E078E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Where`2 : ValueType
    {
        public System.Func`2<Transmtn.DTO.Notifications.Notification,bool> Predicate; // 0x10
        public ZLinq.Linq.SelectMany`3<ZLinq.Linq.FromEnumerable`1<System.Collections.Generic.SortedSet`1<Transmtn.DTO.Notifications.Notification>>,System.Collections.Generic.SortedSet`1<Transmtn.DTO.Notifications.Notification>,Transmtn.DTO.Notifications.Notification> source; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetSource(){} // RVA: 0x7FFD4E2ADC40
        public void get_Predicate(){} // RVA: 0x7FFD4E078E90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Select(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Zip`4 : ValueType
    {
        public V source;
        public V second;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Zip`5 : ValueType
    {
        public System.Func`3<W,T4,T> <resultSelector>P;
        public V source;
        public V second;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class Zip`6 : ValueType
    {
        public T source;
        public W second;
        public W third;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

}