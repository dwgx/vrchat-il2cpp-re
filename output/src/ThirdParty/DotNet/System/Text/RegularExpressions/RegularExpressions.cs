// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.RegularExpressions
// Classes: 32
// Methods: 508

namespace ThirdParty.DotNet.System.Text.RegularExpressions
{
    public class Capture : Object
    {
        public object _index;
        public object _length;
        public object _text;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x765D6F0
        public void get_Index(){} // RVA: 0xB8F8F0
        public void set_Index(){} // RVA: 0xB460A0
        public void get_Length(){} // RVA: 0x116A650
        public void set_Length(){} // RVA: 0x116BB10
        public void get_Text(){} // RVA: 0xB465B0
        public void set_Text(){} // RVA: 0xBA9BA0
        public void get_Value(){} // RVA: 0x765D570
        public void ToString(){} // RVA: 0x765D570
        public void GetLeftSubstring(){} // RVA: 0x765D5A0
        public void GetRightSubstring(){} // RVA: 0x765D630
    }

    public class CaptureCollection : Object
    {
        public object _group;
        public object _capcount;
        public object _captures;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x765E600
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_Count(){} // RVA: 0xE62D00
        public void get_Item(){} // RVA: 0x765D790
        public void GetEnumerator(){} // RVA: 0x765D850
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator(){} // RVA: 0x765D8F0
        public void GetCapture(){} // RVA: 0x765D790
        public void ForceInitialized(){} // RVA: 0x765D990
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0xB5DBF0
        public void CopyTo(){} // RVA: 0x765DCE0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(){} // RVA: 0x765DF00
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(){} // RVA: 0x765DFB0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(){} // RVA: 0x765E000
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(){} // RVA: 0x765E050
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(){} // RVA: 0x765E060
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(){} // RVA: 0x765E0B0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear(){} // RVA: 0x765E100
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(){} // RVA: 0x765E150
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(){} // RVA: 0x765E1B0
        public void System.Collections.IList.Add(){} // RVA: 0x765E200
        public void System.Collections.IList.Clear(){} // RVA: 0x765E250
        public void System.Collections.IList.Contains(){} // RVA: 0x765E2A0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x765E3F0
        public void System.Collections.IList.Insert(){} // RVA: 0x765E4C0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xC2E4C0
        public void System.Collections.IList.Remove(){} // RVA: 0x765E510
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x765E560
        public void System.Collections.IList.get_Item(){} // RVA: 0x765E050
        public void System.Collections.IList.set_Item(){} // RVA: 0x765E5B0
    }

    public class Capture[] : Array
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

    public class ExclusiveReference : Object
    {
        public object _ref;
        public object _obj;
        public object _locked;

        // ── Methods ──
        public void Get(){} // RVA: 0x7662360
        public void Release(){} // RVA: 0x76623E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Group : Capture
    {
        public object s_emptyGroup;
        public object _caps;
        public object _capcount;
        public object _capcoll;
        public object _name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x765EB70
        public void get_Success(){} // RVA: 0x765E8A0
        public void get_Name(){} // RVA: 0xD05CA0
        public void get_Captures(){} // RVA: 0x765E8B0
        public void Synchronized(){} // RVA: 0x765E9C0
        public void .cctor(){} // RVA: 0x765EA50
    }

    public class GroupCollection : Object
    {
        public object _match;
        public object _captureMap;
        public object _groups;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x765FF10
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_Count(){} // RVA: 0x765EBA0
        public void get_Item(){} // RVA: 0x765EBE0
        public void GetEnumerator(){} // RVA: 0x765EC90
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator(){} // RVA: 0x765ED30
        public void GetGroup(){} // RVA: 0x765EDD0
        public void GetGroupImpl(){} // RVA: 0x765F1B0
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0xB5DBF0
        public void CopyTo(){} // RVA: 0x765F5A0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(){} // RVA: 0x765F7F0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(){} // RVA: 0x765F8D0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(){} // RVA: 0x765F920
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(){} // RVA: 0x765EBD0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(){} // RVA: 0x765F970
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(){} // RVA: 0x765F9C0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear(){} // RVA: 0x765FA10
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(){} // RVA: 0x765FA60
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(){} // RVA: 0x765FAC0
        public void System.Collections.IList.Add(){} // RVA: 0x765FB10
        public void System.Collections.IList.Clear(){} // RVA: 0x765FB60
        public void System.Collections.IList.Contains(){} // RVA: 0x765FBB0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x765FD00
        public void System.Collections.IList.Insert(){} // RVA: 0x765FDD0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xC2E4C0
        public void System.Collections.IList.Remove(){} // RVA: 0x765FE20
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x765FE70
        public void System.Collections.IList.get_Item(){} // RVA: 0x765EBD0
        public void System.Collections.IList.set_Item(){} // RVA: 0x765FEC0
    }

