// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Globalization.Unicode
// Classes: 8
// Methods: 78

namespace ThirdParty.DotNet.Mono.Globalization.Unicode
{
    public class CodePointIndexer : Object
    {
        public object defaultIndex; // 0x34E6A9D0
        public object ; // 0x34E6AB70

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddb26e0
        public void ToIndex(){} // RVA: 0x7ffaaddb28d0
    }

    public class Contraction : Object
    {
        public object Replacement; // 0x34E6A6D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddb2980
    }

    public class ContractionComparer : Object
    {
        // ── Original Methods ──
        public void Compare(){} // RVA: 0x7ffaaddb2a80
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaddb2b80
    }

    public class Level2Map : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddb2c20
    }

    public class MSCompatUnicodeTable : Object
    {
        public object categories; // 0x34E68A70
        public object level3; // 0x34E68A70
        public object cjkJAcategory; // 0x34E68A70
        public object cjkCHTlv1; // 0x34E68A70
        public object cjkKOlv2; // 0x34E68A70
        public object forLock; // 0x34E68A70
        public object ; // 0x34E68D90
        public object TailoringInfo[];

        // ── Original Methods ──
        public void BuildTailoringTables(){} // RVA: 0x7ffaaddb2d40
        public void Category(){} // RVA: 0x7ffaaddb39a0
        public void Level1(){} // RVA: 0x7ffaaddb3a60
        public void Level2(){} // RVA: 0x7ffaaddb3b20
        public void Level3(){} // RVA: 0x7ffaaddb3be0
        public void IsIgnorable(){} // RVA: 0x7ffaaddb3ca0
        public void IsIgnorableNonSpacing(){} // RVA: 0x7ffaaddb3de0
        public void ToKanaTypeInsensitive(){} // RVA: 0x7ffaaddb3e30
        public void ToWidthCompat(){} // RVA: 0x7ffaaddb3e50
        public void HasSpecialWeight(){} // RVA: 0x7ffaaddb3fd0
        public void IsHalfWidthKana(){} // RVA: 0x7ffaaddb4040
        public void IsHiragana(){} // RVA: 0x7ffaaddb4060
        public void IsJapaneseSmallLetter(){} // RVA: 0x7ffaaddb4080
        public void get_IsReady(){} // RVA: 0x7ffaaddb41e0
        public void UInt32FromBytePtr(){} // RVA: 0x7ffaaddb42f0
        public void .cctor(){} // RVA: 0x7ffaaddb4330
        public void FillCJK(){} // RVA: 0x7ffaaddb4960
        public void FillCJKCore(){} // RVA: 0x7ffaaddb4b80
        // ── Binary Analysis Named ──
        public void GetTailoringInfo(){} // RVA: 0x7ffaaddb2c30
        public void SetCJKReferences(){} // RVA: 0x7ffaaddb3530
        public void GetResource(){} // RVA: 0x7ffaaddb4240
    }

    public class MSCompatUnicodeTableUtil : Object
    {
        public object Level1; // 0x34E6A3C0
        public object CjkCHS; // 0x34E6A3C0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaddb5330
    }

    public class SimpleCollator : Object
    {
        public object cjkIndexer; // 0x34E69030
        public object unsafeFlags; // 0x34E69030
        public object cjkLv2Table; // 0x34E69030
        public object frenchSort; // 0x34E69030

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddb61b0
        public void Category(){} // RVA: 0x7ffaaddb6920
        public void Level1(){} // RVA: 0x7ffaaddb69c0
        public void Level2(){} // RVA: 0x7ffaaddb6a60
        public void IsHalfKana(){} // RVA: 0x7ffaaddb6c00
        public void FilterOptions(){} // RVA: 0x7ffaaddb71d0
        public void ToDashTypeValue(){} // RVA: 0x7ffaaddb7530
        public void FilterExtender(){} // RVA: 0x7ffaaddb7550
        public void IsIgnorable(){} // RVA: 0x7ffaaddb7700
        public void IsSafe(){} // RVA: 0x7ffaaddb7790
        public void FillSortKeyRaw(){} // RVA: 0x7ffaaddb7d70
        public void FillSurrogateSortKeyRaw(){} // RVA: 0x7ffaaddb82d0
        public void System.Globalization.ISimpleCollator.Compare(){} // RVA: 0x7ffaaddb83a0
        public void Compare(){} // RVA: 0x7ffaaddb83b0
        public void ClearBuffer(){} // RVA: 0x7ffaaddb84b0
        public void CompareInternal(){} // RVA: 0x7ffaaddb84d0
        public void CompareFlagPair(){} // RVA: 0x7ffaaddb9a20
        public void IsPrefix(){} // RVA: 0x7ffaaddb9b80
        public void IsPrefix(){} // RVA: 0x7ffaaddb9b80
        public void IsPrefix(){} // RVA: 0x7ffaaddb9b80
        public void IsSuffix(){} // RVA: 0x7ffaaddb9cc0
        public void IsSuffix(){} // RVA: 0x7ffaaddb9cc0
        public void QuickIndexOf(){} // RVA: 0x7ffaaddb9d80
        public void IndexOf(){} // RVA: 0x7ffaaddba470
        public void IndexOfOrdinal(){} // RVA: 0x7ffaaddba330
        public void IndexOfOrdinal(){} // RVA: 0x7ffaaddba330
        public void IndexOfSortKey(){} // RVA: 0x7ffaaddba3b0
        public void IndexOf(){} // RVA: 0x7ffaaddba470
        public void LastIndexOf(){} // RVA: 0x7ffaaddbadf0
        public void LastIndexOfOrdinal(){} // RVA: 0x7ffaaddbab70
        public void LastIndexOfSortKey(){} // RVA: 0x7ffaaddbad20
        public void LastIndexOf(){} // RVA: 0x7ffaaddbadf0
        public void MatchesForward(){} // RVA: 0x7ffaaddbb360
        public void MatchesForwardCore(){} // RVA: 0x7ffaaddbb540
        public void MatchesPrimitive(){} // RVA: 0x7ffaaddbb990
        public void MatchesBackward(){} // RVA: 0x7ffaaddbbb70
        public void MatchesBackwardCore(){} // RVA: 0x7ffaaddbbd60
        public void .cctor(){} // RVA: 0x7ffaaddbc360
        // ── Binary Analysis Named ──
        public void SetCJKTable(){} // RVA: 0x7ffaaddb6710
        public void GetNeutralCulture(){} // RVA: 0x7ffaaddb6880
        public void GetContraction(){} // RVA: 0x7ffaaddb6d70
        public void GetContraction(){} // RVA: 0x7ffaaddb6d70
        public void GetTailContraction(){} // RVA: 0x7ffaaddb6f90
        public void GetTailContraction(){} // RVA: 0x7ffaaddb6f90
        public void GetExtenderType(){} // RVA: 0x7ffaaddb7470
        public void GetSortKey(){} // RVA: 0x7ffaaddb79f0
        public void GetSortKey(){} // RVA: 0x7ffaaddb79f0
        public void GetSortKey(){} // RVA: 0x7ffaaddb79f0
    }

    public class TailoringInfo : Object
    {
        public object TailoringCount; // 0x34E68D70

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac703900
    }

}