// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Globalization.Unicode
// Classes: 8
// Methods: 78

namespace ThirdParty.DotNet.Mono.Globalization.Unicode
{
    public class CodePointIndexer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537B1530
        public void ToIndex(){} // RVA: 0x7FFD537B1720
    }

    public class Contraction : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537B17D0
    }

    public class ContractionComparer : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD537B18D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD537B19D0
    }

    public class Level2Map : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537B1A70
    }

    public class MSCompatUnicodeTable : Object
    {
        public object IsReady;

        // ── Methods ──
        public void GetTailoringInfo(){} // RVA: 0x7FFD537B1A80
        public void BuildTailoringTables(){} // RVA: 0x7FFD537B1B90
        public void SetCJKReferences(){} // RVA: 0x7FFD537B2380
        public void Category(){} // RVA: 0x7FFD537B27F0
        public void Level1(){} // RVA: 0x7FFD537B28B0
        public void Level2(){} // RVA: 0x7FFD537B2970
        public void Level3(){} // RVA: 0x7FFD537B2A30
        public void IsIgnorable(){} // RVA: 0x7FFD537B2AF0
        public void IsIgnorableNonSpacing(){} // RVA: 0x7FFD537B2C30
        public void ToKanaTypeInsensitive(){} // RVA: 0x7FFD537B2C80
        public void ToWidthCompat(){} // RVA: 0x7FFD537B2CA0
        public void HasSpecialWeight(){} // RVA: 0x7FFD537B2E20
        public void IsHalfWidthKana(){} // RVA: 0x7FFD537B2E90
        public void IsHiragana(){} // RVA: 0x7FFD537B2EB0
        public void IsJapaneseSmallLetter(){} // RVA: 0x7FFD537B2ED0
        public void get_IsReady(){} // RVA: 0x7FFD537B3030
        public void GetResource(){} // RVA: 0x7FFD537B3090
        public void UInt32FromBytePtr(){} // RVA: 0x7FFD537B3140
        public void .cctor(){} // RVA: 0x7FFD537B3180
        public void FillCJK(){} // RVA: 0x7FFD537B37B0
        public void FillCJKCore(){} // RVA: 0x7FFD537B39D0
    }

    public class MSCompatUnicodeTableUtil : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD537B4180
    }

    public class SimpleCollator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537B5000
        public void SetCJKTable(){} // RVA: 0x7FFD537B5560
        public void GetNeutralCulture(){} // RVA: 0x7FFD537B56D0
        public void Category(){} // RVA: 0x7FFD537B5770
        public void Level1(){} // RVA: 0x7FFD537B5810
        public void Level2(){} // RVA: 0x7FFD537B58B0
        public void IsHalfKana(){} // RVA: 0x7FFD537B5A50
        public void GetContraction(){} // RVA: 0x7FFD537B5BC0 | overloaded x2
        public void GetTailContraction(){} // RVA: 0x7FFD537B5DE0 | overloaded x2
        public void FilterOptions(){} // RVA: 0x7FFD537B6020
        public void GetExtenderType(){} // RVA: 0x7FFD537B62C0
        public void ToDashTypeValue(){} // RVA: 0x7FFD537B6380
        public void FilterExtender(){} // RVA: 0x7FFD537B63A0
        public void IsIgnorable(){} // RVA: 0x7FFD537B6550
        public void IsSafe(){} // RVA: 0x7FFD537B65E0
        public void GetSortKey(){} // RVA: 0x7FFD537B6840 | overloaded x3
        public void FillSortKeyRaw(){} // RVA: 0x7FFD537B6BC0
        public void FillSurrogateSortKeyRaw(){} // RVA: 0x7FFD537B7120
        public void System.Globalization.ISimpleCollator.Compare(){} // RVA: 0x7FFD537B71F0
        public void Compare(){} // RVA: 0x7FFD537B7200
        public void ClearBuffer(){} // RVA: 0x7FFD537B7300
        public void CompareInternal(){} // RVA: 0x7FFD537B7320
        public void CompareFlagPair(){} // RVA: 0x7FFD537B8870
        public void IsPrefix(){} // RVA: 0x7FFD537B89D0 | overloaded x3
        public void IsSuffix(){} // RVA: 0x7FFD537B8B10 | overloaded x2
        public void QuickIndexOf(){} // RVA: 0x7FFD537B8BD0
        public void IndexOf(){} // RVA: 0x7FFD537B92C0 | overloaded x2
        public void IndexOfOrdinal(){} // RVA: 0x7FFD537B9180 | overloaded x2
        public void IndexOfSortKey(){} // RVA: 0x7FFD537B9200
        public void LastIndexOf(){} // RVA: 0x7FFD537B9C40 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x7FFD537B99C0
        public void LastIndexOfSortKey(){} // RVA: 0x7FFD537B9B70
        public void MatchesForward(){} // RVA: 0x7FFD537BA1B0
        public void MatchesForwardCore(){} // RVA: 0x7FFD537BA390
        public void MatchesPrimitive(){} // RVA: 0x7FFD537BA7E0
        public void MatchesBackward(){} // RVA: 0x7FFD537BA9C0
        public void MatchesBackwardCore(){} // RVA: 0x7FFD537BABB0
        public void .cctor(){} // RVA: 0x7FFD537BB1B0
    }

    public class TailoringInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD52112960
    }

}