    public class Group[] : Array
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

    public class Match : Group
    {
        public object _groupcoll;
        public object _regex;
        public object _textbeg;
        public object _textpos;
        public object _textend;
        public object _textstart;
        public object _matches;
        public object _matchcount;
        public object _balancing;
        public object _empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7661140
        public void get_Empty(){} // RVA: 0x7660260
        public void Reset(){} // RVA: 0x76602C0
        public void get_Groups(){} // RVA: 0x76603F0
        public void NextMatch(){} // RVA: 0x76604A0
        public void Result(){} // RVA: 0x76604F0
        public void GroupToStringImpl(){} // RVA: 0x76605F0
        public void LastGroupToStringImpl(){} // RVA: 0x7660790
        public void Synchronized(){} // RVA: 0x76607E0
        public void AddMatch(){} // RVA: 0x7660970
        public void BalanceMatch(){} // RVA: 0x7660B50
        public void RemoveMatch(){} // RVA: 0x7660CA0
        public void IsMatched(){} // RVA: 0x7660CD0
        public void MatchIndex(){} // RVA: 0x7660D50
        public void MatchLength(){} // RVA: 0x7660DE0
        public void Tidy(){} // RVA: 0x7660E70
        public void .cctor(){} // RVA: 0x7661060
    }

    public class MatchCollection : Object
    {
        public object _regex;
        public object _matches;
        public object _done;
        public object _input;
        public object _beginning;
        public object _length;
        public object _startat;
        public object _prevlen;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7662260
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_Count(){} // RVA: 0x7661560
        public void get_Item(){} // RVA: 0x76615C0
        public void GetEnumerator(){} // RVA: 0x7661670
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator(){} // RVA: 0x7661710
        public void GetMatch(){} // RVA: 0x76617B0
        public void EnsureInitialized(){} // RVA: 0x7661950
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x2303260
        public void CopyTo(){} // RVA: 0x76619F0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(){} // RVA: 0x7661A80
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(){} // RVA: 0x7661B20
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(){} // RVA: 0x7661B70
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(){} // RVA: 0x7661BC0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(){} // RVA: 0x7661BE0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(){} // RVA: 0x7661C30
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear(){} // RVA: 0x7661C80
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(){} // RVA: 0x7661CD0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(){} // RVA: 0x7661D90
        public void System.Collections.IList.Add(){} // RVA: 0x7661DE0
        public void System.Collections.IList.Clear(){} // RVA: 0x7661E30
        public void System.Collections.IList.Contains(){} // RVA: 0x7661E80
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7661FD0
        public void System.Collections.IList.Insert(){} // RVA: 0x7662120
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xC2E4C0
        public void System.Collections.IList.Remove(){} // RVA: 0x7662170
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x76621C0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7661BC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7662210
    }

    public class MatchEvaluator : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23F1A30
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class MatchSparse : Match
    {
        public object _caps;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7661170
        public void get_Groups(){} // RVA: 0x7661270
    }

    public class Match[] : Array
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

    public class Regex : Object
    {
        public object CacheDictionarySwitchLimit;
        public object s_cacheSize;
        public object s_cache;
        public object s_cacheCount;
        public object s_cacheFirst;
        public object s_cacheLast;
        public object s_maximumMatchTimeout;
        public object DefaultMatchTimeout_ConfigKeyName;
        public object s_defaultMatchTimeout;
        public object InfiniteMatchTimeout;
        public object internalMatchTimeout;
        public object MaxOptionShift;
        public object pattern;
        public object roptions;
        public object factory;
        public object caps;
        public object capnames;
        public object capslist;
        public object capsize;
        public object _runnerref;
        public object _replref;
        public object _code;
        public object _refsInitialized;

