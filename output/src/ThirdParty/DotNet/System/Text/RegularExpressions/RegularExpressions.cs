// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.RegularExpressions
// Classes: 20
// Methods: 398

namespace ThirdParty.DotNet.System.Text.RegularExpressions
{
    public class Capture : Object
    {
        public int Index; // 0x10
        public int Length; // 0x14
        public string Text; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547B4B70
        public void get_Index(){} // RVA: 0x7FFD4E38E5C0
        public void set_Index(){} // RVA: 0x7FFD4E3440C0
        public void get_Length(){} // RVA: 0x7FFD4E7F5A20
        public void set_Length(){} // RVA: 0x7FFD4E7F4990
        public void get_Text(){} // RVA: 0x7FFD4E3447C0
        public void set_Text(){} // RVA: 0x7FFD4E3A7E80
        public void get_Value(){} // RVA: 0x7FFD547B4BE0
        public void ToString(){} // RVA: 0x7FFD547B4BE0
        public void GetLeftSubstring(){} // RVA: 0x7FFD547B4C10
        public void GetRightSubstring(){} // RVA: 0x7FFD547B4CA0
    }

    public class CaptureCollection : Object
    {
        public object IsReadOnly;
        public object Count;
        public object Item;
        public object IsSynchronized;
        public object SyncRoot;
        public object System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item;
        public object System.Collections.IList.IsFixedSize;
        public object System.Collections.IList.Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547B4D60
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E426850
        public void get_Count(){} // RVA: 0x7FFD4E577800
        public void get_Item(){} // RVA: 0x7FFD547B4DD0
        public void GetEnumerator(){} // RVA: 0x7FFD547B4E90
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator(){} // RVA: 0x7FFD547B4F30
        public void GetCapture(){} // RVA: 0x7FFD547B4DD0
        public void ForceInitialized(){} // RVA: 0x7FFD547B4FD0
        public void get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void get_SyncRoot(){} // RVA: 0x7FFD4E35C380
        public void CopyTo(){} // RVA: 0x7FFD547B5300 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(){} // RVA: 0x7FFD547B5500
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(){} // RVA: 0x7FFD547B55B0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(){} // RVA: 0x7FFD547B5600
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(){} // RVA: 0x7FFD547B5650
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(){} // RVA: 0x7FFD547B5660
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(){} // RVA: 0x7FFD547B56B0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear(){} // RVA: 0x7FFD547B5700
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(){} // RVA: 0x7FFD547B5750
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(){} // RVA: 0x7FFD547B57B0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD547B5800
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFD547B5850
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD547B58A0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD547B59F0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD547B5AC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E426850
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD547B5B10
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD547B5B60
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD547B5650
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD547B5BB0
    }

    public class ExclusiveReference : Object
    {
        public tor.p _ref; // 0x10
        public tor.p _obj; // 0x18
        public int _locked; // 0x20

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD547B98D0
        public void Release(){} // RVA: 0x7FFD547B9950
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Group : Capture
    {
        public tor.? Success;
        public int[] Name; // 0x20
        public int Captures; // 0x28
        public tor.<EnabledProtocols>k__BackingField _capcoll; // 0x30
        public string <Name>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547B6150 | overloaded x2
        public void get_Success(){} // RVA: 0x7FFD547B5E70
        public void get_Name(){} // RVA: 0x7FFD4E5F0140
        public void get_Captures(){} // RVA: 0x7FFD547B5E80
        public void Synchronized(){} // RVA: 0x7FFD547B5F90
        public void .cctor(){} // RVA: 0x7FFD547B6020
    }

    public class GroupCollection : Object
    {
        public tor.Instance IsReadOnly; // 0x10
        public mePatterns.MES_SIZE Count; // 0x18
        public tor.?[] Item; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547B7490 | overloaded x2
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E426850
        public void get_Count(){} // RVA: 0x7FFD547B6180
        public void get_Item(){} // RVA: 0x7FFD547B61C0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFD547B6270
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator(){} // RVA: 0x7FFD547B6310
        public void GetGroup(){} // RVA: 0x7FFD547B63B0
        public void GetGroupImpl(){} // RVA: 0x7FFD547B6760
        public void get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void get_SyncRoot(){} // RVA: 0x7FFD4E35C380
        public void CopyTo(){} // RVA: 0x7FFD547B6B20 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(){} // RVA: 0x7FFD547B6D70
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(){} // RVA: 0x7FFD547B6E50
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(){} // RVA: 0x7FFD547B6EA0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(){} // RVA: 0x7FFD547B61B0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(){} // RVA: 0x7FFD547B6EF0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(){} // RVA: 0x7FFD547B6F40
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear(){} // RVA: 0x7FFD547B6F90
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(){} // RVA: 0x7FFD547B6FE0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(){} // RVA: 0x7FFD547B7040
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD547B7090
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFD547B70E0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD547B7130
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD547B7280
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD547B7350
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E426850
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD547B73A0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD547B73F0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD547B61B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD547B7440
    }

