// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.RegularExpressions
// Classes: 26
// Methods: 466

namespace ThirdParty.DotNet.System.Text.RegularExpressions
{
    public class Capture : Object
    {
        public int _index; // 0x10
        public int _length; // 0x14
        public string _text; // 0x18
        public object field_3; // 0xC9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8773D2A0
        public void get_Index(){} // RVA: 0x7FFE811485C0
        public void set_Index(){} // RVA: 0x7FFE810FE0C0
        public void get_Length(){} // RVA: 0x7FFE8164B230
        public void set_Length(){} // RVA: 0x7FFE8164E0F0
        public void get_Text(){} // RVA: 0x7FFE810FE7C0
        public void set_Text(){} // RVA: 0x7FFE81161E80
        public void get_Value(){} // RVA: 0x7FFE8773D310
        public void ToString(){} // RVA: 0x7FFE8773D310
        public void GetLeftSubstring(){} // RVA: 0x7FFE8773D340
        public void GetRightSubstring(){} // RVA: 0x7FFE8773D3D0
    }

    public class CaptureCollection : Object
    {
        public System.Text.RegularExpressions.Group _group; // 0x10
        public int _capcount; // 0x18
        public System.Text.RegularExpressions.Capture[] _captures; // 0x20
        public object field_3; // 0xCD
        public object field_4; // 0xCE
        public object field_5; // 0xCF
        public object field_6; // 0xD0
        public object field_7; // 0xD1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8773D490
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void get_Item(){} // RVA: 0x7FFE8773D500
        public void GetEnumerator(){} // RVA: 0x7FFE8773D5C0
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator(){} // RVA: 0x7FFE8773D660
        public void GetCapture(){} // RVA: 0x7FFE8773D500
        public void ForceInitialized(){} // RVA: 0x7FFE8773D700
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE81116380
        public void CopyTo(){} // RVA: 0x7FFE8773DA30 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(){} // RVA: 0x7FFE8773DC30
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(){} // RVA: 0x7FFE8773DCE0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(){} // RVA: 0x7FFE8773DD30
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(){} // RVA: 0x7FFE8773DD80
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(){} // RVA: 0x7FFE8773DD90
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(){} // RVA: 0x7FFE8773DDE0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear(){} // RVA: 0x7FFE8773DE30
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(){} // RVA: 0x7FFE8773DE80
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(){} // RVA: 0x7FFE8773DEE0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE8773DF30
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE8773DF80
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE8773DFD0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE8773E120
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE8773E1F0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE811E0850
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE8773E240
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE8773E290
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE8773DD80
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE8773E2E0
    }

