// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq.Linq
// Classes: 89
// Methods: 540

namespace ThirdParty.ZLinq.ZLinq.Linq
{
    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__DescendingDefaultComparer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Compare(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__OrderByHelper : Object
    {
        // ── Methods ──
        public void TypeIsImplicitlyStable(){} // RVA: 0x7FFE80E2F180
        public void QuickSelect(){} // RVA: 0x7FFE8A547310
        public void PartialQuickSort(){} // RVA: 0x7FFE8A5475C0
        public void Min(){} // RVA: 0x7FFE8A5478B0
        public void Max(){} // RVA: 0x7FFE8A547A20
    }

    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__UnsafeFunctions`2 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class AggregateBy2`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Initialize(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class AggregateBy`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Initialize(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Append`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class ArrayIterator`1 : CollectionIterator`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E32650
        public void TryGetSpan(){} // RVA: 0x7FFE80E32650
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E32650
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ArraySelect`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class ArrayWhereSelect`2 : ValueType
    {
        public System.Func`2<U,bool> <predicate>P;
        public System.Func`2<U,T> <selector>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E50660
        public void GetSource(){} // RVA: 0x7FFE80E2E2E0
        public void get_Predicate(){} // RVA: 0x7FFE80E2E2E0
        public void get_Selector(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class ArrayWhere`1 : ValueType
    {
        public System.Func`2<T,bool> <predicate>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetSource(){} // RVA: 0x7FFE80E2E2E0
        public void get_Predicate(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Select(){} // RVA: 0x7FFE810A1420
    }

    public class Cast`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Chunk`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class CollectionIterator`1 : Object
    {
        // ── Methods ──
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E32650
        public void TryGetSpan(){} // RVA: 0x7FFE86226A70
        public void TryCopyTo(){} // RVA: 0x7FFE810FB320
        public void TryGetNext(){} // RVA: 0x7FFE80E32650
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Concat`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class CountBy`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Initialize(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class DefaultIfEmpty`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class DistinctBy`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Distinct`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class EnumerableIterator`1 : CollectionIterator`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E32650
        public void TryGetNext(){} // RVA: 0x7FFE80E32650
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void <TryGetNext>g__Initialize|3_0(){} // RVA: 0x7FFE80E2E3D0
    }

    public class ExceptBy`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Except`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class FromArray`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetSource(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class FromEnumerableContent : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FA6E60
        public void ThrowIfNoEnumerable(){} // RVA: 0x7FFE8A5472A0
        public void <ThrowIfNoEnumerable>g__Throw|3_0(){} // RVA: 0x7FFE8A5472C0
    }

    public class FromEnumerable`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetSource(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class FromList`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetSource(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class FromMemory`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class FromRange : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A547B90
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE84AB8630
        public void TryGetSpan(){} // RVA: 0x7FFE836DC760
        public void TryCopyTo(){} // RVA: 0x7FFE8A547BB0
        public void TryGetNext(){} // RVA: 0x7FFE8A547D00
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void FillIncremental(){} // RVA: 0x7FFE8A547D20
    }

    public class GroupBy2`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void BuildRoot(){} // RVA: 0x7FFE80E2E2E0
    }

    public class GroupBy3`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void BuildRoot(){} // RVA: 0x7FFE80E2E2E0
    }

    public class GroupBy4`5 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void BuildRoot(){} // RVA: 0x7FFE80E2E2E0
    }

    public class GroupBy`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void BuildRoot(){} // RVA: 0x7FFE80E2E2E0
    }

    public class GroupJoin`6 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class GroupingDebugView`2 : Object
    {
    }

    public class Grouping`2 : Object
    {
        public U key;
        public uint hashCode;
        public T[] elements;
        public int count;
        public ZLinq.Linq.Grouping`2<U,T> NextGroupInAddOrder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_Key(){} // RVA: 0x7FFE810A1420
        public void get_HashCode(){} // RVA: 0x7FFE80E2EDB0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Remove(){} // RVA: 0x7FFE810A1420
    }