    public class Match : Group
    {
        public tor.Id Empty; // 0x40
        public tor.neStore Groups; // 0x48
        public int _textbeg; // 0x50
        public int _textpos; // 0x54
        public int _textend; // 0x58
        public int _textstart; // 0x5C
        public int[][] _matches; // 0x60
        public int[] _matchcount; // 0x68
        public bool _balancing; // 0x70
        public tor.Instance <Empty>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547B86B0 | overloaded x2
        public void get_Empty(){} // RVA: 0x7FFD547B77E0
        public void Reset(){} // RVA: 0x7FFD547B7840
        public void get_Groups(){} // RVA: 0x7FFD547B7960
        public void NextMatch(){} // RVA: 0x7FFD547B7A10
        public void Result(){} // RVA: 0x7FFD547B7A60
        public void GroupToStringImpl(){} // RVA: 0x7FFD547B7B70
        public void LastGroupToStringImpl(){} // RVA: 0x7FFD547B7D20
        public void Synchronized(){} // RVA: 0x7FFD547B7D70
        public void AddMatch(){} // RVA: 0x7FFD547B7F00
        public void BalanceMatch(){} // RVA: 0x7FFD547B80D0
        public void RemoveMatch(){} // RVA: 0x7FFD547B8250
        public void IsMatched(){} // RVA: 0x7FFD547B8280
        public void MatchIndex(){} // RVA: 0x7FFD547B8300
        public void MatchLength(){} // RVA: 0x7FFD547B8390
        public void Tidy(){} // RVA: 0x7FFD547B8420
        public void .cctor(){} // RVA: 0x7FFD547B85C0
    }

    public class MatchSparse : Match
    {
        public mePatterns.MES_SIZE Groups; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547B86E0
        public void get_Groups(){} // RVA: 0x7FFD547B87E0
    }

    public class Regex : Object
    {
        public int CacheSize;
        public int MatchTimeout;
        public URA.DateTime<_btls_ssl_set_renegotiate_mode,tiate_pending> Options; // 0x8
        public int RightToLeft; // 0x10
        public tiate_pending s_cacheFirst; // 0x18
        public tiate_pending s_cacheLast; // 0x20
        public ializable.GetObjectData s_maximumMatchTimeout; // 0x28
        public string DefaultMatchTimeout_ConfigKeyName;
        public ializable.GetObjectData s_defaultMatchTimeout; // 0x30
        public ializable.GetObjectData InfiniteMatchTimeout; // 0x38
        public ializable.GetObjectData internalMatchTimeout; // 0x10
        public int MaxOptionShift;
        public string pattern; // 0x18
        public tor.F_SIGNED_CERT_IN_CHAIN roptions; // 0x20
        public tor.509_name_get_entry_count factory; // 0x28
        public mePatterns.MES_SIZE caps; // 0x30
        public mePatterns.MES_SIZE capnames; // 0x38
        public string[] capslist; // 0x40
        public int capsize; // 0x48
        public tor.re _runnerref; // 0x50
        public numValuesAndNames<tor.btls_x509_lookup_add_dir> _replref; // 0x58
        public tor.ck _code; // 0x60
        public bool _refsInitialized; // 0x68

