// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.RegularExpressions
// Classes: 26
// Methods: 466

namespace ThirdParty.DotNet.System.Text.RegularExpressions
{
    public class Capture : Object
    {
        public int Index; // 0x10
        public int Length; // 0x14
        public string Text; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9394B70
        public void get_Index(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Index(){} // RVA: 0x7FFAC2F240C0
        public void get_Length(){} // RVA: 0x7FFAC33D5A20
        public void set_Length(){} // RVA: 0x7FFAC33D4990
        public void get_Text(){} // RVA: 0x7FFAC2F247C0
        public void set_Text(){} // RVA: 0x7FFAC2F87E80
        public void get_Value(){} // RVA: 0x7FFAC9394BE0
        public void ToString(){} // RVA: 0x7FFAC9394BE0
        public void GetLeftSubstring(){} // RVA: 0x7FFAC9394C10
        public void GetRightSubstring(){} // RVA: 0x7FFAC9394CA0
    }

    public class CaptureCollection : Object
    {
        public System.Text.RegularExpressions.Group IsReadOnly; // 0x10
        public int Count; // 0x18
        public System.Text.RegularExpressions.Capture[] Item; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9394D60
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void get_Item(){} // RVA: 0x7FFAC9394DD0
        public void GetEnumerator(){} // RVA: 0x7FFAC9394E90
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator(){} // RVA: 0x7FFAC9394F30
        public void GetCapture(){} // RVA: 0x7FFAC9394DD0
        public void ForceInitialized(){} // RVA: 0x7FFAC9394FD0
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC2F3C380
        public void CopyTo(){} // RVA: 0x7FFAC9395300 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(){} // RVA: 0x7FFAC9395500
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(){} // RVA: 0x7FFAC93955B0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(){} // RVA: 0x7FFAC9395600
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(){} // RVA: 0x7FFAC9395650
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(){} // RVA: 0x7FFAC9395660
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(){} // RVA: 0x7FFAC93956B0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear(){} // RVA: 0x7FFAC9395700
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(){} // RVA: 0x7FFAC9395750
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(){} // RVA: 0x7FFAC93957B0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC9395800
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC9395850
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC93958A0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC93959F0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC9395AC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC3006850
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC9395B10
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC9395B60
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC9395650
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC9395BB0
    }