    public class IListIterator`1 : CollectionIterator`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E32650
        public void TryGetNext(){} // RVA: 0x7FFE80E32650
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class IOrderByComparable`1
    {
        // ── Methods ──
        public void GetComparer(){} // RVA: 0x7FFE810A1420
    }

    public class IOrderByComparer
    {
    }

    public class IReadOnlyListIterator`1 : CollectionIterator`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E32650
        public void TryGetNext(){} // RVA: 0x7FFE80E32650
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class Index`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class IntersectBy`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Intersect`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Join`6 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class LeftJoin`6 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class ListIterator`1 : CollectionIterator`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E32650
        public void TryGetSpan(){} // RVA: 0x7FFE80E32650
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E32650
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ListSelect`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class ListWhereSelect`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E50660
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class ListWhere`1 : ValueType
    {
        public System.Func`2<T,bool> <predicate>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetSource(){} // RVA: 0x7FFE80E2E2E0
        public void get_Predicate(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Select(){} // RVA: 0x7FFE810A1420
    }

    public class Lookup : Object
    {
        // ── Methods ──
        public void CreateForJoin(){} // RVA: 0x7FFE80E3EAC0
    }

    public class LookupBuilder`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetBucketIndex(){} // RVA: 0x7FFE80E35520
        public void InternalGetHashCode(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420
        public void BuildAndClear(){} // RVA: 0x7FFE80E2E2E0
        public void GetRootGroupAndClear(){} // RVA: 0x7FFE80E2E2E0
        public void ResizeAndRehash(){} // RVA: 0x7FFE80E45FE0
    }

    public class LookupDebugView`2 : Object
    {
    }

    public class Lookup`2 : Object
    {
        public ZLinq.Linq.Lookup`2<U,T> Empty;
        public ZLinq.Linq.Grouping`2<U,T>[] groups;
        public ZLinq.Linq.Grouping`2<U,T> last;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void GetGroup(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void GetBucketIndex(){} // RVA: 0x7FFE80E35520
        public void InternalGetHashCode(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Add(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Remove(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class OfType`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class OrderByComparable`2 : Object
    {
        // ── Methods ──
        public void .ctor(){}
        public void GetComparer(){} // RVA: 0x7FFE810A1420
    }

    public class OrderByComparer`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Compare(){} // RVA: 0x7FFE80E356E0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class OrderBySkipTake`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void InitBuffer(){} // RVA: 0x7FFE80E45FE0
        public void Sort(){} // RVA: 0x7FFE810A1420
    }

    public class OrderBy`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void InitBuffer(){} // RVA: 0x7FFE80E45FE0
        public void Sort(){} // RVA: 0x7FFE810A1420
        public void ThenBy(){} // RVA: 0x7FFE810A1420
        public void IsAllowDirectSort(){} // RVA: 0x7FFE80E2F150
    }

    public class Prepend`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class RangeSelect`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Reverse`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void InitBuffer(){} // RVA: 0x7FFE80E45FE0
    }

    public class RightJoin`6 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Select2`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectMany2`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectMany2`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectMany3`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectMany3`5 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectMany4`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectMany4`5 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectMany`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectMany`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelectWhere`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Select`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Where(){} // RVA: 0x7FFE810A1420
    }

    public class Shuffle`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void InitBuffer(){} // RVA: 0x7FFE80E45FE0
    }

    public class SkipLast`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SkipWhile2`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class SkipWhile`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Skip`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class TakeLast`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class TakeRange`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class TakeWhile2`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class TakeWhile`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Take`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class UnionBy`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Union`3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Where2`2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class WhereSelect`3 : ValueType
    {
        public System.Func`2<V,bool> <predicate>P;
        public System.Func`2<V,T> <selector>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetSource(){} // RVA: 0x7FFE810A1420
        public void get_Predicate(){} // RVA: 0x7FFE80E2E2E0
        public void get_Selector(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Where`2 : ValueType
    {
        public System.Func`2<U,bool> <predicate>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetSource(){} // RVA: 0x7FFE810A1420
        public void get_Predicate(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Select(){} // RVA: 0x7FFE810A1420
    }

    public class Zip`4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Zip`5 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class Zip`6 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFE80E2F3B0
        public void TryGetSpan(){} // RVA: 0x7FFE80E2F3B0
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void TryGetNext(){} // RVA: 0x7FFE80E2F3B0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

}