        // ── Methods ──
        public void get_CacheSize(){} // RVA: 0x7FFD547B9A60
        public void set_CacheSize(){} // RVA: 0x7FFD547B9AC0
        public void GetCachedCode(){} // RVA: 0x7FFD547B9EB0
        public void GetCachedCodeEntryInternal(){} // RVA: 0x7FFD547BA070
        public void FillCacheDictionary(){} // RVA: 0x7FFD547BA8B0
        public void TryGetCacheValue(){} // RVA: 0x7FFD547BAA30
        public void TryGetCacheValueSmall(){} // RVA: 0x7FFD547BAB30
        public void LookupCachedAndPromote(){} // RVA: 0x7FFD547BAD30
        public void IsMatch(){} // RVA: 0x7FFD547BB730 | overloaded x5
        public void Match(){} // RVA: 0x7FFD547BBB30 | overloaded x6
        public void Matches(){} // RVA: 0x7FFD547BBE90 | overloaded x5
        public void Replace(){} // RVA: 0x7FFD547BCAC0 | overloaded x11
        public void Split(){} // RVA: 0x7FFD547BD520 | overloaded x7
        public void .cctor(){} // RVA: 0x7FFD547BDC00
        public void get_MatchTimeout(){} // RVA: 0x7FFD4E35C380
        public void ValidateMatchTimeout(){} // RVA: 0x7FFD547BDE10
        public void InitDefaultMatchTimeout(){} // RVA: 0x7FFD547BDF50
        public void .ctor(){} // RVA: 0x7FFD547BE310 | overloaded x4
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD547BE2D0
        public void Escape(){} // RVA: 0x7FFD547BE840
        public void Unescape(){} // RVA: 0x7FFD547BE8E0
        public void get_Options(){} // RVA: 0x7FFD4E4FBBE0
        public void get_RightToLeft(){} // RVA: 0x7FFD536217D0
        public void ToString(){} // RVA: 0x7FFD4E3447C0
        public void GetGroupNames(){} // RVA: 0x7FFD547BE980
        public void GetGroupNumbers(){} // RVA: 0x7FFD547BEB60
        public void GroupNameFromNumber(){} // RVA: 0x7FFD547BEE90
        public void GroupNumberFromName(){} // RVA: 0x7FFD547BEFE0
        public void InitializeReferences(){} // RVA: 0x7FFD547BF110
        public void Run(){} // RVA: 0x7FFD547BF2B0
        public void UseOptionR(){} // RVA: 0x7FFD536217D0
        public void UseOptionInvariant(){} // RVA: 0x7FFD53621730
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
        public 0.T_I8 _culture; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547BFC50
        public void MatchPattern(){} // RVA: 0x7FFD547C03C0
        public void IsMatch(){} // RVA: 0x7FFD547C0520
        public void Scan(){} // RVA: 0x7FFD547C0590
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
        public URA.DateTime<string,string> s_definedCategories; // 0x58
        public string[][] s_propTable; // 0x60
        public etClientCertificateIssuers[] s_lcTable; // 0x68
        public URA.woDigitYearMax<erNameCallback> _rangelist; // 0x10
        public em.MarkAborted.izeDefaultCase _categories; // 0x18
        public bool _canonical; // 0x20
        public bool _negate; // 0x21
        public tor.etRenegotiateMode _subtractor; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547C0B10 | overloaded x2
        public void get_CanMerge(){} // RVA: 0x7FFD547C0C30
        public void set_Negate(){} // RVA: 0x7FFD4EB8A610
        public void AddChar(){} // RVA: 0x7FFD547C0C50
        public void AddCharClass(){} // RVA: 0x7FFD547C0C60
        public void AddSet(){} // RVA: 0x7FFD547C0EB0
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void AddRange(){} // RVA: 0x7FFD547C1110
        public void AddCategoryFromName(){} // RVA: 0x7FFD547C1240
        public void AddCategory(){} // RVA: 0x7FFD547C1600
        public void AddLowercase(){} // RVA: 0x7FFD547C1620
        public void AddLowercaseRange(){} // RVA: 0x7FFD547C17A0
        public void AddWord(){} // RVA: 0x7FFD547C1A00
        public void AddSpace(){} // RVA: 0x7FFD547C1B40
        public void AddDigit(){} // RVA: 0x7FFD547C1C80
        public void SingletonChar(){} // RVA: 0x7FFD547C1D40
        public void IsMergeable(){} // RVA: 0x7FFD547C1D70
        public void IsEmpty(){} // RVA: 0x7FFD547C1E20
        public void IsSingleton(){} // RVA: 0x7FFD547C1EC0
        public void IsSingletonInverse(){} // RVA: 0x7FFD547C1FA0
        public void IsSubtraction(){} // RVA: 0x7FFD547C2080
        public void IsNegated(){} // RVA: 0x7FFD547C20C0
        public void IsECMAWordChar(){} // RVA: 0x7FFD547C20F0
        public void IsWordChar(){} // RVA: 0x7FFD547C21A0
        public void CharInClass(){} // RVA: 0x7FFD547C2270
        public void CharInClassRecursive(){} // RVA: 0x7FFD547C22E0
        public void CharInClassInternal(){} // RVA: 0x7FFD547C2430
        public void CharInCategory(){} // RVA: 0x7FFD547C2650
        public void CharInCategoryGroup(){} // RVA: 0x7FFD547C27E0
        public void NegateCategory(){} // RVA: 0x7FFD547C28D0
        public void Parse(){} // RVA: 0x7FFD547C29E0
        public void ParseRecursive(){} // RVA: 0x7FFD547C2A40
        public void RangeCount(){} // RVA: 0x7FFD547C2DE0
        public void ToStringClass(){} // RVA: 0x7FFD547C2E30
        public void GetRangeAt(){} // RVA: 0x7FFD547C30F0
        public void Canonicalize(){} // RVA: 0x7FFD547C3160
        public void SetFromProperty(){} // RVA: 0x7FFD547C3450
        public void .cctor(){} // RVA: 0x7FFD547C3720
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
        public mePatterns.MES_SIZE Caps; // 0x28
        public int CapSize; // 0x30
        public aphy<tor.oBtlsX509Lookup> FCPrefix; // 0x38
        public tor.iateCertificate BMPrefix; // 0x50
        public int Anchors; // 0x58
        public bool RightToLeft; // 0x5C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547C8AF0
        public void OpcodeBacktracks(){} // RVA: 0x7FFD547C8D50
    }