    public class CollectionDebuggerProxy`1 : Object
    {
    }

    public class ExclusiveReference : Object
    {
        public System.Text.RegularExpressions.RegexRunner _ref; // 0x10
        public System.Text.RegularExpressions.RegexRunner _obj; // 0x18
        public int _locked; // 0x20

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC93998D0
        public void Release(){} // RVA: 0x7FFAC9399950
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Group : Capture
    {
        public System.Text.RegularExpressions.Group Success;
        public int[] Name; // 0x20
        public int Captures; // 0x28
        public System.Text.RegularExpressions.CaptureCollection _capcoll; // 0x30
        public string <Name>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9396150 | overloaded x2
        public void get_Success(){} // RVA: 0x7FFAC9395E70
        public void get_Name(){} // RVA: 0x7FFAC31D0140
        public void get_Captures(){} // RVA: 0x7FFAC9395E80
        public void Synchronized(){} // RVA: 0x7FFAC9395F90
        public void .cctor(){} // RVA: 0x7FFAC9396020
    }

    public class GroupCollection : Object
    {
        public System.Text.RegularExpressions.Match IsReadOnly; // 0x10
        public System.Collections.Hashtable Count; // 0x18
        public System.Text.RegularExpressions.Group[] Item; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9397490 | overloaded x2
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_Count(){} // RVA: 0x7FFAC9396180
        public void get_Item(){} // RVA: 0x7FFAC93961C0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC9396270
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator(){} // RVA: 0x7FFAC9396310
        public void GetGroup(){} // RVA: 0x7FFAC93963B0
        public void GetGroupImpl(){} // RVA: 0x7FFAC9396760
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC2F3C380
        public void CopyTo(){} // RVA: 0x7FFAC9396B20 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(){} // RVA: 0x7FFAC9396D70
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(){} // RVA: 0x7FFAC9396E50
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(){} // RVA: 0x7FFAC9396EA0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(){} // RVA: 0x7FFAC93961B0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(){} // RVA: 0x7FFAC9396EF0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(){} // RVA: 0x7FFAC9396F40
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear(){} // RVA: 0x7FFAC9396F90
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(){} // RVA: 0x7FFAC9396FE0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(){} // RVA: 0x7FFAC9397040
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC9397090
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC93970E0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC9397130
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC9397280
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC9397350
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC3006850
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC93973A0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC93973F0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC93961B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC9397440
    }

    public class Match : Group
    {
        public System.Text.RegularExpressions.GroupCollection Empty; // 0x40
        public System.Text.RegularExpressions.Regex Groups; // 0x48
        public int _textbeg; // 0x50
        public int _textpos; // 0x54
        public int _textend; // 0x58
        public int _textstart; // 0x5C
        public int[][] _matches; // 0x60
        public int[] _matchcount; // 0x68
        public bool _balancing; // 0x70
        public System.Text.RegularExpressions.Match <Empty>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93986B0 | overloaded x2
        public void get_Empty(){} // RVA: 0x7FFAC93977E0
        public void Reset(){} // RVA: 0x7FFAC9397840
        public void get_Groups(){} // RVA: 0x7FFAC9397960
        public void NextMatch(){} // RVA: 0x7FFAC9397A10
        public void Result(){} // RVA: 0x7FFAC9397A60
        public void GroupToStringImpl(){} // RVA: 0x7FFAC9397B70
        public void LastGroupToStringImpl(){} // RVA: 0x7FFAC9397D20
        public void Synchronized(){} // RVA: 0x7FFAC9397D70
        public void AddMatch(){} // RVA: 0x7FFAC9397F00
        public void BalanceMatch(){} // RVA: 0x7FFAC93980D0
        public void RemoveMatch(){} // RVA: 0x7FFAC9398250
        public void IsMatched(){} // RVA: 0x7FFAC9398280
        public void MatchIndex(){} // RVA: 0x7FFAC9398300
        public void MatchLength(){} // RVA: 0x7FFAC9398390
        public void Tidy(){} // RVA: 0x7FFAC9398420
        public void .cctor(){} // RVA: 0x7FFAC93985C0
    }

    public class MatchCollection : Object
    {
        public System.Text.RegularExpressions.Regex IsReadOnly; // 0x10
        public System.Collections.Generic.List`1<System.Text.RegularExpressions.Match> Count; // 0x18
        public bool Item; // 0x20
        public string IsSynchronized; // 0x28
        public int SyncRoot; // 0x30
        public int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item; // 0x34
        public int System.Collections.IList.IsFixedSize; // 0x38
        public int System.Collections.IList.Item; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93997D0 | overloaded x2
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_Count(){} // RVA: 0x7FFAC9398AD0
        public void get_Item(){} // RVA: 0x7FFAC9398B30
        public void GetEnumerator(){} // RVA: 0x7FFAC9398BE0
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator(){} // RVA: 0x7FFAC9398C80
        public void GetMatch(){} // RVA: 0x7FFAC9398D20
        public void EnsureInitialized(){} // RVA: 0x7FFAC9398EC0
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void CopyTo(){} // RVA: 0x7FFAC9398F60 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(){} // RVA: 0x7FFAC9398FF0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(){} // RVA: 0x7FFAC9399090
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(){} // RVA: 0x7FFAC93990E0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(){} // RVA: 0x7FFAC9399130
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(){} // RVA: 0x7FFAC9399150
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(){} // RVA: 0x7FFAC93991A0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear(){} // RVA: 0x7FFAC93991F0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(){} // RVA: 0x7FFAC9399240
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(){} // RVA: 0x7FFAC9399300
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC9399350
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC93993A0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC93993F0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC9399540
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC9399690
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC3006850
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC93996E0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC9399730
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC9399130
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC9399780
    }

    public class MatchEvaluator : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3AD0660
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class MatchSparse : Match
    {
        public System.Collections.Hashtable Groups; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93986E0
        public void get_Groups(){} // RVA: 0x7FFAC93987E0
    }