    public class CollectionDebuggerProxy`1 : Object
    {
    }

    public class ExclusiveReference : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE87742000
        public void Release(){} // RVA: 0x7FFE87742080
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Group : Capture
    {
        public System.Text.RegularExpressions.Group s_emptyGroup;
        public int[] _caps; // 0x20
        public int _capcount; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8773E880 | overloaded x2
        public void get_Success(){} // RVA: 0x7FFE8773E5A0
        public void get_Name(){} // RVA: 0x7FFE8143BA80
        public void get_Captures(){} // RVA: 0x7FFE8773E5B0
        public void Synchronized(){} // RVA: 0x7FFE8773E6C0
        public void .cctor(){} // RVA: 0x7FFE8773E750
    }

    public class GroupCollection : Object
    {
        public System.Text.RegularExpressions.Match _match; // 0x10
        public System.Collections.Hashtable _captureMap; // 0x18
        public System.Text.RegularExpressions.Group[] _groups; // 0x20
        public object field_3; // 0xDA
        public object field_4; // 0xDB
        public object field_5; // 0xDC
        public object field_6; // 0xDD
        public object field_7; // 0xDE
        public object field_8; // 0xDF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8773FBC0 | overloaded x2
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_Count(){} // RVA: 0x7FFE8773E8B0
        public void get_Item(){} // RVA: 0x7FFE8773E8F0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE8773E9A0
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator(){} // RVA: 0x7FFE8773EA40
        public void GetGroup(){} // RVA: 0x7FFE8773EAE0
        public void GetGroupImpl(){} // RVA: 0x7FFE8773EE90
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE81116380
        public void CopyTo(){} // RVA: 0x7FFE8773F250 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(){} // RVA: 0x7FFE8773F4A0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(){} // RVA: 0x7FFE8773F580
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(){} // RVA: 0x7FFE8773F5D0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(){} // RVA: 0x7FFE8773E8E0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(){} // RVA: 0x7FFE8773F620
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(){} // RVA: 0x7FFE8773F670
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear(){} // RVA: 0x7FFE8773F6C0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(){} // RVA: 0x7FFE8773F710
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(){} // RVA: 0x7FFE8773F770
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE8773F7C0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE8773F810
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE8773F860
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE8773F9B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE8773FA80
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE811E0850
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE8773FAD0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE8773FB20
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE8773E8E0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE8773FB70
    }

    public class Match : Group
    {
        public System.Text.RegularExpressions.GroupCollection _groupcoll; // 0x40
        public System.Text.RegularExpressions.Regex _regex; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87740DE0 | overloaded x2
        public void get_Empty(){} // RVA: 0x7FFE8773FF10
        public void Reset(){} // RVA: 0x7FFE8773FF70
        public void get_Groups(){} // RVA: 0x7FFE87740090
        public void NextMatch(){} // RVA: 0x7FFE87740140
        public void Result(){} // RVA: 0x7FFE87740190
        public void GroupToStringImpl(){} // RVA: 0x7FFE877402A0
        public void LastGroupToStringImpl(){} // RVA: 0x7FFE87740450
        public void Synchronized(){} // RVA: 0x7FFE877404A0
        public void AddMatch(){} // RVA: 0x7FFE87740630
        public void BalanceMatch(){} // RVA: 0x7FFE87740800
        public void RemoveMatch(){} // RVA: 0x7FFE87740980
        public void IsMatched(){} // RVA: 0x7FFE877409B0
        public void MatchIndex(){} // RVA: 0x7FFE87740A30
        public void MatchLength(){} // RVA: 0x7FFE87740AC0
        public void Tidy(){} // RVA: 0x7FFE87740B50
        public void .cctor(){} // RVA: 0x7FFE87740CF0
    }

    public class MatchCollection : Object
    {
        public System.Text.RegularExpressions.Regex _regex; // 0x10
        public System.Collections.Generic.List`1<System.Text.RegularExpressions.Match> _matches; // 0x18
        public bool _done; // 0x20
        public string _input; // 0x28
        public int _beginning; // 0x30
        public int _length; // 0x34
        public int _startat; // 0x38
        public int _prevlen; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87741F00 | overloaded x2
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_Count(){} // RVA: 0x7FFE87741200
        public void get_Item(){} // RVA: 0x7FFE87741260
        public void GetEnumerator(){} // RVA: 0x7FFE87741310
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator(){} // RVA: 0x7FFE877413B0
        public void GetMatch(){} // RVA: 0x7FFE87741450
        public void EnsureInitialized(){} // RVA: 0x7FFE877415F0
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void CopyTo(){} // RVA: 0x7FFE87741690 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(){} // RVA: 0x7FFE87741720
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(){} // RVA: 0x7FFE877417C0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(){} // RVA: 0x7FFE87741810
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(){} // RVA: 0x7FFE87741860
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(){} // RVA: 0x7FFE87741880
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(){} // RVA: 0x7FFE877418D0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear(){} // RVA: 0x7FFE87741920
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(){} // RVA: 0x7FFE87741970
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(){} // RVA: 0x7FFE87741A30
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE87741A80
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE87741AD0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE87741B20
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE87741C70
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE87741DC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE811E0850
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE87741E10
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE87741E60
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE87741860
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE87741EB0
    }

    public class MatchEvaluator : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828B3580
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class MatchSparse : Match
    {
        public System.Collections.Hashtable _caps; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87740E10
        public void get_Groups(){} // RVA: 0x7FFE87740F10
    }

    public class Regex : Object
    {
        public int CacheDictionarySwitchLimit;
        public int s_cacheSize;
        public System.Collections.Generic.Dictionary`2<CachedCodeEntryKey,CachedCodeEntry> s_cache; // 0x8
        public int s_cacheCount; // 0x10

        // ── Methods ──
        public void get_CacheSize(){} // RVA: 0x7FFE87742190
        public void set_CacheSize(){} // RVA: 0x7FFE877421F0
        public void GetCachedCode(){} // RVA: 0x7FFE877425E0
        public void GetCachedCodeEntryInternal(){} // RVA: 0x7FFE877427A0
        public void FillCacheDictionary(){} // RVA: 0x7FFE87742FE0
        public void TryGetCacheValue(){} // RVA: 0x7FFE87743160
        public void TryGetCacheValueSmall(){} // RVA: 0x7FFE87743260
        public void LookupCachedAndPromote(){} // RVA: 0x7FFE87743460
        public void IsMatch(){} // RVA: 0x7FFE87743E60 | overloaded x5
        public void Match(){} // RVA: 0x7FFE87744260 | overloaded x6
        public void Matches(){} // RVA: 0x7FFE877445C0 | overloaded x5
        public void Replace(){} // RVA: 0x7FFE877451F0 | overloaded x11
        public void Split(){} // RVA: 0x7FFE87745C50 | overloaded x7
        public void .cctor(){} // RVA: 0x7FFE87746330
        public void get_MatchTimeout(){} // RVA: 0x7FFE81116380
        public void ValidateMatchTimeout(){} // RVA: 0x7FFE87746540
        public void InitDefaultMatchTimeout(){} // RVA: 0x7FFE87746680
        public void .ctor(){} // RVA: 0x7FFE87746A40 | overloaded x4
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87746A00
        public void Escape(){} // RVA: 0x7FFE87746F70
        public void Unescape(){} // RVA: 0x7FFE87747010
        public void get_Options(){} // RVA: 0x7FFE8151D690
        public void get_RightToLeft(){} // RVA: 0x7FFE865AB110
        public void ToString(){} // RVA: 0x7FFE810FE7C0
        public void GetGroupNames(){} // RVA: 0x7FFE877470B0
        public void GetGroupNumbers(){} // RVA: 0x7FFE87747290
        public void GroupNameFromNumber(){} // RVA: 0x7FFE877475C0
        public void GroupNumberFromName(){} // RVA: 0x7FFE87747710
        public void InitializeReferences(){} // RVA: 0x7FFE87747840
        public void Run(){} // RVA: 0x7FFE877479E0
        public void UseOptionR(){} // RVA: 0x7FFE865AB110
        public void UseOptionInvariant(){} // RVA: 0x7FFE865AB070
    }

    public class RegexBoyerMoore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87748380
        public void MatchPattern(){} // RVA: 0x7FFE87748AF0
        public void IsMatch(){} // RVA: 0x7FFE87748C50
        public void Scan(){} // RVA: 0x7FFE87748CC0
    }

    public class RegexCharClass : Object
    {
        public string s_internalRegexIgnoreCase;
        public string s_space; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87749240 | overloaded x2
        public void get_CanMerge(){} // RVA: 0x7FFE87749360
        public void set_Negate(){} // RVA: 0x7FFE818933B0
        public void AddChar(){} // RVA: 0x7FFE87749380
        public void AddCharClass(){} // RVA: 0x7FFE87749390
        public void AddSet(){} // RVA: 0x7FFE877495E0
        public void AddSubtraction(){} // RVA: 0x7FFE810FCE90
        public void AddRange(){} // RVA: 0x7FFE87749840
        public void AddCategoryFromName(){} // RVA: 0x7FFE87749970
        public void AddCategory(){} // RVA: 0x7FFE87749D30
        public void AddLowercase(){} // RVA: 0x7FFE87749D50
        public void AddLowercaseRange(){} // RVA: 0x7FFE87749ED0
        public void AddWord(){} // RVA: 0x7FFE8774A130
        public void AddSpace(){} // RVA: 0x7FFE8774A270
        public void AddDigit(){} // RVA: 0x7FFE8774A3B0
        public void SingletonChar(){} // RVA: 0x7FFE8774A470
        public void IsMergeable(){} // RVA: 0x7FFE8774A4A0
        public void IsEmpty(){} // RVA: 0x7FFE8774A550
        public void IsSingleton(){} // RVA: 0x7FFE8774A5F0
        public void IsSingletonInverse(){} // RVA: 0x7FFE8774A6D0
        public void IsSubtraction(){} // RVA: 0x7FFE8774A7B0
        public void IsNegated(){} // RVA: 0x7FFE8774A7F0
        public void IsECMAWordChar(){} // RVA: 0x7FFE8774A820
        public void IsWordChar(){} // RVA: 0x7FFE8774A8D0
        public void CharInClass(){} // RVA: 0x7FFE8774A9A0
        public void CharInClassRecursive(){} // RVA: 0x7FFE8774AA10
        public void CharInClassInternal(){} // RVA: 0x7FFE8774AB60
        public void CharInCategory(){} // RVA: 0x7FFE8774AD80
        public void CharInCategoryGroup(){} // RVA: 0x7FFE8774AF10
        public void NegateCategory(){} // RVA: 0x7FFE8774B000
        public void Parse(){} // RVA: 0x7FFE8774B110
        public void ParseRecursive(){} // RVA: 0x7FFE8774B170
        public void RangeCount(){} // RVA: 0x7FFE8774B510
        public void ToStringClass(){} // RVA: 0x7FFE8774B560
        public void GetRangeAt(){} // RVA: 0x7FFE8774B820
        public void Canonicalize(){} // RVA: 0x7FFE8774B890
        public void SetFromProperty(){} // RVA: 0x7FFE8774BB80
        public void .cctor(){} // RVA: 0x7FFE8774BE50
    }

    public class RegexCode : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87751220
        public void OpcodeBacktracks(){} // RVA: 0x7FFE87751480
    }

    public class RegexFC : Object
    {
        public System.Text.RegularExpressions.RegexCharClass _cc; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87752DD0 | overloaded x3
        public void AddFC(){} // RVA: 0x7FFE87752ED0
        public void get_CaseInsensitive(){} // RVA: 0x7FFE814B3730
        public void set_CaseInsensitive(){} // RVA: 0x7FFE81CD0510
        public void GetFirstChars(){} // RVA: 0x7FFE87752F60
    }

    public class RegexFCD : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877514E0
        public void FirstChars(){} // RVA: 0x7FFE87751600
        public void Prefix(){} // RVA: 0x7FFE87751990
        public void Anchors(){} // RVA: 0x7FFE87751CB0
        public void AnchorFromType(){} // RVA: 0x7FFE87751F40
        public void PushInt(){} // RVA: 0x7FFE87751FC0
        public void IntIsEmpty(){} // RVA: 0x7FFE87752010
        public void PopInt(){} // RVA: 0x7FFE87752050
        public void PushFC(){} // RVA: 0x7FFE877520A0
        public void FCIsEmpty(){} // RVA: 0x7FFE87752140
        public void PopFC(){} // RVA: 0x7FFE87752190
        public void TopFC(){} // RVA: 0x7FFE87752210
        public void Dispose(){} // RVA: 0x7FFE877522A0
        public void RegexFCFromRegexTree(){} // RVA: 0x7FFE877522E0
        public void SkipChild(){} // RVA: 0x7FFE876BC1E0
        public void CalculateFC(){} // RVA: 0x7FFE87752570
    }

    public class RegexInterpreter : RegexRunner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87752FA0
        public void InitTrackCount(){} // RVA: 0x7FFE87753060
        public void Advance(){} // RVA: 0x7FFE87753090
        public void Goto(){} // RVA: 0x7FFE87753110
        public void Textto(){} // RVA: 0x7FFE817E4800
        public void Trackto(){} // RVA: 0x7FFE877531A0
        public void Textstart(){} // RVA: 0x7FFE813DB630
        public void Textpos(){} // RVA: 0x7FFE81549710
        public void Trackpos(){} // RVA: 0x7FFE877531C0
        public void TrackPush(){} // RVA: 0x7FFE87753320 | overloaded x4
        public void TrackPush2(){} // RVA: 0x7FFE87753440 | overloaded x2
        public void Backtrack(){} // RVA: 0x7FFE877534D0
        public void SetOperator(){} // RVA: 0x7FFE877535B0
        public void TrackPop(){} // RVA: 0x7FFE877535F0 | overloaded x2
        public void TrackPeek(){} // RVA: 0x7FFE87753630 | overloaded x2
        public void StackPush(){} // RVA: 0x7FFE877536B0 | overloaded x2
        public void StackPop(){} // RVA: 0x7FFE87753710 | overloaded x2
        public void StackPeek(){} // RVA: 0x7FFE87753750 | overloaded x2
        public void Operator(){} // RVA: 0x7FFE814AA220
        public void Operand(){} // RVA: 0x7FFE87753790
        public void Leftchars(){} // RVA: 0x7FFE877537E0
        public void Rightchars(){} // RVA: 0x7FFE877537F0
        public void Bump(){} // RVA: 0x7FFE87753800
        public void Forwardchars(){} // RVA: 0x7FFE87753820
        public void Forwardcharnext(){} // RVA: 0x7FFE87753840
        public void Stringmatch(){} // RVA: 0x7FFE87753900
        public void Refmatch(){} // RVA: 0x7FFE87753A90
        public void Backwardnext(){} // RVA: 0x7FFE87753C80
        public void CharAt(){} // RVA: 0x7FFE87753CA0
        public void FindFirstChar(){} // RVA: 0x7FFE87753CE0
        public void Go(){} // RVA: 0x7FFE87754180
    }

    public class RegexMatchTimeoutException : TimeoutException
    {
        public string _input; // 0x90
        public string _pattern; // 0x98
        public System.TimeSpan _matchTimeout; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877568B0 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87756BB0
        public void get_Input(){} // RVA: 0x7FFE8154EB60
        public void get_Pattern(){} // RVA: 0x7FFE817AE360
        public void get_MatchTimeout(){} // RVA: 0x7FFE8179C860
    }

    public class RegexNode : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877570E0 | overloaded x5
        public void UseOptionR(){} // RVA: 0x7FFE87757100
        public void ReverseLeft(){} // RVA: 0x7FFE87757110
        public void MakeRep(){} // RVA: 0x7FFE877571C0
        public void Reduce(){} // RVA: 0x7FFE877571D0
        public void StripEnation(){} // RVA: 0x7FFE877572E0
        public void ReduceGroup(){} // RVA: 0x7FFE87757390
        public void ReduceRep(){} // RVA: 0x7FFE87757420
        public void ReduceSet(){} // RVA: 0x7FFE87757600
        public void ReduceAlternation(){} // RVA: 0x7FFE87757A30
        public void ReduceConcatenation(){} // RVA: 0x7FFE87757E60
        public void MakeQuantifier(){} // RVA: 0x7FFE87758260
        public void AddChild(){} // RVA: 0x7FFE87758350
        public void Child(){} // RVA: 0x7FFE87758670
        public void ChildCount(){} // RVA: 0x7FFE877586F0
        public void Type(){} // RVA: 0x7FFE811485C0
    }

    public class RegexParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFE87758740
        public void ParseReplacement(){} // RVA: 0x7FFE87758A30
        public void Escape(){} // RVA: 0x7FFE87758C60
        public void Unescape(){} // RVA: 0x7FFE87758E90
        public void .ctor(){} // RVA: 0x7FFE87759070
        public void SetPattern(){} // RVA: 0x7FFE87759210
        public void Reset(){} // RVA: 0x7FFE877592C0
        public void ScanRegex(){} // RVA: 0x7FFE877593F0
        public void ScanReplacement(){} // RVA: 0x7FFE87759CA0
        public void ScanCharClass(){} // RVA: 0x7FFE87759F10
        public void ScanGroupOpen(){} // RVA: 0x7FFE8775A7D0
        public void ScanBlank(){} // RVA: 0x7FFE8775B410
        public void ScanBackslash(){} // RVA: 0x7FFE8775B7A0
        public void ScanBasicBackslash(){} // RVA: 0x7FFE8775BD80
        public void ScanDollar(){} // RVA: 0x7FFE8775C440
        public void ScanCapname(){} // RVA: 0x7FFE8775C870
        public void ScanOctal(){} // RVA: 0x7FFE8775C940
        public void ScanDecimal(){} // RVA: 0x7FFE8775C9E0
        public void ScanHex(){} // RVA: 0x7FFE8775CA90
        public void HexDigit(){} // RVA: 0x7FFE8775CBC0
        public void ScanControl(){} // RVA: 0x7FFE8775CBF0
        public void IsOnlyTopOption(){} // RVA: 0x7FFE8775CCD0
        public void ScanOptions(){} // RVA: 0x7FFE8775CCF0
        public void ScanCharEscape(){} // RVA: 0x7FFE8775CE10
        public void ParseProperty(){} // RVA: 0x7FFE8775D1D0
        public void TypeFromCode(){} // RVA: 0x7FFE8775D3C0
        public void OptionFromCode(){} // RVA: 0x7FFE8775D440
        public void CountCaptures(){} // RVA: 0x7FFE8775D4D0
        public void NoteCaptureSlot(){} // RVA: 0x7FFE8775D870
        public void NoteCaptureName(){} // RVA: 0x7FFE8775D980
        public void NoteCaptures(){} // RVA: 0x7FFE8775DBE0
        public void AssignNameSlots(){} // RVA: 0x7FFE8775DCA0
        public void CaptureSlotFromName(){} // RVA: 0x7FFE8775E520
        public void IsCaptureSlot(){} // RVA: 0x7FFE8775E5B0
        public void IsCaptureName(){} // RVA: 0x7FFE8775E650
        public void UseOptionN(){} // RVA: 0x7FFE8775E680
        public void UseOptionI(){} // RVA: 0x7FFE8775E690
        public void UseOptionM(){} // RVA: 0x7FFE8775E6A0
        public void UseOptionS(){} // RVA: 0x7FFE8775E6B0
        public void UseOptionX(){} // RVA: 0x7FFE8775E6C0
        public void UseOptionE(){} // RVA: 0x7FFE8775E6D0
        public void IsSpecial(){} // RVA: 0x7FFE8775E6E0
        public void IsStopperX(){} // RVA: 0x7FFE8775E770
        public void IsQuantifier(){} // RVA: 0x7FFE8775E800
        public void IsTrueQuantifier(){} // RVA: 0x7FFE8775E890
        public void IsSpace(){} // RVA: 0x7FFE8775EA30
        public void IsMetachar(){} // RVA: 0x7FFE8775EAC0
        public void AddConcatenate(){} // RVA: 0x7FFE8775F520 | overloaded x3
        public void PushGroup(){} // RVA: 0x7FFE8775EE50
        public void PopGroup(){} // RVA: 0x7FFE8775EFE0
        public void EmptyStack(){} // RVA: 0x7FFE81CFE7A0
        public void StartGroup(){} // RVA: 0x7FFE8775F220
        public void AddAlternate(){} // RVA: 0x7FFE8775F3A0
        public void Unit(){} // RVA: 0x7FFE8144E200
        public void AddUnitOne(){} // RVA: 0x7FFE8775F690
        public void AddUnitNotone(){} // RVA: 0x7FFE8775F7A0
        public void AddUnitSet(){} // RVA: 0x7FFE8775F8B0
        public void AddUnitNode(){} // RVA: 0x7FFE81129890
        public void AddUnitType(){} // RVA: 0x7FFE8775F9C0
        public void AddGroup(){} // RVA: 0x7FFE8775FA80
        public void PushOptions(){} // RVA: 0x7FFE8775FC40
        public void PopOptions(){} // RVA: 0x7FFE8775FCE0
        public void EmptyOptionsStack(){} // RVA: 0x7FFE8775FDA0
        public void PopKeepOptions(){} // RVA: 0x7FFE8775FDF0
        public void MakeException(){} // RVA: 0x7FFE8775FE60
        public void Textpos(){} // RVA: 0x7FFE8119C080
        public void Textto(){} // RVA: 0x7FFE8119C090
        public void RightCharMoveRight(){} // RVA: 0x7FFE8775FEF0
        public void MoveRight(){} // RVA: 0x7FFE8775FF40 | overloaded x2
        public void MoveLeft(){} // RVA: 0x7FFE8775FF50
        public void CharAt(){} // RVA: 0x7FFE8775FF60
        public void RightChar(){} // RVA: 0x7FFE8775FFE0 | overloaded x2
        public void CharsRight(){} // RVA: 0x7FFE87760020
        public void .cctor(){} // RVA: 0x7FFE87760040
    }

    public class RegexPrefix : ValueType
    {
        public bool _caseInsensitive; // 0x10
        public System.Text.RegularExpressions.RegexPrefix _empty;
        public string _prefix; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87760120
        public void get_CaseInsensitive(){} // RVA: 0x7FFE82BC9920
        public void get_Empty(){} // RVA: 0x7FFE87760180
        public void get_Prefix(){} // RVA: 0x7FFE826F4210
        public void .cctor(){} // RVA: 0x7FFE877601E0
    }

    public class RegexReplacement : Object
    {
        public int Specials;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87760300
        public void GetOrCreate(){} // RVA: 0x7FFE87760830
        public void get_Pattern(){} // RVA: 0x7FFE811290C0
        public void ReplacementImpl(){} // RVA: 0x7FFE87760980
        public void ReplacementImplRTL(){} // RVA: 0x7FFE87760BD0
        public void Replacement(){} // RVA: 0x7FFE87760E00
        public void Replace(){} // RVA: 0x7FFE87761080
    }

    public class RegexRunner : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Scan(){} // RVA: 0x7FFE877618E0
        public void StartTimeoutWatch(){} // RVA: 0x7FFE87761C90
        public void CheckTimeout(){} // RVA: 0x7FFE87761CC0
        public void DoCheckTimeout(){} // RVA: 0x7FFE87761DA0
        public void Go(){} // RVA: 0x7FFE80E45FE0
        public void FindFirstChar(){} // RVA: 0x7FFE80E2F150
        public void InitTrackCount(){} // RVA: 0x7FFE80E45FE0
        public void InitMatch(){} // RVA: 0x7FFE87761E80
        public void TidyMatch(){} // RVA: 0x7FFE87762310
        public void EnsureStorage(){} // RVA: 0x7FFE877623C0
        public void IsBoundary(){} // RVA: 0x7FFE877625C0
        public void IsECMABoundary(){} // RVA: 0x7FFE877626D0
        public void DoubleTrack(){} // RVA: 0x7FFE877627E0
        public void DoubleStack(){} // RVA: 0x7FFE877628D0
        public void DoubleCrawl(){} // RVA: 0x7FFE877629C0
        public void Crawl(){} // RVA: 0x7FFE87762AB0
        public void Popcrawl(){} // RVA: 0x7FFE87762BE0
        public void Crawlpos(){} // RVA: 0x7FFE87762C20
        public void Capture(){} // RVA: 0x7FFE87762C40
        public void TransferCapture(){} // RVA: 0x7FFE87762CD0
        public void Uncapture(){} // RVA: 0x7FFE87762E00
        public void IsMatched(){} // RVA: 0x7FFE87762E50
        public void MatchIndex(){} // RVA: 0x7FFE87762E80
        public void MatchLength(){} // RVA: 0x7FFE87762EB0
    }

    public class RegexRunnerFactory : Object
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFE80E2E2E0
    }

    public class RegexTree : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87762EE0
    }

    public class RegexWriter : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877630A0
        public void Write(){} // RVA: 0x7FFE877631C0
        public void Dispose(){} // RVA: 0x7FFE87763400
        public void RegexCodeFromRegexTree(){} // RVA: 0x7FFE87763440
        public void PatchJump(){} // RVA: 0x7FFE87763B20
        public void Emit(){} // RVA: 0x7FFE87763CE0 | overloaded x3
        public void StringCode(){} // RVA: 0x7FFE87763DB0
        public void MapCapnum(){} // RVA: 0x7FFE87763F80
        public void EmitFragment(){} // RVA: 0x7FFE87764050
    }

}