    public class RegexFC : Object
    {
        public tor.etRenegotiateMode CaseInsensitive; // 0x10
        public bool _nullable; // 0x18
        public bool <CaseInsensitive>k__BackingField; // 0x19

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547CA6A0 | overloaded x3
        public void AddFC(){} // RVA: 0x7FFD547CA7A0
        public void get_CaseInsensitive(){} // RVA: 0x7FFD4E648D50
        public void set_CaseInsensitive(){} // RVA: 0x7FFD4E935120
        public void GetFirstChars(){} // RVA: 0x7FFD547CA830
    }

    public class RegexInterpreter : RegexRunner
    {
        public tor.ck _code; // 0x80
        public 0.T_I8 _culture; // 0x88
        public int _operator; // 0x90
        public int _codepos; // 0x94
        public bool _rightToLeft; // 0x98
        public bool _caseInsensitive; // 0x99

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547CA870
        public void InitTrackCount(){} // RVA: 0x7FFD547CA930
        public void Advance(){} // RVA: 0x7FFD547CA960
        public void Goto(){} // RVA: 0x7FFD547CA9E0
        public void Textto(){} // RVA: 0x7FFD4EABA6E0
        public void Trackto(){} // RVA: 0x7FFD547CAA70
        public void Textstart(){} // RVA: 0x7FFD4E577800
        public void Textpos(){} // RVA: 0x7FFD4E70C4C0
        public void Trackpos(){} // RVA: 0x7FFD547CAA90
        public void TrackPush(){} // RVA: 0x7FFD547CABF0 | overloaded x4
        public void TrackPush2(){} // RVA: 0x7FFD547CAD10 | overloaded x2
        public void Backtrack(){} // RVA: 0x7FFD547CADA0
        public void SetOperator(){} // RVA: 0x7FFD547CAE80
        public void TrackPop(){} // RVA: 0x7FFD547CAEC0 | overloaded x2
        public void TrackPeek(){} // RVA: 0x7FFD547CAF00 | overloaded x2
        public void StackPush(){} // RVA: 0x7FFD547CAF80 | overloaded x2
        public void StackPop(){} // RVA: 0x7FFD547CAFE0 | overloaded x2
        public void StackPeek(){} // RVA: 0x7FFD547CB020 | overloaded x2
        public void Operator(){} // RVA: 0x7FFD4E640660
        public void Operand(){} // RVA: 0x7FFD547CB060
        public void Leftchars(){} // RVA: 0x7FFD547CB0B0
        public void Rightchars(){} // RVA: 0x7FFD547CB0C0
        public void Bump(){} // RVA: 0x7FFD547CB0D0
        public void Forwardchars(){} // RVA: 0x7FFD547CB0F0
        public void Forwardcharnext(){} // RVA: 0x7FFD547CB110
        public void Stringmatch(){} // RVA: 0x7FFD547CB1D0
        public void Refmatch(){} // RVA: 0x7FFD547CB360
        public void Backwardnext(){} // RVA: 0x7FFD547CB550
        public void CharAt(){} // RVA: 0x7FFD547CB570
        public void FindFirstChar(){} // RVA: 0x7FFD547CB5B0
        public void Go(){} // RVA: 0x7FFD547CBA50
    }

