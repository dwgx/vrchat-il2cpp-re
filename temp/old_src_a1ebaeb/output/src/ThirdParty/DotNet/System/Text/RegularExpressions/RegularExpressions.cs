// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.RegularExpressions
// Classes: 20
// Methods: 398

namespace ThirdParty.DotNet.System.Text.RegularExpressions
{
    public class Capture : Object
    {
        public object _text; // 0x34DEA2D0, was: <Text>k__BackingField
        public object Index; // 0x170000C9

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedb6b40
        public void get_Index(){} // RVA: 0x7ffaa897f5c0
        public void set_Index(){} // RVA: 0x7ffaa89350c0
        public void get_Length(){} // RVA: 0x7ffaa8e046c0
        public void set_Length(){} // RVA: 0x7ffaa8e03640
        public void get_Text(){} // RVA: 0x7ffaa89357c0
        public void set_Text(){} // RVA: 0x7ffaa8998e80
        public void get_Value(){} // RVA: 0x7ffaaedb6bb0
        public void ToString(){} // RVA: 0x7ffaaedb6bb0
        // ── Binary Analysis Named ──
        public void GetLeftSubstring(){} // RVA: 0x7ffaaedb6be0
        public void GetRightSubstring(){} // RVA: 0x7ffaaedb6c70
    }

    public class CaptureCollection : Object
    {
        public object _captures; // 0x35CE2890
        public object IsReadOnly; // 0x170000CD

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedb6d30
        public void get_IsReadOnly(){} // RVA: 0x7ffaa8a17850
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void get_Item(){} // RVA: 0x7ffaaedb6da0
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator(){} // RVA: 0x7ffaaedb6f00
        public void ForceInitialized(){} // RVA: 0x7ffaaedb6fa0
        public void get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void get_SyncRoot(){} // RVA: 0x7ffaa894d380
        public void CopyTo(){} // RVA: 0x7ffaaedb72d0
        public void CopyTo(){} // RVA: 0x7ffaaedb72d0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(){} // RVA: 0x7ffaaedb74d0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(){} // RVA: 0x7ffaaedb7580
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(){} // RVA: 0x7ffaaedb75d0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(){} // RVA: 0x7ffaaedb7620
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(){} // RVA: 0x7ffaaedb7630
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(){} // RVA: 0x7ffaaedb7680
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear(){} // RVA: 0x7ffaaedb76d0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(){} // RVA: 0x7ffaaedb7720
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(){} // RVA: 0x7ffaaedb7780
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaaedb77d0
        public void System.Collections.IList.Clear(){} // RVA: 0x7ffaaedb7820
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaaedb7870
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaaedb79c0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaaedb7a90
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8a17850
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaaedb7ae0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7ffaaedb7b30
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaaedb7620
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaaedb7b80
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaedb6e60
        public void GetCapture(){} // RVA: 0x7ffaaedb6da0
    }

    public class ExclusiveReference : Object
    {
        public object _locked; // 0x34D68030

        // ── Original Methods ──
        public void Release(){} // RVA: 0x7ffaaedbb920
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaaedbb8a0
    }

    public class Group : Capture
    {
        public object _capcount; // 0x34DEA150

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedb8120
        public void get_Success(){} // RVA: 0x7ffaaedb7e40
        public void get_Name(){} // RVA: 0x7ffaa8bf45b0
        public void get_Captures(){} // RVA: 0x7ffaaedb7e50
        public void Synchronized(){} // RVA: 0x7ffaaedb7f60
        public void .cctor(){} // RVA: 0x7ffaaedb7ff0
        public void .ctor(){} // RVA: 0x7ffaaedb8120
    }

