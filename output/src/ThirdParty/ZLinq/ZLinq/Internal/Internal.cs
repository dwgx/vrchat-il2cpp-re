// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq.Internal
// Classes: 14
// Methods: 73

namespace ThirdParty.ZLinq.ZLinq.Internal
{
    public class DefaultInterpolatedStringHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B085C0
        public void AppendFormatted(){} // RVA: 0x283FA0 | overloaded x2
        public void ToStringAndClear(){} // RVA: 0x9B08700
        public void Clear(){} // RVA: 0x9B08860
        public void GrowThenCopyString(){} // RVA: 0x9B08910
        public void Grow(){} // RVA: 0x9B08A50 | overloaded x2
        public void GrowCore(){} // RVA: 0x9B08A60
        public void MathClamp(){} // RVA: 0x9B08D50
        public void ThrowMinMaxException(){} // RVA: 0x283FA0
    }

    public class DictionarySlim`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void GetValueRefOrAddDefault(){} // RVA: 0x283FA0
        public void Resize(){} // RVA: 0x24A50
        public void InternalGetHashCode(){} // RVA: 0x283FA0
        public void GetBucketIndex(){} // RVA: 0x13FB0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void Dispose(){} // RVA: 0x24A50
    }

    public class EnumeratorHelper
    {
        // ── Methods ──
        public void TryGetSliceRange(){} // RVA: 0x9B08520
        public void TryGetSlice(){} // RVA: 0x283FA0
        public void TryConsumeGetAt(){} // RVA: 0x10C50 | overloaded x2
        public void TryConsumeGetFirst(){} // RVA: 0xE230
        public void TryConsumeGetLast(){} // RVA: 0xE230
        public void TryConsumeGetFromLast(){} // RVA: 0x10C50
    }

    public class HashSetSlim`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40 | overloaded x2
        public void Add(){} // RVA: 0x283FA0
        public void Resize(){} // RVA: 0x24A50
        public void Remove(){} // RVA: 0x283FA0
        public void InternalGetHashCode(){} // RVA: 0x283FA0
        public void GetBucketIndex(){} // RVA: 0x13FB0
        public void Dispose(){} // RVA: 0x24A50
    }

    public class InlineArray16`1
    {
        // ── Methods ──
        public void AsSpan(){} // RVA: 0x283FA0
    }

    public class InlineArray27`1
    {
        public object valueType;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x1BCC0
        public void AsSpan(){} // RVA: 0x283FA0
    }

    public class InlineArrayMarshal
    {
        // ── Methods ──
        public void AsSpan(){} // RVA: 0x283FA0
        public void ElementRef(){} // RVA: 0x1BF70
    }

    public class RandomShared
    {
        // ── Methods ──
        public void Shuffle(){} // RVA: 0x283FA0 | overloaded x2
        public void .cctor(){} // RVA: 0x9B08DD0
    }

    public class RefBox`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void GetValueRef(){} // RVA: 0xCD60
        public void Dispose(){} // RVA: 0x24A50
    }

    public class RentedArrayBox`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0
        public void get_Length(){} // RVA: 0xD840
        public void get_Span(){} // RVA: 0x283FA0
        public void UnsafeGetAt(){} // RVA: 0x1BCC0
        public void Dispose(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class SegmentedArrayProvider`1
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x283FA0
        public void GetSpan(){} // RVA: 0x283FA0
        public void Advance(){} // RVA: 0x24FA0
        public void Expand(){} // RVA: 0x24A50
        public void CopyToAndClear(){} // RVA: 0x283FA0
    }

    public class SingleSpan
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x283FA0
    }

    public class Throws
    {
        // ── Methods ──
        public void ArgumentOutOfRange(){} // RVA: 0x283FA0 | overloaded x2
        public void MoreThanOneElement(){} // RVA: 0x9B09350
        public void MoreThanOneMatch(){} // RVA: 0x9B093A0
        public void NoElements(){} // RVA: 0x283FA0 | overloaded x2
        public void NoMatch(){} // RVA: 0x283FA0
        public void NotSupportedType(){} // RVA: 0x9B09440
        public void IfNull(){} // RVA: 0x283FA0
    }

    public class ValueQueue`1
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x24FA0
        public void Enqueue(){} // RVA: 0x283FA0
        public void Dequeue(){} // RVA: 0x283FA0
        public void Throw(){} // RVA: 0x24A80
        public void Grow(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
    }

}