        // ── Methods ──
        public void get_CacheSize(){} // RVA: 0x76624F0
        public void set_CacheSize(){} // RVA: 0x7662550
        public void GetCachedCode(){} // RVA: 0x7662920
        public void GetCachedCodeEntryInternal(){} // RVA: 0x7662AE0
        public void FillCacheDictionary(){} // RVA: 0x76632F0
        public void TryGetCacheValue(){} // RVA: 0x7663470
        public void TryGetCacheValueSmall(){} // RVA: 0x7663570
        public void LookupCachedAndPromote(){} // RVA: 0x7663770
        public void IsMatch(){} // RVA: 0x7664170
        public void Match(){} // RVA: 0x7664570
        public void Matches(){} // RVA: 0x76648D0
        public void Replace(){} // RVA: 0x7665500
        public void Split(){} // RVA: 0x7665F50
        public void .cctor(){} // RVA: 0x7666630
        public void get_MatchTimeout(){} // RVA: 0xB5DBF0
        public void ValidateMatchTimeout(){} // RVA: 0x7666840
        public void InitDefaultMatchTimeout(){} // RVA: 0x7666980
        public void .ctor(){} // RVA: 0x7666DA0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7666D60
        public void Escape(){} // RVA: 0x76672D0
        public void Unescape(){} // RVA: 0x7667370
        public void get_Options(){} // RVA: 0xFEAE90
        public void get_RightToLeft(){} // RVA: 0x64E4840
        public void ToString(){} // RVA: 0xB465B0
        public void GetGroupNames(){} // RVA: 0x7667410
        public void GetGroupNumbers(){} // RVA: 0x7667620
        public void GroupNameFromNumber(){} // RVA: 0x7667940
        public void GroupNumberFromName(){} // RVA: 0x7667A60
        public void InitializeReferences(){} // RVA: 0x7667B90
        public void Run(){} // RVA: 0x7667D30
        public void UseOptionR(){} // RVA: 0x64E4840
        public void UseOptionInvariant(){} // RVA: 0x64E47A0
    }

    public class RegexBoyerMoore : Object
    {
        public object Positive;
        public object NegativeASCII;
        public object NegativeUnicode;
        public object Pattern;
        public object LowASCII;
        public object HighASCII;
        public object RightToLeft;
        public object CaseInsensitive;
        public object _culture;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76686C0
        public void MatchPattern(){} // RVA: 0x7668E50
        public void IsMatch(){} // RVA: 0x7668FB0
        public void Scan(){} // RVA: 0x7669020
    }

    public class RegexCharClass : Object
    {
        public object s_internalRegexIgnoreCase;
        public object s_space;
        public object s_notSpace;
        public object s_word;
        public object s_notWord;
        public object SpaceClass;
        public object NotSpaceClass;
        public object WordClass;
        public object NotWordClass;
        public object DigitClass;
        public object NotDigitClass;
        public object s_definedCategories;
        public object s_propTable;
        public object s_lcTable;
        public object _rangelist;
        public object _categories;
        public object _canonical;
        public object _negate;
        public object _subtractor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76695A0
        public void get_CanMerge(){} // RVA: 0x76696C0
        public void set_Negate(){} // RVA: 0x1AD91E0
        public void AddChar(){} // RVA: 0x76696E0
        public void AddCharClass(){} // RVA: 0x76696F0
        public void AddSet(){} // RVA: 0x7669950
        public void AddSubtraction(){} // RVA: 0xB44DC0
        public void AddRange(){} // RVA: 0x7669BB0
        public void AddCategoryFromName(){} // RVA: 0x7669CE0
        public void AddCategory(){} // RVA: 0x766A0A0
        public void AddLowercase(){} // RVA: 0x766A0C0
        public void AddLowercaseRange(){} // RVA: 0x766A260
        public void AddWord(){} // RVA: 0x766A4C0
        public void AddSpace(){} // RVA: 0x766A600
        public void AddDigit(){} // RVA: 0x766A740
        public void SingletonChar(){} // RVA: 0x766A800
        public void IsMergeable(){} // RVA: 0x766A830
        public void IsEmpty(){} // RVA: 0x766A8E0
        public void IsSingleton(){} // RVA: 0x766A980
        public void IsSingletonInverse(){} // RVA: 0x766AA60
        public void IsSubtraction(){} // RVA: 0x766AB40
        public void IsNegated(){} // RVA: 0x766AB80
        public void IsECMAWordChar(){} // RVA: 0x766ABB0
        public void IsWordChar(){} // RVA: 0x766AC60
        public void CharInClass(){} // RVA: 0x766AD30
        public void CharInClassRecursive(){} // RVA: 0x766ADA0
        public void CharInClassInternal(){} // RVA: 0x766AEF0
        public void CharInCategory(){} // RVA: 0x766B100
        public void CharInCategoryGroup(){} // RVA: 0x766B280
        public void NegateCategory(){} // RVA: 0x766B350
        public void Parse(){} // RVA: 0x766B460
        public void ParseRecursive(){} // RVA: 0x766B4C0
        public void RangeCount(){} // RVA: 0x766B860
        public void ToStringClass(){} // RVA: 0x766B8B0
        public void GetRangeAt(){} // RVA: 0x766BB80
        public void Canonicalize(){} // RVA: 0x766BBF0
        public void SetFromProperty(){} // RVA: 0x766BF20
        public void .cctor(){} // RVA: 0x766C1F0
    }

