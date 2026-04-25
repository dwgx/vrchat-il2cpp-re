// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Globalization.Unicode
// Classes: 10
// Methods: 92

namespace ThirdParty.DotNet.Mono.Globalization.Unicode
{
    public class CodePointIndexer : Object
    {
        public TableRange[] ranges; // 0x10
        public int TotalCount; // 0x18
        public int defaultIndex; // 0x1C
        public int defaultCP; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8391530
        public void ToIndex(){} // RVA: 0x7FFAC8391720
    }

    public class Contraction : Object
    {
        public int Index; // 0x10
        public char[] Source; // 0x18
        public string Replacement; // 0x20
        public byte[] SortKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83917D0
    }

    public class ContractionComparer : Object
    {
        public Mono.Globalization.Unicode.ContractionComparer Instance;

        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC83918D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC83919D0
    }

    public class Level2Map : Object
    {
        public byte Source; // 0x10
        public byte Replace; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8391A70
    }

    public class MSCompatUnicodeTable : Object
    {
        public int IsReady;
        public byte* ignorableFlags; // 0x8
        public byte* categories; // 0x10
        public byte* level1; // 0x18
        public byte* level2; // 0x20
        public byte* level3; // 0x28
        public byte* cjkCHScategory; // 0x30
        public byte* cjkCHTcategory; // 0x38
        public byte* cjkJAcategory; // 0x40
        public byte* cjkKOcategory; // 0x48
        public byte* cjkCHSlv1; // 0x50
        public byte* cjkCHTlv1; // 0x58
        public byte* cjkJAlv1; // 0x60
        public byte* cjkKOlv1; // 0x68
        public byte* cjkKOlv2; // 0x70
        public char[] tailoringArr; // 0x78
        public Mono.Globalization.Unicode.TailoringInfo[] tailoringInfos; // 0x80
        public object forLock; // 0x88
        public bool isReady; // 0x90

        // ── Methods ──
        public void GetTailoringInfo(){} // RVA: 0x7FFAC8391A80
        public void BuildTailoringTables(){} // RVA: 0x7FFAC8391B90
        public void SetCJKReferences(){} // RVA: 0x7FFAC8392380
        public void Category(){} // RVA: 0x7FFAC83927F0
        public void Level1(){} // RVA: 0x7FFAC83928B0
        public void Level2(){} // RVA: 0x7FFAC8392970
        public void Level3(){} // RVA: 0x7FFAC8392A30
        public void IsIgnorable(){} // RVA: 0x7FFAC8392AF0
        public void IsIgnorableNonSpacing(){} // RVA: 0x7FFAC8392C30
        public void ToKanaTypeInsensitive(){} // RVA: 0x7FFAC8392C80
        public void ToWidthCompat(){} // RVA: 0x7FFAC8392CA0
        public void HasSpecialWeight(){} // RVA: 0x7FFAC8392E20
        public void IsHalfWidthKana(){} // RVA: 0x7FFAC8392E90
        public void IsHiragana(){} // RVA: 0x7FFAC8392EB0
        public void IsJapaneseSmallLetter(){} // RVA: 0x7FFAC8392ED0
        public void get_IsReady(){} // RVA: 0x7FFAC8393030
        public void GetResource(){} // RVA: 0x7FFAC8393090
        public void UInt32FromBytePtr(){} // RVA: 0x7FFAC8393140
        public void .cctor(){} // RVA: 0x7FFAC8393180
        public void FillCJK(){} // RVA: 0x7FFAC83937B0
        public void FillCJKCore(){} // RVA: 0x7FFAC83939D0
    }

    public class MSCompatUnicodeTableUtil : Object
    {
        public Mono.Globalization.Unicode.CodePointIndexer Ignorable;
        public Mono.Globalization.Unicode.CodePointIndexer Category; // 0x8
        public Mono.Globalization.Unicode.CodePointIndexer Level1; // 0x10
        public Mono.Globalization.Unicode.CodePointIndexer Level2; // 0x18
        public Mono.Globalization.Unicode.CodePointIndexer Level3; // 0x20
        public Mono.Globalization.Unicode.CodePointIndexer CjkCHS; // 0x28
        public Mono.Globalization.Unicode.CodePointIndexer Cjk; // 0x30

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8394180
    }

    public class NormalizationTableUtil : Object
    {
        public Mono.Globalization.Unicode.CodePointIndexer Prop;
        public Mono.Globalization.Unicode.CodePointIndexer Map; // 0x8
        public Mono.Globalization.Unicode.CodePointIndexer Combining; // 0x10
        public Mono.Globalization.Unicode.CodePointIndexer Composite; // 0x18
        public Mono.Globalization.Unicode.CodePointIndexer Helper; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8394970
        public void PropIdx(){} // RVA: 0x7FFAC8394F20
        public void MapIdx(){} // RVA: 0x7FFAC8394F90
    }

