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
        public System.Collections.Generic.IEqualityComparer`1<U> comparer;
        public 0x665C6E58<U,T>[] entries;
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
        public System.Collections.Generic.IEqualityComparer`1<Transmtn.DTO.Notifications.Notification> comparer; // 0x10
        public 0x665C6FB8<Transmtn.DTO.Notifications.Notification>[] entries; // 0x18
        public int[] buckets; // 0x20
        public int bucketsLength; // 0x28
        public int entryIndex; // 0x2C
        public int resizeThreshold; // 0x30

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
        public System.Collections.Generic.KeyValuePair`2<string,int> item0; // 0x10
        public System.Collections.Generic.KeyValuePair`2<string,int> item1; // 0x20
        public System.Collections.Generic.KeyValuePair`2<string,int> item2; // 0x30
        public System.Collections.Generic.KeyValuePair`2<string,int> item3; // 0x40
        public System.Collections.Generic.KeyValuePair`2<string,int> item4; // 0x50
        public System.Collections.Generic.KeyValuePair`2<string,int> item5; // 0x60
        public System.Collections.Generic.KeyValuePair`2<string,int> item6; // 0x70
        public System.Collections.Generic.KeyValuePair`2<string,int> item7; // 0x80
        public System.Collections.Generic.KeyValuePair`2<string,int> item8; // 0x90
        public System.Collections.Generic.KeyValuePair`2<string,int> item9; // 0xA0
        public System.Collections.Generic.KeyValuePair`2<string,int> item10; // 0xB0
        public System.Collections.Generic.KeyValuePair`2<string,int> item11; // 0xC0
        public System.Collections.Generic.KeyValuePair`2<string,int> item12; // 0xD0
        public System.Collections.Generic.KeyValuePair`2<string,int> item13; // 0xE0
        public System.Collections.Generic.KeyValuePair`2<string,int> item14; // 0xF0
        public System.Collections.Generic.KeyValuePair`2<string,int> item15; // 0x100

        // ── Methods ──
        public void AsSpan(){} // RVA: 0x7FFD4E2ADC40
    }

    public class InlineArray27`1 : ValueType
    {
        public System.Collections.Generic.KeyValuePair`2<string,int>[] Item; // 0x10
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item1; // 0x18
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item2; // 0x20
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item3; // 0x28
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item4; // 0x30
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item5; // 0x38
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item6; // 0x40
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item7; // 0x48
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item8; // 0x50
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item9; // 0x58
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item10; // 0x60
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item11; // 0x68
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item12; // 0x70
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item13; // 0x78
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item14; // 0x80
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item15; // 0x88
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item16; // 0x90
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item17; // 0x98
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item18; // 0xA0
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item19; // 0xA8
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item20; // 0xB0
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item21; // 0xB8
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item22; // 0xC0
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item23; // 0xC8
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item24; // 0xD0
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item25; // 0xD8
        public System.Collections.Generic.KeyValuePair`2<string,int>[] item26; // 0xE0

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
        public System.Threading.ThreadLocal`1<System.Random> Shared;

        // ── Methods ──
        public void Shuffle(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD57502670
    }

    public class RefBox`1 : Object
    {
        public ZLinq.Internal.ValueQueue`1<int> value; // 0x10
        public bool isDisposed; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetValueRef(){} // RVA: 0x7FFD4E078E90
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class RentedArrayBox`1 : Object
    {
        public Transmtn.DTO.Notifications.Notification[] Length; // 0x10
        public int Span; // 0x18
        public ZLinq.Internal.RentedArrayBox`1<Transmtn.DTO.Notifications.Notification> Empty;

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
        public System.Span`1<System.Collections.Generic.KeyValuePair`2<string,int>> Count; // 0x10
        public int countInCurrentSegment; // 0x20
        public System.Span`1<System.Collections.Generic.KeyValuePair`2<string,int>> initialBuffer; // 0x28
        public ZLinq.Internal.InlineArray27`1<System.Collections.Generic.KeyValuePair`2<string,int>[]> segments; // 0x38
        public int segmentsCount; // 0x110
        public int countInFinishedSegments; // 0x114

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
        public int[] Count; // 0x10
        public int head; // 0x18
        public int tail; // 0x1C
        public int size; // 0x20

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