    public class RegexCode : Object
    {
        public object Onerep;
        public object Notonerep;
        public object Setrep;
        public object Oneloop;
        public object Notoneloop;
        public object Setloop;
        public object Onelazy;
        public object Notonelazy;
        public object Setlazy;
        public object One;
        public object Notone;
        public object Set;
        public object Multi;
        public object Ref;
        public object Bol;
        public object Eol;
        public object Boundary;
        public object Nonboundary;
        public object Beginning;
        public object Start;
        public object EndZ;
        public object End;
        public object Nothing;
        public object Lazybranch;
        public object Branchmark;
        public object Lazybranchmark;
        public object Nullcount;
        public object Setcount;
        public object Branchcount;
        public object Lazybranchcount;
        public object Nullmark;
        public object Setmark;
        public object Capturemark;
        public object Getmark;
        public object Setjump;
        public object Backjump;
        public object Forejump;
        public object Testref;
        public object Goto;
        public object Prune;
        public object Stop;
        public object ECMABoundary;
        public object NonECMABoundary;
        public object Mask;
        public object Rtl;
        public object Back;
        public object Back2;
        public object Ci;
        public object Codes;
        public object Strings;
        public object TrackCount;
        public object Caps;
        public object CapSize;
        public object FCPrefix;
        public object BMPrefix;
        public object Anchors;
        public object RightToLeft;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76715A0
        public void OpcodeBacktracks(){} // RVA: 0x7671800
    }

    public class RegexFC : Object
    {
        public object _cc;
        public object _nullable;
        public object _caseInsensitive;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76731C0
        public void AddFC(){} // RVA: 0x76732C0
        public void get_CaseInsensitive(){} // RVA: 0xF43F30
        public void set_CaseInsensitive(){} // RVA: 0x17F4D80
        public void GetFirstChars(){} // RVA: 0x7673350
    }

    public class RegexFCD : ValueType
    {
        public object _fcStack;
        public object _intStack;
        public object _skipAllChildren;
        public object _skipchild;
        public object _failed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7671860
        public void FirstChars(){} // RVA: 0x7671980
        public void Prefix(){} // RVA: 0x7671D30
        public void Anchors(){} // RVA: 0x7672060
        public void AnchorFromType(){} // RVA: 0x7672310
        public void PushInt(){} // RVA: 0x7672390
        public void IntIsEmpty(){} // RVA: 0x76723E0
        public void PopInt(){} // RVA: 0x7672420
        public void PushFC(){} // RVA: 0x7672470
        public void FCIsEmpty(){} // RVA: 0x7672510
        public void PopFC(){} // RVA: 0x7672560
        public void TopFC(){} // RVA: 0x76725E0
        public void Dispose(){} // RVA: 0x7672670
        public void RegexFCFromRegexTree(){} // RVA: 0x76726B0
        public void SkipChild(){} // RVA: 0x75DEF00
        public void CalculateFC(){} // RVA: 0x7672940
    }

    public class RegexFC[] : Array
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