    public class Regex : Object
    {
        public int CacheSize;
        public int MatchTimeout;
        public System.Collections.Generic.Dictionary`2<CachedCodeEntryKey,CachedCodeEntry> Options; // 0x8
        public int RightToLeft; // 0x10
        public CachedCodeEntry s_cacheFirst; // 0x18
        public CachedCodeEntry s_cacheLast; // 0x20
        public System.TimeSpan s_maximumMatchTimeout; // 0x28
        public string DefaultMatchTimeout_ConfigKeyName;
        public System.TimeSpan s_defaultMatchTimeout; // 0x30
        public System.TimeSpan InfiniteMatchTimeout; // 0x38
        public System.TimeSpan internalMatchTimeout; // 0x10
        public int MaxOptionShift;
        public string pattern; // 0x18
        public 0x6B130410 roptions; // 0x20
        public System.Text.RegularExpressions.RegexRunnerFactory factory; // 0x28
        public System.Collections.Hashtable caps; // 0x30
        public System.Collections.Hashtable capnames; // 0x38
        public string[] capslist; // 0x40
        public int capsize; // 0x48
        public System.Text.RegularExpressions.ExclusiveReference _runnerref; // 0x50
        public System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement> _replref; // 0x58
        public System.Text.RegularExpressions.RegexCode _code; // 0x60
        public bool _refsInitialized; // 0x68

        // ── Methods ──
        public void get_CacheSize(){} // RVA: 0x7FFAC9399A60
        public void set_CacheSize(){} // RVA: 0x7FFAC9399AC0
        public void GetCachedCode(){} // RVA: 0x7FFAC9399EB0
        public void GetCachedCodeEntryInternal(){} // RVA: 0x7FFAC939A070
        public void FillCacheDictionary(){} // RVA: 0x7FFAC939A8B0
        public void TryGetCacheValue(){} // RVA: 0x7FFAC939AA30
        public void TryGetCacheValueSmall(){} // RVA: 0x7FFAC939AB30
        public void LookupCachedAndPromote(){} // RVA: 0x7FFAC939AD30
        public void IsMatch(){} // RVA: 0x7FFAC939B730 | overloaded x5
        public void Match(){} // RVA: 0x7FFAC939BB30 | overloaded x6
        public void Matches(){} // RVA: 0x7FFAC939BE90 | overloaded x5
        public void Replace(){} // RVA: 0x7FFAC939CAC0 | overloaded x11
        public void Split(){} // RVA: 0x7FFAC939D520 | overloaded x7
        public void .cctor(){} // RVA: 0x7FFAC939DC00
        public void get_MatchTimeout(){} // RVA: 0x7FFAC2F3C380
        public void ValidateMatchTimeout(){} // RVA: 0x7FFAC939DE10
        public void InitDefaultMatchTimeout(){} // RVA: 0x7FFAC939DF50
        public void .ctor(){} // RVA: 0x7FFAC939E310 | overloaded x4
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC939E2D0
        public void Escape(){} // RVA: 0x7FFAC939E840
        public void Unescape(){} // RVA: 0x7FFAC939E8E0
        public void get_Options(){} // RVA: 0x7FFAC30DBBE0
        public void get_RightToLeft(){} // RVA: 0x7FFAC82017D0
        public void ToString(){} // RVA: 0x7FFAC2F247C0
        public void GetGroupNames(){} // RVA: 0x7FFAC939E980
        public void GetGroupNumbers(){} // RVA: 0x7FFAC939EB60
        public void GroupNameFromNumber(){} // RVA: 0x7FFAC939EE90
        public void GroupNumberFromName(){} // RVA: 0x7FFAC939EFE0
        public void InitializeReferences(){} // RVA: 0x7FFAC939F110
        public void Run(){} // RVA: 0x7FFAC939F2B0
        public void UseOptionR(){} // RVA: 0x7FFAC82017D0
        public void UseOptionInvariant(){} // RVA: 0x7FFAC8201730
    }

    public class RegexBoyerMoore : Object
    {
        public int[] Positive; // 0x10
        public int[] NegativeASCII; // 0x18
        public int[][] NegativeUnicode; // 0x20
        public string Pattern; // 0x28
        public int LowASCII; // 0x30
        public int HighASCII; // 0x34
        public bool RightToLeft; // 0x38
        public bool CaseInsensitive; // 0x39
        public System.Globalization.CultureInfo _culture; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC939FC50
        public void MatchPattern(){} // RVA: 0x7FFAC93A03C0
        public void IsMatch(){} // RVA: 0x7FFAC93A0520
        public void Scan(){} // RVA: 0x7FFAC93A0590
    }

    public class RegexCharClass : Object
    {
        public string CanMerge;
        public string Negate; // 0x8
        public string s_notSpace; // 0x10
        public string s_word; // 0x18
        public string s_notWord; // 0x20
        public string SpaceClass; // 0x28
        public string NotSpaceClass; // 0x30
        public string WordClass; // 0x38
        public string NotWordClass; // 0x40
        public string DigitClass; // 0x48
        public string NotDigitClass; // 0x50
        public System.Collections.Generic.Dictionary`2<string,string> s_definedCategories; // 0x58
        public string[][] s_propTable; // 0x60
        public LowerCaseMapping[] s_lcTable; // 0x68
        public System.Collections.Generic.List`1<SingleRange> _rangelist; // 0x10
        public System.Text.StringBuilder _categories; // 0x18
        public bool _canonical; // 0x20
        public bool _negate; // 0x21
        public System.Text.RegularExpressions.RegexCharClass _subtractor; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93A0B10 | overloaded x2
        public void get_CanMerge(){} // RVA: 0x7FFAC93A0C30
        public void set_Negate(){} // RVA: 0x7FFAC376A610
        public void AddChar(){} // RVA: 0x7FFAC93A0C50
        public void AddCharClass(){} // RVA: 0x7FFAC93A0C60
        public void AddSet(){} // RVA: 0x7FFAC93A0EB0
        public void AddSubtraction(){} // RVA: 0x7FFAC2F22E90
        public void AddRange(){} // RVA: 0x7FFAC93A1110
        public void AddCategoryFromName(){} // RVA: 0x7FFAC93A1240
        public void AddCategory(){} // RVA: 0x7FFAC93A1600
        public void AddLowercase(){} // RVA: 0x7FFAC93A1620
        public void AddLowercaseRange(){} // RVA: 0x7FFAC93A17A0
        public void AddWord(){} // RVA: 0x7FFAC93A1A00
        public void AddSpace(){} // RVA: 0x7FFAC93A1B40
        public void AddDigit(){} // RVA: 0x7FFAC93A1C80
        public void SingletonChar(){} // RVA: 0x7FFAC93A1D40
        public void IsMergeable(){} // RVA: 0x7FFAC93A1D70
        public void IsEmpty(){} // RVA: 0x7FFAC93A1E20
        public void IsSingleton(){} // RVA: 0x7FFAC93A1EC0
        public void IsSingletonInverse(){} // RVA: 0x7FFAC93A1FA0
        public void IsSubtraction(){} // RVA: 0x7FFAC93A2080
        public void IsNegated(){} // RVA: 0x7FFAC93A20C0
        public void IsECMAWordChar(){} // RVA: 0x7FFAC93A20F0
        public void IsWordChar(){} // RVA: 0x7FFAC93A21A0
        public void CharInClass(){} // RVA: 0x7FFAC93A2270
        public void CharInClassRecursive(){} // RVA: 0x7FFAC93A22E0
        public void CharInClassInternal(){} // RVA: 0x7FFAC93A2430
        public void CharInCategory(){} // RVA: 0x7FFAC93A2650
        public void CharInCategoryGroup(){} // RVA: 0x7FFAC93A27E0
        public void NegateCategory(){} // RVA: 0x7FFAC93A28D0
        public void Parse(){} // RVA: 0x7FFAC93A29E0
        public void ParseRecursive(){} // RVA: 0x7FFAC93A2A40
        public void RangeCount(){} // RVA: 0x7FFAC93A2DE0
        public void ToStringClass(){} // RVA: 0x7FFAC93A2E30
        public void GetRangeAt(){} // RVA: 0x7FFAC93A30F0
        public void Canonicalize(){} // RVA: 0x7FFAC93A3160
        public void SetFromProperty(){} // RVA: 0x7FFAC93A3450
        public void .cctor(){} // RVA: 0x7FFAC93A3720
    }

    public class RegexCode : Object
    {
        public int Onerep;
        public int Notonerep;
        public int Setrep;
        public int Oneloop;
        public int Notoneloop;
        public int Setloop;
        public int Onelazy;
        public int Notonelazy;
        public int Setlazy;
        public int One;
        public int Notone;
        public int Set;
        public int Multi;
        public int Ref;
        public int Bol;
        public int Eol;
        public int Boundary;
        public int Nonboundary;
        public int Beginning;
        public int Start;
        public int EndZ;
        public int End;
        public int Nothing;
        public int Lazybranch;
        public int Branchmark;
        public int Lazybranchmark;
        public int Nullcount;
        public int Setcount;
        public int Branchcount;
        public int Lazybranchcount;
        public int Nullmark;
        public int Setmark;
        public int Capturemark;
        public int Getmark;
        public int Setjump;
        public int Backjump;
        public int Forejump;
        public int Testref;
        public int Goto;
        public int Prune;
        public int Stop;
        public int ECMABoundary;
        public int NonECMABoundary;
        public int Mask;
        public int Rtl;
        public int Back;
        public int Back2;
        public int Ci;
        public int[] Codes; // 0x10
        public string[] Strings; // 0x18
        public int TrackCount; // 0x20
        public System.Collections.Hashtable Caps; // 0x28
        public int CapSize; // 0x30
        public System.Nullable`1<System.Text.RegularExpressions.RegexPrefix> FCPrefix; // 0x38
        public System.Text.RegularExpressions.RegexBoyerMoore BMPrefix; // 0x50
        public int Anchors; // 0x58
        public bool RightToLeft; // 0x5C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93A8AF0
        public void OpcodeBacktracks(){} // RVA: 0x7FFAC93A8D50
    }

