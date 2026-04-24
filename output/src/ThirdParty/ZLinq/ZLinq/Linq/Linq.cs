// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq.Linq
// Classes: 86
// Methods: 540

namespace ThirdParty.ZLinq.ZLinq.Linq
{
    public class <OrderBy>F20F22F0783C758479CC59FC23C7FEAF81F289B10B31CBE866E87C24F818E06F4__DescendingDefaultComparer`1 : Object
    {
        public URA.ndar_data<T1717717888> Default;

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
        public n<T1717717856,T1717717872> Identity;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class AggregateBy2`4 : ValueType
    {
        public n<T1717716256,T1717716272> <keySelector>P;
        public n<T1717716272,T1717716288> <seedSelector>P;
        public nalInformation<T1717716288,T1717716256,T1717716288> <func>P;
        public URA.hEraNames<T1717716272> <keyComparer>P;
        public T1717716240 source;
        public ics.ManagedTypes.intBase<T1717716272,T1717716288> dictionary;
        public eDeviceInformation<T1717716272,T1717716288> enumerator;

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
        public n<T1717716192,T1717716208> <keySelector>P;
        public T1717716224 <seed>P;
        public nalInformation<T1717716224,T1717716192,T1717716224> <func>P;
        public URA.hEraNames<T1717716208> <keyComparer>P;
        public T1717716176 source;
        public ics.ManagedTypes.intBase<T1717716208,T1717716224> dictionary;
        public eDeviceInformation<T1717716208,T1717716224> enumerator;

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
        public T1717716320 <element>P;
        public T1717716304 source;
        public byte state;

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
        public RC.Dynamics.PhysBoneManager.Grab>.Current.RootDefinition<ÏÍÎÌÏÎÍÏÌÍÍÍÍÎÍÌÌÌÏÎÏ> Instance;

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
        public T1717718240[] source;
        public n<T1717718240,T1717718256> selector;
        public int index;

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
        public n<T1717719680,bool> Predicate;
        public n<T1717719680,T1717719696> Selector;
        public int index;
        public T1717719680[] source;

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
        public n<T1717719664,bool> Predicate;
        public T1717719664[] source;
        public int index;

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
        public RC.Dynamics.PhysBoneManager.Grab>.Current.RequiredHideFlags<object> source; // 0x10

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
        public T1717716544 source;
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
        public T1717716576 first;
        public T1717716592 second;
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
        public n<T1717716640,T1717716656> <keySelector>P;
        public URA.hEraNames<T1717716656> <keyComparer>P;
        public T1717716624 source;
        public ics.ManagedTypes.intBase<T1717716656,int> dictionary;
        public eDeviceInformation<T1717716656,int> enumerator;

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
        public T1717716688 <defaultValue>P;
        public T1717716672 source;
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
        public n<T1717716752,T1717716768> <keySelector>P;
        public URA.hEraNames<T1717716768> <comparer>P;
        public T1717716736 source;
        public ics.ManagedTypes.?<T1717716768> set;

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
        public URA.hEraNames<T1717716720> <comparer>P;
        public T1717716704 source;
        public ics.ManagedTypes.?<T1717716720> set;

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
        public RC.Dynamics.PhysBoneManager.Grab>.Current.eFixedTime<ÏÍÎÌÏÎÍÏÌÍÍÍÍÎÍÌÌÌÏÎÏ> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E07D200
        public void TryGetNext(){} // RVA: 0x7FFD4E07D200
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void <TryGetNext>g__Initialize|3_0(){} // RVA: 0x7FFD4E078F80
    }

