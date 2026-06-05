// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Globalization.Unicode
// Classes: 10
// Methods: 92

namespace ThirdParty.DotNet.Mono.Globalization.Unicode
{
    public class CodePointIndexer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86A9FE0
        public void ToIndex(){} // RVA: 0x7FFAF86AA1D0
    }

    public class Contraction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86AA280
    }

    public class ContractionComparer
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAF86AA380
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF86AA480
    }

    public class Level2Map
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86AA520
    }

    public class MSCompatUnicodeTable
    {
        // ── Methods ──
        public void GetTailoringInfo(){} // RVA: 0x7FFAF86AA530
        public void BuildTailoringTables(){} // RVA: 0x7FFAF86AA640
        public void SetCJKReferences(){} // RVA: 0x7FFAF86AAE30
        public void Category(){} // RVA: 0x7FFAF86AB2A0
        public void Level1(){} // RVA: 0x7FFAF86AB360
        public void Level2(){} // RVA: 0x7FFAF86AB420
        public void Level3(){} // RVA: 0x7FFAF86AB4E0
        public void IsIgnorable(){} // RVA: 0x7FFAF86AB5A0
        public void IsIgnorableNonSpacing(){} // RVA: 0x7FFAF86AB6E0
        public void ToKanaTypeInsensitive(){} // RVA: 0x7FFAF86AB730
        public void ToWidthCompat(){} // RVA: 0x7FFAF86AB750
        public void HasSpecialWeight(){} // RVA: 0x7FFAF86AB8D0
        public void IsHalfWidthKana(){} // RVA: 0x7FFAF86AB940
        public void IsHiragana(){} // RVA: 0x7FFAF86AB960
        public void IsJapaneseSmallLetter(){} // RVA: 0x7FFAF86AB980
        public void get_IsReady(){} // RVA: 0x7FFAF86ABAE0
        public void GetResource(){} // RVA: 0x7FFAF86ABB40
        public void UInt32FromBytePtr(){} // RVA: 0x7FFAF86ABBF0
        public void .cctor(){} // RVA: 0x7FFAF86ABC30
        public void FillCJK(){} // RVA: 0x7FFAF86AC260
        public void FillCJKCore(){} // RVA: 0x7FFAF86AC480
    }

    public class MSCompatUnicodeTableUtil
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF86ACC30
    }

    public class NormalizationTableUtil
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF86AD420
        public void PropIdx(){} // RVA: 0x7FFAF86AD9D0
        public void MapIdx(){} // RVA: 0x7FFAF86ADA40
    }

    public class SimpleCollator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86ADAB0
        public void SetCJKTable(){} // RVA: 0x7FFAF86AE010
        public void GetNeutralCulture(){} // RVA: 0x7FFAF86AE180
        public void Category(){} // RVA: 0x7FFAF86AE220
        public void Level1(){} // RVA: 0x7FFAF86AE2C0
        public void Level2(){} // RVA: 0x7FFAF86AE360
        public void IsHalfKana(){} // RVA: 0x7FFAF86AE500
        public void GetContraction(){} // RVA: 0x7FFAF86AE670 | overloaded x2
        public void GetTailContraction(){} // RVA: 0x7FFAF86AE890 | overloaded x2
        public void FilterOptions(){} // RVA: 0x7FFAF86AEAD0
        public void GetExtenderType(){} // RVA: 0x7FFAF86AED70
        public void ToDashTypeValue(){} // RVA: 0x7FFAF86AEE30
        public void FilterExtender(){} // RVA: 0x7FFAF86AEE50
        public void IsIgnorable(){} // RVA: 0x7FFAF86AF000
        public void IsSafe(){} // RVA: 0x7FFAF86AF090
        public void GetSortKey(){} // RVA: 0x7FFAF86AF2F0 | overloaded x3
        public void FillSortKeyRaw(){} // RVA: 0x7FFAF86AF670
        public void FillSurrogateSortKeyRaw(){} // RVA: 0x7FFAF86AFBD0
        public void System.Globalization.ISimpleCollator.Compare(){} // RVA: 0x7FFAF86AFCA0
        public void Compare(){} // RVA: 0x7FFAF86AFCB0
        public void ClearBuffer(){} // RVA: 0x7FFAF86AFDB0
        public void CompareInternal(){} // RVA: 0x7FFAF86AFDD0
        public void CompareFlagPair(){} // RVA: 0x7FFAF86B1320
        public void IsPrefix(){} // RVA: 0x7FFAF86B1480 | overloaded x3
        public void IsSuffix(){} // RVA: 0x7FFAF86B15C0 | overloaded x2
        public void QuickIndexOf(){} // RVA: 0x7FFAF86B1680
        public void IndexOf(){} // RVA: 0x7FFAF86B1D70 | overloaded x2
        public void IndexOfOrdinal(){} // RVA: 0x7FFAF86B1C30 | overloaded x2
        public void IndexOfSortKey(){} // RVA: 0x7FFAF86B1CB0
        public void LastIndexOf(){} // RVA: 0x7FFAF86B26F0 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x7FFAF86B2470
        public void LastIndexOfSortKey(){} // RVA: 0x7FFAF86B2620
        public void MatchesForward(){} // RVA: 0x7FFAF86B2C60
        public void MatchesForwardCore(){} // RVA: 0x7FFAF86B2E40
        public void MatchesPrimitive(){} // RVA: 0x7FFAF86B3290
        public void MatchesBackward(){} // RVA: 0x7FFAF86B3470
        public void MatchesBackwardCore(){} // RVA: 0x7FFAF86B3660
        public void .cctor(){} // RVA: 0x7FFAF86B3C60
    }

    public class SortKeyBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Reset(){} // RVA: 0x7FFAF86B3DD0
        public void Initialize(){} // RVA: 0x7FFAF86B3DF0
        public void AppendCJKExtension(){} // RVA: 0x7FFAF86B4260
        public void AppendKana(){} // RVA: 0x7FFAF86B4330
        public void AppendNormal(){} // RVA: 0x7FFAF86B4400
        public void AppendLevel5(){} // RVA: 0x7FFAF86B45F0
        public void AppendBufferPrimitive(){} // RVA: 0x7FFAF86B46D0
        public void GetResultAndReset(){} // RVA: 0x7FFAF86B48A0
        public void GetOptimizedLength(){} // RVA: 0x7FFAF86B48D0
        public void GetResult(){} // RVA: 0x7FFAF86B4920
    }

    public class TailoringInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EEE060
    }

}