    public class RegexFC : Object
    {
        public System.Text.RegularExpressions.RegexCharClass CaseInsensitive; // 0x10
        public bool _nullable; // 0x18
        public bool <CaseInsensitive>k__BackingField; // 0x19

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93AA6A0 | overloaded x3
        public void AddFC(){} // RVA: 0x7FFAC93AA7A0
        public void get_CaseInsensitive(){} // RVA: 0x7FFAC3228D50
        public void set_CaseInsensitive(){} // RVA: 0x7FFAC3515120
        public void GetFirstChars(){} // RVA: 0x7FFAC93AA830
    }

    public class RegexFCD : ValueType
    {
        public System.Collections.Generic.List`1<System.Text.RegularExpressions.RegexFC> _fcStack; // 0x10
        public System.Collections.Generic.ValueListBuilder`1<int> _intStack; // 0x18
        public bool _skipAllChildren; // 0x38
        public bool _skipchild; // 0x39
        public bool _failed; // 0x3A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93A8DB0
        public void FirstChars(){} // RVA: 0x7FFAC93A8ED0
        public void Prefix(){} // RVA: 0x7FFAC93A9260
        public void Anchors(){} // RVA: 0x7FFAC93A9580
        public void AnchorFromType(){} // RVA: 0x7FFAC93A9810
        public void PushInt(){} // RVA: 0x7FFAC93A9890
        public void IntIsEmpty(){} // RVA: 0x7FFAC93A98E0
        public void PopInt(){} // RVA: 0x7FFAC93A9920
        public void PushFC(){} // RVA: 0x7FFAC93A9970
        public void FCIsEmpty(){} // RVA: 0x7FFAC93A9A10
        public void PopFC(){} // RVA: 0x7FFAC93A9A60
        public void TopFC(){} // RVA: 0x7FFAC93A9AE0
        public void Dispose(){} // RVA: 0x7FFAC93A9B70
        public void RegexFCFromRegexTree(){} // RVA: 0x7FFAC93A9BB0
        public void SkipChild(){} // RVA: 0x7FFAC9313AB0
        public void CalculateFC(){} // RVA: 0x7FFAC93A9E40
    }

