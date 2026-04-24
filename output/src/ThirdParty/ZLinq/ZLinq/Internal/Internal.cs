// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq.Internal
// Classes: 14
// Methods: 73

namespace ThirdParty.ZLinq.ZLinq.Internal
{
    public class DefaultInterpolatedStringHandler : ValueType
    {
        public nalGetValue _provider; // 0x10
        public char[] _arrayToReturnToPool; // 0x18
        public HaveRegistry<char> _chars; // 0x20
        public int _pos; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57501E60
        public void AppendFormatted(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToStringAndClear(){} // RVA: 0x7FFD57501FA0
        public void Clear(){} // RVA: 0x7FFD57502100
        public void GrowThenCopyString(){} // RVA: 0x7FFD575021B0
        public void Grow(){} // RVA: 0x7FFD575022F0 | overloaded x2
        public void GrowCore(){} // RVA: 0x7FFD57502300
        public void MathClamp(){} // RVA: 0x7FFD575025F0
        public void ThrowMinMaxException(){} // RVA: 0x7FFD4E2ADC40
    }

    public class DictionarySlim`2 : Object
    {
        public URA.hEraNames<T1717720080> comparer;
        public ?<T1717720080,T1717720096>[] entries;
        public int[] buckets;
        public int bucketsLength;
        public int entryIndex;
        public int resizeThreshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetValueRefOrAddDefault(){} // RVA: 0x7FFD4E2ADC40
        public void Resize(){} // RVA: 0x7FFD4E090980
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E2ADC40
        public void GetBucketIndex(){} // RVA: 0x7FFD4E0800D0
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class EnumeratorHelper : Object
    {
        // ── Methods ──
        public void TryGetSliceRange(){} // RVA: 0x7FFD57501DC0
        public void TryGetSlice(){} // RVA: 0x7FFD4E2ADC40
        public void TryConsumeGetAt(){} // RVA: 0x7FFD4E07CD30 | overloaded x2
        public void TryConsumeGetFirst(){} // RVA: 0x7FFD4E07A350
        public void TryConsumeGetLast(){} // RVA: 0x7FFD4E07A350
        public void TryConsumeGetFromLast(){} // RVA: 0x7FFD4E07CD30
    }

    public class HashSetSlim`1 : Object
    {
        public URA.hEraNames<T1717720304> comparer;
        public ?<T1717720304>[] entries;
        public int[] buckets;
        public int bucketsLength;
        public int entryIndex;
        public int resizeThreshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092BC0 | overloaded x2
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Resize(){} // RVA: 0x7FFD4E090980
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E2ADC40
        public void GetBucketIndex(){} // RVA: 0x7FFD4E0800D0
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class InlineArray16`1 : ValueType
    {
        public T1717720432 item0;
        public T1717720432 item1;
        public T1717720432 item2;
        public T1717720432 item3;
        public T1717720432 item4;
        public T1717720432 item5;
        public T1717720432 item6;
        public T1717720432 item7;
        public T1717720432 item8;
        public T1717720432 item9;
        public T1717720432 item10;
        public T1717720432 item11;
        public T1717720432 item12;
        public T1717720432 item13;
        public T1717720432 item14;
        public T1717720432 item15;

        // ── Methods ──
        public void AsSpan(){} // RVA: 0x7FFD4E2ADC40
    }

    public class InlineArray27`1 : ValueType
    {
        public T1717720448 Item;
        public T1717720448 item1;
        public T1717720448 item2;
        public T1717720448 item3;
        public T1717720448 item4;
        public T1717720448 item5;
        public T1717720448 item6;
        public T1717720448 item7;
        public T1717720448 item8;
        public T1717720448 item9;
        public T1717720448 item10;
        public T1717720448 item11;
        public T1717720448 item12;
        public T1717720448 item13;
        public T1717720448 item14;
        public T1717720448 item15;
        public T1717720448 item16;
        public T1717720448 item17;
        public T1717720448 item18;
        public T1717720448 item19;
        public T1717720448 item20;
        public T1717720448 item21;
        public T1717720448 item22;
        public T1717720448 item23;
        public T1717720448 item24;
        public T1717720448 item25;
        public T1717720448 item26;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD4E087DE0
        public void AsSpan(){} // RVA: 0x7FFD4E2ADC40
    }

    public class InlineArrayMarshal : Object
    {
        // ── Methods ──
        public void AsSpan(){} // RVA: 0x7FFD4E2ADC40
        public void ElementRef(){} // RVA: 0x7FFD4E088090
    }

    public class RandomShared : Object
    {
        public sageKind._id<?> Shared;

        // ── Methods ──
        public void Shuffle(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD57502670
    }

    public class RefBox`1 : Object
    {
        public T1717720384 value;
        public bool isDisposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetValueRef(){} // RVA: 0x7FFD4E078E90
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class RentedArrayBox`1 : Object
    {
        public T1717720400[] Length;
        public int Span;
        public ics.ManagedTypes.leConstraintBase<T1717720400> Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_Span(){} // RVA: 0x7FFD4E2ADC40
        public void UnsafeGetAt(){} // RVA: 0x7FFD4E087DE0
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class SegmentedArrayProvider`1 : ValueType
    {
        public HaveRegistry<T1717720416> Count;
        public int countInCurrentSegment;
        public HaveRegistry<T1717720416> initialBuffer;
        public ics.ManagedTypes.A8AA6C8FF033EEE4803350ED422AA23E2B48009BA39CC9988B38F<T1717720416[]> segments;
        public int segmentsCount;
        public int countInFinishedSegments;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetSpan(){} // RVA: 0x7FFD4E2ADC40
        public void Advance(){} // RVA: 0x7FFD4E090ED0
        public void Expand(){} // RVA: 0x7FFD4E090980
        public void CopyToAndClear(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SingleSpan : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Throws : Object
    {
        // ── Methods ──
        public void ArgumentOutOfRange(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void MoreThanOneElement(){} // RVA: 0x7FFD57502BF0
        public void MoreThanOneMatch(){} // RVA: 0x7FFD57502C40
        public void NoElements(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void NoMatch(){} // RVA: 0x7FFD4E2ADC40
        public void NotSupportedType(){} // RVA: 0x7FFD57502CE0
        public void IfNull(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ValueQueue`1 : ValueType
    {
        public T1717720608[] Count;
        public int head;
        public int tail;
        public int size;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void Enqueue(){} // RVA: 0x7FFD4E2ADC40
        public void Dequeue(){} // RVA: 0x7FFD4E2ADC40
        public void Throw(){} // RVA: 0x7FFD4E0909B0
        public void Grow(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

}