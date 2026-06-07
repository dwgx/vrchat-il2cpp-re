// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.ZLinq.ZLinq
// Classes: 10
// Methods: 257

namespace ThirdParty.ZLinq.ZLinq
{
    public class ArgumentNullException
    {
        // ── Methods ──
        public void ThrowIfNull(){} // RVA: 0x9B07920
        public void Throw(){} // RVA: 0x9B07940
    }

    public class GC
    {
        // ── Methods ──
        public void AllocateUninitializedArray(){} // RVA: 0x127A0
    }

    public class IValueEnumerator`1
    {
        // ── Methods ──
        public void TryGetNext(){} // RVA: 0xDE40
        public void TryGetNonEnumeratedCount(){} // RVA: 0xDE40
        public void TryGetSpan(){} // RVA: 0xDE40
        public void TryCopyTo(){} // RVA: 0x283FA0
    }

    public class PooledArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0
        public void get_Memory(){} // RVA: 0x283FA0
        public void get_ArraySegment(){} // RVA: 0x283FA0
        public void AsEnumerable(){} // RVA: 0xCD60
        public void AsValueEnumerable(){} // RVA: 0x283FA0
        public void Deconstruct(){} // RVA: 0x2DC60
        public void Dispose(){} // RVA: 0x24A50
    }

    public class ValueEnumerable
    {
        // ── Methods ──
        public void AsValueEnumerable(){} // RVA: 0x283FA0 | overloaded x5
        public void Range(){} // RVA: 0x9B07990
    }

    public class ValueEnumerableDebugView`2
    {
    }

