// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Globalization.Unicode
// Classes: 10
// Methods: 92

namespace ThirdParty.DotNet.Mono.Globalization.Unicode
{
    public class CodePointIndexer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8673AE30
        public void ToIndex(){} // RVA: 0x7FFE8673B020
    }

    public class Contraction : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8673B0D0
    }

    public class ContractionComparer : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE8673B1D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8673B2D0
    }

    public class Level2Map : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8673B370
    }

    public class MSCompatUnicodeTable : Object
    {
        public int MaxExpansionLength;

        // ── Methods ──
        public void GetTailoringInfo(){} // RVA: 0x7FFE8673B380
        public void BuildTailoringTables(){} // RVA: 0x7FFE8673B490
        public void SetCJKReferences(){} // RVA: 0x7FFE8673BC80
        public void Category(){} // RVA: 0x7FFE8673C0F0
        public void Level1(){} // RVA: 0x7FFE8673C1B0
        public void Level2(){} // RVA: 0x7FFE8673C270
        public void Level3(){} // RVA: 0x7FFE8673C330
        public void IsIgnorable(){} // RVA: 0x7FFE8673C3F0
        public void IsIgnorableNonSpacing(){} // RVA: 0x7FFE8673C530
        public void ToKanaTypeInsensitive(){} // RVA: 0x7FFE8673C580
        public void ToWidthCompat(){} // RVA: 0x7FFE8673C5A0
        public void HasSpecialWeight(){} // RVA: 0x7FFE8673C720
        public void IsHalfWidthKana(){} // RVA: 0x7FFE8673C790
        public void IsHiragana(){} // RVA: 0x7FFE8673C7B0
        public void IsJapaneseSmallLetter(){} // RVA: 0x7FFE8673C7D0
        public void get_IsReady(){} // RVA: 0x7FFE8673C930
        public void GetResource(){} // RVA: 0x7FFE8673C990
        public void UInt32FromBytePtr(){} // RVA: 0x7FFE8673CA40
        public void .cctor(){} // RVA: 0x7FFE8673CA80
        public void FillCJK(){} // RVA: 0x7FFE8673D0B0
        public void FillCJKCore(){} // RVA: 0x7FFE8673D2D0
    }

    public class MSCompatUnicodeTableUtil : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8673DA80
    }

    public class NormalizationTableUtil : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8673E270
        public void PropIdx(){} // RVA: 0x7FFE8673E820
        public void MapIdx(){} // RVA: 0x7FFE8673E890
    }

    public class SimpleCollator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8673E900
        public void SetCJKTable(){} // RVA: 0x7FFE8673EE60
        public void GetNeutralCulture(){} // RVA: 0x7FFE8673EFD0
        public void Category(){} // RVA: 0x7FFE8673F070
        public void Level1(){} // RVA: 0x7FFE8673F110
        public void Level2(){} // RVA: 0x7FFE8673F1B0
        public void IsHalfKana(){} // RVA: 0x7FFE8673F350
        public void GetContraction(){} // RVA: 0x7FFE8673F4C0 | overloaded x2
        public void GetTailContraction(){} // RVA: 0x7FFE8673F6E0 | overloaded x2
        public void FilterOptions(){} // RVA: 0x7FFE8673F920
        public void GetExtenderType(){} // RVA: 0x7FFE8673FBC0
        public void ToDashTypeValue(){} // RVA: 0x7FFE8673FC80
        public void FilterExtender(){} // RVA: 0x7FFE8673FCA0
        public void IsIgnorable(){} // RVA: 0x7FFE8673FE50
        public void IsSafe(){} // RVA: 0x7FFE8673FEE0
        public void GetSortKey(){} // RVA: 0x7FFE86740140 | overloaded x3
        public void FillSortKeyRaw(){} // RVA: 0x7FFE867404C0
        public void FillSurrogateSortKeyRaw(){} // RVA: 0x7FFE86740A20
        public void System.Globalization.ISimpleCollator.Compare(){} // RVA: 0x7FFE86740AF0
        public void Compare(){} // RVA: 0x7FFE86740B00
        public void ClearBuffer(){} // RVA: 0x7FFE86740C00
        public void CompareInternal(){} // RVA: 0x7FFE86740C20
        public void CompareFlagPair(){} // RVA: 0x7FFE86742170
        public void IsPrefix(){} // RVA: 0x7FFE867422D0 | overloaded x3
        public void IsSuffix(){} // RVA: 0x7FFE86742410 | overloaded x2
        public void QuickIndexOf(){} // RVA: 0x7FFE867424D0
        public void IndexOf(){} // RVA: 0x7FFE86742BC0 | overloaded x2
        public void IndexOfOrdinal(){} // RVA: 0x7FFE86742A80 | overloaded x2
        public void IndexOfSortKey(){} // RVA: 0x7FFE86742B00
        public void LastIndexOf(){} // RVA: 0x7FFE86743540 | overloaded x2
        public void LastIndexOfOrdinal(){} // RVA: 0x7FFE867432C0
        public void LastIndexOfSortKey(){} // RVA: 0x7FFE86743470
        public void MatchesForward(){} // RVA: 0x7FFE86743AB0
        public void MatchesForwardCore(){} // RVA: 0x7FFE86743C90
        public void MatchesPrimitive(){} // RVA: 0x7FFE867440E0
        public void MatchesBackward(){} // RVA: 0x7FFE867442C0
        public void MatchesBackwardCore(){} // RVA: 0x7FFE867444B0
        public void .cctor(){} // RVA: 0x7FFE86744AB0
    }

    public class SortKeyBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Reset(){} // RVA: 0x7FFE86744C20
        public void Initialize(){} // RVA: 0x7FFE86744C40
        public void AppendCJKExtension(){} // RVA: 0x7FFE867450B0
        public void AppendKana(){} // RVA: 0x7FFE86745180
        public void AppendNormal(){} // RVA: 0x7FFE86745250
        public void AppendLevel5(){} // RVA: 0x7FFE86745440
        public void AppendBufferPrimitive(){} // RVA: 0x7FFE86745520
        public void GetResultAndReset(){} // RVA: 0x7FFE867456F0
        public void GetOptimizedLength(){} // RVA: 0x7FFE86745720
        public void GetResult(){} // RVA: 0x7FFE86745770
    }

    public class TailoringInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE85078DD0
    }

}