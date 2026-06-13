// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Globalization.Unicode
// Classes: 10
// Methods: 92

namespace ThirdParty.DotNet.Mono.Globalization.Unicode
{
    public class CodePointIndexer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BF9FE0
        public void ToIndex(){} // RVA: 0x5BFA1D0
    }

    public class Contraction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BFA280
    }

    public class ContractionComparer
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x5BFA380
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5BFA480
    }

    public class Level2Map
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BFA520
    }

    public class MSCompatUnicodeTable
    {
        public int MaxExpansionLength;

        // ── Methods ──
        public void GetTailoringInfo(){} // RVA: 0x5BFA530
        public void BuildTailoringTables(){} // RVA: 0x5BFA640
        public void SetCJKReferences(){} // RVA: 0x5BFAE30
        public void Category(){} // RVA: 0x5BFB2A0
        public void Level1(){} // RVA: 0x5BFB360
        public void Level2(){} // RVA: 0x5BFB420
        public void Level3(){} // RVA: 0x5BFB4E0
        public void IsIgnorable(){} // RVA: 0x5BFB5A0
        public void IsIgnorableNonSpacing(){} // RVA: 0x5BFB6E0
        public void ToKanaTypeInsensitive(){} // RVA: 0x5BFB730
        public void ToWidthCompat(){} // RVA: 0x5BFB750
        public void HasSpecialWeight(){} // RVA: 0x5BFB8D0
        public void IsHalfWidthKana(){} // RVA: 0x5BFB940
        public void IsHiragana(){} // RVA: 0x5BFB960
        public void IsJapaneseSmallLetter(){} // RVA: 0x5BFB980
        public void get_IsReady(){} // RVA: 0x5BFBAE0
        public void GetResource(){} // RVA: 0x5BFBB40
        public void UInt32FromBytePtr(){} // RVA: 0x5BFBBF0
        public void .cctor(){} // RVA: 0x5BFBC30
        public void FillCJK(){} // RVA: 0x5BFC260
        public void FillCJKCore(){} // RVA: 0x5BFC480
    }

    public class MSCompatUnicodeTableUtil
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5BFCC30
    }

    public class NormalizationTableUtil
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5BFD420
        public void PropIdx(){} // RVA: 0x5BFD9D0
        public void MapIdx(){} // RVA: 0x5BFDA40
    }

    public class SimpleCollator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BFDAB0
        public void SetCJKTable(){} // RVA: 0x5BFE010
        public void GetNeutralCulture(){} // RVA: 0x5BFE180
        public void Category(){} // RVA: 0x5BFE220
        public void Level1(){} // RVA: 0x5BFE2C0
        public void Level2(){} // RVA: 0x5BFE360
        public void IsHalfKana(){} // RVA: 0x5BFE500
        public void GetContraction(){} // RVA: 0x5BFE670 | overloaded x2
        public void GetTailContraction(){} // RVA: 0x5BFE890 | overloaded x2
        public void FilterOptions(){} // RVA: 0x5BFEAD0
        public void GetExtenderType(){} // RVA: 0x5BFED70
        public void ToDashTypeValue(){} // RVA: 0x5BFEE30
        public void FilterExtender(){} // RVA: 0x5BFEE50
        public void IsIgnorable(){} // RVA: 0x5BFF000
        public void IsSafe(){} // RVA: 0x5BFF090
        public void GetSortKey(){} // RVA: 0x5BFF2F0 | overloaded x3
        public void FillSortKeyRaw(){} // RVA: 0x5BFF670
        public void FillSurrogateSortKeyRaw(){} // RVA: 0x5BFFBD0
        public void System.Globalization.ISimpleCollator.Compare(){} // RVA: 0x5BFFCA0
        public void Compare(){} // RVA: 0x5BFFCB0
        public void ClearBuffer(){} // RVA: 0x5BFFDB0
        public void CompareInternal(){} // RVA: 0x5BFFDD0
        public void CompareFlagPair(){} // RVA: 0x5C01320
        public void IsPrefix(){} // RVA: 0x5C01480 | overloaded x3
        public void IsSuffix(){} // RVA: 0x5C015C0 | overloaded x2
        public void QuickIndexOf(){} // RVA: 0x5C01680
        public void IndexOf(){} // RVA: 0x5C01D70 | overloaded x2
        public void IndexOfOrdinal(){} // RVA: 0x5C01C30 | overloaded x2
        public void IndexOfSortKey(){} // RVA: 0x5C01CB0
        public void LastIndexOf(){} // RVA: 0x5C026F0 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x5C02470
        public void LastIndexOfSortKey(){} // RVA: 0x5C02620
        public void MatchesForward(){} // RVA: 0x5C02C60
        public void MatchesForwardCore(){} // RVA: 0x5C02E40
        public void MatchesPrimitive(){} // RVA: 0x5C03290
        public void MatchesBackward(){} // RVA: 0x5C03470
        public void MatchesBackwardCore(){} // RVA: 0x5C03660
        public void .cctor(){} // RVA: 0x5C03C60
    }

    public class SortKeyBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Reset(){} // RVA: 0x5C03DD0
        public void Initialize(){} // RVA: 0x5C03DF0
        public void AppendCJKExtension(){} // RVA: 0x5C04260
        public void AppendKana(){} // RVA: 0x5C04330
        public void AppendNormal(){} // RVA: 0x5C04400
        public void AppendLevel5(){} // RVA: 0x5C045F0
        public void AppendBufferPrimitive(){} // RVA: 0x5C046D0
        public void GetResultAndReset(){} // RVA: 0x5C048A0
        public void GetOptimizedLength(){} // RVA: 0x5C048D0
        public void GetResult(){} // RVA: 0x5C04920
    }

    public class TailoringInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x443E060
    }

}