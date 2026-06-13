// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.RegularExpressions
// Classes: 26
// Methods: 466

namespace ThirdParty.DotNet.System.Text.RegularExpressions
{
    public class Capture
    {
        public int Groups; // 0x10
        public int <Length>k__BackingField; // 0x14
        public string <Text>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BFC3F0
        public void get_Index(){} // RVA: 0x32A5C0
        public void set_Index(){} // RVA: 0x2E00C0
        public void get_Length(){} // RVA: 0x8ABED0
        public void set_Length(){} // RVA: 0x8AC660
        public void get_Text(){} // RVA: 0x2E07C0
        public void set_Text(){} // RVA: 0x343E80
        public void get_Value(){} // RVA: 0x6BFC460
        public void ToString(){} // RVA: 0x6BFC460
        public void GetLeftSubstring(){} // RVA: 0x6BFC490
        public void GetRightSubstring(){} // RVA: 0x6BFC520
    }

    public class CaptureCollection
    {
        public System.Text.RegularExpressions.Group _group; // 0x10
        public int _capcount; // 0x18
        public System.Text.RegularExpressions.Capture[] _captures; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BFC5E0
        public void get_IsReadOnly(){} // RVA: 0x3C2850
        public void get_Count(){} // RVA: 0x5BED50
        public void get_Item(){} // RVA: 0x6BFC650
        public void GetEnumerator(){} // RVA: 0x6BFC710
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator(){} // RVA: 0x6BFC7B0
        public void GetCapture(){} // RVA: 0x6BFC650
        public void ForceInitialized(){} // RVA: 0x6BFC850
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_SyncRoot(){} // RVA: 0x2F8380
        public void CopyTo(){} // RVA: 0x6BFCB80 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(){} // RVA: 0x6BFCD80
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(){} // RVA: 0x6BFCE30
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(){} // RVA: 0x6BFCE80
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(){} // RVA: 0x6BFCED0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(){} // RVA: 0x6BFCEE0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(){} // RVA: 0x6BFCF30
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear(){} // RVA: 0x6BFCF80
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(){} // RVA: 0x6BFCFD0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(){} // RVA: 0x6BFD030
        public void System.Collections.IList.Add(){} // RVA: 0x6BFD080
        public void System.Collections.IList.Clear(){} // RVA: 0x6BFD0D0
        public void System.Collections.IList.Contains(){} // RVA: 0x6BFD120
        public void System.Collections.IList.IndexOf(){} // RVA: 0x6BFD270
        public void System.Collections.IList.Insert(){} // RVA: 0x6BFD340
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x3C2850
        public void System.Collections.IList.Remove(){} // RVA: 0x6BFD390
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x6BFD3E0
        public void System.Collections.IList.get_Item(){} // RVA: 0x6BFCED0
        public void System.Collections.IList.set_Item(){} // RVA: 0x6BFD430
    }