    public class RegexNode : Object
    {
        public int NType; // 0x10
        public URA.woDigitYearMax<tor.RROR_IN_CERT_NOT_BEFORE_FIELD> Children; // 0x18
        public string Str; // 0x20
        public char Ch; // 0x28
        public int M; // 0x2C
        public int N; // 0x30
        public tor.F_SIGNED_CERT_IN_CHAIN Options; // 0x34
        public tor.RROR_IN_CERT_NOT_BEFORE_FIELD Next; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547CE9B0 | overloaded x5
        public void UseOptionR(){} // RVA: 0x7FFD547CE9D0
        public void ReverseLeft(){} // RVA: 0x7FFD547CE9E0
        public void MakeRep(){} // RVA: 0x7FFD547CEA90
        public void Reduce(){} // RVA: 0x7FFD547CEAA0
        public void StripEnation(){} // RVA: 0x7FFD547CEBB0
        public void ReduceGroup(){} // RVA: 0x7FFD547CEC60
        public void ReduceRep(){} // RVA: 0x7FFD547CECF0
        public void ReduceSet(){} // RVA: 0x7FFD547CEED0
        public void ReduceAlternation(){} // RVA: 0x7FFD547CF300
        public void ReduceConcatenation(){} // RVA: 0x7FFD547CF730
        public void MakeQuantifier(){} // RVA: 0x7FFD547CFB30
        public void AddChild(){} // RVA: 0x7FFD547CFC20
        public void Child(){} // RVA: 0x7FFD547CFF40
        public void ChildCount(){} // RVA: 0x7FFD547CFFC0
        public void Type(){} // RVA: 0x7FFD4E38E5C0
    }