    public class SimpleCollator : Object
    {
        public Mono.Globalization.Unicode.SimpleCollator invariant;
        public System.Globalization.TextInfo textInfo; // 0x10
        public Mono.Globalization.Unicode.CodePointIndexer cjkIndexer; // 0x18
        public Mono.Globalization.Unicode.Contraction[] contractions; // 0x20
        public Mono.Globalization.Unicode.Level2Map[] level2Maps; // 0x28
        public byte[] unsafeFlags; // 0x30
        public byte* cjkCatTable; // 0x38
        public byte* cjkLv1Table; // 0x40
        public byte* cjkLv2Table; // 0x48
        public Mono.Globalization.Unicode.CodePointIndexer cjkLv2Indexer; // 0x50
        public int lcid; // 0x58
        public bool frenchSort; // 0x5C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8395000
        public void SetCJKTable(){} // RVA: 0x7FFAC8395560
        public void GetNeutralCulture(){} // RVA: 0x7FFAC83956D0
        public void Category(){} // RVA: 0x7FFAC8395770
        public void Level1(){} // RVA: 0x7FFAC8395810
        public void Level2(){} // RVA: 0x7FFAC83958B0
        public void IsHalfKana(){} // RVA: 0x7FFAC8395A50
        public void GetContraction(){} // RVA: 0x7FFAC8395BC0 | overloaded x2
        public void GetTailContraction(){} // RVA: 0x7FFAC8395DE0 | overloaded x2
        public void FilterOptions(){} // RVA: 0x7FFAC8396020
        public void GetExtenderType(){} // RVA: 0x7FFAC83962C0
        public void ToDashTypeValue(){} // RVA: 0x7FFAC8396380
        public void FilterExtender(){} // RVA: 0x7FFAC83963A0
        public void IsIgnorable(){} // RVA: 0x7FFAC8396550
        public void IsSafe(){} // RVA: 0x7FFAC83965E0
        public void GetSortKey(){} // RVA: 0x7FFAC8396840 | overloaded x3
        public void FillSortKeyRaw(){} // RVA: 0x7FFAC8396BC0
        public void FillSurrogateSortKeyRaw(){} // RVA: 0x7FFAC8397120
        public void System.Globalization.ISimpleCollator.Compare(){} // RVA: 0x7FFAC83971F0
        public void Compare(){} // RVA: 0x7FFAC8397200
        public void ClearBuffer(){} // RVA: 0x7FFAC8397300
        public void CompareInternal(){} // RVA: 0x7FFAC8397320
        public void CompareFlagPair(){} // RVA: 0x7FFAC8398870
        public void IsPrefix(){} // RVA: 0x7FFAC83989D0 | overloaded x3
        public void IsSuffix(){} // RVA: 0x7FFAC8398B10 | overloaded x2
        public void QuickIndexOf(){} // RVA: 0x7FFAC8398BD0
        public void IndexOf(){} // RVA: 0x7FFAC83992C0 | overloaded x2
        public void IndexOfOrdinal(){} // RVA: 0x7FFAC8399180 | overloaded x2
        public void IndexOfSortKey(){} // RVA: 0x7FFAC8399200
        public void LastIndexOf(){} // RVA: 0x7FFAC8399C40 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x7FFAC83999C0
        public void LastIndexOfSortKey(){} // RVA: 0x7FFAC8399B70
        public void MatchesForward(){} // RVA: 0x7FFAC839A1B0
        public void MatchesForwardCore(){} // RVA: 0x7FFAC839A390
        public void MatchesPrimitive(){} // RVA: 0x7FFAC839A7E0
        public void MatchesBackward(){} // RVA: 0x7FFAC839A9C0
        public void MatchesBackwardCore(){} // RVA: 0x7FFAC839ABB0
        public void .cctor(){} // RVA: 0x7FFAC839B1B0
    }

    public class SortKeyBuffer : Object
    {
        public byte[] l1b; // 0x10
        public byte[] l2b; // 0x18
        public byte[] l3b; // 0x20
        public byte[] l4sb; // 0x28
        public byte[] l4tb; // 0x30
        public byte[] l4kb; // 0x38
        public byte[] l4wb; // 0x40
        public byte[] l5b; // 0x48
        public string source; // 0x50
        public int l1; // 0x58
        public int l2; // 0x5C
        public int l3; // 0x60
        public int l4s; // 0x64
        public int l4t; // 0x68
        public int l4k; // 0x6C
        public int l4w; // 0x70
        public int l5; // 0x74
        public int lcid; // 0x78
        public 0x6B0DB010 options; // 0x7C
        public bool processLevel2; // 0x80
        public bool frenchSort; // 0x81
        public bool frenchSorted; // 0x82

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Reset(){} // RVA: 0x7FFAC839B320
        public void Initialize(){} // RVA: 0x7FFAC839B340
        public void AppendCJKExtension(){} // RVA: 0x7FFAC839B7B0
        public void AppendKana(){} // RVA: 0x7FFAC839B880
        public void AppendNormal(){} // RVA: 0x7FFAC839B950
        public void AppendLevel5(){} // RVA: 0x7FFAC839BB40
        public void AppendBufferPrimitive(){} // RVA: 0x7FFAC839BC20
        public void GetResultAndReset(){} // RVA: 0x7FFAC839BDF0
        public void GetOptimizedLength(){} // RVA: 0x7FFAC839BE20
        public void GetResult(){} // RVA: 0x7FFAC839BE70
    }

    public class TailoringInfo : Object
    {
        public int LCID; // 0x10
        public int TailoringIndex; // 0x14
        public int TailoringCount; // 0x18
        public bool FrenchSort; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6CF2960
    }

}