    public class RegexInterpreter : RegexRunner
    {
        public object _code;
        public object _culture;
        public object _operator;
        public object _codepos;
        public object _rightToLeft;
        public object _caseInsensitive;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7673390
        public void InitTrackCount(){} // RVA: 0x7673450
        public void Advance(){} // RVA: 0x7673480
        public void Goto(){} // RVA: 0x7673500
        public void Textto(){} // RVA: 0x13233D0
        public void Trackto(){} // RVA: 0x7673590
        public void Textstart(){} // RVA: 0xE62D00
        public void Textpos(){} // RVA: 0x1065D50
        public void Trackpos(){} // RVA: 0x76735B0
        public void TrackPush(){} // RVA: 0x7673710
        public void TrackPush2(){} // RVA: 0x7673830
        public void Backtrack(){} // RVA: 0x76738C0
        public void SetOperator(){} // RVA: 0x76739A0
        public void TrackPop(){} // RVA: 0x76739E0
        public void TrackPeek(){} // RVA: 0x7673A20
        public void StackPush(){} // RVA: 0x7673AA0
        public void StackPop(){} // RVA: 0x7673B00
        public void StackPeek(){} // RVA: 0x7673B40
        public void Operator(){} // RVA: 0xF3A950
        public void Operand(){} // RVA: 0x7673B80
        public void Leftchars(){} // RVA: 0x7673BD0
        public void Rightchars(){} // RVA: 0x7673BE0
        public void Bump(){} // RVA: 0x7673BF0
        public void Forwardchars(){} // RVA: 0x7673C10
        public void Forwardcharnext(){} // RVA: 0x7673C30
        public void Stringmatch(){} // RVA: 0x7673CF0
        public void Refmatch(){} // RVA: 0x7673E80
        public void Backwardnext(){} // RVA: 0x7674070
        public void CharAt(){} // RVA: 0x7674090
        public void FindFirstChar(){} // RVA: 0x76740D0
        public void Go(){} // RVA: 0x7674560
    }

    public class RegexMatchTimeoutException : TimeoutException
    {
        public object _input;
        public object _pattern;
        public object _matchTimeout;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7676C70
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7676F60
        public void get_Input(){} // RVA: 0x1069350
        public void get_Pattern(){} // RVA: 0x106A7D0
        public void get_MatchTimeout(){} // RVA: 0x106A050
    }

    public class RegexNode : Object
    {
        public object NType;
        public object Children;
        public object Str;
        public object Ch;
        public object M;
        public object N;
        public object Options;
        public object Next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7677480
        public void UseOptionR(){} // RVA: 0x76774A0
        public void ReverseLeft(){} // RVA: 0x76774B0
        public void MakeRep(){} // RVA: 0x7677560
        public void Reduce(){} // RVA: 0x7677570
        public void StripEnation(){} // RVA: 0x7677690
        public void ReduceGroup(){} // RVA: 0x7677740
        public void ReduceRep(){} // RVA: 0x76777D0
        public void ReduceSet(){} // RVA: 0x76779B0
        public void ReduceAlternation(){} // RVA: 0x7677DE0
        public void ReduceConcatenation(){} // RVA: 0x7678240
        public void MakeQuantifier(){} // RVA: 0x7678680
        public void AddChild(){} // RVA: 0x7678770
        public void Child(){} // RVA: 0x7678A90
        public void ChildCount(){} // RVA: 0x7678B10
        public void Type(){} // RVA: 0xB8F8F0
    }

    public class RegexNode[] : Array
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