    public class RegexParser : Object
    {
        public tor.RROR_IN_CERT_NOT_BEFORE_FIELD _stack; // 0x10
        public tor.RROR_IN_CERT_NOT_BEFORE_FIELD _group; // 0x18
        public tor.RROR_IN_CERT_NOT_BEFORE_FIELD _alternation; // 0x20
        public tor.RROR_IN_CERT_NOT_BEFORE_FIELD _concatenation; // 0x28
        public tor.RROR_IN_CERT_NOT_BEFORE_FIELD _unit; // 0x30
        public string _pattern; // 0x38
        public int _currentPos; // 0x40
        public 0.T_I8 _culture; // 0x48
        public int _autocap; // 0x50
        public int _capcount; // 0x54
        public int _captop; // 0x58
        public int _capsize; // 0x5C
        public mePatterns.MES_SIZE _caps; // 0x60
        public mePatterns.MES_SIZE _capnames; // 0x68
        public int[] _capnumlist; // 0x70
        public URA.woDigitYearMax<string> _capnamelist; // 0x78
        public tor.F_SIGNED_CERT_IN_CHAIN _options; // 0x80
        public URA.woDigitYearMax<tor.F_SIGNED_CERT_IN_CHAIN> _optionsStack; // 0x88
        public bool _ignoreNextParen; // 0x90
        public byte[] s_category;

        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFD547D0010
        public void ParseReplacement(){} // RVA: 0x7FFD547D0300
        public void Escape(){} // RVA: 0x7FFD547D0530
        public void Unescape(){} // RVA: 0x7FFD547D0760
        public void .ctor(){} // RVA: 0x7FFD547D0940
        public void SetPattern(){} // RVA: 0x7FFD547D0AE0
        public void Reset(){} // RVA: 0x7FFD547D0B90
        public void ScanRegex(){} // RVA: 0x7FFD547D0CC0
        public void ScanReplacement(){} // RVA: 0x7FFD547D1570
        public void ScanCharClass(){} // RVA: 0x7FFD547D17E0
        public void ScanGroupOpen(){} // RVA: 0x7FFD547D20A0
        public void ScanBlank(){} // RVA: 0x7FFD547D2CE0
        public void ScanBackslash(){} // RVA: 0x7FFD547D3070
        public void ScanBasicBackslash(){} // RVA: 0x7FFD547D3650
        public void ScanDollar(){} // RVA: 0x7FFD547D3D10
        public void ScanCapname(){} // RVA: 0x7FFD547D4140
        public void ScanOctal(){} // RVA: 0x7FFD547D4210
        public void ScanDecimal(){} // RVA: 0x7FFD547D42B0
        public void ScanHex(){} // RVA: 0x7FFD547D4360
        public void HexDigit(){} // RVA: 0x7FFD547D4490
        public void ScanControl(){} // RVA: 0x7FFD547D44C0
        public void IsOnlyTopOption(){} // RVA: 0x7FFD547D45A0
        public void ScanOptions(){} // RVA: 0x7FFD547D45C0
        public void ScanCharEscape(){} // RVA: 0x7FFD547D46E0
        public void ParseProperty(){} // RVA: 0x7FFD547D4AA0
        public void TypeFromCode(){} // RVA: 0x7FFD547D4C90
        public void OptionFromCode(){} // RVA: 0x7FFD547D4D10
        public void CountCaptures(){} // RVA: 0x7FFD547D4DA0
        public void NoteCaptureSlot(){} // RVA: 0x7FFD547D5140
        public void NoteCaptureName(){} // RVA: 0x7FFD547D5250
        public void NoteCaptures(){} // RVA: 0x7FFD547D54B0
        public void AssignNameSlots(){} // RVA: 0x7FFD547D5570
        public void CaptureSlotFromName(){} // RVA: 0x7FFD547D5DF0
        public void IsCaptureSlot(){} // RVA: 0x7FFD547D5E80
        public void IsCaptureName(){} // RVA: 0x7FFD547D5F20
        public void UseOptionN(){} // RVA: 0x7FFD547D5F50
        public void UseOptionI(){} // RVA: 0x7FFD547D5F60
        public void UseOptionM(){} // RVA: 0x7FFD547D5F70
        public void UseOptionS(){} // RVA: 0x7FFD547D5F80
        public void UseOptionX(){} // RVA: 0x7FFD547D5F90
        public void UseOptionE(){} // RVA: 0x7FFD547D5FA0
        public void IsSpecial(){} // RVA: 0x7FFD547D5FB0
        public void IsStopperX(){} // RVA: 0x7FFD547D6040
        public void IsQuantifier(){} // RVA: 0x7FFD547D60D0
        public void IsTrueQuantifier(){} // RVA: 0x7FFD547D6160
        public void IsSpace(){} // RVA: 0x7FFD547D6300
        public void IsMetachar(){} // RVA: 0x7FFD547D6390
        public void AddConcatenate(){} // RVA: 0x7FFD547D6DF0 | overloaded x3
        public void PushGroup(){} // RVA: 0x7FFD547D6720
        public void PopGroup(){} // RVA: 0x7FFD547D68B0
        public void EmptyStack(){} // RVA: 0x7FFD4E95FA50
        public void StartGroup(){} // RVA: 0x7FFD547D6AF0
        public void AddAlternate(){} // RVA: 0x7FFD547D6C70
        public void Unit(){} // RVA: 0x7FFD4E5F95E0
        public void AddUnitOne(){} // RVA: 0x7FFD547D6F60
        public void AddUnitNotone(){} // RVA: 0x7FFD547D7070
        public void AddUnitSet(){} // RVA: 0x7FFD547D7180
        public void AddUnitNode(){} // RVA: 0x7FFD4E36F890
        public void AddUnitType(){} // RVA: 0x7FFD547D7290
        public void AddGroup(){} // RVA: 0x7FFD547D7350
        public void PushOptions(){} // RVA: 0x7FFD547D7510
        public void PopOptions(){} // RVA: 0x7FFD547D75B0
        public void EmptyOptionsStack(){} // RVA: 0x7FFD547D7670
        public void PopKeepOptions(){} // RVA: 0x7FFD547D76C0
        public void MakeException(){} // RVA: 0x7FFD547D7730
        public void Textpos(){} // RVA: 0x7FFD4E3E2080
        public void Textto(){} // RVA: 0x7FFD4E3E2090
        public void RightCharMoveRight(){} // RVA: 0x7FFD547D77C0
        public void MoveRight(){} // RVA: 0x7FFD547D7810 | overloaded x2
        public void MoveLeft(){} // RVA: 0x7FFD547D7820
        public void CharAt(){} // RVA: 0x7FFD547D7830
        public void RightChar(){} // RVA: 0x7FFD547D78B0 | overloaded x2
        public void CharsRight(){} // RVA: 0x7FFD547D78F0
        public void .cctor(){} // RVA: 0x7FFD547D7910
    }