    public class ExceptBy`4 : ValueType
    {
        public n<T1717716864,T1717716880> <keySelector>P;
        public URA.hEraNames<T1717716880> <comparer>P;
        public T1717716832 source;
        public _MARGIN..PhysBoneManager.Chainchain)>.Current<T1717716848,T1717716880> second;
        public ics.ManagedTypes.?<T1717716880> set;

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
        public URA.hEraNames<T1717716816> <comparer>P;
        public T1717716784 source;
        public _MARGIN..PhysBoneManager.Chainchain)>.Current<T1717716800,T1717716816> second;
        public ics.ManagedTypes.?<T1717716816> set;

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
        public T1717716448[] <source>P;
        public int index;

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
        public RC.Dynamics.PhysBoneManager.Grab>.Current.ng<ÏÍÎÌÏÎÍÏÌÍÍÍÍÎÍÌÌÌÏÎÏ> iterator; // 0x10
        public RC.Dynamics.PhysBoneManager.Grab>.Current.Timing content; // 0x18

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
        public URA.woDigitYearMax<T1717716480> <source>P;
        public int index;

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
        public oRegistry<eObjectDelegate.kingField<E<?,ÌÌÌÏÎÌÌÏÎÍÌÌÍÏÌÍÎÎÌÏÍ,int>>> <source>P; // 0x10
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
        public n<T1717716960,T1717716976> <keySelector>P;
        public n<T1717716960,T1717716992> <elementSelector>P;
        public URA.hEraNames<T1717716976> <comparer>P;
        public T1717716944 source;
        public bool init;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717716976,T1717716992> rootGrouping;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717716976,T1717716992> currentGrouping;

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
        public n<T1717717024,T1717717040> <keySelector>P;
        public nalInformation<T1717717040,URA.bbrevEraNames<T1717717024>,T1717717056> <resultSelector>P;
        public URA.hEraNames<T1717717040> <comparer>P;
        public T1717717008 source;
        public bool init;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717717040,T1717717024> rootGrouping;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717717040,T1717717024> currentGrouping;

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
        public n<T1717717088,T1717717104> <keySelector>P;
        public n<T1717717088,T1717717120> <elementSelector>P;
        public nalInformation<T1717717104,URA.bbrevEraNames<T1717717120>,T1717717136> <resultSelector>P;
        public URA.hEraNames<T1717717104> <comparer>P;
        public T1717717072 source;
        public bool init;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717717104,T1717717120> rootGrouping;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717717104,T1717717120> currentGrouping;

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
        public n<T1717716912,T1717716928> <keySelector>P;
        public URA.hEraNames<T1717716928> <comparer>P;
        public T1717716896 source;
        public bool init;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717716928,T1717716912> rootGrouping;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717716928,T1717716912> currentGrouping;

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
        public n<T1717717184,T1717717216> <outerKeySelector>P;
        public n<T1717717200,T1717717216> <innerKeySelector>P;
        public nalInformation<T1717717184,URA.bbrevEraNames<T1717717200>,T1717717232> <resultSelector>P;
        public URA.hEraNames<T1717717216> <comparer>P;
        public T1717717152 source;
        public T1717717168 inner;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.m<T1717717216,T1717717200> innerLookup;

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
        public T1717719312 Key;
        public uint HashCode;
        public T1717719328[] Count;
        public int IsReadOnly;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717719312,T1717719328> Item;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717719312,T1717719328> NextGroupInSameHashCode;

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
        public RC.Dynamics.PhysBoneManager.Grab>.Current.et_AutoEvaluateFixedTime<ÏÍÎÌÏÎÍÏÌÍÍÍÍÎÍÌÌÌÏÎÏ> Instance;

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
        public RC.Dynamics.PhysBoneManager.Grab>.Current.ixedTime<ÏÍÎÌÏÎÍÏÌÍÍÍÍÎÍÌÌÌÏÎÏ> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E07D200
        public void TryGetNext(){} // RVA: 0x7FFD4E07D200
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class Index`2 : ValueType
    {
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
        public n<T1717717360,T1717717376> <keySelector>P;
        public URA.hEraNames<T1717717376> <comparer>P;
        public T1717717328 source;
        public _MARGIN..PhysBoneManager.Chainchain)>.Current<T1717717344,T1717717376> second;
        public ics.ManagedTypes.?<T1717717376> set;

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
        public URA.hEraNames<T1717717312> <comparer>P;
        public T1717717280 source;
        public _MARGIN..PhysBoneManager.Chainchain)>.Current<T1717717296,T1717717312> second;
        public ics.ManagedTypes.?<T1717717312> set;

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
        public n<T1717717424,T1717717456> <outerKeySelector>P;
        public n<T1717717440,T1717717456> <innerKeySelector>P;
        public nalInformation<T1717717424,T1717717440,T1717717472> <resultSelector>P;
        public URA.hEraNames<T1717717456> <comparer>P;
        public T1717717392 source;
        public T1717717408 inner;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.m<T1717717456,T1717717440> innerLookup;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717717456,T1717717440> currentGroup;
        public int currentGroupIndex;
        public T1717717424 currentOuter;

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
        public n<T1717717520,T1717717552> <outerKeySelector>P;
        public n<T1717717536,T1717717552> <innerKeySelector>P;
        public nalInformation<T1717717520,T1717717536,T1717717568> <resultSelector>P;
        public URA.hEraNames<T1717717552> <comparer>P;
        public T1717717488 source;
        public T1717717504 inner;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.m<T1717717552,T1717717536> innerLookup;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717717552,T1717717536> currentGroup;
        public int currentGroupIndex;
        public T1717717520 currentOuter;

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
        public RC.Dynamics.PhysBoneManager.Grab>.Current._NameAsString<ÏÍÎÌÏÎÍÏÌÍÍÍÍÎÍÌÌÌÏÎÏ> Instance;

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
        public URA.woDigitYearMax<T1717718272> source;
        public n<T1717718272,T1717718288> selector;
        public int index;

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
        public n<T1717719744,bool> <predicate>P;
        public n<T1717719744,T1717719760> <selector>P;
        public int index;
        public URA.woDigitYearMax<T1717719744> source;

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
        public n<ÎÌÌÎÍÎÏÏÏÏÍÍÏ,bool> Predicate; // 0x10
        public URA.woDigitYearMax<ÎÌÌÎÍÎÏÏÏÏÍÍÏ> source; // 0x18
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
        public URA.hEraNames<T1717719184> comparer;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717719184,T1717719200>[] buckets;
        public int bucketsLength;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717719184,T1717719200> last;
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
        public RC.Dynamics.PhysBoneManager.Grab>.Current.m<T1717719248,T1717719264> Item;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717719248,T1717719264>[] Count;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717719248,T1717719264> System.Collections.Generic.ICollection<System.Linq.IGrouping<TKey,TElement>>.IsReadOnly;
        public int count;
        public URA.hEraNames<T1717719248> comparer;

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
        public T1717717584 source;

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
        public n<T1717717760,T1717717776> <keySelector>P;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.wed<T1717717760> <parent>P;
        public bool <descending>P;
        public URA.ndar_data<T1717717776> comparer;

        // ── Methods ──
        public void .ctor(){}
        public void GetComparer(){} // RVA: 0x7FFD4E2ADC40
    }

    public class OrderByComparer`2 : Object
    {
        public T1717717808[] keys;
        public URA.ndar_data<T1717717808> comparer;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.d childComparer;
        public bool descending;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Compare(){} // RVA: 0x7FFD4E080290
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class OrderBySkipTake`3 : ValueType
    {
        public T1717717696 source;
        public RC.Dynamics.PhysBoneManager.Grab>.Current._Angle<T1717717712,T1717717728> comparable;
        public int minIndexInclusive;
        public int maxIndexInclusive;
        public ics.ManagedTypes.leConstraintBase<T1717717712> buffer;
        public ics.ManagedTypes.leConstraintBase<int> indexMap;
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
        public n<T1717717664,T1717717680> <keySelector>P;
        public URA.ndar_data<T1717717680> <comparer>P;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.wed<T1717717664> <parent>P;
        public bool <descending>P;
        public T1717717648 source;
        public RC.Dynamics.PhysBoneManager.Grab>.Current._Angle<T1717717664,T1717717680> comparable;
        public ics.ManagedTypes.leConstraintBase<T1717717664> buffer;
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
        public void ThenBy(){} // RVA: 0x7FFD4E2ADC40
        public void IsAllowDirectSort(){} // RVA: 0x7FFD4E079D00
    }

    public class Prepend`2 : ValueType
    {
        public T1717717936 <element>P;
        public T1717717920 source;
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
        public n<int,T1717718176> selector;

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
        public T1717717952 source;
        public ics.ManagedTypes.leConstraintBase<T1717717968> buffer;
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

    public class RightJoin`6 : ValueType
    {
        public n<T1717718016,T1717718048> <outerKeySelector>P;
        public n<T1717718032,T1717718048> <innerKeySelector>P;
        public nalInformation<T1717718016,T1717718032,T1717718064> <resultSelector>P;
        public URA.hEraNames<T1717718048> <comparer>P;
        public T1717717984 source;
        public T1717718000 inner;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.m<T1717718048,T1717718016> outerLookup;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.6G16B16_SInt<T1717718048,T1717718016> currentGroup;
        public int currentGroupIndex;
        public T1717718032 currentInner;

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
        public nalInformation<T1717718144,int,T1717718160> <selector>P;
        public T1717718128 source;
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
        public nalInformation<T1717718656,int,URA.bbrevEraNames<T1717718672>> <selector>P;
        public T1717718640 source;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.RequiredHideFlags<T1717718672> innerEnumerator;
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
        public nalInformation<T1717718384,int,_MARGIN..PhysBoneManager.Chainchain)>.Current<T1717718368,T1717718400>> <selector>P;
        public T1717718352 source;
        public T1717718368 innerEnumerator;
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
        public n<T1717718704,URA.bbrevEraNames<T1717718720>> <collectionSelector>P;
        public nalInformation<T1717718704,T1717718720,T1717718736> <resultSelector>P;
        public T1717718688 source;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.RequiredHideFlags<T1717718720> innerEnumerator;
        public T1717718704 currentSource;
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
        public n<T1717718448,_MARGIN..PhysBoneManager.Chainchain)>.Current<T1717718432,T1717718464>> <collectionSelector>P;
        public nalInformation<T1717718448,T1717718464,T1717718480> <resultSelector>P;
        public T1717718416 source;
        public T1717718432 innerEnumerator;
        public T1717718448 currentSource;
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
        public nalInformation<T1717718768,int,URA.bbrevEraNames<T1717718784>> <collectionSelector>P;
        public nalInformation<T1717718768,T1717718784,T1717718800> <resultSelector>P;
        public T1717718752 source;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.RequiredHideFlags<T1717718784> innerEnumerator;
        public T1717718768 currentSource;
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
        public nalInformation<T1717718528,int,_MARGIN..PhysBoneManager.Chainchain)>.Current<T1717718512,T1717718544>> <collectionSelector>P;
        public nalInformation<T1717718528,T1717718544,T1717718560> <resultSelector>P;
        public T1717718496 source;
        public T1717718512 innerEnumerator;
        public T1717718528 currentSource;
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
        public n<T1717718320,URA.bbrevEraNames<T1717718336>> <selector>P;
        public T1717718304 source;
        public RC.Dynamics.PhysBoneManager.Grab>.Current.RequiredHideFlags<T1717718336> innerEnumerator;
        public bool hasInner;

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
        public n<T1717718608,_MARGIN..PhysBoneManager.Chainchain)>.Current<T1717718592,T1717718624>> <selector>P;
        public T1717718576 source;
        public T1717718592 innerEnumerator;
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
        public n<T1717718208,T1717718224> <selector>P;
        public n<T1717718224,bool> <predicate>P;
        public T1717718192 source;

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
        public T1717718080 source;
        public n<T1717718096,T1717718112> selector;

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
        public T1717718816 source;
        public ics.ManagedTypes.leConstraintBase<T1717718832> buffer;
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
        public T1717718880 source;
        public int skipCount;
        public ics.ManagedTypes.ConstraintBase<ics.ManagedTypes.BurstDirectCallInitializer<T1717718896>> buffer;

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
        public nalInformation<T1717718960,int,bool> <predicate>P;
        public T1717718944 source;
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
        public n<T1717718928,bool> <predicate>P;
        public T1717718912 source;
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
        public RC.Dynamics.PhysBoneManager.Grab>.Current.GlobalCollider<ÎÌÌÎÍÎÏÏÏÏÍÍÏ> source; // 0x10
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
        public T1717719040 source;
        public int takeCount;
        public ics.ManagedTypes.ConstraintBase<ics.ManagedTypes.BurstDirectCallInitializer<T1717719056>> q;

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
        public T1717719008 source;
        public HeadAnimatorForExport range;
        public int index;
        public int remains;
        public int skipIndex;
        public int fromEndQueueCount;
        public ics.ManagedTypes.ConstraintBase<ics.ManagedTypes.BurstDirectCallInitializer<T1717719024>> q;
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
        public nalInformation<T1717719120,int,bool> <predicate>P;
        public T1717719104 source;
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
        public n<T1717719088,bool> <predicate>P;
        public T1717719072 source;

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
        public T1717718976 source;
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
        public n<T1717719488,T1717719504> <keySelector>P;
        public URA.hEraNames<T1717719504> <comparer>P;
        public T1717719456 source;
        public T1717719472 second;
        public ics.ManagedTypes.?<T1717719504> set;
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
        public URA.hEraNames<T1717719440> <comparer>P;
        public T1717719408 source;
        public T1717719424 second;
        public ics.ManagedTypes.?<T1717719440> set;
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
        public nalInformation<T1717719584,int,bool> <predicate>P;
        public T1717719568 source;
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
        public object Predicate;
        public object Selector;

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
        public n<T1717719552,bool> Predicate;
        public T1717719536 source;

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
        public T1717719776 source;
        public T1717719792 second;

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
        public nalInformation<T1717719968,T1717719984,T1717720000> <resultSelector>P;
        public T1717719936 source;
        public T1717719952 second;

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
        public T1717719840 source;
        public T1717719856 second;
        public T1717719872 third;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNonEnumeratedCount(){} // RVA: 0x7FFD4E079F60
        public void TryGetSpan(){} // RVA: 0x7FFD4E079F60
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNext(){} // RVA: 0x7FFD4E079F60
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

}