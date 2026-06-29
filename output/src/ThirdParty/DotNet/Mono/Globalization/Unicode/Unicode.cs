// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Globalization.Unicode
// Classes: 13
// Methods: 127

namespace ThirdParty.DotNet.Mono.Globalization.Unicode
{
    public class CodePointIndexer : Object
    {
        public object ranges;
        public object TotalCount;
        public object defaultIndex;
        public object defaultCP;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66729E0
        public void ToIndex(){} // RVA: 0x6672BD0
    }

    public class Contraction : Object
    {
        public object Index;
        public object Source;
        public object Replacement;
        public object SortKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6672C70
    }

    public class ContractionComparer : Object
    {
        public object Instance;

        // ── Methods ──
        public void Compare(){} // RVA: 0x6672D70
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6672E70
    }

    public class Contraction[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Level2Map : Object
    {
        public object Source;
        public object Replace;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6672F10
    }

    public class Level2Map[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MSCompatUnicodeTable : Object
    {
        public object MaxExpansionLength;
        public object ignorableFlags;
        public object categories;
        public object level1;
        public object level2;
        public object level3;
        public object cjkCHScategory;
        public object cjkCHTcategory;
        public object cjkJAcategory;
        public object cjkKOcategory;
        public object cjkCHSlv1;
        public object cjkCHTlv1;
        public object cjkJAlv1;
        public object cjkKOlv1;
        public object cjkKOlv2;
        public object tailoringArr;
        public object tailoringInfos;
        public object forLock;
        public object isReady;

        // ── Methods ──
        public void GetTailoringInfo(){} // RVA: 0x6672F20
        public void BuildTailoringTables(){} // RVA: 0x6673040
        public void SetCJKReferences(){} // RVA: 0x6673820
        public void Category(){} // RVA: 0x6673C90
        public void Level1(){} // RVA: 0x6673D50
        public void Level2(){} // RVA: 0x6673E10
        public void Level3(){} // RVA: 0x6673ED0
        public void IsIgnorable(){} // RVA: 0x6673F90
        public void IsIgnorableNonSpacing(){} // RVA: 0x66740C0
        public void ToKanaTypeInsensitive(){} // RVA: 0x6674110
        public void ToWidthCompat(){} // RVA: 0x6674130
        public void HasSpecialWeight(){} // RVA: 0x66742B0
        public void IsHalfWidthKana(){} // RVA: 0x6674320
        public void IsHiragana(){} // RVA: 0x6674340
        public void IsJapaneseSmallLetter(){} // RVA: 0x6674360
        public void get_IsReady(){} // RVA: 0x66744D0
        public void GetResource(){} // RVA: 0x6674530
        public void UInt32FromBytePtr(){} // RVA: 0x66745E0
        public void .cctor(){} // RVA: 0x6674620
        public void FillCJK(){} // RVA: 0x6674CA0
        public void FillCJKCore(){} // RVA: 0x6674EA0
    }

    public class MSCompatUnicodeTableUtil : Object
    {
        public object Ignorable;
        public object Category;
        public object Level1;
        public object Level2;
        public object Level3;
        public object CjkCHS;
        public object Cjk;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6675650
    }

    public class NormalizationTableUtil : Object
    {
        public object Prop;
        public object Map;
        public object Combining;
        public object Composite;
        public object Helper;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6675E40
        public void PropIdx(){} // RVA: 0x66763D0
        public void MapIdx(){} // RVA: 0x6676440
    }

    public class SimpleCollator : Object
    {
        public object invariant;
        public object textInfo;
        public object cjkIndexer;
        public object contractions;
        public object level2Maps;
        public object unsafeFlags;
        public object cjkCatTable;
        public object cjkLv1Table;
        public object cjkLv2Table;
        public object cjkLv2Indexer;
        public object lcid;
        public object frenchSort;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66764B0
        public void SetCJKTable(){} // RVA: 0x6676A00
        public void GetNeutralCulture(){} // RVA: 0x6676B70
        public void Category(){} // RVA: 0x6676C10
        public void Level1(){} // RVA: 0x6676CB0
        public void Level2(){} // RVA: 0x6676D50
        public void IsHalfKana(){} // RVA: 0x6676EF0
        public void GetContraction(){} // RVA: 0x6677060
        public void GetTailContraction(){} // RVA: 0x6677290
        public void FilterOptions(){} // RVA: 0x66774C0
        public void GetExtenderType(){} // RVA: 0x6677770
        public void ToDashTypeValue(){} // RVA: 0x6677830
        public void FilterExtender(){} // RVA: 0x6677850
        public void IsIgnorable(){} // RVA: 0x6677A10
        public void IsSafe(){} // RVA: 0x6677AA0
        public void GetSortKey(){} // RVA: 0x6677CF0
        public void FillSortKeyRaw(){} // RVA: 0x6678060
        public void FillSurrogateSortKeyRaw(){} // RVA: 0x66785B0
        public void System.Globalization.ISimpleCollator.Compare(){} // RVA: 0x6678680
        public void Compare(){} // RVA: 0x6678690
        public void ClearBuffer(){} // RVA: 0x6678790
        public void CompareInternal(){} // RVA: 0x66787B0
        public void CompareFlagPair(){} // RVA: 0x6679CE0
        public void IsPrefix(){} // RVA: 0x6679E40
        public void IsSuffix(){} // RVA: 0x6679F80
        public void QuickIndexOf(){} // RVA: 0x667A040
        public void IndexOf(){} // RVA: 0x667A750
        public void IndexOfOrdinal(){} // RVA: 0x667A610
        public void IndexOfSortKey(){} // RVA: 0x667A690
        public void LastIndexOf(){} // RVA: 0x667B0D0
        public void LastIndexOfOrdinal(){} // RVA: 0x667AE50
        public void LastIndexOfSortKey(){} // RVA: 0x667B000
        public void MatchesForward(){} // RVA: 0x667B630
        public void MatchesForwardCore(){} // RVA: 0x667B810
        public void MatchesPrimitive(){} // RVA: 0x667BC60
        public void MatchesBackward(){} // RVA: 0x667BE40
        public void MatchesBackwardCore(){} // RVA: 0x667C030
        public void .cctor(){} // RVA: 0x667C630
    }

    public class SortKeyBuffer : Object
    {
        public object l1b;
        public object l2b;
        public object l3b;
        public object l4sb;
        public object l4tb;
        public object l4kb;
        public object l4wb;
        public object l5b;
        public object source;
        public object l1;
        public object l2;
        public object l3;
        public object l4s;
        public object l4t;
        public object l4k;
        public object l4w;
        public object l5;
        public object lcid;
        public object options;
        public object processLevel2;
        public object frenchSort;
        public object frenchSorted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Reset(){} // RVA: 0x667C7A0
        public void Initialize(){} // RVA: 0x667C7C0
        public void AppendCJKExtension(){} // RVA: 0x667CC30
        public void AppendKana(){} // RVA: 0x667CD00
        public void AppendNormal(){} // RVA: 0x667CDD0
        public void AppendLevel5(){} // RVA: 0x667CFC0
        public void AppendBufferPrimitive(){} // RVA: 0x667D0A0
        public void GetResultAndReset(){} // RVA: 0x667D270
        public void GetOptimizedLength(){} // RVA: 0x667D2A0
        public void GetResult(){} // RVA: 0x667D2F0
    }

    public class TailoringInfo : Object
    {
        public object LCID;
        public object TailoringIndex;
        public object TailoringCount;
        public object FrenchSort;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F3B900
    }

    public class TailoringInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}