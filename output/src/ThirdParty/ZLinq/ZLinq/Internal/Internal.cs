// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq.Internal
// Classes: 14
// Methods: 73

namespace ThirdParty.ZLinq.ZLinq.Internal
{
    public class DefaultInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A547E30
        public void AppendFormatted(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ToStringAndClear(){} // RVA: 0x7FFE8A547F70
        public void Clear(){} // RVA: 0x7FFE8A5480D0
        public void GrowThenCopyString(){} // RVA: 0x7FFE8A548180
        public void Grow(){} // RVA: 0x7FFE8A5482C0 | overloaded x2
        public void GrowCore(){} // RVA: 0x7FFE8A5482D0
        public void MathClamp(){} // RVA: 0x7FFE8A5485C0
        public void ThrowMinMaxException(){} // RVA: 0x7FFE810A1420
    }

    public class DictionarySlim`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetValueRefOrAddDefault(){} // RVA: 0x7FFE810A1420
        public void Resize(){} // RVA: 0x7FFE80E45FE0
        public void InternalGetHashCode(){} // RVA: 0x7FFE810A1420
        public void GetBucketIndex(){} // RVA: 0x7FFE80E35520
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class EnumeratorHelper : Object
    {
        // ── Methods ──
        public void TryGetSliceRange(){} // RVA: 0x7FFE8A547D90
        public void TryGetSlice(){} // RVA: 0x7FFE810A1420
        public void TryConsumeGetAt(){} // RVA: 0x7FFE80E32180 | overloaded x2
        public void TryConsumeGetFirst(){} // RVA: 0x7FFE80E2F7A0
        public void TryConsumeGetLast(){} // RVA: 0x7FFE80E2F7A0
        public void TryConsumeGetFromLast(){} // RVA: 0x7FFE80E32180
    }

    public class HashSetSlim`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E48220 | overloaded x2
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Resize(){} // RVA: 0x7FFE80E45FE0
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void InternalGetHashCode(){} // RVA: 0x7FFE810A1420
        public void GetBucketIndex(){} // RVA: 0x7FFE80E35520
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class InlineArray16`1 : ValueType
    {
        // ── Methods ──
        public void AsSpan(){} // RVA: 0x7FFE810A1420
    }

    public class InlineArray27`1 : ValueType
    {
        public T item0;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE80E3D230
        public void AsSpan(){} // RVA: 0x7FFE810A1420
    }

    public class InlineArrayMarshal : Object
    {
        // ── Methods ──
        public void AsSpan(){} // RVA: 0x7FFE810A1420
        public void ElementRef(){} // RVA: 0x7FFE80E3D4E0
    }

    public class RandomShared : Object
    {
        // ── Methods ──
        public void Shuffle(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8A548640
    }

    public class RefBox`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetValueRef(){} // RVA: 0x7FFE80E2E2E0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class RentedArrayBox`1 : Object
    {
        public T[] <array>P;
        public int <length>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4D070
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_Span(){} // RVA: 0x7FFE810A1420
        public void UnsafeGetAt(){} // RVA: 0x7FFE80E3D230
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class SegmentedArrayProvider`1 : ValueType
    {
        public System.Span`1<T> currentSegment;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetSpan(){} // RVA: 0x7FFE810A1420
        public void Advance(){} // RVA: 0x7FFE80E46530
        public void Expand(){} // RVA: 0x7FFE80E45FE0
        public void CopyToAndClear(){} // RVA: 0x7FFE810A1420
    }

    public class SingleSpan : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420
    }

    public class Throws : Object
    {
        // ── Methods ──
        public void ArgumentOutOfRange(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void MoreThanOneElement(){} // RVA: 0x7FFE8A548BC0
        public void MoreThanOneMatch(){} // RVA: 0x7FFE8A548C10
        public void NoElements(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void NoMatch(){} // RVA: 0x7FFE810A1420
        public void NotSupportedType(){} // RVA: 0x7FFE8A548CB0
        public void IfNull(){} // RVA: 0x7FFE810A1420
    }

    public class ValueQueue`1 : ValueType
    {
        public T[] items;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void Enqueue(){} // RVA: 0x7FFE810A1420
        public void Dequeue(){} // RVA: 0x7FFE810A1420
        public void Throw(){} // RVA: 0x7FFE80E46010
        public void Grow(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

}