    public class CollectionDebuggerProxy`1
    {
    }

    public class ExclusiveReference
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x6C01150
        public void Release(){} // RVA: 0x6C011D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Group
    {
        public System.Text.RegularExpressions.Group Index;
        public int[] Length; // 0x20
        public int Text; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BFD9D0 | overloaded x2
        public void get_Success(){} // RVA: 0x6BFD6F0
        public void get_Name(){} // RVA: 0x4976A0
        public void get_Captures(){} // RVA: 0x6BFD700
        public void Synchronized(){} // RVA: 0x6BFD810
        public void .cctor(){} // RVA: 0x6BFD8A0
    }

    public class GroupCollection
    {
        public System.Text.RegularExpressions.Match _match; // 0x10
        public System.Collections.Hashtable _captureMap; // 0x18
        public System.Text.RegularExpressions.Group[] _groups; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BFED10 | overloaded x2
        public void get_IsReadOnly(){} // RVA: 0x3C2850
        public void get_Count(){} // RVA: 0x6BFDA00
        public void get_Item(){} // RVA: 0x6BFDA40 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x6BFDAF0
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator(){} // RVA: 0x6BFDB90
        public void GetGroup(){} // RVA: 0x6BFDC30
        public void GetGroupImpl(){} // RVA: 0x6BFDFE0
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_SyncRoot(){} // RVA: 0x2F8380
        public void CopyTo(){} // RVA: 0x6BFE3A0 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(){} // RVA: 0x6BFE5F0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(){} // RVA: 0x6BFE6D0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(){} // RVA: 0x6BFE720
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(){} // RVA: 0x6BFDA30
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(){} // RVA: 0x6BFE770
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(){} // RVA: 0x6BFE7C0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear(){} // RVA: 0x6BFE810
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(){} // RVA: 0x6BFE860
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(){} // RVA: 0x6BFE8C0
        public void System.Collections.IList.Add(){} // RVA: 0x6BFE910
        public void System.Collections.IList.Clear(){} // RVA: 0x6BFE960
        public void System.Collections.IList.Contains(){} // RVA: 0x6BFE9B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x6BFEB00
        public void System.Collections.IList.Insert(){} // RVA: 0x6BFEBD0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x3C2850
        public void System.Collections.IList.Remove(){} // RVA: 0x6BFEC20
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x6BFEC70
        public void System.Collections.IList.get_Item(){} // RVA: 0x6BFDA30
        public void System.Collections.IList.set_Item(){} // RVA: 0x6BFECC0
    }

    public class Match
    {
        public System.Text.RegularExpressions.GroupCollection _groupcoll; // 0x40
        public System.Text.RegularExpressions.Regex _regex; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BFFF30 | overloaded x2
        public void get_Empty(){} // RVA: 0x6BFF060
        public void Reset(){} // RVA: 0x6BFF0C0
        public void get_Groups(){} // RVA: 0x6BFF1E0
        public void NextMatch(){} // RVA: 0x6BFF290
        public void Result(){} // RVA: 0x6BFF2E0
        public void GroupToStringImpl(){} // RVA: 0x6BFF3F0
        public void LastGroupToStringImpl(){} // RVA: 0x6BFF5A0
        public void Synchronized(){} // RVA: 0x6BFF5F0
        public void AddMatch(){} // RVA: 0x6BFF780
        public void BalanceMatch(){} // RVA: 0x6BFF950
        public void RemoveMatch(){} // RVA: 0x6BFFAD0
        public void IsMatched(){} // RVA: 0x6BFFB00
        public void MatchIndex(){} // RVA: 0x6BFFB80
        public void MatchLength(){} // RVA: 0x6BFFC10
        public void Tidy(){} // RVA: 0x6BFFCA0
        public void .cctor(){} // RVA: 0x6BFFE40
    }

    public class MatchCollection
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
        public void .ctor(){} // RVA: 0x6C01050 | overloaded x2
        public void get_IsReadOnly(){} // RVA: 0x3C2850
        public void get_Count(){} // RVA: 0x6C00350
        public void get_Item(){} // RVA: 0x6C003B0
        public void GetEnumerator(){} // RVA: 0x6C00460
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator(){} // RVA: 0x6C00500
        public void GetMatch(){} // RVA: 0x6C005A0
        public void EnsureInitialized(){} // RVA: 0x6C00740
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_SyncRoot(){} // RVA: 0x1A3F520
        public void CopyTo(){} // RVA: 0x6C007E0 | overloaded x2
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(){} // RVA: 0x6C00870
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(){} // RVA: 0x6C00910
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(){} // RVA: 0x6C00960
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(){} // RVA: 0x6C009B0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(){} // RVA: 0x6C009D0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(){} // RVA: 0x6C00A20
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear(){} // RVA: 0x6C00A70
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(){} // RVA: 0x6C00AC0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(){} // RVA: 0x6C00B80
        public void System.Collections.IList.Add(){} // RVA: 0x6C00BD0
        public void System.Collections.IList.Clear(){} // RVA: 0x6C00C20
        public void System.Collections.IList.Contains(){} // RVA: 0x6C00C70
        public void System.Collections.IList.IndexOf(){} // RVA: 0x6C00DC0
        public void System.Collections.IList.Insert(){} // RVA: 0x6C00F10
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x3C2850
        public void System.Collections.IList.Remove(){} // RVA: 0x6C00F60
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x6C00FB0
        public void System.Collections.IList.get_Item(){} // RVA: 0x6C009B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x6C01000
    }

    public class MatchEvaluator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B07170
        public void Invoke(){} // RVA: 0x338C60
    }

    public class MatchSparse
    {
        public System.Collections.Hashtable _caps; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BFFF60
        public void get_Groups(){} // RVA: 0x6C00060
    }

    public class Regex
    {
        public int CacheDictionarySwitchLimit;
        public int s_cacheSize;
        public System.Collections.Generic.Dictionary`2<CachedCodeEntryKey,CachedCodeEntry> s_cache; // 0x8
        public int s_cacheCount; // 0x10