    public class GroupCollection : Object
    {
        public object _groups; // 0x34DEA680
        public object IsReadOnly; // 0x170000DA

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedb9460
        public void get_IsReadOnly(){} // RVA: 0x7ffaa8a17850
        public void get_Count(){} // RVA: 0x7ffaaedb8150
        public void get_Item(){} // RVA: 0x7ffaaedb8190
        public void get_Item(){} // RVA: 0x7ffaaedb8190
        public void System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator(){} // RVA: 0x7ffaaedb82e0
        public void get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void get_SyncRoot(){} // RVA: 0x7ffaa894d380
        public void CopyTo(){} // RVA: 0x7ffaaedb8af0
        public void CopyTo(){} // RVA: 0x7ffaaedb8af0
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(){} // RVA: 0x7ffaaedb8d40
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(){} // RVA: 0x7ffaaedb8e20
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(){} // RVA: 0x7ffaaedb8e70
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(){} // RVA: 0x7ffaaedb8180
        public void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(){} // RVA: 0x7ffaaedb8ec0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(){} // RVA: 0x7ffaaedb8f10
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear(){} // RVA: 0x7ffaaedb8f60
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(){} // RVA: 0x7ffaaedb8fb0
        public void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(){} // RVA: 0x7ffaaedb9010
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaaedb9060
        public void System.Collections.IList.Clear(){} // RVA: 0x7ffaaedb90b0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaaedb9100
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaaedb9250
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaaedb9320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8a17850
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaaedb9370
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7ffaaedb93c0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaaedb8180
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaaedb9410
        public void .ctor(){} // RVA: 0x7ffaaedb9460
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaedb8240
        public void GetGroup(){} // RVA: 0x7ffaaedb8380
        public void GetGroupImpl(){} // RVA: 0x7ffaaedb8730
    }

    public class Match : Group
    {
        public object _textbeg; // 0x34DE9F20
        public object _textstart; // 0x34DE9F20
        public object _balancing; // 0x34DE9F20

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedba680
        public void get_Empty(){} // RVA: 0x7ffaaedb97b0
        public void Reset(){} // RVA: 0x7ffaaedb9810
        public void get_Groups(){} // RVA: 0x7ffaaedb9930
        public void NextMatch(){} // RVA: 0x7ffaaedb99e0
        public void Result(){} // RVA: 0x7ffaaedb9a30
        public void GroupToStringImpl(){} // RVA: 0x7ffaaedb9b40
        public void LastGroupToStringImpl(){} // RVA: 0x7ffaaedb9cf0
        public void Synchronized(){} // RVA: 0x7ffaaedb9d40
        public void AddMatch(){} // RVA: 0x7ffaaedb9ed0
        public void BalanceMatch(){} // RVA: 0x7ffaaedba0a0
        public void RemoveMatch(){} // RVA: 0x7ffaaedba220
        public void IsMatched(){} // RVA: 0x7ffaaedba250
        public void MatchIndex(){} // RVA: 0x7ffaaedba2d0
        public void MatchLength(){} // RVA: 0x7ffaaedba360
        public void Tidy(){} // RVA: 0x7ffaaedba3f0
        public void .cctor(){} // RVA: 0x7ffaaedba590
        public void .ctor(){} // RVA: 0x7ffaaedba680
    }