    public class RegexInterpreter : RegexRunner
    {
        public System.Text.RegularExpressions.RegexCode _code; // 0x80
        public System.Globalization.CultureInfo _culture; // 0x88
        public int _operator; // 0x90
        public int _codepos; // 0x94
        public bool _rightToLeft; // 0x98
        public bool _caseInsensitive; // 0x99

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93AA870
        public void InitTrackCount(){} // RVA: 0x7FFAC93AA930
        public void Advance(){} // RVA: 0x7FFAC93AA960
        public void Goto(){} // RVA: 0x7FFAC93AA9E0
        public void Textto(){} // RVA: 0x7FFAC369A6E0
        public void Trackto(){} // RVA: 0x7FFAC93AAA70
        public void Textstart(){} // RVA: 0x7FFAC3157800
        public void Textpos(){} // RVA: 0x7FFAC32EC4C0
        public void Trackpos(){} // RVA: 0x7FFAC93AAA90
        public void TrackPush(){} // RVA: 0x7FFAC93AABF0 | overloaded x4
        public void TrackPush2(){} // RVA: 0x7FFAC93AAD10 | overloaded x2
        public void Backtrack(){} // RVA: 0x7FFAC93AADA0
        public void SetOperator(){} // RVA: 0x7FFAC93AAE80
        public void TrackPop(){} // RVA: 0x7FFAC93AAEC0 | overloaded x2
        public void TrackPeek(){} // RVA: 0x7FFAC93AAF00 | overloaded x2
        public void StackPush(){} // RVA: 0x7FFAC93AAF80 | overloaded x2
        public void StackPop(){} // RVA: 0x7FFAC93AAFE0 | overloaded x2
        public void StackPeek(){} // RVA: 0x7FFAC93AB020 | overloaded x2
        public void Operator(){} // RVA: 0x7FFAC3220660
        public void Operand(){} // RVA: 0x7FFAC93AB060
        public void Leftchars(){} // RVA: 0x7FFAC93AB0B0
        public void Rightchars(){} // RVA: 0x7FFAC93AB0C0
        public void Bump(){} // RVA: 0x7FFAC93AB0D0
        public void Forwardchars(){} // RVA: 0x7FFAC93AB0F0
        public void Forwardcharnext(){} // RVA: 0x7FFAC93AB110
        public void Stringmatch(){} // RVA: 0x7FFAC93AB1D0
        public void Refmatch(){} // RVA: 0x7FFAC93AB360
        public void Backwardnext(){} // RVA: 0x7FFAC93AB550
        public void CharAt(){} // RVA: 0x7FFAC93AB570
        public void FindFirstChar(){} // RVA: 0x7FFAC93AB5B0
        public void Go(){} // RVA: 0x7FFAC93ABA50
    }

    public class RegexMatchTimeoutException : TimeoutException
    {
        public string Input; // 0x90
        public string Pattern; // 0x98
        public System.TimeSpan MatchTimeout; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93AE180 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC93AE480
        public void get_Input(){} // RVA: 0x7FFAC32EF640
        public void get_Pattern(){} // RVA: 0x7FFAC354DFB0
        public void get_MatchTimeout(){} // RVA: 0x7FFAC3543900
    }