    public class RegexPrefix : ValueType
    {
        public bool CaseInsensitive; // 0x10
        public tor.oBtlsX509Lookup Empty;
        public string Prefix; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547D79F0
        public void get_CaseInsensitive(){} // RVA: 0x7FFD4FD7DDF0
        public void get_Empty(){} // RVA: 0x7FFD547D7A50
        public void get_Prefix(){} // RVA: 0x7FFD4F840220
        public void .cctor(){} // RVA: 0x7FFD547D7AB0
    }

    public class RegexReplacement : Object
    {
        public int Pattern;
        public int LeftPortion;
        public int RightPortion;
        public int LastGroup;
        public int WholeString;
        public URA.woDigitYearMax<string> _strings; // 0x10
        public URA.woDigitYearMax<int> _rules; // 0x18
        public string <Pattern>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547D7BD0
        public void GetOrCreate(){} // RVA: 0x7FFD547D8100
        public void get_Pattern(){} // RVA: 0x7FFD4E36F0C0
        public void ReplacementImpl(){} // RVA: 0x7FFD547D8250
        public void ReplacementImplRTL(){} // RVA: 0x7FFD547D84A0
        public void Replacement(){} // RVA: 0x7FFD547D86D0
        public void Replace(){} // RVA: 0x7FFD547D8950
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
        public tor.Instance runmatch; // 0x60
        public tor.neStore runregex; // 0x68
        public int _timeout; // 0x70
        public bool _ignoreTimeout; // 0x74
        public int _timeoutOccursAt; // 0x78
        public int TimeoutCheckFrequency;
        public int _timeoutChecksToSkip; // 0x7C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Scan(){} // RVA: 0x7FFD547D91B0
        public void StartTimeoutWatch(){} // RVA: 0x7FFD547D9560
        public void CheckTimeout(){} // RVA: 0x7FFD547D9590
        public void DoCheckTimeout(){} // RVA: 0x7FFD547D9670
        public void Go(){} // RVA: 0x7FFD4E090980
        public void FindFirstChar(){} // RVA: 0x7FFD4E079D00
        public void InitTrackCount(){} // RVA: 0x7FFD4E090980
        public void InitMatch(){} // RVA: 0x7FFD547D9750
        public void TidyMatch(){} // RVA: 0x7FFD547D9BE0
        public void EnsureStorage(){} // RVA: 0x7FFD547D9C90
        public void IsBoundary(){} // RVA: 0x7FFD547D9E90
        public void IsECMABoundary(){} // RVA: 0x7FFD547D9FA0
        public void DoubleTrack(){} // RVA: 0x7FFD547DA0B0
        public void DoubleStack(){} // RVA: 0x7FFD547DA1A0
        public void DoubleCrawl(){} // RVA: 0x7FFD547DA290
        public void Crawl(){} // RVA: 0x7FFD547DA380
        public void Popcrawl(){} // RVA: 0x7FFD547DA4B0
        public void Crawlpos(){} // RVA: 0x7FFD547DA4F0
        public void Capture(){} // RVA: 0x7FFD547DA510
        public void TransferCapture(){} // RVA: 0x7FFD547DA5A0
        public void Uncapture(){} // RVA: 0x7FFD547DA6D0
        public void IsMatched(){} // RVA: 0x7FFD547DA720
        public void MatchIndex(){} // RVA: 0x7FFD547DA750
        public void MatchLength(){} // RVA: 0x7FFD547DA780
    }

    public class RegexRunnerFactory : Object
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0x7FFD4E078E90
    }

    public class RegexTree : Object
    {
        public tor.RROR_IN_CERT_NOT_BEFORE_FIELD Root; // 0x10
        public mePatterns.MES_SIZE Caps; // 0x18
        public int[] CapNumList; // 0x20
        public int CapTop; // 0x28
        public mePatterns.MES_SIZE CapNames; // 0x30
        public string[] CapsList; // 0x38
        public tor.F_SIGNED_CERT_IN_CHAIN Options; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547DA7B0
    }

}