        // ── Methods ──
        public void get_CacheSize(){} // RVA: 0x6C012E0
        public void set_CacheSize(){} // RVA: 0x6C01340
        public void GetCachedCode(){} // RVA: 0x6C01730
        public void GetCachedCodeEntryInternal(){} // RVA: 0x6C018F0
        public void FillCacheDictionary(){} // RVA: 0x6C02130
        public void TryGetCacheValue(){} // RVA: 0x6C022B0
        public void TryGetCacheValueSmall(){} // RVA: 0x6C023B0
        public void LookupCachedAndPromote(){} // RVA: 0x6C025B0
        public void IsMatch(){} // RVA: 0x6C02FB0 | overloaded x5
        public void Match(){} // RVA: 0x6C033B0 | overloaded x6
        public void Matches(){} // RVA: 0x6C03710 | overloaded x5
        public void Replace(){} // RVA: 0x6C04340 | overloaded x11
        public void Split(){} // RVA: 0x6C04DA0 | overloaded x7
        public void .cctor(){} // RVA: 0x6C05480
        public void get_MatchTimeout(){} // RVA: 0x2F8380
        public void ValidateMatchTimeout(){} // RVA: 0x6C05690
        public void InitDefaultMatchTimeout(){} // RVA: 0x6C057D0
        public void .ctor(){} // RVA: 0x6C05B90 | overloaded x4
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6C05B50
        public void Escape(){} // RVA: 0x6C060C0
        public void Unescape(){} // RVA: 0x6C06160
        public void get_Options(){} // RVA: 0x760030
        public void get_RightToLeft(){} // RVA: 0x5A6A410
        public void ToString(){} // RVA: 0x2E07C0
        public void GetGroupNames(){} // RVA: 0x6C06200
        public void GetGroupNumbers(){} // RVA: 0x6C063E0
        public void GroupNameFromNumber(){} // RVA: 0x6C06710
        public void GroupNumberFromName(){} // RVA: 0x6C06860
        public void InitializeReferences(){} // RVA: 0x6C06990
        public void Run(){} // RVA: 0x6C06B30
        public void UseOptionR(){} // RVA: 0x5A6A410
        public void UseOptionInvariant(){} // RVA: 0x5A6A370
    }

    public class RegexBoyerMoore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C074D0
        public void MatchPattern(){} // RVA: 0x6C07C40
        public void IsMatch(){} // RVA: 0x6C07DA0
        public void Scan(){} // RVA: 0x6C07E10
    }

    public class RegexCharClass
    {
        public string s_internalRegexIgnoreCase;
        public string s_space; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C08390 | overloaded x2
        public void get_CanMerge(){} // RVA: 0x6C084B0
        public void set_Negate(){} // RVA: 0xB265D0
        public void AddChar(){} // RVA: 0x6C084D0
        public void AddCharClass(){} // RVA: 0x6C084E0
        public void AddSet(){} // RVA: 0x6C08730
        public void AddSubtraction(){} // RVA: 0x2DEE90
        public void AddRange(){} // RVA: 0x6C08990
        public void AddCategoryFromName(){} // RVA: 0x6C08AC0
        public void AddCategory(){} // RVA: 0x6C08E80
        public void AddLowercase(){} // RVA: 0x6C08EA0
        public void AddLowercaseRange(){} // RVA: 0x6C09020
        public void AddWord(){} // RVA: 0x6C09280
        public void AddSpace(){} // RVA: 0x6C093C0
        public void AddDigit(){} // RVA: 0x6C09500
        public void SingletonChar(){} // RVA: 0x6C095C0
        public void IsMergeable(){} // RVA: 0x6C095F0
        public void IsEmpty(){} // RVA: 0x6C096A0
        public void IsSingleton(){} // RVA: 0x6C09740
        public void IsSingletonInverse(){} // RVA: 0x6C09820
        public void IsSubtraction(){} // RVA: 0x6C09900
        public void IsNegated(){} // RVA: 0x6C09940
        public void IsECMAWordChar(){} // RVA: 0x6C09970
        public void IsWordChar(){} // RVA: 0x6C09A20
        public void CharInClass(){} // RVA: 0x6C09AF0
        public void CharInClassRecursive(){} // RVA: 0x6C09B60
        public void CharInClassInternal(){} // RVA: 0x6C09CB0
        public void CharInCategory(){} // RVA: 0x6C09ED0
        public void CharInCategoryGroup(){} // RVA: 0x6C0A060
        public void NegateCategory(){} // RVA: 0x6C0A150
        public void Parse(){} // RVA: 0x6C0A260
        public void ParseRecursive(){} // RVA: 0x6C0A2C0
        public void RangeCount(){} // RVA: 0x6C0A660
        public void ToStringClass(){} // RVA: 0x6C0A6B0
        public void GetRangeAt(){} // RVA: 0x6C0A970
        public void Canonicalize(){} // RVA: 0x6C0A9E0
        public void SetFromProperty(){} // RVA: 0x6C0ACD0
        public void .cctor(){} // RVA: 0x6C0AFA0
    }

    public class RegexCode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C10370
        public void OpcodeBacktracks(){} // RVA: 0x6C105D0
    }

    public class RegexFC
    {
        public System.Text.RegularExpressions.RegexCharClass _cc; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C11F20 | overloaded x3
        public void AddFC(){} // RVA: 0x6C12020
        public void get_CaseInsensitive(){} // RVA: 0x6B93D0
        public void set_CaseInsensitive(){} // RVA: 0xF43D70
        public void GetFirstChars(){} // RVA: 0x6C120B0
    }

    public class RegexFCD
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C10630
        public void FirstChars(){} // RVA: 0x6C10750
        public void Prefix(){} // RVA: 0x6C10AE0
        public void Anchors(){} // RVA: 0x6C10E00
        public void AnchorFromType(){} // RVA: 0x6C11090
        public void PushInt(){} // RVA: 0x6C11110
        public void IntIsEmpty(){} // RVA: 0x6C11160
        public void PopInt(){} // RVA: 0x6C111A0
        public void PushFC(){} // RVA: 0x6C111F0
        public void FCIsEmpty(){} // RVA: 0x6C11290
        public void PopFC(){} // RVA: 0x6C112E0
        public void TopFC(){} // RVA: 0x6C11360
        public void Dispose(){} // RVA: 0x6C113F0
        public void RegexFCFromRegexTree(){} // RVA: 0x6C11430
        public void SkipChild(){} // RVA: 0x6B7CF30
        public void CalculateFC(){} // RVA: 0x6C116C0
    }

    public class RegexInterpreter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C120F0
        public void InitTrackCount(){} // RVA: 0x6C121B0
        public void Advance(){} // RVA: 0x6C121E0
        public void Goto(){} // RVA: 0x6C12260
        public void Textto(){} // RVA: 0xA53440
        public void Trackto(){} // RVA: 0x6C122F0
        public void Textstart(){} // RVA: 0x5BED50
        public void Textpos(){} // RVA: 0x791DC0
        public void Trackpos(){} // RVA: 0x6C12310
        public void TrackPush(){} // RVA: 0x6C12470 | overloaded x4
        public void TrackPush2(){} // RVA: 0x6C12590 | overloaded x2
        public void Backtrack(){} // RVA: 0x6C12620
        public void SetOperator(){} // RVA: 0x6C12700
        public void TrackPop(){} // RVA: 0x6C12740 | overloaded x2
        public void TrackPeek(){} // RVA: 0x6C12780 | overloaded x2
        public void StackPush(){} // RVA: 0x6C12800 | overloaded x2
        public void StackPop(){} // RVA: 0x6C12860 | overloaded x2
        public void StackPeek(){} // RVA: 0x6C128A0 | overloaded x2
        public void Operator(){} // RVA: 0x6AFD40
        public void Operand(){} // RVA: 0x6C128E0
        public void Leftchars(){} // RVA: 0x6C12930
        public void Rightchars(){} // RVA: 0x6C12940
        public void Bump(){} // RVA: 0x6C12950
        public void Forwardchars(){} // RVA: 0x6C12970
        public void Forwardcharnext(){} // RVA: 0x6C12990
        public void Stringmatch(){} // RVA: 0x6C12A50
        public void Refmatch(){} // RVA: 0x6C12BE0
        public void Backwardnext(){} // RVA: 0x6C12DD0
        public void CharAt(){} // RVA: 0x6C12DF0
        public void FindFirstChar(){} // RVA: 0x6C12E30
        public void Go(){} // RVA: 0x6C132D0
    }

    public class RegexMatchTimeoutException
    {
        public string <Input>k__BackingField; // 0x90
        public string <Pattern>k__BackingField; // 0x98
        public System.TimeSpan <MatchTimeout>k__BackingField; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C15A00 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6C15D00
        public void get_Input(){} // RVA: 0x796DE0
        public void get_Pattern(){} // RVA: 0xA1C8C0
        public void get_MatchTimeout(){} // RVA: 0xA085E0
    }

    public class RegexNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C16230 | overloaded x5
        public void UseOptionR(){} // RVA: 0x6C16250
        public void ReverseLeft(){} // RVA: 0x6C16260
        public void MakeRep(){} // RVA: 0x6C16310
        public void Reduce(){} // RVA: 0x6C16320
        public void StripEnation(){} // RVA: 0x6C16430
        public void ReduceGroup(){} // RVA: 0x6C164E0
        public void ReduceRep(){} // RVA: 0x6C16570
        public void ReduceSet(){} // RVA: 0x6C16750
        public void ReduceAlternation(){} // RVA: 0x6C16B80
        public void ReduceConcatenation(){} // RVA: 0x6C16FB0
        public void MakeQuantifier(){} // RVA: 0x6C173B0
        public void AddChild(){} // RVA: 0x6C174A0
        public void Child(){} // RVA: 0x6C177C0
        public void ChildCount(){} // RVA: 0x6C17840
        public void Type(){} // RVA: 0x32A5C0
    }

    public class RegexParser
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x6C17890
        public void ParseReplacement(){} // RVA: 0x6C17B80
        public void Escape(){} // RVA: 0x6C17DB0
        public void Unescape(){} // RVA: 0x6C17FE0
        public void .ctor(){} // RVA: 0x6C181C0
        public void SetPattern(){} // RVA: 0x6C18360
        public void Reset(){} // RVA: 0x6C18410
        public void ScanRegex(){} // RVA: 0x6C18540
        public void ScanReplacement(){} // RVA: 0x6C18DF0
        public void ScanCharClass(){} // RVA: 0x6C19060
        public void ScanGroupOpen(){} // RVA: 0x6C19920
        public void ScanBlank(){} // RVA: 0x6C1A560
        public void ScanBackslash(){} // RVA: 0x6C1A8F0
        public void ScanBasicBackslash(){} // RVA: 0x6C1AED0
        public void ScanDollar(){} // RVA: 0x6C1B590
        public void ScanCapname(){} // RVA: 0x6C1B9C0
        public void ScanOctal(){} // RVA: 0x6C1BA90
        public void ScanDecimal(){} // RVA: 0x6C1BB30
        public void ScanHex(){} // RVA: 0x6C1BBE0
        public void HexDigit(){} // RVA: 0x6C1BD10
        public void ScanControl(){} // RVA: 0x6C1BD40
        public void IsOnlyTopOption(){} // RVA: 0x6C1BE20
        public void ScanOptions(){} // RVA: 0x6C1BE40
        public void ScanCharEscape(){} // RVA: 0x6C1BF60
        public void ParseProperty(){} // RVA: 0x6C1C320
        public void TypeFromCode(){} // RVA: 0x6C1C510
        public void OptionFromCode(){} // RVA: 0x6C1C590
        public void CountCaptures(){} // RVA: 0x6C1C620
        public void NoteCaptureSlot(){} // RVA: 0x6C1C9C0
        public void NoteCaptureName(){} // RVA: 0x6C1CAD0
        public void NoteCaptures(){} // RVA: 0x6C1CD30
        public void AssignNameSlots(){} // RVA: 0x6C1CDF0
        public void CaptureSlotFromName(){} // RVA: 0x6C1D670
        public void IsCaptureSlot(){} // RVA: 0x6C1D700
        public void IsCaptureName(){} // RVA: 0x6C1D7A0
        public void UseOptionN(){} // RVA: 0x6C1D7D0
        public void UseOptionI(){} // RVA: 0x6C1D7E0
        public void UseOptionM(){} // RVA: 0x6C1D7F0
        public void UseOptionS(){} // RVA: 0x6C1D800
        public void UseOptionX(){} // RVA: 0x6C1D810
        public void UseOptionE(){} // RVA: 0x6C1D820
        public void IsSpecial(){} // RVA: 0x6C1D830
        public void IsStopperX(){} // RVA: 0x6C1D8C0
        public void IsQuantifier(){} // RVA: 0x6C1D950
        public void IsTrueQuantifier(){} // RVA: 0x6C1D9E0
        public void IsSpace(){} // RVA: 0x6C1DB80
        public void IsMetachar(){} // RVA: 0x6C1DC10
        public void AddConcatenate(){} // RVA: 0x6C1E670 | overloaded x3
        public void PushGroup(){} // RVA: 0x6C1DFA0
        public void PopGroup(){} // RVA: 0x6C1E130
        public void EmptyStack(){} // RVA: 0xF70920
        public void StartGroup(){} // RVA: 0x6C1E370
        public void AddAlternate(){} // RVA: 0x6C1E4F0
        public void Unit(){} // RVA: 0x6374D0
        public void AddUnitOne(){} // RVA: 0x6C1E7E0
        public void AddUnitNotone(){} // RVA: 0x6C1E8F0
        public void AddUnitSet(){} // RVA: 0x6C1EA00
        public void AddUnitNode(){} // RVA: 0x30B890
        public void AddUnitType(){} // RVA: 0x6C1EB10
        public void AddGroup(){} // RVA: 0x6C1EBD0
        public void PushOptions(){} // RVA: 0x6C1ED90
        public void PopOptions(){} // RVA: 0x6C1EE30
        public void EmptyOptionsStack(){} // RVA: 0x6C1EEF0
        public void PopKeepOptions(){} // RVA: 0x6C1EF40
        public void MakeException(){} // RVA: 0x6C1EFB0
        public void Textpos(){} // RVA: 0x37E080
        public void Textto(){} // RVA: 0x37E090
        public void RightCharMoveRight(){} // RVA: 0x6C1F040
        public void MoveRight(){} // RVA: 0x6C1F090 | overloaded x2
        public void MoveLeft(){} // RVA: 0x6C1F0A0
        public void CharAt(){} // RVA: 0x6C1F0B0
        public void RightChar(){} // RVA: 0x6C1F130 | overloaded x2
        public void CharsRight(){} // RVA: 0x6C1F170
        public void .cctor(){} // RVA: 0x6C1F190
    }

    public class RegexPrefix
    {
        public bool CaseInsensitive; // 0x10
        public System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField;
        public string <Prefix>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C1F270
        public void get_CaseInsensitive(){} // RVA: 0x1E40360
        public void get_Empty(){} // RVA: 0x6C1F2D0
        public void get_Prefix(){} // RVA: 0x19689C0
        public void .cctor(){} // RVA: 0x6C1F330
    }

    public class RegexReplacement
    {
        public int joystick;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C1F450
        public void GetOrCreate(){} // RVA: 0x6C1F980
        public void get_Pattern(){} // RVA: 0x30B0C0
        public void ReplacementImpl(){} // RVA: 0x6C1FAD0
        public void ReplacementImplRTL(){} // RVA: 0x6C1FD20
        public void Replacement(){} // RVA: 0x6C1FF50
        public void Replace(){} // RVA: 0x6C201D0
    }

    public class RegexRunner
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Scan(){} // RVA: 0x6C20A30
        public void StartTimeoutWatch(){} // RVA: 0x6C20DE0
        public void CheckTimeout(){} // RVA: 0x6C20E10
        public void DoCheckTimeout(){} // RVA: 0x6C20EF0
        public void Go(){} // RVA: 0x24A50
        public void FindFirstChar(){} // RVA: 0xDBE0
        public void InitTrackCount(){} // RVA: 0x24A50
        public void InitMatch(){} // RVA: 0x6C20FD0
        public void TidyMatch(){} // RVA: 0x6C21460
        public void EnsureStorage(){} // RVA: 0x6C21510
        public void IsBoundary(){} // RVA: 0x6C21710
        public void IsECMABoundary(){} // RVA: 0x6C21820
        public void DoubleTrack(){} // RVA: 0x6C21930
        public void DoubleStack(){} // RVA: 0x6C21A20
        public void DoubleCrawl(){} // RVA: 0x6C21B10
        public void Crawl(){} // RVA: 0x6C21C00
        public void Popcrawl(){} // RVA: 0x6C21D30
        public void Crawlpos(){} // RVA: 0x6C21D70
        public void Capture(){} // RVA: 0x6C21D90
        public void TransferCapture(){} // RVA: 0x6C21E20
        public void Uncapture(){} // RVA: 0x6C21F50
        public void IsMatched(){} // RVA: 0x6C21FA0
        public void MatchIndex(){} // RVA: 0x6C21FD0
        public void MatchLength(){} // RVA: 0x6C22000
    }

    public class RegexRunnerFactory
    {
        // ── Methods ──
        public void CreateInstance(){} // RVA: 0xCD60
    }

    public class RegexTree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C22030
    }

    public class RegexWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C221F0
        public void Write(){} // RVA: 0x6C22310
        public void Dispose(){} // RVA: 0x6C22550
        public void RegexCodeFromRegexTree(){} // RVA: 0x6C22590
        public void PatchJump(){} // RVA: 0x6C22C70
        public void Emit(){} // RVA: 0x6C22E30 | overloaded x3
        public void StringCode(){} // RVA: 0x6C22F00
        public void MapCapnum(){} // RVA: 0x6C230D0
        public void EmitFragment(){} // RVA: 0x6C231A0
    }

}