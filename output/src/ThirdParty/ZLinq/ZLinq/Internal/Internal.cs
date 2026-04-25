// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq.Internal
// Classes: 14
// Methods: 73

namespace ThirdParty.ZLinq.ZLinq.Internal
{
    public class DefaultInterpolatedStringHandler : ValueType
    {
        public System.IFormatProvider _provider; // 0x10
        public char[] _arrayToReturnToPool; // 0x18
        public System.Span`1<char> _chars; // 0x20
        public int _pos; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0E1E60
        public void AppendFormatted(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ToStringAndClear(){} // RVA: 0x7FFACC0E1FA0
        public void Clear(){} // RVA: 0x7FFACC0E2100
        public void GrowThenCopyString(){} // RVA: 0x7FFACC0E21B0
        public void Grow(){} // RVA: 0x7FFACC0E22F0 | overloaded x2
        public void GrowCore(){} // RVA: 0x7FFACC0E2300
        public void MathClamp(){} // RVA: 0x7FFACC0E25F0
        public void ThrowMinMaxException(){} // RVA: 0x7FFAC2E8DC40
    }

    public class DictionarySlim`2 : Object
    {
        public System.Collections.Generic.IEqualityComparer`1<U> comparer;
        public Entry<U,T>[] entries;
        public int[] buckets;
        public int bucketsLength;
        public int entryIndex;
        public int resizeThreshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetValueRefOrAddDefault(){} // RVA: 0x7FFAC2E8DC40
        public void Resize(){} // RVA: 0x7FFAC2C70980
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2E8DC40
        public void GetBucketIndex(){} // RVA: 0x7FFAC2C600D0
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class EnumeratorHelper : Object
    {
        // ── Methods ──
        public void TryGetSliceRange(){} // RVA: 0x7FFACC0E1DC0
        public void TryGetSlice(){} // RVA: 0x7FFAC2E8DC40
        public void TryConsumeGetAt(){} // RVA: 0x7FFAC2C5CD30 | overloaded x2
        public void TryConsumeGetFirst(){} // RVA: 0x7FFAC2C5A350
        public void TryConsumeGetLast(){} // RVA: 0x7FFAC2C5A350
        public void TryConsumeGetFromLast(){} // RVA: 0x7FFAC2C5CD30
    }

    public class HashSetSlim`1 : Object
    {
        public System.Collections.Generic.IEqualityComparer`1<T> comparer;
        public Entry<T>[] entries;
        public int[] buckets;
        public int bucketsLength;
        public int entryIndex;
        public int resizeThreshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72BC0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Resize(){} // RVA: 0x7FFAC2C70980
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2E8DC40
        public void GetBucketIndex(){} // RVA: 0x7FFAC2C600D0
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class InlineArray16`1 : ValueType
    {
        public T item0;
        public T item1;
        public T item2;
        public T item3;
        public T item4;
        public T item5;
        public T item6;
        public T item7;
        public T item8;
        public T item9;
        public T item10;
        public T item11;
        public T item12;
        public T item13;
        public T item14;
        public T item15;

        // ── Methods ──
        public void AsSpan(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InlineArray27`1 : ValueType
    {
        public T Item;
        public T item1;
        public T item2;
        public T item3;
        public T item4;
        public T item5;
        public T item6;
        public T item7;
        public T item8;
        public T item9;
        public T item10;
        public T item11;
        public T item12;
        public T item13;
        public T item14;
        public T item15;
        public T item16;
        public T item17;
        public T item18;
        public T item19;
        public T item20;
        public T item21;
        public T item22;
        public T item23;
        public T item24;
        public T item25;
        public T item26;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void AsSpan(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InlineArrayMarshal : Object
    {
        // ── Methods ──
        public void AsSpan(){} // RVA: 0x7FFAC2E8DC40
        public void ElementRef(){} // RVA: 0x7FFAC2C68090
    }

    public class RandomShared : Object
    {
        public System.Threading.ThreadLocal`1<System.Random> Shared;

        // ── Methods ──
        public void Shuffle(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFACC0E2670
    }

    public class RefBox`1 : Object
    {
        public T value;
        public bool isDisposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetValueRef(){} // RVA: 0x7FFAC2C58E90
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class RentedArrayBox`1 : Object
    {
        public T[] Length;
        public int Span;
        public ZLinq.Internal.RentedArrayBox`1<T> Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_Span(){} // RVA: 0x7FFAC2E8DC40
        public void UnsafeGetAt(){} // RVA: 0x7FFAC2C67DE0
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class SegmentedArrayProvider`1 : ValueType
    {
        public System.Span`1<T> Count;
        public int countInCurrentSegment;
        public System.Span`1<T> initialBuffer;
        public ZLinq.Internal.InlineArray27`1<T[]> segments;
        public int segmentsCount;
        public int countInFinishedSegments;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetSpan(){} // RVA: 0x7FFAC2E8DC40
        public void Advance(){} // RVA: 0x7FFAC2C70ED0
        public void Expand(){} // RVA: 0x7FFAC2C70980
        public void CopyToAndClear(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SingleSpan : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Throws : Object
    {
        // ── Methods ──
        public void ArgumentOutOfRange(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void MoreThanOneElement(){} // RVA: 0x7FFACC0E2BF0
        public void MoreThanOneMatch(){} // RVA: 0x7FFACC0E2C40
        public void NoElements(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void NoMatch(){} // RVA: 0x7FFAC2E8DC40
        public void NotSupportedType(){} // RVA: 0x7FFACC0E2CE0
        public void IfNull(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ValueQueue`1 : ValueType
    {
        public T[] Count;
        public int head;
        public int tail;
        public int size;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void Enqueue(){} // RVA: 0x7FFAC2E8DC40
        public void Dequeue(){} // RVA: 0x7FFAC2E8DC40
        public void Throw(){} // RVA: 0x7FFAC2C709B0
        public void Grow(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

}