    public class ValueEnumerableExtensions
    {
        // ── Methods ──
        public void Aggregate(){} // RVA: 0x283FA0 | overloaded x3
        public void AggregateBy(){} // RVA: 0x283FA0 | overloaded x4
        public void All(){} // RVA: 0x283FA0 | overloaded x2
        public void Any(){} // RVA: 0x283FA0 | overloaded x3
        public void Append(){} // RVA: 0x283FA0
        public void Average(){} // RVA: 0x283FA0 | overloaded x12
        public void Chunk(){} // RVA: 0x283FA0
        public void Concat(){} // RVA: 0x283FA0 | overloaded x2
        public void Contains(){} // RVA: 0x283FA0 | overloaded x3
        public void ContainsCore(){} // RVA: 0x283FA0
        public void Count(){} // RVA: 0x283FA0 | overloaded x3
        public void CountBy(){} // RVA: 0x283FA0 | overloaded x2
        public void DefaultIfEmpty(){} // RVA: 0x283FA0 | overloaded x2
        public void Distinct(){} // RVA: 0x283FA0 | overloaded x2
        public void DistinctBy(){} // RVA: 0x283FA0 | overloaded x2
        public void ElementAt(){} // RVA: 0x283FA0 | overloaded x2
        public void ElementAtOrDefault(){} // RVA: 0x283FA0 | overloaded x2
        public void TryGetElementAt(){} // RVA: 0x283FA0
        public void Except(){} // RVA: 0x283FA0 | overloaded x4
        public void ExceptBy(){} // RVA: 0x283FA0 | overloaded x4
        public void First(){} // RVA: 0x283FA0 | overloaded x2
        public void FirstOrDefault(){} // RVA: 0x283FA0 | overloaded x4
        public void TryGetFirst(){} // RVA: 0x114C0 | overloaded x2
        public void GroupBy(){} // RVA: 0x283FA0 | overloaded x8
        public void GroupJoin(){} // RVA: 0x283FA0 | overloaded x4
        public void Index(){} // RVA: 0x283FA0
        public void Intersect(){} // RVA: 0x283FA0 | overloaded x4
        public void IntersectBy(){} // RVA: 0x283FA0 | overloaded x4
        public void Join(){} // RVA: 0x283FA0 | overloaded x4
        public void JoinToString(){} // RVA: 0x283FA0 | overloaded x3
        public void Last(){} // RVA: 0x283FA0 | overloaded x2
        public void LastOrDefault(){} // RVA: 0x283FA0 | overloaded x4
        public void TryGetLast(){} // RVA: 0x114C0 | overloaded x2
        public void LeftJoin(){} // RVA: 0x283FA0 | overloaded x4
        public void LongCount(){} // RVA: 0x283FA0 | overloaded x3
        public void Max(){} // RVA: 0x283FA0 | overloaded x3
        public void MaxBy(){} // RVA: 0x283FA0 | overloaded x2
        public void Min(){} // RVA: 0x283FA0 | overloaded x3
        public void MinBy(){} // RVA: 0x283FA0 | overloaded x2
        public void Order(){} // RVA: 0x283FA0 | overloaded x2
        public void OrderDescending(){} // RVA: 0x283FA0 | overloaded x2
        public void OrderBy(){} // RVA: 0x283FA0 | overloaded x2
        public void OrderByDescending(){} // RVA: 0x283FA0 | overloaded x2
        public void ThenBy(){} // RVA: 0x283FA0
        public void Take(){} // RVA: 0x283FA0 | overloaded x3
        public void Prepend(){} // RVA: 0x283FA0
        public void Reverse(){} // RVA: 0x283FA0
        public void RightJoin(){} // RVA: 0x283FA0 | overloaded x4
        public void Select(){} // RVA: 0x283FA0 | overloaded x8
        public void Where(){} // RVA: 0x283FA0 | overloaded x5
        public void SelectMany(){} // RVA: 0x283FA0 | overloaded x8
        public void SequenceEqual(){} // RVA: 0x283FA0 | overloaded x4
        public void Shuffle(){} // RVA: 0x283FA0
        public void Single(){} // RVA: 0x283FA0 | overloaded x2
        public void SingleOrDefault(){} // RVA: 0x283FA0 | overloaded x4
        public void TryGetSingle(){} // RVA: 0x114C0 | overloaded x2
        public void Skip(){} // RVA: 0x283FA0
        public void SkipLast(){} // RVA: 0x283FA0
        public void SkipWhile(){} // RVA: 0x283FA0 | overloaded x2
        public void Sum(){} // RVA: 0x283FA0 | overloaded x4
        public void TakeLast(){} // RVA: 0x283FA0
        public void TakeWhile(){} // RVA: 0x283FA0 | overloaded x2
        public void ToArray(){} // RVA: 0x283FA0 | overloaded x9
        public void ToArrayPool(){} // RVA: 0x283FA0
        public void ToDictionary(){} // RVA: 0x283FA0 | overloaded x8
        public void ToHashSet(){} // RVA: 0x283FA0 | overloaded x2
        public void ToHashSetSlim(){} // RVA: 0x283FA0
        public void ToList(){} // RVA: 0x283FA0 | overloaded x4
        public void ToLookup(){} // RVA: 0x283FA0 | overloaded x4
        public void TryGetNonEnumeratedCount(){} // RVA: 0x283FA0
        public void Union(){} // RVA: 0x283FA0 | overloaded x4
        public void UnionBy(){} // RVA: 0x283FA0 | overloaded x4
        public void Zip(){} // RVA: 0x283FA0 | overloaded x6
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void <All>g__All|8_0(){} // RVA: 0xE230
        public void <Any>g__Any|11_0(){} // RVA: 0xE230
        public void <Count>g__Count|37_0(){} // RVA: 0x12610
        public void <LongCount>g__LongCount|110_0(){} // RVA: 0xCEC0
    }

    public class ValueEnumerable`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void Cast(){} // RVA: 0x283FA0
        public void OfType(){} // RVA: 0x283FA0
    }

    public class ValueEnumerator`2 : current
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_Current(){} // RVA: 0x283FA0
        public void MoveNext(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
    }

    public class ZLinqDropInAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
    }

}