    public class MatchSparse : Match
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedba6b0
        public void get_Groups(){} // RVA: 0x7ffaaedba7b0
    }

    public class Regex : Object
    {
        public object s_cache; // 0x34C27510
        public object s_cacheLast; // 0x34C27510
        public object s_defaultMatchTimeout; // 0x34C27510
        public object MaxOptionShift; // 0x34C27510
        public object factory; // 0x34C27510
        public object capslist; // 0x34C27510
        public object _replref; // 0x34C27510
        public object .cctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void get_CacheSize(){} // RVA: 0x7ffaaedbba30
        public void set_CacheSize(){} // RVA: 0x7ffaaedbba90
        public void FillCacheDictionary(){} // RVA: 0x7ffaaedbc880
        public void TryGetCacheValue(){} // RVA: 0x7ffaaedbca00
        public void TryGetCacheValueSmall(){} // RVA: 0x7ffaaedbcb00
        public void LookupCachedAndPromote(){} // RVA: 0x7ffaaedbcd00
        public void IsMatch(){} // RVA: 0x7ffaaedbd700
        public void IsMatch(){} // RVA: 0x7ffaaedbd700
        public void IsMatch(){} // RVA: 0x7ffaaedbd700
        public void IsMatch(){} // RVA: 0x7ffaaedbd700
        public void IsMatch(){} // RVA: 0x7ffaaedbd700
        public void Match(){} // RVA: 0x7ffaaedbdb00
        public void Match(){} // RVA: 0x7ffaaedbdb00
        public void Match(){} // RVA: 0x7ffaaedbdb00
        public void Match(){} // RVA: 0x7ffaaedbdb00
        public void Match(){} // RVA: 0x7ffaaedbdb00
        public void Match(){} // RVA: 0x7ffaaedbdb00
        public void Matches(){} // RVA: 0x7ffaaedbde60
        public void Matches(){} // RVA: 0x7ffaaedbde60
        public void Matches(){} // RVA: 0x7ffaaedbde60
        public void Matches(){} // RVA: 0x7ffaaedbde60
        public void Matches(){} // RVA: 0x7ffaaedbde60
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Replace(){} // RVA: 0x7ffaaedbea90
        public void Split(){} // RVA: 0x7ffaaedbf4f0
        public void Split(){} // RVA: 0x7ffaaedbf4f0
        public void Split(){} // RVA: 0x7ffaaedbf4f0
        public void Split(){} // RVA: 0x7ffaaedbf4f0
        public void Split(){} // RVA: 0x7ffaaedbf4f0
        public void Split(){} // RVA: 0x7ffaaedbf4f0
        public void Split(){} // RVA: 0x7ffaaedbf4f0
        public void .cctor(){} // RVA: 0x7ffaaedbfbd0
        public void get_MatchTimeout(){} // RVA: 0x7ffaa894d380
        public void ValidateMatchTimeout(){} // RVA: 0x7ffaaedbfde0
        public void InitDefaultMatchTimeout(){} // RVA: 0x7ffaaedbff20
        public void .ctor(){} // RVA: 0x7ffaaedc02e0
        public void .ctor(){} // RVA: 0x7ffaaedc02e0
        public void .ctor(){} // RVA: 0x7ffaaedc02e0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ffaaedc02a0
        public void .ctor(){} // RVA: 0x7ffaaedc02e0
        public void Escape(){} // RVA: 0x7ffaaedc0810
        public void Unescape(){} // RVA: 0x7ffaaedc08b0
        public void get_Options(){} // RVA: 0x7ffaa8aeced0
        public void get_RightToLeft(){} // RVA: 0x7ffaadc22980
        public void ToString(){} // RVA: 0x7ffaa89357c0
        public void GroupNameFromNumber(){} // RVA: 0x7ffaaedc0e60
        public void GroupNumberFromName(){} // RVA: 0x7ffaaedc0fb0
        public void InitializeReferences(){} // RVA: 0x7ffaaedc10e0
        public void Run(){} // RVA: 0x7ffaaedc1280
        public void UseOptionR(){} // RVA: 0x7ffaadc22980
        public void UseOptionInvariant(){} // RVA: 0x7ffaadc228e0
        // ── Binary Analysis Named ──
        public void GetCachedCode(){} // RVA: 0x7ffaaedbbe80
        public void GetCachedCodeEntryInternal(){} // RVA: 0x7ffaaedbc040
        public void GetGroupNames(){} // RVA: 0x7ffaaedc0950
        public void GetGroupNumbers(){} // RVA: 0x7ffaaedc0b30
    }

    public class RegexBoyerMoore : Object
    {
        public object NegativeUnicode; // 0x34CA7960
        public object HighASCII; // 0x34CA7960
        public object _culture; // 0x34CA7960
        public object OpcodeBacktracks; // 0xB41EFD10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedc1c20
        public void MatchPattern(){} // RVA: 0x7ffaaedc2390
        public void IsMatch(){} // RVA: 0x7ffaaedc24f0
        public void Scan(){} // RVA: 0x7ffaaedc2560
    }

    public class RegexCharClass : Object
    {
        public object s_notSpace; // 0x34CA7050
        public object SpaceClass; // 0x34CA7050
        public object NotWordClass; // 0x34CA7050
        public object s_definedCategories; // 0x34CA7050
        public object _rangelist; // 0x34CA7050
        public object _negate; // 0x34CA7050

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedc2ae0
        public void .ctor(){} // RVA: 0x7ffaaedc2ae0
        public void get_CanMerge(){} // RVA: 0x7ffaaedc2c00
        public void set_Negate(){} // RVA: 0x7ffaa91942c0
        public void AddChar(){} // RVA: 0x7ffaaedc2c20
        public void AddCharClass(){} // RVA: 0x7ffaaedc2c30
        public void AddSet(){} // RVA: 0x7ffaaedc2e80
        public void AddSubtraction(){} // RVA: 0x7ffaa8933e90
        public void AddRange(){} // RVA: 0x7ffaaedc30e0
        public void AddCategoryFromName(){} // RVA: 0x7ffaaedc3210
        public void AddCategory(){} // RVA: 0x7ffaaedc35d0
        public void AddLowercase(){} // RVA: 0x7ffaaedc35f0
        public void AddLowercaseRange(){} // RVA: 0x7ffaaedc3770
        public void AddWord(){} // RVA: 0x7ffaaedc39d0
        public void AddSpace(){} // RVA: 0x7ffaaedc3b10
        public void AddDigit(){} // RVA: 0x7ffaaedc3c50
        public void SingletonChar(){} // RVA: 0x7ffaaedc3d10
        public void IsMergeable(){} // RVA: 0x7ffaaedc3d40
        public void IsEmpty(){} // RVA: 0x7ffaaedc3df0
        public void IsSingleton(){} // RVA: 0x7ffaaedc3e90
        public void IsSingletonInverse(){} // RVA: 0x7ffaaedc3f70
        public void IsSubtraction(){} // RVA: 0x7ffaaedc4050
        public void IsNegated(){} // RVA: 0x7ffaaedc4090
        public void IsECMAWordChar(){} // RVA: 0x7ffaaedc40c0
        public void IsWordChar(){} // RVA: 0x7ffaaedc4170
        public void CharInClass(){} // RVA: 0x7ffaaedc4240
        public void CharInClassRecursive(){} // RVA: 0x7ffaaedc42b0
        public void CharInClassInternal(){} // RVA: 0x7ffaaedc4400
        public void CharInCategory(){} // RVA: 0x7ffaaedc4620
        public void CharInCategoryGroup(){} // RVA: 0x7ffaaedc47b0
        public void NegateCategory(){} // RVA: 0x7ffaaedc48a0
        public void Parse(){} // RVA: 0x7ffaaedc49b0
        public void ParseRecursive(){} // RVA: 0x7ffaaedc4a10
        public void RangeCount(){} // RVA: 0x7ffaaedc4db0
        public void ToStringClass(){} // RVA: 0x7ffaaedc4e00
        public void Canonicalize(){} // RVA: 0x7ffaaedc5130
        public void .cctor(){} // RVA: 0x7ffaaedc56f0
        // ── Binary Analysis Named ──
        public void GetRangeAt(){} // RVA: 0x7ffaaedc50c0
        public void SetFromProperty(){} // RVA: 0x7ffaaedc5420
    }

    public class RegexCode : Object
    {
        public object Setrep; // 0x34CA7AE0
        public object Setloop; // 0x34CA7AE0
        public object Setlazy; // 0x34CA7AE0
        public object Set; // 0x34CA7AE0
        public object Bol; // 0x34CA7AE0
        public object Nonboundary; // 0x34CA7AE0
        public object EndZ; // 0x34CA7AE0
        public object Lazybranch; // 0x34CA7AE0
        public object Nullcount; // 0x34CA7AE0
        public object Lazybranchcount; // 0x34CA7AE0
        public object Capturemark; // 0x34CA7AE0
        public object Backjump; // 0x34CA7AE0
        public object Goto; // 0x34CA7AE0
        public object ECMABoundary; // 0x34CA7AE0
        public object Rtl; // 0x34CA7AE0
        public object Ci; // 0x34CA7AE0
        public object TrackCount; // 0x34CA7AE0
        public object FCPrefix; // 0x34CA7AE0
        public object RightToLeft; // 0x34CA7AE0
        public object `; // 0x31267688
        public object get_Value; // 0xB3FA0CD0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedcaac0
        public void OpcodeBacktracks(){} // RVA: 0x7ffaaedcad20
    }

    public class RegexFC : Object
    {
        public object _caseInsensitive; // 0x34CA7DE0, was: <CaseInsensitive>k__BackingFie
        public object Capacity; // 0x170008CD

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedcc670
        public void .ctor(){} // RVA: 0x7ffaaedcc670
        public void .ctor(){} // RVA: 0x7ffaaedcc670
        public void AddFC(){} // RVA: 0x7ffaaedcc770
        public void get_CaseInsensitive(){} // RVA: 0x7ffaa8c53420
        public void set_CaseInsensitive(){} // RVA: 0x7ffaa8f41f20
        // ── Binary Analysis Named ──
        public void GetFirstChars(){} // RVA: 0x7ffaaedcc800
    }

    public class RegexInterpreter : RegexRunner
    {
        public object _operator; // 0x34DE9BC0
        public object _caseInsensitive; // 0x34DE9BC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedcc840
        public void InitTrackCount(){} // RVA: 0x7ffaaedcc900
        public void Advance(){} // RVA: 0x7ffaaedcc930
        public void Goto(){} // RVA: 0x7ffaaedcc9b0
        public void Textto(){} // RVA: 0x7ffaa90c0cd0
        public void Trackto(){} // RVA: 0x7ffaaedcca40
        public void Textstart(){} // RVA: 0x7ffaa8b945a0
        public void Textpos(){} // RVA: 0x7ffaa8d14570
        public void Trackpos(){} // RVA: 0x7ffaaedcca60
        public void TrackPush(){} // RVA: 0x7ffaaedccbc0
        public void TrackPush(){} // RVA: 0x7ffaaedccbc0
        public void TrackPush(){} // RVA: 0x7ffaaedccbc0
        public void TrackPush(){} // RVA: 0x7ffaaedccbc0
        public void TrackPush2(){} // RVA: 0x7ffaaedccce0
        public void TrackPush2(){} // RVA: 0x7ffaaedccce0
        public void Backtrack(){} // RVA: 0x7ffaaedccd70
        public void TrackPop(){} // RVA: 0x7ffaaedcce90
        public void TrackPop(){} // RVA: 0x7ffaaedcce90
        public void TrackPeek(){} // RVA: 0x7ffaaedcced0
        public void TrackPeek(){} // RVA: 0x7ffaaedcced0
        public void StackPush(){} // RVA: 0x7ffaaedccf50
        public void StackPush(){} // RVA: 0x7ffaaedccf50
        public void StackPop(){} // RVA: 0x7ffaaedccfb0
        public void StackPop(){} // RVA: 0x7ffaaedccfb0
        public void StackPeek(){} // RVA: 0x7ffaaedccff0
        public void StackPeek(){} // RVA: 0x7ffaaedccff0
        public void Operator(){} // RVA: 0x7ffaa8c4abe0
        public void Operand(){} // RVA: 0x7ffaaedcd030
        public void Leftchars(){} // RVA: 0x7ffaaedcd080
        public void Rightchars(){} // RVA: 0x7ffaaedcd090
        public void Bump(){} // RVA: 0x7ffaaedcd0a0
        public void Forwardchars(){} // RVA: 0x7ffaaedcd0c0
        public void Forwardcharnext(){} // RVA: 0x7ffaaedcd0e0
        public void Stringmatch(){} // RVA: 0x7ffaaedcd1a0
        public void Refmatch(){} // RVA: 0x7ffaaedcd330
        public void Backwardnext(){} // RVA: 0x7ffaaedcd520
        public void CharAt(){} // RVA: 0x7ffaaedcd540
        public void FindFirstChar(){} // RVA: 0x7ffaaedcd580
        public void Go(){} // RVA: 0x7ffaaedcda20
        // ── Binary Analysis Named ──
        public void SetOperator(){} // RVA: 0x7ffaaedcce50
    }

    public class RegexNode : Object
    {
        public object Str; // 0x34CA77E0
        public object N; // 0x34CA77E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedd0980
        public void .ctor(){} // RVA: 0x7ffaaedd0980
        public void .ctor(){} // RVA: 0x7ffaaedd0980
        public void .ctor(){} // RVA: 0x7ffaaedd0980
        public void .ctor(){} // RVA: 0x7ffaaedd0980
        public void UseOptionR(){} // RVA: 0x7ffaaedd09a0
        public void ReverseLeft(){} // RVA: 0x7ffaaedd09b0
        public void MakeRep(){} // RVA: 0x7ffaaedd0a60
        public void Reduce(){} // RVA: 0x7ffaaedd0a70
        public void StripEnation(){} // RVA: 0x7ffaaedd0b80
        public void ReduceGroup(){} // RVA: 0x7ffaaedd0c30
        public void ReduceRep(){} // RVA: 0x7ffaaedd0cc0
        public void ReduceSet(){} // RVA: 0x7ffaaedd0ea0
        public void ReduceAlternation(){} // RVA: 0x7ffaaedd12d0
        public void ReduceConcatenation(){} // RVA: 0x7ffaaedd1700
        public void MakeQuantifier(){} // RVA: 0x7ffaaedd1b00
        public void AddChild(){} // RVA: 0x7ffaaedd1bf0
        public void Child(){} // RVA: 0x7ffaaedd1f10
        public void ChildCount(){} // RVA: 0x7ffaaedd1f90
        public void Type(){} // RVA: 0x7ffaa897f5c0
    }

    public class RegexParser : Object
    {
        public object _alternation; // 0x34CA4CC0
        public object _pattern; // 0x34CA4CC0
        public object _autocap; // 0x34CA4CC0
        public object _capsize; // 0x34CA4CC0
        public object _capnumlist; // 0x34CA4CC0
        public object _optionsStack; // 0x34CA4CC0
        public object `;
        public object ComputeStringHash; // 0xB41EA1F0

        // ── Original Methods ──
        public void Parse(){} // RVA: 0x7ffaaedd1fe0
        public void ParseReplacement(){} // RVA: 0x7ffaaedd22d0
        public void Escape(){} // RVA: 0x7ffaaedd2500
        public void Unescape(){} // RVA: 0x7ffaaedd2730
        public void .ctor(){} // RVA: 0x7ffaaedd2910
        public void Reset(){} // RVA: 0x7ffaaedd2b60
        public void ScanRegex(){} // RVA: 0x7ffaaedd2c90
        public void ScanReplacement(){} // RVA: 0x7ffaaedd3540
        public void ScanCharClass(){} // RVA: 0x7ffaaedd37b0
        public void ScanGroupOpen(){} // RVA: 0x7ffaaedd4070
        public void ScanBlank(){} // RVA: 0x7ffaaedd4cb0
        public void ScanBackslash(){} // RVA: 0x7ffaaedd5040
        public void ScanBasicBackslash(){} // RVA: 0x7ffaaedd5620
        public void ScanDollar(){} // RVA: 0x7ffaaedd5ce0
        public void ScanCapname(){} // RVA: 0x7ffaaedd6110
        public void ScanOctal(){} // RVA: 0x7ffaaedd61e0
        public void ScanDecimal(){} // RVA: 0x7ffaaedd6280
        public void ScanHex(){} // RVA: 0x7ffaaedd6330
        public void HexDigit(){} // RVA: 0x7ffaaedd6460
        public void ScanControl(){} // RVA: 0x7ffaaedd6490
        public void IsOnlyTopOption(){} // RVA: 0x7ffaaedd6570
        public void ScanOptions(){} // RVA: 0x7ffaaedd6590
        public void ScanCharEscape(){} // RVA: 0x7ffaaedd66b0
        public void ParseProperty(){} // RVA: 0x7ffaaedd6a70
        public void TypeFromCode(){} // RVA: 0x7ffaaedd6c60
        public void OptionFromCode(){} // RVA: 0x7ffaaedd6ce0
        public void CountCaptures(){} // RVA: 0x7ffaaedd6d70
        public void NoteCaptureSlot(){} // RVA: 0x7ffaaedd7110
        public void NoteCaptureName(){} // RVA: 0x7ffaaedd7220
        public void NoteCaptures(){} // RVA: 0x7ffaaedd7480
        public void AssignNameSlots(){} // RVA: 0x7ffaaedd7540
        public void CaptureSlotFromName(){} // RVA: 0x7ffaaedd7dc0
        public void IsCaptureSlot(){} // RVA: 0x7ffaaedd7e50
        public void IsCaptureName(){} // RVA: 0x7ffaaedd7ef0
        public void UseOptionN(){} // RVA: 0x7ffaaedd7f20
        public void UseOptionI(){} // RVA: 0x7ffaaedd7f30
        public void UseOptionM(){} // RVA: 0x7ffaaedd7f40
        public void UseOptionS(){} // RVA: 0x7ffaaedd7f50
        public void UseOptionX(){} // RVA: 0x7ffaaedd7f60
        public void UseOptionE(){} // RVA: 0x7ffaaedd7f70
        public void IsSpecial(){} // RVA: 0x7ffaaedd7f80
        public void IsStopperX(){} // RVA: 0x7ffaaedd8010
        public void IsQuantifier(){} // RVA: 0x7ffaaedd80a0
        public void IsTrueQuantifier(){} // RVA: 0x7ffaaedd8130
        public void IsSpace(){} // RVA: 0x7ffaaedd82d0
        public void IsMetachar(){} // RVA: 0x7ffaaedd8360
        public void AddConcatenate(){} // RVA: 0x7ffaaedd8dc0
        public void PushGroup(){} // RVA: 0x7ffaaedd86f0
        public void PopGroup(){} // RVA: 0x7ffaaedd8880
        public void EmptyStack(){} // RVA: 0x7ffaa8f6d110
        public void StartGroup(){} // RVA: 0x7ffaaedd8ac0
        public void AddAlternate(){} // RVA: 0x7ffaaedd8c40
        public void AddConcatenate(){} // RVA: 0x7ffaaedd8dc0
        public void AddConcatenate(){} // RVA: 0x7ffaaedd8dc0
        public void Unit(){} // RVA: 0x7ffaa8bfcc80
        public void AddUnitOne(){} // RVA: 0x7ffaaedd8f30
        public void AddUnitNotone(){} // RVA: 0x7ffaaedd9040
        public void AddUnitSet(){} // RVA: 0x7ffaaedd9150
        public void AddUnitNode(){} // RVA: 0x7ffaa8960890
        public void AddUnitType(){} // RVA: 0x7ffaaedd9260
        public void AddGroup(){} // RVA: 0x7ffaaedd9320
        public void PushOptions(){} // RVA: 0x7ffaaedd94e0
        public void PopOptions(){} // RVA: 0x7ffaaedd9580
        public void EmptyOptionsStack(){} // RVA: 0x7ffaaedd9640
        public void PopKeepOptions(){} // RVA: 0x7ffaaedd9690
        public void MakeException(){} // RVA: 0x7ffaaedd9700
        public void Textpos(){} // RVA: 0x7ffaa89d3080
        public void Textto(){} // RVA: 0x7ffaa89d3090
        public void RightCharMoveRight(){} // RVA: 0x7ffaaedd9790
        public void MoveRight(){} // RVA: 0x7ffaaedd97e0
        public void MoveRight(){} // RVA: 0x7ffaaedd97e0
        public void MoveLeft(){} // RVA: 0x7ffaaedd97f0
        public void CharAt(){} // RVA: 0x7ffaaedd9800
        public void RightChar(){} // RVA: 0x7ffaaedd9880
        public void RightChar(){} // RVA: 0x7ffaaedd9880
        public void CharsRight(){} // RVA: 0x7ffaaedd98c0
        public void .cctor(){} // RVA: 0x7ffaaedd98e0
        // ── Binary Analysis Named ──
        public void SetPattern(){} // RVA: 0x7ffaaedd2ab0
    }

    public class RegexPrefix : ValueType
    {
        public object _prefix; // 0x34CA7C60, was: <Prefix>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedd99c0
        public void get_CaseInsensitive(){} // RVA: 0x7ffaaa365870
        public void get_Empty(){} // RVA: 0x7ffaaedd9a20
        public void get_Prefix(){} // RVA: 0x7ffaa9e47540
        public void .cctor(){} // RVA: 0x7ffaaedd9a80
    }

    public class RegexReplacement : Object
    {
        public object RightPortion; // 0x34D681B0
        public object _strings; // 0x34D681B0
        public object aGM; // 0x20120000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedd9ba0
        public void get_Pattern(){} // RVA: 0x7ffaa89600c0
        public void ReplacementImpl(){} // RVA: 0x7ffaaedda220
        public void ReplacementImplRTL(){} // RVA: 0x7ffaaedda470
        public void Replacement(){} // RVA: 0x7ffaaedda6a0
        public void Replace(){} // RVA: 0x7ffaaedda920
        // ── Binary Analysis Named ──
        public void GetOrCreate(){} // RVA: 0x7ffaaedda0d0
    }

    public class RegexRunner : Object
    {
        public object runtextstart; // 0x34DE9D70
        public object runtrack; // 0x34DE9D70
        public object runstackpos; // 0x34DE9D70
        public object runtrackcount; // 0x34DE9D70
        public object _timeout; // 0x34DE9D70
        public object TimeoutCheckFrequency; // 0x34DE9D70

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Scan(){} // RVA: 0x7ffaaeddb180
        public void StartTimeoutWatch(){} // RVA: 0x7ffaaeddb530
        public void Go(){} // RVA: 0x7ffaa8660cc0
        public void FindFirstChar(){} // RVA: 0x7ffaa864a040
        public void InitTrackCount(){} // RVA: 0x7ffaa8660cc0
        public void InitMatch(){} // RVA: 0x7ffaaeddb720
        public void TidyMatch(){} // RVA: 0x7ffaaeddbbb0
        public void EnsureStorage(){} // RVA: 0x7ffaaeddbc60
        public void IsBoundary(){} // RVA: 0x7ffaaeddbe60
        public void IsECMABoundary(){} // RVA: 0x7ffaaeddbf70
        public void Crawl(){} // RVA: 0x7ffaaeddc350
        public void Popcrawl(){} // RVA: 0x7ffaaeddc480
        public void Crawlpos(){} // RVA: 0x7ffaaeddc4c0
        public void Capture(){} // RVA: 0x7ffaaeddc4e0
        public void TransferCapture(){} // RVA: 0x7ffaaeddc570
        public void Uncapture(){} // RVA: 0x7ffaaeddc6a0
        public void IsMatched(){} // RVA: 0x7ffaaeddc6f0
        public void MatchIndex(){} // RVA: 0x7ffaaeddc720
        public void MatchLength(){} // RVA: 0x7ffaaeddc750
        // ── Binary Analysis Named ──
        public void CheckTimeout(){} // RVA: 0x7ffaaeddb560
        public void DoCheckTimeout(){} // RVA: 0x7ffaaeddb640
        public void DoubleTrack(){} // RVA: 0x7ffaaeddc080
        public void DoubleStack(){} // RVA: 0x7ffaaeddc170
        public void DoubleCrawl(){} // RVA: 0x7ffaaeddc260
    }

    public class RegexRunnerFactory : Object
    {
        // ── Original Methods ──
        public void CreateInstance(){} // RVA: 0x7ffaa86491d0
    }

    public class RegexTree : Object
    {
        public object CapNumList; // 0x34CA5D40
        public object CapsList; // 0x34CA5D40

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaeddc780
    }

}