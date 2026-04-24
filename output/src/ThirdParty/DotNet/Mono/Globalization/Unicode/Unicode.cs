// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Globalization.Unicode
// Classes: 8
// Methods: 78

namespace ThirdParty.DotNet.Mono.Globalization.Unicode
{
    public class CodePointIndexer : Object
    {
        public E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5[] ranges; // 0x10
        public int TotalCount; // 0x18
        public int defaultIndex; // 0x1C
        public int defaultCP; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537B1530
        public void ToIndex(){} // RVA: 0x7FFD537B1720
    }

    public class Contraction : Object
    {
        public int Index; // 0x10
        public char[] Source; // 0x18
        public string Replacement; // 0x20
        public byte[] SortKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537B17D0
    }

    public class ContractionComparer : Object
    {
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.293D0C9535AF26B5452C6E916CE62FBBF765077BD958E69B7B9 Instance;

        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD537B18D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD537B19D0
    }

    public class Level2Map : Object
    {
        public byte Source; // 0x10
        public byte Replace; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537B1A70
    }

    public class MSCompatUnicodeTable : Object
    {
        public int IsReady;
        public IntPtr ignorableFlags; // 0x8
        public IntPtr categories; // 0x10
        public IntPtr level1; // 0x18
        public IntPtr level2; // 0x20
        public IntPtr level3; // 0x28
        public IntPtr cjkCHScategory; // 0x30
        public IntPtr cjkCHTcategory; // 0x38
        public IntPtr cjkJAcategory; // 0x40
        public IntPtr cjkKOcategory; // 0x48
        public IntPtr cjkCHSlv1; // 0x50
        public IntPtr cjkCHTlv1; // 0x58
        public IntPtr cjkJAlv1; // 0x60
        public IntPtr cjkKOlv1; // 0x68
        public IntPtr cjkKOlv2; // 0x70
        public char[] tailoringArr; // 0x78
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.AF3C51E6220BF5[] tailoringInfos; // 0x80
        public object forLock; // 0x88
        public bool isReady; // 0x90

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
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.0AC33B3C31E27 Ignorable;
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.0AC33B3C31E27 Category; // 0x8
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.0AC33B3C31E27 Level1; // 0x10
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.0AC33B3C31E27 Level2; // 0x18
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.0AC33B3C31E27 Level3; // 0x20
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.0AC33B3C31E27 CjkCHS; // 0x28
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.0AC33B3C31E27 Cjk; // 0x30

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD537B4180
    }

    public class SimpleCollator : Object
    {
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.E0CE5B8BEA476668CC2303A9845D8EC347A4035FB8 invariant;
        public 0.GetDeclaringTypeInternal textInfo; // 0x10
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.0AC33B3C31E27 cjkIndexer; // 0x18
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.AB290A5E77EE4F9223EB2E39F9B89C30C41B9D[] contractions; // 0x20
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.6E916CE62FBBF765077BD958E69B7B9[] level2Maps; // 0x28
        public byte[] unsafeFlags; // 0x30
        public IntPtr cjkCatTable; // 0x38
        public IntPtr cjkLv1Table; // 0x40
        public IntPtr cjkLv2Table; // 0x48
        public D3F08BE488F1D6DCBF05D01C69BA80DF49A9E9E415F0205D575B4B5F32A34.0AC33B3C31E27 cjkLv2Indexer; // 0x50
        public int lcid; // 0x58
        public bool frenchSort; // 0x5C

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
        public int LCID; // 0x10
        public int TailoringIndex; // 0x14
        public int TailoringCount; // 0x18
        public bool FrenchSort; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD52112960
    }

}