    public class RegexNode : Object
    {
        public int NType; // 0x10
        public System.Collections.Generic.List`1<System.Text.RegularExpressions.RegexNode> Children; // 0x18
        public string Str; // 0x20
        public char Ch; // 0x28
        public int M; // 0x2C
        public int N; // 0x30
        public 0x6B130410 Options; // 0x34
        public System.Text.RegularExpressions.RegexNode Next; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93AE9B0 | overloaded x5
        public void UseOptionR(){} // RVA: 0x7FFAC93AE9D0
        public void ReverseLeft(){} // RVA: 0x7FFAC93AE9E0
        public void MakeRep(){} // RVA: 0x7FFAC93AEA90
        public void Reduce(){} // RVA: 0x7FFAC93AEAA0
        public void StripEnation(){} // RVA: 0x7FFAC93AEBB0
        public void ReduceGroup(){} // RVA: 0x7FFAC93AEC60
        public void ReduceRep(){} // RVA: 0x7FFAC93AECF0
        public void ReduceSet(){} // RVA: 0x7FFAC93AEED0
        public void ReduceAlternation(){} // RVA: 0x7FFAC93AF300
        public void ReduceConcatenation(){} // RVA: 0x7FFAC93AF730
        public void MakeQuantifier(){} // RVA: 0x7FFAC93AFB30
        public void AddChild(){} // RVA: 0x7FFAC93AFC20
        public void Child(){} // RVA: 0x7FFAC93AFF40
        public void ChildCount(){} // RVA: 0x7FFAC93AFFC0
        public void Type(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class RegexParser : Object
    {
        public System.Text.RegularExpressions.RegexNode _stack; // 0x10
        public System.Text.RegularExpressions.RegexNode _group; // 0x18
        public System.Text.RegularExpressions.RegexNode _alternation; // 0x20
        public System.Text.RegularExpressions.RegexNode _concatenation; // 0x28
        public System.Text.RegularExpressions.RegexNode _unit; // 0x30
        public string _pattern; // 0x38
        public int _currentPos; // 0x40
        public System.Globalization.CultureInfo _culture; // 0x48
        public int _autocap; // 0x50
        public int _capcount; // 0x54
        public int _captop; // 0x58
        public int _capsize; // 0x5C
        public System.Collections.Hashtable _caps; // 0x60
        public System.Collections.Hashtable _capnames; // 0x68
        public int[] _capnumlist; // 0x70
        public System.Collections.Generic.List`1<string> _capnamelist; // 0x78
        public 0x6B130410 _options; // 0x80
        public System.Collections.Generic.List`1<0x6B130410> _optionsStack; // 0x88
        public bool _ignoreNextParen; // 0x90
        public byte[] s_category;

        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAC93B0010
        public void ParseReplacement(){} // RVA: 0x7FFAC93B0300
        public void Escape(){} // RVA: 0x7FFAC93B0530
        public void Unescape(){} // RVA: 0x7FFAC93B0760
        public void .ctor(){} // RVA: 0x7FFAC93B0940
        public void SetPattern(){} // RVA: 0x7FFAC93B0AE0
        public void Reset(){} // RVA: 0x7FFAC93B0B90
        public void ScanRegex(){} // RVA: 0x7FFAC93B0CC0
        public void ScanReplacement(){} // RVA: 0x7FFAC93B1570
        public void ScanCharClass(){} // RVA: 0x7FFAC93B17E0
        public void ScanGroupOpen(){} // RVA: 0x7FFAC93B20A0
        public void ScanBlank(){} // RVA: 0x7FFAC93B2CE0
        public void ScanBackslash(){} // RVA: 0x7FFAC93B3070
        public void ScanBasicBackslash(){} // RVA: 0x7FFAC93B3650
        public void ScanDollar(){} // RVA: 0x7FFAC93B3D10
        public void ScanCapname(){} // RVA: 0x7FFAC93B4140
        public void ScanOctal(){} // RVA: 0x7FFAC93B4210
        public void ScanDecimal(){} // RVA: 0x7FFAC93B42B0
        public void ScanHex(){} // RVA: 0x7FFAC93B4360
        public void HexDigit(){} // RVA: 0x7FFAC93B4490
        public void ScanControl(){} // RVA: 0x7FFAC93B44C0
        public void IsOnlyTopOption(){} // RVA: 0x7FFAC93B45A0
        public void ScanOptions(){} // RVA: 0x7FFAC93B45C0
        public void ScanCharEscape(){} // RVA: 0x7FFAC93B46E0
        public void ParseProperty(){} // RVA: 0x7FFAC93B4AA0
        public void TypeFromCode(){} // RVA: 0x7FFAC93B4C90
        public void OptionFromCode(){} // RVA: 0x7FFAC93B4D10
        public void CountCaptures(){} // RVA: 0x7FFAC93B4DA0
        public void NoteCaptureSlot(){} // RVA: 0x7FFAC93B5140
        public void NoteCaptureName(){} // RVA: 0x7FFAC93B5250
        public void NoteCaptures(){} // RVA: 0x7FFAC93B54B0
        public void AssignNameSlots(){} // RVA: 0x7FFAC93B5570
        public void CaptureSlotFromName(){} // RVA: 0x7FFAC93B5DF0
        public void IsCaptureSlot(){} // RVA: 0x7FFAC93B5E80
        public void IsCaptureName(){} // RVA: 0x7FFAC93B5F20
        public void UseOptionN(){} // RVA: 0x7FFAC93B5F50
        public void UseOptionI(){} // RVA: 0x7FFAC93B5F60
        public void UseOptionM(){} // RVA: 0x7FFAC93B5F70
        public void UseOptionS(){} // RVA: 0x7FFAC93B5F80
        public void UseOptionX(){} // RVA: 0x7FFAC93B5F90
        public void UseOptionE(){} // RVA: 0x7FFAC93B5FA0
        public void IsSpecial(){} // RVA: 0x7FFAC93B5FB0
        public void IsStopperX(){} // RVA: 0x7FFAC93B6040
        public void IsQuantifier(){} // RVA: 0x7FFAC93B60D0
        public void IsTrueQuantifier(){} // RVA: 0x7FFAC93B6160
        public void IsSpace(){} // RVA: 0x7FFAC93B6300
        public void IsMetachar(){} // RVA: 0x7FFAC93B6390
        public void AddConcatenate(){} // RVA: 0x7FFAC93B6DF0 | overloaded x3
        public void PushGroup(){} // RVA: 0x7FFAC93B6720
        public void PopGroup(){} // RVA: 0x7FFAC93B68B0
        public void EmptyStack(){} // RVA: 0x7FFAC353FA50
        public void StartGroup(){} // RVA: 0x7FFAC93B6AF0
        public void AddAlternate(){} // RVA: 0x7FFAC93B6C70
        public void Unit(){} // RVA: 0x7FFAC31D95E0
        public void AddUnitOne(){} // RVA: 0x7FFAC93B6F60
        public void AddUnitNotone(){} // RVA: 0x7FFAC93B7070
        public void AddUnitSet(){} // RVA: 0x7FFAC93B7180
        public void AddUnitNode(){} // RVA: 0x7FFAC2F4F890
        public void AddUnitType(){} // RVA: 0x7FFAC93B7290
        public void AddGroup(){} // RVA: 0x7FFAC93B7350
        public void PushOptions(){} // RVA: 0x7FFAC93B7510
        public void PopOptions(){} // RVA: 0x7FFAC93B75B0
        public void EmptyOptionsStack(){} // RVA: 0x7FFAC93B7670
        public void PopKeepOptions(){} // RVA: 0x7FFAC93B76C0
        public void MakeException(){} // RVA: 0x7FFAC93B7730
        public void Textpos(){} // RVA: 0x7FFAC2FC2080
        public void Textto(){} // RVA: 0x7FFAC2FC2090
        public void RightCharMoveRight(){} // RVA: 0x7FFAC93B77C0
        public void MoveRight(){} // RVA: 0x7FFAC93B7810 | overloaded x2
        public void MoveLeft(){} // RVA: 0x7FFAC93B7820
        public void CharAt(){} // RVA: 0x7FFAC93B7830
        public void RightChar(){} // RVA: 0x7FFAC93B78B0 | overloaded x2
        public void CharsRight(){} // RVA: 0x7FFAC93B78F0
        public void .cctor(){} // RVA: 0x7FFAC93B7910
    }

    public class RegexPrefix : ValueType
    {
        public bool CaseInsensitive; // 0x10
        public System.Text.RegularExpressions.RegexPrefix Empty;
        public string Prefix; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93B79F0
        public void get_CaseInsensitive(){} // RVA: 0x7FFAC495DDF0
        public void get_Empty(){} // RVA: 0x7FFAC93B7A50
        public void get_Prefix(){} // RVA: 0x7FFAC4420220
        public void .cctor(){} // RVA: 0x7FFAC93B7AB0
    }

    public class RegexReplacement : Object
    {
        public int Pattern;
        public int LeftPortion;
        public int RightPortion;
        public int LastGroup;
        public int WholeString;
        public System.Collections.Generic.List`1<string> _strings; // 0x10
        public System.Collections.Generic.List`1<int> _rules; // 0x18
        public string <Pattern>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93B7BD0
        public void GetOrCreate(){} // RVA: 0x7FFAC93B8100
        public void get_Pattern(){} // RVA: 0x7FFAC2F4F0C0
        public void ReplacementImpl(){} // RVA: 0x7FFAC93B8250
        public void ReplacementImplRTL(){} // RVA: 0x7FFAC93B84A0
        public void Replacement(){} // RVA: 0x7FFAC93B86D0
        public void Replace(){} // RVA: 0x7FFAC93B8950
    }

    public class RegexRunner : Object
    {
        public int runtextbeg; // 0x10
        public int runtextend; // 0x14
        public int runtextstart; // 0x18
        public string runtext; // 0x20
        public int runtextpos; // 0x28
        public int[] runtrack; // 0x30
        public int runtrackpos; // 0x38
        public int[] runstack; // 0x40
        public int runstackpos; // 0x48
        public int[] runcrawl; // 0x50
        public int runcrawlpos; // 0x58
        public int runtrackcount; // 0x5C
        public System.Text.RegularExpressions.Match runmatch; // 0x60
        public System.Text.RegularExpressions.Regex runregex; // 0x68
        public int _timeout; // 0x70
        public bool _ignoreTimeout; // 0x74
        public int _timeoutOccursAt; // 0x78
        public int TimeoutCheckFrequency;
        public int _timeoutChecksToSkip; // 0x7C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Scan(){} // RVA: 0x7FFAC93B91B0
        public void StartTimeoutWatch(){} // RVA: 0x7FFAC93B9560
        public void CheckTimeout(){} // RVA: 0x7FFAC93B9590
        public void DoCheckTimeout(){} // RVA: 0x7FFAC93B9670
        public void Go(){} // RVA: 0x7FFAC2C70980
        public void FindFirstChar(){} // RVA: 0x7FFAC2C59D00
        public void InitTrackCount(){} // RVA: 0x7FFAC2C70980
        public void InitMatch(){} // RVA: 0x7FFAC93B9750
        public void TidyMatch(){} // RVA: 0x7FFAC93B9BE0
        public void EnsureStorage(){} // RVA: 0x7FFAC93B9C90
        public void IsBoundary(){} // RVA: 0x7FFAC93B9E90
        public void IsECMABoundary(){} // RVA: 0x7FFAC93B9FA0
        public void DoubleTrack(){} // RVA: 0x7FFAC93BA0B0
        public void DoubleStack(){} // RVA: 0x7FFAC93BA1A0
        public void DoubleCrawl(){} // RVA: 0x7FFAC93BA290
        public void Crawl(){} // RVA: 0x7FFAC93BA380
        public void Popcrawl(){} // RVA: 0x7FFAC93BA4B0
        public void Crawlpos(){} // RVA: 0x7FFAC93BA4F0
        public void Capture(){} // RVA: 0x7FFAC93BA510
        public void TransferCapture(){} // RVA: 0x7FFAC93BA5A0
        public void Uncapture(){} // RVA: 0x7FFAC93BA6D0
        public void IsMatched(){} // RVA: 0x7FFAC93BA720
        public void MatchIndex(){} // RVA: 0x7FFAC93BA750
        public void MatchLength(){} // RVA: 0x7FFAC93BA780
    }

    public class RegexRunnerFactory : Object
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFAC2C58E90
    }

    public class RegexTree : Object
    {
        public System.Text.RegularExpressions.RegexNode Root; // 0x10
        public System.Collections.Hashtable Caps; // 0x18
        public int[] CapNumList; // 0x20
        public int CapTop; // 0x28
        public System.Collections.Hashtable CapNames; // 0x30
        public string[] CapsList; // 0x38
        public 0x6B130410 Options; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93BA7B0
    }

    public class RegexWriter : ValueType
    {
        public System.Collections.Generic.ValueListBuilder`1<int> _emitted; // 0x10
        public System.Collections.Generic.ValueListBuilder`1<int> _intStack; // 0x30
        public System.Collections.Generic.Dictionary`2<string,int> _stringHash; // 0x50
        public System.Collections.Generic.List`1<string> _stringTable; // 0x58
        public System.Collections.Hashtable _caps; // 0x60
        public int _trackCount; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93BA970
        public void Write(){} // RVA: 0x7FFAC93BAA90
        public void Dispose(){} // RVA: 0x7FFAC93BACD0
        public void RegexCodeFromRegexTree(){} // RVA: 0x7FFAC93BAD10
        public void PatchJump(){} // RVA: 0x7FFAC93BB3F0
        public void Emit(){} // RVA: 0x7FFAC93BB5B0 | overloaded x3
        public void StringCode(){} // RVA: 0x7FFAC93BB680
        public void MapCapnum(){} // RVA: 0x7FFAC93BB850
        public void EmitFragment(){} // RVA: 0x7FFAC93BB920
    }

}