    public class RegexOptions[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RegexParser : Object
    {
        public object _stack;
        public object _group;
        public object _alternation;
        public object _concatenation;
        public object _unit;
        public object _pattern;
        public object _currentPos;
        public object _culture;
        public object _autocap;
        public object _capcount;
        public object _captop;
        public object _capsize;
        public object _caps;
        public object _capnames;
        public object _capnumlist;
        public object _capnamelist;
        public object _options;
        public object _optionsStack;
        public object _ignoreNextParen;
        public object s_category;

        // ── Methods ──
        public void Parse(){} // RVA: 0x7678B60
        public void ParseReplacement(){} // RVA: 0x7678EC0
        public void Escape(){} // RVA: 0x7679150
        public void Unescape(){} // RVA: 0x7679380
        public void .ctor(){} // RVA: 0x7679560
        public void SetPattern(){} // RVA: 0x7679700
        public void Reset(){} // RVA: 0x7679780
        public void ScanRegex(){} // RVA: 0x76798B0
        public void ScanReplacement(){} // RVA: 0x767A150
        public void ScanCharClass(){} // RVA: 0x767A3B0
        public void ScanGroupOpen(){} // RVA: 0x767AC40
        public void ScanBlank(){} // RVA: 0x767B880
        public void ScanBackslash(){} // RVA: 0x767BC20
        public void ScanBasicBackslash(){} // RVA: 0x767C200
        public void ScanDollar(){} // RVA: 0x767C8F0
        public void ScanCapname(){} // RVA: 0x767CD20
        public void ScanOctal(){} // RVA: 0x767CDF0
        public void ScanDecimal(){} // RVA: 0x767CE90
        public void ScanHex(){} // RVA: 0x767CF40
        public void HexDigit(){} // RVA: 0x767D070
        public void ScanControl(){} // RVA: 0x767D0B0
        public void IsOnlyTopOption(){} // RVA: 0x767D190
        public void ScanOptions(){} // RVA: 0x767D1B0
        public void ScanCharEscape(){} // RVA: 0x767D2D0
        public void ParseProperty(){} // RVA: 0x767D690
        public void TypeFromCode(){} // RVA: 0x767D880
        public void OptionFromCode(){} // RVA: 0x767D900
        public void CountCaptures(){} // RVA: 0x767D9A0
        public void NoteCaptureSlot(){} // RVA: 0x767DD40
        public void NoteCaptureName(){} // RVA: 0x767DE30
        public void NoteCaptures(){} // RVA: 0x767E080
        public void AssignNameSlots(){} // RVA: 0x767E140
        public void CaptureSlotFromName(){} // RVA: 0x767E9F0
        public void IsCaptureSlot(){} // RVA: 0x767EA50
        public void IsCaptureName(){} // RVA: 0x767EAC0
        public void UseOptionN(){} // RVA: 0x767EAF0
        public void UseOptionI(){} // RVA: 0x767EB00
        public void UseOptionM(){} // RVA: 0x767EB10
        public void UseOptionS(){} // RVA: 0x767EB20
        public void UseOptionX(){} // RVA: 0x767EB30
        public void UseOptionE(){} // RVA: 0x767EB40
        public void IsSpecial(){} // RVA: 0x767EB50
        public void IsStopperX(){} // RVA: 0x767EBE0
        public void IsQuantifier(){} // RVA: 0x767EC70
        public void IsTrueQuantifier(){} // RVA: 0x767ED00
        public void IsSpace(){} // RVA: 0x767EEC0
        public void IsMetachar(){} // RVA: 0x767EF50
        public void AddConcatenate(){} // RVA: 0x767F9B0
        public void PushGroup(){} // RVA: 0x767F2E0
        public void PopGroup(){} // RVA: 0x767F470
        public void EmptyStack(){} // RVA: 0x1825040
        public void StartGroup(){} // RVA: 0x767F6B0
        public void AddAlternate(){} // RVA: 0x767F830
        public void Unit(){} // RVA: 0xD33E60
        public void AddUnitOne(){} // RVA: 0x767FB20
        public void AddUnitNotone(){} // RVA: 0x767FC30
        public void AddUnitSet(){} // RVA: 0x767FD40
        public void AddUnitNode(){} // RVA: 0xB708C0
        public void AddUnitType(){} // RVA: 0x767FE50
        public void AddGroup(){} // RVA: 0x767FF10
        public void PushOptions(){} // RVA: 0x76800D0
        public void PopOptions(){} // RVA: 0x7680170
        public void EmptyOptionsStack(){} // RVA: 0x7680230
        public void PopKeepOptions(){} // RVA: 0x7680280
        public void MakeException(){} // RVA: 0x76802F0
        public void Textpos(){} // RVA: 0xBE5850
        public void Textto(){} // RVA: 0xBE5860
        public void RightCharMoveRight(){} // RVA: 0x7680380
        public void MoveRight(){} // RVA: 0x76803D0
        public void MoveLeft(){} // RVA: 0x76803E0
        public void CharAt(){} // RVA: 0x76803F0
        public void RightChar(){} // RVA: 0x7680470
        public void CharsRight(){} // RVA: 0x76804B0
        public void .cctor(){} // RVA: 0x76804D0
    }

    public class RegexPrefix : ValueType
    {
        public object _caseInsensitive;
        public object _empty;
        public object _prefix;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x91DF80
        public void get_CaseInsensitive(){} // RVA: 0x90520
        public void get_Empty(){} // RVA: 0x7680610
        public void get_Prefix(){} // RVA: 0x77ED0
        public void .cctor(){} // RVA: 0x7680670
    }

    public class RegexReplacement : Object
    {
        public object Specials;
        public object LeftPortion;
        public object RightPortion;
        public object LastGroup;
        public object WholeString;
        public object _strings;
        public object _rules;
        public object _pattern;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7680780
        public void GetOrCreate(){} // RVA: 0x7680CA0
        public void get_Pattern(){} // RVA: 0xB700F0
        public void ReplacementImpl(){} // RVA: 0x7680DE0
        public void ReplacementImplRTL(){} // RVA: 0x7681040
        public void Replacement(){} // RVA: 0x7681290
        public void Replace(){} // RVA: 0x7681530
    }

    public class RegexRunner : Object
    {
        public object runtextbeg;
        public object runtextend;
        public object runtextstart;
        public object runtext;
        public object runtextpos;
        public object runtrack;
        public object runtrackpos;
        public object runstack;
        public object runstackpos;
        public object runcrawl;
        public object runcrawlpos;
        public object runtrackcount;
        public object runmatch;
        public object runregex;
        public object _timeout;
        public object _ignoreTimeout;
        public object _timeoutOccursAt;
        public object TimeoutCheckFrequency;
        public object _timeoutChecksToSkip;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Scan(){} // RVA: 0x7681DB0
        public void StartTimeoutWatch(){} // RVA: 0x7682160
        public void CheckTimeout(){} // RVA: 0x7682190
        public void DoCheckTimeout(){} // RVA: 0x7682270
        public void Go(){} // RVA: 0x894290
        public void FindFirstChar(){} // RVA: 0x87D280
        public void InitTrackCount(){} // RVA: 0x894290
        public void InitMatch(){} // RVA: 0x7682350
        public void TidyMatch(){} // RVA: 0x76827F0
        public void EnsureStorage(){} // RVA: 0x76828A0
        public void IsBoundary(){} // RVA: 0x7682A90
        public void IsECMABoundary(){} // RVA: 0x7682BA0
        public void DoubleTrack(){} // RVA: 0x7682CB0
        public void DoubleStack(){} // RVA: 0x7682DA0
        public void DoubleCrawl(){} // RVA: 0x7682E90
        public void Crawl(){} // RVA: 0x7682F80
        public void Popcrawl(){} // RVA: 0x76830B0
        public void Crawlpos(){} // RVA: 0x76830F0
        public void Capture(){} // RVA: 0x7683110
        public void TransferCapture(){} // RVA: 0x76831A0
        public void Uncapture(){} // RVA: 0x76832D0
        public void IsMatched(){} // RVA: 0x7683320
        public void MatchIndex(){} // RVA: 0x7683350
        public void MatchLength(){} // RVA: 0x7683380
    }

    public class RegexRunnerFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateInstance(){} // RVA: 0x87C0A0
    }

    public class RegexTree : Object
    {
        public object Root;
        public object Caps;
        public object CapNumList;
        public object CapTop;
        public object CapNames;
        public object CapsList;
        public object Options;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76833B0
    }

    public class RegexWriter : ValueType
    {
        public object _emitted;
        public object _intStack;
        public object _stringHash;
        public object _stringTable;
        public object _caps;
        public object _trackCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7683570
        public void Write(){} // RVA: 0x7683690
        public void Dispose(){} // RVA: 0x76838E0
        public void RegexCodeFromRegexTree(){} // RVA: 0x7683920
        public void PatchJump(){} // RVA: 0x7683FF0
        public void Emit(){} // RVA: 0x76841B0
        public void StringCode(){} // RVA: 0x7684280
        public void MapCapnum(){} // RVA: 0x7684440
        public void EmitFragment(){} // RVA: 0x76844E0
    }

    public class Regex[] : Array
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